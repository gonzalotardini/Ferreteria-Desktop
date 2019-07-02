Imports dal
Imports Entidades
Imports System.Configuration
Imports System.Data.SqlClient

Public Class MarcaForm

    Private Sub Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.icono
        Dim MarcasMetodos As New MarcaMetodos


        DataGridView1.DataSource = MarcasMetodos.ObtenerTodasMarcas.Tables(0)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ButtonAceptar.Enabled = False






    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim marca As New Marca
        Dim marcaMetodos As New MarcaMetodos

        marca.Descripcion = (TextBox1.Text).ToUpper

        If marcaMetodos.AgregarMarca(marca) = True Then

            DataGridView1.DataSource = marcaMetodos.ObtenerTodasMarcas.Tables(0)
            TextBox1.Text = ""
            TextBox1.Focus()

        End If






    End Sub



    Public MarcaP As New Marca
    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click


        MarcaP.Cod_Marca = DataGridView1.CurrentRow.Cells(0).Value
        MarcaP.Descripcion = DataGridView1.CurrentRow.Cells(1).Value


        TextBox1.Text = MarcaP.Descripcion


        ButtonAgregar.Enabled = False
        ButtonAceptar.Enabled = True




    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim MarcaMetodos As New MarcaMetodos


        MarcaP.Descripcion = (TextBox1.Text).ToUpper

        If MarcaMetodos.ModificarMarca(MarcaP) = True Then
            TextBox1.Text = ""
            DataGridView1.DataSource = MarcaMetodos.ObtenerTodasMarcas.Tables(0)


        End If

        ButtonAceptar.Enabled = False
        ButtonAgregar.Enabled = True



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged


        Dim MarcaMetodos As New MarcaMetodos
        Dim Marca As New Marca
        Marca.Descripcion = (TextBoxBuscar.Text).ToUpper

        DataGridView1.DataSource = MarcaMetodos.BuscarMarcaPorDescripcion(Marca).Tables(0)



    End Sub
End Class