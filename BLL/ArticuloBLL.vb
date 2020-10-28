Imports Entidades
Imports dal
Imports System.Transactions
Imports System.Math
Imports SL


Public Class ArticuloBLL


    Public Sub AumentarPrecioBll(ListaArticulos As List(Of Articulo), PorcentajeAumento As Integer)

        Dim NuevoPrecio As Decimal
        Dim cantidadArticulos As Integer = ListaArticulos.Count
        Dim Articulo As New Articulo
        Dim ArticuloDal As New ArticulosMetodos
        Dim articuloEmailList As New List(Of ArticuloParaEmail)

        Using ts As TransactionScope = New TransactionScope


            For i = 1 To cantidadArticulos

                Articulo.Cod_Articulo = ListaArticulos.Item(i - 1).Cod_Articulo
                Articulo.Precio = ListaArticulos.Item(i - 1).Precio
                Articulo.Descripcion = ListaArticulos.Item(i - 1).Descripcion
                Articulo.Descripcion_SubUnidad = ListaArticulos.Item(i - 1).Descripcion_SubUnidad
                Dim precioViejo = Articulo.Precio

                'Calculo nuevo precio con el porcentaje de aumento

                NuevoPrecio = ((Articulo.Precio * PorcentajeAumento) / 100) + Articulo.Precio


                If NuevoPrecio > 5 Then

                    ' Si los centavos estan entre 50 y 10 redondeo para arriba

                    If Right(NuevoPrecio, 2) > 10 And Right(NuevoPrecio, 2) < 50 Then

                        Articulo.Precio = Round(NuevoPrecio) + 1

                        ArticuloDal.ActualizarPrecio(Articulo)


                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        ArticuloDal.MovimientoPrecios(Articulo, Fecha)

                    Else

                        Articulo.Precio = Round(NuevoPrecio)

                        ArticuloDal.ActualizarPrecio(Articulo)

                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        ArticuloDal.MovimientoPrecios(Articulo, Fecha)

                    End If



                Else


                    Articulo.Precio = NuevoPrecio
                    ArticuloDal.ActualizarPrecio(Articulo)
                    Dim Fecha As Date

                    Fecha = Now

                    ArticuloDal.MovimientoPrecios(Articulo, Fecha)

                End If

                Dim articuloEmail = New ArticuloParaEmail
                With articuloEmail
                    .Cod_Articulo = Articulo.Cod_Articulo
                    .Descripcion = Articulo.Descripcion
                    .Descripcion_SubUnidad = Articulo.Descripcion_SubUnidad
                    .Precio_Anterior = precioViejo
                    .Precio = Articulo.Precio
                End With
                articuloEmailList.Add(articuloEmail)
            Next

            ts.Complete()
            EnviarEmail(articuloEmailList)

        End Using

    End Sub


    Private Sub EnviarEmail(articuloEmailList As List(Of ArticuloParaEmail))
        Dim emailService = New EmailService
        Dim tableItems As String = ""

        For Each articulo As ArticuloParaEmail In articuloEmailList
            tableItems += "<tr><td>" + articulo.Cod_Articulo.ToString + "</td><td>" + articulo.Descripcion + "</td><td>" + articulo.Descripcion_SubUnidad + "</td><td>" + articulo.Precio_Anterior.ToString + "</td><td>" + articulo.Precio.ToString + "</td></tr>"
        Next

        Dim cuerpo As String = "<html>
            <head>
                <style>
                   td {
                        border:solid 1px;                    
                    }
                </style>
             </head>
            <body>
                <table><tbody><tr><td><strong>CodArticulo<strong></td><td><strong>Descripcion<strong></td><td><strong>Medida<strong></td><td><strong>Precio Viejo<strong></td><td><strong>Precio Nuevo<strong></td></tr>" + tableItems + "</tbody></table>
            </body>
        </html>"


        ''Dim cuerpo As String = "<table><tbody><tr><td><strong>CodArticulo<strong></td><td><strong>Descripcion<strong></td><td><strong>Medida<strong></td><td><strong>Precio Viejo<strong></td><td><strong>Precio Nuevo<strong></td></tr><tr><td>" + articuloEmail.Cod_Articulo.ToString + "</td><td>" + articuloEmail.Descripcion + "</td><td>" + articuloEmail.Descripcion_SubUnidad + "</td><td>" + articuloEmail.Precio_Anterior.ToString + "</td><td>" + articuloEmail.Precio.ToString + "</td></tr></tbody></table>"
        emailService.EnviarMail(cuerpo)
    End Sub
    Public Sub DescontarPrecioBll(ListaArticulos As List(Of Articulo), PorcentajeAumento As Integer)

        Dim NuevoPrecio As Decimal
        Dim cantidadArticulos As Integer = ListaArticulos.Count
        Dim Articulo As New Articulo
        Dim ArticuloDal As New ArticulosMetodos


        Using ts As TransactionScope = New TransactionScope


            For i = 1 To cantidadArticulos


                Articulo.Cod_Articulo = ListaArticulos.Item(i - 1).Cod_Articulo
                Articulo.Precio = ListaArticulos.Item(i - 1).Precio

                'Calculo nuevo precio con el porcentaje de aumento

                NuevoPrecio = Articulo.Precio - ((Articulo.Precio * PorcentajeAumento) / 100)


                If NuevoPrecio > 5 Then

                    ' Si los centavos estan entre 50 y 10 redondeo para arriba

                    If Right(NuevoPrecio, 2) > 10 And Right(NuevoPrecio, 2) < 50 Then

                        Articulo.Precio = Round(NuevoPrecio) + 1

                        ArticuloDal.ActualizarPrecio(Articulo)


                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        ArticuloDal.MovimientoPrecios(Articulo, Fecha)
                    Else

                        Articulo.Precio = Round(NuevoPrecio)

                        ArticuloDal.ActualizarPrecio(Articulo)

                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        ArticuloDal.MovimientoPrecios(Articulo, Fecha)


                    End If

                Else
                    Articulo.Precio = NuevoPrecio

                    ArticuloDal.ActualizarPrecio(Articulo)


                End If

            Next


            ts.Complete()

        End Using





    End Sub



    Public Sub BajaArticulo(articulo)

        Dim ArticuloMetodos As New ArticulosMetodos

        Using ts As TransactionScope = New TransactionScope


            ArticuloMetodos.CopiarArticulo(articulo)


            ArticuloMetodos.EliminarArticulo(articulo)





            ts.Complete()


        End Using



    End Sub


End Class
