﻿Public Class mostar

    Private Sub mostar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSeleccionarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarCliente.Click
        dtgMostrar.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText



        If (dtgMostrar.GetCellCount(DataGridViewElementStates.Selected) > 0) Then

            Dim x As Integer
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
End Class