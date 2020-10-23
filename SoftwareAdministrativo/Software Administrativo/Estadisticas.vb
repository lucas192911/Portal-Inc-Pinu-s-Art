Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Estadisticas

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema; convert zero datetime=True")

        Dim cmd As New MySqlCommand("SELECT COUNT(*)cantidad, monthname(fecha) as Mes from encargo group by month(fecha)", conection)
        Dim adaptador As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adaptador.Fill(dt)

        Chart1.Size = New Size(600, 200)
        Chart1.Series("Series1").XValueMember = "Mes"
        Chart1.Series("Series1").YValueMembers = "cantidad"
        Chart1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
