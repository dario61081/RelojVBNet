Imports RelojVBNET.Models
Imports SAPbobsCOM

Public Class ModelUtils

    Public Shared Function BuildDataFromAttendanceRecord(Value As AttendanceRecord, DataInterface As GeneralService) As GeneralData
        Dim Data = DataInterface.GetDataInterface(GeneralServiceDataInterfaces.gsGeneralData)
        Data.SetProperty("U_LEGAJO", Value.EnrollNumber)
        Data.SetProperty("U_TIPO_EVENTO", Value.InOutMode)
        Data.SetProperty("U_FECHA", Value.DateTime)
        Data.SetProperty("U_ID_DISP", Value.DeviceNumber)
        Data.SetProperty("U_WORK_MODE", Value.WorkMode)
        Return Data
    End Function



End Class
