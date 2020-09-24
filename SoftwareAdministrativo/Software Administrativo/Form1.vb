Imports System.Runtime.InteropServices

Public Class Form1



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelFH.Text = Date.Now.ToLongTimeString & "   " & DateTime.Now.ToString("dd/MM/yyyy")
    End Sub


    Private Sub pbxLogoMain_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogoMain.MouseHover

        pbxLogoMain.Visible = False
        pbxMouseHover.Visible = True
    End Sub

    Private Sub pbxMouseHover_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMouseHover.MouseLeave

        pbxMouseHover.Visible = False
        pbxLogoMain.Visible = True
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mostar.ShowDialog()
    End Sub

    Private Sub btnEncargo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncargo.Click
        'Eleccion.Show()
        If pnlSubMenuEncargos.Visible = False Then
            pnlSubMenuEncargos.Visible = True
        Else
            pnlSubMenuEncargos.Visible = False
        End If
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
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



    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub lblClientes_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblClientes.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblEncargos_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblEncargos.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblMateriales_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblMateriales.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblPrecios_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPrecios.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub






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




    Private Sub pnlTitleBar_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDoubleClick

        If (Me.WindowState = FormWindowState.Normal = True) Then
            Me.WindowState = FormWindowState.Maximized
            btnRestaurar.Visible = True
        Else
            Me.WindowState = FormWindowState.Normal
            btnRestaurar.Visible = False
        End If

    End Sub

    
    Private Sub btnMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMateriales.Click
        Dim s As String = <A>select id as ID, 
                                nombre as Nombre, 
                                precio as Precio, 
                                cantidad as Cantidad, 
                                descripcion as Descripcion 
                             from materiales</A>

        Materiales.dtgMostrar.DataSource = Consulta(s)
        AbrirFormEnPanel(Me.pnlContenedor, Materiales)

        quitarLbl()
        Me.pnlTitleBar.Controls.Add(lblMateriales)
        lblMateriales.Visible = True
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

        mostar.dtgMostrar.DataSource = Consulta(s)

        AbrirFormEnPanel(Me.pnlContenedor, mostar)

        quitarLbl()
        Me.pnlTitleBar.Controls.Add(lblClientes)
        lblClientes.Visible = True
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        FormAbout.ShowDialog()
    End Sub




    Public Sub quitarLbl()
        Me.pnlTitleBar.Controls.Clear()
        Me.pnlTitleBar.Controls.Add(btnClose)
        Me.pnlTitleBar.Controls.Add(btnMaximizar)
        Me.pnlTitleBar.Controls.Add(btnMinimizar)
    End Sub


    Private Sub pbxLogoMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogoMain.Click
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(pnlContenedorMain)

        quitarLbl()

    End Sub



    Private Sub pbxMouseHover_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxMouseHover.MouseClick
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(pnlContenedorMain)

        quitarLbl()
    End Sub



    Private Sub subBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subBtnNuevo.Click

        Eleccion.Show()
        Me.Hide()
    End Sub

    Private Sub subBtnExistente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subBtnExistente.Click
        AbrirFormEnPanel(Me.pnlContenedor, Encargo)

        quitarLbl()
        Me.pnlTitleBar.Controls.Add(lblEncargos)
        lblEncargos.Visible = True
    End Sub

End Class
