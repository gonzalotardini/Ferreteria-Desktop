Imports Entidades
Imports dal
Imports BLL

Public Class CategoriaForm

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        Dim Categoria As New Categoria
        Dim CategoriaMetodos As New CategoriaMetodos


        If TextBox1.Text = "" Then
            MsgBox("Complete Categoria", MsgBoxStyle.Exclamation, "ATENCIÓN")

        Else

            Categoria.Descripcion = (TextBox1.Text).ToUpper


            If CategoriaMetodos.AgregarCategoria(Categoria) = True Then

                TextBox1.Text = ""

            End If




            DataGridView1.DataSource = CategoriaMetodos.ObtenerTodasCategorias.Tables(0)



        End If

       






    End Sub

    Private Sub CategoriaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.icono

        Dim CategoriaMetodos As New CategoriaMetodos

        AceptarButton.Enabled = False

        DataGridView1.DataSource = CategoriaMetodos.ObtenerTodasCategorias.Tables(0)




    End Sub
    Public CategoriaP As New Categoria
    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        Dim UnidadMedida As New UnidadMedida

        CategoriaP.Cod_Categoria = DataGridView1.CurrentRow.Cells(0).Value()
        CategoriaP.Descripcion = DataGridView1.CurrentRow.Cells(1).Value



        TextBox1.Text = CategoriaP.Descripcion

        AgregarButton.Enabled = False
        AceptarButton.Enabled = True
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        Dim CategoriaMetodos As New CategoriaMetodos

        If TextBox1.Text = "" Then
            MsgBox("Complete Categoria", MsgBoxStyle.Exclamation, "ATENCIÓN")
        Else


            CategoriaP.Descripcion = (TextBox1.Text).ToUpper

            AceptarButton.Enabled = False
            AgregarButton.Enabled = True



            If CategoriaMetodos.ActualizarCategoria(CategoriaP) = True Then 'este if es para limpiar el textbox, si se ejecuto correctamente la funcion lo limpio, sino no
                TextBox1.Clear()
            End If



            DataGridView1.DataSource = CategoriaMetodos.ObtenerTodasCategorias.Tables(0)


        End If



       
    End Sub
End Class