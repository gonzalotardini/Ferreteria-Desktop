Imports Entidades
Imports dal
Imports System.Transactions
Imports SL
Imports Microsoft.VisualBasic.PowerPacks

Public Class ModificarArticuloForm




    Public Cod_Articulo As Integer 'variable publcia que contiene el cod de articulo
    Private articuloMetodos As New ArticulosMetodos
    Private PrecioViejo As Decimal

    Private Sub ModificarArticuloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono




        Dim Articulo As New Articulo
        'Dim Form As New ARTICULOSForm


        Articulo.Cod_Articulo = Cod_Articulo

        'cargo cod proveedor
        articuloMetodos.ObtenerArticuloConID(Articulo)
        TextBox_Cod_Articulo_Proveedor.Text = Articulo.Cod_Articulo_Proveedor

        'cargo descripcion articulo
        TextBox_Descripcion.Text = Articulo.Descripcion

        'cargo precio


        TextBox3.Text = Microsoft.VisualBasic.Right(Articulo.Precio, 2) 'solo los decimales
        TextBox2.Text = Convert.ToInt32(Fix(Articulo.Precio)) ' selecciono solo el número entero, sin decimales

        PrecioViejo = Convert.ToDecimal(TextBox2.Text + "," + TextBox3.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox_Cod_Articulo_Proveedor.Text = "" Then

            MsgBox("Introduzca Codigo de Barras", MsgBoxStyle.Exclamation, "ATENCION")
            TextBox_Cod_Articulo_Proveedor.Focus()
        Else

            If TextBox2.Text = "" Then

                MsgBox("Introduzca precio", MsgBoxStyle.Exclamation, "ATENCION")
                TextBox2.Focus()
            Else
                If TextBox_Stock.Text = "" Then
                    MsgBox("Introduzca Stock", MsgBoxStyle.Exclamation, "ATENCION")
                    TextBox_Stock.Focus()
                Else


                    If ComboBox_Unidad_Medida.SelectedIndex = -1 Then
                        MsgBox("Error, Seleccione Unidad de Medida", MsgBoxStyle.Exclamation, "ATENCIÓN")
                    Else

                        If ComboBox_SubUnidad_Medida.SelectedIndex = -1 Then
                            MsgBox("Error, Seleccione Sub-Unidad de Medida", MsgBoxStyle.Exclamation, "ATENCIÓN")

                        Else

                            If ComboBox_Categoria.SelectedIndex = -1 Then
                                MsgBox("Error, Seleccione Categoría", MsgBoxStyle.Exclamation, "ATENCIÓN")
                            Else

                                If ComboBox_SubCategoria.SelectedIndex = -1 Then
                                    MsgBox("Error, Seleccione Sub-Categoría", MsgBoxStyle.Exclamation, "ATENCIÓN")

                                Else

                                    If ComboBox_Marca.SelectedIndex = -1 Then
                                        MsgBox("Error, Seleccione Marca", MsgBoxStyle.Exclamation, "ATENCIÓN")

                                    Else

                                        Dim Articulo As New Articulo
                                        Dim articuloMetodos As New ArticulosMetodos
                                        Articulo.Cod_Articulo = Cod_Articulo 'variable publcia que contiene el cod de articulo
                                        Articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBox_Cod_Articulo_Proveedor.Text)
                                        Articulo.Descripcion = (TextBox_Descripcion.Text).ToUpper
                                        Articulo.Cod_Unidad_Medida = ComboBox_Unidad_Medida.SelectedValue
                                        Articulo.Cod_SubUnidad_Medida = ComboBox_SubUnidad_Medida.SelectedValue
                                        Articulo.Precio = Convert.ToDecimal(TextBox2.Text + "," + TextBox3.Text)
                                        Articulo.Cod_Categoria = ComboBox_Categoria.SelectedValue
                                        Articulo.Cod_SubCategoria = ComboBox_SubCategoria.SelectedValue
                                        Articulo.Cod_Marca = ComboBox_Marca.SelectedValue
                                        Articulo.Stock = Convert.ToInt32(TextBox_Stock.Text)


                                        Try

                                            Using ts As TransactionScope = New TransactionScope

                                                articuloMetodos.ActualizarArticulo(Articulo)

                                                Dim Fecha As Date
                                                Fecha = Now
                                                Articulo.Cod_Articulo = Cod_Articulo
                                                If PrecioViejo <> Articulo.Precio Then
                                                    articuloMetodos.MovimientoPrecios(Articulo, Fecha)
                                                    ts.Complete()

                                                    ''Verifico si debo enviar mail notificando modificación de precio
                                                    If (articuloMetodos.ExisteEnTienda(Articulo.Cod_Articulo) = True) Then
                                                        Dim articuloEmail = New ArticuloParaEmail
                                                        With articuloEmail
                                                            .Cod_Articulo = Articulo.Cod_Articulo
                                                            .Descripcion = Articulo.Descripcion
                                                            .Descripcion_SubUnidad = ComboBox_SubUnidad_Medida.Text
                                                            .Precio_Anterior = PrecioViejo
                                                            .Precio = Articulo.Precio
                                                        End With

                                                        ''Envio mail notificando modificación de precio
                                                        EnviarEmail(articuloEmail)
                                                        Dim emailService = New EmailService
                                                    End If
                                                Else
                                                    ts.Complete()
                                                End If
                                            End Using

                                            Me.Close()
                                        Catch ex As Exception
                                            MsgBox(ex.Message)
                                        End Try
                                    End If

                                End If

                            End If

                        End If


                    End If


                End If

            End If
        End If













    End Sub
    Public num As Integer = 0

    Private Sub EnviarEmail(articuloEmail As ArticuloParaEmail)
        Dim emailService = New EmailService

        Dim cuerpo As String = "<html>
            <head>
                <style>
                   td {
                        border:solid 1px;                    
                    }
                </style>
             </head>
            <body>
                <table><tbody><tr><td><strong>CodArticulo<strong></td><td><strong>Descripcion<strong></td><td><strong>Medida<strong></td><td><strong>Precio Viejo<strong></td><td><strong>Precio Nuevo<strong></td></tr><tr><td>" + articuloEmail.Cod_Articulo.ToString + "</td><td>" + articuloEmail.Descripcion + "</td><td>" + articuloEmail.Descripcion_SubUnidad + "</td><td>" + articuloEmail.Precio_Anterior.ToString + "</td><td>" + articuloEmail.Precio.ToString + "</td></tr></tbody></table>
            </body>
        </html>"


        ''Dim cuerpo As String = "<table><tbody><tr><td><strong>CodArticulo<strong></td><td><strong>Descripcion<strong></td><td><strong>Medida<strong></td><td><strong>Precio Viejo<strong></td><td><strong>Precio Nuevo<strong></td></tr><tr><td>" + articuloEmail.Cod_Articulo.ToString + "</td><td>" + articuloEmail.Descripcion + "</td><td>" + articuloEmail.Descripcion_SubUnidad + "</td><td>" + articuloEmail.Precio_Anterior.ToString + "</td><td>" + articuloEmail.Precio.ToString + "</td></tr></tbody></table>"
        emailService.EnviarMail(cuerpo)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Descripcion.TextChanged
        Dim articulosMetodos As New ArticulosMetodos
        Dim articulo As New Articulo
        Dim categoria As New Categoria


        'cargo las unidades de medida
        ComboBox_Unidad_Medida.DataSource = articulosMetodos.ObtenerUnidadMedida()
        ComboBox_Unidad_Medida.ValueMember = "Cod_Unidad_Medida"
        ComboBox_Unidad_Medida.DisplayMember = "Descripcion"


        articulo.Cod_Articulo = Cod_Articulo

        articulosMetodos.ObtenerArticuloConID(articulo)


        ComboBox_Unidad_Medida.SelectedValue = articulo.Cod_Unidad_Medida



        'cargo categorias

        ComboBox_Categoria.DataSource = articulosMetodos.ObtenerCategorias
        ComboBox_Categoria.ValueMember = "Cod_Categoria"
        ComboBox_Categoria.DisplayMember = "Descripcion"

        ComboBox_Categoria.SelectedValue = articulo.Cod_Categoria
        num = 1




        'cargo las sub categorias
        categoria.Cod_Categoria = ComboBox_Categoria.SelectedValue

        ComboBox_SubCategoria.DataSource = articulosMetodos.ObtenerSubCategoria(categoria)
        ComboBox_SubCategoria.ValueMember = "Cod_SubCategoria"
        ComboBox_SubCategoria.DisplayMember = "Descripcion"



        articulo.Cod_Articulo = Cod_Articulo

        articulosMetodos.ObtenerArticuloConID(articulo)


        ComboBox_SubCategoria.SelectedValue = articulo.Cod_SubCategoria




        'cargo marcas

        ComboBox_Marca.DataSource = articulosMetodos.ObtenerMarcas
        ComboBox_Marca.ValueMember = "Cod_Marca"
        ComboBox_Marca.DisplayMember = "Descripcion"

        ComboBox_Marca.SelectedValue = articulo.Cod_Marca




        'cargo stock

        TextBox_Stock.Text = articulo.Stock







    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Unidad_Medida.SelectedIndexChanged

        Dim articulosMetodos As New ArticulosMetodos
        Dim articulo As New Articulo
        Dim Unidad_Medida As New UnidadMedida




        Unidad_Medida.Cod_UnidadMedida = ComboBox_Unidad_Medida.SelectedValue


        'cargo las sub unidades de medida
        ComboBox_SubUnidad_Medida.DataSource = articulosMetodos.ObtenerSubUnidadMedida(Unidad_Medida)
        ComboBox_SubUnidad_Medida.ValueMember = "Cod_SubUnidad_Medida"
        ComboBox_SubUnidad_Medida.DisplayMember = "Descripcion"



        articulo.Cod_Articulo = Cod_Articulo

        articulosMetodos.ObtenerArticuloConID(articulo)


        ComboBox_SubUnidad_Medida.SelectedValue = articulo.Cod_SubUnidad_Medida




    End Sub



    Private Sub ComboBox_Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Categoria.SelectedIndexChanged
        Dim ArticulosMetodos As New ArticulosMetodos
        Dim Categoria As New Categoria



        'Cargo las subCategorias
        ' hago este if para que primero me cargue las categorias y despues las sub categorias, es una bandera para que no tire error
        If num = 1 Then
            Categoria.Cod_Categoria = ComboBox_Categoria.SelectedValue

            'Cargo Sub Categorias
            ComboBox_SubCategoria.DataSource = ArticulosMetodos.ObtenerSubCategoria(Categoria)
            ComboBox_SubCategoria.ValueMember = "Cod_SubCategoria"
            ComboBox_SubCategoria.DisplayMember = "Descripcion"
        End If


    End Sub
    'End Sub
End Class