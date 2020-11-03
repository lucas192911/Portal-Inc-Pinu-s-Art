Imports System.Runtime.InteropServices


Public Class Form1


    'boton seleccionado en menú
    Public currentBtn As New Button


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelFH.Text = Date.Now.ToLongTimeString & "   " & DateTime.Now.ToString("dd/MM/yyyy")
    End Sub


    'evento en icono de inicio
    Private Sub pbxLogoMain_MouseEnter(sender As Object, e As EventArgs) Handles pbxLogoMain.MouseEnter
        pbxLogoMain.Visible = False
        pbxMouseHover.Visible = True
    End Sub

    Private Sub pbxMouseHover_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMouseHover.MouseLeave

        pbxMouseHover.Visible = False
        pbxLogoMain.Visible = True
    End Sub




    'Muestra panel de sub-menu de encargo
    Private Sub btnEncargo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncargo.Click
        If pnlSubMenuEncargos.Visible = False Then
            pnlSubMenuEncargos.Visible = True
        Else
            pnlSubMenuEncargos.Visible = False
        End If
    End Sub


    ''Botones cerrar, maximizar, minimizar y restaurar
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Login.Close()
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub


    ''Al arrastrar ventana desde panel de barra de titulo
    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
        If (WindowState = FormWindowState.Normal) Then
            btnMaximizar.Visible = True
            btnRestaurar.Visible = False
        End If

        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)

    End Sub


    'Mostrar label correspondientes a los botones max., min., rest. y cerrar
    Private Sub btnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        lblCerrar.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        lblCerrar.Visible = False
    End Sub

    Private Sub btnMaximizar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaximizar.MouseHover
        lblMaximizar.Visible = True
    End Sub

    Private Sub btnMaximizar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMaximizar.MouseLeave
        lblMaximizar.Visible = False
    End Sub

    Private Sub btnMinimizar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseHover
        lblMinimizar.Visible = True
    End Sub

    Private Sub btnMinimizar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseLeave
        lblMinimizar.Visible = False
    End Sub

    Private Sub btnRestaurar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRestaurar.MouseHover
        lblRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRestaurar.MouseLeave
        lblRestaurar.Visible = False
    End Sub



    'Maximizar y minimizar, por medio del panel de barra de titulo
    Private Sub pnlTitleBar_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDoubleClick

        If (Me.WindowState = FormWindowState.Normal = True) Then
            Me.WindowState = FormWindowState.Maximized
            btnRestaurar.Visible = True
        Else
            Me.WindowState = FormWindowState.Normal
            btnRestaurar.Visible = False
        End If

    End Sub

    ''Boton de encargos pendientes. Establece a boton actual(currentBtn), el color original, y establece
    '' color de seleccion a boton encargos pendientes (subBtnExistente)--
    Private Sub subBtnExistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subBtnPendiente.Click
        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Finalizados") Then

            currentBtn.BackColor = Color.FromArgb(46, 40, 40)

        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If

        subBtnPendiente.BackColor = Color.FromArgb(145, 89, 90)
        currentBtn = subBtnPendiente

        Dim s As String = <a>   select encargo.id, 
                                encargo.nombre, 
                                fecha, presupuesto, 
                                descripcion, 
                                cliente.nombre as nombreCliente
                                from encargo join cliente
                                on id_Cliente = cliente.id
                                where estado = 1</a>
        Encargo.dtgMostrar.AutoGenerateColumns = False
        Encargo.dtgMostrar.DataSource = Consulta(s)
        Encargo.dtgMostrar.Columns(0).DataPropertyName = "id"
        Encargo.dtgMostrar.Columns(1).DataPropertyName = "nombre"
        Encargo.dtgMostrar.Columns(2).DataPropertyName = "fecha"
        Encargo.dtgMostrar.Columns(3).DataPropertyName = "presupuesto"
        Encargo.dtgMostrar.Columns(4).DataPropertyName = "descripcion"
        Encargo.dtgMostrar.Columns(5).DataPropertyName = "nombreCliente"
        AbrirFormEnPanel(Me.pnlContenedor, Encargo)

        If Encargo.Contains(Encargo.btnEliminar) = False Then
            Encargo.Controls.Add(Encargo.btnEliminar)
        End If
    End Sub


    ''Boton de materiales. Establece a boton actual(currentBtn), el color original, y establece
    '' color de seleccion a boton materiales (btnMateriales)--
    Private Sub btnMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMateriales.Click
        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Pendientes") Then

            'comprueba si el boton actual tiene no solo el color de seleccion, si no tambien el nombre 'Pendientes'
            currentBtn.BackColor = Color.FromArgb(46, 40, 40)


        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If


        btnMateriales.BackColor = Color.FromArgb(145, 89, 90)
        currentBtn = btnMateriales


        AbrirFormEnPanel(Me.pnlContenedor, Materiales)

    End Sub


    ''Boton de clientes. Establece a boton actual(currentBtn), el color original, y establece
    '' color de seleccion a boton clientes (btnClientes)--
    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        AbrirFormEnPanel(Me.pnlContenedor, Clientes)
        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Pendientes") Then

            currentBtn.BackColor = Color.FromArgb(46, 40, 40)

        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If

        btnCliente.BackColor = Color.FromArgb(145, 89, 90)
        currentBtn = btnCliente


    End Sub



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        FormAbout.ShowDialog()
    End Sub



    ''Quita todos los controles que estan en pnlContenedor, y le agrega pnlContenedorMain(Inicio)
    Private Sub pbxLogoMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogoMain.Click
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(pnlContenedorMain)
        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Pendientes") Then

            'comprueba si el boton actual tiene no solo el color de seleccion, si no tambien el nombre 'Pendientes'
            currentBtn.BackColor = Color.FromArgb(46, 40, 40)


        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If
    End Sub
    Private Sub pbxMouseHover_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxMouseHover.MouseClick
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(pnlContenedorMain)
        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Pendientes" Or currentBtn.Text = "Finalizados") Then

            'comprueba si el boton actual tiene no solo el color de seleccion, si no tambien el nombre 'Pendientes'
            currentBtn.BackColor = Color.FromArgb(46, 40, 40)


        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If
    End Sub


    ''Boton de nuevo encargo
    Private Sub subBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subBtnNuevo.Click
        Me.Hide()
        Eleccion.Show()
    End Sub

    Private Sub subBtnEstadistica_Click(sender As Object, e As EventArgs) Handles subBtnEstadistica.Click
        Estadisticas.ShowDialog()
    End Sub

    Private Sub subBtnFinalizado_Click(sender As Object, e As EventArgs) Handles subBtnFinalizado.Click
        Dim s As String = "select encargo.id, encargo.nombre, fecha, presupuesto,descripcion,cliente.nombre As nombreCliente From encargo Join cliente On id_Cliente = cliente.id Where estado <> 1"
        Encargo.dtgMostrar.AutoGenerateColumns = False
        Encargo.dtgMostrar.DataSource = Consulta(s)
        Encargo.dtgMostrar.Columns(0).DataPropertyName = "id"
        Encargo.dtgMostrar.Columns(1).DataPropertyName = "nombre"
        Encargo.dtgMostrar.Columns(2).DataPropertyName = "fecha"
        Encargo.dtgMostrar.Columns(3).DataPropertyName = "presupuesto"
        Encargo.dtgMostrar.Columns(4).DataPropertyName = "descripcion"
        Encargo.dtgMostrar.Columns(5).DataPropertyName = "nombreCliente"
        AbrirFormEnPanel(Me.pnlContenedor, Encargo)

        If (currentBtn.BackColor = Color.FromArgb(145, 89, 90) And currentBtn.Text = "Pendientes") Then

            currentBtn.BackColor = Color.FromArgb(46, 40, 40)

        ElseIf (currentBtn.BackColor = Color.FromArgb(145, 89, 90)) Then
            currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        End If

        Encargo.Controls.Remove(Encargo.btnEliminar)

        subBtnFinalizado.BackColor = Color.FromArgb(145, 89, 90)
        currentBtn = subBtnFinalizado
    End Sub

End Class
