Imports System.Net.Mail
Imports System.Net

Public Class Correo
    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario1 As String, destinatario2 As String)
        Try
            correos.To.Clear()
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario1))
            correos.To.Add(Trim(destinatario2))
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "diagonal.dnsrou.com" 'Google: "smtp.gmail.com"
            envios.Port = 587 'Google: 465
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'txbDestinatario.Text = correo1.ToString
        'txbDestinatario.ReadOnly = True
        'txtDestinatario2.Text = correo2.ToString
        'txtDestinatario2.ReadOnly = True
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim dt1 As DataTable = Consulta("select * from email")

        Dim correo1 As String = dt1.Rows(0).Item(1).ToString
        Dim correo2 As String = dt1.Rows(1).Item(1).ToString



        Dim dtClave As DataTable = Consulta("select (aes_decrypt(clave, 'portalinc')) from password")
        Dim clave1 As Byte() = dtClave.Rows(0).Item(0)
        Dim result As String = System.Text.Encoding.UTF8.GetString(clave1)

        Dim clave2 As Byte() = dtClave.Rows(1).Item(0)
        Dim result2 As String = System.Text.Encoding.UTF8.GetString(clave2)

        Dim clave3 As Byte() = dtClave.Rows(2).Item(0)
        Dim resul3 As String = System.Text.Encoding.UTF8.GetString(clave3)
        'Dim clave2 As String = dtClave.Rows(1).Item(0).ToString
        ' Dim clave3 As String = dtClave.Rows(2).Item(0).ToString

        Dim mensaje As String = "Contraseñas " + vbCrLf + result + " || " + vbCrLf + " || " + result2 + vbCrLf + " || " + resul3

        enviarCorreo("programacion@edusalto.uy", "prog@2020", mensaje, "Claves", correo1, correo2)
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class
