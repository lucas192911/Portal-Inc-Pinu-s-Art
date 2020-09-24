Public Class Ingresar_Encargo

   


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ExitAlert.ShowDialog()
        ''sound

    End Sub


    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

   
    Private Sub Label7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Ingresar_Encargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Me.Close()
        AbrirFormEnPanel(Form1.pnlContenedor, Encargo)
        Form1.pnlTitleBar.Controls.Add(Form1.lblEncargos)
        Form1.lblEncargos.Visible = True

        Form1.Show()
    End Sub

    
End Class