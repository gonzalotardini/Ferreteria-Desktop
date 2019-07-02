Imports dal
Imports Entidades


Public Class SubUnidadMedidaForm

    Private Sub SubUnidadMedidaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icono

        Dim SubUnidadMetodos As New SubUnidadMedidaMetodos

        Dim UnidadMedidaMetodos As New UnidadMedidaMetodos
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        AceptarButton.Enabled = False

        ComboBox1.DataSource = UnidadMedidaMetodos.ObtenerTodasUnidadMedida.Tables(0)

        ComboBox1.ValueMember = "Codigo"
        ComboBox1.DisplayMember = "Descripcion"


        DataGridView1.DataSource = SubUnidadMetodos.ObtenerTodasLasSubUnidadMedia.Tables(0)

    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click

        Dim SubUnidadMedida As New SubUnidad_Medida
        Dim UnidadMedida As New UnidadMedida
        Dim subUnidadMetodos As New SubUnidadMedidaMetodos





        UnidadMedida.Cod_UnidadMedida = ComboBox1.SelectedValue
        SubUnidadMedida.Descripcion_SubUnidad = (TextBox1.Text).ToUpper

        ' If subCategoriaMetodos.AgregarSubCategoria(categoria, Subcategoria) = True Then
        'TextBox1.Text = ""
        'End If

        Try
            subUnidadMetodos.AgregarSubUnidadMedida(SubUnidadMedida, UnidadMedida)
            MsgBox("Se ha agregado correctamente", MsgBoxStyle.Information, "INFORMACIÓN")

        Catch ex As Exception
            MsgBox("ERROR al agregar", MsgBoxStyle.Critical, "ATENCIÓN")

        Finally

            DataGridView1.DataSource = subUnidadMetodos.ObtenerTodasLasSubUnidadMedia.Tables(0)

        End Try




    End Sub


    Public SubUnidadMedidaP As New SubUnidad_Medida
    Public UnidadMedidaP As New UnidadMedida
    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click


        Dim SubUnidadMedidaMetodos As New SubUnidadMedidaMetodos
        Dim UnidadMedidaMetodos As New UnidadMedidaMetodos

        SubUnidadMedidaP.Cod_SubUnidad_Medida = DataGridView1.CurrentRow.Cells(0).Value
        SubUnidadMedidaP.Descripcion_SubUnidad = DataGridView1.CurrentRow.Cells(1).Value



        TextBox1.Text = SubUnidadMedidaP.Descripcion_SubUnidad

        AgregarButton.Enabled = False
        AceptarButton.Enabled = True


        ComboBox1.DataSource = UnidadMedidaMetodos.ObtenerTodasUnidadMedida.Tables(0)
        ComboBox1.ValueMember = "Codigo"
        ComboBox1.DisplayMember = "Descripcion"







        ComboBox1.SelectedValue = SubUnidadMedidaMetodos.ObtenerUnidadMedidaConId(SubUnidadMedidaP).Cod_UnidadMedida


    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Dim SubUnidadMedidaMetodos As New SubUnidadMedidaMetodos



        AgregarButton.Enabled = True

        SubUnidadMedidaP.Cod_Unidad_Medida = ComboBox1.SelectedValue
        SubUnidadMedidaP.Descripcion_SubUnidad = (TextBox1.Text).ToUpper


        SubUnidadMedidaMetodos.ActualizarSubUnidadMedida(SubUnidadMedidaP)

        DataGridView1.DataSource = SubUnidadMedidaMetodos.ObtenerTodasLasSubUnidadMedia.Tables(0)

        TextBox1.Text = ""

        AceptarButton.Enabled = False





    End Sub
End Class