<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encargo
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgMostrar = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgMostrar
        '
        Me.dtgMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMostrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dtgMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgMostrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMostrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMostrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Fecha, Me.Presupuesto, Me.Descripcion, Me.NombreCliente})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgMostrar.DefaultCellStyle = DataGridViewCellStyle9
        Me.dtgMostrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtgMostrar.EnableHeadersVisualStyles = False
        Me.dtgMostrar.Location = New System.Drawing.Point(0, 0)
        Me.dtgMostrar.Name = "dtgMostrar"
        Me.dtgMostrar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMostrar.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dtgMostrar.RowHeadersVisible = False
        Me.dtgMostrar.RowHeadersWidth = 20
        Me.dtgMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMostrar.Size = New System.Drawing.Size(757, 457)
        Me.dtgMostrar.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(499, 463)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 31)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(625, 463)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(120, 31)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID.DefaultCellStyle = DataGridViewCellStyle7
        Me.ID.HeaderText = "    ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 61
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Fecha
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle8
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Presupuesto
        '
        Me.Presupuesto.HeaderText = "Presupuesto"
        Me.Presupuesto.Name = "Presupuesto"
        Me.Presupuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "NombreCliente"
        Me.NombreCliente.Name = "NombreCliente"
        '
        'Encargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 498)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dtgMostrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Encargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargo"
        CType(Me.dtgMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgMostrar As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Presupuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
End Class
