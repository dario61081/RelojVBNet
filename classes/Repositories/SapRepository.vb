Imports SAPbobsCOM
Imports RelojVBNET.SapRepositoryConfig
Public Class SapRepository
    Private Shared Property OCompany As Company

    Public Shared Function GetInstance(Config As SapRepositoryConfig) As Company

        If OCompany Is Nothing Then
            OCompany = New Company() With {
                .Server = Config.Server,
                .CompanyDB = Config.CompanyDB,
                .UserName = Config.Username,
                .Password = Config.Password,
                .DbUserName = Config.DBUsername,
                .LicenseServer = Config.LicenseServer,
                .language = Config.Language,
                .DbPassword = Config.DBPassword,
                .DbServerType = Config.DBServerType,
                .UseTrusted = Config.UseTrusted
            }
        End If

        Return OCompany
    End Function
End Class
