<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoNuevoForm
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
        Me.LabelCodPresupuesto = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCuit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FinalizarPresupuestoButton = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ArticulosGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LabelTOTAL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QuitarButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.ComprobanteRadioButton = New System.Windows.Forms.RadioButton()
        Me.PresupuestoRadioButton = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GenerarPDFButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCodPresupuesto
        '
        Me.LabelCodPresupuesto.AutoSize = True
        Me.LabelCodPresupuesto.Location = New System.Drawing.Point(410, 6)
        Me.LabelCodPresupuesto.Name = "LabelCodPresupuesto"
        Me.LabelCodPresupuesto.Size = New System.Drawing.Size(0, 13)
        Me.LabelCodPresupuesto.TabIndex = 16
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(381, 25)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(405, 20)
        Me.TextBoxNombre.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NOMBRE"
        '
        'TextBoxCuit
        '
        Me.TextBoxCuit.Location = New System.Drawing.Point(108, 12)
        Me.TextBoxCuit.Name = "TextBoxCuit"
        Me.TextBoxCuit.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCuit.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CODIGO/CUIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    CLIENTE"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(584, 3)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFecha.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nº PRESUPUESTO"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(105, 35)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BUSCAR CLIENTE"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.CodigoBarras, Me.Descripcion, Me.Marca, Me.UnidadMedida, Me.Precio, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(979, 271)
        Me.DataGridView1.TabIndex = 18
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'CodigoBarras
        '
        Me.CodigoBarras.HeaderText = "CodigoBarras"
        Me.CodigoBarras.Name = "CodigoBarras"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'UnidadMedida
        '
        Me.UnidadMedida.HeaderText = "UnidadMedida"
        Me.UnidadMedida.Name = "UnidadMedida"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(668, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL:  $"
        '
        'FinalizarPresupuestoButton
        '
        Me.FinalizarPresupuestoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizarPresupuestoButton.Location = New System.Drawing.Point(997, 261)
        Me.FinalizarPresupuestoButton.Name = "FinalizarPresupuestoButton"
        Me.FinalizarPresupuestoButton.Size = New System.Drawing.Size(131, 42)
        Me.FinalizarPresupuestoButton.TabIndex = 22
        Me.FinalizarPresupuestoButton.Text = "   FINALIZAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRESUPUESTO"
        Me.FinalizarPresupuestoButton.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(15, 383)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(295, 22)
        Me.TextBoxBuscar.TabIndex = 24
        '
        'ArticulosGridView
        '
        Me.ArticulosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosGridView.Location = New System.Drawing.Point(12, 411)
        Me.ArticulosGridView.Name = "ArticulosGridView"
        Me.ArticulosGridView.ReadOnly = True
        Me.ArticulosGridView.Size = New System.Drawing.Size(1207, 281)
        Me.ArticulosGridView.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 36)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.AutoSize = True
        Me.RadioButtonDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(106, 13)
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1274, 704)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 960
        Me.LineShape5.X2 = 960
        Me.LineShape5.Y1 = 325
        Me.LineShape5.Y2 = 368
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 662
        Me.LineShape3.X2 = 956
        Me.LineShape3.Y1 = 367
        Me.LineShape3.Y2 = 367
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 660
        Me.LineShape2.X2 = 660
        Me.LineShape2.Y1 = 325
        Me.LineShape2.Y2 = 366
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 660
        Me.LineShape1.X2 = 957
        Me.LineShape1.Y1 = 325
        Me.LineShape1.Y2 = 325
        '
        'LabelTOTAL
        '
        Me.LabelTOTAL.AutoSize = True
        Me.LabelTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTOTAL.Location = New System.Drawing.Point(780, 326)
        Me.LabelTOTAL.Name = "LabelTOTAL"
        Me.LabelTOTAL.Size = New System.Drawing.Size(137, 42)
        Me.LabelTOTAL.TabIndex = 30
        Me.LabelTOTAL.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 34)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1169, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 42)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "QUITAR TODO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Ferreteria.My.Resources.Resources.agregar
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1006, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 44)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "AGREGAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Ferreteria.My.Resources.Resources.Imprimir2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1006, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 48)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "IMPRIMIR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'QuitarButton
        '
        Me.QuitarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarButton.Image = Global.Ferreteria.My.Resources.Resources.quitar
        Me.QuitarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarButton.Location = New System.Drawing.Point(1006, 103)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(111, 51)
        Me.QuitarButton.TabIndex = 23
        Me.QuitarButton.Text = "QUITAR"
        Me.QuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "SUB TOTAL"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(471, 329)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(0, 24)
        Me.SubTotalLabel.TabIndex = 36
        '
        'ComprobanteRadioButton
        '
        Me.ComprobanteRadioButton.AutoSize = True
        Me.ComprobanteRadioButton.Location = New System.Drawing.Point(1159, 10)
        Me.ComprobanteRadioButton.Name = "ComprobanteRadioButton"
        Me.ComprobanteRadioButton.Size = New System.Drawing.Size(108, 17)
        Me.ComprobanteRadioButton.TabIndex = 38
        Me.ComprobanteRadioButton.TabStop = True
        Me.ComprobanteRadioButton.Text = "COMPROBANTE"
        Me.ComprobanteRadioButton.UseVisualStyleBackColor = True
        '
        'PresupuestoRadioButton
        '
        Me.PresupuestoRadioButton.AutoSize = True
        Me.PresupuestoRadioButton.Location = New System.Drawing.Point(1159, 35)
        Me.PresupuestoRadioButton.Name = "PresupuestoRadioButton"
        Me.PresupuestoRadioButton.Size = New System.Drawing.Size(98, 17)
        Me.PresupuestoRadioButton.TabIndex = 39
        Me.PresupuestoRadioButton.TabStop = True
        Me.PresupuestoRadioButton.Text = "PRESPUESTO"
        Me.PresupuestoRadioButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(1145, 239)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 64)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "PRESUPEUSTOS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GenerarPDFButton
        '
        Me.GenerarPDFButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarPDFButton.Location = New System.Drawing.Point(1169, 183)
        Me.GenerarPDFButton.Name = "GenerarPDFButton"
        Me.GenerarPDFButton.Size = New System.Drawing.Size(75, 38)
        Me.GenerarPDFButton.TabIndex = 41
        Me.GenerarPDFButton.Text = "GENERAR PDF"
        Me.GenerarPDFButton.UseVisualStyleBackColor = True
        '
        'PresupuestoNuevoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 704)
        Me.Controls.Add(Me.GenerarPDFButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PresupuestoRadioButton)
        Me.Controls.Add(Me.ComprobanteRadioButton)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelTOTAL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ArticulosGridView)
        Me.Controls.Add(Me.QuitarButton)
        Me.Controls.Add(Me.FinalizarPresupuestoButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LabelCodPresupuesto)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCuit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "PresupuestoNuevoForm"
        Me.Text = "NUEVO PRESUPUESTO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCodPresupuesto As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FinalizarPresupuestoButton As System.Windows.Forms.Button
    Friend WithEvents QuitarButton As System.Windows.Forms.Button
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ArticulosGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents LabelTOTAL As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents ComprobanteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PresupuestoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GenerarPDFButton As Button
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape5 As PowerPacks.LineShape
    Private WithEvents LineShape3 As PowerPacks.LineShape
    Private WithEvents LineShape2 As PowerPacks.LineShape
    Private WithEvents LineShape1 As PowerPacks.LineShape
End Class
