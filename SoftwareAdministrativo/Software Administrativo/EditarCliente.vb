Public Class EditarCliente


    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sql As String = String.Format("update cliente set telefono ={0}, nombre = '{1}', direccion =  '{2}' where id = {3}", txtTelefono.Text, txtNombre.Text, txtDireccion.Text, Clientes.dtgMostrar.CurrentRow.Cells(0).Value.ToString)

        Editar(sql)

        Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>
        Clientes.dtgMostrar.DataSource = Consulta(s)
        If PreguntarParaEditar.num2 = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class