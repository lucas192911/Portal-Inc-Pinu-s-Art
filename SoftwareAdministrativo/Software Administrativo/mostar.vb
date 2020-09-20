Public Class mostar

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Dim x As Integer

    Private Sub btnSeleccionarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarCliente.Click
        dtgMostrar.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText



        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then


            'devuleve el valor de la priemra fila
            '   x = dtgMostrar.Rows(0).Cells(0).Value

            'devuelve el valor de la fila seleccionada ||UTILIZAR EN CONSULTA PARA AGREGAR ENCARGOS|| ...............
            x = dtgMostrar.SelectedRows.Item(0).Cells(0).Value

            '  MsgBox(x, MsgBoxStyle.Information, "ID, para consulta")

            Me.Close()
            AbrirFormEnPanel(Form1.pnlContenedor, Ingresar_Encargo)
            'mostrar todo el contenido
            '   Clipboard.SetDataObject(dtgMostrar.GetClipboardContent())

            '   MsgBox(Clipboard.GetText())
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        Form1.pnlContMain.Show()
    End Sub
End Class