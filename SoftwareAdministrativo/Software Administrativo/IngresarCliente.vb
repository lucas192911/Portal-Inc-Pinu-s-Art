Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class IngresarCliente

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sqlValidation As String = "select * from cliente where telefono=" & txtTelefono.Text & ";"
        Dim sql As String = String.Format("insert into cliente(nombre,telefono,direccion) values ('{0}',{1},'{2}');", txtNombre.Text, txtTelefono.Text, txtDireccion.Text)

        insertRegistry(sqlValidation, sql)
    End Sub

    
End Class