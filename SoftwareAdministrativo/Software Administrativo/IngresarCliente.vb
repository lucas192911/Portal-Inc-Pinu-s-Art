Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class IngresarCliente

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If (txtTelefono.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "") Then

            MsgBox("Complete los campos", MsgBoxStyle.Critical)

        Else

            Dim sqlValidation As String = "select * from cliente where telefono=" & txtTelefono.Text & ";"
            Dim sql As String = String.Format("insert into cliente(nombre,telefono,direccion) values ('{0}',{1},'{2}');", txtNombre.Text, txtTelefono.Text, txtDireccion.Text)

            InsertRow(sqlValidation, sql)
            Me.Hide()
            Ingresar_Encargo.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub IngresarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class