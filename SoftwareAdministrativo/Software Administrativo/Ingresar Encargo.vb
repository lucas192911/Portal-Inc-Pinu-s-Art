Public Class Ingresar_Encargo

    Public id As Integer
    Public nombre As String
    Public telefono As Integer


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Beep()
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
        Form1.subBtnPendiente.BackColor = Color.FromArgb(145, 89, 90)
        Form1.currentBtn = Form1.subBtnPendiente

        Dim val As String = String.Format("select * from encargo where nombre = '{0}' and descripcion = '{1}'", txtNombre.Text, txtBxDescripcion.Text)


        If id = 0 Then
            Dim dt As DataTable = Consulta("select id from cliente")
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            Dim s As Integer = CStr(row("id"))
            Dim sql As String = String.Format("insert into encargo (nombre, fecha, descripcion, id_Cliente, estado) values ('{0}',now(),'{1}', {2}, 1)", txtNombre.Text, txtBxDescripcion.Text, s)
            IngresarRegistro(val, sql)

        Else
            Dim s As String = String.Format("insert into encargo (nombre, fecha, descripcion, id_Cliente, estado) values ('{0}',now(),'{1}', {2}, 1)", txtNombre.Text, txtBxDescripcion.Text, id)
            IngresarRegistro(val, s)
        End If
        If funciones.num = 0 Then

            Dim s As String = <a>  select encargo.id, 
                                encargo.nombre, 
                                fecha, presupuesto, 
                                descripcion, 
                                cliente.nombre as nombreCliente
                                from encargo join cliente
                                on id_Cliente = cliente.id
                                where estado = 1</a>

            Encargo.dtgMostrar.AutoGenerateColumns = False
            Encargo.dtgMostrar.DataSource = Consulta(s)
            Encargo.dtgMostrar.Columns(0).DataPropertyName = "id"
            Encargo.dtgMostrar.Columns(1).DataPropertyName = "nombre"
            Encargo.dtgMostrar.Columns(2).DataPropertyName = "fecha"
            Encargo.dtgMostrar.Columns(3).DataPropertyName = "presupuesto"
            Encargo.dtgMostrar.Columns(4).DataPropertyName = "descripcion"
            Encargo.dtgMostrar.Columns(5).DataPropertyName = "nombreCliente"

            AbrirFormEnPanel(Form1.pnlContenedor, Encargo)
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Agregar_MAteriales.ShowDialog()
    End Sub


End Class