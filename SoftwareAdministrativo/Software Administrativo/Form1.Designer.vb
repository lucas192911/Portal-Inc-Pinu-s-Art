﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelFH = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.btnMateriales = New System.Windows.Forms.Button()
        Me.btnPendiente = New System.Windows.Forms.Button()
        Me.btnEncargo = New System.Windows.Forms.Button()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblMaximizar = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblRestaurar = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LabelFH
        '
        Me.LabelFH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFH.AutoSize = True
        Me.LabelFH.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelFH.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFH.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.LabelFH.Location = New System.Drawing.Point(324, 442)
        Me.LabelFH.Name = "LabelFH"
        Me.LabelFH.Size = New System.Drawing.Size(0, 37)
        Me.LabelFH.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.btnCliente)
        Me.pnlMenu.Controls.Add(Me.btnPrecio)
        Me.pnlMenu.Controls.Add(Me.pnlContenedor)
        Me.pnlMenu.Controls.Add(Me.btnMateriales)
        Me.pnlMenu.Controls.Add(Me.btnPendiente)
        Me.pnlMenu.Controls.Add(Me.btnEncargo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(172, 578)
        Me.pnlMenu.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 562)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ayuda"
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnCliente.Location = New System.Drawing.Point(0, 225)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(172, 39)
        Me.btnCliente.TabIndex = 13
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'btnPrecio
        '
        Me.btnPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrecio.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnPrecio.Location = New System.Drawing.Point(0, 339)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(172, 39)
        Me.btnPrecio.TabIndex = 12
        Me.btnPrecio.Text = "Precios"
        Me.btnPrecio.UseVisualStyleBackColor = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(172, 25)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(605, 550)
        Me.pnlContenedor.TabIndex = 15
        '
        'btnMateriales
        '
        Me.btnMateriales.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriales.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnMateriales.Location = New System.Drawing.Point(0, 283)
        Me.btnMateriales.Name = "btnMateriales"
        Me.btnMateriales.Size = New System.Drawing.Size(172, 39)
        Me.btnMateriales.TabIndex = 11
        Me.btnMateriales.Text = "Materiales"
        Me.btnMateriales.UseVisualStyleBackColor = False
        '
        'btnPendiente
        '
        Me.btnPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendiente.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnPendiente.Location = New System.Drawing.Point(0, 107)
        Me.btnPendiente.Name = "btnPendiente"
        Me.btnPendiente.Size = New System.Drawing.Size(172, 39)
        Me.btnPendiente.TabIndex = 10
        Me.btnPendiente.Text = "Pendientes"
        Me.btnPendiente.UseVisualStyleBackColor = False
        '
        'btnEncargo
        '
        Me.btnEncargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEncargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncargo.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnEncargo.Location = New System.Drawing.Point(0, 164)
        Me.btnEncargo.Name = "btnEncargo"
        Me.btnEncargo.Size = New System.Drawing.Size(172, 40)
        Me.btnEncargo.TabIndex = 0
        Me.btnEncargo.Text = "Encargos"
        Me.btnEncargo.UseVisualStyleBackColor = False
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.btnRestaurar)
        Me.pnlTitleBar.Controls.Add(Me.btnMaximizar)
        Me.pnlTitleBar.Controls.Add(Me.btnClose)
        Me.pnlTitleBar.Controls.Add(Me.btnMinimizar)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(172, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(608, 29)
        Me.pnlTitleBar.TabIndex = 11
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(723, 20)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(41, 15)
        Me.lblCerrar.TabIndex = 12
        Me.lblCerrar.Text = "Cerrar"
        Me.lblCerrar.Visible = False
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinimizar.AutoSize = True
        Me.lblMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(680, 20)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(62, 15)
        Me.lblMinimizar.TabIndex = 13
        Me.lblMinimizar.Text = "Minimizar"
        Me.lblMinimizar.Visible = False
        '
        'lblMaximizar
        '
        Me.lblMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaximizar.AutoSize = True
        Me.lblMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblMaximizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximizar.ForeColor = System.Drawing.Color.White
        Me.lblMaximizar.Location = New System.Drawing.Point(715, 20)
        Me.lblMaximizar.Name = "lblMaximizar"
        Me.lblMaximizar.Size = New System.Drawing.Size(65, 15)
        Me.lblMaximizar.TabIndex = 14
        Me.lblMaximizar.Text = "Maximizar"
        Me.lblMaximizar.Visible = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(530, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 29)
        Me.btnRestaurar.TabIndex = 15
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(530, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 29)
        Me.btnMaximizar.TabIndex = 9
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.ic_clear_128_283061
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(565, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 29)
        Me.btnClose.TabIndex = 7
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(489, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 29)
        Me.btnMinimizar.TabIndex = 8
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.Software_Administrativo.My.Resources.Resources.fondo_abstracto_textura_metalica_oro_rosa_1048_7968
        Me.PictureBox2.Location = New System.Drawing.Point(313, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(355, 352)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblRestaurar
        '
        Me.lblRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRestaurar.AutoSize = True
        Me.lblRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaurar.ForeColor = System.Drawing.Color.White
        Me.lblRestaurar.Location = New System.Drawing.Point(715, 20)
        Me.lblRestaurar.Name = "lblRestaurar"
        Me.lblRestaurar.Size = New System.Drawing.Size(61, 15)
        Me.lblRestaurar.TabIndex = 15
        Me.lblRestaurar.Text = "Restaurar"
        Me.lblRestaurar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 578)
        Me.Controls.Add(Me.lblRestaurar)
        Me.Controls.Add(Me.lblMaximizar)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.LabelFH)
        Me.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "de"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlTitleBar.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncargo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelFH As System.Windows.Forms.Label
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnPendiente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents btnPrecio As System.Windows.Forms.Button
    Friend WithEvents btnMateriales As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
    Friend WithEvents lblCerrar As System.Windows.Forms.Label
    Friend WithEvents lblMinimizar As System.Windows.Forms.Label
    Friend WithEvents lblMaximizar As System.Windows.Forms.Label
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents lblRestaurar As System.Windows.Forms.Label

End Class
