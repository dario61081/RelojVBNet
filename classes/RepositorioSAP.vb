Imports RelojVBNET.Models
Imports SAPbobsCOM

Public Class DatabaseParams
    Public Property Server As String
    Public Property CompanyDB As String
    Public Property Username As String
    Public Property Password As String
    Public Property LicenseServer As String
    Public Property DbServertype As BoDataServerTypes
    Public Property Language As BoSuppLangs
    Public Property DBUsername As String
    Public Property DBPassword As String
    Public Property UseTrusted As Boolean

End Class

Public Class LocalServerParams
    Inherits DatabaseParams

    Public Sub New()
        Server = "192.168.2.115:30015"
        CompanyDB = "SELTZ29102024"
        Username = "Reloj"
        Password = "123456"
        LicenseServer = "192.168.2.115:40000"
        DbServertype = BoDataServerTypes.dst_HANADB
        Language = BoSuppLangs.ln_Spanish_La
        DBUsername = "SYSTEM"
        DBPassword = "Seltz2024*"
        useTrusted = False
    End Sub

End Class


Public Class RepositorioSAP
    Private Shared oCompany As Company

    Public Shared Function GetInstance(Params As DatabaseParams) As Company
        If oCompany Is Nothing Then

            oCompany = New Company() With {
               .Server = Params.Server,
               .CompanyDB = Params.CompanyDB,
               .UserName = Params.Username,
               .Password = Params.Password,
               .LicenseServer = Params.LicenseServer,
               .DbServerType = Params.DbServertype,
               .language = Params.Language,
               .DbUserName = Params.DBUsername,
               .DbPassword = Params.DBPassword,
               .UseTrusted = Params.UseTrusted
            }

        End If


        Return oCompany
    End Function


End Class
