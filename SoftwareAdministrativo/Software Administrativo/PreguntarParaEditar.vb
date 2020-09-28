Public Class PreguntarParaEditar

    Public num2 As Integer

    Private Sub btnSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSI.Click
        num2 = 1
        Me.Close()

    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        num2 = 0
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class