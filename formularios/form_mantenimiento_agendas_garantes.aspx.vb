Public Class form_mantenimiento_agendas_garantes
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen_tabla1 = New cimaweb.ds_agen_tabla
        Me.Ds_firm_garantes1 = New cimaweb.ds_firm_garantes
        Me.Ds_covegrou1 = New cimaweb.ds_covegrou
        Me.Ds_firm_garantes2 = New cimaweb.ds_firm_garantes
        Me.Ds_agendas_garantes1 = New cimaweb.ds_agendas_garantes
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter12 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agendas_garantes2 = New cimaweb.ds_agendas_garantes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_coberturas1 = New cimaweb.ds_cima_coberturas
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter7 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm_garantes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agendas_garantes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_coberturas1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss FROM agen WHERE (agenacti = 'Y')" & _
        " AND (cent_key = 1) AND (agencode IN (SELECT resoagen.agencode FROM resoagen WHE" & _
        "RE resoagen.tablcode = 'csta')) AND (agentypecode IN ('CE', 'RX', 'LA', 'UR','FA" & _
        "')) ORDER BY agenname"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("addrcodemain", "addrcodemain"), New System.Data.Common.DataColumnMapping("addrcodedeli", "addrcodedeli"), New System.Data.Common.DataColumnMapping("addrcodeinvo", "addrcodeinvo"), New System.Data.Common.DataColumnMapping("ttaxgfircode", "ttaxgfircode"), New System.Data.Common.DataColumnMapping("paymdocucode", "paymdocucode"), New System.Data.Common.DataColumnMapping("firmclascode", "firmclascode"), New System.Data.Common.DataColumnMapping("currcode", "currcode"), New System.Data.Common.DataColumnMapping("langcode", "langcode"), New System.Data.Common.DataColumnMapping("addrcodepaym", "addrcodepaym"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("payccode", "payccode"), New System.Data.Common.DataColumnMapping("idenfirmcode", "idenfirmcode"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firmname", "firmname"), New System.Data.Common.DataColumnMapping("firmnamecomm", "firmnamecomm"), New System.Data.Common.DataColumnMapping("firmidencode", "firmidencode"), New System.Data.Common.DataColumnMapping("firmdateacti", "firmdateacti"), New System.Data.Common.DataColumnMapping("firmrema", "firmrema"), New System.Data.Common.DataColumnMapping("firmfilename", "firmfilename"), New System.Data.Common.DataColumnMapping("firmacti", "firmacti"), New System.Data.Common.DataColumnMapping("plancodeterr", "plancodeterr"), New System.Data.Common.DataColumnMapping("tfircode", "tfircode"), New System.Data.Common.DataColumnMapping("firmea13", "firmea13"), New System.Data.Common.DataColumnMapping("firm_abc", "firm_abc"), New System.Data.Common.DataColumnMapping("invccode", "invccode"), New System.Data.Common.DataColumnMapping("firmguar", "firmguar"), New System.Data.Common.DataColumnMapping("firmnameshor", "firmnameshor"), New System.Data.Common.DataColumnMapping("funccodebrne", "funccodebrne"), New System.Data.Common.DataColumnMapping("funccodeprpr", "funccodeprpr"), New System.Data.Common.DataColumnMapping("firm_keyfath", "firm_keyfath"), New System.Data.Common.DataColumnMapping("funccodebrnedeli", "funccodebrnedeli"), New System.Data.Common.DataColumnMapping("funccodeprprdeli", "funccodeprprdeli"), New System.Data.Common.DataColumnMapping("funccodebrneorde", "funccodebrneorde"), New System.Data.Common.DataColumnMapping("funccodeprprorde", "funccodeprprorde"), New System.Data.Common.DataColumnMapping("buni_key", "buni_key"), New System.Data.Common.DataColumnMapping("codetmplcode", "codetmplcode"), New System.Data.Common.DataColumnMapping("funccodeacce", "funccodeacce"), New System.Data.Common.DataColumnMapping("firmtrantime", "firmtrantime"), New System.Data.Common.DataColumnMapping("firmpartserv", "firmpartserv"), New System.Data.Common.DataColumnMapping("firmminiperc", "firmminiperc"), New System.Data.Common.DataColumnMapping("firmrealqualctrl", "firmrealqualctrl"), New System.Data.Common.DataColumnMapping("firmleve", "firmleve"), New System.Data.Common.DataColumnMapping("firmorde", "firmorde"), New System.Data.Common.DataColumnMapping("firmdelidays", "firmdelidays"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("firmdatedrop", "firmdatedrop"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("plancodeter2", "plancodeter2"), New System.Data.Common.DataColumnMapping("addrcodezone", "addrcodezone"), New System.Data.Common.DataColumnMapping("tfircod2", "tfircod2"), New System.Data.Common.DataColumnMapping("plancodefir2", "plancodefir2"), New System.Data.Common.DataColumnMapping("firminvonumb", "firminvonumb"), New System.Data.Common.DataColumnMapping("firm_keytabl", "firm_keytabl"), New System.Data.Common.DataColumnMapping("tablcode", "tablcode"), New System.Data.Common.DataColumnMapping("trac_key", "trac_key")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT firm.firm_key, firm.addrcodemain, firm.addrcodedeli, firm.addrcodeinvo, fi" & _
        "rm.ttaxgfircode, firm.paymdocucode, firm.firmclascode, firm.currcode, firm.langc" & _
        "ode, firm.addrcodepaym, firm.plancode, firm.payccode, firm.idenfirmcode, firm.fi" & _
        "rmcode, LTRIM(RTRIM(firm.firmcode)) + ' - ' + firm.firmname AS firmname, firm.fi" & _
        "rmnamecomm, firm.firmidencode, firm.firmdateacti, firm.firmrema, firm.firmfilena" & _
        "me, firm.firmacti, firm.plancodeterr, firm.tfircode, firm.firmea13, firm.firm_ab" & _
        "c, firm.invccode, firm.firmguar, firm.firmnameshor, firm.funccodebrne, firm.func" & _
        "codeprpr, firm.firm_keyfath, firm.funccodebrnedeli, firm.funccodeprprdeli, firm." & _
        "funccodebrneorde, firm.funccodeprprorde, firm.buni_key, firm.codetmplcode, firm." & _
        "funccodeacce, firm.firmtrantime, firm.firmpartserv, firm.firmminiperc, firm.firm" & _
        "realqualctrl, firm.firmleve, firm.firmorde, firm.firmdelidays, firm.txts_key, fi" & _
        "rm.firmdatedrop, firm.docu_key, firm.plancodeter2, firm.addrcodezone, firm.tfirc" & _
        "od2, firm.plancodefir2, firm.firminvonumb, firm.firm_keytabl, firm.tablcode, fir" & _
        "m.trac_key FROM firm LEFT OUTER JOIN firmclas ON firm.firmclascode = firmclas.fi" & _
        "rmclascode INNER JOIN curr ON firm.currcode = curr.currcode LEFT OUTER JOIN lang" & _
        " ON firm.langcode = lang.langcode INNER JOIN ttaxgfir ON firm.ttaxgfircode = tta" & _
        "xgfir.ttaxgfircode INNER JOIN invc ON firm.invccode = invc.invccode INNER JOIN p" & _
        "ayc ON firm.payccode = payc.payccode WHERE (firm.tfircode = 'CU') AND (firm.firm" & _
        "guar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') ORDER BY firm.f" & _
        "irmname"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'Ds_agen_tabla1
        '
        Me.Ds_agen_tabla1.DataSetName = "ds_agen_tabla"
        Me.Ds_agen_tabla1.EnforceConstraints = False
        Me.Ds_agen_tabla1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_firm_garantes1
        '
        Me.Ds_firm_garantes1.DataSetName = "ds_firm_garantes"
        Me.Ds_firm_garantes1.EnforceConstraints = False
        Me.Ds_firm_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_covegrou1
        '
        Me.Ds_covegrou1.DataSetName = "ds_covegrou"
        Me.Ds_covegrou1.EnforceConstraints = False
        Me.Ds_covegrou1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_firm_garantes2
        '
        Me.Ds_firm_garantes2.DataSetName = "ds_firm_garantes"
        Me.Ds_firm_garantes2.EnforceConstraints = False
        Me.Ds_firm_garantes2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agendas_garantes1
        '
        Me.Ds_agendas_garantes1.DataSetName = "ds_agendas_garantes"
        Me.Ds_agendas_garantes1.EnforceConstraints = False
        Me.Ds_agendas_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_agendas_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_agenda_garante", "id_agenda_garante"), New System.Data.Common.DataColumnMapping("agencode_par", "agencode_par"), New System.Data.Common.DataColumnMapping("firm_key_par", "firm_key_par"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("comentarios", "comentarios")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_agenda_garante, agencode_par, firm_key_par, descripcion, firm_key, cove" & _
        "grou_key, comentarios FROM cima_agendas_garantes ORDER BY descripcion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter12
        '
        Me.SqlDataAdapter12.SelectCommand = Me.SqlSelectCommand12
        Me.SqlDataAdapter12.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_COBERTURAS_FIRM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "[SP_CIMACEX_COBERTURAS_FIRM]"
        Me.SqlSelectCommand12.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        '
        'Ds_agendas_garantes2
        '
        Me.Ds_agendas_garantes2.DataSetName = "ds_agendas_garantes"
        Me.Ds_agendas_garantes2.EnforceConstraints = False
        Me.Ds_agendas_garantes2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_agendas_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_agenda_garante", "id_agenda_garante"), New System.Data.Common.DataColumnMapping("agencode_par", "agencode_par"), New System.Data.Common.DataColumnMapping("firm_key_par", "firm_key_par"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("comentarios", "comentarios")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_agenda_garante, agencode_par, firm_key_par, descripcion, COALESCE (firm" & _
        "_key, 0) AS firm_key, COALESCE (covegrou_key, 0) AS covegrou_key, comentarios FR" & _
        "OM cima_agendas_garantes WHERE (id_agenda_garante = @id_agenda_garante)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4, "id_agenda_garante"))
        '
        'Ds_cima_coberturas1
        '
        Me.Ds_cima_coberturas1.DataSetName = "ds_cima_coberturas"
        Me.Ds_cima_coberturas1.EnforceConstraints = False
        Me.Ds_cima_coberturas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_coberturas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong"), New System.Data.Common.DataColumnMapping("id_agenda_garante", "id_agenda_garante"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CSaludR.dbo.covegrou.covegroudesclong, cima_coberturas.id_agenda_garante, " & _
        "cima_coberturas.covegrou_key FROM cima_coberturas INNER JOIN CSaludR.dbo.covegro" & _
        "u ON CSaludR.dbo.covegrou.covegrou_key = cima_coberturas.covegrou_key WHERE (cim" & _
        "a_coberturas.id_agenda_garante = @id_agenda_garante) ORDER BY CSaludR.dbo.covegr" & _
        "ou.covegroudesclong"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4, "id_agenda_garante"))
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_PRESTACIONES_AUTORIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("retorno", "retorno")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "[SP_CIMACEX_ALTA_PRESTACIONES_AUTORIZACION]"
        Me.SqlSelectCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter7
        '
        Me.SqlDataAdapter7.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter7.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_BAJA_PRESTACIONES_AUTORIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("retorno", "retorno")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "[SP_CIMACEX_BAJA_PRESTACIONES_AUTORIZACION]"
        Me.SqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4))
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm_garantes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agendas_garantes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_coberturas1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agen_tabla1 As cimaweb.ds_agen_tabla
    Protected WithEvents Ds_firm_garantes1 As cimaweb.ds_firm_garantes
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_covegrou1 As cimaweb.ds_covegrou
    Protected WithEvents Ds_firm_garantes2 As cimaweb.ds_firm_garantes
    Protected WithEvents Ds_agendas_garantes1 As cimaweb.ds_agendas_garantes
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents SqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agendas_garantes2 As cimaweb.ds_agendas_garantes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_coberturas1 As cimaweb.ds_cima_coberturas
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Dropdownlist10 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Dropdownlist9 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents count As System.Web.UI.WebControls.TextBox
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button

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

        Dim array() As String
        Dim n As Integer



        Me.Dropdownlist3.Enabled = False
        Me.Dropdownlist5.Enabled = False

        'Introducir aquí el código de usuario para inicializar la página
        Me.SqlConnection2.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_agendas_garantes1.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        Me.Dropdownlist1.DataBind()

        Me.Dropdownlist1.Items.Insert(0, "")

        If Len(Trim(Request("DropDownList1"))) > 0 Then

            Me.Dropdownlist1.SelectedValue = Request("DropDownList1")
            Me.Button5.Enabled = True
        Else
            Me.Button5.Enabled = False
        End If

        If Len(Trim(Request("id_agenda_garante"))) > 0 Then

            Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = Request("DropDownList1")

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter7.SelectCommand.ExecuteNonQuery()

            array = Split(Request("cadena_creciente"), "*", , CompareMethod.Text)

            For n = 0 To UBound(array)

                If array(n) <> "" Then

                    Me.SqlDataAdapter6.SelectCommand.Parameters(1).Value = array(n)
                    Me.SqlDataAdapter6.SelectCommand.Parameters(2).Value = Request("DropDownList1")

                    Me.SqlDataAdapter6.SelectCommand.ExecuteNonQuery()

                End If

            Next

            Me.SqlConnection2.Close()

            refresco_tras_envio()

        End If

    End Sub

    Public Sub actualizar()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist5.DataBind()

        Me.Dropdownlist5.Items.Insert(0, "")

        If Len(Trim(Request("DropDownList5"))) > 0 Then
            Me.Dropdownlist5.SelectedValue = Request("DropDownList5")
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes1.firm)
        Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes2.firm)
        Me.SqlConnection1.Close()

        Me.Dropdownlist3.DataBind()

        Me.Dropdownlist3.Items.Insert(0, "PRIVADO")

        If Len(Trim(Request("DropDownList3"))) > 0 Then
            Me.Dropdownlist3.SelectedValue = Request("DropDownList3")
        End If

        Me.Dropdownlist9.DataBind()

        Me.Dropdownlist9.Items.Insert(0, "PROPIO PACIENTE")

        If Len(Trim(Request("DropDownList9"))) > 0 Then
            Me.Dropdownlist9.SelectedValue = Request("DropDownList9")
        End If



    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        'actualizar()

    End Sub

    Private Sub Dropdownlist1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist1.SelectedIndexChanged

        Me.Panel1.Visible = True
        Me.Panel2.Visible = True
        Me.Button2.Enabled = True

        Me.DataGrid1.Visible = True

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_agendas_garantes2.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        Me.TextBox1.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("descripcion")
        Me.TextBox2.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("comentarios")

        actualizar()

        'Me.TextBox2.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("agencode_par")
        Me.Dropdownlist5.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("agencode_par")
        'Me.Dropdownlist5.SelectedValue = DataBinder.Eval(Ds_agendas_garantes2, "Tables[cima_agendas_garantes].DefaultView.[0].agencode_par")
        'Me.Dropdownlist5.DataBind()

        If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key_par") = "0" Then
            Me.Dropdownlist3.SelectedValue = "PRIVADO"
        Else
            Me.Dropdownlist3.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key_par")
        End If

        If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key") >= 0 Then

            If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key") = "0" Then
                Me.Dropdownlist9.SelectedValue = "PROPIO PACIENTE"
            Else
                Me.Dropdownlist9.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")
            End If

            'Me.Dropdownlist9.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")

            Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter12.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection1.Close()
            Me.Dropdownlist10.DataBind()

            Me.Dropdownlist10.Items.Insert(0, "")

            'Me.Dropdownlist10.SelectedValue = Request("Dropdownlist10")

        End If

        'If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key") <> 0 Then
        'Me.Dropdownlist10.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key")
        'End If

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_cima_coberturas1.cima_coberturas)
        Me.SqlConnection2.Close()

        Me.DataGrid1.DataBind()



        'Me.Dropdownlist10.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key")

    End Sub

    Public Sub refresco_tras_envio()

        Me.Panel1.Visible = True
        Me.Panel2.Visible = True
        Me.Button2.Enabled = True

        Me.DataGrid1.Visible = True

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_agendas_garantes2.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        Me.TextBox1.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("descripcion")
        Me.TextBox2.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("comentarios")

        actualizar()

        'Me.TextBox2.Text = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("agencode_par")
        Me.Dropdownlist5.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("agencode_par")
        'Me.Dropdownlist5.SelectedValue = DataBinder.Eval(Ds_agendas_garantes2, "Tables[cima_agendas_garantes].DefaultView.[0].agencode_par")
        'Me.Dropdownlist5.DataBind()

        If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key_par") = "0" Then
            Me.Dropdownlist3.SelectedValue = "PRIVADO"
        Else
            Me.Dropdownlist3.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key_par")
        End If

        If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key") >= 0 Then

            If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key") = "0" Then
                Me.Dropdownlist9.SelectedValue = "PROPIO PACIENTE"
            Else
                Me.Dropdownlist9.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")
            End If

            'Me.Dropdownlist9.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")

            Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("firm_key")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter12.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection1.Close()
            Me.Dropdownlist10.DataBind()

            Me.Dropdownlist10.Items.Insert(0, "")

            'Me.Dropdownlist10.SelectedValue = Request("Dropdownlist10")

        End If

        'If Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key") <> 0 Then
        'Me.Dropdownlist10.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key")
        'End If

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_cima_coberturas1.cima_coberturas)
        Me.SqlConnection2.Close()

        Me.DataGrid1.DataBind()



        'Me.Dropdownlist10.SelectedValue = Me.Ds_agendas_garantes2.cima_agendas_garantes.Rows(0).Item("covegrou_key")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        actualizar()

        Me.Panel1.Visible = True
        Me.Panel2.Visible = False
        Me.Button2.Enabled = False

        Me.DataGrid1.Visible = True

        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""

        Me.Dropdownlist5.SelectedValue = ""
        Me.Dropdownlist3.SelectedValue = "PRIVADO"

        Me.Dropdownlist9.SelectedValue = "PROPIO PACIENTE"
        Me.Dropdownlist10.SelectedValue = ""

        Me.Dropdownlist1.SelectedValue = ""

        Me.Dropdownlist1.Enabled = False
        Me.Dropdownlist3.Enabled = True
        Me.Dropdownlist5.Enabled = True

    End Sub

    Private Sub Dropdownlist9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist9.SelectedIndexChanged

        Me.Ds_covegrou1.Clear()

        If Request("DropDownList9") = "PROPIO PACIENTE" Then
            Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = "0"
        Else
            Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Me.Dropdownlist9.SelectedValue 'Request("DropDownList9")
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter12.Fill(Me.Ds_covegrou1.covegrou)
        Me.SqlConnection1.Close()
        Me.Dropdownlist10.DataBind()

        Me.Dropdownlist10.Items.Insert(0, "")

        Me.Dropdownlist10.SelectedValue = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql, ls_garante, ls_coberturas, ls_mutua As String

        If Len(Trim(Me.Dropdownlist9.SelectedValue)) > 0 And Me.Dropdownlist9.SelectedValue <> "PROPIO PACIENTE" Then
            ls_garante = Me.Dropdownlist9.SelectedValue
        Else
            ls_garante = "0"
        End If

        If Len(Trim(Me.Dropdownlist10.SelectedValue)) > 0 Then
            ls_coberturas = Me.Dropdownlist10.SelectedValue
        Else
            ls_coberturas = "0"
        End If

        If Len(Trim(Me.Dropdownlist3.SelectedValue)) > 0 And Me.Dropdownlist3.SelectedValue <> "PRIVADO" Then
            ls_mutua = Me.Dropdownlist3.SelectedValue
        Else
            ls_mutua = "0"
        End If

        If Me.Button2.Enabled = False Then 'Insert.

            str_sql = "dbo.SP_CIMACEX_ALTA_AGENDA_GARANTE '" & Me.Dropdownlist5.SelectedValue & "'," & ls_mutua & ",'" + Me.TextBox1.Text & "','" & Me.TextBox2.Text & "'," & ls_garante & "," & ls_coberturas

        Else ' Update.

            str_sql = "dbo.SP_CIMACEX_UPDATE_AGENDA_GARANTE " & Me.Dropdownlist1.SelectedValue & ",'" & Me.Dropdownlist5.SelectedValue & "'," & ls_mutua & ",'" + Me.TextBox1.Text & "','" & Me.TextBox2.Text & "'," & ls_garante & "," & ls_coberturas

        End If

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Me.Button2.Enabled = True
        Me.Panel1.Visible = False

        Me.DataGrid1.Visible = False

        Me.Dropdownlist1.Enabled = True

        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""

        actualizar()

        'Introducir aquí el código de usuario para inicializar la página
        Me.SqlConnection2.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_agendas_garantes1.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        Me.Dropdownlist1.DataBind()

        Me.Dropdownlist1.Items.Insert(0, "")

        'If Len(Trim(Request("DropDownList1"))) > 0 Then
        'Me.Dropdownlist1.SelectedValue = Request("DropDownList1")
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Len(Trim(Request("Dropdownlist9"))) > 0 And Len(Trim(Request("Dropdownlist10"))) > 0 Then

            Me.Dropdownlist9.SelectedValue = Request("Dropdownlist9")

            If Request("DropDownList9") = "PROPIO PACIENTE" Then
                Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = "0"
            Else
                Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Request("DropDownList9")
            End If

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter12.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection1.Close()
            Me.Dropdownlist10.DataBind()

            Me.Dropdownlist10.Items.Insert(0, "")

            Me.Dropdownlist10.SelectedValue = Request("Dropdownlist10")

            If Len(Trim(Me.Dropdownlist1.SelectedValue)) > 0 Then

                str_sql = "dbo.SP_CIMACEX_ALTA_COBERTURA " & Me.Dropdownlist1.SelectedValue & "," & Me.Dropdownlist10.SelectedValue

                objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Else

                'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

            End If

            Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter5.Fill(Me.Ds_cima_coberturas1.cima_coberturas)
            Me.SqlConnection2.Close()

            Me.DataGrid1.DataBind()

            Me.DataGrid1.SelectedIndex = -1

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_BAJA_COBERTURA " & Me.Dropdownlist1.SelectedValue & "," & Me.DataGrid1.SelectedItem.Cells(2).Text

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Else

            'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        End If

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_cima_coberturas1.cima_coberturas)
        Me.SqlConnection2.Close()

        Me.DataGrid1.DataBind()

        Me.DataGrid1.SelectedIndex = -1

        Me.Dropdownlist10.SelectedValue = ""

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        
        str_sql = "dbo.SP_CIMACEX_BAJA_AGENDA_GARANTE " & Me.Dropdownlist1.SelectedValue


        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Me.Button2.Enabled = True
        Me.Panel1.Visible = False

        Me.DataGrid1.Visible = False

        Me.Dropdownlist1.Enabled = True

        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_agendas_garantes1.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        Me.Dropdownlist1.DataBind()

        Me.Dropdownlist1.Items.Insert(0, "")


        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("alert('Par ELIMINADO con éxito.');" & vbCrLf)

        Response.Write("</scr" & "ipt>" & vbCrLf)
        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("location.href='form_mantenimiento_agendas_garantes.aspx';" & vbCrLf)
        Response.Write("</scr" & "ipt>" & vbCrLf)
    End Sub
End Class
