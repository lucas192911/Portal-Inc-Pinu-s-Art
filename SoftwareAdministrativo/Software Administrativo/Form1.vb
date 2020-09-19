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



    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mostar.ShowDialog()
    End Sub



    Private Sub btnEncargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncargo.Click
        Eleccion.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
