Imports dal
Imports Entidades
Imports BLL
Imports System.ServiceProcess



Public Class Articulos

    ' Dim servicio As New System.ServiceProcess.ServiceController("MSDTC")



    Private Sub ARTICULOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  servicio.Start()
        Me.BringToFront()



        Application.DoEvents()
        TextBoxBuscar.Focus()

        Me.WindowState = FormWindowState.Maximized

        Dim ArticulosMetodos As New ArticulosMetodos

        TextBox3.Text = "00"
        RadioButtonDESCRIPCION.Select()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        'Cargo las unidades de medida
        Combo_UniddMedida.DataSource = ArticulosMetodos.ObtenerUnidadMedida
        Combo_UniddMedida.ValueMember = "Cod_Unidad_Medida"
        Combo_UniddMedida.DisplayMember = "Descripcion"


        DataGridView1.DataSource = ArticulosMetodos.ObtenerPrimerosArticulos.Tables(0)


        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label14.Text = CantidadArticulos

    End Sub


    'numero para bandera
    Public num As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_UniddMedida.SelectedIndexChanged


        Dim Unidad_Medida As New UnidadMedida
        Dim Categoria As New Categoria
        Dim ArticulosMetodos As New ArticulosMetodos





        Unidad_Medida.Cod_UnidadMedida = Combo_UniddMedida.SelectedValue

        'Cargo las Sub Unidad de Medida
        Combo_SubUnidad.DataSource = ArticulosMetodos.ObtenerSubUnidadMedida(Unidad_Medida)
        Combo_SubUnidad.DisplayMember = "Descripcion"
        Combo_SubUnidad.ValueMember = "Cod_SubUnidad_Medida"


        'Cargo las Categorias

        ComboCategoria.DataSource = ArticulosMetodos.ObtenerCategorias
        ComboCategoria.ValueMember = "Cod_Categoria"
        ComboCategoria.DisplayMember = "Descripcion"
        num = 1


        'Cargo las Marcas

        ComboMarca.DataSource = ArticulosMetodos.ObtenerMarcas
        ComboMarca.ValueMember = "Cod_Marca"
        ComboMarca.DisplayMember = "Descripcion"







    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCategoria.SelectedIndexChanged
        Dim ArticulosMetodos As New ArticulosMetodos
        Dim Categoria As New Categoria



        'Cargo las subCategorias
        ' hago este if para que primero me cargue las categorias y despues las sub categorias, es una bandera para que no tire error
        If num = 1 Then
            Categoria.Cod_Categoria = ComboCategoria.SelectedValue

            'Cargo Sub Categorias
            ComboSubCategoria.DataSource = ArticulosMetodos.ObtenerSubCategoria(Categoria)
            ComboSubCategoria.ValueMember = "Cod_SubCategoria"
            ComboSubCategoria.DisplayMember = "Descripcion"
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim Articulo As New Articulo
        Dim ArticulosMetodos As New ArticulosMetodos

        Dim ValidarArticulo As New ValidarArticuloClase


        'ruta = OpenFileDialog1.FileName.ToString


        If TextBoxCodProveedor.Text = "" Then

            MsgBox("Introduzca Codigo de Barras", MsgBoxStyle.Exclamation, "ATENCION")
            TextBoxCodProveedor.Focus()
        Else

            If TextBoxPrecio.Text = "" Then

                MsgBox("Introduzca precio", MsgBoxStyle.Exclamation, "ATENCION")
                TextBoxPrecio.Focus()
            Else
                If TextBoxStock.Text = "" Then
                    MsgBox("Introduzca Stock", MsgBoxStyle.Exclamation, "ATENCION")
                    TextBoxStock.Focus()
                Else


                    If Combo_UniddMedida.SelectedIndex = -1 Then
                        MsgBox("Error, Seleccione Unidad de Medida", MsgBoxStyle.Exclamation, "ATENCIÓN")
                    Else

                        If Combo_SubUnidad.SelectedIndex = -1 Then
                            MsgBox("Error, Seleccione Sub-Unidad de Medida", MsgBoxStyle.Exclamation, "ATENCIÓN")

                        Else

                            If ComboCategoria.SelectedIndex = -1 Then
                                MsgBox("Error, Seleccione Categoría", MsgBoxStyle.Exclamation, "ATENCIÓN")
                            Else

                                If ComboSubCategoria.SelectedIndex = -1 Then
                                    MsgBox("Error, Seleccione Sub-Categoría", MsgBoxStyle.Exclamation, "ATENCIÓN")

                                Else

                                    If ComboMarca.SelectedIndex = -1 Then
                                        MsgBox("Error, Seleccione Marca", MsgBoxStyle.Exclamation, "ATENCIÓN")

                                    Else

                                        Articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBoxCodProveedor.Text)
                                        Articulo.Descripcion = TextBoxDescripcion.Text.ToUpper
                                        Articulo.Cod_Unidad_Medida = Combo_UniddMedida.SelectedValue
                                        Articulo.Cod_SubUnidad_Medida = Combo_SubUnidad.SelectedValue
                                        Articulo.Precio = Convert.ToDecimal(TextBoxPrecio.Text + "," + TextBox3.Text)
                                        Articulo.Cod_Categoria = ComboCategoria.SelectedValue
                                        Articulo.Cod_SubCategoria = ComboSubCategoria.SelectedValue
                                        Articulo.Cod_Marca = ComboMarca.SelectedValue
                                        Articulo.Stock = Convert.ToInt32(TextBoxStock.Text)
                                        'Articulo.Imagen = System.Drawing.Image.FromFile(ruta)



                                        If ValidarArticulo.ValidarArticulo(Articulo) = True Then
                                            TextBoxCodProveedor.Text = ""
                                            TextBox3.Text = "00"
                                            TextBoxDescripcion.Text = ""
                                            TextBoxPrecio.Text = ""
                                            TextBoxStock.Text = ""
                                        End If

                                        For Each row As DataGridViewRow In DataGridView1.Rows

                                            If row.Index Mod 2 <> 0 Then
                                                row.DefaultCellStyle.BackColor = Color.Bisque
                                            Else
                                                row.DefaultCellStyle.BackColor = Color.Aqua

                                            End If

                                        Next


                                    End If

                                End If

                            End If

                        End If


                    End If


                End If

            End If
        End If



        ' DataGridView1.DataSource = ArticulosMetodos.ObtenerTodosArticulos.Tables(0)
        ' For Each row As DataGridViewRow In DataGridView1.Rows

        'If row.Index Mod 2 <> 0 Then
        ' row.DefaultCellStyle.BackColor = Color.Bisque
        ' Else
        'row.DefaultCellStyle.BackColor = Color.Aqua

        ' End If

        ' Next

        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label14.Text = CantidadArticulos
    End Sub






    Public form As New ModificarArticuloForm
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New ModificarArticuloForm


        form.Cod_Articulo = DataGridView1.CurrentRow.Cells(0).Value







        form.Show()







    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown


        Dim bandera As Integer = 0

        If RadioButtonCODIGO.Checked = True Then

            Dim articulo As New Articulo
            Dim articuloMetodos As New ArticulosMetodos

            Select Case e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBoxBuscar.Text)
                        DataGridView1.DataSource = articuloMetodos.BuscarArticuloPorCodigoBarras(articulo).Tables(0)

                        TextBoxBuscar.SelectAll()

                        For Each row As DataGridViewRow In DataGridView1.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next








                        'If PresupuestoNuevoForm.Visible = True Then






                        'Articulo.Cod_Articulo = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Codigo")
                        'Articulo.Cod_Articulo_Proveedor = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("CodigoBarras")
                        'Articulo.Descripcion = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Descripcion")
                        'Marca.Descripcion = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Marca")
                        'SubUnidad_Medida.Descripcion_SubUnidad = ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Sub Unidad")
                        'Articulo.Precio = Convert.ToDecimal(ArticuloMetodos.BuscarArticuloPorCodigo(Articulo).Tables(0).Rows(0).Item("Precio"))



                        'presupuestoDetalle.Cantidad = -1

                    Else
                        bandera = 1
                    End If

                    Dim CantidadArticulos As Integer

                    CantidadArticulos = DataGridView1.RowCount - 1
                    Label14.Text = CantidadArticulos

            End Select









        End If

        If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

            Dim articulo2 As New Articulo
            Dim articuloMetodos2 As New ArticulosMetodos

            Select Case e.KeyData

                Case Keys.Enter


                    articuloMetodos2.BuscarArticuloPorNombre(articulo2)


                    articulo2.Descripcion = (TextBoxBuscar.Text).ToUpper
                    DataGridView1.DataSource = articuloMetodos2.BuscarArticuloPorNombre(articulo2).Tables(0)



                    For Each row As DataGridViewRow In DataGridView1.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    Bandera = 0

                    RadioButtonDESCRIPCION.Checked = True
            End Select

            Dim CantidadArticulos As Integer

            CantidadArticulos = DataGridView1.RowCount - 1
            Label14.Text = CantidadArticulos
        End If


    End Sub



    Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress

        If RadioButtonCODIGO.Checked = True Then ' vlaido con el evento keypress para permitir solamente el ingreso de NUMEROS
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

        '   Dim ArticuloMetodos As New ArticulosMetodos
        ' Dim Articulo As New Articulo




        ' ArticuloMetodos.BuscarArticuloPorNombre(Articulo)


        ' Select Case True

        ' Case RadioButtonDESCRIPCION.Checked
        'Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
        ' DataGridView1.DataSource = ArticuloMetodos.BuscarArticuloPorNombre(Articulo).Tables(0)

        ' Case RadioButtonCODIGO.Checked


        '' Dim EsNumero As Boolean

        ' EsNumero = IsNumeric(TextBoxBuscar.Text)


        ' If TextBoxBuscar.Text <> "" And EsNumero = True Then  'valido para que no ejectue la funcion si no hay caracteres
        ' Articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBoxBuscar.Text)
        'DataGridView1.DataSource = ArticuloMetodos.BuscarArticuloPorCodigoBarras(Articulo).Tables(0)
        'End If




        'End Select

        ' For Each row As DataGridViewRow In DataGridView1.Rows

        'If row.Index Mod 2 <> 0 Then
        ' row.DefaultCellStyle.BackColor = Color.Bisque
        ' Else
        ' row.DefaultCellStyle.BackColor = Color.Aqua

        ' End If

        'Next

        ' Dim CantidadArticulos As Integer

        'CantidadArticulos = DataGridView1.RowCount - 1
        'Label14.Text = CantidadArticulos
    End Sub

    Private Sub TextBoxCodProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCodProveedor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub



    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TextBoxPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrecio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        Dim Articulo As New Articulo
        Dim ArticuloBLL As New ArticuloBLL

        If MsgBox("Seguro desea eliminar el Articulo?", vbYesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Try

                Articulo.Cod_Articulo = DataGridView1.CurrentRow.Cells(0).Value

                ArticuloBLL.BajaArticulo(Articulo)

                MsgBox("Se ha eliminado el articulo correctamente", MsgBoxStyle.Information)

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


        End If




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
End Class