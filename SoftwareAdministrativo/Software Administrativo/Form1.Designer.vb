<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Nj8ihToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelFH = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Button1.Location = New System.Drawing.Point(233, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nuevo encargo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LavenderBlush
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nj8ihToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Nj8ihToolStripMenuItem
        '
        Me.Nj8ihToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush
        Me.Nj8ihToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosToolStripMenuItem, Me.PendientesToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.MaterialesToolStripMenuItem})
        Me.Nj8ihToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nj8ihToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Nj8ihToolStripMenuItem.Name = "Nj8ihToolStripMenuItem"
        Me.Nj8ihToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.Nj8ihToolStripMenuItem.Text = "Productos"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush
        Me.PreciosToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'PendientesToolStripMenuItem
        '
        Me.PendientesToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush
        Me.PendientesToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.PendientesToolStripMenuItem.Name = "PendientesToolStripMenuItem"
        Me.PendientesToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.PendientesToolStripMenuItem.Text = "Pendientes"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush
        Me.RegistroToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.RegistroToolStripMenuItem.Text = "Clientes"
        '
        'MaterialesToolStripMenuItem
        '
        Me.MaterialesToolStripMenuItem.Name = "MaterialesToolStripMenuItem"
        Me.MaterialesToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.MaterialesToolStripMenuItem.Text = "Materiales"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'LabelFH
        '
        Me.LabelFH.AutoSize = True
        Me.LabelFH.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelFH.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFH.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.LabelFH.Location = New System.Drawing.Point(170, 144)
        Me.LabelFH.Name = "LabelFH"
        Me.LabelFH.Size = New System.Drawing.Size(0, 31)
        Me.LabelFH.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.Fondo_2
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -746)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(681, 1158)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 400)
        Me.Controls.Add(Me.LabelFH)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenid@"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Nj8ihToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelFH As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MaterialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
