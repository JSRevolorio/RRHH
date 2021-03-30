Public Interface IGeneric(Of Entity As Class)
    Function GetAll() As List(Of Entity)
    Function Add(entity As Entity) As Integer
    Function Update(entity As Entity) As Integer
    Function Delete(entity As Entity) As Integer
End Interface
