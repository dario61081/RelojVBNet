Imports SAPbobsCOM
Imports RelojVBNET.SapRepositoryConfig
Public Class SapRepository
    Private Shared Property OCompany As Company
    ''' <summary>
    ''' Obtiene la instancia de la conexion a base de datos dependiento de los parametros aplicados
    ''' </summary>
    ''' <param name="Config">Derivados de SapRepositoryConfig</param>
    ''' <returns>Instancia de Company</returns>
    Public Shared Function GetInstance(Config As SapRepositoryConfig) As Company
        If Config Is Nothing Then
            Throw New Exception("Parametros de la instancia no estan definidas")
        End If


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
