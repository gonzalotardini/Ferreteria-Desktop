Imports System.Configuration
Imports System.Data.SqlClient
Imports Entidades
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO




Public Class PresupuestoMetodos

    Inherits DatosBase



    Public Function ObtenerTodosLosPresupuestos() As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Select Cod_Presupuesto,Nombre, Fecha, Total from PresupuestoCabecera as P where Eliminado=0 order by Cod_Presupuesto desc "


        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet

        Conexion.Close()

    End Function


    Public Function ObtenerPresupuestoCabeceraPorNombre(PresupuestoCabecera As PresupuestoCabecera) As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "select Cod_Presupuesto as 'Codigo', Nombre, Fecha, Total from PresupuestoCabecera where Nombre like '%" + PresupuestoCabecera.Nombre + "%' and Eliminado=0 order by Fecha desc"


        _Comando = New SqlCommand(_Consulta, Me.Conexion)



        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        Return _DataSet

        Conexion.Close()

    End Function

   

    Public Function ObtenerPresupuestoCabecera(presupuestoCabecera As PresupuestoCabecera) As DataSet

        Dim _Consulta As String
        ' Dim _Consulta2 As String

        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        'Dim Cliente As New Cliente



        'lleno la cabecera del presupeusto
        _Consulta = "Select PC.Cod_Presupuesto, PC.fecha, PC.Nombre, PC.Total From PresupuestoCabecera AS PC where  cod_presupuesto=@Cod_Presupuesto"

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Presupuesto", presupuestoCabecera.Cod_Presupuesto)

        Dim _Adapter As New SqlDataAdapter(_Comando)

        _Adapter.Fill(_DataSet)

        '

        '_DataSet.Tables(0).TableName = "Cabecera"
        '_DataSet.Tables(1).TableName = "Detalle"

        Return _DataSet
        'Return Cliente


        Me.Conexion.Close()
    End Function


    Public Function ObtenerPresupuestoDetalle(PresupuestoCabecera As PresupuestoCabecera) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        'lleno el detalle del presupuesto
        _Consulta = "select PC.Cantidad ,PC.cod_articulo as 'Codigo', A.Cod_Articulo_Proveedor as 'CodigoBarras', A.Descripcion, M.Descripcion as Marca, SU.Descripcion as 'UnidadMedida', PC.Precio, PC.importe as 'Importe' from Marca as M, SubUnidad_Medida as SU, PresupuestoDetalle as PC, Articulo AS A WHERE PC.Cod_Articulo=A.Cod_Articulo and M.Cod_Marca=A.cod_Marca and SU.Cod_SubUnidad_Medida=A.Cod_SubUnidad_Medida  AND Cod_Presupuesto=@Cod_Presupuesto "

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Presupuesto", PresupuestoCabecera.Cod_Presupuesto)

        Dim _Adapter As New SqlDataAdapter(_Comando)



        _Adapter.Fill(_DataSet)

        Return _DataSet


    End Function



    Public Function ObtenerCodUltimoPresupuesto() As PresupuestoCabecera



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim PresupuestoCabecera As New PresupuestoCabecera

        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "select top 1 Cod_Presupuesto from presupuestocabecera order by Cod_Presupuesto desc "

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        PresupuestoCabecera.Cod_Presupuesto = (_Comando.ExecuteScalar) 'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


        Return PresupuestoCabecera


    End Function



    Public Function CalcularTotal(PresupuestoDetalle As PresupuestoDetalle, PresupuestoCabecera As PresupuestoCabecera) As PresupuestoCabecera ' calculo el total de la factura
        Dim _presupuestoCabecera As New PresupuestoCabecera


        _presupuestoCabecera.Total = PresupuestoCabecera.Total + PresupuestoDetalle.Importe




        Return _presupuestoCabecera




    End Function



    Public Sub CrearNuevoPresupuestoCabecera(presupuestoCabecera As PresupuestoCabecera)

        Dim _Consulta As String
        Dim _Comando As SqlCommand



        Me.Conexion.Close()
        Me.Conexion.Open()




        'consulta cabecera
        _Consulta = "Insert into PresupuestoCabecera (Nombre, Fecha, Total) values ( @Nombre, @Fecha, @Total)"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)


        _Comando.Parameters.AddWithValue("@Nombre", presupuestoCabecera.Nombre)
        _Comando.Parameters.AddWithValue("@Fecha", presupuestoCabecera.Fecha)
        _Comando.Parameters.AddWithValue("@Total", presupuestoCabecera.Total)




        _Comando.ExecuteNonQuery()







    End Sub



    Public Sub CrearNuevoPresupuestoDetalle(PresupuestoDetalle As PresupuestoDetalle)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try


            Me.Conexion.Close()
            Me.Conexion.Open()

            _Consulta = "Insert into PresupuestoDetalle (Cod_Presupuesto, Cod_Articulo, Cantidad, Precio, Importe, SubTotal, Iva) values (@Cod_Presupuesto, @Cod_Articulo, @Cantidad, @Precio, @Importe, @SubTotal, @Iva) "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", PresupuestoDetalle.Cod_Presupuesto)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", PresupuestoDetalle.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@Cantidad", PresupuestoDetalle.Cantidad)
            _Comando.Parameters.AddWithValue("@Precio", PresupuestoDetalle.Precio)
            _Comando.Parameters.AddWithValue("@Importe", PresupuestoDetalle.Importe)
            _Comando.Parameters.AddWithValue("@SubTotal", PresupuestoDetalle.SubTotal)
            _Comando.Parameters.AddWithValue("@Iva", PresupuestoDetalle.Iva)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
  


    Public Sub GenerarPresupuestoPDF(ListaDetalle As List(Of GrillaPresupuesto), PresupuestoCabecera As PresupuestoCabecera, b As Integer)

        Try
            Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

            'Declaro fuente
            Dim fuente As iTextSharp.text.pdf.BaseFont
            'Defino fuente
            fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont



            Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New FileStream("PRESUPUESTO.pdf", FileMode.Create))



            Dim linea As PdfContentByte




            Dim cb As PdfContentByte


            PdfDocument.Open()
            PdfDocument.NewPage()




            linea = PdfWrite.DirectContent

            'linea.BeginText()


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(750, 750) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 700) 'MoveTo indica el punto de inicio
            linea.LineTo(700, 700) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(300, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(300, 800) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(280, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(320, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 800) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            'Linea final
            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(10, 50) 'MoveTo indica el punto de inicio
            linea.LineTo(590, 50) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva






            cb = PdfWrite.DirectContent
            cb.BeginText()

            cb.SetFontAndSize(fuente, 18)

            'PdfDocument.Add(New Paragraph(" "))
            ' PdfDocument.Add(New Paragraph(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI"))


            'CABECERA
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI HNOS.", 145, 800, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            If b = 1 Then

                cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMPROBANTE", 450, 800, 0)
                ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            Else
                cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 450, 800, 0)
                ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)
            End If

            cb.SetFontAndSize(fuente, 22)
            'X
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "X", 300, 810, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)


            'Izquierda
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Direccion: Artigas Jose G. 3985 CABA ", 20, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Condicion frente al IVA: Responsable Inscripto ", 20, 760, 0)


            'Cliente

            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Cliente:  " & PresupuestoCabecera.Nombre, 20, 720, 0)

            'Derecha
            cb.SetFontAndSize(fuente, 11)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Punto de venta: 001", 400, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha:  " + Now.ToShortDateString, 400, 760, 0)

            'COLUMNAS
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cantidad", 25, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Código", 65, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Descripción", 130, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca", 350, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Medida", 450, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio", 500, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Importe", 550, 685, 0)

            'Total


            cb.SetFontAndSize(fuente, 20)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & PresupuestoCabecera.Total, 400, 30, 0)


            Dim Ubicacion As Integer = 670




            For I = 1 To ListaDetalle.Count

                cb.SetFontAndSize(fuente, 8)


                'obtenemos el valor de la columna en la variable declarada
                ' ListaDetalledetalle.Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
                ' detalle.Cantidad = row.Cells(1).Value
                ' detalle.Descripcion = row.Cells(2).Value
                ' detalle.Marca = row.Cells(3).Value
                ' detalle.Medida = row.Cells(4).Value
                ' detalle.Precio = row.Cells(5).Value
                ' detalle.Importe = row.Cells(6).Value

                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Cantidad, 20, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Codigo, 60, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Descripcion, 90, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Marca, 330, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Medida, 440, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Precio, 490, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Importe, 540, Ubicacion, 0)

                Ubicacion = Ubicacion - 15




            Next





            cb.EndText()
            PdfDocument.Close()

            MsgBox("PDF OK", MsgBoxStyle.Information)


            Dim myProcess As New Process
            myProcess.StartInfo.CreateNoWindow = False
            myProcess.StartInfo.Verb = "print"
            myProcess.StartInfo.FileName = "PRESUPUESTO.PDF"
            myProcess.Start()
            myProcess.WaitForExit(10000)
            myProcess.CloseMainWindow()
            myProcess.Close()


            Dim myprocesses As Process() = System.Diagnostics.Process.GetProcessesByName("AcroRd32")


            System.Threading.Thread.Sleep(7000)

            For Each myproces As Process In myprocesses
                myproces.Kill()
            Next





        Catch ex As Exception
            MsgBox("Error al crear pdf", ex.Message)
        End Try





    End Sub


    Public Sub GenerarPdf(ListaDetalle As List(Of GrillaPresupuesto), PresupuestoCabecera As PresupuestoCabecera, b As Integer)
        Try
            Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

            'Declaro fuente
            Dim fuente As iTextSharp.text.pdf.BaseFont
            'Defino fuente
            fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont


            Dim path As String

            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New FileStream(path + "\PRESUPUESTO.pdf", FileMode.Create))



            Dim linea As PdfContentByte




            Dim cb As PdfContentByte


            PdfDocument.Open()
            PdfDocument.NewPage()




            linea = PdfWrite.DirectContent

            'linea.BeginText()


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(750, 750) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 700) 'MoveTo indica el punto de inicio
            linea.LineTo(700, 700) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(300, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(300, 800) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(280, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(320, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 800) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            'Linea final
            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(10, 50) 'MoveTo indica el punto de inicio
            linea.LineTo(590, 50) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva






            cb = PdfWrite.DirectContent
            cb.BeginText()

            cb.SetFontAndSize(fuente, 18)

            'PdfDocument.Add(New Paragraph(" "))
            ' PdfDocument.Add(New Paragraph(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI"))


            'CABECERA
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI HNOS.", 145, 800, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            If b = 1 Then

                cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMPROBANTE", 450, 800, 0)
                ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            Else
                cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 450, 800, 0)
                ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)
            End If

            cb.SetFontAndSize(fuente, 22)
            'X
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "X", 300, 810, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)


            'Izquierda
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Direccion: Artigas Jose G. 3985 CABA ", 20, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Condicion frente al IVA: Responsable Inscripto ", 20, 760, 0)


            'Cliente

            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Cliente:  " & PresupuestoCabecera.Nombre, 20, 720, 0)

            'Derecha
            cb.SetFontAndSize(fuente, 11)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Punto de venta: 001", 400, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha:  " + Now.ToShortDateString, 400, 760, 0)

            'COLUMNAS
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cantidad", 25, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Código", 65, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Descripción", 130, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca", 350, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Medida", 450, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio", 500, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Importe", 550, 685, 0)

            'Total


            cb.SetFontAndSize(fuente, 20)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & PresupuestoCabecera.Total, 400, 30, 0)


            Dim Ubicacion As Integer = 670




            For I = 1 To ListaDetalle.Count

                cb.SetFontAndSize(fuente, 8)


                'obtenemos el valor de la columna en la variable declarada
                ' ListaDetalledetalle.Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
                ' detalle.Cantidad = row.Cells(1).Value
                ' detalle.Descripcion = row.Cells(2).Value
                ' detalle.Marca = row.Cells(3).Value
                ' detalle.Medida = row.Cells(4).Value
                ' detalle.Precio = row.Cells(5).Value
                ' detalle.Importe = row.Cells(6).Value

                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Cantidad, 20, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Codigo, 60, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Descripcion, 90, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Marca, 330, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Medida, 440, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Precio, 490, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Importe, 540, Ubicacion, 0)

                Ubicacion = Ubicacion - 15




            Next





            cb.EndText()
            PdfDocument.Close()

            MsgBox("PDF OK", MsgBoxStyle.Information)



        Catch ex As Exception
            MsgBox("Error al crear pdf", ex.Message)
        End Try





    End Sub

    Public Sub SoftEliminarPresupuesto(CodigoPresupuesto)


        Dim _Consulta As String
        Dim _Comando As SqlCommand


        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Update PresupuestoCabecera set Eliminado=1 where Cod_Presupuesto=@Cod_Presupuesto"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Presupuesto", CodigoPresupuesto)


        _Comando.ExecuteNonQuery()


    End Sub



    Public Sub EliminarDetalle(CodigoPresupuesto)


        Dim _Consulta As String
        Dim _Comando As SqlCommand


        Me.Conexion.Close()
        Me.Conexion.Open()

        _Consulta = "Delete from PresupuestoDetalle where Cod_Presupuesto=@Cod_Presupuesto"

        _Comando = New SqlCommand(_Consulta, Me.Conexion)

        _Comando.Parameters.AddWithValue("@Cod_Presupuesto", CodigoPresupuesto)


        _Comando.ExecuteNonQuery()

    End Sub




    Public Sub EliminarPresupuestoDetalle(_PresupuestoCabecera As PresupuestoCabecera)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "Delete from PresupuestoDetalle where Cod_Presupuesto=@Cod_Presupuesto"

        Try
            Me.Conexion.Close()
            Me.Conexion.Open()


            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", _PresupuestoCabecera.Cod_Presupuesto)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub


    Public Sub ActualizarPresupuestoCabecera(_PresupuestoCabecera As PresupuestoCabecera)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "Update PresupuestoCabecera set Total=@Total, Nombre=@Nombre, Fecha=@Fecha where Cod_Presupuesto=@Cod_Presupuesto"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Total", _PresupuestoCabecera.Total)
            _Comando.Parameters.AddWithValue("@Fecha", _PresupuestoCabecera.Fecha)
            _Comando.Parameters.AddWithValue("@Nombre", _PresupuestoCabecera.Nombre)
            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", _PresupuestoCabecera.Cod_Presupuesto)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub



End Class
