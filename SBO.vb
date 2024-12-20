Imports SAPbobsCOM

Module SBO
    Property oCompany As Company



    Public Function ConnectToSAP(SAPUser As String, SAPPasswrd As String) As Boolean
        oCompany = New Company()

        Try
            ' Configuración de conexión
            oCompany.Server = "192.168.2.115:30015"
            oCompany.CompanyDB = "SELTZ29102024"
            oCompany.DbUserName = "SYSTEM"
            oCompany.DbPassword = "Seltz2024*"
            oCompany.UserName = SAPUser
            oCompany.Password = SAPPasswrd
            oCompany.DbServerType = BoDataServerTypes.dst_HANADB
            oCompany.language = BoSuppLangs.ln_Spanish_La

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
            'enviar a ocompany

        End If
        Return enviados
    End Function



    Public Sub DisconnectFromSAP()
        If oCompany IsNot Nothing AndAlso oCompany.Connected Then
            oCompany.Disconnect()
            oCompany = Nothing
        End If
    End Sub


End Module
