Public Class mostar

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sentenceSql As String = "select id as ID,nombre as Nombre,telefono as Telefono,descripcion as Descripcion from cliente"
        Dim dt As New DataTable
       
        DataGridView1.DataSource = fillTable(showQuery(sentenceSql), dt)

    End Sub



End Class