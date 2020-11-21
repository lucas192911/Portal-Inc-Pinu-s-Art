Public Class EditarCliente


    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql As String = String.Format("update cliente set telefono ={0}, nombre = '{1}', apellido = '{2}', direccion =  '{3}' where id = {4}", txtTelefono.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, Clientes.dtgMostrar.CurrentRow.Cells(0).Value.ToString)

        Editar(sql)

        Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    apellido as Apellido,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

        Dim dtClientes As DataTable = Consulta(s)

        Clientes.dtgMostrar.AutoGenerateColumns = False
        Clientes.dtgMostrar.DataSource = dtClientes
        Clientes.dtgMostrar.Columns(0).DataPropertyName = "ID"
        Clientes.dtgMostrar.Columns(1).DataPropertyName = "Nombre"
        Clientes.dtgMostrar.Columns(2).DataPropertyName = "Apellido"
        Clientes.dtgMostrar.Columns(3).DataPropertyName = "Telefono"
        Clientes.dtgMostrar.Columns(4).DataPropertyName = "Direccion"

        If PreguntarParaEditar.num2 = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

End Class