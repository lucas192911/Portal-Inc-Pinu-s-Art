Public Class Clientes

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim x As Integer

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        dtgMostrar.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText



        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then


            'devuleve el valor de la priemra fila
            '   x = dtgMostrar.Rows(0).Cells(0).Value

            'devuelve el valor de la fila seleccionada ||UTILIZAR EN CONSULTA PARA AGREGAR ENCARGOS|| ...............
            x = dtgMostrar.SelectedRows.Item(0).Cells(0).Value

            MsgBox(x)

            'mostrar todo el contenido
            '   Clipboard.SetDataObject(dtgMostrar.GetClipboardContent())

            '   MsgBox(Clipboard.GetText())
        End If

    End Sub

    Private Sub btnVovler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVovler.Click
        Me.Close()
    End Sub
End Class