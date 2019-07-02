Imports Entidades
Imports dal
Imports System.Transactions
Imports System.Math


Public Class ArticuloBLL


    Public Sub AumentarPrecioBll(ListaArticulos As List(Of Articulo), PorcentajeAumento As Integer)

        Dim NuevoPrecio As Decimal
        Dim cantidadArticulos As Integer = ListaArticulos.Count
        Dim Articulo As New Articulo
        Dim ArticuloDal As New ArticulosMetodos


        Using ts As TransactionScope = New TransactionScope


            For i = 1 To cantidadArticulos


                Articulo.Cod_Articulo = ListaArticulos.Item(i - 1).Cod_Articulo
                Articulo.Precio = ListaArticulos.Item(i - 1).Precio

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

                    ' Articulo.Cod_Articulo = Cod_Articulo

                    ArticuloDal.MovimientoPrecios(Articulo, Fecha)



                End If

            Next


            ts.Complete()

        End Using





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
