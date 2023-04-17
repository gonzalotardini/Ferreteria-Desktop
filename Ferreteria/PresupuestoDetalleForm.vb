Imports Entidades
Imports dal
Imports BLL


Public Class PresupuestoDetalleForm









    Public PresupuestoP As New PresupuestoCabecera

    Private Sub PresupuestoDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.icono
        Dim PresupuestoMetodos As New PresupuestoMetodos
        Dim PresupuestoCabecera As New PresupuestoCabecera
        Dim cliente As New Cliente
        Dim Articulosdal As New ArticulosMetodos


        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        ArticulosGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)

        ComprobanteRadioButton.Checked = True


        PresupuestoCabecera.Cod_Presupuesto = PresupuestoP.Cod_Presupuesto

        Dim row As DataRow = PresupuestoMetodos.ObtenerPresupuestoCabecera(PresupuestoCabecera).Tables(0).Rows(0)

        PresupuestoCabecera.Nombre = row.Item("Nombre")
        PresupuestoCabecera.Fecha = row.Item("Fecha")
        PresupuestoCabecera.Cod_Presupuesto = row.Item("Cod_Presupuesto")
        ' cliente.Razon_Social = PresupuestoMetodos.ObtenerPresupuestoCabecera(PresupuestoCabecera).Tables(0).Rows(0).Item("Razon_Social")
        PresupuestoCabecera.Total = row.Item("Total")

        LabelCodPresupuesto.Text = PresupuestoCabecera.Cod_Presupuesto
        TextBoxFecha.Text = PresupuestoCabecera.Fecha
        'TextBoxCuit.Text = PresupuestoCabecera.Cod_Cliente
        TextBoxNombre.Text = PresupuestoCabecera.Nombre
        LabelTOTAL.Text = PresupuestoCabecera.Total

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        DataGridView1.DataSource = PresupuestoMetodos.ObtenerPresupuestoDetalle(PresupuestoCabecera).Tables(0)



        TextBox1.Text = DataGridView1.RowCount



        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir




        ArticulosGridView.Enabled = False
        QuitarButton.Enabled = False
        GroupBox1.Enabled = False
        FinalizarButton.Enabled = False
        RadioButtonDESCRIPCION.Checked = True

        


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim CantidadFilas As Integer
        Dim i As Integer = 0
        Dim Importe As Decimal
        Dim total As Decimal


        Dim EsNulo As Boolean




        CantidadFilas = DataGridView1.RowCount



        For i = 0 To (CantidadFilas - 1)

            EsNulo = IsNumeric(DataGridView1.Rows(i).Cells(6).Value)


            If EsNulo = True Then
                Importe = (DataGridView1.Rows(i).Cells(0).Value) * (DataGridView1.Rows(i).Cells(6).Value)

                Importe = FormatNumber(Importe, 2)

                DataGridView1.Rows(i).Cells(7).Value = Importe




                total = total + (DataGridView1.Rows(i).Cells(7).Value)



                LabelTOTAL.Text = total

            End If




        Next








        LabelTOTAL.Text = total.ToString("##,##0.00")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        If MsgBox("¿Seguro desea imprimir?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Dim PresupuestoCabecera As New PresupuestoCabecera

            Dim _GrillaPresupuesto As GrillaPresupuesto
            Dim _ListaDetalle As New List(Of GrillaPresupuesto)
            Dim CantidadItems As Integer = DataGridView1.RowCount
            Dim PresupuestoMetodos As New PresupuestoMetodos
            Dim Bandera As Integer

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

            '  Dim bandera As Integer


            If ComprobanteRadioButton.Checked = True Then
                Bandera = 1
            Else
                Bandera = 0
            End If



            PresupuestoMetodos.GenerarPresupuestoPDF(_ListaDetalle, PresupuestoCabecera, bandera)



        Else
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBoxCuit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCuit.TextChanged

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
            ' SubTotalLabel.Text = FormatNumber((total / 1.21), 2)


        End If




        Me.Show()
        TextBoxBuscar.Focus()



    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown


        Dim Bandera As Integer = 0
        Dim CantidadFilas As Integer

        If RadioButtonCODIGO.Checked = True Then

            Dim articulo As New Articulo
            Dim articuloMetodos As New ArticulosMetodos

            Select Case e.KeyData
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
                                'SubTotalLabel.Text = FormatNumber((PresupuestoCabecera.Total / 1.21), 2)

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

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FinalizarButton.Click



        Dim _GestorPresupuesto As New Presupuestobll
        Dim _PresupuestoDAO As New PresupuestoMetodos
        Dim _PresupuestoCabecera As New PresupuestoCabecera
        Dim _ListaDetalles As New List(Of PresupuestoDetalle)


        If MsgBox("¿Seguro desea finalizar el presupuesto?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Try

                '_PresupuestoCabecera.Cod_Presupuesto = _PresupuestoDAO.ObtenerCodUltimoPresupuesto + 1
                _PresupuestoCabecera.Cod_Presupuesto = Convert.ToInt32(LabelCodPresupuesto.Text)
                _PresupuestoCabecera.Nombre = TextBoxNombre.Text.ToUpper
                _PresupuestoCabecera.Fecha = Convert.ToDateTime(TextBoxFecha.Text)

                _PresupuestoCabecera.Total = Convert.ToDecimal(LabelTOTAL.Text)


                For i = 0 To DataGridView1.RowCount - 1

                    Dim _PresupuestoDetalle As New PresupuestoDetalle

                    '_PresupuestoDetalle.Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto
                    _PresupuestoDetalle.Cantidad = DataGridView1.Rows(i).Cells("Cantidad").Value
                    _PresupuestoDetalle.Cod_Articulo = DataGridView1.Rows(i).Cells("Codigo").Value
                    _PresupuestoDetalle.Descripcion = DataGridView1.Rows(i).Cells("Descripcion").Value.ToString().ToUpper()
                    _PresupuestoDetalle.Precio = DataGridView1.Rows(i).Cells("Precio").Value
                    _PresupuestoDetalle.Importe = DataGridView1.Rows(i).Cells("Importe").Value

                    _ListaDetalles.Add(_PresupuestoDetalle)

                Next


                _GestorPresupuesto.ActualizarPresupuesto(_PresupuestoCabecera, _ListaDetalles)


                '    Dim el As New EventLogger


                '  el.WriteToErrorLog("Se guardo correctamente el presupuesto ", "Nuevo Presupuesto Form", "Información")

                ' Dim Mensaje = MsgBox("Se guardo correctamente el presupuesto", MsgBoxStyle.Information, "INFORMACION")




                'PresupuestoGridView.Rows.Clear()

                LabelTOTAL.Text = 0

                TextBoxBuscar.Text = ""
                Me.Show()
                TextBoxBuscar.Focus()

                MsgBox("Se modificó correctamente el presupuesto", MsgBoxStyle.Information)

                PresupuestosForm.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells





                PresupuestosForm.DataGridView1.DataSource = _PresupuestoDAO.ObtenerTodosLosPresupuestos.Tables(0)



                Me.Close()



            Catch ex As Exception

                'Dim el As New ErrorLogger
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                ' el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            End Try



        Else

        End If








    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click


        QuitarButton.Enabled = True
        FinalizarButton.Enabled = True
        ArticulosGridView.Enabled = True
        GroupBox1.Enabled = True

        Dim ArticuloDal As New ArticulosMetodos


        ArticulosGridView.DataSource = ArticuloDal.ObtenerPrimerosArticulos.Tables(0)

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

        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ArticulosGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellContentClick

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


        Dim _Cantidad As String

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

            RespuestaInputBox = InputBox("Introduza cantidad", "ATENCIÓN", CStr(1))


            If IsNumeric(RespuestaInputBox) Then

                If RespuestaInputBox.Contains(".") = True Then
                    RespuestaInputBox = Replace(RespuestaInputBox, ".", ",")
                End If

                ' Verifico si ya existe en el detalle, si ya existe actualizo la cantidad de la que ya esta
                ' Tambien verifico si el precio se modifico. Si cambio pongo el precio NUEVO y pinto la fila para que se den cuenta
                For Each row As DataGridViewRow In Me.DataGridView1.Rows

                    If Articulo.Cod_Articulo = row.Cells("Codigo").Value Then

                        RespuestaInputBox = RespuestaInputBox + Convert.ToDecimal(row.Cells("Cantidad").Value)
                        row.Cells("Cantidad").Value = RespuestaInputBox
                        bandera = 1
                        indice = row.Index

                        If (Articulo.Precio > row.Cells("Precio").Value) Then
                            row.Cells("Precio").Value = Articulo.Precio
                            DataGridView1.Rows(indice).DefaultCellStyle.BackColor = Color.Coral
                        End If
                    End If
                Next

                presupuestoDetalle.Cantidad = Convert.ToDouble(RespuestaInputBox)

                If bandera = 0 Then

                    Dim dt As DataTable = DirectCast(DataGridView1.DataSource, DataTable)
                    dt.Rows.Add()
                    DataGridView1.Item("Cantidad", CantidadFilas).ValueType = GetType(Decimal)
                    DataGridView1.Item("Cantidad", CantidadFilas).Value = presupuestoDetalle.Cantidad
                    DataGridView1.Item("Codigo", CantidadFilas).Value = Articulo.Cod_Articulo
                    DataGridView1.Item("CodigoBarras", CantidadFilas).Value = Articulo.Cod_Articulo_Proveedor
                    DataGridView1.Item("Descripcion", CantidadFilas).Value = Articulo.Descripcion
                    DataGridView1.Item("Marca", CantidadFilas).Value = Marca.Descripcion
                    DataGridView1.Item("UnidadMedida", CantidadFilas).Value = SubUnidad_Medida.Descripcion_SubUnidad
                    DataGridView1.Item("Precio", CantidadFilas).Value = Articulo.Precio

                    presupuestoDetalle.Importe = (DataGridView1.Item("Cantidad", CantidadFilas).Value) * Articulo.Precio
                    DataGridView1.Item("Importe", CantidadFilas).Value = presupuestoDetalle.Importe

                Else
                    'Si ya esta agregado en el detalle
                    DataGridView1.Item("Cantidad", indice).Value = presupuestoDetalle.Cantidad
                    presupuestoDetalle.Importe = (DataGridView1.Item("Cantidad", indice).Value) * Articulo.Precio
                    DataGridView1.Item("Importe", indice).Value = Convert.ToDecimal(presupuestoDetalle.Importe)
                End If


                'Dim Total As Decimal

                CantidadFilas = DataGridView1.RowCount

                For i = 0 To CantidadFilas - 1

                    presupuestoDetalle.Importe = Convert.ToDecimal(DataGridView1.Rows(i).Cells(7).Value)

                    '  PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera)

                    PresupuestoCabecera.Total = PresupuestoMetodos.CalcularTotal(presupuestoDetalle, PresupuestoCabecera).Total
                Next


                LabelTOTAL.Text = (PresupuestoCabecera.Total).ToString("##,##0.00")
                'DataGridView1.Rows(0).Cells(7).Value() = Format((DataGridView1.Rows(0).Cells(7).Value()), ("##,##0.00"))

                TextBoxBuscar.Text = ""
                Me.Show()
                TextBoxBuscar.Focus()


            Else
            End If



        Else
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

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



        Else
        End If

    End Sub
End Class