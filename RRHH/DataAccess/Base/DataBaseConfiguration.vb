Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class DataBaseConfiguration

    Private ReadOnly connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("RRHH").ToString
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
