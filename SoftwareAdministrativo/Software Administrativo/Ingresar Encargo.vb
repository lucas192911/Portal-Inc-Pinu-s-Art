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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        SoloDigitos(e)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.currentBtn.BackColor = Color.FromArgb(149, 128, 127)
        Form1.subBtnPendiente.BackColor = Color.FromArgb(145, 89, 90)
        Form1.currentBtn = Form1.subBtnPendiente

        Dim val As String = String.Format("select * from encargo where nombre = '{0}' and descripcion = '{1}'", txtNombre.Text, txtBxDescripcion.Text)

        If txtNombre.Text <> "" And txtBxDescripcion.Text <> "" Then

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

            If Modulo.num = 0 Then

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
                Encargo.dtgMostrar.Columns(3).DataPropertyName = "descripcion"
                Encargo.dtgMostrar.Columns(4).DataPropertyName = "nombreCliente"

                AbrirFormEnPanel(Form1.pnlContenedor, Encargo)

                Dim sMtr As String = <A>select * from materiales</A>

                Dim dtMateriales As DataTable = Consulta(sMtr)

                Materiales.dtgMostrar.AutoGenerateColumns = False
                Materiales.dtgMostrar.DataSource = dtMateriales
                Materiales.dtgMostrar.Columns(0).DataPropertyName = "ID"
                Materiales.dtgMostrar.Columns(1).DataPropertyName = "Nombre"
                Materiales.dtgMostrar.Columns(2).DataPropertyName = "Precio"
                Materiales.dtgMostrar.Columns(3).DataPropertyName = "Cantidad"
                Materiales.dtgMostrar.Columns(4).DataPropertyName = "Descripcion"

                Me.Close()
                Form1.Show()
            End If

        Else
            MsgBox("Complete los campos")
        End If

        If txtGastos.Text <> "" And txtManoObra.Text <> "" Then
            Dim num1 As Integer = txtManoObra.Text
            Dim num2 As Integer = txtGastos.Text
            lblMonto.Text = num1 + num2
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AgregarMaterialesParaEncargos.ShowDialog()
    End Sub

    Private Sub txtManoObra_TextChanged(sender As Object, e As EventArgs) Handles txtManoObra.TextChanged
        btnCalcular.Visible = True
    End Sub

    Private Sub txtGastos_TextChanged(sender As Object, e As EventArgs) Handles txtGastos.TextChanged
        btnCalcular.Visible = True
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblMonto.Text = "Monto Total: "
        If txtGastos.Text <> "" And txtManoObra.Text <> "" Then
            Dim num1 As Integer = txtGastos.Text
            Dim num2 As Integer = txtManoObra.Text

            lblMonto.Text += (num1 + num2).ToString
        End If
    End Sub
End Class