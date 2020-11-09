Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Estadisticas

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Dim varAño As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema; convert zero datetime=True")
        Dim sql As String = String.Format("SELECT COUNT(*)cantidad, monthname(fecha) as Mes from encargo where year(fecha) = '{0}' group by month(fecha)", varAño)
        Dim cmd As New MySqlCommand(Sql, conection)
        Dim adaptador As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adaptador.Fill(dt)

        Chart1.Size = New Size(600, 200)
        Chart1.Series("Series1").XValueMember = "Mes"
        Chart1.Series("Series1").YValueMembers = "cantidad"
        Chart1.DataSource = dt

        Dim año As String = "SELECT id as id, year(fecha) as a from encargo  group by  year(fecha)"
        Dim dtA As DataTable = Consulta(año)
        ComboBox1.DataSource = dtA
        ComboBox1.DisplayMember = "a"
        ComboBox1.ValueMember = "a"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        varAño = ComboBox1.SelectedValue.ToString

        Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema; convert zero datetime=True")
        Dim sql As String = String.Format("SELECT COUNT(*)cantidad, monthname(fecha) as Mes from encargo where year(fecha) = '{0}' group by month(fecha)", varAño)
        Dim cmd As New MySqlCommand(sql, conection)
        Dim adaptador As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adaptador.Fill(dt)

        Chart1.Size = New Size(600, 200)
        Chart1.Series("Series1").XValueMember = "Mes"
        Chart1.Series("Series1").YValueMembers = "cantidad"
        Chart1.DataSource = dt
    End Sub
End Class
