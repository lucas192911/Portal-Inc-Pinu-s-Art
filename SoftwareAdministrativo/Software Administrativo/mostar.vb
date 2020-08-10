Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class mostar
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = "select * from cliente"
            da = New MySqlDataAdapter(sql, conexion)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class