Imports System.IO

Public Class FormAbout
    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        Dim pdf As Byte() = My.Resources.manual
        Using tmp As New FileStream("manual.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)
        End Using
        Process.Start("manual.pdf")
    End Sub
End Class
