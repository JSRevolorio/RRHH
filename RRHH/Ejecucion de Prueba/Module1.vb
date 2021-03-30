Imports DataAccess
Module Module1

    Sub Main()
        Dim ASD As New RoleRepository
        Dim lis As List(Of RoleModel) = ASD.GetAll()
    End Sub

End Module
