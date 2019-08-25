Imports SL

Public Class BackUpForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BackupClase As New BackUp


        Try
            BackupClase.RealizarBackUp()

            MsgBox("Se realizó correctamente el BackUp", MsgBoxStyle.Information, "INFORMACIÓN")
            Me.Close()
        Catch ex As Exception

            MsgBox("Error al realizar BackUp " & ex.Message)

        End Try






    End Sub

    Private Sub BackUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
    End Sub
End Class