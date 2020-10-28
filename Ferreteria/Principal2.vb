Imports Entidades
Public Class Principal2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ArticulosForm.Visible = True Then
            ArticulosForm.BringToFront()
        Else
            ArticulosForm.Show()
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If ClientesForm.Visible = True Then
            ClientesForm.BringToFront()
        Else
            ClientesForm.Show()
        End If
    End Sub

  

   

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click

        MarcaForm.Show()

    End Sub



    Private Sub SubCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriaToolStripMenuItem.Click
        SubCategoriaForm.Show()

    End Sub

    Private Sub Principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        '   If e.KeyData = Keys.F5 Then
        'Dim form As New PresupuestoNuevoForm

        '  form.Show()

        ' End If
    End Sub



    Private Sub Principal_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        '  If e.KeyData = Keys.F5 Then
        'Dim form As New PresupuestoNuevoForm

        '  form.Show()

        'End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PresupuestosForm.Show()
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Precios.Show()
    End Sub

    

    Private Sub NuevoPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPresupuestoToolStripMenuItem.Click

        If PresupuestoNuevoForm.Visible = True Then
            PresupuestoNuevoForm.BringToFront()
        Else
            PresupuestoNuevoForm.Show()
        End If


    End Sub







    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
    End Sub

    Private Sub ExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraToolStripMenuItem.Click

    End Sub

    Private Sub UnidadMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadMedidaToolStripMenuItem.Click
        UnidadMedidaForm.Show()
    End Sub

    Private Sub SubUnidadMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubUnidadMedidaToolStripMenuItem.Click
        SubUnidadMedidaForm.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        CategoriaForm.Show()
    End Sub

    Private Sub PreciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem1.Click
        ReportePrecios.Show()
    End Sub

    Private Sub ArticulosEliminadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosEliminadosToolStripMenuItem.Click
        ArticulosEliminadosForm.Show()

    End Sub

    Private Sub BackUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpToolStripMenuItem.Click
        BackUpForm.Show()

    End Sub

    Private Sub ModificacionesArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionesArticulosToolStripMenuItem.Click
        ModificacionesArticulosForm.Show()

    End Sub
End Class
