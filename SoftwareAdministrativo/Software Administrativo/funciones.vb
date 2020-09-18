Imports MySql.Data.MySqlClient

Module funciones
    Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema")




    'Validación de registro antes de ingresarlo. 'sentenceValidation: consulta para validar, y sentence: consulta para ingresar'---
    Public Sub InsertRow(ByVal sentenceValidation As String, ByVal sentence As String)
        conection.Open()
        Dim dtValidation As New DataTable
        Dim searchInTable As DataTable = Consulta(sentenceValidation)

        Try

            If searchInTable.Rows.Count > 0 Then
                MsgBox("Ya existe", MsgBoxStyle.Critical)
            Else
                Dim Command As New MySqlCommand(sentence, conection)
                Command.ExecuteNonQuery()
                MsgBox("Datos guardados", MsgBoxStyle.Information)
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

    End Function

    
    
End Module
