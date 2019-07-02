<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoDetalleForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCuit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelCodPresupuesto = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelTOTAL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ArticulosGridView = New System.Windows.Forms.DataGridView()
        Me.QuitarButton = New System.Windows.Forms.Button()
        Me.FinalizarButton = New System.Windows.Forms.Button()
        Me.PresupuestoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ComprobanteRadioButton = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº PRESUPUESTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(521, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FECHA"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(581, 5)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CODIGO/CUIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    CLIENTE"
        '
        'TextBoxCuit
        '
        Me.TextBoxCuit.Location = New System.Drawing.Point(102, 12)
        Me.TextBoxCuit.Name = "TextBoxCuit"
        Me.TextBoxCuit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCuit.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NOMBRE"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(72, 45)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(405, 20)
        Me.TextBoxNombre.TabIndex = 7
        '
        'LabelCodPresupuesto
        '
        Me.LabelCodPresupuesto.AutoSize = True
        Me.LabelCodPresupuesto.Location = New System.Drawing.Point(373, 12)
        Me.LabelCodPresupuesto.Name = "LabelCodPresupuesto"
        Me.LabelCodPresupuesto.Size = New System.Drawing.Size(0, 13)
        Me.LabelCodPresupuesto.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(982, 306)
        Me.DataGridView1.TabIndex = 9
        '
        'LabelTOTAL
        '
        Me.LabelTOTAL.AutoSize = True
        Me.LabelTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTOTAL.Location = New System.Drawing.Point(830, 392)
        Me.LabelTOTAL.Name = "LabelTOTAL"
        Me.LabelTOTAL.Size = New System.Drawing.Size(137, 42)
        Me.LabelTOTAL.TabIndex = 10
        Me.LabelTOTAL.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(699, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TOTAL:  $"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(314, 394)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1021, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "IMPRIMIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ModificarButton
        '
        Me.ModificarButton.Location = New System.Drawing.Point(20, 383)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(116, 41)
        Me.ModificarButton.TabIndex = 14
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(337, 430)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 36)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.AutoSize = True
        Me.RadioButtonDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(103, 13)
        Me.RadioButtonDESCRIPCION.Name = "RadioButtonDESCRIPCION"
        Me.RadioButtonDESCRIPCION.Size = New System.Drawing.Size(140, 22)
        Me.RadioButtonDESCRIPCION.TabIndex = 29
        Me.RadioButtonDESCRIPCION.TabStop = True
        Me.RadioButtonDESCRIPCION.Text = "DESCRIPCION"
        Me.RadioButtonDESCRIPCION.UseVisualStyleBackColor = True
        '
        'RadioButtonCODIGO
        '
        Me.RadioButtonCODIGO.AutoSize = True
        Me.RadioButtonCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCODIGO.Location = New System.Drawing.Point(4, 13)
        Me.RadioButtonCODIGO.Name = "RadioButtonCODIGO"
        Me.RadioButtonCODIGO.Size = New System.Drawing.Size(93, 22)
        Me.RadioButtonCODIGO.TabIndex = 28
        Me.RadioButtonCODIGO.TabStop = True
        Me.RadioButtonCODIGO.Text = "CODIGO"
        Me.RadioButtonCODIGO.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(20, 443)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(295, 22)
        Me.TextBoxBuscar.TabIndex = 29
        '
        'ArticulosGridView
        '
        Me.ArticulosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosGridView.Location = New System.Drawing.Point(12, 472)
        Me.ArticulosGridView.Name = "ArticulosGridView"
        Me.ArticulosGridView.ReadOnly = True
        Me.ArticulosGridView.Size = New System.Drawing.Size(1237, 226)
        Me.ArticulosGridView.TabIndex = 30
        '
        'QuitarButton
        '
        Me.QuitarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarButton.Image = Global.Ferreteria.My.Resources.Resources.quitar
        Me.QuitarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarButton.Location = New System.Drawing.Point(1018, 168)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(111, 51)
        Me.QuitarButton.TabIndex = 32
        Me.QuitarButton.Text = "QUITAR"
        Me.QuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarButton.UseVisualStyleBackColor = True
        '
        'FinalizarButton
        '
        Me.FinalizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizarButton.Location = New System.Drawing.Point(1018, 263)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(108, 47)
        Me.FinalizarButton.TabIndex = 33
        Me.FinalizarButton.Text = "GUARDAR PRESUPUESTO"
        Me.FinalizarButton.UseVisualStyleBackColor = True
        '
        'PresupuestoRadioButton
        '
        Me.PresupuestoRadioButton.AutoSize = True
        Me.PresupuestoRadioButton.Location = New System.Drawing.Point(1021, 43)
        Me.PresupuestoRadioButton.Name = "PresupuestoRadioButton"
        Me.PresupuestoRadioButton.Size = New System.Drawing.Size(98, 17)
        Me.PresupuestoRadioButton.TabIndex = 41
        Me.PresupuestoRadioButton.TabStop = True
        Me.PresupuestoRadioButton.Text = "PRESPUESTO"
        Me.PresupuestoRadioButton.UseVisualStyleBackColor = True
        '
        'ComprobanteRadioButton
        '
        Me.ComprobanteRadioButton.AutoSize = True
        Me.ComprobanteRadioButton.Location = New System.Drawing.Point(1021, 18)
        Me.ComprobanteRadioButton.Name = "ComprobanteRadioButton"
        Me.ComprobanteRadioButton.Size = New System.Drawing.Size(108, 17)
        Me.ComprobanteRadioButton.TabIndex = 40
        Me.ComprobanteRadioButton.TabStop = True
        Me.ComprobanteRadioButton.Text = "COMPROBANTE"
        Me.ComprobanteRadioButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1174, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "GENERAR PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PresupuestoDetalleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 742)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PresupuestoRadioButton)
        Me.Controls.Add(Me.ComprobanteRadioButton)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.QuitarButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ArticulosGridView)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelTOTAL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LabelCodPresupuesto)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCuit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PresupuestoDetalleForm"
        Me.Text = "PRESUPUESTO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LabelCodPresupuesto As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LabelTOTAL As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ModificarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ArticulosGridView As System.Windows.Forms.DataGridView
    Friend WithEvents QuitarButton As System.Windows.Forms.Button
    Friend WithEvents FinalizarButton As System.Windows.Forms.Button
    Friend WithEvents PresupuestoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ComprobanteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As Button
End Class
