<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Me.MarcaRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubRadioButton = New System.Windows.Forms.RadioButton()
        Me.CategoriaRadioButton = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EXCLUIR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DescontarRadioButon = New System.Windows.Forms.RadioButton()
        Me.AumentarRadioButton = New System.Windows.Forms.RadioButton()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarcaRadioButton
        '
        Me.MarcaRadioButton.AutoSize = True
        Me.MarcaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaRadioButton.Location = New System.Drawing.Point(54, 99)
        Me.MarcaRadioButton.Name = "MarcaRadioButton"
        Me.MarcaRadioButton.Size = New System.Drawing.Size(68, 22)
        Me.MarcaRadioButton.TabIndex = 0
        Me.MarcaRadioButton.TabStop = True
        Me.MarcaRadioButton.Text = "Marca"
        Me.MarcaRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AUMENTAR POR"
        '
        'SubRadioButton
        '
        Me.SubRadioButton.AutoSize = True
        Me.SubRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubRadioButton.Location = New System.Drawing.Point(149, 99)
        Me.SubRadioButton.Name = "SubRadioButton"
        Me.SubRadioButton.Size = New System.Drawing.Size(120, 22)
        Me.SubRadioButton.TabIndex = 2
        Me.SubRadioButton.TabStop = True
        Me.SubRadioButton.Text = "Sub Categoria"
        Me.SubRadioButton.UseVisualStyleBackColor = True
        '
        'CategoriaRadioButton
        '
        Me.CategoriaRadioButton.AutoSize = True
        Me.CategoriaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaRadioButton.Location = New System.Drawing.Point(288, 99)
        Me.CategoriaRadioButton.Name = "CategoriaRadioButton"
        Me.CategoriaRadioButton.Size = New System.Drawing.Size(90, 22)
        Me.CategoriaRadioButton.TabIndex = 3
        Me.CategoriaRadioButton.TabStop = True
        Me.CategoriaRadioButton.Text = "Categoria"
        Me.CategoriaRadioButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(73, 159)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(851, 255)
        Me.DataGridView1.TabIndex = 5
        '
        'EXCLUIR
        '
        Me.EXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXCLUIR.Location = New System.Drawing.Point(332, 148)
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.Size = New System.Drawing.Size(84, 41)
        Me.EXCLUIR.TabIndex = 8
        Me.EXCLUIR.Text = "EXCLUIR"
        Me.EXCLUIR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DescontarRadioButon)
        Me.GroupBox1.Controls.Add(Me.AumentarRadioButton)
        Me.GroupBox1.Controls.Add(Me.AceptarButton)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 489)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 113)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DescontarRadioButon
        '
        Me.DescontarRadioButon.AutoSize = True
        Me.DescontarRadioButon.Location = New System.Drawing.Point(271, 63)
        Me.DescontarRadioButon.Name = "DescontarRadioButon"
        Me.DescontarRadioButon.Size = New System.Drawing.Size(92, 17)
        Me.DescontarRadioButon.TabIndex = 14
        Me.DescontarRadioButon.TabStop = True
        Me.DescontarRadioButon.Text = "DESCONTAR"
        Me.DescontarRadioButon.UseVisualStyleBackColor = True
        '
        'AumentarRadioButton
        '
        Me.AumentarRadioButton.AutoSize = True
        Me.AumentarRadioButton.Location = New System.Drawing.Point(271, 39)
        Me.AumentarRadioButton.Name = "AumentarRadioButton"
        Me.AumentarRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.AumentarRadioButton.TabIndex = 13
        Me.AumentarRadioButton.TabStop = True
        Me.AumentarRadioButton.Text = "AUMENTAR"
        Me.AumentarRadioButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarButton.Location = New System.Drawing.Point(143, 39)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(95, 34)
        Me.AceptarButton.TabIndex = 12
        Me.AceptarButton.Text = "ACEPTAR"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(45, 39)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(69, 35)
        Me.NumericUpDown1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(593, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CANTIDAD DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ARTICULOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(706, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 630)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EXCLUIR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CategoriaRadioButton)
        Me.Controls.Add(Me.SubRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MarcaRadioButton)
        Me.Name = "Precios"
        Me.Text = "PRECIOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CategoriaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EXCLUIR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DescontarRadioButon As System.Windows.Forms.RadioButton
    Friend WithEvents AumentarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AceptarButton As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
