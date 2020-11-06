Public Class Formulario


    Private Sub Formulario_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If txtEmail.Text <> "" And txtEmailRespaldo.Text <> "" And txtPassword.Text <> "" And txtPassword2.Text <> "" Then

            Dim sql As String = "insert into user(nombre) values ('admin')"
            IngresarRegistro("select * from user", sql)

            Dim sqlCorreo As String = String.Format("insert into email (correo, idUser) values ('{0}',1)", txtEmail.Text)
            Dim sqlCorreoResapldo As String = String.Format("insert into email (correo, idUser) values ('{0}',1)", txtEmailRespaldo.Text)
            Dim sqlPassword As String = String.Format("insert into password (clave, idUser) values (aes_encrypt('{0}','portalinc'),1)", txtPassword.Text)
            Dim sqlPassword2 As String = String.Format("insert into password (clave, idUser) values (aes_encrypt('{0}','portalinc'),1)", txtPassword2.Text)
            Dim sqlPassword3 As String = String.Format("insert into password (clave, idUser) values (aes_encrypt('masterportal','portalinc'),1)")

            IngresarRegistro(sqlCorreo)
            IngresarRegistro(sqlCorreoResapldo)
            IngresarRegistro(sqlPassword)
            IngresarRegistro(sqlPassword2)
            IngresarRegistro(sqlPassword3)
            Me.Close()
        Else
            MsgBox("Complete los campos")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub
End Class
