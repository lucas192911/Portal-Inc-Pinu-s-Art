Public Class IngresarCliente


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (txtTelefono.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "") Then

            MsgBox("Complete los campos", MsgBoxStyle.Critical)

        Else

            Dim sqlValidation As String = "select * from cliente where telefono=" & txtTelefono.Text & ";"
            Dim sql As String = String.Format("insert into cliente(nombre,telefono,direccion) values ('{0}',{1},'{2}');", txtNombre.Text, txtTelefono.Text, txtDireccion.Text)

            IngresarRegistro(sqlValidation, sql)

            If funciones.num = 0 Then
                Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

                Clientes.dtgMostrar.DataSource = Consulta(s)
                Me.Close()
            End If

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloDigitos(e)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        SoloNumeros(e)
    End Sub
End Class