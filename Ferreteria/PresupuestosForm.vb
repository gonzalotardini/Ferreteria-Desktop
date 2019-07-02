Imports dal
Imports Entidades
Imports BLL

Public Class PresupuestosForm

    Private Sub PresupuestosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        AgregarButton.Enabled = False




        Dim PresupuestoMetodos As New PresupuestoMetodos


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells





        DataGridView1.DataSource = PresupuestoMetodos.ObtenerTodosLosPresupuestos.Tables(0)





    End Sub



   

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        PresupuestoDetalleForm.PresupuestoP.Cod_Presupuesto = DataGridView1.CurrentRow.Cells(0).Value


        PresupuestoDetalleForm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PresupuestoNuevoForm.Show()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        Dim PresupuestoBLL As New PresupuestoBLL

        Dim CodigoPresupuesto As Integer

        CodigoPresupuesto = DataGridView1.CurrentRow.Cells(0).Value






        If MsgBox("¿Seguro desea eliminar el presupuesto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            Try

                PresupuestoBLL.EliminarPresupuesto(CodigoPresupuesto)
                MsgBox("Presupuesto eliminado correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try






        End If




        Dim PresupuestoMetodos As New PresupuestoMetodos


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells





        DataGridView1.DataSource = PresupuestoMetodos.ObtenerTodosLosPresupuestos.Tables(0)



    End Sub

    Public _Cod_Presupuesto As String
    Public _B As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click



        _Cod_Presupuesto = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)


        _B = 1


        Me.Close()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Dim PresupuestoDAO As New PresupuestoMetodos
                Dim PresupuestoCabecera As New PresupuestoCabecera

                PresupuestoCabecera.Nombre = (TextBox1.Text).ToUpper


                DataGridView1.DataSource = PresupuestoDAO.ObtenerPresupuestoCabeceraPorNombre(PresupuestoCabecera).Tables(0)

        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub TextBox1_Layout(sender As Object, e As LayoutEventArgs) Handles TextBox1.Layout

    End Sub
End Class