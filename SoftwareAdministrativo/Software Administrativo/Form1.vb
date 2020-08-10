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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New IngresarCliente
        f.ShowDialog()
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        mostar.ShowDialog()
    End Sub

    
End Class
