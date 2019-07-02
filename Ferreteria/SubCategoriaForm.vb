Imports dal
Imports Entidades

Public Class SubCategoriaForm

    Private Sub SubCategoriaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        Dim SubCategoriaMetodos As New SubCategoriaMetodos

        Dim CategoriaMetodos As New CategoriaMetodos
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        AceptarButton.Enabled = False

        ComboBox1.DataSource = CategoriaMetodos.ObtenerTodasCategorias.Tables(0)

        ComboBox1.ValueMember = "Cod_Categoria"
        ComboBox1.DisplayMember = "Descripcion"


        DataGridView1.DataSource = SubCategoriaMetodos.ObtenerTodasLasSUbCategorias.Tables(0)



    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click

        Dim Subcategoria As New SubCategoria
        Dim categoria As New Categoria
        Dim subCategoriaMetodos As New SubCategoriaMetodos





        categoria.Cod_Categoria = ComboBox1.SelectedValue
        Subcategoria.Descripcion = (TextBox1.Text).ToUpper

        If subCategoriaMetodos.AgregarSubCategoria(categoria, Subcategoria) = True Then
            TextBox1.Text = ""
        End If


        DataGridView1.DataSource = subCategoriaMetodos.ObtenerTodasLasSUbCategorias.Tables(0)

    End Sub




    Public SubCategoriaP As New SubCategoria
    Public CategoriaP As New Categoria
    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        Dim UnidadMedida As New UnidadMedida
        Dim CategoriaMetodos As New CategoriaMetodos
        Dim subCategoriaMetodos As New SubCategoriaMetodos
        Dim categoria As New Categoria

        SubCategoriaP.Cod_SubCategoria = DataGridView1.CurrentRow.Cells(0).Value()
        SubCategoriaP.Descripcion = DataGridView1.CurrentRow.Cells(1).Value



        TextBox1.Text = SubCategoriaP.Descripcion

        AgregarButton.Enabled = False
        AceptarButton.Enabled = True


        ComboBox1.DataSource = CategoriaMetodos.ObtenerTodasCategorias.Tables(0)
        ComboBox1.ValueMember = "Cod_Categoria"
        ComboBox1.DisplayMember = "Descripcion"







        ComboBox1.SelectedValue = subCategoriaMetodos.ObtenerCategoriaConId(SubCategoriaP).Cod_Categoria




    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Dim SubCategoriaMetodos As New SubCategoriaMetodos



        AgregarButton.Enabled = True

        SubCategoriaP.Cod_Categoria = ComboBox1.SelectedValue
        SubCategoriaP.Descripcion = (TextBox1.Text).ToUpper


        SubCategoriaMetodos.ActualizarSubCategoria(SubCategoriaP)

        DataGridView1.DataSource = SubCategoriaMetodos.ObtenerTodasLasSUbCategorias.Tables(0)

        TextBox1.Text = ""

        AceptarButton.Enabled = False



    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        Dim SubCategoriaMetodos As New SubCategoriaMetodos
        Dim SubCategoria As New SubCategoria

        SubCategoria.Descripcion = (TextBoxBuscar.Text).ToUpper

        DataGridView1.DataSource = SubCategoriaMetodos.BuscarSubCategoriaPorDescripcion(SubCategoria).Tables(0)





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class