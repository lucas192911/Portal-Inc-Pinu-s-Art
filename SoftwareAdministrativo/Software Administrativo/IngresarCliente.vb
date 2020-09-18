Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class IngresarCliente

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim sqlValidation As String = "select * from cliente where id=" & txtID.Text & ";"
        Dim sql As String = String.Format("insert into cliente(nombre,telefono,descripcion) values ('{0}',{1},'{2}');", txtNombre.Text, txtTelefono.Text, txtDescripcion.Text)

        insertRegistry(sqlValidation, sql)
    End Sub

    ''Example of delete button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sqlValidation As String = "select * from cliente where id= 255;"
        Dim sql As String = "delete from cliente where nombre= '" & txtNombre.Text & "';"

        insertRegistry(sqlValidation, sql)
    End Sub
End Class