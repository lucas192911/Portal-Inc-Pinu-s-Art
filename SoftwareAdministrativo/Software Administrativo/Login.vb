Imports System.Security.Cryptography

Public Class Login

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim s As String = String.Format("select (aes_decrypt(clave, 'portalinc')) from password where aes_decrypt(clave,'portalinc') = '{0}'", txtPassword.Text)
        Dim dt As DataTable = Consulta(s)

        If dt.Rows.Count > 0 Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Contraseña incorrecta")
            txtPassword.Clear()
        End If
    End Sub


    Dim x As Integer
    Dim z As Integer
    Dim ancho As Integer
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = Consulta("select * from user")
        If dt.Rows.Count = 0 Then     ''''si no hay un usuario, mostrar formulario---------\\\\\\\
            Formulario.ShowDialog()
        End If
        'Form1.ShowDialog()
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
            txtPassword.Font = New Font("Century Gothic", 14.0F)
        Else
            txtPassword.PasswordChar = "*"
            txtPassword.Font = New Font("Century Gothic", 18.0F)
        End If
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Correo.ShowDialog()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim s As String = String.Format("select (aes_decrypt(clave, 'portalinc')) from password where aes_decrypt(clave,'portalinc') = '{0}'", txtPassword.Text)
            Dim dt As DataTable = Consulta(s)

            If dt.Rows.Count > 0 Then
                Form1.Show()
                Me.Hide()
            Else
                e.SuppressKeyPress = True
                MsgBox("Contraseña incorrecta")
                txtPassword.Clear()
            End If

        End If
    End Sub
End Class
