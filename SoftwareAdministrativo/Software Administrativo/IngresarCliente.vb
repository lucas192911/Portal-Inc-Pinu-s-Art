Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class IngresarCliente

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim sentencia As String = "insert into cliente(id,nombre,telefono,descripcion) values ("
            sentencia = sentencia & Me.txtID.Text & ","
            sentencia = sentencia & "'" & Me.txtNombre.Text & "',"
            sentencia = sentencia & Me.txtTelefono.Text & ","
            sentencia = sentencia & "'" & Me.txtDescripcion.Text & "');"


            Dim conexion As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema")
            Dim comando As New MySqlCommand(sentencia, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Datos Guardados")
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IngresarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class