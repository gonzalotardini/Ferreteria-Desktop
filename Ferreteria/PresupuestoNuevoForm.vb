Imports Entidades
Imports dal
Imports BLL


Public Class PresupuestoNuevoForm




    Private Sub PresupuestoNuevoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        ComprobanteRadioButton.Checked = True
        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        ArticulosGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)


        Dim PresupuestoMetodos As New PresupuestoMetodos


        TextBoxFecha.Text = CStr(Today)

        LabelCodPresupuesto.Text = CStr((PresupuestoMetodos.ObtenerCodUltimoPresupuesto.Cod_Presupuesto) + 1)



        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells 'sirve para que el ancho de las columnas se acomode automaticamente

        LabelTOTAL.Text = CStr(0)

        '  Label7.Text = DataGridView1.RowCount






        'Cargo todos los articulos en la grilla de articulos


        Dim ArticulosDal As New ArticulosMetodos



        ArticulosGridView.DataSource = ArticulosDal.ObtenerPrimerosArticulos.Tables(0)

        RadioButtonDESCRIPCION.Select()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
        TextBoxBuscar.Focus()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ClientesForm.Show()
    End Sub


    Public Sub TraerCliente(Cliente As Cliente)
        TextBoxCuit.Text = CStr(Cliente.Cuit)
        TextBoxNombre.Text = Cliente.Razon_Social
    End Sub

    Private b As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FinalizarPresupuestoButton.Click



        Try

            If MsgBox("Seguro desea finalizar presupuesto", vbYesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

                Dim PresupuestoMetodos As New PresupuestoMetodos
                Dim PresupuestoCabecera As New PresupuestoCabecera
                Dim presupuestoDetalle As PresupuestoDetalle
                Dim ListaDetalle As New List(Of PresupuestoDetalle)
                Dim PresupuestoBLL As New PresupuestoBLL

                Dim CantidadItems As Integer
                Dim i As Integer

                CantidadItems = DataGridView1.RowCount


                'PresupuestoCabecera.Cod_Cliente = TextBoxCuit.Text
                PresupuestoCabecera.Nombre = TextBoxNombre.Text.ToUpper
                PresupuestoCabecera.Fecha = CDate(TextBoxFecha.Text)
                PresupuestoCabecera.Total = Convert.ToDecimal(LabelTOTAL.Text)
                PresupuestoCabecera.Cod_Presupuesto = CStr((PresupuestoMetodos.ObtenerCodUltimoPresupuesto.Cod_Presupuesto) + 1) + b

                ' PresupuestoMetodos.CrearNuevoPresupuestoCabecera(PresupuestoCabecera)


                For i = 0 To (CantidadItems - 1)
                    presupuestoDetalle = New PresupuestoDetalle

                    presupuestoDetalle.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
                    presupuestoDetalle.Cantidad = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
                    presupuestoDetalle.Cod_Articulo = CStr(DataGridView1.Rows(i).Cells("Codigo").Value)
                    presupuestoDetalle.Descripcion = (DataGridView1.Rows(i).Cells("Descripcion").Value).ToString().ToUpper()
                    presupuestoDetalle.Precio = CDec(DataGridView1.Rows(i).Cells("Precio").Value)
                    presupuestoDetalle.Importe = CDec(DataGridView1.Rows(i).Cells("Importe").Value)

                    ListaDetalle.Add(presupuestoDetalle)
                    'PresupuestoMetodos.CrearNuevoPresupuestoDetalle(presupuestoDetalle)
                Next


                PresupuestoBLL.AgregarPresupuestoCompleto(PresupuestoCabecera, ListaDetalle)

                MsgBox("Presupuesto guardado correctamente", MsgBoxStyle.Information, "Información")

                '  PresupuestosForm.Close()
                '  PresupuestosForm.Show()



                If MsgBox("¿Desea imprimir el presupuesto?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then


                    Dim PresupuestoCabecera2 As New PresupuestoCabecera

                    Dim _GrillaPresupuesto2 As GrillaPresupuesto
                    Dim _ListaDetalle2 As New List(Of GrillaPresupuesto)
                    Dim CantidadItems2 As Integer = DataGridView1.RowCount
                    Dim PresupuestoMetodos2 As New PresupuestoMetodos
                    Dim bandera As Integer


                    For i = 0 To (CantidadItems - 1)

                        _GrillaPresupuesto2 = New GrillaPresupuesto

                        ' _GrillaPresupuesto.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
                        _GrillaPresupuesto2.Cantidad = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
                        _GrillaPresupuesto2.Descripcion = Microsoft.VisualBasic.Left(CStr((DataGridView1.Rows(i).Cells("Descripcion").Value)), 40)
                        _GrillaPresupuesto2.Marca = CStr(DataGridView1.Rows(i).Cells("Marca").Value)
                        _GrillaPresupuesto2.Medida = CStr(DataGridView1.Rows(i).Cells("UnidadMedida").Value)
                        _GrillaPresupuesto2.Codigo = CLng(DataGridView1.Rows(i).Cells("Codigo").Value)
                        _GrillaPresupuesto2.Precio = CDec(DataGridView1.Rows(i).Cells("Precio").Value)
                        _GrillaPresupuesto2.Importe = CDec(DataGridView1.Rows(i).Cells("Importe").Value)




                        _ListaDetalle2.Add(_GrillaPresupuesto2)




                        If ComprobanteRadioButton.Checked = True Then
                            Bandera = 1
                        Else
                            Bandera = 0
                        End If




                    Next
                    PresupuestoCabecera2.Fecha = CDate(TextBoxFecha.Text)
                    PresupuestoCabecera2.Total = CDec(LabelTOTAL.Text)
                    PresupuestoCabecera2.Nombre = (TextBoxNombre.Text).ToUpper

                    PresupuestoMetodos2.GenerarPresupuestoPDF(_ListaDetalle2, PresupuestoCabecera2, Bandera)




                End If












                If DataGridView1.CurrentRow IsNot Nothing Then



                    DataGridView1.Rows.Clear()






                    LabelTOTAL.Text = CStr(0)
                    SubTotalLabel.Text = 0
                    TextBoxNombre.Text = ""

                End If



                TextBoxBuscar.Text = ""
                Me.Show()
                TextBoxBuscar.Focus()

                LabelCodPresupuesto.Text = CStr((PresupuestoMetodos.ObtenerCodUltimoPresupuesto.Cod_Presupuesto) + 1)

                b = 0

            End If





        Catch ex As Exception

            
            MsgBox(ex.Message)


        End Try




    End Sub

    

    Private Sub QuitarButton_Click(sender As Object, e As EventArgs) Handles QuitarButton.Click

        Dim PresupuestoDetalle As New PresupuestoDetalle
        Dim PresupuestoCabecera As New PresupuestoCabecera
        Dim PresupuestoMetodos As New PresupuestoMetodos
        Dim cantidadFilas As Integer



        If DataGridView1.CurrentRow IsNot Nothing Then

            ' saco del presupuesto el articulo
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            cantidadFilas = DataGridView1.RowCount


            Dim total As Decimal
            For i = 0 To cantidadFilas - 1

                PresupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)


                total = total + PresupuestoDetalle.Importe




            Next



            LabelTOTAL.Text = CStr(total)
            SubTotalLabel.Text = FormatNumber((total / 1.21), 2)


        End If




        Me.Show()
        TextBoxBuscar.Focus()

    End Sub

   

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown

        Dim Bandera As Integer = 0
        Dim CantidadFilas As Integer

        If RadioButtonCODIGO.Checked = True Then

            Dim articulo As New Articulo
            Dim articuloMetodos As New ArticulosMetodos

            Select e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBoxBuscar.Text)
                        ArticulosGridView.DataSource = articuloMetodos.BuscarArticuloPorCodigoBarras(articulo).Tables(0)

                        TextBoxBuscar.SelectAll()
                        

                        For Each row As DataGridViewRow In ArticulosGridView.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next


                        If (ArticulosGridView.RowCount - 1) = 1 Then
                            'Dim Articulo As New Articulo
                            'Dim ArticuloMetodos As New ArticulosMetodos
                            ' Dim CantidadFilas As Integer
                            Dim ArticuloParaPresupuesto As New ArticuloParaPresupuesto

                            Dim Marca As New Marca
                            Dim SubUnidad_Medida As New SubUnidad_Medida


                            Dim presupuestoDetalle As New PresupuestoDetalle
                            Dim PresupuestoCabecera As New PresupuestoCabecera
                            Dim PresupuestoMetodos As New PresupuestoMetodos


                            CantidadFilas = DataGridView1.RowCount





                            'If PresupuestoNuevoForm.Visible = True Then



                            articulo.Cod_Articulo = CInt(ArticulosGridView.CurrentRow.Cells(0).Value)


                            ArticuloParaPresupuesto = articuloMetodos.BuscarArticuloPorCodigo(articulo)



                            'Articulo.Cod_Articulo = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Codigo")
                            articulo.Cod_Articulo = CInt(ArticuloParaPresupuesto.Cod_Articulo)
                            articulo.Cod_Articulo_Proveedor = ArticuloParaPresupuesto.Cod_Articulo_Proveedor
                            articulo.Descripcion = ArticuloParaPresupuesto.Descripcion
                            Marca.Descripcion = ArticuloParaPresupuesto.Marca
                            SubUnidad_Medida.Descripcion_SubUnidad = ArticuloParaPresupuesto.SubUnidad_Medida
                            articulo.Precio = Convert.ToDecimal(ArticuloParaPresupuesto.Precio)


                            'Articulo.Cod_Articulo = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Codigo")
                            'Articulo.Cod_Articulo_Proveedor = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("CodigoBarras")
                            'Articulo.Descripcion = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Descripcion")
                            'Marca.Descripcion = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Marca")
                            'SubUnidad_Medida.Descripcion_SubUnidad = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Sub Unidad")
                            'Articulo.Precio = Convert.ToDecimal(ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Precio"))



                            'presupuestoDetalle.Cantidad = -1

                            Dim RespuestaInputBox As String
                            ' Dim EsNumero As Boolean

                            RespuestaInputBox = InputBox("Introduza cantidad", "ATENCIÓN", CStr(1))

                            EsNumero = IsNumeric(RespuestaInputBox)

                            If EsNumero = True Then


                                If RespuestaInputBox.Contains(".") = True Then

                                    RespuestaInputBox = Replace(RespuestaInputBox, ".", ",")

                                Else


                                End If


                                presupuestoDetalle.Cantidad = Convert.ToDecimal(RespuestaInputBox)

                                DataGridView1.Rows.Add()
                                DataGridView1.Item("Cantidad", CantidadFilas).Value = presupuestoDetalle.Cantidad
                                DataGridView1.Item("Codigo", CantidadFilas).Value = articulo.Cod_Articulo
                                DataGridView1.Item("CodigoBarras", CantidadFilas).Value = articulo.Cod_Articulo_Proveedor
                                DataGridView1.Item("Descripcion", CantidadFilas).Value = articulo.Descripcion
                                DataGridView1.Item("Marca", CantidadFilas).Value = Marca.Descripcion
                                DataGridView1.Item("UnidadMedida", CantidadFilas).Value = SubUnidad_Medida.Descripcion_SubUnidad
                                DataGridView1.Item("Precio", CantidadFilas).Value = articulo.Precio

                                presupuestoDetalle.Importe = ((DataGridView1.Item("Cantidad", CantidadFilas).Value) * articulo.Precio)




                                DataGridView1.Item("Importe", CantidadFilas).Value = FormatNumber(Convert.ToDecimal(presupuestoDetalle.Importe))




                                'Dim Total As Decimal

                                For i = 0 To CantidadFilas

                                    presupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)




                                    PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera)

                                    PresupuestoCabecera.Total = PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera).Total
                                Next


                                LabelTOTAL.Text = CStr(PresupuestoCabecera.Total)
                                SubTotalLabel.Text = FormatNumber((PresupuestoCabecera.Total / 1.21), 2)

                                TextBoxBuscar.Text = ""
                                Me.Show()
                                TextBoxBuscar.Focus()


                            Else
                            End If
                        End If
                    Else
                        Bandera = 1

                    End If

            End Select








        End If

        If RadioButtonDESCRIPCION.Checked = True Or Bandera = 1 Then

            Dim articulo2 As New Articulo
            Dim articuloMetodos2 As New ArticulosMetodos

            Select Case e.KeyData

                Case Keys.Enter


                    articuloMetodos2.BuscarArticuloPorNombre(articulo2)


                    articulo2.Descripcion = (TextBoxBuscar.Text).ToUpper
                    ArticulosGridView.DataSource = articuloMetodos2.BuscarArticuloPorNombre(articulo2).Tables(0)



                    For Each row As DataGridViewRow In ArticulosGridView.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    Bandera = 0

                    RadioButtonDESCRIPCION.Checked = True

            End Select


        End If




    End Sub






    Private Sub ArticulosGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellDoubleClick




        Dim Articulo As New Articulo
        Dim ArticuloMetodos As New ArticulosMetodos
        Dim CantidadFilas As Integer
        Dim ArticuloParaPresupuesto As New ArticuloParaPresupuesto

        Dim Marca As New Marca
        Dim SubUnidad_Medida As New SubUnidad_Medida
        Dim bandera As Integer = 0
        Dim indice As Integer


        Dim presupuestoDetalle As New PresupuestoDetalle
        Dim PresupuestoCabecera As New PresupuestoCabecera
        Dim PresupuestoMetodos As New PresupuestoMetodos


        CantidadFilas = DataGridView1.RowCount





        'If PresupuestoNuevoForm.Visible = True Then

        If ArticulosGridView.CurrentRow.Index < (ArticulosGridView.RowCount) - 1 Then

            Articulo.Cod_Articulo = CInt(ArticulosGridView.CurrentRow.Cells(0).Value)


            ArticuloParaPresupuesto = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo)



            'Articulo.Cod_Articulo = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Codigo")
            Articulo.Cod_Articulo = CInt(ArticuloParaPresupuesto.Cod_Articulo)
            Articulo.Cod_Articulo_Proveedor = ArticuloParaPresupuesto.Cod_Articulo_Proveedor
            Articulo.Descripcion = ArticuloParaPresupuesto.Descripcion
            Marca.Descripcion = ArticuloParaPresupuesto.Marca
            SubUnidad_Medida.Descripcion_SubUnidad = ArticuloParaPresupuesto.SubUnidad_Medida
            Articulo.Precio = Convert.ToDecimal(ArticuloParaPresupuesto.Precio)



            Dim RespuestaInputBox As String
            Dim EsNumero As Boolean

            RespuestaInputBox = InputBox("Introduza cantidad", "ATENCIÓN", CStr(1))

            EsNumero = IsNumeric(RespuestaInputBox)

            If EsNumero = True Then


                If RespuestaInputBox.Contains(".") = True Then

                    RespuestaInputBox = Replace(RespuestaInputBox, ".", ",")

                Else


                End If

                For Each row As DataGridViewRow In Me.DataGridView1.Rows

                    If Articulo.Cod_Articulo = row.Cells(1).Value Then

                        RespuestaInputBox = RespuestaInputBox + row.Cells(0).Value
                        row.Cells(0).Value = RespuestaInputBox
                        bandera = 1
                        indice = row.Index

                    End If



                Next



                presupuestoDetalle.Cantidad = Convert.ToDecimal(RespuestaInputBox)

                If bandera = 0 Then
                    DataGridView1.Rows.Add()
                    DataGridView1.Item("Cantidad", CantidadFilas).Value = presupuestoDetalle.Cantidad
                    DataGridView1.Item("Codigo", CantidadFilas).Value = Articulo.Cod_Articulo
                    DataGridView1.Item("CodigoBarras", CantidadFilas).Value = Articulo.Cod_Articulo_Proveedor
                    DataGridView1.Item("Descripcion", CantidadFilas).Value = Articulo.Descripcion
                    DataGridView1.Item("Marca", CantidadFilas).Value = Marca.Descripcion
                    DataGridView1.Item("UnidadMedida", CantidadFilas).Value = SubUnidad_Medida.Descripcion_SubUnidad
                    DataGridView1.Item("Precio", CantidadFilas).Value = Articulo.Precio

                    presupuestoDetalle.Importe = (DataGridView1.Item("Cantidad", CantidadFilas).Value) * Articulo.Precio




                    DataGridView1.Item("Importe", CantidadFilas).Value = FormatNumber(Convert.ToDecimal(presupuestoDetalle.Importe))

                Else

                    DataGridView1.Item("Cantidad", indice).Value = presupuestoDetalle.Cantidad
                    presupuestoDetalle.Importe = (DataGridView1.Item("Cantidad", indice).Value) * Articulo.Precio




                    DataGridView1.Item("Importe", indice).Value = FormatNumber(Convert.ToDecimal(presupuestoDetalle.Importe))
                End If


                'Dim Total As Decimal

                CantidadFilas = DataGridView1.RowCount

                For i = 0 To CantidadFilas - 1


                    presupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)




                    '  PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera)

                    PresupuestoCabecera.Total = PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera).Total







                Next



                LabelTOTAL.Text = CStr(PresupuestoCabecera.Total)
                SubTotalLabel.Text = FormatNumber((PresupuestoCabecera.Total / 1.21), 2)


                TextBoxBuscar.Text = ""
                Me.Show()
                TextBoxBuscar.Focus()


            Else
            End If



        Else
        End If




    End Sub

    Private Sub ArticulosGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellContentClick
        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ArticulosGridView_Sorted(sender As Object, e As EventArgs) Handles ArticulosGridView.Sorted
        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub RadioButtonCODIGO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCODIGO.CheckedChanged

        If RadioButtonCODIGO.Checked = True Then
            TextBoxBuscar.Text = ""
            Me.Show()
            TextBoxBuscar.Focus()


        End If

        If RadioButtonDESCRIPCION.Checked = True Then
            Me.Show()
            TextBoxBuscar.Focus()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxBuscar.Text = ""
        Me.Show()
        TextBoxBuscar.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)


    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub RadioButtonDESCRIPCION_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDESCRIPCION.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click





        If MsgBox("¿Seguro desea imprimir?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Dim PresupuestoCabecera As New PresupuestoCabecera

            Dim _GrillaPresupuesto As GrillaPresupuesto
            Dim _ListaDetalle As New List(Of GrillaPresupuesto)
            Dim CantidadItems As Integer = DataGridView1.RowCount
            Dim PresupuestoMetodos As New PresupuestoMetodos

            For i = 0 To (CantidadItems - 1)

                _GrillaPresupuesto = New GrillaPresupuesto

                ' _GrillaPresupuesto.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
                _GrillaPresupuesto.Cantidad = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
                _GrillaPresupuesto.Descripcion = Microsoft.VisualBasic.Left(CStr((DataGridView1.Rows(i).Cells("Descripcion").Value)), 40)
                _GrillaPresupuesto.Marca = CStr(DataGridView1.Rows(i).Cells("Marca").Value)
                _GrillaPresupuesto.Medida = CStr(DataGridView1.Rows(i).Cells("UnidadMedida").Value)
                _GrillaPresupuesto.Codigo = CLng(DataGridView1.Rows(i).Cells("Codigo").Value)
                _GrillaPresupuesto.Precio = CDec(DataGridView1.Rows(i).Cells("Precio").Value)
                _GrillaPresupuesto.Importe = CDec(DataGridView1.Rows(i).Cells("Importe").Value)




                _ListaDetalle.Add(_GrillaPresupuesto)





            Next
            PresupuestoCabecera.Fecha = CDate(TextBoxFecha.Text)
            PresupuestoCabecera.Total = CDec(LabelTOTAL.Text)
            PresupuestoCabecera.Nombre = (TextBoxNombre.Text).ToUpper


            Dim Bandera As Integer


            If ComprobanteRadioButton.Checked = True Then
                Bandera = 1
            Else
                Bandera = 0
            End If



            PresupuestoMetodos.GenerarPresupuestoPDF(_ListaDetalle, PresupuestoCabecera, Bandera)

            TextBoxNombre.Text = ""

        Else
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       




        If DataGridView1.CurrentRow IsNot Nothing Then

            

            DataGridView1.Rows.Clear()






            LabelTOTAL.Text = CStr(0)
            SubTotalLabel.Text = 0


        End If



        TextBoxBuscar.Text = ""
        Me.Show()
        TextBoxBuscar.Focus()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cantidadFilas As Integer
        Dim PresupuestoDetalle As New PresupuestoDetalle

        DataGridView1.Rows.Add()

        cantidadFilas = (DataGridView1.RowCount) - 1

        DataGridView1.Rows(cantidadFilas).Cells(0).Value = 1
        DataGridView1.Rows(cantidadFilas).Cells(1).Value = 10201
        DataGridView1.Rows(cantidadFilas).Cells(2).Value = 1
        DataGridView1.Rows(cantidadFilas).Cells(4).Value = "SIN MARCA"
        DataGridView1.Rows(cantidadFilas).Cells(5).Value = "1 U"
        DataGridView1.Rows(cantidadFilas).Cells(6).Value = 1
        DataGridView1.Rows(cantidadFilas).Cells(7).Value = 1

        Dim total As Decimal
        For i = 0 To cantidadFilas
            PresupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)
            total = total + PresupuestoDetalle.Importe
        Next

        LabelTOTAL.Text = CStr(total)
        SubTotalLabel.Text = FormatNumber((total / 1.21), 2)


    End Sub

    Private Sub DataGridView1_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles DataGridView1.CellContextMenuStripNeeded

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        


        Dim PresupuestoDetalle As New PresupuestoDetalle
        Dim PresupuestoCabecera As New PresupuestoCabecera
        Dim PresupuestoMetodos As New PresupuestoMetodos
        Dim cantidadFilas As Integer

        Dim cantidad As Decimal
        Dim precio As Decimal
        Dim importe As Decimal
        Dim fila As Integer


        fila = DataGridView1.CurrentRow.Index
        cantidadFilas = DataGridView1.RowCount

        cantidad = CDec(DataGridView1.Rows(fila).Cells(0).Value)
        precio = CDec(DataGridView1.Rows(fila).Cells(6).Value)

        importe = cantidad * precio
        DataGridView1.Rows(fila).Cells(7).Value = importe

        Dim total As Decimal
        For i = 0 To cantidadFilas - 1

            

            PresupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)


            total = total + PresupuestoDetalle.Importe
            SubTotalLabel.Text = FormatNumber((total / 1.21), 2)



        Next

        Dim _Descripcion As String

        LabelTOTAL.Text = CStr(total)

        _Descripcion = DataGridView1.Rows(fila).Cells(3).Value

        If _Descripcion <> "" Then

            DataGridView1.Rows(fila).Cells(3).Value = _Descripcion.ToUpper


        End If

       




        Me.Show()
        TextBoxBuscar.Focus()



    End Sub

    
    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub TextBoxBuscar_TabStopChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TabStopChanged

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

  
    Public ListaDetalle As New List(Of PresupuestoDetalle)
    

    Private Sub Button5_Click(sender As Object, e As EventArgs)


        Dim PresupuestoMetodos As New PresupuestoMetodos
        Dim PresupuestoCabecera As New PresupuestoCabecera
        Dim presupuestoDetalle As PresupuestoDetalle
        ' Dim ListaDetalle As New List(Of PresupuestoDetalle)
        Dim PresupuestoBLL As New PresupuestoBLL

        Dim CantidadItems As Integer
        Dim i As Integer








        CantidadItems = DataGridView1.RowCount


        'PresupuestoCabecera.Cod_Cliente = TextBoxCuit.Text
        '   PresupuestoCabecera.Nombre = TextBoxNombre.Text.ToUpper
        '  PresupuestoCabecera.Fecha = CDate(TextBoxFecha.Text)
        '  PresupuestoCabecera.Total = Convert.ToDecimal(LabelTOTAL.Text)
        '  PresupuestoCabecera.Cod_Presupuesto = CStr((PresupuestoMetodos.ObtenerCodUltimoPresupuesto.Cod_Presupuesto) + 1) + b

        ' PresupuestoMetodos.CrearNuevoPresupuestoCabecera(PresupuestoCabecera)


        For i = 0 To (CantidadItems - 1)

            presupuestoDetalle = New PresupuestoDetalle

            presupuestoDetalle.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
            presupuestoDetalle.Cantidad = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
            presupuestoDetalle.Cod_Articulo = CStr(DataGridView1.Rows(i).Cells("Codigo").Value)
            presupuestoDetalle.Precio = CDec(DataGridView1.Rows(i).Cells("Precio").Value)
            presupuestoDetalle.Importe = CDec(DataGridView1.Rows(i).Cells("Importe").Value)




            ListaDetalle.Add(presupuestoDetalle)



            'PresupuestoMetodos.CrearNuevoPresupuestoDetalle(presupuestoDetalle)



        Next


        PresupuestosForm.Show()

        PresupuestosForm.AgregarButton.Enabled = True



    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        PresupuestosForm.Show()
    End Sub

    Private Sub GenerarPDFButton_Click(sender As Object, e As EventArgs) Handles GenerarPDFButton.Click


        If MsgBox("¿Seguro desea generar PDF?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Dim PresupuestoCabecera As New PresupuestoCabecera

            Dim _GrillaPresupuesto As GrillaPresupuesto
            Dim _ListaDetalle As New List(Of GrillaPresupuesto)
            Dim CantidadItems As Integer = DataGridView1.RowCount
            Dim PresupuestoMetodos As New PresupuestoMetodos

            For i = 0 To (CantidadItems - 1)

                _GrillaPresupuesto = New GrillaPresupuesto

                ' _GrillaPresupuesto.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
                _GrillaPresupuesto.Cantidad = CDec(DataGridView1.Rows(i).Cells("Cantidad").Value)
                _GrillaPresupuesto.Descripcion = Microsoft.VisualBasic.Left(CStr((DataGridView1.Rows(i).Cells("Descripcion").Value)), 40)
                _GrillaPresupuesto.Marca = CStr(DataGridView1.Rows(i).Cells("Marca").Value)
                _GrillaPresupuesto.Medida = CStr(DataGridView1.Rows(i).Cells("UnidadMedida").Value)
                _GrillaPresupuesto.Codigo = CLng(DataGridView1.Rows(i).Cells("Codigo").Value)
                _GrillaPresupuesto.Precio = CDec(DataGridView1.Rows(i).Cells("Precio").Value)
                _GrillaPresupuesto.Importe = CDec(DataGridView1.Rows(i).Cells("Importe").Value)




                _ListaDetalle.Add(_GrillaPresupuesto)





            Next
            PresupuestoCabecera.Fecha = CDate(TextBoxFecha.Text)
            PresupuestoCabecera.Total = CDec(LabelTOTAL.Text)
            PresupuestoCabecera.Nombre = (TextBoxNombre.Text).ToUpper


            Dim Bandera As Integer


            If ComprobanteRadioButton.Checked = True Then
                Bandera = 1
            Else
                Bandera = 0
            End If



            PresupuestoMetodos.GenerarPdf(_ListaDetalle, PresupuestoCabecera, Bandera)

            TextBoxNombre.Text = ""

        Else
        End If


    End Sub
End Class