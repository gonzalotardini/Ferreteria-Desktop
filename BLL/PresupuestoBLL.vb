
Imports Entidades
Imports dal
Imports System.Transactions

Public Class PresupuestoBLL


    Public Sub AgregarPresupuestoCompleto(Cabecera As PresupuestoCabecera, ListaDetalle As List(Of PresupuestoDetalle))

        Dim PresupuestoDal As New PresupuestoMetodos
        Dim PresupuestoDetalle As New PresupuestoDetalle
        Dim I As Integer
        Dim cod As Integer




        'Dim ts As TransactionScope = New TransactionScope

        Using ts As TransactionScope = New TransactionScope

            PresupuestoDal.CrearNuevoPresupuestoCabecera(Cabecera)

            cod = (PresupuestoDal.ObtenerCodUltimoPresupuesto.Cod_Presupuesto)




            For I = 1 To ListaDetalle.Count


                'PresupuestoDetalle.Cod_Presupuesto = ListaDetalle.Item(I - 1).Cod_Presupuesto
                PresupuestoDetalle.Cod_Presupuesto = cod
                PresupuestoDetalle.Cantidad = ListaDetalle.Item(I - 1).Cantidad
                PresupuestoDetalle.Cod_Articulo = ListaDetalle.Item(I - 1).Cod_Articulo
                PresupuestoDetalle.Precio = ListaDetalle.Item(I - 1).Precio
                PresupuestoDetalle.Importe = ListaDetalle.Item(I - 1).Importe

                PresupuestoDal.CrearNuevoPresupuestoDetalle(PresupuestoDetalle)



            Next

            ts.Complete()




        End Using

    End Sub



    Public Sub EliminarPresupuesto(CodigoPresupuesto)

        Dim PresupuestoMetodos As New PresupuestoMetodos


        Using ts As TransactionScope = New TransactionScope


            PresupuestoMetodos.SoftEliminarPresupuesto(CodigoPresupuesto)

            'PresupuestoMetodos.EliminarDetalle(CodigoPresupuesto)



            ts.Complete()

        End Using


    End Sub



    Public Sub ActualizarPresupuesto(ByVal _PresupuestoCabecera As PresupuestoCabecera, ByVal _ListaDetalles As List(Of PresupuestoDetalle))



        Dim _PresupuestoDao As New PresupuestoMetodos



        Try


            Using ts As TransactionScope = New TransactionScope



                _PresupuestoDao.EliminarPresupuestoDetalle(_PresupuestoCabecera)
                _PresupuestoDao.ActualizarPresupuestoCabecera(_PresupuestoCabecera)






                For i = 0 To _ListaDetalles.Count - 1

                    _ListaDetalles(i).Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto

                    _PresupuestoDao.CrearNuevoPresupuestoDetalle(_ListaDetalles(i))


                Next



                ts.Complete()





            End Using






        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try

    End Sub


End Class
