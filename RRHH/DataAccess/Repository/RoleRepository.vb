Imports System.Data
Imports System.Data.SqlClient
Imports AutoMapper

Public Class RoleRepository
    Inherits MasterQuery
    Implements IRole

    Private querySelect As String
    Private queryInsert As String
    Private queryUpdate As String
    Private queiryDelete As String
    Private tabla As DataTable
    Private listRole As IList(Of RoleModel)
    Private autoMapperConfiguration As New AutoMapperConfiguration
    Private mapper As IMapper

    Public Sub New()
        querySelect = "SELECT * FROM [dbo].[Role]"
        mapper = autoMapperConfiguration.Configure()
    End Sub

    Public Function GetAll() As List(Of RoleModel) Implements IRole.GetAll
        'listRole =  IList(Of RoleModel)
        tabla = New DataTable()
        tabla = ExecuteReader(querySelect)


        Dim AST As DataTableReader = tabla.CreateDataReader

        Dim go = AST.GetInt32(0)
        Dim dose = AST.GetString(2)



        listRole = mapper.Map(Of IList(Of RoleModel))(tabla.CreateDataReader())

        Return listRole
    End Function
End Class
