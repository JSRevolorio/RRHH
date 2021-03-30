Imports AutoMapper
Public Class AutoMapperConfiguration
    Private mapperConfiguration As MapperConfiguration
    Private mapper As IMapper

    Public Function Configure() As IMapper

        mapperConfiguration = New MapperConfiguration(Sub(config)
                                                          config.AddProfile(New MapperProfile)
                                                      End Sub)
        mapper = mapperConfiguration.CreateMapper()

        Return mapper
    End Function
End Class
