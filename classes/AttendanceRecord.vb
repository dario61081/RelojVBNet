''' <summary>
''' Representa un registro de marcación
''' </summary>
Public Class AttendanceRecord
    Public Property DeviceNumber As Integer
    Public Property EnrollNumber As String
    Public Property VerifyMode As Integer
    Public Property InOutMode As Integer
    Public Property DateTime As DateTime
    Public Property WorkMode As Integer


    Public Function GetFirma() As String
        '(U_FECHA || U_HORA || U_LEGAJO || U_TIPO_EVENTO) AS hash
        '2025-01-02 00:00:00.000000035928

        Dim fecha As String = DateTime.ToString("yyyy-MM-dd")
        Dim hora As String = DateTime.ToString("HHmm")
        Dim legajo As String = $"{EnrollNumber}"
        Dim evento As String = $"{InOutMode}"
        Return $"{fecha}_{hora}_{legajo}_{evento}"
    End Function



End Class
