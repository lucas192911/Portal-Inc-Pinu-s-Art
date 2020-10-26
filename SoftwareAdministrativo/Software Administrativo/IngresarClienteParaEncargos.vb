Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class IngresarClienteParaEncargos

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If (txtTelefono.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "") Then

            MsgBox("Complete los campos", MsgBoxStyle.Critical)

        Else

            Dim sqlValidation As String = "select * from cliente where telefono=" & txtTelefono.Text & ";"
            Dim sql As String = String.Format("insert into cliente(nombre,telefono,direccion) values ('{0}',{1},'{2}');", txtNombre.Text, txtTelefono.Text, txtDireccion.Text)

            IngresarRegistro(sqlValidation, sql)

            If funciones.num = 0 Then
                Me.Hide()
                Ingresar_Encargo.nombre = txtNombre.Text
                Ingresar_Encargo.telefono = txtTelefono.Text
                Ingresar_Encargo.ShowDialog()
                Me.Close()
            End If

        End If

    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloDigitos(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub IngresarCliente_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class