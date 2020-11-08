Public Class AgregarMaterialesParaEncargos


    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Agregar_MAteriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = <a>select id , 
                                    nombre,
                                    precio,
                                    descripcion, 
                                    cantidad
                                    from materiales</a>
        Dim dtClientes As DataTable = Consulta(s)

        dtgMostrarMateriales.AutoGenerateColumns = False
        dtgMostrarMateriales.DataSource = dtClientes
        dtgMostrarMateriales.Columns(1).DataPropertyName = "ID"
        dtgMostrarMateriales.Columns(2).DataPropertyName = "Nombre"
        dtgMostrarMateriales.Columns(3).DataPropertyName = "Precio"
        dtgMostrarMateriales.Columns(4).DataPropertyName = "Descripcion"
    End Sub
    
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim sql As String = String.Format("select nombre as Nombre, precio as Precio,cantidad as Cantidad ,descripcion as Descripcion from materiales where nombre like '{0}%';", txtBuscar.Text)

        dtgMostrarMateriales.DataSource = Consulta(sql)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click


        For i As Integer = 0 To dtgMostrarMateriales.Rows.Count - 1
            If CBool(dtgMostrarMateriales.Rows(i).Cells(0).Value) = True Then
                Dim id As Integer = dtgMostrarMateriales.Rows(i).Cells(1).Value
                Dim cant As Integer = dtgMostrarMateriales.Rows(i).Cells(5).Value
                Consulta("update materiales set cantidad = cantidad - " & cant.ToString & " where id = " & id.ToString)
            End If
        Next

    End Sub
End Class