<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesForm))
        Me.TextBox_Razon_Social = New System.Windows.Forms.TextBox()
        Me.TextBox_Cuit = New System.Windows.Forms.TextBox()
        Me.TextBox_Direccion = New System.Windows.Forms.TextBox()
        Me.TextBox_Localidad = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.RadioButtonCUIT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRazonSocial = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CopiarButton = New System.Windows.Forms.Button()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CodCliente = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Razon_Social
        '
        Me.TextBox_Razon_Social.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Razon_Social.Location = New System.Drawing.Point(7, 78)
        Me.TextBox_Razon_Social.Name = "TextBox_Razon_Social"
        Me.TextBox_Razon_Social.Size = New System.Drawing.Size(233, 22)
        Me.TextBox_Razon_Social.TabIndex = 0
        '
        'TextBox_Cuit
        '
        Me.TextBox_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Cuit.Location = New System.Drawing.Point(4, 128)
        Me.TextBox_Cuit.Name = "TextBox_Cuit"
        Me.TextBox_Cuit.Size = New System.Drawing.Size(233, 22)
        Me.TextBox_Cuit.TabIndex = 1
        '
        'TextBox_Direccion
        '
        Me.TextBox_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Direccion.Location = New System.Drawing.Point(7, 181)
        Me.TextBox_Direccion.Name = "TextBox_Direccion"
        Me.TextBox_Direccion.Size = New System.Drawing.Size(233, 22)
        Me.TextBox_Direccion.TabIndex = 2
        '
        'TextBox_Localidad
        '
        Me.TextBox_Localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Localidad.Location = New System.Drawing.Point(7, 251)
        Me.TextBox_Localidad.Name = "TextBox_Localidad"
        Me.TextBox_Localidad.Size = New System.Drawing.Size(117, 22)
        Me.TextBox_Localidad.TabIndex = 3
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Telefono.Location = New System.Drawing.Point(7, 301)
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(120, 22)
        Me.TextBox_Telefono.TabIndex = 4
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Email.Location = New System.Drawing.Point(4, 358)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(167, 22)
        Me.TextBox_Email.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RAZÓN SOCIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CUIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LOCALIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TELÉFONO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "EMAIL"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 52)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CLIENTES"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(243, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(944, 364)
        Me.DataGridView1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(630, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 64)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "VER TODOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "BUSCAR"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(347, 99)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxBuscar.TabIndex = 17
        '
        'RadioButtonCUIT
        '
        Me.RadioButtonCUIT.AutoSize = True
        Me.RadioButtonCUIT.Location = New System.Drawing.Point(646, 99)
        Me.RadioButtonCUIT.Name = "RadioButtonCUIT"
        Me.RadioButtonCUIT.Size = New System.Drawing.Size(50, 17)
        Me.RadioButtonCUIT.TabIndex = 18
        Me.RadioButtonCUIT.TabStop = True
        Me.RadioButtonCUIT.Text = "CUIT"
        Me.RadioButtonCUIT.UseVisualStyleBackColor = True
        '
        'RadioButtonRazonSocial
        '
        Me.RadioButtonRazonSocial.AutoSize = True
        Me.RadioButtonRazonSocial.Location = New System.Drawing.Point(726, 99)
        Me.RadioButtonRazonSocial.Name = "RadioButtonRazonSocial"
        Me.RadioButtonRazonSocial.Size = New System.Drawing.Size(104, 17)
        Me.RadioButtonRazonSocial.TabIndex = 19
        Me.RadioButtonRazonSocial.TabStop = True
        Me.RadioButtonRazonSocial.Text = "RAZÓN SOCIAL"
        Me.RadioButtonRazonSocial.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(581, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'CopiarButton
        '
        Me.CopiarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopiarButton.Location = New System.Drawing.Point(266, 559)
        Me.CopiarButton.Name = "CopiarButton"
        Me.CopiarButton.Size = New System.Drawing.Size(75, 23)
        Me.CopiarButton.TabIndex = 21
        Me.CopiarButton.Text = "COPIAR"
        Me.CopiarButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(121, 410)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(79, 52)
        Me.AceptarButton.TabIndex = 22
        Me.AceptarButton.Text = "ACEPTAR"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Location = New System.Drawing.Point(266, 498)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(115, 35)
        Me.ModificarButton.TabIndex = 23
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Codigo"
        '
        'CodCliente
        '
        Me.CodCliente.AutoSize = True
        Me.CodCliente.Location = New System.Drawing.Point(62, 28)
        Me.CodCliente.Name = "CodCliente"
        Me.CodCliente.Size = New System.Drawing.Size(0, 13)
        Me.CodCliente.TabIndex = 25
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 628)
        Me.Controls.Add(Me.CodCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.CopiarButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButtonRazonSocial)
        Me.Controls.Add(Me.RadioButtonCUIT)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.TextBox_Telefono)
        Me.Controls.Add(Me.TextBox_Localidad)
        Me.Controls.Add(Me.TextBox_Direccion)
        Me.Controls.Add(Me.TextBox_Cuit)
        Me.Controls.Add(Me.TextBox_Razon_Social)
        Me.Name = "ClientesForm"
        Me.Text = "CLIENTES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonCUIT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRazonSocial As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CopiarButton As System.Windows.Forms.Button
    Friend WithEvents AceptarButton As System.Windows.Forms.Button
    Friend WithEvents ModificarButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CodCliente As System.Windows.Forms.Label
End Class
