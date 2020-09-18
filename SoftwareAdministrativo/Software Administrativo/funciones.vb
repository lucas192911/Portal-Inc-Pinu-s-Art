Imports MySql.Data.MySqlClient

Module funciones
    Dim conection As New MySqlConnection("server=localhost; user id=root; password=userpass; database=bdsistema")

    Dim adapter As MySqlDataAdapter



    'Validación de registro antes de ingresarlo. 'sentenceValidation: consulta para validar, y sentence: consulta para ingresar'---
    Public Sub insertRegistry(ByVal sentenceValidation As String, ByVal sentence As String)
        conection.Open()
        Dim dtValidation As New DataTable
        Dim searchInTable As DataTable = fillTable(showQuery(sentenceValidation), dtValidation)

        Try

            If searchInTable.Rows.Count > 0 Then
                MsgBox("Ya existe", MsgBoxStyle.Critical)
            Else
                Dim Command As New MySqlCommand(sentence, conection)
                command.ExecuteNonQuery()
                MsgBox("Datos guardados", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conection.Close()
    End Sub


    '---Envía una consulta de obtención de registro, como parametro 'sentence'.Y retorna una variable de tipo MysqlAdapter---
    Public Function showQuery(ByVal sentence As String)
        Try

            adapter = New MySqlDataAdapter(sentence, conection)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return adapter

    End Function

    '---Llena un dataTable con el retorno de showQuery---
    Public Function fillTable(ByVal adapter As MySqlDataAdapter, ByVal dataTable As DataTable)
        Try
            adapter.Fill(DataTable)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return DataTable

    End Function

    
End Module
