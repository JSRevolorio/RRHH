Imports System.Data.SqlClient
Imports System.Data

Public Class MasterQuery
    Inherits DataBaseConfiguration

    Protected parameters As List(Of SqlParameter)

    Protected Function ExecuteNonQuery(Query As String) As Integer
        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = Query
                command.CommandType = CommandType.Text

                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next

                Dim result = command.ExecuteNonQuery()
                parameters.Clear()

                Return result
            End Using
        End Using
    End Function

    Protected Function ExecuteReader(Query As String) As DataTable
        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = Query
                command.CommandType = CommandType.Text

                If (parameters IsNot Nothing) Then

                    For Each item As SqlParameter In parameters
                        command.Parameters.Add(item)
                    Next

                End If

                Using reader = command.ExecuteReader()
                    Using table = New DataTable
                        table.Load(reader)

                        reader.Dispose()

                        Return table
                    End Using
                End Using

                parameters.Clear()
            End Using
        End Using
    End Function

End Class
