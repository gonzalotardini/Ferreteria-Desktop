Imports Entidades
Imports dal
Imports BLL

Public Class ModificacionesArticulosForm

    Private Sub ModificacionesArticulosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.icono
        Dim ArticulosDal As New ArticulosMetodos

        Me.WindowState = FormWindowState.Maximized
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells 'sirve para que el ancho de las columnas se acomode automaticamente

        DataGridView1.DataSource = ArticulosDal.ObtenerModificacionesTop50()





    End Sub
End Class