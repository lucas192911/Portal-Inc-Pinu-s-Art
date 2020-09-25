Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Module funciones
    Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema; convert zero datetime=True")

    Dim adapter As MySqlDataAdapter

    Public num As Integer

    'Validación de registro antes de ingresarlo. 'sentenceValidation: consulta para validar, y sentence: consulta para ingresar'---
    Public Sub InsertRow(ByVal sentenceValidation As String, ByVal sentence As String)
        conection.Open()
        Dim dtValidation As New DataTable
        Dim searchInTable As DataTable = Consulta(sentenceValidation)

        Try

            If searchInTable.Rows.Count > 0 Then
                MsgBox("Ya existe", MsgBoxStyle.Critical)
                num = 1
            Else
                Dim Command As New MySqlCommand(sentence, conection)
                Command.ExecuteNonQuery()
                MsgBox("Datos guardados", MsgBoxStyle.Information)
                num = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conection.Close()
    End Sub


    '---Envía una consulta de registro, como parametro 'sentence'.---
    Public Function Consulta(ByVal sentence As String) As DataTable
        Dim dt As New DataTable

        Try
            Dim adapter As New MySqlDataAdapter
            adapter = New MySqlDataAdapter(sentence, conection)
            adapter.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return dt
        conection.Close()
    End Function


    Public Sub Eliminar(ByVal sql As String)
        conection.Open()

        PreguntarParaElminar.ShowDialog()

        If PreguntarParaElminar.num = 1 Then
            Try

                Dim cm As New MySqlCommand(sql, conection)
                cm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try



        End If
        

        conection.Close()
    End Sub


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Sub SendMesagge(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Public Sub AbrirFormEnPanel(ByVal panel As Panel, ByVal FormHijo As Object)
        '''''remover los controles del panel contennedor '''''
        ' If panel.Controls.Count > 0 Then
        'panel.Controls.RemoveAt(0)
        ' End If
        Dim fh As Form = TryCast(FormHijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        panel.Controls.Add(fh)
        panel.Tag = fh
        fh.Show()
        fh.BringToFront()
    End Sub

End Module
