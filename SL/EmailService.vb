Public Class EmailService

    Public Sub EnviarMail(CuerpoEmail As String)

        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage

        With smtp
            .Port = 587
            .Host = "smtp.gmail.com"
            .Credentials = New System.Net.NetworkCredential("augustodibernardi@gmail.com", "chaca1994")
            .EnableSsl = True
        End With
        With correo
            .From = New System.Net.Mail.MailAddress("augustodibernardi@gmail.com")
            .To.Add("gonzalotardini@gmail.com")
            .Subject = "Modificación de precios"
            .Body = CuerpoEmail
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
        End With

        Try
            smtp.Send(correo)
        Catch ex As Exception
            MsgBox("Se ha producido un error al enviar el email de moficiación de precios", MsgBoxStyle.Critical, "ATENCION")
        End Try



    End Sub


    Public Function GenerarCuerpoMail() As String



        Return ""

    End Function


End Class
