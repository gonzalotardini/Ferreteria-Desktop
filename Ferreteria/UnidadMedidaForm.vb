Imports dal
Imports Entidades
Public Class UnidadMedidaForm

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub UnidadMedidaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        Dim UnidadMedidaMetodo As New UnidadMedidaMetodos

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.DataSource = UnidadMedidaMetodo.ObtenerTodasUnidadMedida.Tables(0)

        AceptarButton.Enabled = False



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click


        Dim UnidadMedida As New UnidadMedida
        Dim UnidadMedidaMetodo As New UnidadMedidaMetodos

        UnidadMedida.Descripcion = (TextBox1.Text).ToUpper

        UnidadMedidaMetodo.AgregarUnidadMedida(UnidadMedida)
        UnidadMedidaMetodo.ObtenerTodasUnidadMedida()




    End Sub
    Public UnidadMedidaP As New UnidadMedida
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click

        Dim UnidadMedida As New UnidadMedida

        UnidadMedidaP.Cod_UnidadMedida = DataGridView1.CurrentRow.Cells(0).Value()
        UnidadMedidaP.Descripcion = DataGridView1.CurrentRow.Cells(1).Value



        TextBox1.Text = UnidadMedidaP.Descripcion

        AgregarButton.Enabled = False
        AceptarButton.Enabled = True





    End Sub

    
    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click


        Dim UnidadMedidaMetodos As New UnidadMedidaMetodos

        UnidadMedidaP.Descripcion = (TextBox1.Text).ToUpper

        AceptarButton.Enabled = False
        AgregarButton.Enabled = True



        If UnidadMedidaMetodos.ActualizarUnidadMedida(UnidadMedidaP) = True Then 'este if es para limpiar el textbox, si se ejecuto correctamente la funcion lo limpio, sino no
            TextBox1.Clear()
        End If



        DataGridView1.DataSource = UnidadMedidaMetodos.ObtenerTodasUnidadMedida.Tables(0)

        

    End Sub
End Class