Imports Entidades
Imports dal

Public Class ClientesForm

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Cliente As New Cliente
        Dim ClientesMetodos As New ClientesMetodos
        '  Dim ER As New System.Text.RegularExpressions.Regex("^[a-zA-Z ]{1,25}$")



        ' If ER.IsMatch(TextBox_Razon_Social.Text) Then

        Cliente.Razon_Social = (TextBox_Razon_Social.Text).ToUpper
        Cliente.Cuit = Convert.ToInt64(TextBox_Cuit.Text)
        Cliente.Direccion = (TextBox_Direccion.Text).ToUpper
        Cliente.Localidad = (TextBox_Localidad.Text).ToUpper
        Cliente.Telefono = (TextBox_Telefono.Text).ToUpper
        Cliente.Email = (TextBox_Email.Text).ToUpper

        Try
            ClientesMetodos.AgregarCliente(Cliente)
            TextBox_Razon_Social.Text = ""
            TextBox_Cuit.Text = ""
            TextBox_Direccion.Text = ""
            TextBox_Email.Text = ""
            TextBox_Telefono.Text = ""

            MsgBox("Se ha agregado correctamente el cliente", MsgBoxStyle.Information, "INFORMACIÓN")
        Catch ex As Exception
            MsgBox("ERROR al cargar", MsgBoxStyle.Critical, "ATENCIÓN")
        Finally
            DataGridView1.DataSource = ClientesMetodos.ObtenerTodosLosClientes.Tables(0)
        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ClientesMetodos As New ClientesMetodos

        DataGridView1.DataSource = ClientesMetodos.ObtenerTodosLosClientes.Tables(0)




    End Sub

    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono
        Dim clientesMetodos As New ClientesMetodos
        AceptarButton.Enabled = False


        Application.DoEvents()
        TextBoxBuscar.Focus()

        RadioButtonRazonSocial.Select()

        DataGridView1.DataSource = clientesMetodos.ObtenerTodosLosClientes.Tables(0)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        Dim cliente As New Cliente
        Dim ClienteMetodos As New ClientesMetodos



        Select Case True

            Case RadioButtonRazonSocial.Checked
                cliente.Razon_Social = (TextBoxBuscar.Text).ToUpper

                DataGridView1.DataSource = ClienteMetodos.BuscarClientePorRazonSocial(cliente).Tables(0)


            Case RadioButtonCUIT.Checked
                If TextBoxBuscar.Text <> "" Then

                    cliente.Cuit = Convert.ToInt64(TextBoxBuscar.Text)

                    DataGridView1.DataSource = ClienteMetodos.BuscarClientePorCuit(cliente).Tables(0)
                Else
                    DataGridView1.DataSource = ClienteMetodos.ObtenerTodosLosClientes.Tables(0)
                End If

        End Select

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim cliente As New Cliente


        If PresupuestoNuevoForm.Visible = True Then


            cliente.Cuit = DataGridView1.CurrentRow.Cells(2).Value
            cliente.Razon_Social = DataGridView1.CurrentRow.Cells(1).Value.ToString

            PresupuestoNuevoForm.TextBoxNombre.Enabled = True

            PresupuestoNuevoForm.TraerCliente(cliente)

            Me.Close()
            PresupuestoNuevoForm.Show()
        End If

    End Sub

    Private Sub CopiarButton_Click(sender As Object, e As EventArgs) Handles CopiarButton.Click
        Dim valor As String

        If DataGridView1.CurrentRow IsNot Nothing Then

            valor = Convert.ToString(DataGridView1.CurrentRow.Cells(2).Value)

            Clipboard.Clear()
            Clipboard.SetText(valor)

        End If




    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click
        Dim Cliente As New Cliente
        Dim CLienteMetodos As New ClientesMetodos



        Cliente.Cod_Cliente = DataGridView1.CurrentRow.Cells("Cod_Cliente").Value



        Cliente = CLienteMetodos.ObtenerClientePorCodigo(Cliente)

        CodCliente.Text = Cliente.Cod_Cliente
        TextBox_Razon_Social.Text = Cliente.Razon_Social
        TextBox_Cuit.Text = Cliente.Cuit
        TextBox_Direccion.Text = Cliente.Direccion
        TextBox_Localidad.Text = Cliente.Localidad
        TextBox_Telefono.Text = Cliente.Telefono
        TextBox_Email.Text = Cliente.Email

        Button1.Enabled = False
        AceptarButton.Enabled = True


    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Dim Cliente As New Cliente
        Dim ClienteMetodo As New ClientesMetodos



        Cliente.Cod_Cliente = CodCliente.Text
        Cliente.Cuit = (TextBox_Cuit.Text).ToUpper
        Cliente.Direccion = (TextBox_Direccion.Text).ToUpper
        Cliente.Email = (TextBox_Email.Text).ToUpper
        Cliente.Localidad = (TextBox_Localidad.Text).ToUpper
        Cliente.Razon_Social = (TextBox_Razon_Social.Text).ToUpper
        Cliente.Telefono = (TextBox_Telefono.Text).ToUpper

        Try
            ClienteMetodo.ActualizarCliente(Cliente)
            MsgBox("Se he modificado correctamente el Cliente " + Cliente.Razon_Social, MsgBoxStyle.Information, "INFORMACIÓN")

            CodCliente.Text = ""
            TextBox_Cuit.Text = ""
            TextBox_Direccion.Text = ""
            TextBox_Email.Text = ""
            TextBox_Localidad.Text = ""
            TextBox_Razon_Social.Text = ""
            TextBox_Telefono.Text = ""
            AceptarButton.Enabled = False
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class