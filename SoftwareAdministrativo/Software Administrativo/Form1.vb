Imports System.Runtime.InteropServices

Public Class Form1



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelFH.Text = Date.Now.ToLongTimeString & "   " & DateTime.Now.ToString("dd/MM/yyyy")
    End Sub



    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mostar.ShowDialog()
    End Sub

    Private Sub btnEncargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncargo.Click
        Eleccion.Show()
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
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
End Class
