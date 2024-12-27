''' <summary>
''' Configuracion del servidor local
''' </summary>

Public Class SapLocalServerConfig
    Inherits SapRepositoryConfig

    Public Sub New()

        ' parametros de conexion al servidor local
        Server = "192.168.2.115:30015"
        CompanyDB = "SELTZ29102024"
        Username = "Reloj"
        Password = "123456"
        LicenseServer = "192.168.2.115:40000"
        DBUsername = "SYSTEM"
        DBPassword = "Seltz2024*"
    End Sub

End Class
