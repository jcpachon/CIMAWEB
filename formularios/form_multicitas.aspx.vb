'Imports System.Net
'Imports System.Security.Cryptography.X509Certificates

Public Class form_multicitas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_firm_garantes1 = New cimaweb.ds_firm_garantes
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen_tabla1 = New cimaweb.ds_agen_tabla
        Me.Ds_pers1 = New cimaweb.ds_pers
        Me.Ds_prestaciones1 = New cimaweb.ds_prestaciones
        Me.Ds_covegrou1 = New cimaweb.ds_covegrou
        Me.Ds_busca_huecos1 = New cimaweb.ds_busca_huecos
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter9 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_csta1 = New cimaweb.ds_csta
        Me.Ds_agendas_garantes1 = New cimaweb.ds_agendas_garantes
        Me.SqlDataAdapter7 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Ds_horas_visita1 = New cimaweb.ds_horas_visita
        Me.Ds_episodios_multicitas1 = New cimaweb.ds_episodios_multicitas
        Me.SqlDataAdapter10 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Ds_multicitas1 = New cimaweb.ds_multicitas
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter11 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.Ds_firm1 = New cimaweb.ds_firm
        Me.SqlDataAdapter12 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_autorizaciones1 = New cimaweb.ds_autorizaciones
        Me.SqlDataAdapter13 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.Ds_hora_maxima1 = New cimaweb.ds_hora_maxima
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_horas_visita1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_episodios_multicitas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_multicitas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_autorizaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hora_maxima1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "covegrou", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT CSaludR.dbo.covegrou.covegrou_key, CSaludR.dbo.covegrou.covegroudesclong F" & _
        "ROM cima_coberturas INNER JOIN CSaludR.dbo.covegrou ON cima_coberturas.covegrou_" & _
        "key = CSaludR.dbo.covegrou.covegrou_key WHERE (cima_coberturas.id_agenda_garante" & _
        " = @id_agenda_garante) ORDER BY CSaludR.dbo.covegrou.covegroudesclong"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4, "id_agenda_garante"))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT pers.pers_key, pers.persfullname, pers.perssur1, pers.perssur2, pers.persn" & _
        "ame FROM cstahper INNER JOIN pers ON cstahper.pers_key = pers.pers_key INNER JOI" & _
        "N hper ON pers.pers_key = hper.pers_key INNER JOIN csta ON cstahper.csta_key = c" & _
        "sta.csta_key INNER JOIN hperclas ON hper.hperclascode = hperclas.hperclascode WH" & _
        "ERE (cstahper.cstahperdate_end IS NULL) AND (csta.tactcode IN ('CE', 'RX', 'LA'," & _
        " 'UR')) AND (hper.hperclascode IN (SELECT hperclascode FROM hperclas WHERE hperg" & _
        "roucode = 'C')) AND (csta.cent_key = 1) AND (cstahper.csta_key = @csta_key) ORDE" & _
        "R BY pers.perssur1, pers.perssur2, pers.persname"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PLUTON;packet size=4096;user id=sa;data source=JUPITER;persist sec" & _
        "urity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_firm_garantes1
        '
        Me.Ds_firm_garantes1.DataSetName = "ds_firm_garantes"
        Me.Ds_firm_garantes1.EnforceConstraints = False
        Me.Ds_firm_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT reso_key AS csta_key, resodesc AS cstadesclong FROM reso WHERE (tablcode =" & _
        " 'csta') ORDER BY resodesc"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "[SP_CIMACEX_BUSCA_HUECOS_MULTICITAS]"
        Me.SqlSelectCommand8.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
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
        '
        'Ds_agen_tabla1
        '
        Me.Ds_agen_tabla1.DataSetName = "ds_agen_tabla"
        Me.Ds_agen_tabla1.EnforceConstraints = False
        Me.Ds_agen_tabla1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_pers1
        '
        Me.Ds_pers1.DataSetName = "ds_pers"
        Me.Ds_pers1.EnforceConstraints = False
        Me.Ds_pers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_prestaciones1
        '
        Me.Ds_prestaciones1.DataSetName = "ds_prestaciones"
        Me.Ds_prestaciones1.EnforceConstraints = False
        Me.Ds_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_covegrou1
        '
        Me.Ds_covegrou1.DataSetName = "ds_covegrou"
        Me.Ds_covegrou1.EnforceConstraints = False
        Me.Ds_covegrou1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_busca_huecos1
        '
        Me.Ds_busca_huecos1.DataSetName = "ds_busca_huecos"
        Me.Ds_busca_huecos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss FROM agen WHERE (agenacti = 'Y')" & _
        " AND (cent_key = 1) AND (agencode IN (SELECT resoagen.agencode FROM resoagen WHE" & _
        "RE resoagen.reso_key = @reso_key AND resoagen.tablcode = 'csta')) AND (agentypec" & _
        "ode IN ('CE', 'RX', 'LA', 'UR')) AND (agencode IN (SELECT agencode FROM CIMACEX." & _
        "dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) AND (@firm_key <> 0 AND " & _
        "@firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par FROM CIMACEX" & _
        ".dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencode_par " & _
        "= agen.agencode) OR @firm_key = 0) ORDER BY agenname"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reso_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_agendas_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_agenda_garante", "id_agenda_garante"), New System.Data.Common.DataColumnMapping("agencode_par", "agencode_par"), New System.Data.Common.DataColumnMapping("firm_key_par", "firm_key_par"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("comentarios", "comentarios")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cima_agendas_garantes.id_agenda_garante, cima_agendas_garantes.agencode_pa" & _
        "r, cima_agendas_garantes.firm_key_par, cima_agendas_garantes.descripcion, COALES" & _
        "CE (cima_agendas_garantes.firm_key, 0) AS firm_key, cima_agendas_garantes.covegr" & _
        "ou_key, cima_agendas_garantes.comentarios, COALESCE (CSaludR.dbo.firm.firmname, " & _
        "'') AS firmname FROM cima_agendas_garantes LEFT OUTER JOIN CSaludR.dbo.firm ON c" & _
        "ima_agendas_garantes.firm_key = CSaludR.dbo.firm.firm_key WHERE (cima_agendas_ga" & _
        "rantes.agencode_par = @agencode_par) AND (cima_agendas_garantes.firm_key_par = @" & _
        "firm_key_par)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode_par", System.Data.SqlDbType.VarChar, 6, "agencode_par"))
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key_par", System.Data.SqlDbType.Int, 4, "firm_key_par"))
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=NEPTUNO;packet size=4096;user id=sa;data source=""10.8.50.213"";pers" & _
        "ist security info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter9
        '
        Me.SqlDataAdapter9.SelectCommand = Me.SqlSelectCommand9
        Me.SqlDataAdapter9.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_HORAS_VISITA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CIMACEX_HORAS_VISITA]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.SqlConnection3
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
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
        "guar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') AND (@agencode " & _
        "<> '' AND @agencode IN (SELECT CIMACEX.dbo.cima_agendas_garantes.agencode_par FR" & _
        "OM CIMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.fir" & _
        "m_key_par = firm.firm_key) OR @agencode = '') ORDER BY firm.firmname"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.Char, 6))
        '
        'Ds_csta1
        '
        Me.Ds_csta1.DataSetName = "ds_csta"
        Me.Ds_csta1.EnforceConstraints = False
        Me.Ds_csta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agendas_garantes1
        '
        Me.Ds_agendas_garantes1.DataSetName = "ds_agendas_garantes"
        Me.Ds_agendas_garantes1.EnforceConstraints = False
        Me.Ds_agendas_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter7
        '
        Me.SqlDataAdapter7.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter7.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "prod", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Descripción", "Descripción"), New System.Data.Common.DataColumnMapping("Tiempo", "Tiempo"), New System.Data.Common.DataColumnMapping("prod_key", "prod_key"), New System.Data.Common.DataColumnMapping("proddesclong", "proddesclong")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
        "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
        "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
        "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
        " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
        " = btimetab.agencode LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE" & _
        " ((proctita.agencode = @agencode AND @agencode <> 'LABO') or (@agencode = 'LABO'" & _
        " and hpro.hprocode = 'LB9900')) AND (hpro.hproacti = 'Y') AND (proctita.proctita" & _
        "acti = 'Y') AND (btimetab.btimetabacti = 'Y')"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6, "agencode"))
        '
        'Ds_horas_visita1
        '
        Me.Ds_horas_visita1.DataSetName = "ds_horas_visita"
        Me.Ds_horas_visita1.EnforceConstraints = False
        Me.Ds_horas_visita1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_episodios_multicitas1
        '
        Me.Ds_episodios_multicitas1.DataSetName = "ds_episodios_multicitas"
        Me.Ds_episodios_multicitas1.EnforceConstraints = False
        Me.Ds_episodios_multicitas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter10
        '
        Me.SqlDataAdapter10.SelectCommand = Me.SqlSelectCommand10
        Me.SqlDataAdapter10.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_EPISODIOS_MULTICITAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("epis_key", "epis_key"), New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("clip_key", "clip_key"), New System.Data.Common.DataColumnMapping("tactdesc", "tactdesc"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("pati_hfn", "pati_hfn"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname"), New System.Data.Common.DataColumnMapping("episdatecrea", "episdatecrea"), New System.Data.Common.DataColumnMapping("episcstadateinit", "episcstadateinit"), New System.Data.Common.DataColumnMapping("episcstadate_end", "episcstadate_end"), New System.Data.Common.DataColumnMapping("episopen", "episopen")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "[SP_CIMACEX_EPISODIOS_MULTICITAS]"
        Me.SqlSelectCommand10.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        '
        'Ds_multicitas1
        '
        Me.Ds_multicitas1.DataSetName = "ds_multicitas"
        Me.Ds_multicitas1.EnforceConstraints = False
        Me.Ds_multicitas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter8
        '
        Me.SqlDataAdapter8.SelectCommand = Me.SqlSelectCommand8
        Me.SqlDataAdapter8.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_BUSCA_HUECOS_MULTICITAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hora_ini", "hora_ini"), New System.Data.Common.DataColumnMapping("hora_fin", "hora_fin"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("diardate", "diardate"), New System.Data.Common.DataColumnMapping("ok", "ok"), New System.Data.Common.DataColumnMapping("diardate1", "diardate1"), New System.Data.Common.DataColumnMapping("dia_semana", "dia_semana"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("duracion", "duracion"), New System.Data.Common.DataColumnMapping("hora_inicial", "hora_inicial")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "[SP_CIMACEX_BUSCA_HUECOS]"
        Me.SqlSelectCommand11.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dia", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@covegrou_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@duracion", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter11
        '
        Me.SqlDataAdapter11.SelectCommand = Me.SqlSelectCommand12
        Me.SqlDataAdapter11.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT firm_key FROM firm WHERE (firm_keytabl = @pers_key) AND (tablcode = 'pers'" & _
        ")"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4, "firm_keytabl"))
        '
        'Ds_firm1
        '
        Me.Ds_firm1.DataSetName = "ds_firm"
        Me.Ds_firm1.EnforceConstraints = False
        Me.Ds_firm1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter12
        '
        Me.SqlDataAdapter12.SelectCommand = Me.SqlCommand1
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT hpro_key, id_agenda_garante FROM cima_prestaciones_autorizacion WHERE (hpr" & _
        "o_key = @hpro_key) AND (id_agenda_garante = @id_agenda_garante)"
        Me.SqlCommand1.Connection = Me.SqlConnection2
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, "hpro_key"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4, "id_agenda_garante"))
        '
        'Ds_autorizaciones1
        '
        Me.Ds_autorizaciones1.DataSetName = "ds_autorizaciones"
        Me.Ds_autorizaciones1.EnforceConstraints = False
        Me.Ds_autorizaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter13
        '
        Me.SqlDataAdapter13.SelectCommand = Me.SqlSelectCommand13
        Me.SqlDataAdapter13.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("max_hora", "max_hora")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT MAX(CONVERT (varchar(5), btimetabhour_end, 108)) AS max_hora FROM btimetab" & _
        " WHERE (agencode = @agencode) AND (btimetabacti = 'Y')"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        Me.SqlSelectCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6, "agencode"))
        '
        'Ds_hora_maxima1
        '
        Me.Ds_hora_maxima1.DataSetName = "ds_hora_maxima"
        Me.Ds_hora_maxima1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_horas_visita1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_episodios_multicitas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_multicitas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_autorizaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hora_maxima1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents fecha_ini As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_firm_garantes1 As cimaweb.ds_firm_garantes
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agen_tabla1 As cimaweb.ds_agen_tabla
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers
    Protected WithEvents Ds_prestaciones1 As cimaweb.ds_prestaciones
    Protected WithEvents Ds_covegrou1 As cimaweb.ds_covegrou
    Protected WithEvents Ds_busca_huecos1 As cimaweb.ds_busca_huecos
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_csta1 As cimaweb.ds_csta
    Protected WithEvents Ds_agendas_garantes1 As cimaweb.ds_agendas_garantes
    Protected WithEvents SqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_horas_visita1 As cimaweb.ds_horas_visita
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Ds_episodios_multicitas1 As cimaweb.ds_episodios_multicitas
    Protected WithEvents SqlDataAdapter10 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_multicitas1 As cimaweb.ds_multicitas
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DropDownList8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter11 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_firm1 As cimaweb.ds_firm
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_autorizaciones1 As cimaweb.ds_autorizaciones
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter13 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_hora_maxima1 As cimaweb.ds_hora_maxima

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    'Private service As New CIMAServeiIntegracio.ServeiIntegracio

    'JGM Variable per controlar canvi agenda o servei
    Dim aux_canvi As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        Dim ls_matriz() As String

        Dim ls_agencode, ls_doctor, ls_mutua, ls_covegrou_key, ls_pers_key As String
        Dim str_menu As String

        Dim ls_duracion() As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        ''Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)



        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        If Session("requiere_autorizacion") = "S" Then

            Me.Label10.Visible = True

        Else

            Me.Label10.Visible = False

        End If

        'Dim objCIMA As New CIMA_Clases.CIMA

        'Dim objDS As New Data.DataSet


        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")



        Me.Panel4.Visible = False

        If Me.fecha_ini.Text = "__/__/____" Then
            ls_matriz = Split(Today.ToString, " ", , CompareMethod.Text)
            Me.fecha_ini.Text = ls_matriz(0)
            Me.Textbox2.Text = ls_matriz(0)
            Me.Calendar1.SelectedDate = Today
            Me.Calendar2.SelectedDate = Today
        End If

        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then

            Me.Panel4.Visible = True

        End If

        If Len(Trim(Request("pers_key_paciente"))) > 0 Then

            Me.SqlDataAdapter10.SelectCommand.Parameters(1).Value = Request("pers_key_paciente")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter10.Fill(Me.Ds_episodios_multicitas1.SP_CIMACEX_EPISODIOS_MULTICITAS)
            Me.SqlConnection1.Close()

            Me.Panel6.Visible = True

            Session("pers_key_paciente") = Request("pers_key_paciente")

        End If

        If Request("ok_padre") = "S" Then

            Me.Panel6.Visible = False
            Me.Panel5.Visible = True
            Me.Label17.Text = Request("episcode")

        End If

        If Request("ok_cita") = "S" And Request("ok_control") <> "S" Then

            'Request.Form("envio_cita").Form1.Empty()

            'document.envio_cita.fecha_cita.value=fecha;
            'document.envio_cita.btimetabcode.value = btimetabcode;
            'document.envio_cita.hora_final.value = hora_fin;
            'document.envio_cita.hora_inicial.value = hora_ini;
            'document.envio_cita.ok_cita.value="S";

            If Len(Request("covegrou_key")) = 0 Or Request("covegrou_key") Is Nothing Then

                ' Par no definido o definido incorrectamente.

                Response.Write("<scr" & "ipt>" & vbCrLf)
                'Response.Write("document.envio_cita.ok_cita.value="""";")
                Response.Write("alert(""Par no definido o definido incorrectamente. Contacte con Administración."");" & vbCrLf)

                Response.Write("</scr" & "ipt>")

            Else

                If Request("retorno_pers_key") Is Nothing Or Request("retorno_pers_key") = "" Then

                    ' Falta especificar el paciente.

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    'Response.Write("document.envio_cita.ok_cita.value="""";")
                    Response.Write("alert(""Paciente no definido."");" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                Else

                    ls_duracion = Split(Request("prestacion"), "/", , CompareMethod.Text)

                    ls_agencode = Request("agencode")

                    If Len(Trim(Request("doctor"))) > 0 Then
                        ls_doctor = Request("doctor")
                    Else
                        ls_doctor = "0"
                    End If

                    ls_mutua = Request("garante") 'Request("firm_key")

                    If ls_mutua = "0" Then

                        ls_mutua = CStr(PP(Request("retorno_pers_key")))

                    End If

                    If ls_mutua = "-1" Then

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")

                    Else

                        ls_covegrou_key = Request("covegrou_key")

                        ls_pers_key = Request("retorno_pers_key")

                        If Len(Trim(str_uid)) > 0 Then
                            str_uid = str_uid
                        Else
                            str_uid = ""
                        End If

                        str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA] '" & Request("fecha_cita") & "','" & ls_agencode & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Request("btimetabcode") & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & Request("firm_key") & "," & Request("covegrou_key") & ",'" & str_uid & "'"

                        Dim objConn As New Odbc.OdbcConnection

                        Dim objCommand As New Odbc.OdbcCommand

                        'Dim objDA As New Odbc.OdbcDataAdapter(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN") ' SqlClient.SqlDataAdapter(sql, cadena_conexion)

                        'Dim objDS As New Data.DataSet
                        'pepino.Connection.ConnectionString = ""

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
                        Response.Write("alert('Cita registrada con éxito.');" & vbCrLf)
                        Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                        Response.Write("</scr" & "ipt>" & vbCrLf)

                        'Response.Redirect("form_citas_rapidas.aspx")

                    End If

                End If

            End If

            'str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA] '" & Request("fecha_cita") & "','" & Session("agencode") & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Me.DropDownList1.SelectedValue.ToString & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico

        End If

        'JGM Inicialitzem la primera vegada
        If IsPostBack = False Then
            aux_canvi = False
        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim array(), m1(), m2() As String
        Dim n As Integer

        Dim str_creciente As String



        If Len(Request("cadena_creciente")) > 0 Then

            array = Split(Request("cadena_creciente"), "*", , CompareMethod.Text)

            For n = 0 To UBound(array)

                If array(n) <> "" Then

                    str_creciente = str_creciente & "{" & array(n)

                End If

            Next

            m1 = Split(str_creciente, "{", , CompareMethod.Text)

            For n = 0 To UBound(m1)

                If m1(n) <> "" Then

                    m2 = Split(m1(n), "#", , CompareMethod.Text)


                    alta_cita(m2(4), m2(8), m2(5), m2(6), m2(7), m2(0), m2(1), m2(2), m2(3), m2(9))


                End If

            Next

            Session("pers_key_paciente") = ""

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Citas REGISTRADAS con éxito.');")
            'Response.Write("alert('" & str_creciente & "');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        actualizar()

    End Sub

    Public Sub actualizar()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_csta1.csta)
        Me.SqlConnection1.Close()

        Me.DropDownList1.DataBind()

        Me.DropDownList1.Items.Insert(0, "")

        If Len(Trim(Request("DropDownList1"))) > 0 Then
            Me.DropDownList1.SelectedValue = Request("DropDownList1")
        End If

        'JGM -- Afegim el control de les mutues
        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
            Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue
        Else
            Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = ""
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes1.firm)
        Me.SqlConnection1.Close()

        Me.Dropdownlist3.DataBind()

        Me.Dropdownlist3.Items.Insert(0, "PRIVADO")

        'JGM només mantemin la mutua si no ha canviat ni l'agenda ni el servei.
        ' Farem servir una variable de control
        If Len(Trim(Request("DropDownList3"))) > 0 And aux_canvi = False Then
            Me.Dropdownlist3.SelectedValue = Request("DropDownList3")
            aux_canvi = False
        End If

    End Sub

    Public Sub alta_cita(ByVal agencode As String, ByVal prestacion As String, ByVal doctor As String, ByVal firm_key As String, ByVal covegrou_key As String, ByVal fecha_cita As String, ByVal hora_inicial As String, ByVal hora_final As String, ByVal btimetabcode As String, ByVal duracion As String)

        Dim ls_duracion() As String
        Dim ls_agencode, ls_doctor, ls_mutua, ls_covegrou_key, ls_pers_key As String
        Dim str_menu As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String




        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        'ls_duracion = Split(prestacion, "/", , CompareMethod.Text)

        ls_agencode = agencode

        If Len(Trim(doctor)) > 0 Then
            ls_doctor = doctor
        Else
            ls_doctor = "0"
        End If

        ls_mutua = firm_key

        If ls_mutua = "0" Then

            ls_mutua = CStr(PP(Request("retorno_pers_key")))

        End If

        If ls_mutua = "-1" Then

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            ls_covegrou_key = covegrou_key

            ls_pers_key = Session("pers_key_paciente") 'Trim(Request("pers_key_paciente"))

            If Len(Trim(str_uid)) > 0 Then
                str_uid = str_uid
            Else
                str_uid = ""
            End If

            str_menu = "[dbo].[SP_CIMACEX_ALTA_MULTICITA] '" & fecha_cita & "','" & ls_agencode & "','" & hora_inicial & "','" & hora_final & "'," & duracion & "," & btimetabcode & "," & prestacion & "," & ls_pers_key & "," & ls_doctor & "," & firm_key & "," & covegrou_key & ",'" & Me.Label17.Text & "','" & str_uid & "'"

            Dim objConn As New Odbc.OdbcConnection

            Dim objCommand As New Odbc.OdbcCommand

            'Dim objDA As New Odbc.OdbcDataAdapter(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN") ' SqlClient.SqlDataAdapter(sql, cadena_conexion)

            'Dim objDS As New Data.DataSet
            'pepino.Connection.ConnectionString = ""

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

        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Dim str_uid As String

        'JGM Actualitzem la variable de control 
        aux_canvi = True
        Me.Dropdownlist3.SelectedValue = "PRIVADO"

        Me.Label13.Visible = False
        Me.Label12.Visible = False
        Me.Label7.Visible = False
        Me.Dropdownlist6.Visible = False

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_pers1.pers)
        Me.SqlConnection1.Close()

        Me.Dropdownlist2.DataBind()

        Me.Dropdownlist2.Items.Insert(0, "")

        str_uid = Request.Cookies("usuario").Value

        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = str_uid

        'JGM --Afegim el nou paràmetre.
        If Me.Dropdownlist3.SelectedValue = "PRIVADO" Then
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = 0
        Else
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = Me.Dropdownlist3.SelectedValue
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist5.DataBind()

        Me.Dropdownlist5.Items.Insert(0, "")

        Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = ""

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
        Me.SqlConnection1.Close()

        Me.Dropdownlist4.DataBind()

        Me.Dropdownlist4.Items.Insert(0, "")

        Me.Dropdownlist4.SelectedValue = ""

        Session("requiere_autorizacion") = "N"

        Me.Label10.Visible = False

        'Me.Ds_firm_garantes1.Clear()

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes1.firm)
        'Me.SqlConnection1.Close()

        'Me.Dropdownlist3.DataBind()

        'Me.Dropdownlist3.SelectedValue = ""

        Me.Dropdownlist6.DataBind()

        Me.Panel1.Visible = False

        Session("id_agenda_garante") = ""

        Me.Panel4.Visible = False
        'If Me.DataGrid1.Items.Count.Cells(2).Text() Then


    End Sub

    Private Sub Dropdownlist3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist3.SelectedIndexChanged

        Dim ls_agencode As String
        Dim li_firm_key As Integer
        Dim str_uid As String

        Me.Label13.Visible = False
        Me.Label12.Visible = False
        Me.Label7.Visible = False
        Me.Dropdownlist6.Visible = False

        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
            ls_agencode = Me.Dropdownlist5.SelectedValue
        Else
            ls_agencode = ""
        End If

        If Len(Trim(Me.Dropdownlist3.SelectedValue)) > 0 And Me.Dropdownlist3.SelectedValue <> "PRIVADO" Then
            li_firm_key = CInt(Me.Dropdownlist3.SelectedValue)
        Else
            li_firm_key = 0
        End If

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = ls_agencode 'Me.Dropdownlist5.SelectedValue
        Me.SqlDataAdapter5.SelectCommand.Parameters(1).Value = li_firm_key 'Me.Dropdownlist3.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_agendas_garantes1.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        If Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows.Count > 0 Then

            Session("id_agenda_garante") = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.SqlDataAdapter6.SelectCommand.Parameters(0).Value = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.TextBox1.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("comentarios")
            Me.Label13.Visible = True
            Me.Label12.Visible = True
            Me.Label7.Visible = True
            Me.Dropdownlist6.Visible = True

            If Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key") = 0 Then
                Me.Label13.Text = "PROPIO PACIENTE"
                Me.Label15.Text = PP(Session("pers_key_paciente")) 'PP(Request("retorno_pers_key"))
            Else
                Me.Label13.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firmname")
                Me.Label15.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key")
            End If

            Me.Panel1.Visible = True

        Else

            Me.SqlDataAdapter6.SelectCommand.Parameters(0).Value = 0 'Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.Panel1.Visible = False

            Session("id_agenda_garante") = ""

            'Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")

        End If

        If Me.Label15.Text = "-1" Then

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter6.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection2.Close()

            Me.Dropdownlist6.DataBind()

            Me.Dropdownlist4.SelectedValue = ""

            Session("requiere_autorizacion") = "N"

            Me.Label10.Visible = False

        End If

        'JGM -- Tornem a recarregar les agendes
        str_uid = Request.Cookies("usuario").Value

        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = str_uid

        If Me.Dropdownlist3.SelectedValue = "PRIVADO" Then
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = 0
        Else
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = Me.Dropdownlist3.SelectedValue
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist5.DataBind()
        Me.Dropdownlist5.Items.Insert(0, "")

        If Len(Trim(Request("Dropdownlist5"))) > 0 Then
            Me.Dropdownlist5.SelectedValue = Request("Dropdownlist5")
        End If

        'Fi JGM

    End Sub

    Private Sub Dropdownlist5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist5.SelectedIndexChanged

        Dim ls_agencode As String
        Dim li_firm_key As Integer

        Me.Label13.Visible = False
        Me.Label12.Visible = False
        Me.Label7.Visible = False
        Me.Dropdownlist6.Visible = False
        'Ocultem la label19 que ens servirà només per agafar la hora màxima de l'agenda
        Me.Label19.Visible = False


        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
            ls_agencode = Me.Dropdownlist5.SelectedValue
        Else
            ls_agencode = ""
        End If

        If Len(Trim(Me.Dropdownlist3.SelectedValue)) > 0 And Me.Dropdownlist3.SelectedValue <> "PRIVADO" Then
            li_firm_key = CInt(Me.Dropdownlist3.SelectedValue)
        Else
            li_firm_key = 0
        End If

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = ls_agencode 'Me.Dropdownlist5.SelectedValue
        Me.SqlDataAdapter5.SelectCommand.Parameters(1).Value = li_firm_key 'Me.Dropdownlist3.SelectedValue

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_agendas_garantes1.cima_agendas_garantes)
        Me.SqlConnection2.Close()

        If Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows.Count > 0 Then

            Session("id_agenda_garante") = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.SqlDataAdapter6.SelectCommand.Parameters(0).Value = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.TextBox1.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("comentarios")
            Me.Label13.Visible = True
            Me.Label12.Visible = True
            Me.Label7.Visible = True
            Me.Dropdownlist6.Visible = True

            If Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key") = 0 Then
                Me.Label13.Text = "PROPIO PACIENTE"
                Me.Label15.Text = PP(Session("pers_key_paciente")) 'PP(Request("retorno_pers_key"))
            Else
                Me.Label13.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firmname")
                Me.Label15.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key")
            End If

            If Len(Trim(Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("comentarios"))) > 0 Then

                Me.Panel1.Visible = True

                'Else

                'Me.Panel1.Visible = False

            End If

        Else

            Me.SqlDataAdapter6.SelectCommand.Parameters(0).Value = 0 'Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("id_agenda_garante")

            Me.Panel1.Visible = False

            Session("id_agenda_garante") = ""

        End If

        If Me.Label15.Text = "-1" Then

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter6.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection2.Close()

            Me.Dropdownlist6.DataBind()

            Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = ls_agencode

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
            Me.SqlConnection1.Close()

            Me.Dropdownlist4.DataBind()

            Me.Dropdownlist4.Items.Insert(0, "")

            Me.Dropdownlist4.SelectedValue = ""

            Session("requiere_autorizacion") = "N"

            Me.Label10.Visible = False

            Me.SqlDataAdapter9.SelectCommand.Parameters(1).Value = Me.Dropdownlist5.SelectedValue

            Me.SqlConnection3.Open()
            Me.SqlDataAdapter9.Fill(Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA)
            Me.SqlConnection3.Close()

            Me.Label18.Visible = True

            'Informamos la agenda per omplir la label19.
            Me.SqlDataAdapter13.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue


            If Len(Trim(Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA.Rows(0).Item("nombre"))) > 0 Then

                Me.Label18.Text = Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA.Rows(0).Item("nombre")
                Me.Panel4.Visible = True
                'Si trobem la franja de l'agenda ens guardem el valor màxim.
                Me.SqlConnection3.Open()
                Me.SqlDataAdapter13.Fill(Me.Ds_hora_maxima1.cima_hora_maxima)
                Me.SqlConnection1.Close()
                Me.Label19.Text = Me.Ds_hora_maxima1.cima_hora_maxima.Rows(0).Item("max_hora")
            Else

                Me.Panel4.Visible = False

            End If

        End If

    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        If Me.Calendar1.Visible = True Then
            Me.Calendar1.Visible = False
        Else
            Me.Calendar1.Visible = True
        End If

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        Me.fecha_ini.Text = Me.Calendar1.SelectedDate.ToShortDateString.ToString
        Me.Calendar1.Visible = False

    End Sub

    Private Sub Imagebutton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton2.Click

        If Me.Calendar2.Visible = True Then
            Me.Calendar2.Visible = False
        Else
            Me.Calendar2.Visible = True
        End If

    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged

        Me.Textbox2.Text = Me.Calendar2.SelectedDate.ToShortDateString.ToString
        Me.Calendar2.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If Me.RadioButton1.Checked = True Then
            Me.Panel2.Visible = True
            Me.Panel3.Visible = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If Me.RadioButton2.Checked = True Then
            Me.Panel2.Visible = False
            Me.Panel3.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ls_causa As String

        If Me.DataGrid1.Items().Count > 0 Then

            If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
                ' Agenda. Cuando se tenga activado el servicio se deberá comprobrar sólo si está un servicio seleccionado.
                If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
                    ' Mutua.
                    If Len(Trim(Me.Label13.Text)) > 0 And Me.Label13.Visible = True Then
                        ' Garante.
                        If Len(Trim(Me.Dropdownlist6.SelectedValue)) > 0 Then
                            ' A. de Coberturas.
                            If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then
                                ' Prestación.
                                'Session("ok_busca_huecos") = "S"
                                If CInt(Mid(Me.Label19.Text, 1, 2)) > CInt(Mid(Me.DropDownList8.SelectedValue.ToString, 1, 2)) Then
                                    Session("ok_busca_huecos") = "S"
                                Else
                                    If CInt(Mid(Me.Label19.Text, 1, 2)) = CInt(Mid(Me.DropDownList8.SelectedValue.ToString, 1, 2)) Then
                                        If CInt(Mid(Me.Label19.Text, 4, 2)) > CInt(Mid(Me.DropDownList8.SelectedValue.ToString, 4, 2)) Then
                                            Session("ok_busca_huecos") = "S"
                                        Else
                                            ls_causa = "H"
                                        End If
                                    Else
                                        ls_causa = "H"
                                    End If
                                End If
                            Else
                                ls_causa = "P"
                            End If
                            'Session("ok_busca_huecos") = "S"
                        Else
                            ls_causa = "C"
                        End If
                    Else
                        ls_causa = "G"
                    End If
                Else
                    ls_causa = "M"
                End If
            Else
                ls_causa = "A"
            End If

            Select Case ls_causa
                Case "A"
                    Response.Write("<script language=javascript>alert(""Falta especificar una agenda."");</script>")
                Case "M"
                    Response.Write("<script language=javascript>alert(""Falta especificar una mutua."");</script>")
                Case "G", "C"
                    Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")
                Case "P"
                    Response.Write("<script language=javascript>alert(""Falta especificar una prestación."");</script>")
                Case "H"
                    Response.Write("<script language=javascript>alert(""La hora de inicio es superior a la del fin de alguna agenda"");</script>")
            End Select

        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('No hay PRESTACIONES seleccionadas.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim dt As New Data.DataTable
        Dim dr As Data.DataRow

        Dim i As Integer



        If Len(Trim(Me.Label13.Text)) > 0 And Me.Label13.Visible = True And Len(Trim(Me.Dropdownlist6.SelectedValue)) > 0 Then

            If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

                Me.DataGrid1.Visible = True
                Me.Button4.Visible = True

                Me.DataGrid1.SelectedIndex() = -1



                'dt.Columns.Add(New DataColumn("", GetType(String)))
                dt.Columns.Add(New DataColumn("Servicio", GetType(String)))
                dt.Columns.Add(New DataColumn("Agenda", GetType(String)))
                dt.Columns.Add(New DataColumn("Garante", GetType(String)))
                dt.Columns.Add(New DataColumn("Agr. de Cob.", GetType(String)))
                dt.Columns.Add(New DataColumn("Prestación", GetType(String)))
                'dt.Columns.Add(New DataColumn(" ", GetType(String), "", MappingType.Hidden))
                'dt.Columns.Add(New DataColumn("1", GetType(String), "", MappingType.Hidden))
                'dt.Columns.Add(New DataColumn("2", GetType(String), "", MappingType.Hidden))
                'dt.Columns.Add(New DataColumn("3", GetType(String), "", MappingType.Hidden))
                dt.Columns.Add(New DataColumn(" ", GetType(String)))
                dt.Columns.Add(New DataColumn("1", GetType(String)))
                dt.Columns.Add(New DataColumn("2", GetType(String)))
                dt.Columns.Add(New DataColumn("3", GetType(String)))

                'Me.DataGrid1.Items(0).Visible = False

                For i = 0 To Me.DataGrid1.Items().Count - 1

                    dr = dt.NewRow()

                    'dr(0) = ">>>"
                    dr(0) = Me.DataGrid1.Items(i).Cells(1).Text
                    dr(1) = Me.DataGrid1.Items(i).Cells(2).Text
                    dr(2) = Me.DataGrid1.Items(i).Cells(3).Text
                    dr(3) = Me.DataGrid1.Items(i).Cells(4).Text
                    'dr(4) = Me.Dropdownlist3.SelectedValue
                    dr(4) = Me.DataGrid1.Items(i).Cells(5).Text
                    dr(5) = Me.DataGrid1.Items(i).Cells(6).Text
                    dr(6) = Me.DataGrid1.Items(i).Cells(7).Text
                    dr(7) = Me.DataGrid1.Items(i).Cells(8).Text
                    dr(8) = Me.DataGrid1.Items(i).Cells(9).Text

                    dt.Rows.Add(dr)

                Next

                dr = dt.NewRow()

                'dr(0) = ">>>"
                dr(0) = Me.DropDownList1.SelectedItem
                dr(1) = Me.Dropdownlist5.SelectedValue
                dr(2) = Me.Label13.Text
                dr(3) = Me.Dropdownlist6.SelectedItem
                'dr(4) = Me.Dropdownlist3.SelectedValue
                dr(4) = Me.Dropdownlist4.SelectedItem
                dr(5) = Me.Dropdownlist4.SelectedValue
                dr(6) = Me.Dropdownlist2.SelectedValue
                dr(7) = CInt(Me.Label15.Text)
                dr(8) = Me.Dropdownlist6.SelectedValue

                dt.Rows.Add(dr)

                DataGrid1.DataSource = dt

                DataGrid1.DataBind()

                Session("dt") = dt

                'Me.DataGrid1.Columns(6).Visible = False
                'Me.DataGrid1.Columns(7).Visible = False
                'Me.DataGrid1.Columns(8).Visible = False

                'Me.DataGrid1.Items(0).Cells(8).Visible = False

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Debe seleccionar una PRESTACION.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        Else

            Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")

        End If

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

        Me.Button4.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim dt As New Data.DataTable
        Dim dr As Data.DataRow

        Dim i As Integer



        'dt.Columns.Add(New DataColumn("", GetType(String)))
        dt.Columns.Add(New DataColumn("Servicio", GetType(String)))
        dt.Columns.Add(New DataColumn("Agenda", GetType(String)))
        dt.Columns.Add(New DataColumn("Garante", GetType(String)))
        dt.Columns.Add(New DataColumn("Agr. de Cob.", GetType(String)))
        dt.Columns.Add(New DataColumn("Prestación", GetType(String)))
        dt.Columns.Add(New DataColumn(" ", GetType(String), "", MappingType.Hidden))
        dt.Columns.Add(New DataColumn("1", GetType(String), "", MappingType.Hidden))
        dt.Columns.Add(New DataColumn("2", GetType(String), "", MappingType.Hidden))
        dt.Columns.Add(New DataColumn("3", GetType(String), "", MappingType.Hidden))

        'Me.DataGrid1.Items(0).Visible = False

        For i = 0 To Me.DataGrid1.Items().Count - 1

            If i <> Me.DataGrid1.SelectedIndex Then

                dr = dt.NewRow()

                dr(0) = Me.DataGrid1.Items(i).Cells(1).Text
                dr(1) = Me.DataGrid1.Items(i).Cells(2).Text
                dr(2) = Me.DataGrid1.Items(i).Cells(3).Text
                dr(3) = Me.DataGrid1.Items(i).Cells(4).Text
                'dr(4) = Me.Dropdownlist3.SelectedValue
                dr(4) = Me.DataGrid1.Items(i).Cells(5).Text
                dr(5) = Me.DataGrid1.Items(i).Cells(6).Text
                dr(6) = Me.DataGrid1.Items(i).Cells(7).Text
                dr(7) = Me.DataGrid1.Items(i).Cells(8).Text
                dr(8) = Me.DataGrid1.Items(i).Cells(9).Text

                dt.Rows.Add(dr)

            End If

        Next

        dt.Columns(5).ColumnMapping = MappingType.Hidden

        DataGrid1.DataSource = dt

        DataGrid1.DataBind()

        'Me.DataGrid1.Items(0).Cells(8).Visible = False

        Me.Button4.Enabled = False

        If Me.DataGrid1.Items().Count < 1 Then

            Me.DataGrid1.Visible = False
            Me.Button4.Visible = False
            Me.DataGrid1.SelectedIndex() = -1

        End If

    End Sub

    Public Function PP(ByVal ai_pers_key As Integer) As Integer

        Me.SqlDataAdapter11.SelectCommand.Parameters(0).Value = ai_pers_key

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter11.Fill(Me.Ds_firm1.firm)
        Me.SqlConnection1.Close()

        'PP = CInt(Me.Ds_firm1.firm.Rows(0).Item("firm_key"))

        If Me.Ds_firm1.firm.Rows.Count > 0 Then
            PP = CInt(Me.Ds_firm1.firm.Rows(0).Item("firm_key"))
        Else
            PP = -1
        End If

    End Function


    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound

        e.Item.Cells(6).Visible = False
        e.Item.Cells(7).Visible = False
        e.Item.Cells(8).Visible = False
        e.Item.Cells(9).Visible = False

    End Sub

    Private Sub Dropdownlist4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist4.SelectedIndexChanged

        Dim ls_duracion() As String



        'Me.Dropdownlist7.SelectedValue = ""

        'Me.Textbox3.Text = ""

        If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

            If Len(Trim(Session("id_agenda_garante"))) > 0 Then

                ls_duracion = Split(Me.Dropdownlist4.SelectedValue.ToString, "/", , CompareMethod.Text)

                Me.SqlDataAdapter12.SelectCommand.Parameters(0).Value = ls_duracion(1) 'Me.Dropdownlist4.SelectedValue
                Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Session("id_agenda_garante")

                Me.SqlConnection2.Open()
                Me.SqlDataAdapter12.Fill(Me.Ds_autorizaciones1.cima_prestaciones_autorizacion)
                Me.SqlConnection2.Close()

                If Me.Ds_autorizaciones1.cima_prestaciones_autorizacion.Rows.Count > 0 Then

                    Me.Label10.Visible = True
                    Session("requiere_autorizacion") = "S"

                Else

                    Me.Label10.Visible = False
                    Session("requiere_autorizacion") = "N"

                End If

            Else

                Me.Label10.Visible = False
                Session("requiere_autorizacion") = "N"

            End If

        End If

    End Sub

End Class
