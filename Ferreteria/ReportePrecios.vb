Imports dal
Imports BLL
Imports Entidades


Public Class ReportePrecios



    Private Sub ReportePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        Me.WindowState = FormWindowState.Maximized


        RadioButtonDESCRIPCION.Checked = True



        Dim ArticuloMetodos As New ArticulosMetodos

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells ' acomodo automaticamente el tamaño de las celdas

        '  DataGridView1.DataSource = ArticuloMetodos.ObtenerPreciosHistoricos().Tables(0)


    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown

        Dim bandera As Integer = 0

        If RadioButtonCODIGO.Checked = True Then

            Dim articulo As New Articulo
            Dim articuloMetodos As New ArticulosMetodos

            Select e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        articulo.Cod_Articulo_Proveedor = Convert.ToInt64(TextBoxBuscar.Text)
                        DataGridView1.DataSource = articuloMetodos.ObtenerPreciosHistoricosPorCodigo(articulo).Tables(0)

                        TextBoxBuscar.SelectAll()

                        For Each row As DataGridViewRow In DataGridView1.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next



                    Else
                        bandera = 1
                    End If

                    Dim CantidadArticulos As Integer

                    CantidadArticulos = DataGridView1.RowCount - 1
                    '   Label14.Text = CantidadArticulos

            End Select









        End If

        If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

            Dim articulo2 As New Articulo
            Dim articuloMetodos2 As New ArticulosMetodos

            Select Case e.KeyData

                Case Keys.Enter


                    articuloMetodos2.BuscarArticuloPorNombre(articulo2)


                    articulo2.Descripcion = (TextBoxBuscar.Text).ToUpper
                    DataGridView1.DataSource = articuloMetodos2.ObtenerPreciosHistoricosPorDescripcion(articulo2).Tables(0)



                    For Each row As DataGridViewRow In DataGridView1.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    bandera = 0

                    RadioButtonDESCRIPCION.Checked = True
            End Select

            Dim CantidadArticulos As Integer

            CantidadArticulos = DataGridView1.RowCount - 1
            '  Label14.Text = CantidadArticulos
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

    Private Sub RadioButtonCODIGO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCODIGO.CheckedChanged
        If RadioButtonCODIGO.Checked = True Then
            TextBoxBuscar.Text = ""
            Me.Show()
            TextBoxBuscar.Focus()


        End If

        If RadioButtonDESCRIPCION.Checked = True Then
            Me.Show()
            TextBoxBuscar.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub
End Class