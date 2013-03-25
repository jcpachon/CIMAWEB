Public Class form_anular_cita
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_bookcanc1 = New cimaweb.ds_bookcanc
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_bookcanc1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_cima_garantes1
        '
        Me.Ds_cima_garantes1.DataSetName = "ds_cima_garantes"
        Me.Ds_cima_garantes1.EnforceConstraints = False
        Me.Ds_cima_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name"), New System.Data.Common.DataColumnMapping("id_creador", "id_creador"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cima_garantes.id_garante, cima_garantes.firm_key, cima_garantes.firmcode, " & _
        "cima_garantes.firm_name, cima_garantes.id_creador, cima_garantes.fecha_creacion " & _
        "FROM cima_epis INNER JOIN cima_garantes ON cima_epis.id_garante = cima_garantes." & _
        "id_garante WHERE (cima_epis.episcode = @episcode)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT bookcanccode, bookcancdesclong FROM bookcanc WHERE (bookcancacti = 'Y') OR" & _
        "DER BY bookcancdesclong"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CSaludR;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_bookcanc1
        '
        Me.Ds_bookcanc1.DataSetName = "ds_bookcanc"
        Me.Ds_bookcanc1.EnforceConstraints = False
        Me.Ds_bookcanc1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_bookcanc1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_bookcanc1 As cimaweb.ds_bookcanc
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList

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

        Dim ristra As String
        Dim matriz_ristra() As String

        Dim n As Integer

        Dim a As Integer



        Session("entrada") = Request("entrada")

        'Response.End()

        'login = Request.ServerVariables("AUTH_USER")

        Session("ristra") = Trim(Request("ristra"))

        'JGM Modificació 02/02/2011 Si cridem desde el form_pers, ja ve informat el servicio_origen
        If Session("form") <> 1 Then
            If Len(Trim(Request("DropDownList2"))) > 0 Then

                Session("servicio_origen") = Trim(Request("DropDownList2"))

            End If
        End If


        If Session("entrada") <> "N" Then



            Dim ls_array() As String
            Dim ls_array2() As String


            If Len(Trim(Request("dia_seleccionado"))) > 0 Then

                Session("dia_seleccionado") = Request("dia_seleccionado")

                Session("dia_seleccionado_origen") = Request("dia_seleccionado")

            End If

            If Session("dia_seleccionado") <> Nothing Then

                ls_array = Split(Session("dia_seleccionado"), "/")
                ls_array2 = Split(ls_array(2), " ")
                Session("dia_seleccionado") = ls_array(0) + "/" + ls_array(1) + "/" + ls_array2(0)

            End If

            Session("entrada") = "N"

        End If

        Session("agencode") = Request("agencode")

        If Request("control") = "S" And Len(Trim(Session("motivo"))) > 0 Then



            Dim str_menu As String

            Dim objCIMA As New CIMA_Clases.CIMA

            Dim objDS As New Data.DataSet

            Dim objRow As Data.DataRow

            Dim contador As Integer

            Dim ls_array(), ls_array2() As String

            Dim str_cadena_naciente, str_uid As String

            Dim ls_dia_seleccionado_origen As String

            Dim lidermalia_ws As New idermalia_ws.Service1
            Dim ldermas_ws As New dermas_ws.Service1

            Dim lds_baja_cita_idermalia As New idermalia_ws.ds_baja_cita
            Dim lds_baja_cita_dermas As New dermas_ws.ds_baja_cita

            Dim ds_baja_citaRow_idermalia As DataRow = lds_baja_cita_idermalia.baja_cita.NewRow()
            Dim ds_baja_citaRow_dermas As DataRow = lds_baja_cita_dermas.baja_cita.NewRow()




            contador = 0

            If Session("dia_seleccionado") <> Nothing Then

                ls_array = Split(Session("dia_seleccionado"), "/")
                Session("dia_seleccionado") = ls_array(0) + "/" + ls_array(1) + "/" + ls_array(2)

            End If

            str_uid = Request.Cookies("usuario").Value


            If Len(Trim(Session("ristra"))) >= 1 Then

                matriz_ristra = Split(Session("ristra"), "/", , CompareMethod.Text)

                For a = 0 To UBound(matriz_ristra)

                    If Len(Trim(matriz_ristra(a))) >= 1 Then

                        'str_menu = "dbo.SP_CIMACEX_EPIS_NOTIFICADO_CETIR " & Trim(matriz_ristra(a)) '& ",'" & Request("motivo") & "'"

                        'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        'If objDS.Tables(0).Rows.Count > 0 Then
                        If Trim(Session("servicio_origen")) = "RX" Then

                            ''''

                            Anulacion_CETIR(CInt(Trim(matriz_ristra(a))), Request("motivo"))

                            ''''

                        End If

                        str_menu = "dbo.SP_CIMACEX_BAJA_CITA " & Trim(matriz_ristra(a)) & ",'" & Request("motivo") & "','" & str_uid & "'"

                        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        ''' Conexión con otros back-offices.

                        'If Trim(Session("agencode")) = "BOZA" Or Trim(Session("agencode")) = "SOLE" Or Trim(Session("agencode")) = "SOLER" Or Trim(Session("agencode")) = "GUIL" Or Trim(Session("agencode")) = "BODET" Or Trim(Session("agencode")) = "FUERTE" Or Trim(Session("agencode")) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

                        '    ds_baja_citaRow_idermalia.Delete()
                        '    ds_baja_citaRow_dermas.Delete()

                        '    lds_baja_cita_idermalia.baja_cita.Clear()
                        '    lds_baja_cita_dermas.baja_cita.Clear()

                        '    ds_baja_citaRow_idermalia("epis_key_cima") = Trim(Trim(matriz_ristra(a)))
                        '    ds_baja_citaRow_dermas("epis_key_cima") = Trim(Trim(matriz_ristra(a)))

                        '    Select Case Trim(Request("motivo"))
                        '        Case "D", "R"
                        '            ds_baja_citaRow_idermalia("motivo") = Trim(Request("motivo"))
                        '            ds_baja_citaRow_dermas("motivo") = Trim(Request("motivo"))
                        '        Case "P"
                        '            ds_baja_citaRow_idermalia("motivo") = "C"
                        '            ds_baja_citaRow_dermas("motivo") = "C"
                        '        Case "N"
                        '            ds_baja_citaRow_idermalia("motivo") = "A"
                        '            ds_baja_citaRow_dermas("motivo") = "A"
                        '        Case Else
                        '            ds_baja_citaRow_idermalia("motivo") = "D"
                        '            ds_baja_citaRow_dermas("motivo") = "D"
                        '    End Select

                        '    lds_baja_cita_idermalia.baja_cita.Rows.Add(ds_baja_citaRow_idermalia)
                        '    lds_baja_cita_dermas.baja_cita.Rows.Add(ds_baja_citaRow_dermas)

                        '    lidermalia_ws.BajaCita("cima.ws", "Idermalia1", lds_baja_cita_idermalia)
                        '    ldermas_ws.BajaCita("cima.ws", "Dermas10", lds_baja_cita_dermas)

                        'End If

                        ''' Fin de la conexión.

                    End If

                Next

            End If

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Citas anuladas con éxito.');" & vbCrLf)

            ' Corrección del agencode a char.

            str_cadena_naciente = Session("agencode")

            For n = Len(Session("agencode")) To 5

                str_cadena_naciente = str_cadena_naciente + " "

            Next

            ls_array = Split(Session("dia_seleccionado_origen"), " ", , CompareMethod.Text)
            'ls_array = Split(Session("dia_seleccionado"), " ", , CompareMethod.Text)
            ls_array2 = Split(ls_array(0), "/", , CompareMethod.Text)
            ls_dia_seleccionado_origen = Session("dia_seleccionado_origen")
            'ls_dia_seleccionado_origen = Session("dia_seleccionado")

            'CARLOSSSSSSSSSSSSSSSSSSSSSSSSS **********************  FINALIZADO  *****
            If Session("form") <> 1 Then
                Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_origen") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & ls_dia_seleccionado_origen & "';")
            Else
                Response.Write("opener.location.href='../formularios/form_pers.aspx?pers_key=" & Session("pers_key") & "';")
            End If
            'FIN DE LA MODIFICACION DE CARLOSSSSSSS **************  FINALIZADO  *****
            'Response.Write("opener.location.href='../formularios/form_agendas.aspx?agenda_origen=" & str_cadena_naciente & "&dia_origen=" & Session("dia_seleccionado_origen") & "';")
            'Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_origen") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & ls_dia_seleccionado_origen & "';")
            Response.Write("window.close();" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        If Trim(Session("dia_seleccionado")) = "" Or Session("dia_seleccionado") = Nothing Then

            Session("control") = "True"

        Else

            Session("control") = "False"

        End If

        Me.Ds_bookcanc1.Clear()

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.Fill(Me.Ds_bookcanc1.bookcanc)

        Me.OdbcConnection1.Close()

        Me.DropDownList3.DataBind()

        Me.DropDownList3.Items.Add(" ")

        Me.DropDownList3.SelectedValue = " "

        Session("motivo") = ""

    End Sub

    Private Sub DropDownList3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList3.SelectedIndexChanged

        Me.DropDownList3.SelectedValue = Request("DropDownList3")

        Session("motivo") = Request("DropDownList3")

    End Sub

    Private Sub Anulacion_CETIR(ByVal epis_key As Integer, ByVal motivo As String)

        'Dim lcgm_carga As CGMServeiIntegracio.Cita
        'Dim lcgm_descarga As CGMServeiIntegracio.Cita

        'Dim PP() As CGMServeiIntegracio.HoraReservada
        'Dim KK() As CGMServeiIntegracio.HoraReservada

        'Dim lcgm_paciente As New CGMServeiIntegracio.Pacient
        'Dim lcgb_hora_reservada As CGMServeiIntegracio.HoraReservada

        Dim lb_ok As Boolean

        Dim ls_ok As String

        'Dim data As Date = New Date(1971, 12, 15)

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet
        Dim objDS_3 As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim str_menu, str_menu_2, str_menu_3 As String

        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima", "98yREc37", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)
        ''Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita

        Dim contador As Integer

        Dim li_clave_cetir As Integer

        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio

        Dim ls_cadena As String



        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        'str_menu = "dbo.SP_CIMACEX_RECUPERA_CLAVE_CETIR " & epis_key & ""

        'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        str_menu_2 = "dbo.SP_CIMACEX_ANULAR_CITA_CETIR " & epis_key & ""

        'If objDS.Tables(0).Rows.Count = 1 Then

        'str_menu = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR_EPIS_KEY " & epis_key & ""

        'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        'If objDS.Tables(0).Rows.Count > 0 Then
        'Else
        str_menu_3 = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR_EPIS_KEY " & CStr(epis_key) '& "'"

        objDS_3 = objCIMA.f_consulta_CSaludR(str_menu_3, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        If objDS_3.Tables(0).Rows.Count > 0 Then

            li_clave_cetir = objDS_3.Tables(0).Rows(0).Item("clave_cetir")

        Else

            li_clave_cetir = -1

        End If

        str_menu = "dbo.SP_CIMACEX_NOTIFICACION_CETIR_EPIS_KEY_BAJA " & CStr(epis_key) & ""

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        For Each objRow In objDS.Tables(0).Rows

            'lcgm_carga = service.CrearCita(objRow.Item("garante"), objRow.Item("ID_Prova"), "CARGA INFORMATICA CIMA.", False, False, False, False, False, False, False, False)

            lcima_paciente.Data_NaixamentSpecified = True

            lcima_paciente.ID_Pacient_Extern = CStr(objRow.Item("pers_key"))
            lcima_paciente.Nom = objRow.Item("persname")
            lcima_paciente.Cognom1 = objRow.Item("perssur1")
            lcima_paciente.Cognom2 = objRow.Item("perssur2")
            lcima_paciente.Data_Naixament = objRow.Item("fecha_nacimiento")
            lcima_paciente.CIP = ""
            lcima_paciente.DNI = objRow.Item("dni")

            Select Case objRow.Item("tsexcode")

                Case "1"

                    lcima_paciente.Sexe = "F"

                Case "2"

                    lcima_paciente.Sexe = "M"

                Case Else

                    lcima_paciente.Sexe = ""

            End Select

            lcima_paciente.Codi_Postal = objRow.Item("cp")
            lcima_paciente.Adreca = objRow.Item("direccion")
            lcima_paciente.Poblacio = objRow.Item("poblacion")
            lcima_paciente.Professio = ""
            lcima_paciente.Telefon = objRow.Item("tel1")
            lcima_paciente.Mobil = objRow.Item("tel2")
            lcima_paciente.Poblacio_Naixament = ""
            lcima_paciente.E_Mail = objRow.Item("email")
            lcima_paciente.ID_CGM = -1

            l_transaccion = service.BegginTransaction()

            'If li_clave_cetir = -1 Then

            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

            'Else

            'l_horas_reservadas = service.RecitarPacient(l_transaccion.ID, True, li_clave_cetir, True, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True)

            'End If

            ' Lolooooooooooooooooooooooooooooo!!!
            'service.AnularDadesEpisodi(l_transaccion.ID, True, lcima_paciente.ID_Pacient_Extern, objRow.Item("episcode"), motivo)
            service.AnularDadesEpisodi(l_transaccion.ID, True, lcima_paciente.ID_Pacient_Extern, objRow.Item("episcode"), li_clave_cetir, True, motivo)

            l_transaccion_retorno = service.CommitTransaccio(l_transaccion.ID, True)

            ls_cadena = "episcode=" & objRow.Item("episcode") & "#" & "clave_cetir=" & CStr(li_clave_cetir) & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

            str_menu = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','BCI'"

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")

            'zeus.CIMAServeiIntegracio.ServeiIntegracio.GenerateXmlMappings()

        Next

        'End If

        objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        'End If

    End Sub

End Class
