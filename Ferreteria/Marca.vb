Imports dal
Imports Entidades

Public Class Marca

    Private Sub Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MarcasMetodos As New MarcaMetodos


        DataGridView1.DataSource = MarcasMetodos.ObtenerTodasMarcas.Tables(0)
        DataGridView1.AutoSizeColumnsMode = True








    End Sub
End Class