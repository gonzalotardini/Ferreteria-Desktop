Imports System.IO


Public Class PDF

    Private Sub PDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        Me.WindowState = FormWindowState.Maximized

        Dim ruta_archivo As String = "C:\Users\NOTEBOOK\Desktop\PRESUPUESTO.pdf"



        If File.Exists(ruta_archivo) = True Then
            AxAcroPDF1.LoadFile(ruta_archivo)
            AxAcroPDF1.Enabled = True
            AxAcroPDF1.Dock = DockStyle.None
            AxAcroPDF1.setShowScrollbars(True)
            AxAcroPDF1.setShowToolbar(False)
        End If

    End Sub
End Class