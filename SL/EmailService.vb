Public Class EmailService

    Public Sub EnviarMail(CuerpoEmail As String)

        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim fechaHoy As String = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now)

        With smtp
            .Port = 587
            .Host = "smtp.gmail.com"
            .Credentials = New System.Net.NetworkCredential("augustodibernardi@gmail.com", "cabezapelada")
            .EnableSsl = True
        End With
        With correo
            .From = New System.Net.Mail.MailAddress("augustodibernardi@gmail.com")
            .To.Add("gonzalotardini@gmail.com")
            .Subject = "Modificación de precios " + fechaHoy
            .Body = CuerpoEmail
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
        End With

        Try
            smtp.Send(correo)
        Catch ex As Exception
            MsgBox("Se ha producido un error al enviar el email de moficiación de precios: " + ex.Message, MsgBoxStyle.Critical, "ATENCION")
        End Try



    End Sub


    Public Function GenerarCuerpoMail() As String



        Return ""

    End Function


End Class
