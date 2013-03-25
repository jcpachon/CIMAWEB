Public Class form_agendas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_agendas1 = New cimaweb.ds_agendas
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_dias1 = New cimaweb.ds_dias
        Me.Ds_dias2 = New cimaweb.ds_dias
        Me.Ds_dias3 = New cimaweb.ds_dias
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_agendas1
        '
        Me.Ds_agendas1.DataSetName = "ds_agendas"
        Me.Ds_agendas1.EnforceConstraints = False
        Me.Ds_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agenname", "agenname")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
        "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
        " @id_usuario) AND (agen.agenacti = 'Y') AND (agen.agentypecode = @agentypecode) " & _
        "ORDER BY agen.agenname"
        Me.SqlSelectCommand1.CommandTimeout = 0
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agentypecode", System.Data.SqlDbType.VarChar, 2, "agentypecode"))
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("addrcodemain", "addrcodemain"), New System.Data.Common.DataColumnMapping("addrcodedeli", "addrcodedeli"), New System.Data.Common.DataColumnMapping("addrcodeinvo", "addrcodeinvo"), New System.Data.Common.DataColumnMapping("ttaxgfircode", "ttaxgfircode"), New System.Data.Common.DataColumnMapping("paymdocucode", "paymdocucode"), New System.Data.Common.DataColumnMapping("firmclascode", "firmclascode"), New System.Data.Common.DataColumnMapping("currcode", "currcode"), New System.Data.Common.DataColumnMapping("langcode", "langcode"), New System.Data.Common.DataColumnMapping("addrcodepaym", "addrcodepaym"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("payccode", "payccode"), New System.Data.Common.DataColumnMapping("idenfirmcode", "idenfirmcode"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firmname", "firmname"), New System.Data.Common.DataColumnMapping("firmnamecomm", "firmnamecomm"), New System.Data.Common.DataColumnMapping("firmidencode", "firmidencode"), New System.Data.Common.DataColumnMapping("firmdateacti", "firmdateacti"), New System.Data.Common.DataColumnMapping("firmrema", "firmrema"), New System.Data.Common.DataColumnMapping("firmfilename", "firmfilename"), New System.Data.Common.DataColumnMapping("firmacti", "firmacti"), New System.Data.Common.DataColumnMapping("plancodeterr", "plancodeterr"), New System.Data.Common.DataColumnMapping("tfircode", "tfircode"), New System.Data.Common.DataColumnMapping("firmea13", "firmea13"), New System.Data.Common.DataColumnMapping("firm_abc", "firm_abc"), New System.Data.Common.DataColumnMapping("invccode", "invccode"), New System.Data.Common.DataColumnMapping("firmguar", "firmguar"), New System.Data.Common.DataColumnMapping("firmnameshor", "firmnameshor"), New System.Data.Common.DataColumnMapping("funccodebrne", "funccodebrne"), New System.Data.Common.DataColumnMapping("funccodeprpr", "funccodeprpr"), New System.Data.Common.DataColumnMapping("firm_keyfath", "firm_keyfath"), New System.Data.Common.DataColumnMapping("funccodebrnedeli", "funccodebrnedeli"), New System.Data.Common.DataColumnMapping("funccodeprprdeli", "funccodeprprdeli"), New System.Data.Common.DataColumnMapping("funccodebrneorde", "funccodebrneorde"), New System.Data.Common.DataColumnMapping("funccodeprprorde", "funccodeprprorde"), New System.Data.Common.DataColumnMapping("buni_key", "buni_key"), New System.Data.Common.DataColumnMapping("codetmplcode", "codetmplcode"), New System.Data.Common.DataColumnMapping("funccodeacce", "funccodeacce"), New System.Data.Common.DataColumnMapping("firmtrantime", "firmtrantime"), New System.Data.Common.DataColumnMapping("firmpartserv", "firmpartserv"), New System.Data.Common.DataColumnMapping("firmminiperc", "firmminiperc"), New System.Data.Common.DataColumnMapping("firmrealqualctrl", "firmrealqualctrl"), New System.Data.Common.DataColumnMapping("firmleve", "firmleve"), New System.Data.Common.DataColumnMapping("firmorde", "firmorde"), New System.Data.Common.DataColumnMapping("firmdelidays", "firmdelidays"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("firmdatedrop", "firmdatedrop"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("plancodeter2", "plancodeter2"), New System.Data.Common.DataColumnMapping("addrcodezone", "addrcodezone"), New System.Data.Common.DataColumnMapping("tfircod2", "tfircod2"), New System.Data.Common.DataColumnMapping("plancodefir2", "plancodefir2"), New System.Data.Common.DataColumnMapping("firminvonumb", "firminvonumb")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT diardate AS dia FROM diar"
        Me.OdbcSelectCommand1.CommandTimeout = 0
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CSaludR;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};Network=DBMSSOCN;;WSID=ZEUS"
        '
        'Ds_dias1
        '
        Me.Ds_dias1.DataSetName = "ds_dias"
        Me.Ds_dias1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_dias2
        '
        Me.Ds_dias2.DataSetName = "ds_dias"
        Me.Ds_dias2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_dias3
        '
        Me.Ds_dias3.DataSetName = "ds_dias"
        Me.Ds_dias3.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.SqlSelectCommand2.CommandTimeout = 0
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'Ds_cima_garantes1
        '
        Me.Ds_cima_garantes1.DataSetName = "ds_cima_garantes"
        Me.Ds_cima_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_agendas1 As cimaweb.ds_agendas
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Ds_dias1 As cimaweb.ds_dias
    Protected WithEvents Ds_dias2 As cimaweb.ds_dias
    Protected WithEvents Ds_dias3 As cimaweb.ds_dias
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image6 As System.Web.UI.WebControls.Image
    Protected WithEvents Image5 As System.Web.UI.WebControls.Image
    Protected WithEvents Image4 As System.Web.UI.WebControls.Image
    Protected WithEvents Image9 As System.Web.UI.WebControls.Image
    Protected WithEvents Image8 As System.Web.UI.WebControls.Image
    Protected WithEvents Image7 As System.Web.UI.WebControls.Image
    Protected WithEvents Image12 As System.Web.UI.WebControls.Image
    Protected WithEvents Image11 As System.Web.UI.WebControls.Image
    Protected WithEvents Image10 As System.Web.UI.WebControls.Image
    Protected WithEvents Image15 As System.Web.UI.WebControls.Image
    Protected WithEvents Image14 As System.Web.UI.WebControls.Image
    Protected WithEvents Image13 As System.Web.UI.WebControls.Image
    Protected WithEvents Image18 As System.Web.UI.WebControls.Image
    Protected WithEvents Image17 As System.Web.UI.WebControls.Image
    Protected WithEvents Image16 As System.Web.UI.WebControls.Image
    Protected WithEvents Image21 As System.Web.UI.WebControls.Image
    Protected WithEvents Image20 As System.Web.UI.WebControls.Image
    Protected WithEvents Image19 As System.Web.UI.WebControls.Image
    Protected WithEvents Image24 As System.Web.UI.WebControls.Image
    Protected WithEvents Image23 As System.Web.UI.WebControls.Image
    Protected WithEvents Image22 As System.Web.UI.WebControls.Image
    Protected WithEvents Image27 As System.Web.UI.WebControls.Image
    Protected WithEvents Image26 As System.Web.UI.WebControls.Image
    Protected WithEvents Image25 As System.Web.UI.WebControls.Image
    Protected WithEvents Image30 As System.Web.UI.WebControls.Image
    Protected WithEvents Image29 As System.Web.UI.WebControls.Image
    Protected WithEvents Image28 As System.Web.UI.WebControls.Image
    Protected WithEvents Image33 As System.Web.UI.WebControls.Image
    Protected WithEvents Image32 As System.Web.UI.WebControls.Image
    Protected WithEvents Image31 As System.Web.UI.WebControls.Image
    Protected WithEvents Image36 As System.Web.UI.WebControls.Image
    Protected WithEvents Image35 As System.Web.UI.WebControls.Image
    Protected WithEvents Image34 As System.Web.UI.WebControls.Image
    Protected WithEvents Image39 As System.Web.UI.WebControls.Image
    Protected WithEvents Image38 As System.Web.UI.WebControls.Image
    Protected WithEvents Image37 As System.Web.UI.WebControls.Image
    Protected WithEvents Image40 As System.Web.UI.WebControls.Image
    Protected WithEvents Image41 As System.Web.UI.WebControls.Image
    Protected WithEvents Image42 As System.Web.UI.WebControls.Image
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents CheckBox4 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Image43 As System.Web.UI.WebControls.Image
    Protected WithEvents Image44 As System.Web.UI.WebControls.Image
    Protected WithEvents Image45 As System.Web.UI.WebControls.Image
    Protected WithEvents Image46 As System.Web.UI.WebControls.Image
    Protected WithEvents Image47 As System.Web.UI.WebControls.Image
    Protected WithEvents Image48 As System.Web.UI.WebControls.Image
    Protected WithEvents Image49 As System.Web.UI.WebControls.Image
    Protected WithEvents Image50 As System.Web.UI.WebControls.Image
    Protected WithEvents Image51 As System.Web.UI.WebControls.Image
    Protected WithEvents Image52 As System.Web.UI.WebControls.Image
    Protected WithEvents Image53 As System.Web.UI.WebControls.Image
    Protected WithEvents Image54 As System.Web.UI.WebControls.Image
    Protected WithEvents Image55 As System.Web.UI.WebControls.Image
    Protected WithEvents Image56 As System.Web.UI.WebControls.Image
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Image57 As System.Web.UI.WebControls.Image
    Protected WithEvents Image58 As System.Web.UI.WebControls.Image
    Protected WithEvents Image59 As System.Web.UI.WebControls.Image
    Protected WithEvents Image60 As System.Web.UI.WebControls.Image
    Protected WithEvents Image61 As System.Web.UI.WebControls.Image
    Protected WithEvents Image62 As System.Web.UI.WebControls.Image
    Protected WithEvents Image266 As System.Web.UI.WebControls.Image
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents sort_by As System.Web.UI.WebControls.DropDownList
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox

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
    'Private PP() As CGMServeiIntegracio.HoraReservada

    Dim ib_control As Boolean

    Dim control_cetir As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        'CARLOS - MODIFICACION *********************
        Session("form") = 0
        'CARLOS - MODIFICACION *********************

        Dim login As String
        Dim login_array() As String

        Dim ls_fecha As String
        Dim li_contador As Long
        Dim n As Long

        Dim ls_array(), ls_array2() As String

        Dim fecha_visible As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_cadena_naciente As String

        Dim objCIMA_cambio_estado As New CIMA_Clases.CIMA
        Dim objCIMA_cambio_estado_lopd As New CIMA_Clases.CIMA

        Dim str_sql As String
        Dim str_sql_lopd As String

        Dim ls_servicio As String

        'login = "cima\juancarlos.pachon"

        'login_array = Split(login, "\")

        'login = login_array(1)

        Dim objDS As New Data.DataSet

        Dim str_menu As String

        Dim ldermas_ws As New dermas_ws.Service1

        'Dim lds_alta_cita As idermalia_ws.ds_cita

        Dim lds_cambio_estado_dermas As New dermas_ws.ds_cambio_estado

        Dim ds_cambio_estadoRow_dermas As DataRow = lds_cambio_estado_dermas.cambio_estado.NewRow()

        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima", "98yREc37", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)
        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)



        'service.RequestSoapContext.Security.Tokens.Add(User)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        'str_uid = Request.Cookies("usuario").Value
        'str_sesion_id = Request.Cookies("session_id").Value

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'Session("apporendcode") = ""

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        str_menu = "dbo.SP_CIMACEX_RECUPERA_DATOS_USUARIO '" & Request.Cookies("usuario").Value & "'"

        'response.write (str_menu)

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        Session("grupo") = objDS.Tables(0).Rows(0).Item("grupo")

        If Session("grupo") = "U" Or Session("grupo") = "G" Or Session("grupo") = "W" Or Session("grupo") = "I" Or Session("grupo") = "L" Then

            Me.CheckBox1.Visible = False

        End If

        'JGM 01/03/2011 Afegim la ordenació per hora admissió
        If Request("sort_by") = "P" Then

            Me.sort_by.SelectedValue = "P"

        ElseIf Request("sort_by") = "A" Then

            Me.sort_by.SelectedValue = "A"

        Else

            Me.sort_by.SelectedValue = "H"

        End If

        If Request("flag") = "S" Then

            'If IsDate(objCIMA.f_formato_fecha(Session("dia_seleccionado"))) And Len(Trim(Session("agencode"))) > 0 Then

            Session("ristra") = Request("ristra")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 2;" & vbCrLf)
            Response.Write("</scr" & "ipt>")

            'End If

        End If

        login = Request.Cookies("usuario").Value

        'aaa

        'str_cadena_naciente = Session("agencode")

        'str_cadena_naciente = ""

        'For n = Len(Request("DropDownList1")) To 5
        'str_cadena_naciente = str_cadena_naciente + " "
        'Next

        If IsPostBack = False Then

            Session("ok") = "N"

            Me.Ds_agendas1.Clear()

            If Request("inactiva") = "True" Then

                Me.CheckBox1.Checked = True

                'If Me.CheckBox1.Checked = True Then

                'Session("ok") = "N"

                'Me.Ds_agendas1.Clear()

                Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
                        "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
                        " @id_usuario) AND (agen.agenacti <> 'Y') AND (agen.agentypecode = @agentypecode) " & _
                        "ORDER BY agen.agenname"

                'End If

            End If

            If Len(Trim(Request("DropDownList2"))) > 0 Then

                Me.Dropdownlist2.SelectedValue = Request("DropDownList2")
                Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("DropDownList2")
                ls_servicio = Request("DropDownList2")

            Else
                If Len(Trim(Request("servicio_origen"))) > 0 Then

                    Me.Dropdownlist2.SelectedValue = Request("servicio_origen")
                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("servicio_origen") 'Me.Dropdownlist2.SelectedValue
                    ls_servicio = Request("servicio_origen")

                Else

                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.Dropdownlist2.SelectedValue
                    ls_servicio = Me.Dropdownlist2.SelectedValue

                End If

                'Session("agenda_en_acto") = Request("DropDownList1")

            End If

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
            Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
            Me.DropDownList1.DataBind()
            Me.SqlConnection1.Close()

            'Me.DropDownList1.Items.Add("")

            If ls_servicio = "RX" Then

                Me.DropDownList1.Items.Add("-TODAS RAD-")

            End If
            'Me.DropDownList1.Items.Add("")

            'JGM - Afegim totes al servei d'urgencies
            If ls_servicio = "UR" And Me.Ds_agendas1.cima_usuarios_agen.Rows.Count() > 0 Then

                Me.DropDownList1.Items.Add("-TODAS URG-")

            End If
            'JGM



            If Len(Trim(Request("DropDownList1"))) > 0 Then

                If Me.Ds_agendas1.cima_usuarios_agen.Select("agencode = '" & Request("DropDownList1") & "'").Length > 0 Then

                    Me.DropDownList1.SelectedValue = Request("DropDownList1")
                    Session("agenda_en_acto") = Request("DropDownList1")

                Else

                    Session("agenda_en_acto") = Me.DropDownList1.SelectedValue

                End If

            Else

                If Me.Ds_agendas1.cima_usuarios_agen.Select("agencode = '" & Request("agenda_origen") & "'").Length > 0 Then

                    Me.DropDownList1.SelectedValue = Request("agenda_origen")
                    Session("agenda_en_acto") = Request("agenda_origen")

                Else

                    Session("agenda_en_acto") = Me.DropDownList1.SelectedValue

                End If

            End If

            If Trim(Request("lopd")) = "S" Then

                str_sql_lopd = "[dbo].[SP_CIMACEX_CAMBIO_ESTADO_LOPD] " & Request("epis_key")
                objCIMA_cambio_estado_lopd.f_consulta(str_sql_lopd, "workstation id=MINERVA;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            End If

            If Trim(Request("nuevo_estado")) = "D" Or Trim(Request("nuevo_estado")) = "P" Then

                'JGM 27/12/10 Passem el paràmetre episkey per la Mutua MGC
                Session("episkey") = Request("epis_key")
                'Fi modificació JGM

                Me.DropDownList1.SelectedValue = Session("agenda_en_acto")
                Label2.Text = Me.Calendar1.SelectedDate.ToString
                fecha_visible = Request("dia_en_seleccion") 'Request("dia_origen")

                str_sql = "[dbo].[SP_CIMACEX_CAMBIO_ESTADO] '" & Request("episcode") & "','" & Request("nuevo_estado") & "'"

                ''' Conexión con otros back-offices.

                'If Trim(Session("agenda_en_acto")) = "BOZA" Or Trim(Session("agenda_en_acto")) = "SOLE" Or Trim(Session("agenda_en_acto")) = "SOLER" Or Trim(Session("agenda_en_acto")) = "GUIL" Or Trim(Session("agenda_en_acto")) = "BODET" Or Trim(Session("agenda_en_acto")) = "FUERTE" Or Trim(Session("agenda_en_acto")) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

                '    ds_cambio_estadoRow_dermas("epis_key_cima") = CInt(Request("epis_key"))
                '    ds_cambio_estadoRow_dermas("estado") = Trim(Request("nuevo_estado"))

                '    lds_cambio_estado_dermas.cambio_estado.Rows.Add(ds_cambio_estadoRow_dermas)
                '    ldermas_ws.CambioEstado("cima.ws", "Dermas10", lds_cambio_estado_dermas)

                'End If

                ''' Fin de la conexión.

                'If Len(Trim(Session("agenda_en_acto"))) > 0 Then
                'Me.DropDownList1.SelectedValue = Session("agenda_en_acto")
                'fecha_visible = Request("dia_en_seleccion") 'Request("dia_origen")
                'Else
                'fecha_visible = Request("VisibleDate")
                'End If

                ''' Notificación y anulación de cita a CETIR.

                'JGM Modificació 22/06/2011
                control_cetir = True

                If Me.Dropdownlist2.SelectedValue = "RX" And Trim(Request("nuevo_estado")) = "D" Then

                    Notificacion_CETIR(Request("episcode"))

                End If

                'JGM 22/02/2011 D'aquesta part només fem la desnotificación a cetir a la nostra BBDD
                'If Me.Dropdownlist2.SelectedValue = "RX" And Trim(Request("nuevo_estado")) = "P" Then

                '    Anulacion_CETIR(Request("epis_key"), "D")

                'End If
                'JGM 22/02/2011

                ''' Fin Notificación a CETIR.

                'JGM Modificació 22/06/2011
                ' Si no ha anat bé l'admissió a CETIR no actualitzem l'estat i donem un avís

                If control_cetir = True Then
                    objCIMA_cambio_estado.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")
                Else
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Error al admitir enviando la notificación a CETIR.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")
                End If


            Else

                If Len(Trim(Request("agenda_origen"))) > 0 Then

                    '---
                    Me.Ds_agendas1.cima_usuarios_agen.Clear()

                    If Me.CheckBox1.Checked = True Then

                        Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
                                "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
                                " @id_usuario) AND (agen.agenacti <> 'Y') AND (agen.agentypecode = @agentypecode) " & _
                                "ORDER BY agen.agenname"

                    End If

                    Me.Dropdownlist2.SelectedValue = Request("servicio_origen")
                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("servicio_origen") 'Me.Dropdownlist2.SelectedValue

                    Me.SqlConnection1.Open()
                    Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
                    Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
                    Me.DropDownList1.DataBind()
                    Me.SqlConnection1.Close()

                    If Request("servicio_origen") = "RX" Then
                        Me.DropDownList1.Items.Add("-TODAS RAD-")
                    End If

                    'JGM Afegim totes al servei Urgencies
                    If Request("servicio_origen") = "UR" Then
                        Me.DropDownList1.Items.Add("-TODAS URG-")
                    End If
                    'JGM


                    '---
                    Me.DropDownList1.SelectedValue = Request("agenda_origen")

                    'fecha_visible = Request("dia_en_seleccion")
                    If Len(Request("VisibleDate")) > 0 Then

                        fecha_visible = Request("VisibleDate")

                    Else

                        fecha_visible = Request("dia_en_seleccion")

                    End If


                Else

                    'fecha_visible = Request("VisibleDate")
                    If Len(Request("VisibleDate")) > 0 Then

                        fecha_visible = Request("VisibleDate")

                    Else

                        fecha_visible = Request("dia_en_seleccion")

                    End If

                End If

            End If

            If Len(fecha_visible) > 0 Then

                Me.Calendar1.VisibleDate = fecha_visible
                Me.Calendar1.SelectedDate = fecha_visible
                Session("dia_seleccionado") = Nothing
                Label2.Text = ""

                ls_array = Split(Me.Calendar1.SelectedDate.ToString, "/")
                'Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)

                'Session("dia_seleccionado") = Me.Calendar1.SelectedDate.ToString

                If Len(Trim(Request("dia_seleccionado"))) > 0 Then

                    Session("dia_seleccionado") = Request("dia_seleccionado")

                Else

                    Session("dia_seleccionado") = Me.Calendar1.SelectedDate.ToString

                End If

                ls_array2 = Split(ls_array(2), " ")
                'Label2.Text = "Día: " + ls_array(0) + "/" + ls_array(1) + "/" + ls_array2(0)

                Label2.Text = Session("dia_seleccionado")


            Else

                Me.Calendar1.VisibleDate = Today()

            End If

            'If Len(Request("VisibleDate")) > 0 Then
            'Me.Calendar2.VisibleDate = Request("VisibleDate")
            'Else

            Me.Calendar2.VisibleDate = Me.Calendar1.VisibleDate

            'End If

        End If

        ib_control = False

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
        Dim objDS_3 As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim str_menu, str_menu_3 As String

        '''Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita

        Dim contador As Integer

        Dim li_clave_cetir As Integer




        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        str_menu_3 = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR_EPIS_KEY " & CStr(epis_key) '& "'"

        objDS_3 = objCIMA.f_consulta_CSaludR(str_menu_3, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        If objDS_3.Tables(0).Rows.Count > 0 Then

            li_clave_cetir = objDS_3.Tables(0).Rows(0).Item("clave_cetir")

        Else

            li_clave_cetir = -1

        End If

        str_menu = "dbo.SP_CIMACEX_RECUPERA_CLAVE_CETIR " & epis_key & ""

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        str_menu = "dbo.SP_CIMACEX_DESNOTIFICACION_CETIR " & epis_key & ""

        If objDS.Tables(0).Rows.Count = 1 Then

            str_menu = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR_EPIS_KEY] " & epis_key & ""

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            contador = 0

            For Each objRow In objDS.Tables(0).Rows

                contador = contador + 1

                If contador = 1 Then

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

                End If

            Next

            l_transaccion = service.BegginTransaction()

            service.AnularDadesEpisodi(l_transaccion.ID, True, lcima_paciente.ID_Pacient_Extern, objDS.Tables(0).Rows(0).Item("episcode"), li_clave_cetir, True, motivo) '(objDS.Tables(0).Rows(0).Item("clave_cetir"), True, motivo)

            service.CommitTransaccio(l_transaccion.ID, True)

            'lcgm_descarga = service.AnularCita(objDS.Tables(0).Rows(0).Item("clave_cetir"), True, motivo)

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        End If

    End Sub

    Private Sub Notificacion_CETIR(ByVal episcode As String)

        'Dim lcgm_carga As CGMServeiIntegracio.Cita
        'Dim lcgm_descarga1 As CGMServeiIntegracio.Cita
        'Dim lcgm_descarga2 As CGMServeiIntegracio.Cita

        'Dim PP() As CGMServeiIntegracio.HoraReservada
        'Dim KK() As CGMServeiIntegracio.HoraReservada

        'Dim lcgm_paciente As New CGMServeiIntegracio.Pacient
        'Dim lcgb_hora_reservada As CGMServeiIntegracio.HoraReservada

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim contador As Integer

        Dim str_menu As String

        Dim li_id_prova() As Integer

        Dim lstr_id_prova As String

        Dim li_recepcion() As Integer

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita

        Dim li_clave_cetir As Integer

        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio

        Dim ls_cadena As String

        'Dim contador As Integer



        str_menu = "dbo.[SP_CIMACEX_NOTIFICACION_CETIR] '" & episcode & "'"

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        contador = 0

        If objDS.Tables(0).Rows.Count > 0 Then

            For Each objRow In objDS.Tables(0).Rows

                contador = contador + 1

                If contador = 1 Then 'Sólo debería entrar una prueba por episodio de RX.

                    str_menu = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR '" & episcode & "'"

                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    If objDS.Tables(0).Rows.Count > 0 Then

                        li_clave_cetir = objDS.Tables(0).Rows(0).Item("clave_cetir")

                    Else

                        li_clave_cetir = -1

                    End If
                    'Else

                    'lcgm_carga = service.CrearCita(objRow.Item("garante"), objRow.Item("ID_Prova"), "CARGA INFORMATICA CIMA.", False, False, False, False, False, False, False, False)

                    lcima_paciente.Data_NaixamentSpecified = True

                    'JGM 28/03/2011 s'envia el pers_key que es va crear l'episodi
                    If objDS.Tables(0).Rows.Count > 0 Then
                        If CStr(objDS.Tables(0).Rows(0).Item("pers_key_cetir")) > 0 Then
                            lcima_paciente.ID_Pacient_Extern = CStr(objDS.Tables(0).Rows(0).Item("pers_key_cetir"))
                        Else
                            lcima_paciente.ID_Pacient_Extern = CStr(objRow.Item("pers_key"))
                        End If
                    Else
                        lcima_paciente.ID_Pacient_Extern = CStr(objRow.Item("pers_key"))
                    End If


                    'lcima_paciente.ID_Pacient_Extern = CStr(objRow.Item("pers_key"))
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

                    'lcgm_descarga1 = service.ProgramarHoraPerCitaEspecial(lcgm_paciente, lcgm_carga.ID_CGM, True, "CMA", objRow.Item("hora_ini"), True, objRow.Item("hora_fin"), True)
                    'lcgm_descarga2 = service.CitaCreadaAmbEpisodiExtern(lcgm_carga.ID_CGM, True, objRow.Item("episcode"))

                    l_transaccion = service.BegginTransaction()

                    li_id_prova = service.RecepcioDePacient(l_transaccion.ID, True, lcima_paciente, objRow.Item("episcode"), li_clave_cetir, True, objRow.Item("ID_Prova"), "CMA", objRow.Item("hora_ini"), True, "CARGA INFORMATICA CIMA.")

                    l_transaccion_retorno = service.CommitTransaccio(l_transaccion.ID, True)

                    If li_id_prova.Length > 0 Then

                        lstr_id_prova = CStr(li_id_prova(0))

                    Else

                        lstr_id_prova = "0"

                    End If

                    ls_cadena = "episcode=" & objRow.Item("episcode") & "#" & "clave_cetir=" & CStr(li_clave_cetir) & "#" & "prova_cetir=" & lstr_id_prova & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

                    str_menu = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','NCI'"

                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")


                    'End If
                    'li_id_prova = service.RecepcioDePacient(CStr(objRow.Item("pers_key")), objRow.Item("episcode"), objRow.Item("ID_Prova"), "")
                    'str_menu = "dbo.[SP_CIMACEX_EPIS_NOTIFICADOS_CETIR] '" & episcode & "','S'," & objRow.Item("hpro_key") & ",'" & objRow.Item("hprocode") & "','" & objRow.Item("ID_Prova") & "'," & CStr(lcgm_carga.ID_CGM) & "," & lstr_id_prova

                    'JGM Modificació 22/06/2011
                    ' En el cas que sigui menor o igual a 0 el que ens retorna CETIR, vol dir que hi ha
                    ' hagut un error i no contemplarem la cita com admesa.
                    If li_id_prova(0) > 0 Then
                        str_menu = "dbo.[SP_CIMACEX_EPIS_NOTIFICADOS_CETIR] '" & episcode & "','S'," & objRow.Item("hpro_key") & ",'" & objRow.Item("hprocode") & "','" & objRow.Item("ID_Prova") & "',0," & lstr_id_prova

                        objDS_2 = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
                    Else
                        control_cetir = False
                    End If
                    

                End If

            Next

            'JGM 22/02/2011 
            'Asterisquem aquesta part

            'Else

            '    str_menu = "dbo.[SP_CIMACEX_EPIS_NOTIFICADOS_CETIR] '" & episcode & "','N',0,'','',0,0"

            '    'response.write (str_menu)

            '    objDS_2 = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
            'JGM 22/02/2011
        End If

    End Sub

    Private Sub Calendar1_VisibleMonthChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MonthChangedEventArgs) Handles Calendar1.VisibleMonthChanged

        Me.Calendar2.VisibleDate = e.NewDate

    End Sub

    Private Sub Calendar2_VisibleMonthChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MonthChangedEventArgs) Handles Calendar2.VisibleMonthChanged

        Me.Calendar1.VisibleDate = e.NewDate

    End Sub

    Private Sub f_marcar()

        Dim ls_fecha As String
        Dim li_contador As Long
        Dim lb_control_agenda_urg As Boolean
        Dim n As Long

        'Dim ObjTransaction As New SqlClient.SqlTransaction

        lb_control_agenda_urg = True

        Me.Ds_dias1.dias.Clear()
        Me.Ds_dias2.dias.Clear()

        ' Calendario 1.

        'Me.Calendar1.SelectedDate = Nothing

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT diar.diardate AS dia " & _
        '"FROM diar " & _
        '"WHERE diar.agencode = '" & Me.DropDownList1.SelectedValue & "' AND diar.diaracti = 'Y' AND diar.btimetabcode = 10 AND month(diar.diardate) = " & Month(e.NewDate) & " AND year(diar.diardate) = " & Year(e.NewDate) & ""

        OdbcDataAdapter1.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

        If Me.Dropdownlist2.SelectedValue <> "UR" Then

            If Session("grupo") = "G" Or Session("grupo") = "U" Or Session("grupo") = "W" Or Session("grupo") = "I" Then

                Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
                "INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                "INNER JOIN CIMACEX.dbo.cima_epis_usuarios on epis.epis_key = CIMACEX.dbo.cima_epis_usuarios.epis_key " & _
                "INNER JOIN CIMACEX.dbo.cima_usuarios on CIMACEX.dbo.cima_usuarios.id_usuario = CIMACEX.dbo.cima_epis_usuarios.usuario COLLATE Modern_Spanish_CS_AS " & _
                "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND " & _
                " (book.agencode = '" & Me.DropDownList1.SelectedValue & "' OR ('-TODAS RAD-' = '" & Trim(Me.DropDownList1.SelectedValue) & "' and csta.tactcode = 'RX' )) " & _
                " AND CIMACEX.dbo.cima_usuarios.grupo = '" & Session("grupo") & "'" & _
                "GROUP BY book.diardate"

            Else
                If Session("grupo") = "L" Then

                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                    "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
                    "INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                    "INNER JOIN cima_nhc_imarques on cima_nhc_imarques.epis_key = epis.epis_key " & _
                    "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND book.agencode = '" & Me.DropDownList1.SelectedValue & "' " & _
                    "GROUP BY book.diardate"

                Else


                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                    "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                    "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar1.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar1.VisibleDate.Year & " AND (book.agencode = '" & Me.DropDownList1.SelectedValue & "' " & _
                    " OR ('-TODAS RAD-' = '" & Trim(Me.DropDownList1.SelectedValue) & "' and csta.tactcode = 'RX' )) " & _
                    "GROUP BY book.diardate"

                End If

            End If

        Else

                Select Case Trim(Me.DropDownList1.SelectedValue)

                    Case "URPED"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 126 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URMI"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 102 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URCOT"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 101 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URESP"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 1 group by convert(varchar(10),epis.episdatearri,103)"

                        'JGM - Afegim la nova agenda de TODAS URG
                    Case "-TODAS URG-"
                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                    "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key in (1,21,101,102,126) group by convert(varchar(10),epis.episdatearri,103)"
                        'JGM
                        'JGM - Afegim la nova agenda de TODAS URG
                    Case "UREN"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 21 group by convert(varchar(10),epis.episdatearri,103)"
                        'JGM

                    Case ""
                        lb_control_agenda_urg = False

                End Select

            End If

            'OdbcConnection1.BeginTransaction.IsolationLevel = IsolationLevel.ReadUncommitted

            Me.OdbcDataAdapter1.Fill(Me.Ds_dias1.dias)

            'JGM
            If lb_control_agenda_urg = False Then
                Me.Ds_dias1.dias.Clear()
            End If
            'JGM

            li_contador = Me.Ds_dias1.dias.Rows.Count

            If li_contador > 0 Then

                For n = 0 To li_contador - 1
                    'Me.Calendar1.SelectedDates.Add(CDate(Me.Ds_dias1.dias.Rows(n).Item(0)))
                Next

            End If

            Me.OdbcConnection1.Close()

            'Me.Ds_dias1.dias.Clear()

            ' Fin Calendario 1.

            'Me.Calendar2.VisibleDate = DateAdd(DateInterval.Month, 1, e.NewDate)

            ' Calendario 2.

            'Me.Calendar2.SelectedDate = Nothing

            Me.OdbcConnection1.Open()

            OdbcDataAdapter1.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

            '.IsolationLevel = .Open()

            'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT diar.diardate AS dia " & _
            '"FROM diar " & _
            '"WHERE diar.agencode = '" & Me.DropDownList1.SelectedValue & "' AND diar.diaracti = 'Y' AND diar.btimetabcode = 10 AND month(diar.diardate) = " & Month(Me.Calendar2.VisibleDate) & " AND year(diar.diardate) = " & Year(Me.Calendar2.VisibleDate) & ""

            'OdbcDataAdapter1.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

            If Me.Dropdownlist2.SelectedValue <> "UR" Then

                If Session("grupo") = "G" Or Session("grupo") = "U" Or Session("grupo") = "W" Or Session("grupo") = "I" Then

                Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
                "INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                "INNER JOIN CIMACEX.dbo.cima_epis_usuarios on epis.epis_key = CIMACEX.dbo.cima_epis_usuarios.epis_key " & _
                "INNER JOIN CIMACEX.dbo.cima_usuarios on CIMACEX.dbo.cima_usuarios.id_usuario = CIMACEX.dbo.cima_epis_usuarios.usuario COLLATE Modern_Spanish_CS_AS " & _
                "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND " & _
                " (book.agencode = '" & Me.DropDownList1.SelectedValue & "' OR ('-TODAS RAD-' = '" & Trim(Me.DropDownList1.SelectedValue) & "' and csta.tactcode = 'RX' )) " & _
                " and CIMACEX.dbo.cima_usuarios.grupo = '" & Session("grupo") & "'" & _
                "GROUP BY book.diardate"

            Else
                If Session("grupo") = "L" Then

                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                    "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
                    "INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                    "INNER JOIN cima_nhc_imarques on cima_nhc_imarques.epis_key = epis.epis_key " & _
                    "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND book.agencode = '" & Me.DropDownList1.SelectedValue & "' " & _
                    "GROUP BY book.diardate"

                Else


                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
                    "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
                    "INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
                    "WHERE appostat.appostatcode in ('R','EN','PR','D','P') AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND (book.agencode = '" & Me.DropDownList1.SelectedValue & "' " & _
                    " OR ('-TODAS RAD-' = '" & Trim(Me.DropDownList1.SelectedValue) & "' and csta.tactcode = 'RX' )) " & _
                    "GROUP BY book.diardate"

                End If
            End If

        Else

                Select Case Trim(Me.DropDownList1.SelectedValue)

                    Case "URPED"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 126 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URMI"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 102 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URCOT"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 101 group by convert(varchar(10),epis.episdatearri,103)"

                    Case "URESP"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 1 group by convert(varchar(10),epis.episdatearri,103)"

                        'JGM Afegim la nova TODAS URG
                    Case "-TODAS URG-"
                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                    "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key in (1,21,101,102,126) group by convert(varchar(10),epis.episdatearri,103)"
                        'JGM

                        'JGM - Afegim la nova agenda de TODAS URG
                    Case "UREN"
                        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cast(convert(varchar(10),epis.episdatearri,103) as datetime) AS dia, count(*) as numero " & _
                        "FROM epis INNER JOIN clip INNER JOIN pati INNER JOIN pers on pati.pers_key=pers.pers_key on clip.pers_key=pati.pers_key on epis.clip_key=clip.clip_key INNER JOIN emep on epis.epis_key=emep.epis_key INNER JOIN csta on epis.csta_key=csta.csta_key LEFT OUTER JOIN bedm INNER JOIN beds on bedm.beds_key=beds.beds_key AND bedm.bedmlast='Y' on epis.epis_key=bedm.epis_key  WHERE (csta.cent_key = 1) and month(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Month & " and year(convert(varchar(10),epis.episdatearri,103)) = " & Me.Calendar1.VisibleDate.Year & " and csta.csta_key = 21 group by convert(varchar(10),epis.episdatearri,103)"
                        'JGM

                    Case ""
                        lb_control_agenda_urg = False

                End Select

            End If

            Me.OdbcDataAdapter1.Fill(Me.Ds_dias2.dias)

            li_contador = Me.Ds_dias2.dias.Rows.Count

            'JGM
            If lb_control_agenda_urg = False Then
                Me.Ds_dias2.dias.Clear()
            End If
            'JGM


            If li_contador > 0 Then

                For n = 0 To li_contador - 1
                    'Me.Calendar2.SelectedDates.Add(CDate(Me.Ds_dias2.dias.Rows(n).Item(0)))
                Next

            End If

            Me.OdbcConnection1.Close()

            '

            Me.OdbcConnection1.Open()

            OdbcDataAdapter1.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT diar.diardate AS dia,  [dbo].[f_cima_estado_dia] (diar.agencode,diar.diardate) AS estado " & _
            "FROM diar INNER JOIN btimetab on diar.btimetabcode = btimetab.btimetabcode AND diar.agencode = btimetab.agencode " & _
            "WHERE diar.agencode = '" & Me.DropDownList1.SelectedValue & "' AND diar.diaracti = 'Y' AND month(diar.diardate) = " & Month(Me.Calendar2.VisibleDate) & " AND year(diar.diardate) = " & Year(Me.Calendar2.VisibleDate) & " GROUP BY diar.diardate, [dbo].[f_cima_estado_dia] (diar.agencode,diar.diardate)"

            'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
            '"FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  INNER  JOIN agenproc ON bookproc.agenproc_key=agenproc.agenproc_key INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key INNER  JOIN episfirm ON episfirm.epis_key=appo.epis_key " & _
            '"WHERE bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND book.agencode = '" & Me.DropDownList1.SelectedValue & "' AND episfirm.episfirmmain = 'Y' " & _
            '"GROUP BY book.diardate"

            Me.OdbcDataAdapter1.Fill(Me.Ds_dias3.dias)

            li_contador = Me.Ds_dias3.dias.Rows.Count

            If li_contador > 0 Then

                For n = 0 To li_contador - 1
                    'Me.Calendar2.SelectedDates.Add(CDate(Me.Ds_dias2.dias.Rows(n).Item(0)))
                Next

            End If

            Me.OdbcConnection1.Close()

            'Me.Ds_dias1.dias.Clear()

            ' Fin.

            ib_control = True

    End Sub

    Private Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar1.DayRender

        Dim li_contador As Integer
        Dim n As Integer

        Dim ll As Object



        If ib_control = False Then

            Call f_marcar()

        End If

        li_contador = Me.Ds_dias1.dias.Rows.Count

        If e.Day.IsOtherMonth Then
            e.Cell.Text = ""
        End If

        If li_contador > 0 Then

            For n = 0 To li_contador - 1

                If e.Day.Date = CDate(Me.Ds_dias1.dias.Rows(n).Item(0)) Then

                    e.Cell.BackColor = e.Cell.BackColor.LightBlue
                    e.Cell.ToolTip = "Citas= " + CStr(Me.Ds_dias1.dias.Rows(n).Item(1))

                End If

                'Me.Calendar1.SelectedDates.Add(CDate(Me.Ds_dias1.dias.Rows(n).Item(0)))

            Next

        End If

        'Dim pp As String
        'pp = e.Day.DayNumberText.ToString()

        'If e.Day.Date = #12/10/2004# Then
        'e.Cell.BackColor = e.Cell.BackColor.Fuchsia()
        'End If

    End Sub

    Private Sub Calendar2_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar2.DayRender

        Dim li_contador, li_contador_2 As Integer
        Dim n As Integer

        Dim ls_array_fecha() As String



        If ib_control = False Then

            Call f_marcar()

        End If

        li_contador = Me.Ds_dias2.dias.Rows.Count
        li_contador_2 = Me.Ds_dias3.dias.Rows.Count

        e.Cell.Text = "&nbsp;"

        If e.Day.IsOtherMonth Then
            e.Cell.Text = ""
        End If

        If li_contador > 0 Then

            For n = 0 To li_contador - 1

                If e.Day.Date = CDate(Me.Ds_dias2.dias.Rows(n).Item(0)) Then

                    'e.Cell.BackColor = e.Cell.BackColor.Fuchsia()
                    e.Cell.Text = CStr(Me.Ds_dias2.dias.Rows(n).Item(1))
                    'e.Cell.ToolTip = "Citas= " + CStr(Me.Ds_dias2.dias.Rows(n).Item(1))
                    'e.Cell.ToolTip = "Citas= " + CStr(Me.Ds_dias2.dias.Rows(n).Item(1))

                End If

                'Me.Calendar1.SelectedDates.Add(CDate(Me.Ds_dias1.dias.Rows(n).Item(0)))

            Next

        End If

        'ok = False

        ls_array_fecha = Split(Session("dia_seleccionado"), " ", , CompareMethod.Text)

        If li_contador_2 > 0 Then

            For n = 0 To li_contador_2 - 1

                If e.Day.Date = CDate(Me.Ds_dias3.dias.Rows(n).Item(0)) Then

                    Select Case Me.Ds_dias3.dias.Rows(n).Item(2)
                        Case "U"
                            If ls_array_fecha(0) = CStr(Me.Ds_dias3.dias.Rows(n).Item(0)) Then
                                Session("ok") = "S"
                            End If
                            e.Cell.BackColor = e.Cell.BackColor.Green 'Yellow
                        Case "B"
                            e.Cell.BackColor = e.Cell.BackColor.Yellow
                        Case "V"
                            e.Cell.BackColor = e.Cell.BackColor.Gold
                        Case "C"
                            e.Cell.BackColor = e.Cell.BackColor.Red
                            Session("ok") = "S"
                    End Select

                    'e.Cell.BackColor = e.Cell.BackColor.GreenYellow
                    'e.Cell.Text = CStr(Me.Ds_dias3.dias.Rows(n).Item(1))
                    'e.Cell.ToolTip = "Citas= " + CStr(Me.Ds_dias2.dias.Rows(n).Item(1))

                End If

                'Me.Calendar1.SelectedDates.Add(CDate(Me.Ds_dias1.dias.Rows(n).Item(0)))

            Next

        End If

        'Dim pp As String
        'pp = e.Day.DayNumberText.ToString()

        'If e.Day.Date = #12/10/2004# Then
        'e.Cell.BackColor = e.Cell.BackColor.Fuchsia()
        'End If

    End Sub


    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim ls_array(), ls_array2() As String



        Session("VisibleFecha") = Me.Calendar1.SelectedDate

        Session("dia_seleccionado") = Nothing

        Label2.Text = ""

        If Me.Calendar1.SelectedDate <> Nothing Then

            ls_array = Split(Me.Calendar1.SelectedDate.ToString, "/")
            'Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)

            If Len(Trim(Request("dia_seleccionado"))) > 0 Then

                Session("dia_seleccionado") = Request("dia_seleccionado")

            Else

                Session("dia_seleccionado") = Me.Calendar1.SelectedDate.ToString

            End If

            ls_array2 = Split(ls_array(2), " ")

            Label2.Visible = True

            Label2.Text = "Día: " + ls_array(0) + "/" + ls_array(1) + "/" + ls_array2(0)

            'Label2.Text = "Día: " + Session("dia_seleccionado")

        Else

            Label2.Visible = False

        End If

        If Me.Calendar2.SelectedDate <> Nothing Then

            ls_array = Split(Me.Calendar2.SelectedDate.ToString, "/")
            'Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)

            'Session("dia_seleccionado") = Me.Calendar2.SelectedDate.ToString

            If Len(Trim(Request("dia_seleccionado"))) > 0 Then

                Session("dia_seleccionado") = Request("dia_seleccionado")

            Else

                Session("dia_seleccionado") = Me.Calendar2.SelectedDate.ToString

            End If

            ls_array2 = Split(ls_array(2), " ")

            Label2.Visible = True

            Label2.Text = "Día: " + ls_array(1) + "/" + ls_array(0) + "/" + ls_array2(0)

            'Label2.Text = "Día: " + Session("dia_seleccionado")

        Else

            'Label2.Visible = False

        End If

        Session("agencode") = Me.DropDownList1.SelectedValue

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        Me.Calendar2.SelectedDate = Nothing

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged

        Me.Calendar1.SelectedDate = Nothing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        If CDate(Me.Calendar1.SelectedDate) < Today() Then

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar un día posterior o igual a la fecha de hoy.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            If Session("ok") = "S" Then

                If IsDate(objCIMA.f_formato_fecha(Session("dia_seleccionado"))) And Len(Trim(Session("agencode"))) > 0 Then

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("control = 1;" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                End If

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Debe seleccionar un día correcto.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        End If

    End Sub


    Private Sub Calendar2_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar2.PreRender

        Session("ok") = "N"

    End Sub

    Private Sub Dropdownlist2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist2.SelectedIndexChanged

        Dim login As String

        login = Request.Cookies("usuario").Value

        Me.Ds_agendas1.Clear()

        If Me.CheckBox1.Checked = True Then

            Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
                    "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
                    " @id_usuario) AND (agen.agenacti <> 'Y') AND (agen.agentypecode = @agentypecode) " & _
                    "ORDER BY agen.agenname"

        End If

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.Dropdownlist2.SelectedValue

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
        Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        If Me.Dropdownlist2.SelectedValue = "RX" Then
            Me.DropDownList1.Items.Add("-TODAS RAD-")
        End If

        'JGM Afegim Totes al servei d'Urgències
        If Me.Dropdownlist2.SelectedValue = "UR" And Me.Ds_agendas1.cima_usuarios_agen.Rows.Count() > 0 Then
            Me.DropDownList1.Items.Add("-TODAS URG-")
        End If
        'JGM

        'Me.DropDownList1.Items.Add("")

        'If Len(Trim(Request("DropDownList1"))) > 0 Then
        'Me.DropDownList1.SelectedValue = Request("DropDownList1")
        'Session("agenda_en_acto") = Request("DropDownList1")
        'End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Dim login As String



        login = Request.Cookies("usuario").Value

        If Me.CheckBox1.Checked = True Then

            Session("ok") = "N"

            Me.Ds_agendas1.Clear()

            Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
                    "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
                    " @id_usuario) AND (agen.agenacti <> 'Y') AND (agen.agentypecode = @agentypecode) " & _
                    "ORDER BY agen.agenname"

            If Len(Trim(Request("DropDownList2"))) > 0 Then

                'Me.Dropdownlist2.SelectedValue = Request("DropDownList2")
                Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("DropDownList2")
                'ls_servicio = Request("DropDownList2")

            Else
                If Len(Trim(Request("servicio_origen"))) > 0 Then

                    'Me.Dropdownlist2.SelectedValue = Request("servicio_origen")
                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("servicio_origen") 'Me.Dropdownlist2.SelectedValue
                    'ls_servicio = Request("servicio_origen")

                Else

                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.Dropdownlist2.SelectedValue
                    'ls_servicio = Me.Dropdownlist2.SelectedValue

                End If

                'Session("agenda_en_acto") = Request("DropDownList1")

            End If

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
            Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
            Me.DropDownList1.DataBind()
            Me.SqlConnection1.Close()

            'If Len(Trim(Request("DropDownList1"))) > 0 Then

            'Me.DropDownList1.SelectedValue = Request("DropDownList1")

            'End If

        Else

            Session("ok") = "N"

            Me.Ds_agendas1.Clear()

            Me.SqlDataAdapter1.SelectCommand.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
                    "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
                    " @id_usuario) AND (agen.agenacti = 'Y') AND (agen.agentypecode = @agentypecode) " & _
                    "ORDER BY agen.agenname"

            If Len(Trim(Request("DropDownList2"))) > 0 Then

                'Me.Dropdownlist2.SelectedValue = Request("DropDownList2")
                Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("DropDownList2")
                'ls_servicio = Request("DropDownList2")

            Else
                If Len(Trim(Request("servicio_origen"))) > 0 Then

                    'Me.Dropdownlist2.SelectedValue = Request("servicio_origen")
                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Request("servicio_origen") 'Me.Dropdownlist2.SelectedValue
                    'ls_servicio = Request("servicio_origen")

                Else

                    Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.Dropdownlist2.SelectedValue
                    'ls_servicio = Me.Dropdownlist2.SelectedValue

                End If

                'Session("agenda_en_acto") = Request("DropDownList1")

            End If

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
            Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
            Me.DropDownList1.DataBind()
            Me.SqlConnection1.Close()

            'If Len(Trim(Request("DropDownList1"))) > 0 Then

            'Me.DropDownList1.SelectedValue = Request("DropDownList1")

            'End If

        End If

    End Sub

End Class
