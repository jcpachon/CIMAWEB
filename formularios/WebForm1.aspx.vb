Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class WebForm1
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private service As New CIMAServeiIntegracio.ServeiIntegracio

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)
        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima", "98yREc37", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        If Request("envio_cita") = "S" Then

            Dim l_transaccion As New CIMAServeiIntegracio.Transaccio


            l_transaccion = service.BegginTransaction()

            'service.ConfirmarHoraPacient(l_transaccion.ID,True,

            service.CommitTransaccio(l_transaccion.ID, True)

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio

        Dim l_horas_reservadas() As CIMAServeiIntegracio.HoraReservada
        Dim l_mantener_horas_reservadas() As CIMAServeiIntegracio.HoraReservada

        Dim n As Integer



        l_transaccion = service.BegginTransaction()

        'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, "20100", CDate("17/11/2008"), True, CDate("25/11/2008"), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.MATI, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

        service.CommitTransaccio(l_transaccion.ID, True)
        '.GetHoresPerCita(lcgm_carga.ID_CGM, True, "CMA", "06/10/2008", True, "26/10/2008", True, CGMServeiIntegracio.FranjaHoraria.QUALSEVOL, True, 5, True, KK)

        Session("PP") = l_horas_reservadas

        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn("ID_Centre", GetType(String)))
        dt.Columns.Add(New DataColumn("ID_Cita", GetType(String)))
        dt.Columns.Add(New DataColumn("Hora", GetType(String)))
        dt.Columns.Add(New DataColumn("Duración", GetType(String)))
        dt.Columns.Add(New DataColumn("ID_Interval_Inici", GetType(String)))
        dt.Columns.Add(New DataColumn("ID_Linia", GetType(String)))
        dt.Columns.Add(New DataColumn("ID_Tram", GetType(String)))

        Dim dr As DataRow

        For n = 0 To UBound(l_horas_reservadas) - 1

            dr = dt.NewRow()
            dr("ID_Centre") = l_horas_reservadas(n).ID_Centre
            dr("ID_Cita") = l_horas_reservadas(n).ID_Cita
            dr("Hora") = l_horas_reservadas(n).DataHoraReservada
            dr("Duración") = l_horas_reservadas(n).Durada
            dr("ID_Interval_Inici") = l_horas_reservadas(n).ID_Interval_Inici
            dr("ID_Linia") = l_horas_reservadas(n).ID_Linia
            dr("ID_Tram") = l_horas_reservadas(n).ID_Tram

            dt.Rows.Add(dr)

        Next

        DataGrid1.DataSource = dt
        DataGrid1.DataBind()

    End Sub

End Class
