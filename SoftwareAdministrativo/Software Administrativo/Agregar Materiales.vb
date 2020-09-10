Public Class Agregar_Materiales

    Private Sub Agregar_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "select nombre as Nombre, precio as Precio,cantidad as Cantidad,descripcion as Descripcion  from materiales;"

        dtgMostrarProd.DataSource = showQuery(sql)
    End Sub
    Private Sub txtEventChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarProd.TextChanged
        Dim sql As String = String.Format("select nombre as Nombre, precio as Precio,cantidad as Cantidad ,descripcion as Descripcion from materiales where nombre like '{0}%';", txtBuscarProd.Text)

        dtgMostrarProd.DataSource = showQuery(Sql)
    End Sub


End Class