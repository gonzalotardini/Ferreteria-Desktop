﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestosForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.AgregarButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckEliminados = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRESUPUESTOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 154)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(889, 286)
        Me.DataGridView1.TabIndex = 2
        '
        'EliminarButton
        '
        Me.EliminarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButton.Image = Global.Ferreteria.My.Resources.Resources.delete12
        Me.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarButton.Location = New System.Drawing.Point(128, 462)
        Me.EliminarButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(141, 48)
        Me.EliminarButton.TabIndex = 3
        Me.EliminarButton.Text = "ELIMINAR"
        Me.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'AgregarButton
        '
        Me.AgregarButton.Location = New System.Drawing.Point(576, 462)
        Me.AgregarButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(128, 48)
        Me.AgregarButton.TabIndex = 4
        Me.AgregarButton.Text = "AGREGAR"
        Me.AgregarButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(196, 105)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(555, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BUSCAR"
        '
        'CheckEliminados
        '
        Me.CheckEliminados.AutoSize = True
        Me.CheckEliminados.Location = New System.Drawing.Point(778, 105)
        Me.CheckEliminados.Name = "CheckEliminados"
        Me.CheckEliminados.Size = New System.Drawing.Size(139, 20)
        Me.CheckEliminados.TabIndex = 7
        Me.CheckEliminados.Text = "Buscar Eliminados"
        Me.CheckEliminados.UseVisualStyleBackColor = True
        '
        'PresupuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 654)
        Me.Controls.Add(Me.CheckEliminados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AgregarButton)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PresupuestosForm"
        Me.Text = "PRESUPUESTOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EliminarButton As System.Windows.Forms.Button
    Friend WithEvents AgregarButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckEliminados As CheckBox
End Class
