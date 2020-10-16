Public Class Ingresar_Encargo

    Public id As Integer
    Public nombre As String
    Public telefono As Integer


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ExitAlert.ShowDialog()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Label7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Ingresar_Encargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        Form1.subBtnExistente.BackColor = Color.FromArgb(145, 89, 90)
        Form1.currentBtn = Form1.subBtnExistente

        Dim val As String = String.Format("select * from encargo where nombre = '{0}' and descripcion = '{1}'", txtNombre.Text, txtBxDescripcion.Text)

        If id = 0 Then
            Dim dt As DataTable = Consulta("select id from cliente")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            Dim s As Integer = CStr(row("id"))
            Dim sql As String = String.Format("insert into encargo (nombre, fecha, descripcion, id_Cliente) values ('{0}',now(),'{1}', {2})", txtNombre.Text, txtBxDescripcion.Text, s)
            InsertRow(val, sql)

        Else
            Dim s As String = String.Format("insert into encargo (nombre, fecha, descripcion, id_Cliente) values ('{0}',now(),'{1}', {2})", txtNombre.Text, txtBxDescripcion.Text, id)
            InsertRow(val, s)
        End If

        AbrirFormEnPanel(Form1.pnlContenedor, Encargo)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Agregar_MAteriales.ShowDialog()
    End Sub


End Class