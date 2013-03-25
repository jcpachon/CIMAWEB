Public Class form_reprogramar_cita
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_prestaciones1 = New cimaweb.ds_prestaciones
        Me.Ds_medicos1 = New cimaweb.ds_medicos
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_franja_horaria1 = New cimaweb.ds_franja_horaria
        Me.OdbcDataAdapter3 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
        Me.Ds_btimetab1 = New cimaweb.ds_btimetab
        Me.Ds_agen_agenname1 = New cimaweb.ds_agen_agenname
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_nombre_paciente1 = New cimaweb.ds_nombre_paciente
        Me.Ds_dias2 = New cimaweb.ds_dias
        Me.Ds_dias3 = New cimaweb.ds_dias
        Me.Ds_dias1 = New cimaweb.ds_dias
        Me.OdbcDataAdapter4 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand4 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDataAdapter5 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand1 = New System.Data.Odbc.OdbcCommand
        Me.Ds_carga_mod_cita1 = New cimaweb.ds_carga_mod_cita
        Me.OdbcDataAdapter6 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand5 = New System.Data.Odbc.OdbcCommand
        Me.Ds_busca_huecos1 = New cimaweb.ds_busca_huecos
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_medicos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen_agenname1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_nombre_paciente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_dias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_carga_mod_cita1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_prestaciones1
        '
        Me.Ds_prestaciones1.DataSetName = "ds_prestaciones"
        Me.Ds_prestaciones1.EnforceConstraints = False
        Me.Ds_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_medicos1
        '
        Me.Ds_medicos1.DataSetName = "ds_medicos"
        Me.Ds_medicos1.EnforceConstraints = False
        Me.Ds_medicos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "btimetab", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("btimetabdesc", "btimetabdesc"), New System.Data.Common.DataColumnMapping("btimetabdateinit", "btimetabdateinit"), New System.Data.Common.DataColumnMapping("btimetabdate_end", "btimetabdate_end"), New System.Data.Common.DataColumnMapping("btimetabdaysweek", "btimetabdaysweek"), New System.Data.Common.DataColumnMapping("btimetabhour_end", "btimetabhour_end"), New System.Data.Common.DataColumnMapping("btimetabhourinit", "btimetabhourinit"), New System.Data.Common.DataColumnMapping("btimetab_maxpers", "btimetab_maxpers"), New System.Data.Common.DataColumnMapping("btimetabamou", "btimetabamou"), New System.Data.Common.DataColumnMapping("btimetabappointe", "btimetabappointe"), New System.Data.Common.DataColumnMapping("btimetabappoholi", "btimetabappoholi"), New System.Data.Common.DataColumnMapping("btimetabgran", "btimetabgran"), New System.Data.Common.DataColumnMapping("spdi_key", "spdi_key"), New System.Data.Common.DataColumnMapping("btimetabacti", "btimetabacti"), New System.Data.Common.DataColumnMapping("btimetabupda", "btimetabupda"), New System.Data.Common.DataColumnMapping("btimetabdefa", "btimetabdefa"), New System.Data.Common.DataColumnMapping("btimetabwarn", "btimetabwarn")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT agencode, btimetabcode, btimetabdesc, btimetabdateinit, btimetabdate_end, " & _
        "btimetabdaysweek, btimetabhour_end, btimetabhourinit, btimetab_maxpers, btimetab" & _
        "amou, btimetabappointe, btimetabappoholi, btimetabgran, spdi_key, btimetabacti, " & _
        "btimetabupda, btimetabdefa, btimetabwarn FROM btimetab"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "PWD=kampeon10;DSN=CSaludR;UID=sa;LANGUAGE=Español;APP=Microsoft® Visual Studio .N" & _
        "ET;WSID=MINERVA;DATABASE=CSaludR"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agenname", "agenname")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT agenname FROM agen WHERE (agencode = @agencode)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6, "agencode"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
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
        'Ds_franja_horaria1
        '
        Me.Ds_franja_horaria1.DataSetName = "ds_franja_horaria"
        Me.Ds_franja_horaria1.EnforceConstraints = False
        Me.Ds_franja_horaria1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter3
        '
        Me.OdbcDataAdapter3.SelectCommand = Me.OdbcSelectCommand3
        Me.OdbcDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cstahper", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key")})})
        '
        'OdbcSelectCommand3
        '
        Me.OdbcSelectCommand3.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key FROM cstahper I" & _
        "NNER JOIN pers ON cstahper.pers_key = pers.pers_key INNER JOIN agen ON agen.csta" & _
        "_key = cstahper.csta_key ORDER BY pers.persfullname"
        Me.OdbcSelectCommand3.Connection = Me.OdbcConnection1
        '
        'Ds_btimetab1
        '
        Me.Ds_btimetab1.DataSetName = "ds_btimetab"
        Me.Ds_btimetab1.EnforceConstraints = False
        Me.Ds_btimetab1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agen_agenname1
        '
        Me.Ds_agen_agenname1.DataSetName = "ds_agen_agenname"
        Me.Ds_agen_agenname1.EnforceConstraints = False
        Me.Ds_agen_agenname1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("spdi_key", "spdi_key"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("agenacti", "agenacti"), New System.Data.Common.DataColumnMapping("caltcode", "caltcode"), New System.Data.Common.DataColumnMapping("agentypecode", "agentypecode"), New System.Data.Common.DataColumnMapping("cent_key", "cent_key"), New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("agenautodoss", "agenautodoss"), New System.Data.Common.DataColumnMapping("agenflagpacs", "agenflagpacs"), New System.Data.Common.DataColumnMapping("agenpriv", "agenpriv"), New System.Data.Common.DataColumnMapping("agenwarn", "agenwarn"), New System.Data.Common.DataColumnMapping("prod_key", "prod_key"), New System.Data.Common.DataColumnMapping("msrepl_tran_version", "msrepl_tran_version")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT agencode, spdi_key, agenname, agenacti, caltcode, agentypecode, cent_key, " & _
        "csta_key, agenautodoss, agenflagpacs, agenpriv, agenwarn, prod_key, msrepl_tran_" & _
        "version FROM agen"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
        '
        'Ds_nombre_paciente1
        '
        Me.Ds_nombre_paciente1.DataSetName = "ds_nombre_paciente"
        Me.Ds_nombre_paciente1.EnforceConstraints = False
        Me.Ds_nombre_paciente1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'Ds_dias1
        '
        Me.Ds_dias1.DataSetName = "ds_dias"
        Me.Ds_dias1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter4
        '
        Me.OdbcDataAdapter4.SelectCommand = Me.OdbcSelectCommand4
        Me.OdbcDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode")})})
        '
        'OdbcSelectCommand4
        '
        Me.OdbcSelectCommand4.CommandText = "SELECT agencode FROM agen"
        Me.OdbcSelectCommand4.Connection = Me.OdbcConnection1
        '
        'OdbcDataAdapter5
        '
        Me.OdbcDataAdapter5.SelectCommand = Me.OdbcCommand1
        Me.OdbcDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode")})})
        '
        'OdbcCommand1
        '
        Me.OdbcCommand1.CommandText = "SELECT agencode FROM agen"
        Me.OdbcCommand1.Connection = Me.OdbcConnection1
        '
        'Ds_carga_mod_cita1
        '
        Me.Ds_carga_mod_cita1.DataSetName = "ds_carga_mod_cita"
        Me.Ds_carga_mod_cita1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter6
        '
        Me.OdbcDataAdapter6.SelectCommand = Me.OdbcSelectCommand5
        Me.OdbcDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_CARGA_MOD_CITA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("bookhini", "bookhini"), New System.Data.Common.DataColumnMapping("bookhend", "bookhend"), New System.Data.Common.DataColumnMapping("booktime", "booktime"), New System.Data.Common.DataColumnMapping("agenproc_key", "agenproc_key")})})
        '
        'OdbcSelectCommand5
        '
        Me.OdbcSelectCommand5.CommandText = "{? = CALL [SP_CIMACEX_CARGA_MOD_CITA]( ? )}"
        Me.OdbcSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand5.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand5.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand5.Parameters.Add(New System.Data.Odbc.OdbcParameter("@episcode", System.Data.Odbc.OdbcType.VarChar, 11))
        '
        'Ds_busca_huecos1
        '
        Me.Ds_busca_huecos1.DataSetName = "ds_busca_huecos"
        Me.Ds_busca_huecos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter8
        '
        Me.SqlDataAdapter8.SelectCommand = Me.SqlSelectCommand8
        Me.SqlDataAdapter8.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_BUSCA_HUECOS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hora_ini", "hora_ini"), New System.Data.Common.DataColumnMapping("hora_fin", "hora_fin"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("diardate", "diardate"), New System.Data.Common.DataColumnMapping("ok", "ok"), New System.Data.Common.DataColumnMapping("diardate1", "diardate1"), New System.Data.Common.DataColumnMapping("dia_semana", "dia_semana"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("duracion", "duracion"), New System.Data.Common.DataColumnMapping("hora_inicial", "hora_inicial")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "[SP_CIMACEX_BUSCA_HUECOS]"
        Me.SqlSelectCommand8.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand8.Connection = Me.SqlConnection2
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dia", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@covegrou_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@duracion", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hora_inicial", System.Data.SqlDbType.Char, 5))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bloque_horario", System.Data.SqlDbType.Int, 4))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_medicos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen_agenname1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_nombre_paciente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_dias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_carga_mod_cita1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_prestaciones1 As cimaweb.ds_prestaciones
    Protected WithEvents Ds_medicos1 As cimaweb.ds_medicos
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_franja_horaria1 As cimaweb.ds_franja_horaria
    Protected WithEvents OdbcDataAdapter3 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_btimetab1 As cimaweb.ds_btimetab
    Protected WithEvents Ds_agen_agenname1 As cimaweb.ds_agen_agenname
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Ds_nombre_paciente1 As cimaweb.ds_nombre_paciente
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Ds_dias2 As cimaweb.ds_dias
    Protected WithEvents Ds_dias3 As cimaweb.ds_dias
    Protected WithEvents Ds_dias1 As cimaweb.ds_dias
    Protected WithEvents OdbcDataAdapter4 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand4 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDataAdapter5 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_carga_mod_cita1 As cimaweb.ds_carga_mod_cita
    Protected WithEvents OdbcDataAdapter6 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand5 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Ds_busca_huecos1 As cimaweb.ds_busca_huecos
    Protected WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents fecha_ini As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button3 As WebControlCIMA.Buttons.ButtonEnviar

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim ib_control As Boolean

    Private service As New CIMAServeiIntegracio.ServeiIntegracio

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim li_dia As Integer

        Dim n As Integer

        Dim fecha_visible As String

        Dim ls_duracion() As String

        Dim li_medico As Integer

        Dim str_menu As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim str_cadena_naciente As String

        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita

        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima", "98yREc37", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)
        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)

        Dim objConn As New Odbc.OdbcConnection

        Dim objCommand As New Odbc.OdbcCommand

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio

        'Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_3 As New Data.DataSet

        Dim li_clave_cetir As Integer

        Dim str_menu_2 As String
        Dim str_menu_3 As String
        Dim str_menu_4 As String
        Dim str_menu_5 As String

        Dim objDS_2 As New Data.DataSet
        Dim objDS_4 As New Data.DataSet
        Dim objDS_5 As New Data.DataSet

        Dim objDS_10 As New Data.DataSet

        Dim objRow_2 As Data.DataRow

        Dim contador As Integer

        Dim ls_agencode_traspaso As String

        Dim li_prestacion As Integer

        Dim ls_episcode As String

        Dim ls_array_1() As String
        Dim ls_array_2() As String

        Dim ls_btimetabcode As String

        'JGM 22/02/2011
        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio
        Dim ls_cadena As String

        Dim lidermalia_ws As New idermalia_ws.Service1
        Dim ldermas_ws As New dermas_ws.Service1

        Dim lds_baja_cita_idermalia As New idermalia_ws.ds_baja_cita
        Dim lds_baja_cita_dermas As New dermas_ws.ds_baja_cita

        Dim ds_baja_citaRow_idermalia As DataRow = lds_baja_cita_idermalia.baja_cita.NewRow()
        Dim ds_baja_citaRow_dermas As DataRow = lds_baja_cita_dermas.baja_cita.NewRow()

        'Dim lds_alta_cita As idermalia_ws.ds_cita
        Dim lds_alta_cita_idermalia As New idermalia_ws.ds_cita
        Dim lds_alta_cita_dermas As New dermas_ws.ds_cita

        Dim ds_cita_persRow_idermalia As DataRow = lds_alta_cita_idermalia.pers.NewRow()
        Dim ds_cita_citaRow_idermalia As DataRow = lds_alta_cita_idermalia.cita.NewRow()

        Dim ds_cita_persRow_dermas As DataRow = lds_alta_cita_dermas.pers.NewRow()
        Dim ds_cita_citaRow_dermas As DataRow = lds_alta_cita_dermas.cita.NewRow()



        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;")
        Response.Write("</scr" & "ipt>" & vbCrLf)

        If Len(Trim(Request("garante"))) > 0 Then

            Session("garante") = Request("garante")

        End If

        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

        'JGM 22/02/2011 - Reprogramació CETIR
        If Len(Trim(Request("agencode"))) > 0 Then

            Session("agencode") = Request("agencode")

        End If

        str_menu_2 = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR '" & Session("episcode") & "'"

        objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        If objDS_2.Tables(0).Rows.Count > 0 Or Session("servicio_seleccionado") = "RX" Then

            Session("control_cambio_prestacion") = "S"
            'Me.DropDownList2.Enabled = False
            'JGM 22/02/2011
            Me.DropDownList2.Enabled = False

        Else

            Session("control_cambio_prestacion") = "N"
            'Me.DropDownList2.Enabled = True
            'JGM 22/02/2011
            Me.DropDownList2.Enabled = True

        End If

        'Session("control_cambio_prestacion") = "S"

        If Request("ok_cita") = "S" Then

            If Request("btimetabcode") = "0" Then

                ''' CETIR.

                'Response.Write("<scr" & "ipt>" & vbCrLf)
                'Response.Write("alert('No está permitido reprogramar citas de RADIOLOGIA. Anule la cita y créela de nuevo.');" & vbCrLf)
                'Response.Write("window.close();" & vbCrLf)
                'Response.Write("</scr" & "ipt>")

                ls_duracion = Split(Request("prestacion"), "/", , CompareMethod.Text)

                If Len(Trim(Request("doctor"))) > 0 Then

                    If CInt(Request("doctor")) > 0 Then
                        li_medico = CInt(Request("doctor"))
                    Else
                        li_medico = 0
                    End If

                Else

                    li_medico = 0

                End If

                service.Timeout = -1

                'If IsNothing(Session("transaccion")) = False Then

                'service.RollbackTransaction(Session("transaccion").ID, True)

                'End If

                'l_transaccion = service.BegginTransaction()

                'Session("transaccion") = l_transaccion

                If Session("control_cambio_prestacion") = "S" Then
                    'JGM 22/02/2011
                    ' Ja ho tenim recuperat a dat.
                    'str_menu_3 = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR '" & Session("episcode") & "'" '& "'"

                    'objDS_3 = objCIMA.f_consulta_CSaludR(str_menu_3, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    If objDS_2.Tables(0).Rows.Count > 0 Then

                        li_clave_cetir = objDS_2.Tables(0).Rows(0).Item("clave_cetir")

                    Else

                        li_clave_cetir = -1

                    End If

                    lcima_cita = service.ConfirmarHoraRecitadaPacient(Session("transaccion").ID, True, Session("horas_reservadas")(Request("id_cita")))

                    ls_array_1 = Split(Request("hora_inicial"), " ", , CompareMethod.Text)
                    ls_array_2 = Split(CStr(DateAdd(DateInterval.Minute, CInt(Request("hora_final")), CDate(Request("hora_inicial")))), " ", , CompareMethod.Text)

                    Select Case Trim(Session("agencode"))

                        Case "MM"

                            ls_btimetabcode = "351"

                        Case "ECG"

                            ls_btimetabcode = "3341"

                        Case "RXC"

                            ls_btimetabcode = "4"

                        Case "TC"

                            ls_btimetabcode = "125"

                        Case "RM"

                            ls_btimetabcode = "7"

                        Case "DN"

                            ls_btimetabcode = "183"

                        Case "TLM"

                            ls_btimetabcode = "323"

                        Case "URG RX"

                            ls_btimetabcode = "1"

                    End Select

                    'str_menu = "[dbo].[SP_CIMACEX_MOD_CITA_CETIR_SIN_EPIS] '" & Session("episcode") & "','" & Request("fecha_cita") & "','" & Session("agencode") & "','" & ls_array_1(1) & "','" & ls_array_2(1) & "'," & ls_duracion(0) & "," & ls_btimetabcode & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico & ",'" & str_uid & "'," & CStr(li_clave_cetir)
                    str_menu_4 = "[dbo].[SP_CIMACEX_MOD_CITA_CETIR_SIN_EPIS] '" & Session("episcode") & "','" & Request("fecha_cita") & "','" & ls_array_1(1) & "','" & ls_array_2(1) & "','" & str_uid & "'"

                    objDS_4 = objCIMA.f_consulta_CSaludR(str_menu_4, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    'ls_episcode = objDS_4.Tables(0).Rows(0).Item(1)

                    'service.AssociarCitaCGMEpisodiExtern(Session("transaccion").ID, True, lcima_cita.ID_CGM, True, ls_episcode)

                    l_transaccion_retorno = service.CommitTransaccio(Session("transaccion").ID, True)

                    'JGM 22/02/2011 Gravem la traza
                    ls_cadena = "episcode=" & Session("episcode") & "#Reprogramada#" & "ID_CGM=" & CStr(lcima_cita.ID_CGM) & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

                    str_menu_5 = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','RCI'"

                    objDS_5 = objCIMA.f_consulta_CSaludR(str_menu_5, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")
                    'JGM 22/02/2011

                    Session("transaccion") = Nothing

                    Session("horas_reservadas") = Nothing

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Cita reprogramada con éxito.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                    ' Corrección del agencode a char.

                    str_cadena_naciente = Session("agencode")

                    For n = Len(Session("agencode")) To 5
                        str_cadena_naciente = str_cadena_naciente + " "
                    Next

                    ' Fin Corrección del agencode a char.

                    'CARLOS - MODIFICACION ************
                    If Session("form") <> 1 Then
                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Request("fecha_cita") & "';")
                    Else
                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("opener.location.href='../formularios/form_pers.aspx?pers_key=" & Session("pers_key") & "';")
                    End If
                    'CARLOS - MODIFICACION ************
                    'Response.Write("<scr" & "ipt>" & vbCrLf)
                    'Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Request("fecha_cita") & "';")
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                Else

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('No está permitido reprogramar citas de RADIOLOGIA. Anule la cita y créela de nuevo.');" & vbCrLf)
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                    'For Each objRow In objDS.Tables(0).Rows

                    '    contador = contador + 1

                    '    If contador = 1 Then


                    '        lcima_paciente.Data_NaixamentSpecified = True

                    '        lcima_paciente.ID_Pacient_Extern = CStr(objRow.Item("pers_key"))
                    '        lcima_paciente.Nom = objRow.Item("persname")
                    '        lcima_paciente.Cognom1 = objRow.Item("perssur1")
                    '        lcima_paciente.Cognom2 = objRow.Item("perssur2")
                    '        lcima_paciente.Data_Naixament = objRow.Item("fecha_nacimiento")
                    '        lcima_paciente.CIP = ""
                    '        lcima_paciente.DNI = objRow.Item("dni")

                    '        Select Case objRow.Item("tsexcode")

                    '            Case "1"

                    '                lcima_paciente.Sexe = "F"

                    '            Case "2"

                    '                lcima_paciente.Sexe = "M"

                    '            Case Else

                    '                lcima_paciente.Sexe = ""

                    '        End Select

                    '        lcima_paciente.Codi_Postal = objRow.Item("cp")
                    '        lcima_paciente.Adreca = objRow.Item("direccion")
                    '        lcima_paciente.Poblacio = objRow.Item("poblacion")
                    '        lcima_paciente.Professio = ""
                    '        lcima_paciente.Telefon = objRow.Item("tel1")
                    '        lcima_paciente.Mobil = objRow.Item("tel2")
                    '        lcima_paciente.Poblacio_Naixament = ""
                    '        lcima_paciente.E_Mail = objRow.Item("email")
                    '        lcima_paciente.ID_CGM = -1

                    '    End If

                    'Next

                    ''''''''''''

                    'Select Case Trim(Request("btimetabcode"))

                    '    Case "MM"

                    '        ls_btimetabcode = "351"

                    '    Case "ECG"

                    '        ls_btimetabcode = "3341"

                    '    Case "RXC"

                    '        ls_btimetabcode = "4"

                    '    Case "TC"

                    '        ls_btimetabcode = "125"

                    '    Case "RM"

                    '        ls_btimetabcode = "7"

                    '    Case "DN"

                    '        ls_btimetabcode = "183"

                    '    Case "TLM"

                    '        ls_btimetabcode = "323"

                    '    Case "URG RX"

                    '        ls_btimetabcode = "1"

                    'End Select

                    'ls_fecha_cita = CStr(DatePart(DateInterval.Day, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Month, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Year, ldt_hora_ini))

                    'ls_array = Split(Request("prestacion"), "/", , CompareMethod.Text)

                    'lcima_cita = service.ConfirmarHoraPacient(Session("transaccion").ID, True, lcima_paciente, Session("horas_reservadas")(Request("id_cita")))

                    'str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA] '" & ls_fecha_cita & "','" & Request("agencode") & "','" & CStr(DatePart(DateInterval.Hour, ldt_hora_ini)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_ini)) & ":00','" & CStr(DatePart(DateInterval.Hour, ldt_hora_fin)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_fin)) & ":00'," & Request("duracion") & "," & ls_btimetabcode & "," & Mid(ls_array(1), 1, ls_array(1).Length - 1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "'"

                    'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    'ls_episcode = objDS.Tables(0).Rows(0).Item(1)

                    'service.AssociarCitaCGMEpisodiExtern(Session("transaccion").ID, True, lcima_cita.ID_CGM, True, ls_episcode)

                    'service.CommitTransaccio(Session("transaccion").ID, True)

                    'Session("transaccion") = Nothing

                    'Session("horas_reservadas") = Nothing

                    'Response.Write("<scr" & "ipt>" & vbCrLf)
                    'Response.Write("alert('Cita reprogramada con éxito.');" & vbCrLf)
                    'Response.Write("</scr" & "ipt>")

                    '' Corrección del agencode a char.

                    'str_cadena_naciente = Session("agencode")

                    'For n = Len(Session("agencode")) To 5
                    '    str_cadena_naciente = str_cadena_naciente + " "
                    'Next

                    '' Fin Corrección del agencode a char.

                    'Response.Write("<scr" & "ipt>" & vbCrLf)
                    'Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Request("fecha_cita") & "';")
                    'Response.Write("window.close();" & vbCrLf)
                    'Response.Write("</scr" & "ipt>")

                End If

                ''' Fin CETIR.

            Else

                ls_duracion = Split(Request("prestacion"), "/", , CompareMethod.Text)

                If Len(Trim(Request("doctor"))) > 0 Then

                    If CInt(Request("doctor")) > 0 Then
                        li_medico = CInt(Request("doctor"))
                    Else
                        li_medico = 0
                    End If

                Else

                    li_medico = 0

                End If

                str_menu = "[dbo].[SP_CIMACEX_MOD_CITA] '" & Session("episcode") & "','" & Request("fecha_cita") & "','" & Session("agencode") & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Request("btimetabcode") & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico & ",'" & str_uid & "'"

                'response.write (str_menu)

                ''''''''''''''''''''''''''''''''''''''''''

                objDS_10 = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                'objConn.ConnectionString = "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

                'objConn.ConnectionTimeout = 200
                'objCommand.Connection = objConn

                'objConn.Open()

                'objCommand.CommandType = CommandType.StoredProcedure
                'objCommand.CommandText = str_menu

                'objCommand.ExecuteNonQuery()

                'objConn.Close()

                'objConn = Nothing

                'objCommand = Nothing

                ''''''''''''''''''''''''''''''''''''''''''

                ''' Conexión con otros back-offices.

                'If Trim(Session("agencode")) = "BOZA" Or Trim(Session("agencode")) = "SOLE" Or Trim(Session("agencode")) = "SOLER" Or Trim(Session("agencode")) = "GUIL" Or Trim(Session("agencode")) = "BODET" Or Trim(Session("agencode")) = "FUERTE" Or Trim(Session("agencode")) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

                '    str_menu_5 = "dbo.[SP_CIMACEX_RECUPERA_EPIS_KEY] '" & Session("episcode") & "'"

                '    objDS_5 = objCIMA.f_consulta_CSaludR(str_menu_5, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                '    ds_baja_citaRow_idermalia.Delete()
                '    ds_baja_citaRow_dermas.Delete()

                '    lds_baja_cita_idermalia.baja_cita.Clear()
                '    lds_baja_cita_dermas.baja_cita.Clear()

                '    ds_baja_citaRow_idermalia("epis_key_cima") = objDS_5.Tables(0).Rows(0).Item("epis_key")
                '    ds_baja_citaRow_dermas("epis_key_cima") = objDS_5.Tables(0).Rows(0).Item("epis_key")

                '    ds_baja_citaRow_idermalia("motivo") = "R"
                '    ds_baja_citaRow_dermas("motivo") = "R"

                '    lds_baja_cita_idermalia.baja_cita.Rows.Add(ds_baja_citaRow_idermalia)
                '    lds_baja_cita_dermas.baja_cita.Rows.Add(ds_baja_citaRow_dermas)

                '    lidermalia_ws.BajaCita("cima.ws", "Idermalia1", lds_baja_cita_idermalia)
                '    ldermas_ws.BajaCita("cima.ws", "Dermas10", lds_baja_cita_dermas)

                '    str_menu_6 = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & Session("pers_key") & ""

                '    objDS_6 = objCIMA.f_consulta_CSaludR(str_menu_6, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                '    contador = 0

                '    For Each objRow_2 In objDS_6.Tables(0).Rows

                '        contador = contador + 1

                '        If contador = 1 Then

                '            ds_cita_persRow_idermalia("pers_key") = CInt(Session("pers_key"))
                '            ds_cita_persRow_idermalia("persname") = objRow_2.Item("persname")
                '            ds_cita_persRow_idermalia("perssur1") = objRow_2.Item("perssur1")
                '            ds_cita_persRow_idermalia("perssur2") = objRow_2.Item("perssur2")
                '            ds_cita_persRow_idermalia("tsexcode") = objRow_2.Item("tsexcode")
                '            ds_cita_persRow_idermalia("persfullname") = objRow_2.Item("persfullname")
                '            ds_cita_persRow_idermalia("idenperscod1") = "1"
                '            ds_cita_persRow_idermalia("persidencod1") = objRow_2.Item("dni")
                '            ds_cita_persRow_idermalia("fecha_nacimiento") = objRow_2.Item("fecha_nacimiento")
                '            ds_cita_persRow_idermalia("movil") = objRow_2.Item("tel2")

                '            lds_alta_cita_idermalia.pers.Rows.Add(ds_cita_persRow_idermalia)

                '            ds_cita_persRow_dermas("pers_key") = CInt(Session("pers_key"))
                '            ds_cita_persRow_dermas("persname") = objRow_2.Item("persname")
                '            ds_cita_persRow_dermas("perssur1") = objRow_2.Item("perssur1")
                '            ds_cita_persRow_dermas("perssur2") = objRow_2.Item("perssur2")
                '            ds_cita_persRow_dermas("tsexcode") = objRow_2.Item("tsexcode")
                '            ds_cita_persRow_dermas("persfullname") = objRow_2.Item("persfullname")
                '            ds_cita_persRow_dermas("idenperscod1") = "1"
                '            ds_cita_persRow_dermas("persidencod1") = objRow_2.Item("dni")
                '            ds_cita_persRow_dermas("fecha_nacimiento") = objRow_2.Item("fecha_nacimiento")
                '            ds_cita_persRow_dermas("movil") = objRow_2.Item("tel2")

                '            lds_alta_cita_dermas.pers.Rows.Add(ds_cita_persRow_dermas)

                '        End If

                '    Next

                '    li_prestacion = 27

                '    Select Case Trim(Session("agencode"))
                '        Case "BOZA"
                '            ls_agencode_traspaso = "A.BOZA"
                '        Case "SOLE"
                '            ls_agencode_traspaso = "T.SOLE"
                '        Case "SOLER"
                '            ls_agencode_traspaso = "J.SOLER"
                '        Case "GUIL"
                '            ls_agencode_traspaso = "A.GUIL"
                '        Case "BODET"
                '            ls_agencode_traspaso = "D.BODE"
                '        Case "FUERTE"
                '            ls_agencode_traspaso = "I.FUER"
                '        Case "SEGURA"
                '            ls_agencode_traspaso = "J.SEGU"
                '    End Select

                '    ds_cita_citaRow_idermalia("id_centro") = 1
                '    ds_cita_citaRow_idermalia("agencode") = ls_agencode_traspaso
                '    ds_cita_citaRow_idermalia("id_prestacion") = li_prestacion
                '    ds_cita_citaRow_idermalia("dia") = CDate(Request("fecha_cita"))
                '    ds_cita_citaRow_idermalia("hora_ini") = CDate("01/01/1900 " & Request("hora_inicial"))
                '    ds_cita_citaRow_idermalia("hora_fin") = CDate("01/01/1900 " & Request("hora_final"))
                '    ds_cita_citaRow_idermalia("id_garante") = 19
                '    ds_cita_citaRow_idermalia("id_agen_franja") = 0
                '    ds_cita_citaRow_idermalia("pers_key") = CInt(Session("pers_key"))
                '    ds_cita_citaRow_idermalia("epis_key") = CInt(objDS_10.Tables(0).Rows(0).Item("epis_key"))

                '    lds_alta_cita_idermalia.cita.Rows.Add(ds_cita_citaRow_idermalia)

                '    ds_cita_citaRow_dermas("id_centro") = 1
                '    ds_cita_citaRow_dermas("agencode") = ls_agencode_traspaso
                '    ds_cita_citaRow_dermas("id_prestacion") = li_prestacion
                '    ds_cita_citaRow_dermas("dia") = CDate(Request("fecha_cita"))
                '    ds_cita_citaRow_dermas("hora_ini") = CDate("01/01/1900 " & Request("hora_inicial"))
                '    ds_cita_citaRow_dermas("hora_fin") = CDate("01/01/1900 " & Request("hora_final"))
                '    ds_cita_citaRow_dermas("id_garante") = 19
                '    ds_cita_citaRow_dermas("id_agen_franja") = 0
                '    ds_cita_citaRow_dermas("pers_key") = CInt(Session("pers_key"))
                '    ds_cita_citaRow_dermas("epis_key") = CInt(objDS_10.Tables(0).Rows(0).Item("epis_key"))

                '    lds_alta_cita_dermas.cita.Rows.Add(ds_cita_citaRow_dermas)

                '    lidermalia_ws.AltaCita("cima.ws", "Idermalia1", lds_alta_cita_idermalia)
                '    ldermas_ws.AltaCita("cima.ws", "Dermas10", lds_alta_cita_dermas)

                'End If

                ''' Fin de la conexión.

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Cita reprogramada con éxito.');" & vbCrLf)

                ' Corrección del agencode a char.

                str_cadena_naciente = Session("agencode")

                For n = Len(Session("agencode")) To 5
                    str_cadena_naciente = str_cadena_naciente + " "
                Next

                ' Fin Corrección del agencode a char.

                'CARLOS - MODIFICACION *******
                If Session("form") <> 1 Then
                    Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Request("fecha_cita") & "';")
                Else
                    Response.Write("opener.location.href='../formularios/form_pers.aspx?pers_key=" & Session("pers_key") & "';")
                End If
                'CARLOS - MODIFICACION *******
                'Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Request("fecha_cita") & "';")
                Response.Write("window.close();" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        End If

        If IsPostBack = False And Request("ok_cita") <> "S" Then

            Session("agencode") = Request("agencode")
            Session("dia_origen") = Session("dia_en_seleccion")
            'Session("dia_seleccionado") = objCIMA.f_formato_fecha(Session("dia_en_seleccion"))
            Session("pers_key") = Request("pers_key")
            Session("episcode") = Request("episcode")
            Session("servicio_seleccionado") = Request("servicio_seleccionado")

            'Session("dia_calendario") = Session("dia_en_seleccion") 'Session("dia_seleccionado")
            Session("dia_calendario") = Session("dia_seleccionado")

            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT persfullname as nombre_paciente FROM pers WHERE pers_key = " & Session("pers_key")

            Me.OdbcDataAdapter6.SelectCommand.Parameters(1).Value = Session("episcode")

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter1.Fill(Me.Ds_nombre_paciente1.paciente)
            Me.OdbcDataAdapter6.Fill(Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA)

            Me.OdbcConnection1.Close()

            Session("nombre_paciente") = Me.Ds_nombre_paciente1.paciente.Rows(0).Item(0)

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("agencode")
            Me.SqlDataAdapter1.Fill(Me.Ds_agen_agenname1.agen)

            Me.SqlConnection1.Close()

            Me.Label1.DataBind()

            Me.Label2.Text = Session("dia_seleccionado")
            Me.fecha_ini.Text = DatePart(DateInterval.Day, Session("dia_seleccionado")) & "/" & DatePart(DateInterval.Month, Session("dia_seleccionado")) & "/" & DatePart(DateInterval.Year, Session("dia_seleccionado"))

            Select Case Weekday(Session("dia_calendario")) 'Weekday(Request("dia_seleccionado"))
                Case 1
                    Session("cadena_semana") = "D"
                Case 2
                    Session("cadena_semana") = "L"
                Case 3
                    Session("cadena_semana") = "M"
                Case 4
                    Session("cadena_semana") = "X"
                Case 5
                    Session("cadena_semana") = "J"
                Case 6
                    Session("cadena_semana") = "V"
                Case 7
                    Session("cadena_semana") = "S"
            End Select

            'Session("time_ini") = Request("DropDownList3")
            'Session("time_fin") = Request("TextBox1")

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT * FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0"

            Me.OdbcDataAdapter1.Fill(Me.Ds_btimetab1.btimetab)

            Me.OdbcConnection1.Close()

            Me.DropDownList1.DataBind()

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

            Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
            "FROM cstahper INNER JOIN " & _
            "pers ON cstahper.pers_key = pers.pers_key " & _
            "INNER JOIN resoagen ON resoagen.reso_key = cstahper.csta_key " & _
            "WHERE resoagen.agencode = '" & Trim(Session("agencode")) & "' AND cstahperacti = 'Y' " & _
            " " & _
            "UNION " & _
            "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
            "FROM cstahper INNER JOIN " & _
            "pers ON cstahper.pers_key = pers.pers_key WHERE cstahperacti = 'Y' AND pers.pers_key in (22211,34686) ORDER BY pers.persfullname"

            Me.Ds_medicos1.Clear()

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter3.Fill(Me.Ds_medicos1.medicos)

            Me.OdbcConnection1.Close()

            Me.DropDownList4.DataBind()

            Me.DropDownList4.Items.Add("")

            Me.Label3.Text = Session("nombre_paciente")

            fecha_visible = Session("dia_calendario")

            Me.Calendar1.VisibleDate = fecha_visible
            Me.Calendar1.SelectedDate = fecha_visible

            Me.Calendar2.SelectedDate = Me.Calendar1.SelectedDate
            Me.Calendar2.VisibleDate = Me.Calendar1.VisibleDate

            Me.OdbcConnection1.Open()

            'Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT ltrim(rtrim(hpro.hprodesclong)) + ' - ' + cast(proctita.proctitadura as varchar) + ' min' as 'Descripción', cast(proctita.proctitadura as varchar) + '/' + cast(hpro.hpro_key as varchar) as 'Tiempo' " & _
            '"FROM hpro, proctita, btimetab " & _
            '"WHERE ( proctita.hpro_key = hpro.hpro_key ) and " & _
            '"( btimetab.btimetabcode = proctita.btimetabcode ) and ( proctita.agencode = btimetab.agencode ) and " & _
            '"( ( proctita.agencode = '" & Session("agencode") & "' ) AND  " & _
            '"( hpro.hproacti = 'Y' ) AND  " & _
            '"( proctita.proctitaacti = 'Y' ) ) AND  btimetab.btimetabacti = 'Y' " & _
            '"AND '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end " & _
            '"AND CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 " & _
            '"ORDER BY hpro.hprodesclong"

            Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitadura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) + '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclong " & _
            " FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN " & _
            " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode = btimetab.agencode LEFT OUTER JOIN " & _
            " prod ON hpro.hprocode = prod.prodcode " & _
            " WHERE (proctita.agencode = '" & Session("agencode") & "') AND (hpro.hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')"

            Me.OdbcDataAdapter2.Fill(Me.Ds_prestaciones1.prestaciones)

            Me.OdbcConnection1.Close()

            Me.DropDownList2.DataBind()



            For n = 0 To Me.DropDownList2.Items.Count - 1
                If Me.DropDownList2.Items(n).Value = Request("DropDownList2") Then
                    Me.DropDownList2.SelectedValue = Request("DropDownList2")
                End If
            Next

            Me.Ds_franja_horaria1.Clear()

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT DATEPART (hh,btimetabhourinit) as hora_inicio, DATEPART (mi,btimetabhourinit) as minuto_inicio,DATEPART (hh,btimetabhour_end) as hora_fin,DATEPART (mi,btimetabhour_end) as minuto_fin, btimetabgran FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and btimetabcode = " & Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(1) & " and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 "

            Me.OdbcDataAdapter1.Fill(Me.Ds_franja_horaria1.franja_horaria)

            If Me.Ds_franja_horaria1.franja_horaria.Count > 0 Then
                montar_desplegable(Me.Ds_franja_horaria1.franja_horaria.Rows(0))
            End If

            Me.OdbcConnection1.Close()

            'Me.TextBox1.Text = ""

            If Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(0) > 0 Then
                Me.DropDownList4.SelectedValue = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(0)
            Else
                Me.DropDownList4.SelectedValue = ""
            End If

            Me.DropDownList1.SelectedValue = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(1)
            'Me.DropDownList3.SelectedValue = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(2)
            'Me.TextBox1.Text = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(3)
            Me.DropDownList2.SelectedValue = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(5)

            Session("prestacion") = Me.Ds_carga_mod_cita1.SP_CIMACEX_CARGA_MOD_CITA.Rows(0).Item(5)

        Else

            'Me.DropDownList1.SelectedValue = Request("DropDownList1")
            'actualizar()

        End If

        If Session("servicio_seleccionado") = "RX" Then

            'Me.DropDownList2.Enabled = False

            Me.DropDownList8.Items.Clear()

            'If Me.DropDownList1.SelectedValue = "2" Then

            Session("entidad_pago") = "ICIMA"

            If Session("garante") = "MUPRESPA" Then

                Session("entidad_pago") = "LFRA"

            End If

            If Session("garante") = "MIDA" Then

                Session("entidad_pago") = "MMCY"

            End If

            If Session("garante") = "EGARSAT" Then

                Session("entidad_pago") = "EGAR"

            End If

            If Session("garante") = "HES" Then

                Session("entidad_pago") = "HESSC"

            End If

            'Me.DropDownList8.Items.Clear()

            'Me.DropDownList8.Items.Add(New ListItem("CUALQUIERA", "Q"))
            'Me.DropDownList8.Items.Add(New ListItem("MAÑANA", "M"))
            'Me.DropDownList8.Items.Add(New ListItem("MEDIODIA", "G"))
            'Me.DropDownList8.Items.Add(New ListItem("TARDE", "T"))
            'Me.DropDownList8.Items.Add(New ListItem("NOCHE", "N"))

            'If Request("DropDownList8") = ("Q") Or Request("DropDownList8") = ("M") Or Request("DropDownList8") = ("G") Or Request("DropDownList8") = ("T") Or Request("DropDownList8") = ("N") Then

            'Me.DropDownList8.SelectedValue = Request("DropDownList8")

            'End If

            Me.DropDownList8.Items.Clear()

            Me.DropDownList8.Items.Add(New ListItem("-- PRIMER HUECO --", "00:00"))
            Me.DropDownList8.Items.Add(New ListItem("07:00 - 08:00", "07:00"))
            Me.DropDownList8.Items.Add(New ListItem("08:00 - 09:00", "08:00"))
            Me.DropDownList8.Items.Add(New ListItem("09:00 - 10:00", "09:00"))
            Me.DropDownList8.Items.Add(New ListItem("10:00 - 11:00", "10:00"))
            Me.DropDownList8.Items.Add(New ListItem("11:00 - 12:00", "11:00"))
            Me.DropDownList8.Items.Add(New ListItem("12:00 - 13:00", "12:00"))
            Me.DropDownList8.Items.Add(New ListItem("13:00 - 14:00", "13:00"))
            Me.DropDownList8.Items.Add(New ListItem("14:00 - 15:00", "14:00"))
            Me.DropDownList8.Items.Add(New ListItem("15:00 - 16:00", "15:00"))
            Me.DropDownList8.Items.Add(New ListItem("16:00 - 17:00", "16:00"))
            Me.DropDownList8.Items.Add(New ListItem("17:00 - 18:00", "17:00"))
            Me.DropDownList8.Items.Add(New ListItem("18:00 - 19:00", "18:00"))
            Me.DropDownList8.Items.Add(New ListItem("19:00 - 20:00", "19:00"))
            Me.DropDownList8.Items.Add(New ListItem("20:00 - 21:00", "20:00"))

            If Request("DropDownList8") <> ("Q") And Request("DropDownList8") <> ("M") And Request("DropDownList8") <> ("G") And Request("DropDownList8") <> ("T") And Request("DropDownList8") <> ("N") And Len(Trim(Request("DropDownList8"))) > 0 Then

                'If Len(Trim(Request("DropDownList8"))) > 0 Then

                Me.DropDownList8.SelectedValue = Request("DropDownList8")

                'Else

                'Me.DropDownList8.SelectedValue = "00:00"

                'End If

                'End If

            End If

        Else

            Me.DropDownList8.Items.Clear()

            Me.DropDownList8.Items.Add(New ListItem("08:00", "08:00"))
            Me.DropDownList8.Items.Add(New ListItem("09:00", "09:00"))
            Me.DropDownList8.Items.Add(New ListItem("10:00", "10:00"))
            Me.DropDownList8.Items.Add(New ListItem("11:00", "11:00"))
            Me.DropDownList8.Items.Add(New ListItem("12:00", "12:00"))
            Me.DropDownList8.Items.Add(New ListItem("13:00", "13:00"))
            Me.DropDownList8.Items.Add(New ListItem("14:00", "14:00"))
            Me.DropDownList8.Items.Add(New ListItem("15:00", "15:00"))
            Me.DropDownList8.Items.Add(New ListItem("16:00", "16:00"))
            Me.DropDownList8.Items.Add(New ListItem("17:00", "17:00"))
            Me.DropDownList8.Items.Add(New ListItem("18:00", "18:00"))
            Me.DropDownList8.Items.Add(New ListItem("19:00", "19:00"))
            Me.DropDownList8.Items.Add(New ListItem("20:00", "20:00"))

            If Request("DropDownList8") <> ("Q") And Request("DropDownList8") <> ("M") And Request("DropDownList8") <> ("G") And Request("DropDownList8") <> ("T") And Request("DropDownList8") <> ("N") And Len(Trim(Request("DropDownList8"))) > 0 Then

                Me.DropDownList8.SelectedValue = Request("DropDownList8")

            End If

        End If

        Me.Calendar2.SelectedDate = Me.Calendar1.SelectedDate

        ib_control = False

    End Sub

    Public Sub actualizar()

        Dim n As Integer

        Dim fecha_visible As String

        Me.Ds_prestaciones1.Clear()

        Select Case Weekday(Me.Calendar1.SelectedDate) 'Weekday(Session("dia_calendario")) 'Weekday(Request("dia_seleccionado"))
            Case 1
                Session("cadena_semana") = "D"
            Case 2
                Session("cadena_semana") = "L"
            Case 3
                Session("cadena_semana") = "M"
            Case 4
                Session("cadena_semana") = "X"
            Case 5
                Session("cadena_semana") = "J"
            Case 6
                Session("cadena_semana") = "V"
            Case 7
                Session("cadena_semana") = "S"
        End Select

        'End If

        'Session("time_ini") = Request("DropDownList3")
        'Session("time_fin") = Request("TextBox1")

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT * FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Request("Calendar1") & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0"

        Me.OdbcDataAdapter1.Fill(Me.Ds_btimetab1.btimetab)

        Me.OdbcConnection1.Close()

        Me.DropDownList1.DataBind()

        'Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
        '   "FROM cstahper INNER JOIN " & _
        '    "pers ON cstahper.pers_key = pers.pers_key INNER JOIN " & _
        '    "agen ON agen.csta_key = cstahper.csta_key " & _
        '    "WHERE     agencode = '" & Trim(Session("agencode")) & "' AND cstahperacti = 'Y' " & _
        '    " " & _
        '    "UNION " & _
        '    "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
        '    "FROM cstahper INNER JOIN " & _
        '    "pers ON cstahper.pers_key = pers.pers_key WHERE cstahperacti = 'Y' AND pers.pers_key IN (22211,34686) ORDER BY pers.persfullname"

        Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
                    "FROM cstahper INNER JOIN " & _
                    "pers ON cstahper.pers_key = pers.pers_key " & _
                    "INNER JOIN resoagen ON resoagen.reso_key = cstahper.csta_key " & _
                    "WHERE resoagen.agencode = '" & Trim(Session("agencode")) & "' AND cstahperacti = 'Y' " & _
                    " " & _
                    "UNION " & _
                    "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
                    "FROM cstahper INNER JOIN " & _
                    "pers ON cstahper.pers_key = pers.pers_key WHERE cstahperacti = 'Y' AND pers.pers_key in (22211,34686) ORDER BY pers.persfullname"

        Me.Ds_medicos1.Clear()

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter3.Fill(Me.Ds_medicos1.medicos)

        Me.OdbcConnection1.Close()

        Me.DropDownList4.DataBind()

        Me.DropDownList4.Items.Add("")

        If Len(Trim(Request("DropDownList4"))) > 0 Then
            Me.DropDownList4.SelectedValue = Request("DropDownList4")
        Else
            Me.DropDownList4.SelectedValue = ""
        End If

        Me.Label3.Text = Session("nombre_paciente")

        fecha_visible = Session("dia_calendario")

        Me.Calendar1.VisibleDate = Me.Calendar1.SelectedDate 'fecha_visible
        Me.Calendar1.SelectedDate = Me.Calendar1.SelectedDate

        Me.Calendar2.VisibleDate = Me.Calendar1.SelectedDate
        Me.Calendar2.SelectedDate = Me.Calendar1.SelectedDate

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT ltrim(rtrim(hpro.hprodesclong)) + ' - ' + cast(proctita.proctitadura as varchar) + ' min' as 'Descripción', cast(proctita.proctitadura as varchar) + '/' + cast(hpro.hpro_key as varchar) as 'Tiempo' " & _
        '"FROM hpro, proctita, btimetab " & _
        '"WHERE ( proctita.hpro_key = hpro.hpro_key ) and " & _
        '"( btimetab.btimetabcode = proctita.btimetabcode ) and ( proctita.agencode = btimetab.agencode ) and " & _
        '"( ( proctita.agencode = '" & Session("agencode") & "' ) AND  " & _
        '"( hpro.hproacti = 'Y' ) AND  " & _
        '"( proctita.proctitaacti = 'Y' ) ) AND  btimetab.btimetabacti = 'Y' " & _
        '"AND '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end " & _
        '"AND CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 " & _
        '"ORDER BY hpro.hprodesclong"

        Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitadura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) + '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclong " & _
            " FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN " & _
            " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode = btimetab.agencode LEFT OUTER JOIN " & _
            " prod ON hpro.hprocode = prod.prodcode " & _
            " WHERE (proctita.agencode = '" & Session("agencode") & "') AND (hpro.hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')"

        Me.OdbcDataAdapter2.Fill(Me.Ds_prestaciones1.prestaciones)

        Me.OdbcConnection1.Close()

        Me.DropDownList2.DataBind()

        For n = 0 To Me.DropDownList2.Items.Count - 1
            If Me.DropDownList2.Items(n).Value = Request("DropDownList2") Then
                Me.DropDownList2.SelectedValue = Request("DropDownList2")
                'ElseIf Me.DropDownList2.Items(n).Value = Me.DropDownList2.SelectedValue Then
                'Me.DropDownList2.SelectedValue = Me.DropDownList2.SelectedValue
            End If
        Next

        'JGM 22/02/2011
        'Si estamos en radiologia, no modificamos la prestación
        If Session("servicio_seleccionado") = "RX" Then
            Me.DropDownList2.SelectedValue = Session("prestacion")
        End If

        Me.Ds_franja_horaria1.Clear()

        For n = 0 To Me.DropDownList1.Items.Count - 1
            If Me.DropDownList1.Items(n).Value = Request("DropDownList1") Then
                Me.DropDownList1.SelectedValue = Request("DropDownList1")
                'ElseIf Me.DropDownList1.Items(n).Value = Me.DropDownList1.SelectedValue Then
                'Me.DropDownList1.SelectedValue = Me.DropDownList1.SelectedValue
            End If
        Next

        Me.OdbcConnection1.Open()


        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT DATEPART (hh,btimetabhourinit) as hora_inicio, DATEPART (mi,btimetabhourinit) as minuto_inicio,DATEPART (hh,btimetabhour_end) as hora_fin,DATEPART (mi,btimetabhour_end) as minuto_fin, btimetabgran FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 and btimetabcode = " & Me.DropDownList1.SelectedValue.ToString

        'JGM -02.10.2008 -- Si no hi ha cap bloc horari, no omplim la franja
        If Me.DropDownList1.SelectedValue.ToString <> "" Then
            Me.OdbcDataAdapter1.Fill(Me.Ds_franja_horaria1.franja_horaria)
        End If

        If Me.Ds_franja_horaria1.franja_horaria.Count > 0 Then
            montar_desplegable(Me.Ds_franja_horaria1.franja_horaria.Rows(0))
        End If

        Me.OdbcConnection1.Close()

        'Me.TextBox1.Text = ""

    End Sub

    Public Sub montar_desplegable(ByVal objRow As ds_franja_horaria.franja_horariaRow)

        Dim li_hora, li_minuto As Integer
        Dim li_gran As Integer

        Dim li_hora_ini, li_hora_fin As Integer

        Dim lb_primera As Boolean

        'li_gran = objRow.Item(4)

        li_hora = objRow.Item(0)
        li_minuto = objRow.Item(1)

        lb_primera = True

        li_hora_ini = li_hora * 60 + li_minuto
        li_hora_fin = objRow.Item(2) * 60 + objRow.Item(3)

        'Me.DropDownList3.Items.Clear()

        While li_hora_ini <= li_hora_fin

            If lb_primera = False Then
                'Me.DropDownList3.Items.Add(formatear_minutos(CStr(li_hora)) & ":" & formatear_minutos(CStr(li_minuto)))
                li_minuto = li_minuto + 5
            Else
                'Me.DropDownList3.Items.Add("")
            End If

            If li_minuto >= 60 And lb_primera = False Then
                li_hora = li_hora + 1
                li_minuto = 0
            End If

            lb_primera = False

            li_hora_ini = li_hora * 60 + li_minuto

        End While

    End Sub

    Public Function formatear_minutos(ByVal str_minuto As String) As String

        Dim str_mi As String

        If Len(Trim(str_minuto)) = 1 Then
            str_mi = "0" & Trim(str_minuto)
        Else
            str_mi = Trim(str_minuto)
        End If

        formatear_minutos = str_mi

    End Function

    'Private Sub DropDownList3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'Dim ls_array(), ls_array2() As String

    'Dim li_hora, li_minuto, li_total As Integer

    'refresco()



    'Me.DropDownList3.SelectedValue = Request("DropDownList3")

    'Me.DropDownList2.SelectedValue = Request("DropDownList2")

    'ls_array = Split(Me.DropDownList3.SelectedValue.ToString, ":", , CompareMethod.Text)

    'li_hora = CInt(ls_array(0)) * 60
    'li_minuto = CInt(ls_array(1))

    'ls_array2 = Split(Me.DropDownList2.SelectedValue.ToString, "/", , CompareMethod.Text)

    'li_total = li_hora + li_minuto + CInt(ls_array2(0))



    'Session("time_fin") = CStr(Int(li_total / 60)) & ":" & formatear_minutos(CStr(li_total Mod 60))

    'End Sub

    Private Sub DropDownList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged

        If Session("control_cambio_prestacion") = "N" Then

            Me.DropDownList2.SelectedValue = Request("DropDownList2")

            refresco()

        Else

            Me.DropDownList2.SelectedValue = Session("prestacion")

        End If



        'Me.Button1.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ls_hora_inicial, ls_hora_final As String

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim lb_no_ok As Boolean

        Dim ls_duracion() As String

        Dim n As Integer
        Dim str_cadena_naciente As String

        Dim li_medico As Integer

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String



        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        ' Controles.

        'If CDate(Session("dia_origen")) < Today() Then

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("alert('Lo sentimos, el día seleccionado es anterior al actual.');" & vbCrLf)
        'Response.Write("</scr" & "ipt>")

        'Else

        refresco()

        If Len(Trim(Session("time_ini"))) > 0 And Len(Trim(Session("time_fin"))) > 0 Then

            ls_hora_inicial = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1))
            ls_hora_final = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3))

            ' Si se encuentra el time_ini o el time_fin en el intervalo o por encima de él, error.

            If presencia_intervalo(ls_hora_inicial, ls_hora_final, Trim(Session("time_ini"))) = False Or presencia_intervalo(ls_hora_inicial, ls_hora_final, Trim(Session("time_fin"))) = False Then

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                str_menu = "dbo.SP_CIMACEX_CITAS_DIA_TODAS_PENDIENTES '" & Session("dia_seleccionado") & "','" & Session("agencode") & "'" ','" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) & ":" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1) & ":00','" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) & ":" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3) & ":00'"

                'response.write (str_menu)

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                lb_no_ok = False

                For Each objRow In objDS.Tables(0).Rows

                    If (presencia_intervalo(objRow.Item(2), objRow.Item(24), Trim(Session("time_ini"))) = True And objRow.Item(24) <> (Trim(Session("time_ini")) & ":00")) Or (presencia_intervalo(objRow.Item(2), objRow.Item(24), Trim(Session("time_fin"))) = True And objRow.Item(2) <> (Trim(Session("time_fin")) & ":00")) Or intervalo_contenido(objRow.Item(2), objRow.Item(24), Trim(Session("time_ini")), Trim(Session("time_fin"))) = True Then

                        lb_no_ok = True

                    End If

                Next

                ' Comprobación pertenencia a intervalos de bloqueo.

                str_menu = "[dbo].[SP_CIMACEX_BLOQUEOS] '" & Session("dia_seleccionado") & "','" & Session("agencode") & "'," & Me.DropDownList1.SelectedValue

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                'lb_no_ok = False

                If lb_no_ok = False Then

                    For Each objRow In objDS.Tables(0).Rows

                        If (presencia_intervalo(objRow.Item(0), objRow.Item(1), Trim(Session("time_ini"))) = True And objRow.Item(1) <> (Trim(Session("time_ini")) & ":00")) Or (presencia_intervalo(objRow.Item(0), objRow.Item(1), Trim(Session("time_fin"))) = True And objRow.Item(0) <> (Trim(Session("time_fin")) & ":00")) Or intervalo_contenido(objRow.Item(0), objRow.Item(1), Trim(Session("time_ini")), Trim(Session("time_fin"))) = True Then

                            lb_no_ok = True

                        End If

                    Next

                End If

                ' Fin de comprobación.

                If lb_no_ok Then

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                Else

                    ' OK!!!

                    ls_duracion = Split(Me.DropDownList2.SelectedValue.ToString, "/", , CompareMethod.Text)

                    If Len(Trim(Me.DropDownList4.SelectedValue)) > 0 Then

                        If Me.DropDownList4.SelectedValue > 0 Then
                            li_medico = Me.DropDownList4.SelectedValue
                        Else
                            li_medico = 0
                        End If

                    Else

                        li_medico = 0

                    End If

                    str_menu = "[dbo].[SP_CIMACEX_MOD_CITA] '" & Session("episcode") & "','" & Session("dia_seleccionado") & "','" & Session("agencode") & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.DropDownList1.SelectedValue.ToString & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico & ",'" & str_uid & "'"

                    'response.write (str_menu)

                    ''''''''''''''''''''''''''''''''''''''''''

                    Dim objConn As New Odbc.OdbcConnection

                    Dim objCommand As New Odbc.OdbcCommand



                    objConn.ConnectionString = "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

                    objConn.ConnectionTimeout = 200
                    objCommand.Connection = objConn

                    objConn.Open()

                    objCommand.CommandType = CommandType.StoredProcedure
                    objCommand.CommandText = str_menu

                    'objDA.SelectCommand.CommandType = CommandType.StoredProcedure ' CommandType.Text '.StoredProcedure
                    'objDA.SelectCommand.CommandText = "EXEC " & str_menu
                    'objDA.SelectCommand.CommandText = str_menu

                    'objDA.SelectCommand.Connection.ConnectionTimeout = 200

                    'objDA.SelectCommand.Connection.Open()

                    objCommand.ExecuteNonQuery()

                    'objDA.Fill(objDS)

                    objConn.Close()

                    'objDA = Nothing
                    objConn = Nothing

                    objCommand = Nothing

                    'f_consulta_CSaludR = objDS

                    ''''''''''''''''''''''''''''''''''''''''''

                    'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Cita reprogramada con éxito.');" & vbCrLf)

                    ' Corrección del agencode a char.

                    str_cadena_naciente = Session("agencode")

                    For n = Len(Session("agencode")) To 5
                        str_cadena_naciente = str_cadena_naciente + " "
                    Next

                    ' Fin Corrección del agencode a char.

                    'CARLOS - MODIFICACION *****
                    If Session("form") <> 1 Then
                        Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Session("dia_seleccionado") & "';")
                    Else
                        Response.Write("opener.location.href='../formularios/form_pers.aspx?pers_key=" & Session("pers_key") & "';")
                    End If
                    'CARLOS - MODIFICACION *****
                    'Response.Write("opener.location.href='../formularios/form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Session("dia_seleccionado") & "';")
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                End If

            End If

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        'End If

    End Sub

    Public Function presencia_intervalo(ByVal str_time_ini As String, ByVal str_time_fin As String, ByVal str_hora As String) As Boolean

        Dim ls_array(), ls_array2(), ls_array3() As String

        Dim li_time_ini, li_time_fin, li_hora As Integer

        ls_array = Split(str_time_ini, ":", , CompareMethod.Text)

        li_time_ini = CInt(ls_array(0)) * 60 + CInt(ls_array(1))

        ls_array2 = Split(str_time_fin, ":", , CompareMethod.Text)

        li_time_fin = CInt(ls_array2(0)) * 60 + CInt(ls_array2(1))

        ls_array3 = Split(str_hora, ":", , CompareMethod.Text)

        li_hora = CInt(ls_array3(0)) * 60 + CInt(ls_array3(1))

        If li_hora >= li_time_ini And li_hora <= li_time_fin Then
            presencia_intervalo = True
        Else
            presencia_intervalo = False
        End If

    End Function

    Public Function intervalo_contenido(ByVal str_time_ini As String, ByVal str_time_fin As String, ByVal str_hora_ini As String, ByVal str_hora_fin As String) As Boolean

        Dim ls_array(), ls_array2(), ls_array3(), ls_array4() As String

        Dim li_time_ini, li_time_fin, li_hora_ini, li_hora_fin As Integer

        ls_array = Split(str_time_ini, ":", , CompareMethod.Text)

        li_time_ini = CInt(ls_array(0)) * 60 + CInt(ls_array(1))

        ls_array2 = Split(str_time_fin, ":", , CompareMethod.Text)

        li_time_fin = CInt(ls_array2(0)) * 60 + CInt(ls_array2(1))

        ls_array3 = Split(str_hora_ini, ":", , CompareMethod.Text)

        li_hora_ini = CInt(ls_array3(0)) * 60 + CInt(ls_array3(1))

        ls_array4 = Split(str_hora_fin, ":", , CompareMethod.Text)

        li_hora_fin = CInt(ls_array4(0)) * 60 + CInt(ls_array4(1))

        If li_hora_ini <= li_time_ini And li_hora_fin >= li_time_fin Then
            intervalo_contenido = True
        Else
            intervalo_contenido = False
        End If

    End Function

    ' Fin Controles.

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;")
        Response.Write("</scr" & "ipt>" & vbCrLf)

    End Sub


    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        Dim objCIMA As New CIMA_Clases.CIMA

        'Session("agencode") = Request("agencode")
        Session("dia_origen") = Me.Calendar1.SelectedDate 'Session("dia_en_seleccion")
        Session("dia_seleccionado") = objCIMA.f_formato_fecha(Session("dia_origen"))
        'Session("pers_key") = Request("pers_key")

        Me.fecha_ini.Text = Me.Calendar1.SelectedDate

        Session("dia_calendario") = Session("dia_en_seleccion") 'Session("dia_seleccionado")

        Select Case Weekday(Me.Calendar1.SelectedDate) 'Weekday(Request("dia_seleccionado"))
            Case 1
                Session("cadena_semana") = "D"
            Case 2
                Session("cadena_semana") = "L"
            Case 3
                Session("cadena_semana") = "M"
            Case 4
                Session("cadena_semana") = "X"
            Case 5
                Session("cadena_semana") = "J"
            Case 6
                Session("cadena_semana") = "V"
            Case 7
                Session("cadena_semana") = "S"
        End Select

        Me.Calendar2.SelectedDate = Nothing

        refresco()

        'Me.Button1.Enabled = True

    End Sub

    Public Sub refresco()

        'Session("time_ini") = Request("DropDownList3")
        'Session("time_fin") = Request("TextBox1")

        Me.Ds_agen_agenname1.Clear()
        Me.Ds_btimetab1.Clear()
        Me.Ds_medicos1.Clear()

        Me.DropDownList1.Items.Clear()
        Me.DropDownList2.Items.Clear()


        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("agencode")
        Me.SqlDataAdapter1.Fill(Me.Ds_agen_agenname1.agen)

        Me.SqlConnection1.Close()

        Me.Label1.DataBind()

        Me.Label2.Text = Session("dia_seleccionado")
        Me.fecha_ini.Text = DatePart(DateInterval.Day, Session("dia_seleccionado")) & "/" & DatePart(DateInterval.Month, Session("dia_seleccionado")) & "/" & DatePart(DateInterval.Year, Session("dia_seleccionado")) 'Session("dia_seleccionado")

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT * FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0"

        Me.OdbcDataAdapter1.Fill(Me.Ds_btimetab1.btimetab)

        Me.OdbcConnection1.Close()

        Me.DropDownList1.DataBind()

        'Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
        '    "FROM cstahper INNER JOIN " & _
        '    "pers ON cstahper.pers_key = pers.pers_key INNER JOIN " & _
        '    "agen ON agen.csta_key = cstahper.csta_key " & _
        '    "WHERE     agencode = '" & Trim(Session("agencode")) & "' AND cstahperacti = 'Y' " & _
        '    " " & _
        '    "UNION " & _
        '    "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
        '    "FROM cstahper INNER JOIN " & _
        '    "pers ON cstahper.pers_key = pers.pers_key WHERE cstahperacti = 'Y' AND pers.pers_key in (22211,34686) ORDER BY pers.persfullname"

        Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
                            "FROM cstahper INNER JOIN " & _
                            "pers ON cstahper.pers_key = pers.pers_key " & _
                            "INNER JOIN resoagen ON resoagen.reso_key = cstahper.csta_key " & _
                            "WHERE resoagen.agencode = '" & Trim(Session("agencode")) & "' AND cstahperacti = 'Y' " & _
                            " " & _
                            "UNION " & _
                            "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key " & _
                            "FROM cstahper INNER JOIN " & _
                            "pers ON cstahper.pers_key = pers.pers_key WHERE cstahperacti = 'Y' AND pers.pers_key in (22211,34686) ORDER BY pers.persfullname"

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter3.Fill(Me.Ds_medicos1.medicos)

        Me.OdbcConnection1.Close()

        Me.DropDownList4.DataBind()

        'Me.DropDownList4.SelectedValue = Request("DropDownList4")

        'If IsPostBack = False Then

        actualizar()

        'Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'If Request("persona_ok") = "S" Then

        Me.Label3.Text = Session("nombre_paciente") 'Request("persona")

        'Session("pers_key") = Request("pers_key")

        'End If

        'fecha_visible = Session("dia_calendario")

        'Me.Calendar1.VisibleDate = fecha_visible
        'Me.Calendar1.SelectedDate = fecha_visible

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        refresco()

        'Me.Button1.Enabled = True

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged

        Me.Calendar1.SelectedDate = Nothing

        'Me.Button1.Enabled = True

    End Sub
    Private Sub Calendar1_VisibleMonthChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MonthChangedEventArgs) Handles Calendar1.VisibleMonthChanged

        Me.Calendar2.VisibleDate = e.NewDate

    End Sub

    Private Sub Calendar2_VisibleMonthChanged(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MonthChangedEventArgs) Handles Calendar2.VisibleMonthChanged

        Me.Calendar1.VisibleDate = e.NewDate

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
                        Case "C"
                            e.Cell.BackColor = e.Cell.BackColor.Red
                    End Select

                    'e.Cell.BackColor = e.Cell.BackColor.GreenYellow
                    'e.Cell.Text = CStr(Me.Ds_dias3.dias.Rows(n).Item(1))
                    'e.Cell.ToolTip = "Citas= " + CStr(Me.Ds_dias2.dias.Rows(n).Item(1))

                End If

                'Me.Calendar1.SelectedDates.Add(CDate(Me.Ds_dias1.dias.Rows(n).Item(0)))

            Next

        End If

    End Sub

    Private Sub f_marcar()

        Dim ls_fecha As String
        Dim li_contador As Long
        Dim n As Long

        Me.Ds_dias1.dias.Clear()
        Me.Ds_dias2.dias.Clear()

        ' Calendario 1.

        'Me.Calendar1.SelectedDate = Nothing

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter4.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
        '"FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  INNER  JOIN agenproc ON bookproc.agenproc_key=agenproc.agenproc_key INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
        '"WHERE bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar1.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar1.VisibleDate.Year & " AND book.agencode = '" & Session("agencode") & "' " & _
        '"GROUP BY book.diardate"

        Me.OdbcDataAdapter4.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
        "FROM book INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN appo ON appo.book_key=book.book_key INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode INNER  JOIN epis ON appo.epis_key=epis.epis_key INNER  JOIN pers perspati ON appo.pers_keypati=perspati.pers_key INNER  JOIN pati ON appo.pers_keypati=pati.pers_key INNER  JOIN csta ON appo.csta_keymake=csta.csta_key LEFT  JOIN cstahper ON appo.cstahper_keymake=cstahper.cstahper_key LEFT  JOIN pers persmedi ON cstahper.pers_key=persmedi.pers_key LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode LEFT  JOIN appofail ON appo.appofailcode=appofail.appofailcode " & _
        "INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
        "INNER  JOIN CSaludR.dbo.hpro ON bookproc.hpro_key=CSaludR.dbo.hpro.hpro_key  " & _
        "LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y'  " & _
        "WHERE appostat.appostatcode <> 'A' AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar1.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar1.VisibleDate.Year & " AND book.agencode = '" & Session("agencode") & "'  " & _
        "GROUP BY book.diardate"

        Me.OdbcDataAdapter4.Fill(Me.Ds_dias1.dias)

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

        'Me.OdbcDataAdapter5.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
        '"FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  INNER  JOIN agenproc ON bookproc.agenproc_key=agenproc.agenproc_key INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key " & _
        '"WHERE bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND book.agencode = '" & Session("agencode") & "' " & _
        '"GROUP BY book.diardate"

        Me.OdbcDataAdapter5.SelectCommand.CommandText = "SELECT book.diardate as dia, count(book.diardate) as numero " & _
        "FROM book INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN appo ON appo.book_key=book.book_key INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode INNER  JOIN epis ON appo.epis_key=epis.epis_key INNER  JOIN pers perspati ON appo.pers_keypati=perspati.pers_key INNER  JOIN pati ON appo.pers_keypati=pati.pers_key INNER  JOIN csta ON appo.csta_keymake=csta.csta_key LEFT  JOIN cstahper ON appo.cstahper_keymake=cstahper.cstahper_key LEFT  JOIN pers persmedi ON cstahper.pers_key=persmedi.pers_key LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode LEFT  JOIN appofail ON appo.appofailcode=appofail.appofailcode " & _
        "INNER  JOIN bookproc ON bookproc.book_key=book.book_key  " & _
        "INNER  JOIN CSaludR.dbo.hpro ON bookproc.hpro_key=CSaludR.dbo.hpro.hpro_key  " & _
        "LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y'  " & _
        "WHERE appostat.appostatcode <> 'A' AND bookproc.bookprocorde = 1 AND month(book.diardate) = " & Me.Calendar2.VisibleDate.Month & " AND year(book.diardate) = " & Me.Calendar2.VisibleDate.Year & " AND book.agencode = '" & Session("agencode") & "'  " & _
        "GROUP BY book.diardate"

        Me.OdbcDataAdapter5.Fill(Me.Ds_dias2.dias)

        li_contador = Me.Ds_dias2.dias.Rows.Count

        If li_contador > 0 Then
            For n = 0 To li_contador - 1
                'Me.Calendar2.SelectedDates.Add(CDate(Me.Ds_dias2.dias.Rows(n).Item(0)))
            Next
        End If

        Me.OdbcConnection1.Close()

        '

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter4.SelectCommand.CommandText = "SELECT diar.diardate AS dia,  [dbo].[f_cima_estado_dia] (diar.agencode,diar.diardate) AS estado " & _
        "FROM diar " & _
        "WHERE diar.agencode = '" & Session("agencode") & "' AND diar.diaracti = 'Y' AND month(diar.diardate) = " & Month(Me.Calendar1.VisibleDate) & " AND year(diar.diardate) = " & Year(Me.Calendar1.VisibleDate) & " GROUP BY diar.diardate, [dbo].[f_cima_estado_dia] (diar.agencode,diar.diardate)"

        Me.OdbcDataAdapter4.Fill(Me.Ds_dias3.dias)

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Trim(Session("agencode")) = "ECG" Or Trim(Session("agencode")) = "RM" Or Trim(Session("agencode")) = "RXC" Or Trim(Session("agencode")) = "TLM" Or Trim(Session("agencode")) = "MM" Or Trim(Session("agencode")) = "DN" Or Trim(Session("agencode")) = "TC" Or Trim(Session("agencode")) = "UR RX" Then

            buscar_huecos_CETIR()

        End If

        Session("ok_busca_huecos") = "S"

    End Sub

    Private Sub buscar_huecos_CETIR()

        Dim contador As Integer

        Dim str_menu As String

        Dim str_menu_2 As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        'Dim objCIMA_2 As New CIMA_Clases.CIMA

        Dim objDS_2 As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio

        Dim l_horas_reservadas() As CIMAServeiIntegracio.HoraReservada
        Dim l_mantener_horas_reservadas() As CIMAServeiIntegracio.HoraReservada

        Dim ls_array() As String

        Dim ls_prestacion As String

        Dim li_clave_cetir As Integer



        ls_array = Split(Me.DropDownList2.SelectedValue.ToString, "/", , CompareMethod.Text)

        'ls_array(1)
        ''''''''''''''''''''

        'Dim agenproc_key() as string

        'contador = 0

        'Session("cadena_conexion") = "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

        'str_menu = "[dbo].[SP_CIMACEX_RECUPERA_PRESTACION_CETIR] " & ls_array(1)

        'objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))

        'If objDS.Tables(0).Rows.Count > 0 Then

        'ls_prestacion = objDS.Tables(0).Rows(0).Item("ID_Prova")

        'If objDS.Tables(0).Rows.Count > 0 Then

        ''''''''''''''''''''

        'If Me.DropDownList8.SelectedValue >= "08:00" And Me.DropDownList8.SelectedValue <= "12:00" Then

        'ElseIf Me.DropDownList8.SelectedValue > "12:00" And Me.DropDownList8.SelectedValue <= "12:00" Then

        'End If
        Session("cadena_conexion") = "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

        str_menu = "[dbo].[SP_CIMACEX_RECUPERA_PRESTACION_CETIR] " & ls_array(1)

        objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))

        If objDS.Tables(0).Rows.Count > 0 Then

            ls_prestacion = objDS.Tables(0).Rows(0).Item("ID_Prova")

            str_menu_2 = "dbo.SP_CIMACEX_EPIS_LIGADO_CETIR '" & Session("episcode") & "'"

            objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            If objDS_2.Tables(0).Rows.Count > 0 Then

                li_clave_cetir = objDS_2.Tables(0).Rows(0).Item("clave_cetir")

            Else

                li_clave_cetir = -1

            End If

            Session("horas_reservadas") = Nothing

            If IsNothing(Session("transaccion")) = False Then

                service.RollbackTransaction(Session("transaccion").ID, True)

            End If

            l_transaccion = service.BegginTransaction()

            Session("transaccion") = l_transaccion

            If Me.DropDownList8.SelectedValue = "00:00" Then

                'l_horas_reservadas=SERVICE.RecitarPacient(l_transaccion.ID,True,

                'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                If li_clave_cetir = -1 Then

                    l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

                Else

                    l_horas_reservadas = service.RecitarPacient(l_transaccion.ID, True, li_clave_cetir, True, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True)

                End If

                'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, "CMA", ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

            Else

                'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 1, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                If li_clave_cetir = -1 Then

                    l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 1, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

                Else

                    l_horas_reservadas = service.RecitarPacient(l_transaccion.ID, True, li_clave_cetir, True, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 1, CDate(Me.DropDownList8.SelectedValue)), True)

                End If

            End If

            'service.CommitTransaccio(l_transaccion.ID, True)

            Session("horas_reservadas") = l_horas_reservadas



            Dim dt As New DataTable



            dt.Columns.Add(New DataColumn("ID_Centre", GetType(String)))
            dt.Columns.Add(New DataColumn("ID_Cita", GetType(String)))
            dt.Columns.Add(New DataColumn("Hora", GetType(String)))
            dt.Columns.Add(New DataColumn("Duración", GetType(String)))
            dt.Columns.Add(New DataColumn("ID_Interval_Inici", GetType(String)))
            dt.Columns.Add(New DataColumn("ID_Linia", GetType(String)))
            dt.Columns.Add(New DataColumn("ID_Tram", GetType(String)))



            Dim dr As DataRow

            Dim n As Integer



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

            Session("ok_busca_huecos") = "S"

        Else

            Response.Write("<script language=javascript>alert(""PRESTACIÓN mal mapeada. Por favor, contacte con Administración."");</script>")

        End If


    End Sub

End Class
