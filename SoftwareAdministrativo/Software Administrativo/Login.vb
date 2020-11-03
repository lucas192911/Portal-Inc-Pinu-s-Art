Public Class Login

    Dim pass As String = "123"

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtPassword.Text = pass Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox(z)
            MsgBox("Contraseña incorrecta")
        End If
    End Sub


    Dim x As Integer
    Dim z As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 266
        z = 280
        Timer2.Start()

        Me.ClientSize = New System.Drawing.Size(430, x)
        Me.Location = New Point(465, z)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If z < 266 Then
            z += 1
        Else
            Timer2.Stop()
            TimerDesplegar.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerDesplegar.Tick
        If x <= 438 Then
            x += 20
            Me.ClientSize = New System.Drawing.Size(430, x)
            lblBienvenido.Visible = True
        Else
            TimerDesplegar.Stop()
            btnClose.Visible = True
            Panel1.Visible = True
        End If

        If z > 145 Then
            z -= 20
            Me.Location = New Point(465, z)
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Visible = False
        PictureBox1.Visible = True
    End Sub
End Class
