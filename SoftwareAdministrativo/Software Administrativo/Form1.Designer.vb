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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnMateriales = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.pnlSubMenuEncargos = New System.Windows.Forms.Panel()
        Me.subBtnEstadistica = New System.Windows.Forms.Button()
        Me.subBtnFinalizado = New System.Windows.Forms.Button()
        Me.subBtnPendiente = New System.Windows.Forms.Button()
        Me.subBtnNuevo = New System.Windows.Forms.Button()
        Me.btnEncargo = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pbxMouseHover = New System.Windows.Forms.PictureBox()
        Me.pbxLogoMain = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblMaximizar = New System.Windows.Forms.Label()
        Me.lblRestaurar = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlContenedorMain = New System.Windows.Forms.Panel()
        Me.LabelFH = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        Me.pnlSubMenuEncargos.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.pbxMouseHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlContenedorMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnStock)
        Me.pnlMenu.Controls.Add(Me.btnMateriales)
        Me.pnlMenu.Controls.Add(Me.btnCliente)
        Me.pnlMenu.Controls.Add(Me.pnlSubMenuEncargos)
        Me.pnlMenu.Controls.Add(Me.btnEncargo)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(172, 600)
        Me.pnlMenu.TabIndex = 5
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.White
        Me.btnStock.Location = New System.Drawing.Point(0, 420)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStock.Size = New System.Drawing.Size(172, 39)
        Me.btnStock.TabIndex = 12
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnMateriales
        '
        Me.btnMateriales.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMateriales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMateriales.FlatAppearance.BorderSize = 0
        Me.btnMateriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMateriales.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriales.ForeColor = System.Drawing.Color.White
        Me.btnMateriales.Location = New System.Drawing.Point(0, 381)
        Me.btnMateriales.Name = "btnMateriales"
        Me.btnMateriales.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMateriales.Size = New System.Drawing.Size(172, 39)
        Me.btnMateriales.TabIndex = 11
        Me.btnMateriales.Text = "Materiales"
        Me.btnMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMateriales.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.White
        Me.btnCliente.Location = New System.Drawing.Point(0, 342)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCliente.Size = New System.Drawing.Size(172, 39)
        Me.btnCliente.TabIndex = 13
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'pnlSubMenuEncargos
        '
        Me.pnlSubMenuEncargos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlSubMenuEncargos.Controls.Add(Me.subBtnEstadistica)
        Me.pnlSubMenuEncargos.Controls.Add(Me.subBtnFinalizado)
        Me.pnlSubMenuEncargos.Controls.Add(Me.subBtnPendiente)
        Me.pnlSubMenuEncargos.Controls.Add(Me.subBtnNuevo)
        Me.pnlSubMenuEncargos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubMenuEncargos.Location = New System.Drawing.Point(0, 206)
        Me.pnlSubMenuEncargos.Name = "pnlSubMenuEncargos"
        Me.pnlSubMenuEncargos.Size = New System.Drawing.Size(172, 136)
        Me.pnlSubMenuEncargos.TabIndex = 18
        Me.pnlSubMenuEncargos.Visible = False
        '
        'subBtnEstadistica
        '
        Me.subBtnEstadistica.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnEstadistica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subBtnEstadistica.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtnEstadistica.FlatAppearance.BorderSize = 0
        Me.subBtnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.subBtnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtnEstadistica.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtnEstadistica.ForeColor = System.Drawing.Color.White
        Me.subBtnEstadistica.Location = New System.Drawing.Point(0, 102)
        Me.subBtnEstadistica.Name = "subBtnEstadistica"
        Me.subBtnEstadistica.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.subBtnEstadistica.Size = New System.Drawing.Size(172, 34)
        Me.subBtnEstadistica.TabIndex = 16
        Me.subBtnEstadistica.Text = "Estadisticas"
        Me.subBtnEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subBtnEstadistica.UseVisualStyleBackColor = False
        '
        'subBtnFinalizado
        '
        Me.subBtnFinalizado.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnFinalizado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subBtnFinalizado.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtnFinalizado.FlatAppearance.BorderSize = 0
        Me.subBtnFinalizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnFinalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.subBtnFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtnFinalizado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtnFinalizado.ForeColor = System.Drawing.Color.White
        Me.subBtnFinalizado.Location = New System.Drawing.Point(0, 68)
        Me.subBtnFinalizado.Name = "subBtnFinalizado"
        Me.subBtnFinalizado.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.subBtnFinalizado.Size = New System.Drawing.Size(172, 34)
        Me.subBtnFinalizado.TabIndex = 17
        Me.subBtnFinalizado.Text = "Finalizados"
        Me.subBtnFinalizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subBtnFinalizado.UseVisualStyleBackColor = False
        '
        'subBtnPendiente
        '
        Me.subBtnPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subBtnPendiente.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtnPendiente.FlatAppearance.BorderSize = 0
        Me.subBtnPendiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnPendiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.subBtnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtnPendiente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtnPendiente.ForeColor = System.Drawing.Color.White
        Me.subBtnPendiente.Location = New System.Drawing.Point(0, 34)
        Me.subBtnPendiente.Name = "subBtnPendiente"
        Me.subBtnPendiente.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.subBtnPendiente.Size = New System.Drawing.Size(172, 34)
        Me.subBtnPendiente.TabIndex = 15
        Me.subBtnPendiente.Text = "Pendientes"
        Me.subBtnPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subBtnPendiente.UseVisualStyleBackColor = False
        '
        'subBtnNuevo
        '
        Me.subBtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subBtnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.subBtnNuevo.FlatAppearance.BorderSize = 0
        Me.subBtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.subBtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.subBtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtnNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subBtnNuevo.ForeColor = System.Drawing.Color.White
        Me.subBtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.subBtnNuevo.Name = "subBtnNuevo"
        Me.subBtnNuevo.Padding = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.subBtnNuevo.Size = New System.Drawing.Size(172, 34)
        Me.subBtnNuevo.TabIndex = 16
        Me.subBtnNuevo.Text = "Nuevo"
        Me.subBtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subBtnNuevo.UseVisualStyleBackColor = False
        '
        'btnEncargo
        '
        Me.btnEncargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEncargo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncargo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEncargo.FlatAppearance.BorderSize = 0
        Me.btnEncargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncargo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncargo.ForeColor = System.Drawing.Color.White
        Me.btnEncargo.Location = New System.Drawing.Point(0, 166)
        Me.btnEncargo.Name = "btnEncargo"
        Me.btnEncargo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEncargo.Size = New System.Drawing.Size(172, 40)
        Me.btnEncargo.TabIndex = 13
        Me.btnEncargo.Text = "Encargos"
        Me.btnEncargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncargo.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.pbxMouseHover)
        Me.pnlLogo.Controls.Add(Me.pbxLogoMain)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(172, 166)
        Me.pnlLogo.TabIndex = 13
        '
        'pbxMouseHover
        '
        Me.pbxMouseHover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMouseHover.Image = Global.Software_Administrativo.My.Resources.Resources.a0859098_ea84_4cf9_8be6_91fd6c75577d_200x200
        Me.pbxMouseHover.Location = New System.Drawing.Point(12, 29)
        Me.pbxMouseHover.Name = "pbxMouseHover"
        Me.pbxMouseHover.Size = New System.Drawing.Size(140, 114)
        Me.pbxMouseHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMouseHover.TabIndex = 14
        Me.pbxMouseHover.TabStop = False
        Me.pbxMouseHover.Visible = False
        '
        'pbxLogoMain
        '
        Me.pbxLogoMain.Image = Global.Software_Administrativo.My.Resources.Resources._0bf9f93d_cfca_4c90_b06a_0faed3d8896c_200x200
        Me.pbxLogoMain.Location = New System.Drawing.Point(12, 29)
        Me.pbxLogoMain.Name = "pbxLogoMain"
        Me.pbxLogoMain.Size = New System.Drawing.Size(140, 114)
        Me.pbxLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogoMain.TabIndex = 13
        Me.pbxLogoMain.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 578)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "About"
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
        Me.pnlTitleBar.Size = New System.Drawing.Size(878, 29)
        Me.pnlTitleBar.TabIndex = 11
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = Global.Software_Administrativo.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(800, 0)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(800, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(835, 0)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(759, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 29)
        Me.btnMinimizar.TabIndex = 8
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'lblCerrar
        '
        Me.lblCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCerrar.AutoSize = True
        Me.lblCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(993, 29)
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
        Me.lblMinimizar.Location = New System.Drawing.Point(950, 29)
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
        Me.lblMaximizar.Location = New System.Drawing.Point(985, 29)
        Me.lblMaximizar.Name = "lblMaximizar"
        Me.lblMaximizar.Size = New System.Drawing.Size(65, 15)
        Me.lblMaximizar.TabIndex = 14
        Me.lblMaximizar.Text = "Maximizar"
        Me.lblMaximizar.Visible = False
        '
        'lblRestaurar
        '
        Me.lblRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRestaurar.AutoSize = True
        Me.lblRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaurar.ForeColor = System.Drawing.Color.White
        Me.lblRestaurar.Location = New System.Drawing.Point(985, 29)
        Me.lblRestaurar.Name = "lblRestaurar"
        Me.lblRestaurar.Size = New System.Drawing.Size(61, 15)
        Me.lblRestaurar.TabIndex = 15
        Me.lblRestaurar.Text = "Restaurar"
        Me.lblRestaurar.Visible = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlContenedorMain)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(172, 29)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(878, 571)
        Me.pnlContenedor.TabIndex = 16
        '
        'pnlContenedorMain
        '
        Me.pnlContenedorMain.Controls.Add(Me.LabelFH)
        Me.pnlContenedorMain.Controls.Add(Me.PictureBox1)
        Me.pnlContenedorMain.Controls.Add(Me.PictureBox2)
        Me.pnlContenedorMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedorMain.ForeColor = System.Drawing.Color.Black
        Me.pnlContenedorMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedorMain.Name = "pnlContenedorMain"
        Me.pnlContenedorMain.Size = New System.Drawing.Size(878, 571)
        Me.pnlContenedorMain.TabIndex = 0
        '
        'LabelFH
        '
        Me.LabelFH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFH.AutoSize = True
        Me.LabelFH.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LabelFH.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelFH.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFH.ForeColor = System.Drawing.Color.White
        Me.LabelFH.Location = New System.Drawing.Point(255, 442)
        Me.LabelFH.Name = "LabelFH"
        Me.LabelFH.Size = New System.Drawing.Size(0, 39)
        Me.LabelFH.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Software_Administrativo.My.Resources.Resources.Dibujo_sin_título1
        Me.PictureBox1.Location = New System.Drawing.Point(231, 434)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.Software_Administrativo.My.Resources.Resources.fondo_abstracto_textura_metalica_oro_rosa_1048_7968
        Me.PictureBox2.Location = New System.Drawing.Point(265, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(355, 352)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1050, 600)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.lblRestaurar)
        Me.Controls.Add(Me.lblMaximizar)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlMenu)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.pnlSubMenuEncargos.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.pbxMouseHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedorMain.ResumeLayout(False)
        Me.pnlContenedorMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnMateriales As System.Windows.Forms.Button
    Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
    Friend WithEvents lblCerrar As System.Windows.Forms.Label
    Friend WithEvents lblMinimizar As System.Windows.Forms.Label
    Friend WithEvents lblMaximizar As System.Windows.Forms.Label
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents lblRestaurar As System.Windows.Forms.Label
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents pnlContenedorMain As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelFH As System.Windows.Forms.Label
    Friend WithEvents pnlSubMenuEncargos As System.Windows.Forms.Panel
    Friend WithEvents subBtnNuevo As System.Windows.Forms.Button
    Friend WithEvents subBtnPendiente As System.Windows.Forms.Button
    Friend WithEvents btnEncargo As System.Windows.Forms.Button
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents pbxLogoMain As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMouseHover As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents subBtnEstadistica As Button
    Friend WithEvents subBtnFinalizado As Button
End Class
