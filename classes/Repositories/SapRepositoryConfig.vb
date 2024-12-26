Imports SAPbobsCOM

Public Class SapRepositoryConfig
    Public Property Server As String
    Public Property CompanyDB As String
    Public Property Username As String
    Public Property Password As String
    Public Property LicenseServer As String
    Public Property DBServerType As BoDataServerTypes
    Public Property Language As BoSuppLangs
    Public Property DBUsername As String
    Public Property DBPassword As String
    Public Property UseTrusted As Boolean


    Public Sub New()
        'valores por defecto
        Language = BoSuppLangs.ln_Spanish_La
        DBServerType = BoDataServerTypes.dst_HANADB
        UseTrusted = False
    End Sub
End Class
