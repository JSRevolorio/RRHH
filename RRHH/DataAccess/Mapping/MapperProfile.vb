Imports AutoMapper
Public Class MapperProfile
    Inherits Profile

    Public Sub New()
        CreateMap(Of IDataReader, RoleModel)().ForMember(Function(R) R.Id, Sub(opt)
                                                                               opt.MapFrom(Function(D) D.GetName(0))
                                                                           End Sub).ForMember(Function(R) R.Name, Sub(opt)
                                                                                                                      opt.MapFrom(Function(D) D.GetName(1))
                                                                                                                  End Sub)


        '.ForMember(Function(D) D.Id, Sub(opt)
        '                                 opt.MapFrom(Function(O) O.Columns("id"))
        '                             End Sub).ForMember(Function(D) D.Name, Sub(opt)
        '                                                                        opt.MapFrom(Function(O) O.Columns("name"))
        '                                                                    End Sub)'








        'ForMember(Function(D) D.GetInt32(0), Sub(opt) opt.MapFrom(Function(R) R.Id)).ForMember(Function(D) D.GetString(1), Sub(opt) opt.MapFrom(Function(R) R.Name))
    End Sub
End Class
