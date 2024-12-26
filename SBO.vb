Imports SAPbobsCOM
Imports RelojVBNET.ModelUtils

Module SBO
    '@deprecated
    Private Property oCompany As Company

    Public Function ConnectToSAP(SAPUser As String, SAPPasswrd As String) As Boolean
        oCompany = New Company()
        'Console.WriteLine($"SAPUser: {SAPUser} SAPPasswrd {SAPPasswrd} ")
        Try
            ' Configuración de conexión
            Dim com As Company = New Company() With {
            .Server = "192.168.2.115:30015",
            .CompanyDB = "SELTZ29102024",
            .UserName = "Reloj",
            .Password = "123456",
            .LicenseServer = "192.168.2.115:40000",
            .DbServerType = BoDataServerTypes.dst_HANADB,
            .language = BoSuppLangs.ln_Spanish_La,
            .DbUserName = "SYSTEM",
            .DbPassword = "Seltz2024*",
            .UseTrusted = False
            }

            ' Conectar
            If oCompany.Connect() <> 0 Then
                Throw New Exception($"Error al conectar a SAP: {oCompany.GetLastErrorDescription()}")
            End If

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function SendAttendancesRecords(list As List(Of AttendanceRecord)) As Integer
        Dim enviados = 0
        If oCompany IsNot Nothing AndAlso oCompany.Connected Then
            Dim servicio As CompanyService = oCompany.GetCompanyService()
            Dim general As GeneralService = servicio.GetGeneralService("RH_MARCACIONES")

            'insertar los registros de marcaciones a @RH_MARCACIONES
            Dim data As GeneralData
            Dim c As Integer = 0
            For Each row As AttendanceRecord In list
                c += 1
                data = BuildDataFromAttendanceRecord(row, general)
                data.SetProperty("U_ID", c)
                general.Add(data)
                Debug.WriteLine($"{row.DateTime },{row.DeviceNumber }, {row.EnrollNumber }, {row.InOutMode }, {row.VerifyMode },{row.WorkMode}")
            Next

        End If
        Return enviados
    End Function



    Public Sub DisconnectFromSAP()
        If oCompany IsNot Nothing AndAlso oCompany.Connected Then
            oCompany.Disconnect()
            oCompany = Nothing
        End If
    End Sub


    Public Sub Main()

        Dim com As Company = New Company() With {
        .Server = "192.168.2.115:30015",
        .CompanyDB = "SELTZ29102024",
        .UserName = "Reloj",
        .Password = "123456",
        .LicenseServer = "192.168.2.115:40000",
        .DbServerType = BoDataServerTypes.dst_HANADB,
        .language = BoSuppLangs.ln_Spanish_La,
        .DbUserName = "SYSTEM",
        .DbPassword = "Seltz2024*",
        .UseTrusted = False
        }

        Try
            Dim result As Integer = com.Connect()
            If result = 0 Then
                Debug.WriteLine("Conectado")
            Else
                Debug.WriteLine($"Error de conexion {com.GetLastErrorDescription }")
            End If

        Catch ex As Exception
            Debug.WriteLine($"Exception: {ex.Message}")
        Finally
            If com.Connected Then
                com.Disconnect()
            End If

        End Try



    End Sub

End Module
