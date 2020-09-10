Public Class Eleccion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        IngresarCliente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As New DataTable


        mostar.DataGridView1.DataSource = showQuery("select * from cliente")
        mostar.Show()
    End Sub
End Class