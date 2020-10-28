Imports dal
Imports BLL
Imports Entidades


Public Class Precios
    Public i = 0
    Private Sub Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.icono
        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos

        Me.WindowState = FormWindowState.Maximized


        i = 0

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        MarcaRadioButton.Checked = True
        AumentarRadioButton.Checked = True



         Select True

            Case MarcaRadioButton.Checked = True
                i = 1
                ComboBox1.DataSource = ArticulosDal.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                i = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = SubCategoriaDal.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                i = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                i = 1

        End Select



    End Sub

    Private Sub SubRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubRadioButton.CheckedChanged
        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        i = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                i = 1
                ComboBox1.DataSource = ArticulosDal.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                i = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = SubCategoriaDal.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                i = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                i = 1

        End Select

    End Sub




    

    
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos
        Dim marca As New Marca
        Dim SubCategoria As New SubCategoria
        Dim Categoria As New Categoria


        DataGridView1.DataSource = Nothing
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Select Case True
            Case MarcaRadioButton.Checked = True

                If i = 1 Then
                    marca.Cod_Marca = ComboBox1.SelectedValue

                    DataGridView1.DataSource = ArticulosDal.ObtenerArticuloPorMarca(marca)
                End If


            Case SubRadioButton.Checked = True

                If i = 1 Then

                    SubCategoria.Cod_SubCategoria = ComboBox1.SelectedValue
                    DataGridView1.DataSource = ArticulosDal.ObtenerArticuloPorSubCategoria(SubCategoria)


                End If

            Case CategoriaRadioButton.Checked = True

                If i = 1 Then


                    Categoria.Cod_Categoria = ComboBox1.SelectedValue
                    DataGridView1.DataSource = ArticulosDal.ObtenenrArticulosPorCategoria(Categoria)



                End If

        End Select

        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos


    End Sub

  
    Private Sub MarcaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MarcaRadioButton.CheckedChanged
        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        i = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                i = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = SubCategoriaDal.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                i = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                i = 1

        End Select
    End Sub

    Private Sub CategoriaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoriaRadioButton.CheckedChanged
        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        i = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                i = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = SubCategoriaDal.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                i = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = ArticulosDal.ObtenerCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                i = 1

        End Select
    End Sub

    Private Sub AumentarButton_Click(sender As Object, e As EventArgs)

     


    End Sub

    Private Sub EXCLUIR_Click(sender As Object, e As EventArgs) Handles EXCLUIR.Click

        If DataGridView1.CurrentRow IsNot Nothing Then

            ' saco de la lista el articulo que no quiero aumentar
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

        End If

        



        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos


    End Sub

    Private Sub DescontarRadioButon_CheckedChanged(sender As Object, e As EventArgs)
        AceptarButton.Text = "DESCONTAR"""
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Dim Articulo As Articulo
        Dim ListaArticulos As New List(Of Articulo)
        Dim cantidadItems As Integer
        Dim ArticuloDal As New ArticulosMetodos
        Dim PorcentajeAumento As Integer
        Dim ArticuloBll As New ArticuloBLL
        Dim i As Integer

        cantidadItems = DataGridView1.RowCount
        PorcentajeAumento = NumericUpDown1.Value

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If MsgBox("Seguro desea aumentar los artículos?", vbYesNo, "ATENCIÓN") = vbYes Then



            Try

                For i = 0 To cantidadItems - 1

                    Articulo = New Articulo

                    Articulo.Cod_Articulo = DataGridView1.Rows(i).Cells("Codigo").Value
                    Articulo.Precio = DataGridView1.Rows(i).Cells("Precio").Value
                    Articulo.Descripcion = DataGridView1.Rows(i).Cells("Descripcion").Value
                    Articulo.Descripcion_SubUnidad = DataGridView1.Rows(i).Cells("Sub Unidad").Value

                    ListaArticulos.Add(Articulo)

                Next


                Select Case True

                    Case AumentarRadioButton.Checked = True
                        ArticuloBll.AumentarPrecioBll(ListaArticulos, PorcentajeAumento)

                        MsgBox("Se actualizaron correctamente los Artículos", MsgBoxStyle.Information, "Información")


                    Case DescontarRadioButon.Checked = True
                        ArticuloBll.DescontarPrecioBll(ListaArticulos, PorcentajeAumento)

                        MsgBox("Se actualizaron correctamente los Artículos", MsgBoxStyle.Information, "Información")

                End Select



            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

            i = 1

        End If

        'Una vez actualizado los precios me muestra la lista actualizada



        Dim MarcasDal As New MarcaMetodos
        Dim SubCategoriaDal As New SubCategoriaMetodos
        Dim ArticulosDal As New ArticulosMetodos
        Dim marca As New Marca
        Dim SubCategoria As New SubCategoria
        Dim Categoria As New Categoria


        DataGridView1.DataSource = Nothing

        Try

            Select Case True
                Case MarcaRadioButton.Checked = True

                    If i = 1 Then
                        marca.Cod_Marca = ComboBox1.SelectedValue

                        DataGridView1.DataSource = ArticulosDal.ObtenerArticuloPorMarca(marca)
                    End If


                Case SubRadioButton.Checked = True

                    If i = 1 Then

                        SubCategoria.Cod_SubCategoria = ComboBox1.SelectedValue
                        DataGridView1.DataSource = ArticulosDal.ObtenerArticuloPorSubCategoria(SubCategoria)


                    End If

                Case CategoriaRadioButton.Checked = True

                    If i = 1 Then


                        Categoria.Cod_Categoria = ComboBox1.SelectedValue
                        DataGridView1.DataSource = ArticulosDal.ObtenenrArticulosPorCategoria(Categoria)



                    End If

            End Select



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos

    End Sub

    
End Class