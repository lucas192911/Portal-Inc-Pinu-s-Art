<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Correo
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.lblDestinatario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.lblRemitente = New System.Windows.Forms.Label()
        Me.txbMensaje = New System.Windows.Forms.TextBox()
        Me.txbAsunto = New System.Windows.Forms.TextBox()
        Me.txbDestinatario = New System.Windows.Forms.TextBox()
        Me.txbContraseña = New System.Windows.Forms.TextBox()
        Me.txbRemitente = New System.Windows.Forms.TextBox()
        Me.txtDestinatario2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEnviar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(0, 426)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(656, 45)
        Me.btnEnviar.TabIndex = 21
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(16, 209)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(60, 17)
        Me.lblMensaje.TabIndex = 20
        Me.lblMensaje.Text = "Mensaje"
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsunto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblAsunto.Location = New System.Drawing.Point(38, 157)
        Me.lblAsunto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(52, 17)
        Me.lblAsunto.TabIndex = 19
        Me.lblAsunto.Text = "Asunto"
        '
        'lblDestinatario
        '
        Me.lblDestinatario.AutoSize = True
        Me.lblDestinatario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestinatario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblDestinatario.Location = New System.Drawing.Point(14, 108)
        Me.lblDestinatario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDestinatario.Name = "lblDestinatario"
        Me.lblDestinatario.Size = New System.Drawing.Size(86, 17)
        Me.lblDestinatario.TabIndex = 18
        Me.lblDestinatario.Text = "Destinatario"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblContrasenia.Location = New System.Drawing.Point(307, 63)
        Me.lblContrasenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(84, 17)
        Me.lblContrasenia.TabIndex = 17
        Me.lblContrasenia.Text = "Contraseña"
        '
        'lblRemitente
        '
        Me.lblRemitente.AutoSize = True
        Me.lblRemitente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemitente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblRemitente.Location = New System.Drawing.Point(23, 64)
        Me.lblRemitente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemitente.Name = "lblRemitente"
        Me.lblRemitente.Size = New System.Drawing.Size(74, 17)
        Me.lblRemitente.TabIndex = 16
        Me.lblRemitente.Text = "Remitente"
        '
        'txbMensaje
        '
        Me.txbMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txbMensaje.ForeColor = System.Drawing.Color.White
        Me.txbMensaje.Location = New System.Drawing.Point(95, 208)
        Me.txbMensaje.Margin = New System.Windows.Forms.Padding(2)
        Me.txbMensaje.Multiline = True
        Me.txbMensaje.Name = "txbMensaje"
        Me.txbMensaje.Size = New System.Drawing.Size(455, 153)
        Me.txbMensaje.TabIndex = 15
        '
        'txbAsunto
        '
        Me.txbAsunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txbAsunto.ForeColor = System.Drawing.Color.White
        Me.txbAsunto.Location = New System.Drawing.Point(117, 153)
        Me.txbAsunto.Margin = New System.Windows.Forms.Padding(2)
        Me.txbAsunto.Name = "txbAsunto"
        Me.txbAsunto.Size = New System.Drawing.Size(162, 20)
        Me.txbAsunto.TabIndex = 14
        '
        'txbDestinatario
        '
        Me.txbDestinatario.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txbDestinatario.ForeColor = System.Drawing.Color.White
        Me.txbDestinatario.Location = New System.Drawing.Point(117, 107)
        Me.txbDestinatario.Margin = New System.Windows.Forms.Padding(2)
        Me.txbDestinatario.Name = "txbDestinatario"
        Me.txbDestinatario.Size = New System.Drawing.Size(162, 20)
        Me.txbDestinatario.TabIndex = 13
        '
        'txbContraseña
        '
        Me.txbContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txbContraseña.Enabled = False
        Me.txbContraseña.ForeColor = System.Drawing.Color.White
        Me.txbContraseña.Location = New System.Drawing.Point(409, 60)
        Me.txbContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.txbContraseña.Name = "txbContraseña"
        Me.txbContraseña.Size = New System.Drawing.Size(162, 20)
        Me.txbContraseña.TabIndex = 12
        Me.txbContraseña.Text = "prog@2020"
        '
        'txbRemitente
        '
        Me.txbRemitente.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txbRemitente.Enabled = False
        Me.txbRemitente.ForeColor = System.Drawing.Color.White
        Me.txbRemitente.Location = New System.Drawing.Point(117, 61)
        Me.txbRemitente.Margin = New System.Windows.Forms.Padding(2)
        Me.txbRemitente.Name = "txbRemitente"
        Me.txbRemitente.Size = New System.Drawing.Size(162, 20)
        Me.txbRemitente.TabIndex = 11
        Me.txbRemitente.Text = "programacion@edusalto.uy"
        '
        'txtDestinatario2
        '
        Me.txtDestinatario2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtDestinatario2.ForeColor = System.Drawing.Color.White
        Me.txtDestinatario2.Location = New System.Drawing.Point(310, 107)
        Me.txtDestinatario2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDestinatario2.Name = "txtDestinatario2"
        Me.txtDestinatario2.Size = New System.Drawing.Size(162, 20)
        Me.txtDestinatario2.TabIndex = 22
        '
        'Correo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 471)
        Me.Controls.Add(Me.txtDestinatario2)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblAsunto)
        Me.Controls.Add(Me.lblDestinatario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblRemitente)
        Me.Controls.Add(Me.txbMensaje)
        Me.Controls.Add(Me.txbAsunto)
        Me.Controls.Add(Me.txbDestinatario)
        Me.Controls.Add(Me.txbContraseña)
        Me.Controls.Add(Me.txbRemitente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Correo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents lblDestinatario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents lblRemitente As System.Windows.Forms.Label
    Friend WithEvents txbMensaje As System.Windows.Forms.TextBox
    Friend WithEvents txbAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txbDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents txbContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txbRemitente As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinatario2 As TextBox
End Class
