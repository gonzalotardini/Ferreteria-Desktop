<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal2
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubUnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosEliminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionesArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 54)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "PRESUPUESTOS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 54)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CLIENTES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 54)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ARTÍCULOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtraToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.NuevoPresupuestoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.BackUpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(894, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadMedidaToolStripMenuItem, Me.SubUnidadMedidaToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.SubCategoriaToolStripMenuItem, Me.MarcasToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(56, 25)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'UnidadMedidaToolStripMenuItem
        '
        Me.UnidadMedidaToolStripMenuItem.Name = "UnidadMedidaToolStripMenuItem"
        Me.UnidadMedidaToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.UnidadMedidaToolStripMenuItem.Text = "Unidad Medida"
        '
        'SubUnidadMedidaToolStripMenuItem
        '
        Me.SubUnidadMedidaToolStripMenuItem.Name = "SubUnidadMedidaToolStripMenuItem"
        Me.SubUnidadMedidaToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.SubUnidadMedidaToolStripMenuItem.Text = "SubUnidad Medida"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'SubCategoriaToolStripMenuItem
        '
        Me.SubCategoriaToolStripMenuItem.Name = "SubCategoriaToolStripMenuItem"
        Me.SubCategoriaToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.SubCategoriaToolStripMenuItem.Text = "Sub Categoria"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'NuevoPresupuestoToolStripMenuItem
        '
        Me.NuevoPresupuestoToolStripMenuItem.Name = "NuevoPresupuestoToolStripMenuItem"
        Me.NuevoPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(158, 25)
        Me.NuevoPresupuestoToolStripMenuItem.Text = "Nuevo Presupuesto"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosToolStripMenuItem1, Me.ArticulosEliminadosToolStripMenuItem, Me.ModificacionesArticulosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PreciosToolStripMenuItem1
        '
        Me.PreciosToolStripMenuItem1.Name = "PreciosToolStripMenuItem1"
        Me.PreciosToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.PreciosToolStripMenuItem1.Text = "Precios"
        '
        'ArticulosEliminadosToolStripMenuItem
        '
        Me.ArticulosEliminadosToolStripMenuItem.Name = "ArticulosEliminadosToolStripMenuItem"
        Me.ArticulosEliminadosToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ArticulosEliminadosToolStripMenuItem.Text = "Articulos Eliminados"
        '
        'BackUpToolStripMenuItem
        '
        Me.BackUpToolStripMenuItem.Name = "BackUpToolStripMenuItem"
        Me.BackUpToolStripMenuItem.Size = New System.Drawing.Size(74, 25)
        Me.BackUpToolStripMenuItem.Text = "BackUp"
        '
        'ModificacionesArticulosToolStripMenuItem
        '
        Me.ModificacionesArticulosToolStripMenuItem.Name = "ModificacionesArticulosToolStripMenuItem"
        Me.ModificacionesArticulosToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ModificacionesArticulosToolStripMenuItem.Text = "Modificaciones Articulos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ferreteria.My.Resources.Resources.fondo3
        Me.PictureBox1.InitialImage = Global.Ferreteria.My.Resources.Resources.fondo3
        Me.PictureBox1.Location = New System.Drawing.Point(131, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(751, 414)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Principal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal2"
        Me.Text = "FERRETERIA TARDINI HNOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExtraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubUnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosEliminadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionesArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
