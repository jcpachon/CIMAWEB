Public Class WebForm2
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ls_matriz() As String

        Dim ls_agencode, ls_doctor, ls_mutua, ls_covegrou_key, ls_pers_key As String
        Dim str_menu, str_menu_2, str_menu_3 As String
        Dim str_menu_dermas As String

        Dim ls_duracion() As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet
        Dim objDS_3 As New Data.DataSet

        Dim objDS_dermas As New Data.DataSet

        Dim objRow As Data.DataRow
        Dim objRow_2 As Data.DataRow
        Dim objRow_3 As Data.DataRow

        Dim objRow_dermas As Data.DataRow

        Dim contador As Integer

        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        'Dim lcima_paciente As New CGMServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita
        'Dim lcima_cita As New CGMServeiIntegracio.Cita

        Dim ls_episcode As String

        Dim ldt_hora_ini, ldt_hora_fin As DateTime
        Dim ls_fecha_cita As String

        Dim ls_array() As String

        Dim ls_btimetabcode As String

        Dim lidermalia_ws As New idermalia_ws.Service1
        Dim ldermas_ws As New dermas_ws.Service1

        'Dim lds_alta_cita As idermalia_ws.ds_cita
        Dim lds_alta_cita_idermalia As New idermalia_ws.ds_cita
        Dim lds_alta_cita_dermas As New dermas_ws.ds_cita

        Dim ds_cita_persRow_idermalia As DataRow = lds_alta_cita_idermalia.pers.NewRow()
        Dim ds_cita_citaRow_idermalia As DataRow = lds_alta_cita_idermalia.cita.NewRow()

        Dim ds_cita_persRow_dermas As DataRow = lds_alta_cita_dermas.pers.NewRow()
        Dim ds_cita_citaRow_dermas As DataRow = lds_alta_cita_dermas.cita.NewRow()

        Dim li_prestacion As Integer

        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio
        Dim ls_cadena As String

        Dim ls_agencode_traspaso As String



        ''' Conexión con otros back-offices.

        'If Trim(ls_agencode) = "BOZA" Or Trim(ls_agencode) = "SOLE" Or Trim(ls_agencode) = "SOLER" Or Trim(ls_agencode) = "GUIL" Or Trim(ls_agencode) = "BODET" Or Trim(ls_agencode) = "FUERTE" Or Trim(ls_agencode) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

        str_menu_dermas = "[dbo].[SP_A_DERMAS]"

        objDS_dermas = objCIMA.f_consulta_CSaludR(str_menu_dermas, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        For Each objRow_dermas In objDS_dermas.Tables(0).Rows

            str_menu_2 = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & CStr(objRow_dermas.Item("pers_key")) 'Session("pers_key_paciente") & ""

            objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            contador = 0

            For Each objRow_2 In objDS_2.Tables(0).Rows

                contador = contador + 1

                If contador = 1 Then

                    ds_cita_persRow_dermas("pers_key") = objRow_dermas.Item("pers_key")
                    ds_cita_persRow_dermas("persname") = objRow_2.Item("persname")
                    ds_cita_persRow_dermas("perssur1") = objRow_2.Item("perssur1")
                    ds_cita_persRow_dermas("perssur2") = objRow_2.Item("perssur2")
                    ds_cita_persRow_dermas("tsexcode") = objRow_2.Item("tsexcode")
                    ds_cita_persRow_dermas("persfullname") = objRow_2.Item("persfullname")
                    ds_cita_persRow_dermas("idenperscod1") = "1"
                    ds_cita_persRow_dermas("persidencod1") = objRow_2.Item("dni")
                    ds_cita_persRow_dermas("fecha_nacimiento") = objRow_2.Item("fecha_nacimiento")
                    ds_cita_persRow_dermas("movil") = objRow_2.Item("tel2")

                    lds_alta_cita_dermas.pers.Rows.Add(ds_cita_persRow_dermas)

                End If

            Next

            'Select Case ls_duracion(0)
            '    case 
            'End Select

            li_prestacion = 27

            Select Case Trim(objRow_dermas.Item("agencode"))
                Case "BOZA"
                    ls_agencode_traspaso = "A.BOZA"
                Case "SOLE"
                    ls_agencode_traspaso = "T.SOLE"
                Case "SOLER"
                    ls_agencode_traspaso = "J.SOLER"
                Case "GUIL"
                    ls_agencode_traspaso = "A.GUIL"
                Case "BODET"
                    ls_agencode_traspaso = "D.BODE"
                Case "FUERTE"
                    ls_agencode_traspaso = "I.FUER"
                Case "SEGURA"
                    ls_agencode_traspaso = "J.SEGU"
            End Select

            ds_cita_citaRow_dermas("id_centro") = 1
            ds_cita_citaRow_dermas("agencode") = ls_agencode_traspaso
            ds_cita_citaRow_dermas("id_prestacion") = li_prestacion
            ds_cita_citaRow_dermas("dia") = CDate(objRow_dermas.Item("fecha_cita"))
            ds_cita_citaRow_dermas("hora_ini") = CDate("01/01/1900 " & objRow_dermas.Item("hora_inicial"))
            ds_cita_citaRow_dermas("hora_fin") = CDate("01/01/1900 " & objRow_dermas.Item("hora_final"))
            ds_cita_citaRow_dermas("id_garante") = 19
            ds_cita_citaRow_dermas("id_agen_franja") = 0
            ds_cita_citaRow_dermas("pers_key") = CInt(objRow_dermas.Item("pers_key"))
            ds_cita_citaRow_dermas("epis_key") = CInt(objRow_dermas.Item("epis_key"))

            lds_alta_cita_dermas.cita.Rows.Add(ds_cita_citaRow_dermas)

            'lidermalia_ws.AltaCita("cima.ws", "Idermalia1", lds_alta_cita_idermalia)
            ldermas_ws.AltaCita("cima.ws", "Dermas10", lds_alta_cita_dermas)

            If lds_alta_cita_dermas.pers.Rows.Count > 0 Then
                lds_alta_cita_dermas.pers.Rows.Remove(ds_cita_persRow_dermas)
            End If
            If lds_alta_cita_dermas.cita.Rows.Count > 0 Then
                lds_alta_cita_dermas.cita.Rows.Remove(ds_cita_citaRow_dermas)
            End If

        Next

        'End If

        ''' Fin de la conexión.

    End Sub
End Class
