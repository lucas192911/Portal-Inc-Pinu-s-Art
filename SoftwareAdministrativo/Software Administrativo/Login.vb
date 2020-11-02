Public Class Login

    Dim pass As String = "123"

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.Text = pass Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub
End Class
