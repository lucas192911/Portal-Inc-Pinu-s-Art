﻿Public Class ClientesParaEncargo

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub pnlTitleBar_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown
        ReleaseCapture()

        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnVovler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVovler.Click
        Me.Close()
        Eleccion.Show()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then


            'devuleve el valor de la priemra fila
            '   x = dtgMostrar.Rows(0).Cells(0).Value

            'devuelve el valor de la fila seleccionada ||UTILIZAR EN CONSULTA PARA AGREGAR ENCARGOS|| ...............
            mostar.x = dtgMostrar.SelectedRows.Item(0).Cells(0).Value

            MsgBox(mostar.x)

            'mostrar todo el contenido
            '   Clipboard.SetDataObject(dtgMostrar.GetClipboardContent())

            '   MsgBox(Clipboard.GetText())
        End If
        Me.Close()
        Ingresar_Encargo.ShowDialog()
    End Sub

    Private Sub Label7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        ReleaseCapture()
        SendMesagge(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class