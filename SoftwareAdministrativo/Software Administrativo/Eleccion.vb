Public Class Eleccion

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistente.Click

        Dim dt As New DataTable

        Dim s As String = <a>select id as ID, 
                                    nombre as Nombre,
                                    telefono as Telefono, 
                                    direccion as Direccion 
                                    from cliente</a>

        ClientesParaEncargo.dtgMostrar.DataSource = Consulta(s)

        'AbrirFormEnPanel(Form1.pnlContenedor, mostar)
        ClientesParaEncargo.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Form1.pnlContenedor.Controls.Clear()
        Form1.pnlContenedor.Controls.Add(Form1.pnlContenedorMain)
        Me.Close()
        IngresarClienteParaEncargos.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Eleccion_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class