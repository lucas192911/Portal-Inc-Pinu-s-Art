Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1



    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelFH.Text = Date.Now.ToLongTimeString & "   " & DateTime.Now.ToString("dd/MM/yyyy")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Eleccion.Show()
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mostar.ShowDialog()
    End Sub


    Private Sub PendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendientesToolStripMenuItem.Click
        'showEncargo
    End Sub
End Class
