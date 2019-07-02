Imports Entidades
Imports dal
Imports System.Transactions

Public Class ValidarArticuloClase

    Public Function ValidarArticulo(articulo As Articulo) As Boolean
        Dim ArticuloMetodos As New ArticulosMetodos





        
            If articulo.Descripcion = "" Or (articulo.Descripcion) = " " Then
                MsgBox("Introduzca Descripcion", MsgBoxStyle.Exclamation, "ATENCION")

                Return False
        Else


            Using ts As TransactionScope = New TransactionScope

                ArticuloMetodos.CargarArticulo(articulo)

                Dim Fecha As Date

                Fecha = Now

                articulo.Cod_Articulo = ArticuloMetodos.ObtenerIdDeArticulo.Cod_Articulo

                ArticuloMetodos.MovimientoPrecios(articulo, Fecha)




                ts.Complete()

            End Using




            Return True

        End If





    End Function



End Class
