Public Class PreguntarParaElminar

    Public num As Integer


    Private Sub btnSI_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSI.Click
        num = 1
        Me.Close()
    End Sub

    Private Sub btnNo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        num = 0
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class