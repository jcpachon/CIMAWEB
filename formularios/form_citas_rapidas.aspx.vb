Imports System.Net
Imports System.Security.Cryptography.X509Certificates

Public Class form_citas_rapidas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_csta1 = New cimaweb.ds_csta
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_pers1 = New cimaweb.ds_pers
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen_tabla1 = New cimaweb.ds_agen_tabla
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_firm_garantes1 = New cimaweb.ds_firm_garantes
        Me.Ds_agendas_garantes1 = New cimaweb.ds_agendas_garantes
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Ds_covegrou1 = New cimaweb.ds_covegrou
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Ds_prestaciones1 = New cimaweb.ds_prestaciones
        Me.SqlDataAdapter7 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_busca_huecos1 = New cimaweb.ds_busca_huecos
        Me.Ds_horas_visita1 = New cimaweb.ds_horas_visita
        Me.SqlDataAdapter9 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter10 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Ds_firm1 = New cimaweb.ds_firm
        Me.SqlDataAdapter11 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.Ds_firm2 = New cimaweb.ds_firm
        Me.Ds_btimetab1 = New cimaweb.ds_btimetab
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_franja_horaria1 = New cimaweb.ds_franja_horaria
        Me.OdbcDataAdapter3 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
        Me.Ds_autorizaciones1 = New cimaweb.ds_autorizaciones
        Me.SqlDataAdapter12 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter13 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.Ds_hpro_cetir1 = New cimaweb.ds_hpro_cetir
        Me.Ds_hoja_citacion1 = New cimaweb.ds_hoja_citacion
        Me.SqlDataAdapter14 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter15 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_episodios_multicitas1 = New cimaweb.ds_episodios_multicitas
        Me.SqlDataAdapter16 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_btimetab2 = New cimaweb.ds_btimetab
        Me.SqlDataAdapter17 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter18 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_horas_visita1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_autorizaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hpro_cetir1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hoja_citacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_episodios_multicitas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_btimetab2, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_csta1
        '
        Me.Ds_csta1.DataSetName = "ds_csta"
        Me.Ds_csta1.EnforceConstraints = False
        Me.Ds_csta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_pers1
        '
        Me.Ds_pers1.DataSetName = "ds_pers"
        Me.Ds_pers1.EnforceConstraints = False
        Me.Ds_pers1.Locale = New System.Globalization.CultureInfo("en-US")
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
        "ERE (cstahper.cstahperdate_end IS NULL) AND (csta.tactcode IN ('CE', 'RX', 'LA' " & _
        ", 'UR')) AND (hper.hperclascode IN (SELECT hperclascode FROM hperclas WHERE hper" & _
        "groucode = 'C')) AND (csta.cent_key = 1) AND (cstahper.csta_key = @csta_key) ORD" & _
        "ER BY pers.perssur1, pers.perssur2, pers.persname"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        '
        'Ds_agen_tabla1
        '
        Me.Ds_agen_tabla1.DataSetName = "ds_agen_tabla"
        Me.Ds_agen_tabla1.EnforceConstraints = False
        Me.Ds_agen_tabla1.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
        '
        'Ds_firm_garantes1
        '
        Me.Ds_firm_garantes1.DataSetName = "ds_firm_garantes"
        Me.Ds_firm_garantes1.EnforceConstraints = False
        Me.Ds_firm_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agendas_garantes1
        '
        Me.Ds_agendas_garantes1.DataSetName = "ds_agendas_garantes"
        Me.Ds_agendas_garantes1.EnforceConstraints = False
        Me.Ds_agendas_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_covegrou1
        '
        Me.Ds_covegrou1.DataSetName = "ds_covegrou"
        Me.Ds_covegrou1.EnforceConstraints = False
        Me.Ds_covegrou1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'Ds_prestaciones1
        '
        Me.Ds_prestaciones1.DataSetName = "ds_prestaciones"
        Me.Ds_prestaciones1.EnforceConstraints = False
        Me.Ds_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
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
        " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
        "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
        "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
        "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') AND (prod.prodco" & _
        "de LIKE 'DN%' or prod.prodcode = 'FA0001') OR (@agencode = 'LABO') AND (hpro.hpr" & _
        "oacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
        " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (proctita" & _
        ".agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on agen.age" & _
        "ncode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) AND (hpro." & _
        "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
        "Y')"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6, "agencode"))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bloque_horario", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT reso_key AS csta_key, resodesc AS cstadesclong FROM reso WHERE (tablcode =" & _
        " 'csta') and (reso_key in (7,2,21,101,1,102,126,51,13) or 1=1) ORDER BY resodesc" & _
        ""
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Ds_busca_huecos1
        '
        Me.Ds_busca_huecos1.DataSetName = "ds_busca_huecos"
        Me.Ds_busca_huecos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_horas_visita1
        '
        Me.Ds_horas_visita1.DataSetName = "ds_horas_visita"
        Me.Ds_horas_visita1.EnforceConstraints = False
        Me.Ds_horas_visita1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=NEPTUNO;packet size=4096;user id=sa;data source=""10.8.50.213"";pers" & _
        "ist security info=True;initial catalog=CSaludR;password=kampeon10"
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
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bloque_horario", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter10
        '
        Me.SqlDataAdapter10.SelectCommand = Me.SqlSelectCommand10
        Me.SqlDataAdapter10.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT firm_key, firmcode FROM firm WHERE (firm_keytabl = @pers_key) AND (tablcod" & _
        "e = 'pers')"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4, "firm_keytabl"))
        '
        'Ds_firm1
        '
        Me.Ds_firm1.DataSetName = "ds_firm"
        Me.Ds_firm1.EnforceConstraints = False
        Me.Ds_firm1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter11
        '
        Me.SqlDataAdapter11.SelectCommand = Me.SqlSelectCommand11
        Me.SqlDataAdapter11.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT firm_key FROM firm WHERE (firm_keytabl = @pers_key) AND (tablcode = 'pers'" & _
        ")"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4, "firm_keytabl"))
        '
        'Ds_firm2
        '
        Me.Ds_firm2.DataSetName = "ds_firm"
        Me.Ds_firm2.EnforceConstraints = False
        Me.Ds_firm2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_btimetab1
        '
        Me.Ds_btimetab1.DataSetName = "ds_btimetab"
        Me.Ds_btimetab1.EnforceConstraints = False
        Me.Ds_btimetab1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "acco", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("acco_key", "acco_key")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT acco_key FROM acco"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "LANGUAGE=Español;DSN=CSaludR;UID=sa;DATABASE=CSaludR;APP=Microsoft® Visual Studio" & _
        " .NET;WSID=MINERVA;PWD=kampeon10"
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "acco", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("acco_key", "acco_key")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT acco_key FROM acco"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
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
        Me.OdbcDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "acco", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("acco_key", "acco_key")})})
        '
        'OdbcSelectCommand3
        '
        Me.OdbcSelectCommand3.CommandText = "SELECT acco_key FROM acco"
        Me.OdbcSelectCommand3.Connection = Me.OdbcConnection1
        '
        'Ds_autorizaciones1
        '
        Me.Ds_autorizaciones1.DataSetName = "ds_autorizaciones"
        Me.Ds_autorizaciones1.EnforceConstraints = False
        Me.Ds_autorizaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter12
        '
        Me.SqlDataAdapter12.SelectCommand = Me.SqlSelectCommand12
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT hpro_key, id_agenda_garante FROM cima_prestaciones_autorizacion WHERE (hpr" & _
        "o_key = @hpro_key) AND (id_agenda_garante = @id_agenda_garante)"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection2
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, "hpro_key"))
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_agenda_garante", System.Data.SqlDbType.Int, 4, "id_agenda_garante"))
        '
        'SqlDataAdapter13
        '
        Me.SqlDataAdapter13.SelectCommand = Me.SqlSelectCommand13
        Me.SqlDataAdapter13.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_hpro_cetir", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Prova", "ID_Prova")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT ID_Prova, id_hpro_cetir, hpro_key FROM cima_hpro_cetir WHERE (hpro_key = @" & _
        "hpro_key)"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection2
        Me.SqlSelectCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, "hpro_key"))
        '
        'Ds_hpro_cetir1
        '
        Me.Ds_hpro_cetir1.DataSetName = "ds_hpro_cetir"
        Me.Ds_hpro_cetir1.EnforceConstraints = False
        Me.Ds_hpro_cetir1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_hoja_citacion1
        '
        Me.Ds_hoja_citacion1.DataSetName = "ds_hoja_citacion"
        Me.Ds_hoja_citacion1.EnforceConstraints = False
        Me.Ds_hoja_citacion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter14
        '
        Me.SqlDataAdapter14.SelectCommand = Me.SqlCommand1
        Me.SqlDataAdapter14.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_HOJA_CITACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("paciente", "paciente"), New System.Data.Common.DataColumnMapping("NHC", "NHC"), New System.Data.Common.DataColumnMapping("fecha_nacimiento", "fecha_nacimiento"), New System.Data.Common.DataColumnMapping("garante", "garante"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("hora", "hora")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "[SP_CIMACEX_HOJA_CITACION_EPIS_KEY]"
        Me.SqlCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@epis_key", System.Data.SqlDbType.Int, 4))
        '
        'SqlDataAdapter15
        '
        Me.SqlDataAdapter15.SelectCommand = Me.SqlSelectCommand14
        Me.SqlDataAdapter15.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "reso", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT reso_key AS csta_key, resodesc AS cstadesclong FROM reso WHERE (tablcode =" & _
        " 'csta') AND (reso_key IN (2,13)) ORDER BY resodesc"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
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
        "ode IN ('CE', 'RX', 'LA', 'UR', 'FA')) AND (agencode IN (SELECT agencode FROM CI" & _
        "MACEX.dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) AND (@firm_key <> " & _
        "0 AND @firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par FROM C" & _
        "IMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencod" & _
        "e_par = agen.agencode) OR @firm_key = 0) AND (agencode = 'DN' or agencode = 'FAR" & _
        "MA' or agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on ag" & _
        "en.agencode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) ORDE" & _
        "R BY agenname"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reso_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        '
        'Ds_episodios_multicitas1
        '
        Me.Ds_episodios_multicitas1.DataSetName = "ds_episodios_multicitas"
        Me.Ds_episodios_multicitas1.EnforceConstraints = False
        Me.Ds_episodios_multicitas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter16
        '
        Me.SqlDataAdapter16.SelectCommand = Me.SqlCommand2
        Me.SqlDataAdapter16.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_EPISODIOS_MULTICITAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("epis_key", "epis_key"), New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("clip_key", "clip_key"), New System.Data.Common.DataColumnMapping("tactdesc", "tactdesc"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("pati_hfn", "pati_hfn"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname"), New System.Data.Common.DataColumnMapping("episdatecrea", "episdatecrea"), New System.Data.Common.DataColumnMapping("episcstadateinit", "episcstadateinit"), New System.Data.Common.DataColumnMapping("episcstadate_end", "episcstadate_end"), New System.Data.Common.DataColumnMapping("episopen", "episopen")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "[SP_CIMACEX_EPISODIOS_MULTICITAS]"
        Me.SqlCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand2.Connection = Me.SqlConnection1
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        '
        'Ds_btimetab2
        '
        Me.Ds_btimetab2.DataSetName = "ds_btimetab"
        Me.Ds_btimetab2.EnforceConstraints = False
        Me.Ds_btimetab2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter17
        '
        Me.SqlDataAdapter17.SelectCommand = Me.SqlSelectCommand15
        Me.SqlDataAdapter17.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "btimetab", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("btimetabdesc", "btimetabdesc"), New System.Data.Common.DataColumnMapping("btimetabdateinit", "btimetabdateinit"), New System.Data.Common.DataColumnMapping("btimetabdate_end", "btimetabdate_end"), New System.Data.Common.DataColumnMapping("btimetabdaysweek", "btimetabdaysweek"), New System.Data.Common.DataColumnMapping("btimetabhour_end", "btimetabhour_end"), New System.Data.Common.DataColumnMapping("btimetabhourinit", "btimetabhourinit"), New System.Data.Common.DataColumnMapping("btimetab_maxpers", "btimetab_maxpers"), New System.Data.Common.DataColumnMapping("btimetabamou", "btimetabamou"), New System.Data.Common.DataColumnMapping("btimetabappointe", "btimetabappointe"), New System.Data.Common.DataColumnMapping("btimetabappoholi", "btimetabappoholi"), New System.Data.Common.DataColumnMapping("btimetabgran", "btimetabgran"), New System.Data.Common.DataColumnMapping("spdi_key", "spdi_key"), New System.Data.Common.DataColumnMapping("btimetabacti", "btimetabacti"), New System.Data.Common.DataColumnMapping("btimetabupda", "btimetabupda"), New System.Data.Common.DataColumnMapping("btimetabdefa", "btimetabdefa"), New System.Data.Common.DataColumnMapping("btimetabwarn", "btimetabwarn")})})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT agencode, btimetabcode, btimetabdesc, btimetabdateinit, btimetabdate_end, " & _
        "btimetabdaysweek, btimetabhour_end, btimetabhourinit, btimetab_maxpers, btimetab" & _
        "amou, btimetabappointe, btimetabappoholi, btimetabgran, spdi_key, btimetabacti, " & _
        "btimetabupda, btimetabdefa, btimetabwarn FROM btimetab WHERE (agencode = @agenco" & _
        "de) AND (btimetabacti = 'Y') ORDER BY btimetabdaysweek"
        Me.SqlSelectCommand15.Connection = Me.SqlConnection1
        Me.SqlSelectCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.Char, 6, "agencode"))
        '
        'SqlDataAdapter18
        '
        Me.SqlDataAdapter18.SelectCommand = Me.SqlSelectCommand16
        Me.SqlDataAdapter18.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_USUARIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")})})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = "[SP_CIMACEX_USUARIO]"
        Me.SqlSelectCommand16.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand16.Connection = Me.SqlConnection1
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agendas_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_busca_huecos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_horas_visita1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_autorizaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hpro_cetir1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hoja_citacion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_episodios_multicitas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_btimetab2, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_csta1 As cimaweb.ds_csta
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agen_tabla1 As cimaweb.ds_agen_tabla
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_firm_garantes1 As cimaweb.ds_firm_garantes
    Protected WithEvents Ds_agendas_garantes1 As cimaweb.ds_agendas_garantes
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_covegrou1 As cimaweb.ds_covegrou
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents fecha_ini As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_prestaciones1 As cimaweb.ds_prestaciones
    Protected WithEvents SqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_busca_huecos1 As cimaweb.ds_busca_huecos
    Protected WithEvents Ds_horas_visita1 As cimaweb.ds_horas_visita
    Protected WithEvents SqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel6 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter10 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_firm1 As cimaweb.ds_firm
    Protected WithEvents DropDownList8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter11 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_firm2 As cimaweb.ds_firm
    Protected WithEvents Dropdownlist9 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_btimetab1 As cimaweb.ds_btimetab
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_franja_horaria1 As cimaweb.ds_franja_horaria
    Protected WithEvents OdbcDataAdapter3 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_autorizaciones1 As cimaweb.ds_autorizaciones
    Protected WithEvents SqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter13 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_hpro_cetir1 As cimaweb.ds_hpro_cetir
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Ds_hoja_citacion1 As cimaweb.ds_hoja_citacion
    Protected WithEvents SqlDataAdapter14 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter15 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Ds_episodios_multicitas1 As cimaweb.ds_episodios_multicitas
    Protected WithEvents SqlDataAdapter16 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As WebControlCIMA.Buttons.ButtonEnviar
    Protected WithEvents Button3 As WebControlCIMA.Buttons.ButtonEnviar
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Checkbox2 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Checkbox3 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList10 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_btimetab2 As cimaweb.ds_btimetab
    Protected WithEvents SqlDataAdapter17 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel7 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList11 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter18 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_hoja_citacion As New cr_obj_hoja_citacion

    'JGM Variable per controlar canvi agenda o servei
    Dim aux_canvi As Boolean

    'Private service As New CGMServeiIntegracio.ServeiIntegracio
    Private service As New CIMAServeiIntegracio.ServeiIntegracio

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim ls_matriz() As String

        Dim ls_agencode, ls_doctor, ls_mutua, ls_covegrou_key, ls_pers_key As String
        Dim str_menu, str_menu_2, str_menu_3, str_menu_4 As String

        Dim ls_duracion() As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet
        Dim objDS_3 As New Data.DataSet
        Dim objDS_4 As New Data.DataSet

        Dim objRow As Data.DataRow
        Dim objRow_2 As Data.DataRow
        Dim objRow_3 As Data.DataRow

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

        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima", "98yREc37", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)
        'Dim user As New Microsoft.Web.Services2.Security.Tokens.UsernameToken("cima_proves", "86fGTp32", Microsoft.Web.Services2.Security.Tokens.PasswordOption.SendPlainText)

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

        'JGM Inicialitzem la primera vegada
        If IsPostBack = False Then
            aux_canvi = False
        End If

        'System.Net.ServicePointManager.CertificatePolicy = Nothing

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        'service.RequestSoapContext.Security.Tokens.Add(user)
        'service.RequestSoapContext.Security.Timestamp.TtlInSeconds = 60

        If IsPostBack = False And Request("ok_cita") <> "C" Then

            Session("transaccion") = Nothing

        End If

        If Session("requiere_autorizacion") = "S" Then

            Me.Label16.Visible = True

        Else

            Me.Label16.Visible = False

        End If

        If Me.DropDownList1.SelectedValue = "2" Then

            Session("entidad_pago") = "ICIMA"

            If Me.Dropdownlist3.SelectedValue = "78841" Then

                Session("entidad_pago") = "LFRA"

            End If

            If Me.Dropdownlist3.SelectedValue = "54243" Then

                Session("entidad_pago") = "MMCY"

            End If

            If Me.Dropdownlist3.SelectedValue = "110557" Then

                Session("entidad_pago") = "EGAR"

            End If

            If Me.Dropdownlist3.SelectedValue = "8904" Then

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

            End If

        Else

            Me.DropDownList8.Items.Clear()

            Me.DropDownList8.Items.Add(New ListItem("07:00", "07:00"))
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

                If Request("DropDownList8") = "00:00" Then

                    Me.DropDownList8.SelectedValue = "07:00"

                Else

                    Me.DropDownList8.SelectedValue = Request("DropDownList8")

                End If

            End If

        End If

        'Dim objCIMA As New CIMA_Clases.CIMA

        'Dim objDS As New Data.DataSet

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        Me.Panel4.Visible = False
        Me.Panel6.Visible = False

        If Me.fecha_ini.Text = "__/__/____" Then

            ls_matriz = Split(Today.ToString, " ", , CompareMethod.Text)
            Me.fecha_ini.Text = ls_matriz(0)
            Me.Textbox2.Text = ls_matriz(0)
            Me.Calendar1.SelectedDate = Today
            Me.Calendar2.SelectedDate = Today

        End If

        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then

            Me.Panel4.Visible = True
            Me.Panel6.Visible = True

        End If

        If Len(Trim(Request("pers_key_paciente"))) > 0 Then

            Session("pers_key_paciente") = Request("pers_key_paciente")

        Else

            If Len(Trim(Request("nombre"))) > 0 Or ((Request("ok_cita") = "S" Or Request("ok_cita") = "C") And Request("ok_control") <> "S") Then

            Else

                Session("pers_key_paciente") = ""

            End If

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

                If Session("pers_key_paciente") Is Nothing Or Session("pers_key_paciente") = "" Then

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

                    ls_mutua = Request("garante") 'Me.Label15.Text 'Request("firm_key")

                    If ls_mutua = "0" Then

                        If Len(Trim(Session("pers_key_paciente"))) > 0 Then

                            ls_mutua = CStr(PP(Session("pers_key_paciente")))

                        Else

                            ls_mutua = ""

                        End If

                    End If

                    If ls_mutua = "-1" Then

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")

                    Else

                        'If ls_mutua = "0" Then

                        'Me.SqlDataAdapter10.SelectCommand.Parameters(0).Value = Request("retorno_pers_key")

                        'Me.SqlConnection1.Open()
                        'Me.SqlDataAdapter10.Fill(Me.Ds_firm1.firm)
                        'Me.SqlConnection1.Close()

                        'ls_mutua = CStr(Me.Ds_firm1.firm(0).Item("firm_key"))

                        'End If

                        ls_covegrou_key = Request("covegrou_key")

                        ls_pers_key = Session("pers_key_paciente")

                        'Modificació JGM 15/02/2010
                        'Si el check de usuario mc está marcado, lo modificamos
                        If Request("mcmutual_usuario") = True Then
                            str_uid = "mcmutual.usuario"
                        End If
                        'Fi Modificació JGM 15/02/2010

                        If Len(Trim(str_uid)) > 0 Then

                            str_uid = str_uid

                        Else

                            str_uid = ""

                        End If

                        If Len(Trim(Session("epis_key_padre"))) > 0 And Trim(Session("epis_key_padre")) <> "0" Then

                            'JGM 04/02/2011 Passem el nou paràmetre NHC Marqués
                            str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_CON_PADRE] '" & Request("fecha_cita") & "','" & ls_agencode & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Request("btimetabcode") & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "'," & Session("epis_key_padre") & ",'" & Request("nhc_marques") & "','" & Request("origen_marques") & "'"

                            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        Else

                            'JGM 04/02/2011 Passem el nou paràmetre NHC Marqués
                            str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA] '" & Request("fecha_cita") & "','" & ls_agencode & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Request("btimetabcode") & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "','" & Request("nhc_marques") & "','" & Request("origen_marques") & "'"

                            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        End If

                        ''' Conexión con otros back-offices.

                        'If Trim(ls_agencode) = "BOZA" Or Trim(ls_agencode) = "SOLE" Or Trim(ls_agencode) = "SOLER" Or Trim(ls_agencode) = "GUIL" Or Trim(ls_agencode) = "BODET" Or Trim(ls_agencode) = "FUERTE" Or Trim(ls_agencode) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

                        '    str_menu_2 = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & Session("pers_key_paciente") & ""

                        '    objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        '    contador = 0

                        '    For Each objRow_2 In objDS_2.Tables(0).Rows

                        '        contador = contador + 1

                        '        If contador = 1 Then

                        '            ds_cita_persRow_idermalia("pers_key") = CInt(ls_pers_key)
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

                        '            ds_cita_persRow_dermas("pers_key") = CInt(ls_pers_key)
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

                        '    Select Case Trim(ls_agencode)
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
                        '    ds_cita_citaRow_idermalia("pers_key") = CInt(ls_pers_key)
                        '    ds_cita_citaRow_idermalia("epis_key") = CInt(objDS.Tables(0).Rows(0).Item("epis_key"))

                        '    lds_alta_cita_idermalia.cita.Rows.Add(ds_cita_citaRow_idermalia)

                        '    ds_cita_citaRow_dermas("id_centro") = 1
                        '    ds_cita_citaRow_dermas("agencode") = ls_agencode_traspaso
                        '    ds_cita_citaRow_dermas("id_prestacion") = li_prestacion
                        '    ds_cita_citaRow_dermas("dia") = CDate(Request("fecha_cita"))
                        '    ds_cita_citaRow_dermas("hora_ini") = CDate("01/01/1900 " & Request("hora_inicial"))
                        '    ds_cita_citaRow_dermas("hora_fin") = CDate("01/01/1900 " & Request("hora_final"))
                        '    ds_cita_citaRow_dermas("id_garante") = 19
                        '    ds_cita_citaRow_dermas("id_agen_franja") = 0
                        '    ds_cita_citaRow_dermas("pers_key") = CInt(ls_pers_key)
                        '    ds_cita_citaRow_dermas("epis_key") = CInt(objDS.Tables(0).Rows(0).Item("epis_key"))

                        '    lds_alta_cita_dermas.cita.Rows.Add(ds_cita_citaRow_dermas)

                        '    lidermalia_ws.AltaCita("cima.ws", "Idermalia1", lds_alta_cita_idermalia)
                        '    ldermas_ws.AltaCita("cima.ws", "Dermas10", lds_alta_cita_dermas)

                        'End If

                        ''' Fin de la conexión.

                        'Dim objConn As New Odbc.OdbcConnection

                        'Dim objCommand As New Odbc.OdbcCommand



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

                        'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                        Session("pers_key_paciente") = ""
                        Session("epis_key_padre") = ""
                        Me.Label17.Text = ""

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Cita REGISTRADA con éxito.');" & vbCrLf)
                        'response.Write("f_abre(""../reports/cr_hoja_citacion.aspx?episcode=" & & """,600,900,"""");" & vbcrlf)
                        'Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                        Response.Write("</scr" & "ipt>" & vbCrLf)

                        'JGM Modificació 09/06/2010 - Si tenim marcar el generar codi web ho fem
                        If objDS.Tables(0).Rows.Count > 0 And (Request("hoja_citacion") = True Or Request("codigo_web") = True) Then

                            'generar_hoja_citacion(objDS.Tables(0).Rows(0).Item(0))

                            'JGM Modificació 09/06/2010 Si marquem la fulla citació
                            If Request("hoja_citacion") = True Then
                                Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                Response.Write("var control=2;" & vbCrLf)
                                Response.Write("f_abre(""../reports/cr_hoja_citacion.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,900,"""");" & vbCrLf)
                                'Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                                Response.Write("</scr" & "ipt>" & vbCrLf)
                            End If

                            'JGM Modificació 09/06/2010 Si marquem generació codi web
                            If Request("codigo_web") = True Then
                                Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                Response.Write("var control=2;" & vbCrLf)
                                Response.Write("f_abre(""../formularios/form_generar_codigo_web.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,830,"""");" & vbCrLf)
                                Response.Write("</scr" & "ipt>" & vbCrLf)
                            End If

                        Else

                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                            Response.Write("</scr" & "ipt>" & vbCrLf)

                        End If

                        'Response.Redirect("form_citas_rapidas.aspx")

                    End If

                End If

            End If

        End If

        If Request("ok_cita") = "C" And Request("ok_control") <> "S" Then

            ''''''''''''''''''

            If Len(Request("covegrou_key")) = 0 Or Request("covegrou_key") Is Nothing Then

                ' Par no definido o definido incorrectamente.

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert(""Par no definido o definido incorrectamente. Contacte con Administración."");" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                If Session("pers_key_paciente") Is Nothing Or Session("pers_key_paciente") = "" Then

                    ' Falta especificar el paciente.

                    Response.Write("<scr" & "ipt>" & vbCrLf)
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

                    ls_mutua = Request("garante")

                    If ls_mutua = "0" Then

                        If Len(Trim(Session("pers_key_paciente"))) > 0 Then

                            ls_mutua = CStr(PP(Session("pers_key_paciente")))

                        Else

                            ls_mutua = ""

                        End If

                    End If

                    If ls_mutua = "-1" Then

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")

                    Else

                        ldt_hora_ini = Request("fecha_hora")
                        ldt_hora_fin = DateAdd(DateInterval.Minute, CInt(Request("duracion")), ldt_hora_ini)

                        If ldt_hora_ini >= ldt_hora_fin Then

                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Lo sentimos, la hora de inicio no puede ser igual o mayor que la hora de finalización.');" & vbCrLf)
                            Response.Write("</scr" & "ipt>")

                        Else

                            ls_covegrou_key = Request("covegrou_key")

                            ls_pers_key = Session("pers_key_paciente")


                            If Len(Trim(str_uid)) > 0 Then

                                str_uid = str_uid

                            Else

                                str_uid = ""

                            End If

                            '''''''''''

                            str_menu = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & Session("pers_key_paciente") & ""

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

                            '''''''''''

                            Select Case Trim(Request("btimetabcode"))

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

                            ls_fecha_cita = CStr(DatePart(DateInterval.Day, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Month, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Year, ldt_hora_ini))

                            ls_array = Split(Request("prestacion"), "/", , CompareMethod.Text)

                            lcima_cita = service.ConfirmarHoraPacient(Session("transaccion").ID, True, lcima_paciente, Session("horas_reservadas")(Request("id_cita")))

                            'Modificació JGM 15/02/2010
                            'Si el check de usuario mc está marcado, lo modificamos
                            If Request("mcmutual_usuario") = True Then
                                str_uid = "mcmutual.usuario"
                            End If
                            'Fi Modificació JGM 15/02/2010

                            If Len(Trim(Session("epis_key_padre"))) > 0 And Trim(Session("epis_key_padre")) <> "0" Then

                                'JGM 04/02/2011 pel cas de cetir, passem el paràmetre a blancs
                                str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_CON_PADRE] '" & ls_fecha_cita & "','" & Request("agencode") & "','" & CStr(DatePart(DateInterval.Hour, ldt_hora_ini)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_ini)) & ":00','" & CStr(DatePart(DateInterval.Hour, ldt_hora_fin)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_fin)) & ":00'," & Request("duracion") & "," & ls_btimetabcode & "," & Mid(ls_array(1), 1, ls_array(1).Length - 1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "'," & Session("epis_key_padre") & ",'',''"

                                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                            Else

                                'JGM 04/02/2011 pel cas de cetir, passem el paràmetre a blancs
                                str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA] '" & ls_fecha_cita & "','" & Request("agencode") & "','" & CStr(DatePart(DateInterval.Hour, ldt_hora_ini)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_ini)) & ":00','" & CStr(DatePart(DateInterval.Hour, ldt_hora_fin)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_fin)) & ":00'," & Request("duracion") & "," & ls_btimetabcode & "," & Mid(ls_array(1), 1, ls_array(1).Length - 1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "','',''"

                                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                            End If

                            ls_episcode = objDS.Tables(0).Rows(0).Item(1)

                            service.AssociarCitaCGMEpisodiExtern(Session("transaccion").ID, True, lcima_cita.ID_CGM, True, ls_episcode)

                            l_transaccion_retorno = service.CommitTransaccio(Session("transaccion").ID, True)

                            'JGM 22/02/2011
                            'Damos de alta la clave de cetir
                            str_menu_4 = "[dbo].[SP_CIMACEX_ALTA_CLAVE_CETIR] '" & ls_episcode & "'," & lcima_cita.ID_CGM & "," & CInt(lcima_paciente.ID_Pacient_Extern)

                            objDS_4 = objCIMA.f_consulta_CSaludR(str_menu_4, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")
                            'Fi JGM 22/02/2011

                            ls_cadena = "episcode=" & ls_episcode & "#Forzada=N#" & "ID_CGM=" & CStr(lcima_cita.ID_CGM) & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

                            str_menu_3 = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','ACI'"

                            objDS_3 = objCIMA.f_consulta_CSaludR(str_menu_3, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")

                            l_transaccion_retorno = Nothing

                            Session("transaccion") = Nothing

                            Session("horas_reservadas") = Nothing

                            Session("pers_key_paciente") = ""

                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Cita REGISTRADA con éxito.');" & vbCrLf)
                            Response.Write("</scr" & "ipt>" & vbCrLf)

                            'JGM Modificació 09/06/2010 Si marquem la fulla de citació o generar codi WEB
                            If objDS.Tables(0).Rows.Count > 0 And (Request("hoja_citacion") = True Or Request("codigo_web") = True) Then

                                'JGM Modificació 09/06/2010 Si marquem la fulla citació
                                If Request("hoja_citacion") = True Then
                                    Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                    Response.Write("<scr" & "ipt>" & vbCrLf)
                                    Response.Write("var control=2;" & vbCrLf)
                                    Response.Write("f_abre(""../reports/cr_hoja_citacion.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,900,"""");" & vbCrLf)
                                    Response.Write("</scr" & "ipt>" & vbCrLf)
                                End If

                                'JGM Modificació 09/06/2010 Si marquem generació codi web
                                If Request("codigo_web") = True Then
                                    Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                    Response.Write("<scr" & "ipt>" & vbCrLf)
                                    Response.Write("var control=2;" & vbCrLf)
                                    Response.Write("f_abre(""../formularios/form_generar_codigo_web.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,830,"""");" & vbCrLf)
                                    Response.Write("</scr" & "ipt>" & vbCrLf)
                                End If

                            Else

                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                                Response.Write("</scr" & "ipt>" & vbCrLf)

                            End If

                        End If


                    End If

                End If

                ''''''''''''''''''

            End If

            'str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA] '" & Request("fecha_cita") & "','" & Session("agencode") & "','" & Request("hora_inicial") & ":00','" & Request("hora_final") & ":00'," & ls_duracion(0) & "," & Me.DropDownList1.SelectedValue.ToString & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico

        End If

    End Sub

    Private Sub generar_hoja_citacion(ByVal epis_key As Integer)

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String



        Me.Ds_hoja_citacion1.Clear()

        Me.SqlDataAdapter14.SelectCommand.Parameters(1).Value = epis_key

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter14.Fill(Me.Ds_hoja_citacion1.SP_CIMACEX_HOJA_CITACION)

        Me.SqlConnection1.Close()

        objCR_rpt_hoja_citacion.SetDataSource(Me.Ds_hoja_citacion1)

        Me.CrystalReportViewer1.ReportSource = objCR_rpt_hoja_citacion

        Me.CrystalReportViewer1.DataBind()

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".doc"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_hoja_citacion.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.WordForWindows '.PortableDocFormat

        objCR_rpt_hoja_citacion.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/octet-stream"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() + ".doc" & """")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        actualizar()

    End Sub

    Public Sub actualizar()

        Dim str_uid As String

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS_USR As New Data.DataSet



        str_uid = Request.Cookies("usuario").Value

        Session("usuario") = str_uid

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.sp_permiso '" & Trim(str_uid) & "'"

        objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        Session("grupo") = objDS_USR.Tables(0).Rows(0).Item(0)

        objDS_USR = Nothing

        If Session("grupo") = "U" Or Session("grupo") = "G" Or Session("grupo") = "W" Or Session("grupo") = "I" Then

            Me.RadioButton2.Visible = False
            Me.Button4.Visible = False
            Me.Label19.Visible = False

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter15.Fill(Me.Ds_csta1.csta)
            Me.SqlConnection1.Close()

        Else

            If Session("grupo") = "A" Or Session("grupo") = "M" Then

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter18.SelectCommand.Parameters(1).Value = str_uid
                Me.SqlDataAdapter18.Fill(Me.Ds_csta1.csta)
                Me.SqlConnection1.Close()

            Else

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter1.Fill(Me.Ds_csta1.csta)
                Me.SqlConnection1.Close()

            End If

            Me.Label19.Text = "Episodio PADRE: "

        End If

        'Modificació JGM 15/02/2010 -Si el usuario es del tipo "administración" 
        ' o "administrador" podrá modificar el usuario como Mc-Mutual
        If Session("grupo") = "A" Or Session("grupo") = "D" Or Session("grupo") = "M" Then
            Me.Label20.Visible = True
            Me.Checkbox2.Visible = True
            'Modificació JGM 09/06/2010 - 
            'El checkbox de generar codi web només per aquests grups
            Me.Label21.Visible = True
            Me.Checkbox3.Visible = True
        Else
            Me.Label20.Visible = False
            Me.Checkbox2.Visible = False
            Me.Label21.Visible = False
            Me.Checkbox3.Visible = False
        End If
        'Fi Modificació JGM 15/02/2010

        'JGM Modificació 15/05/2012 si els usuaris són 'meritxell.sanjuan' o 'tania.navas' que apareguin totes
        If Trim(str_uid) <> "meritxell.sanjuan" And Trim(str_uid) <> "ana.herrera" And Trim(str_uid) <> "tania.navas" And Trim(str_uid) <> "jordi.gonzalez" And Trim(str_uid) <> "mari.sanchez" And Trim(str_uid) <> "juancarlos.pachon" Then
            'JGM Modificació 27/03/2012 -- Només deixem el servei de RADIOLOGIA Agenda DENSITOMETRIA
            Me.Ds_csta1.csta.Clear()
            Me.Ds_csta1.csta.AddcstaRow(2, 0, 0, "", 0, "", "RADIOLOGIA", "", "", "")
            Me.Ds_csta1.csta.AddcstaRow(51, 0, 0, "", 0, "", "FARMACIA", "", "", "")
            Me.Ds_csta1.csta.AddcstaRow(13, 0, 0, "", 0, "", "GINECOLOGIA/OBSTETRICIA", "", "", "")
            'JGM Fi Modificació 27/03/2012
        End If
        'JGM Fi Modificació 15/05/2012

        Me.DropDownList1.DataBind()

        Me.DropDownList1.Items.Insert(0, "")


        If Len(Trim(Request("DropDownList1"))) > 0 Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

        End If

        If Session("grupo") = "U" Then

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
                    "guar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') AND firm.firm_key = 54243 ORDER BY firm.f" & _
                    "irmname"

        End If

        If Session("grupo") = "W" Then

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
                    "guar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') AND firm.firm_key = 17161 ORDER BY firm.f" & _
                    "irmname"

        End If

        If Session("grupo") = "I" Then

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
                    "guar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') AND firm.firm_key = 6036 ORDER BY firm.f" & _
                    "irmname"

        End If

        Me.SqlConnection1.Open()
        'JGM -- Afegim el control de les mutues
        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then
            Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue
        Else
            Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = ""
        End If
        Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes1.firm)
        Me.SqlConnection1.Close()

        Me.Dropdownlist3.DataBind()

        If Session("grupo") <> "U" And Session("grupo") <> "W" Then

            Me.Dropdownlist3.Items.Insert(0, "PRIVADO")

        End If

        If Session("grupo") = "I" Then
            Me.Dropdownlist3.SelectedValue = 6036
        End If

        'JGM només mantemin la mutua si no ha canviat ni l'agenda ni el servei.
        ' Farem servir una variable de control
        If Len(Trim(Request("DropDownList3"))) > 0 And aux_canvi = False Then

            Me.Dropdownlist3.SelectedValue = Request("DropDownList3")
            aux_canvi = False
        End If

        'JGM 04/02/2011 Si l'agenda és laboratori, visualitzem el panel7 per introduir el NHC de Marqués
        If Me.DropDownList1.SelectedValue = "7" Then
            Me.Panel7.Visible = True
        Else
            Me.Panel7.Visible = False
            Me.TextBox4.Text = ""
        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Dim str_uid As String

        'JGM Actualitzem la variable de control 
        aux_canvi = True
        If Session("grupo") = "U" Then
            Me.Dropdownlist3.SelectedValue = 54243
        ElseIf Session("grupo") = "W" Then
            Me.Dropdownlist3.SelectedValue = 17161
        ElseIf Session("grupo") = "I" Then
            Me.Dropdownlist3.SelectedValue = 6036
        Else
            Me.Dropdownlist3.SelectedValue = "PRIVADO"
        End If

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

        'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
        If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
            Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss " & _
                                    "FROM agen WHERE (agenacti = 'Y') AND (cent_key = 1) AND " & _
                                    "(agencode IN (SELECT resoagen.agencode FROM resoagen WHERE resoagen.reso_key = @reso_key AND resoagen.tablcode = 'csta')) " & _
                                    "AND (agentypecode IN ('CE', 'RX', 'LA', 'UR', 'FA')) AND " & _
                                    "(agencode IN (SELECT agencode FROM CIMACEX.dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) " & _
                                    "AND (@firm_key <> 0 AND @firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par " & _
                                    "FROM CIMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencode_par = agen.agencode) " & _
                                    "OR @firm_key = 0) " & _
                                    "ORDER BY agenname"
        Else
            Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss " & _
                                                "FROM agen WHERE (agenacti = 'Y') AND (cent_key = 1) AND " & _
                                                "(agencode IN (SELECT resoagen.agencode FROM resoagen WHERE resoagen.reso_key = @reso_key AND resoagen.tablcode = 'csta')) " & _
                                                "AND (agentypecode IN ('CE', 'RX', 'LA', 'UR', 'FA')) AND " & _
                                                "(agencode IN (SELECT agencode FROM CIMACEX.dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) " & _
                                                "AND (@firm_key <> 0 AND @firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par " & _
                                                "FROM CIMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencode_par = agen.agencode) " & _
                                                "OR @firm_key = 0) AND (agencode = 'DN' or agencode = 'FARMA' or agencode in " & _
                                                "(SELECT resoagen.agencode FROM resoagen inner join agen on agen.agencode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) " & _
                                                "ORDER BY agenname"
        End If
        'JGM Fi Modificació 15/05/2012


        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist5.DataBind()

        Me.Dropdownlist5.Items.Insert(0, "")

        Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = ""
        'JGM -- Afegim el nou paràmetre
        Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = -1
        'Fi JGM

        'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
        If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
            Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
      "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
      "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
      "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
      " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
      " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
      "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
      "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
      "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') " & _
      " OR (@agencode = 'LABO') AND (hpro.hproacti = 'Y') " & _
      " AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
      " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (hpro." & _
      "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
      "Y')"
        Else
            Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
      "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
      "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
      "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
      " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
      " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
      "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
      "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
      "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') AND (prod.prodco" & _
      "de LIKE 'DN%' or prod.prodcode = 'FA0001') OR (@agencode = 'LABO') AND (hpro.hpr" & _
      "oacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
      " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (proctita" & _
      ".agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on agen.age" & _
      "ncode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) AND (hpro." & _
      "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
      "Y')"
        End If
        'JGM Fi Modificació 15/05/2012


        Me.SqlConnection1.Open()
        Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
        Me.SqlConnection1.Close()

        Me.Dropdownlist4.DataBind()


        Me.Dropdownlist4.Items.Insert(0, "")

        Me.Dropdownlist4.SelectedValue = ""

        Session("requiere_autorizacion") = "N"

        Me.Label16.Visible = False

        'Me.Ds_firm_garantes1.Clear()

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter4.Fill(Me.Ds_firm_garantes1.firm)
        'Me.SqlConnection1.Close()

        'Me.Dropdownlist3.DataBind()

        'Me.Dropdownlist3.SelectedValue = ""

        Me.Dropdownlist6.DataBind()

        'Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT * FROM btimetab where agencode = '" & Me.Dropdownlist5.SelectedValue & "' and '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0"

        'Me.OdbcDataAdapter1.Fill(Me.Ds_btimetab1.btimetab)

        'Me.OdbcConnection1.Close()

        Me.Ds_btimetab1.btimetab.Clear()

        Me.Dropdownlist9.DataBind()

        Me.Textbox3.Text = ""

        Me.Dropdownlist7.Items.Clear()

        Me.Panel1.Visible = False

        Me.Panel4.Visible = False
        Me.Panel6.Visible = False

        Session("id_agenda_garante") = ""

        If Me.DropDownList1.SelectedValue = "2" Then

            Me.DropDownList8.SelectedValue = "00:00"

        Else

            Me.DropDownList8.SelectedValue = "07:00"

        End If

    End Sub

    Private Sub Dropdownlist3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist3.SelectedIndexChanged

        Dim ls_agencode As String
        Dim li_firm_key As Integer
        Dim str_uid As String

        Me.Label13.Visible = False
        Me.Label12.Visible = False
        Me.Label7.Visible = False
        Me.Dropdownlist6.Visible = False

        'JGM -- Tornem a recarregar les agendes
        str_uid = Request.Cookies("usuario").Value

        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = str_uid

        If Me.Dropdownlist3.SelectedValue = "PRIVADO" Then
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = 0
        Else
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = Me.Dropdownlist3.SelectedValue
        End If

        'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
        If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
            Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss " & _
                                    "FROM agen WHERE (agenacti = 'Y') AND (cent_key = 1) AND " & _
                                    "(agencode IN (SELECT resoagen.agencode FROM resoagen WHERE resoagen.reso_key = @reso_key AND resoagen.tablcode = 'csta')) " & _
                                    "AND (agentypecode IN ('CE', 'RX', 'LA', 'UR', 'FA')) AND " & _
                                    "(agencode IN (SELECT agencode FROM CIMACEX.dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) " & _
                                    "AND (@firm_key <> 0 AND @firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par " & _
                                    "FROM CIMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencode_par = agen.agencode) " & _
                                    "OR @firm_key = 0) " & _
                                    "ORDER BY agenname"
        Else
            Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT agencode, agenname, agenautodoss " & _
                                                "FROM agen WHERE (agenacti = 'Y') AND (cent_key = 1) AND " & _
                                                "(agencode IN (SELECT resoagen.agencode FROM resoagen WHERE resoagen.reso_key = @reso_key AND resoagen.tablcode = 'csta')) " & _
                                                "AND (agentypecode IN ('CE', 'RX', 'LA', 'UR', 'FA')) AND " & _
                                                "(agencode IN (SELECT agencode FROM CIMACEX.dbo.cima_usuarios_agen WHERE id_usuario = @id_usuario)) " & _
                                                "AND (@firm_key <> 0 AND @firm_key IN (SELECT CIMACEX.dbo.cima_agendas_garantes.firm_key_par " & _
                                                "FROM CIMACEX.dbo.cima_agendas_garantes WHERE CIMACEX.dbo.cima_agendas_garantes.agencode_par = agen.agencode) " & _
                                                "OR @firm_key = 0) AND (agencode = 'DN' or agencode = 'FARMA' or agencode in " & _
                                                "(SELECT resoagen.agencode FROM resoagen inner join agen on agen.agencode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) " & _
                                                "ORDER BY agenname"
        End If
        'JGM Fi Modificació 15/05/2012

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist5.DataBind()
        Me.Dropdownlist5.Items.Insert(0, "")

        If Len(Trim(Request("Dropdownlist5"))) > 0 Then
            Me.Dropdownlist5.SelectedValue = Request("Dropdownlist5")
        End If

        'Fi JGM

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

                If Len(Trim(Session("pers_key_paciente"))) > 0 Then

                    Me.Label15.Text = PP(Session("pers_key_paciente"))

                Else

                    Me.Label15.Text = "0"

                End If

            Else

                Me.Label13.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firmname")
                Me.Label15.Text = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key")

            End If


            Me.Panel1.Visible = True

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

            Me.Dropdownlist4.SelectedValue = ""

            Session("requiere_autorizacion") = "N"

            Me.Label16.Visible = False

        End If

    End Sub

    Public Function PP(ByVal ai_pers_key As Integer) As Integer

        Me.SqlDataAdapter11.SelectCommand.Parameters(0).Value = ai_pers_key

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter11.Fill(Me.Ds_firm2.firm)
        Me.SqlConnection1.Close()

        If Me.Ds_firm2.firm.Rows.Count > 0 Then

            PP = CInt(Me.Ds_firm2.firm.Rows(0).Item("firm_key"))

        Else

            PP = -1

        End If

    End Function

    Private Sub Dropdownlist5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist5.SelectedIndexChanged

        Dim ls_agencode As String
        Dim li_firm_key As Integer
        Dim str_uid As String

        str_uid = Request.Cookies("usuario").Value


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

                If Len(Trim(Session("pers_key_paciente"))) > 0 Then

                    Me.Label15.Text = PP(Session("pers_key_paciente"))

                Else

                    Me.Label15.Text = "0"

                End If

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

            Me.Label16.Visible = False

            Me.SqlDataAdapter9.SelectCommand.Parameters(1).Value = Me.Dropdownlist5.SelectedValue

            Me.SqlConnection3.Open()
            Me.SqlDataAdapter9.Fill(Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA)
            Me.SqlConnection3.Close()

            Me.Label11.Visible = True

            If Len(Trim(Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA.Rows(0).Item("nombre"))) > 0 Then

                Me.Label11.Text = Me.Ds_horas_visita1.SP_CIMACEX_HORAS_VISITA.Rows(0).Item("nombre")
                Me.Panel4.Visible = True
                Me.Panel6.Visible = True

                'JGM Afegim el desplegable dels blocs horaris.
                Me.SqlConnection3.Open()
                Me.SqlDataAdapter17.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue
                Me.SqlDataAdapter17.Fill(Me.Ds_btimetab2.btimetab)
                Me.DropDownList10.DataBind()
                Me.SqlConnection3.Close()

                Me.DropDownList10.Items.Insert(0, "--TODOS--")


            Else

                Me.Panel4.Visible = False
                Me.Panel6.Visible = False

            End If

            Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = ls_agencode
            'JGM -- Afegim el nou paràmetre
            If Me.DropDownList10.SelectedValue = "--TODOS--" Then
                Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = -1
            Else
                If Len(Trim(Me.DropDownList10.SelectedValue)) > 0 Then
                    Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = Me.DropDownList10.SelectedValue
                Else
                    Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = -1
                End If
            End If
            'Fi JGM

            'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
            If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
                Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
          "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
          "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
          "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
          " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
          " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
          "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
          "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
          "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') " & _
          " OR (@agencode = 'LABO') AND (hpro.hproacti = 'Y') " & _
          " AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
          " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (hpro." & _
          "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
          "Y')"
            Else
                Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
          "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
          "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
          "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
          " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
          " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
          "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
          "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
          "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') AND (prod.prodco" & _
          "de LIKE 'DN%' or prod.prodcode = 'FA0001') OR (@agencode = 'LABO') AND (hpro.hpr" & _
          "oacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
          " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (proctita" & _
          ".agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on agen.age" & _
          "ncode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) AND (hpro." & _
          "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
          "Y')"
            End If
            'JGM Fi Modificació 15/05/2012


            Me.SqlConnection1.Open()
            Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
            Me.SqlConnection1.Close()

            Me.Dropdownlist4.DataBind()

            Me.Dropdownlist4.Items.Insert(0, "")

            Me.Dropdownlist4.SelectedValue = ""

            Session("requiere_autorizacion") = "N"

            If Me.RadioButton2.Checked = True Then

                calcular_franja()

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

    Public Sub calcular_franja()

        Dim ls_array() As String



        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 And Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

            If IsDate(Me.Textbox2.Text) = True Then

                If IsDate(Me.Calendar2.SelectedDate) = True Then

                    Select Case Weekday(Me.Calendar2.SelectedDate) 'Weekday(Session("dia_calendario")) 'Weekday(Request("dia_seleccionado"))
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

                    ls_array = Split(Me.Dropdownlist4.SelectedValue.ToString, "/")

                    Me.OdbcConnection1.Open()

                    Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT * FROM btimetab INNER JOIN proctita on proctita.agencode=btimetab.agencode and proctita.btimetabcode = btimetab.btimetabcode and proctitaacti = 'Y' and proctita.hpro_key = " & CStr(ls_array(1)) & " where btimetab.btimetabacti = 'Y' and btimetab.agencode = '" & Me.Dropdownlist5.SelectedValue & "' and '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0"

                    Me.OdbcDataAdapter1.Fill(Me.Ds_btimetab1.btimetab)

                    Me.OdbcConnection1.Close()

                    Me.Dropdownlist9.DataBind()

                    '-----------

                    Dim n As Integer

                    If Len(Trim(Me.Dropdownlist9.SelectedValue.ToString)) > 0 Then

                        Me.Ds_prestaciones1.prestaciones.Clear()

                        Me.OdbcConnection1.Open()

                        Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT ltrim(rtrim(hpro.hprodesclong)) + ' - ' + cast(proctita.proctitadura as varchar) + ' min' as 'Descripción', cast(proctita.proctitadura as varchar) + '/' + cast(hpro.hpro_key as varchar) as 'Tiempo' " & _
                        "FROM hpro, proctita, btimetab " & _
                        "WHERE ( proctita.hpro_key = hpro.hpro_key ) and " & _
                        "( btimetab.btimetabcode = proctita.btimetabcode ) and ( proctita.agencode = btimetab.agencode ) and " & _
                        "( ( proctita.agencode = '" & Me.Dropdownlist5.SelectedValue & "' ) AND  " & _
                        "( hpro.hproacti = 'Y' ) AND  " & _
                        "( proctita.proctitaacti = 'Y' ) ) AND  btimetab.btimetabacti = 'Y' " & _
                        "AND '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end " & _
                        "AND btimetab.btimetabcode = " & Me.Dropdownlist9.SelectedValue.ToString & " and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 " & _
                        "ORDER BY hpro.hprodesclong"

                        Me.OdbcDataAdapter2.Fill(Me.Ds_prestaciones1.prestaciones)

                        Me.OdbcConnection1.Close()

                        If Me.Ds_prestaciones1.prestaciones.Rows.Count > 0 Then

                        Else

                            Me.Ds_prestaciones1.prestaciones.Clear()

                        End If


                        '''''''''''Me.Dropdownlist4.DataBind()

                        'For n = 0 To Me.Dropdownlist2.Items.Count - 1
                        'If Me.Dropdownlist2.Items(n).Value = Request("DropDownList2") Then
                        '    Me.Dropdownlist2.SelectedValue = Request("DropDownList2")
                        'End If
                        'Next

                        Me.Ds_franja_horaria1.Clear()

                        'For n = 0 To Me.DropDownList1.Items.Count - 1
                        'If Me.DropDownList1.Items(n).Value = Request("DropDownList1") Then
                        'Me.DropDownList1.SelectedValue = Request("DropDownList1")
                        'End If
                        'Next

                        Me.OdbcConnection1.Open()

                        Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT DATEPART (hh,btimetabhourinit) as hora_inicio, DATEPART (mi,btimetabhourinit) as minuto_inicio,DATEPART (hh,btimetabhour_end) as hora_fin,DATEPART (mi,btimetabhour_end) as minuto_fin, btimetabgran FROM btimetab where agencode = '" & Me.Dropdownlist5.SelectedValue & "' and '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 and btimetabcode = " & Me.Dropdownlist9.SelectedValue.ToString

                        Me.OdbcDataAdapter3.Fill(Me.Ds_franja_horaria1.franja_horaria)

                        If Me.Ds_franja_horaria1.franja_horaria.Count > 0 Then

                            montar_desplegable(Me.Ds_franja_horaria1.franja_horaria.Rows(0))

                        End If

                        Me.OdbcConnection1.Close()

                    Else

                        Me.Ds_prestaciones1.prestaciones.Clear()

                        'Me.Dropdownlist4.SelectedValue = ""

                        '''''''''''Me.Dropdownlist4.DataBind()

                        Me.Ds_btimetab1.btimetab.Clear()

                        Me.Dropdownlist9.DataBind()

                        Me.Textbox3.Text = ""

                        Me.Dropdownlist7.Items.Clear()

                    End If

                    '-----------

                Else

                    'Response.Write("<script language=javascript>alert(""Falta especificar un día válido."");</script>")

                End If

            Else

                'Response.Write("<script language=javascript>alert(""Falta especificar un día válido."");</script>")

            End If

        Else

            Me.Ds_prestaciones1.prestaciones.Clear()

            'Me.Dropdownlist4.SelectedValue = ""

            '''''''''''''''Me.Dropdownlist4.DataBind()

            Me.Ds_btimetab1.btimetab.Clear()

            Me.Dropdownlist9.DataBind()

            Me.Textbox3.Text = ""

            Me.Dropdownlist7.Items.Clear()

            'Response.Write("<script language=javascript>alert(""Falta especificar una agenda."");</script>")

        End If

        'Me.Dropdownlist9.SelectedValue = Request("Dropdownlist9")

    End Sub

    Public Sub montar_desplegable(ByVal objRow As ds_franja_horaria.franja_horariaRow)

        Dim li_hora, li_minuto As Integer
        Dim li_gran As Integer

        Dim li_hora_ini, li_hora_fin As Integer

        Dim lb_primera As Boolean



        'li_gran = objRow.Item(4)
        Me.Textbox3.Text = ""

        li_hora = objRow.Item(0)
        li_minuto = objRow.Item(1)

        lb_primera = True

        li_hora_ini = li_hora * 60 + li_minuto
        li_hora_fin = objRow.Item(2) * 60 + objRow.Item(3)

        Me.Dropdownlist7.Items.Clear()

        While li_hora_ini <= li_hora_fin

            If lb_primera = False Then

                Me.Dropdownlist7.Items.Add(formatear_minutos(CStr(li_hora)) & ":" & formatear_minutos(CStr(li_minuto)))
                li_minuto = li_minuto + 5

            Else

                Me.Dropdownlist7.Items.Add("")

            End If


            'If li_minuto Mod 60 = 0 And lb_primera = False Then
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

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged

        Me.Textbox2.Text = Me.Calendar2.SelectedDate.ToShortDateString.ToString
        Me.Calendar2.Visible = False

        calcular_franja()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        Dim str_uid As String

        str_uid = Request.Cookies("usuario").Value

        If Me.RadioButton1.Checked = True Then

            Me.Panel2.Visible = True
            Me.Panel3.Visible = False

            Me.Ds_prestaciones1.prestaciones.Clear()

            If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then

                Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue
                'JGM -- Afegim el nou paràmetre
                If Me.DropDownList10.SelectedValue = "--TODOS--" Then
                    Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = -1
                Else
                    Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = Me.DropDownList10.SelectedValue
                End If
                'Fi JGM

                'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
                If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
                    Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
              "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
              "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
              "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
              " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
              " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
              "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
              "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
              "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') " & _
              " OR (@agencode = 'LABO') AND (hpro.hproacti = 'Y') " & _
              " AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
              " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (hpro." & _
              "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
              "Y')"
                Else
                    Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
              "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
              "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
              "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
              " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
              " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
              "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
              "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
              "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') AND (prod.prodco" & _
              "de LIKE 'DN%' or prod.prodcode = 'FA0001') OR (@agencode = 'LABO') AND (hpro.hpr" & _
              "oacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
              " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (proctita" & _
              ".agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on agen.age" & _
              "ncode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) AND (hpro." & _
              "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
              "Y')"
                End If
                'JGM Fi Modificació 15/05/2012


                Me.SqlConnection1.Open()
                Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
                Me.SqlConnection1.Close()

            End If

            Me.Dropdownlist4.DataBind()

            Me.Dropdownlist4.Items.Insert(0, "")

            Me.Dropdownlist4.SelectedValue = ""

            Session("requiere_autorizacion") = "N"

            Me.Label16.Visible = False

        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If Me.RadioButton2.Checked = True Then

            Me.Panel2.Visible = False
            Me.Panel3.Visible = True

            calcular_franja()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ls_causa As String

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        'Dim l_transaccion As New CGMServeiIntegracio.Transaccio

        Dim l_horas_reservadas() As CIMAServeiIntegracio.HoraReservada
        Dim l_mantener_horas_reservadas() As CIMAServeiIntegracio.HoraReservada
        'Dim l_horas_reservadas() As CGMServeiIntegracio.HoraReservada
        'Dim l_mantener_horas_reservadas() As CGMServeiIntegracio.HoraReservada

        Dim n As Integer

        Dim ls_array() As String

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim contador As Integer

        Dim ls_prestacion As String


        If Me.DropDownList1.SelectedValue = "2" Then

            ls_array = Split(Me.Dropdownlist4.SelectedValue.ToString, "/", , CompareMethod.Text)
            'Modificació JGM 14/10/2009
            If Len(Trim(Me.Label13.Text)) > 0 And Me.Label13.Visible = True Then
                ' Garante.

                If Len(Trim(Me.Dropdownlist6.SelectedValue)) > 0 Then

                    ' A. de Coberturas.
                    If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

                        'ls_array(1)
                        ''''''''''''''''''''

                        'Dim agenproc_key() as string

                        contador = 0

                        Session("cadena_conexion") = "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

                        str_menu = "[dbo].[SP_CIMACEX_RECUPERA_PRESTACION_CETIR] " & ls_array(1)

                        objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))

                        If objDS.Tables(0).Rows.Count > 0 Then

                            ls_prestacion = objDS.Tables(0).Rows(0).Item("ID_Prova")

                            'If objDS.Tables(0).Rows.Count > 0 Then

                            ''''''''''''''''''''

                            'If Me.DropDownList8.SelectedValue >= "08:00" And Me.DropDownList8.SelectedValue <= "12:00" Then

                            'ElseIf Me.DropDownList8.SelectedValue > "12:00" And Me.DropDownList8.SelectedValue <= "12:00" Then

                            'End If

                            Session("horas_reservadas") = Nothing

                            'service.RollbackTransaction(Session("transaccion").ID, True)

                            service.Timeout = -1

                            If IsNothing(Session("transaccion")) = False Then

                                service.RollbackTransaction(Session("transaccion").ID, True)

                            End If

                            l_transaccion = service.BegginTransaction()

                            Session("transaccion") = l_transaccion

                            'Select Case Me.DropDownList8.SelectedValue
                            '    Case "Q"
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            '    Case "M"
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.MATI, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            '    Case "G"
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.MIGDIA, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            '    Case "T"
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.TARDA, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            '    Case "N"
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.NIT, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            '    Case Else
                            'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                            'End Select

                            'Response.Write("<script language=javascript>alert('" & Session("entidad_pago") & "');</script>")
                            If Me.DropDownList8.SelectedValue = "00:00" Then

                                l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 20, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Minute, 1, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue))), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)
                                'l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, "CMA", ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 10, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Hour, 23, CDate(Me.DropDownList8.SelectedValue)), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

                            Else

                                l_horas_reservadas = service.GetHoresLliures(l_transaccion.ID, True, Session("entidad_pago"), ls_prestacion, CDate(Me.fecha_ini.Text), True, DateAdd(DateInterval.Day, 20, CDate(Me.fecha_ini.Text)), True, 5, True, CIMAServeiIntegracio.FranjaHoraria.QUALSEVOL, True, CDate(Me.DropDownList8.SelectedValue), True, DateAdd(DateInterval.Minute, 1, DateAdd(DateInterval.Hour, 1, CDate(Me.DropDownList8.SelectedValue))), True, "CMA", False, True, False, True, False, True, False, True, l_mantener_horas_reservadas)

                            End If

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

                            For n = 0 To UBound(l_horas_reservadas) '- 1

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
                            'Modificació JGM 14/10/2009
                            ls_causa = "Q"
                            'Response.Write("<script language=javascript>alert(""PRESTACIÓN mal mapeada. Por favor, contacte con Administración."");</script>")

                        End If

                    Else

                        'Modificació JGM 14/10/2009
                        ls_causa = "P"
                        'Response.Write("<script language=javascript>alert(""Falta especificar una PRESTACIÓN."");</script>")

                    End If
                Else
                    ls_causa = "C"
                End If
            Else
                ls_causa = "G"
            End If

            'Modificació JGM 14/10/2009
            Select Case ls_causa

                Case "Q"

                    Response.Write("<script language=javascript>alert(""PRESTACIÓN mal mapeada. Por favor, contacte con Administración."");</script>")

                Case "G", "C"

                    Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")

                Case "P"

                    Response.Write("<script language=javascript>alert(""Falta especificar una PRESTACIÓN."");</script>")

            End Select
            'Fi Modificació JGM 14/10/2009

        Else

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
                                'If Me.DropDownList1.SelectedValue = "2" Then
                                'busca_huecos_cetir()
                                'End If

                                Session("ok_busca_huecos") = "S"

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

                    Response.Write("<script language=javascript>alert(""Falta especificar una AGENDA."");</script>")

                Case "M"

                    Response.Write("<script language=javascript>alert(""Falta especificar una MUTUA."");</script>")

                Case "G", "C"

                    Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")

                Case "P"

                    Response.Write("<script language=javascript>alert(""Falta especificar una PRESTACIÓN."");</script>")

            End Select

        End If

    End Sub

    Private Sub busca_huecos_cetir()

        'Dim lcgm_carga As CGMServeiIntegracio.Cita

        'Dim PP() As CGMServeiIntegracio.HoraReservada
        'Dim KK() As CGMServeiIntegracio.HoraReservada

        'Dim lcgm_paciente As New CGMServeiIntegracio.Pacient
        'Dim lcgb_hora_reservada As CGMServeiIntegracio.HoraReservada

        Dim lb_ok As Boolean

        Dim ls_ok As String

        Dim data As Date = New Date(1971, 12, 15)

        Dim n As Integer

        Dim ls_array() As String



        'System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        'ls_array = Split(Me.Dropdownlist4.SelectedValue.ToString, "/")

        'Me.SqlDataAdapter13.SelectCommand.Parameters(0).Value = ls_array(0)

        'Me.SqlConnection2.Open()
        'Me.SqlDataAdapter13.Fill(Me.Ds_hpro_cetir1.cima_hpro_cetir)
        'Me.SqlConnection2.Close()

        'lcgm_carga = service.CrearCita(CStr(ls_array(0)), Me.Ds_hpro_cetir1.cima_hpro_cetir.Rows(0).Item("ID_Prova"), "PRUEBA INFORMATICA BATERIA.", False, False, False, False, False, False, False, False)

        'HR = service.GetHoresPerCita(lcgm_carga.ID_CGM, True, "CMA", Me.Calendar1.SelectedDate, True, DateAdd(DateInterval.Month, 1, Me.Calendar1.SelectedDate), True, CGMServeiIntegracio.FranjaHoraria.QUALSEVOL, True, 5, True, KK)

        'Session("HR") = HR

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Label17.Text = ""
        Me.Label18.Text = ""

        Session("epis_key_padre") = ""

        Me.DataGrid2.SelectedIndex = -1

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Dropdownlist7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist7.SelectedIndexChanged

        Dim ls_array(), ls_array2() As String

        Dim li_hora, li_minuto, li_total As Integer



        'refresco()

        'Me.Button1.Enabled = True

        'Me.Dropdownlist3.SelectedValue = Request("DropDownList3")

        'Me.Dropdownlist2.SelectedValue = Request("DropDownList2")

        If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

            ls_array = Split(Me.Dropdownlist7.SelectedValue.ToString, ":", , CompareMethod.Text)

            li_hora = CInt(ls_array(0)) * 60
            li_minuto = CInt(ls_array(1))

            ls_array2 = Split(Me.Dropdownlist4.SelectedValue.ToString, "/", , CompareMethod.Text)

            li_total = li_hora + li_minuto + CInt(ls_array2(0))

            Me.Textbox3.Text = CStr(Int(li_total / 60)) & ":" & formatear_minutos(CStr(li_total Mod 60))

            'Session("time_fin") = CStr(Int(li_total / 60)) & ":" & formatear_minutos(CStr(li_total Mod 60))

            Session("time_fin") = Me.Textbox3.Text
            Session("time_ini") = Me.Dropdownlist7.SelectedValue

        Else

            Response.Write("<script language=javascript>alert(""Falta especificar una PRESTACIÓN."");</script>")
            Me.Dropdownlist7.SelectedValue = ""

        End If

    End Sub

    Private Sub Dropdownlist9_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dropdownlist9.SelectedIndexChanged

        Dim n As Integer



        If Len(Trim(Me.Dropdownlist9.SelectedValue.ToString)) > 0 Then

            'Me.Ds_prestaciones1.prestaciones.Clear()

            'Me.OdbcConnection1.Open()

            'Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT ltrim(rtrim(hpro.hprodesclong)) + ' - ' + cast(proctita.proctitadura as varchar) + ' min' as 'Descripción', cast(proctita.proctitadura as varchar) + '/' + cast(hpro.hpro_key as varchar) as 'Tiempo' " & _
            '"FROM hpro, proctita, btimetab " & _
            '"WHERE ( proctita.hpro_key = hpro.hpro_key ) and " & _
            '"( btimetab.btimetabcode = proctita.btimetabcode ) and ( proctita.agencode = btimetab.agencode ) and " & _
            '"( ( proctita.agencode = '" & Me.Dropdownlist5.SelectedValue & "' ) AND  " & _
            '"( hpro.hproacti = 'Y' ) AND  " & _
            '"( proctita.proctitaacti = 'Y' ) ) AND  btimetab.btimetabacti = 'Y' " & _
            '"AND btimetab.btimetabcode = " & Me.Dropdownlist9.SelectedValue.ToString & " and '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end " & _
            '"AND CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 " & _
            '"ORDER BY hpro.hprodesclong"

            'Me.OdbcDataAdapter2.Fill(Me.Ds_prestaciones1.prestaciones)

            'Me.OdbcConnection1.Close()

            'Me.Dropdownlist4.DataBind()

            Me.Ds_franja_horaria1.Clear()


            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter3.SelectCommand.CommandText = "SELECT DATEPART (hh,btimetabhourinit) as hora_inicio, DATEPART (mi,btimetabhourinit) as minuto_inicio,DATEPART (hh,btimetabhour_end) as hora_fin,DATEPART (mi,btimetabhour_end) as minuto_fin, btimetabgran FROM btimetab where agencode = '" & Me.Dropdownlist5.SelectedValue & "' and '" & Me.Textbox2.Text & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 and btimetabcode = " & Me.Dropdownlist9.SelectedValue.ToString

            Me.OdbcDataAdapter3.Fill(Me.Ds_franja_horaria1.franja_horaria)

            If Me.Ds_franja_horaria1.franja_horaria.Count > 0 Then
                montar_desplegable(Me.Ds_franja_horaria1.franja_horaria.Rows(0))
            End If

            Me.OdbcConnection1.Close()

        Else

            Me.Ds_btimetab1.btimetab.Clear()

            Me.Dropdownlist9.DataBind()

            Me.Textbox3.Text = ""

            Me.Dropdownlist7.Items.Clear()

        End If

    End Sub

    Private Sub Dropdownlist4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dropdownlist4.SelectedIndexChanged

        Dim ls_duracion() As String



        Me.Dropdownlist7.SelectedValue = ""

        Me.Textbox3.Text = ""

        If Len(Trim(Me.Dropdownlist4.SelectedValue)) > 0 Then

            If Len(Trim(Session("id_agenda_garante"))) > 0 Then

                ls_duracion = Split(Me.Dropdownlist4.SelectedValue.ToString, "/", , CompareMethod.Text)

                Me.SqlDataAdapter12.SelectCommand.Parameters(0).Value = ls_duracion(1) 'Me.Dropdownlist4.SelectedValue
                Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Session("id_agenda_garante")

                Me.SqlConnection2.Open()
                Me.SqlDataAdapter12.Fill(Me.Ds_autorizaciones1.cima_prestaciones_autorizacion)
                Me.SqlConnection2.Close()

                If Me.Ds_autorizaciones1.cima_prestaciones_autorizacion.Rows.Count > 0 Then

                    Me.Label16.Visible = True
                    Session("requiere_autorizacion") = "S"

                Else

                    Me.Label16.Visible = False
                    Session("requiere_autorizacion") = "N"

                End If

            Else

                Me.Label16.Visible = False
                Session("requiere_autorizacion") = "N"

            End If

            calcular_franja()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim ls_agencode As String
        Dim li_firm_key As Integer

        Dim ls_hora_inicial, ls_hora_final As String

        Dim str_menu, str_menu_2, str_menu_3 As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet
        Dim objDS_3 As New Data.DataSet

        Dim objRow As Data.DataRow
        Dim objRow_2 As Data.DataRow

        Dim lb_no_ok As Boolean

        Dim ls_duracion() As String

        Dim n As Integer
        Dim str_cadena_naciente As String

        Dim li_medico As Integer

        Dim ls_causa As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim contador As Integer

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        'Dim l_transaccion As New CGMServeiIntegracio.Transaccio

        Dim lcima_paciente As New CIMAServeiIntegracio.Pacient
        Dim lcima_cita As New CIMAServeiIntegracio.Cita
        'Dim lcima_paciente As New CGMServeiIntegracio.Pacient
        'Dim lcima_cita As New CGMServeiIntegracio.Cita

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

        Dim ls_episcode As String

        Dim ldt_hora_ini, ldt_hora_fin As DateTime
        Dim ls_fecha_cita As String

        Dim ls_array() As String

        Dim ls_btimetabcode As String

        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio
        Dim ls_cadena As String

        Dim ls_agencode_traspaso As String



        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        ' Controles.

        If IsDate(Me.Dropdownlist7.SelectedValue) = False Or IsDate(Me.Textbox3.Text) = False Then

            ls_causa = "D"

        Else

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

        End If

        Select Case ls_causa

            Case "A"

                Response.Write("<script language=javascript>alert(""Falta especificar una AGENDA."");</script>")

            Case "M"

                Response.Write("<script language=javascript>alert(""Falta especificar una MUTUA."");</script>")

            Case "G", "C"

                Response.Write("<script language=javascript>alert(""Par mal definido. Por favor, contacte con Administración."");</script>")

            Case "P"

                Response.Write("<script language=javascript>alert(""Falta especificar una PRESTACIÓN."");</script>")

            Case "D"

                Response.Write("<script language=javascript>alert(""Intervalo de fechas mal definido."");</script>")

            Case Else

                If Len(Trim(Me.Dropdownlist9.SelectedValue)) > 0 Then

                    If Len(Trim(Session("time_ini"))) > 0 And Len(Trim(Session("time_fin"))) > 0 Then

                        'ls_hora_inicial = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1))
                        'ls_hora_final = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3))

                        ' Si se encuentra el time_ini o el time_fin en el intervalo o por encima de él, error.

                        If 1 = 2 Then 'presencia_intervalo(ls_hora_inicial, ls_hora_final, Trim(Session("time_ini"))) = False Or presencia_intervalo(ls_hora_inicial, ls_hora_final, Trim(Session("time_fin"))) = False Then

                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
                            Response.Write("</scr" & "ipt>")

                        Else

                            lb_no_ok = False

                            If Me.DropDownList1.SelectedValue = "2" Then

                            Else

                                ' Comprobación pertenencia a intervalos de bloqueo.

                                str_menu = "[dbo].[SP_CIMACEX_BLOQUEOS] '" & Me.Textbox2.Text & "','" & Me.Dropdownlist5.SelectedValue & "'," & Me.Dropdownlist9.SelectedValue

                                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                If lb_no_ok = False Then

                                    For Each objRow In objDS.Tables(0).Rows

                                        If (presencia_intervalo(objRow.Item(0), objRow.Item(1), Trim(Session("time_ini"))) = True And objRow.Item(1) <> (Trim(Session("time_ini")) & ":00")) Or (presencia_intervalo(objRow.Item(0), objRow.Item(1), Trim(Session("time_fin"))) = True And objRow.Item(0) <> (Trim(Session("time_fin")) & ":00")) Or intervalo_contenido(objRow.Item(0), objRow.Item(1), Trim(Session("time_ini")), Trim(Session("time_fin"))) = True Then

                                            lb_no_ok = True

                                        End If

                                    Next

                                End If

                                ' Fin de comprobación.

                            End If


                            If lb_no_ok Then

                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
                                Response.Write("</scr" & "ipt>")

                            Else

                                If Len(Trim(Session("pers_key_paciente"))) > 0 Then



                                    Dim ls_doctor, ls_mutua, ls_covegrou_key, ls_pers_key As String



                                    ' OK!!!

                                    ls_duracion = Split(Me.Dropdownlist4.SelectedValue.ToString, "/", , CompareMethod.Text)

                                    If Len(Trim(Me.Dropdownlist2.SelectedValue)) > 0 Then

                                        ls_doctor = Me.Dropdownlist2.SelectedValue

                                    Else

                                        ls_doctor = "0"

                                    End If

                                    If Me.Dropdownlist3.SelectedValue = "PRIVADO" Then

                                        'Modificació JGM 28/09/2009 -- Solucionem que quan es forza una cita
                                        ' el garant de privat quedi gravat correctament
                                        'ls_mutua = "0"
                                        If Len(Trim(Me.Label15.Text)) > 0 Then
                                            ls_mutua = Me.Label15.Text
                                        Else
                                            ls_mutua = "0"
                                        End If

                                    Else

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

                                        ls_mutua = Me.Ds_agendas_garantes1.cima_agendas_garantes.Rows(0).Item("firm_key")

                                    End If

                                    If ls_mutua = "0" Then

                                        If Len(Trim(Session("pers_key_paciente"))) > 0 Then

                                            ls_mutua = CStr(PP(Session("pers_key_paciente")))

                                        Else

                                            ls_mutua = ""

                                        End If

                                    End If

                                    If ls_mutua = "-1" Then

                                        Response.Write("<scr" & "ipt>" & vbCrLf)
                                        Response.Write("alert('Lo sentimos, el paciente ha sido mal dado de alta. Contacte con Administración.');" & vbCrLf)
                                        Response.Write("</scr" & "ipt>")

                                    Else

                                        ls_covegrou_key = Request("Dropdownlist6")

                                        ls_pers_key = Session("pers_key_paciente")

                                        If Len(Trim(str_uid)) > 0 Then

                                            str_uid = str_uid

                                        Else

                                            str_uid = ""

                                        End If

                                        If Me.DropDownList1.SelectedValue = "2" Then

                                            ''''''''' CETIR.

                                            ldt_hora_ini = Me.Textbox2.Text & " " & CStr(Me.Dropdownlist7.SelectedValue) 'Request("fecha_hora")
                                            ldt_hora_fin = Me.Textbox2.Text & " " & CStr(Me.Textbox3.Text) 'Request("fecha_hora")

                                            If ldt_hora_ini = ldt_hora_fin Then

                                                ' La Hora Inicial no puede ser igual que la Hora Final.

                                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                                Response.Write("alert('Lo sentimos, la Hora Inicial no puede ser igual que la Hora Final.');" & vbCrLf)
                                                Response.Write("</scr" & "ipt>")

                                            Else

                                                service.Timeout = -1

                                                l_transaccion = service.BegginTransaction()

                                                str_menu = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & Session("pers_key_paciente") & ""

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

                                                '''''''''''

                                                ls_btimetabcode = CStr(Me.Dropdownlist9.SelectedValue)

                                                'Select Case Trim(Request("btimetabcode"))
                                                'Case "MM"
                                                '   ls_btimetabcode = "351"
                                                'Case "ECG"
                                                '    ls_btimetabcode = "3341"
                                                'Case "RXC"
                                                '    ls_btimetabcode = "4"
                                                'Case "TC"
                                                '   ls_btimetabcode = "125"
                                                'Case "RM"
                                                '    ls_btimetabcode = "7"
                                                'Case "DN"
                                                '   ls_btimetabcode = "183"
                                                'Case "TLM"
                                                '     ls_btimetabcode = "323"
                                                '  Case "URG RX"
                                                '       ls_btimetabcode = "1"
                                                'End Select

                                                '''''''''''''''''''''''''''''''''

                                                'ls_fecha_cita = CStr(DatePart(DateInterval.Day, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Month, ldt_hora_ini)) & "/" & CStr(DatePart(DateInterval.Year, ldt_hora_ini))

                                                ls_array = Split(Me.Dropdownlist4.SelectedValue, "/", , CompareMethod.Text)

                                                'contador = 0

                                                Session("cadena_conexion") = "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

                                                str_menu = "[dbo].[SP_CIMACEX_RECUPERA_PRESTACION_CETIR] " & ls_array(1)

                                                objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))

                                                lcima_cita = service.ForzarHoraPacient(l_transaccion.ID, True, lcima_paciente, Session("entidad_pago"), objDS.Tables(0).Rows(0).Item("ID_Prova"), "CMA", ldt_hora_ini, True, ldt_hora_fin, True, False, True, False, True, False, True)

                                                'Modificació JGM 15/02/2010
                                                'Si el check de usuario mc está marcado, lo modificamos
                                                If Me.CheckBox2.Checked = True Then
                                                    str_uid = "mcmutual.usuario"
                                                End If
                                                'Fi Modificació JGM 15/02/2010

                                                If Len(Trim(Session("epis_key_padre"))) > 0 And Trim(Session("epis_key_padre")) <> "0" Then

                                                    'JGM 04/02/2011 Per CETIR li passem a blancs
                                                    str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_FORZADA_CON_PADRE] '" & Me.Textbox2.Text & "','" & Me.Dropdownlist5.SelectedValue & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.Dropdownlist9.SelectedValue & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & ls_covegrou_key & ",'" & str_uid & "'," & Session("epis_key_padre") & ",'',''"

                                                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                                Else

                                                    'JGM 04/02/2011 Per CETIR passem el paràmetre a blancs
                                                    str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_FORZADA] '" & Me.Textbox2.Text & "','" & Me.Dropdownlist5.SelectedValue & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.Dropdownlist9.SelectedValue & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & ls_covegrou_key & ",'" & str_uid & "','',''"

                                                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                                End If

                                                'str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA] '" & ls_fecha_cita & "','" & Request("agencode") & "','" & CStr(DatePart(DateInterval.Hour, ldt_hora_ini)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_ini)) & ":00','" & CStr(DatePart(DateInterval.Hour, ldt_hora_fin)) & ":" & CStr(DatePart(DateInterval.Minute, ldt_hora_fin)) & ":00'," & Request("duracion") & "," & ls_btimetabcode & "," & Mid(ls_array(1), 1, ls_array(1).Length - 1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & Request("covegrou_key") & ",'" & str_uid & "'"

                                                'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                                ls_episcode = objDS.Tables(0).Rows(0).Item(1)

                                                service.AssociarCitaCGMEpisodiExtern(l_transaccion.ID, True, lcima_cita.ID_CGM, True, ls_episcode)

                                                l_transaccion_retorno = service.CommitTransaccio(l_transaccion.ID, True)

                                                'JGM 22/02/2011
                                                'Damos de alta la clave de cetir
                                                str_menu_3 = "[dbo].[SP_CIMACEX_ALTA_CLAVE_CETIR] '" & ls_episcode & "'," & lcima_cita.ID_CGM & "," & CInt(lcima_paciente.ID_Pacient_Extern)

                                                objDS_3 = objCIMA.f_consulta_CSaludR(str_menu_3, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")
                                                'Fi JGM 22/02/2011

                                                ls_cadena = "episcode=" & ls_episcode & "#Forzada=S#" & "ID_CGM=" & CStr(lcima_cita.ID_CGM) & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

                                                str_menu_2 = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','ACI'"

                                                objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")

                                            End If


                                            'Session("transaccion") = Nothing

                                            'Session("horas_reservadas") = Nothing

                                            'Session("pers_key_paciente") = ""

                                            '''''''''

                                        Else

                                            'Modificació JGM 15/02/2010
                                            'Si el check de usuario mc está marcado, lo modificamos
                                            If Me.CheckBox2.Checked = True Then
                                                str_uid = "mcmutual.usuario"
                                            End If
                                            'Fi Modificació JGM 15/02/2010

                                            If Len(Trim(Session("epis_key_padre"))) > 0 And Trim(Session("epis_key_padre")) <> "0" Then

                                                'JGM 04/02/2011 Passem el nou paràmetre pel NHC de I.MArquès
                                                str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_FORZADA_CON_PADRE] '" & Me.Textbox2.Text & "','" & Me.Dropdownlist5.SelectedValue & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.Dropdownlist9.SelectedValue & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & ls_covegrou_key & ",'" & str_uid & "'," & Session("epis_key_padre") & ",'" & Me.TextBox4.Text & "','" & Me.DropDownList11.SelectedValue & "'"

                                                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                            Else

                                                'JGM 04/02/2011 Passem el nou paràmetre pel NHC de I.MArquès
                                                str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA_RAPIDA_FORZADA] '" & Me.Textbox2.Text & "','" & Me.Dropdownlist5.SelectedValue & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.Dropdownlist9.SelectedValue & "," & ls_duracion(1) & "," & ls_pers_key & "," & ls_doctor & "," & ls_mutua & "," & ls_covegrou_key & ",'" & str_uid & "','" & Me.TextBox4.Text & "','" & Me.DropDownList11.SelectedValue & "'"

                                                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                            End If

                                            ''' Conexión con otros back-offices.

                                            'If Trim(Me.Dropdownlist5.SelectedValue) = "BOZA" Or Trim(Me.Dropdownlist5.SelectedValue) = "SOLE" Or Trim(Me.Dropdownlist5.SelectedValue) = "SOLER" Or Trim(Me.Dropdownlist5.SelectedValue) = "GUIL" Or Trim(Me.Dropdownlist5.SelectedValue) = "BODET" Or Trim(Me.Dropdownlist5.SelectedValue) = "FUERTE" Or Trim(Me.Dropdownlist5.SelectedValue) = "SEGURA" Then ''' ASKLEPIO de iDermalia y DERMAS.

                                            '    str_menu_2 = "dbo.[SP_CIMACEX_PACIENTE_A_CETIR] " & Session("pers_key_paciente") & ""

                                            '    objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                                            '    contador = 0

                                            '    For Each objRow_2 In objDS_2.Tables(0).Rows

                                            '        contador = contador + 1

                                            '        If contador = 1 Then

                                            '            ds_cita_persRow_idermalia("pers_key") = CInt(ls_pers_key)
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

                                            '            ds_cita_persRow_dermas("pers_key") = CInt(ls_pers_key)
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

                                            '    Select Case Trim(Me.Dropdownlist5.SelectedValue)
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
                                            '    ds_cita_citaRow_idermalia("dia") = Me.Textbox2.Text 'CDate(Request("fecha_cita"))
                                            '    ds_cita_citaRow_idermalia("hora_ini") = CDate("01/01/1900 " & Session("time_ini") & ":00")
                                            '    ds_cita_citaRow_idermalia("hora_fin") = CDate("01/01/1900 " & Session("time_fin") & ":00")
                                            '    ds_cita_citaRow_idermalia("id_garante") = 19
                                            '    ds_cita_citaRow_idermalia("id_agen_franja") = 0
                                            '    ds_cita_citaRow_idermalia("pers_key") = CInt(ls_pers_key)
                                            '    ds_cita_citaRow_idermalia("epis_key") = CInt(objDS.Tables(0).Rows(0).Item(0))

                                            '    lds_alta_cita_idermalia.cita.Rows.Add(ds_cita_citaRow_idermalia)

                                            '    ds_cita_citaRow_dermas("id_centro") = 1
                                            '    ds_cita_citaRow_dermas("agencode") = ls_agencode_traspaso
                                            '    ds_cita_citaRow_dermas("id_prestacion") = li_prestacion
                                            '    ds_cita_citaRow_dermas("dia") = Me.Textbox2.Text 'CDate(Request("fecha_cita"))
                                            '    ds_cita_citaRow_dermas("hora_ini") = CDate("01/01/1900 " & Session("time_ini") & ":00")
                                            '    ds_cita_citaRow_dermas("hora_fin") = CDate("01/01/1900 " & Session("time_fin") & ":00")
                                            '    ds_cita_citaRow_dermas("id_garante") = 19
                                            '    ds_cita_citaRow_dermas("id_agen_franja") = 0
                                            '    ds_cita_citaRow_dermas("pers_key") = CInt(ls_pers_key)
                                            '    ds_cita_citaRow_dermas("epis_key") = CInt(objDS.Tables(0).Rows(0).Item(0))

                                            '    lds_alta_cita_dermas.cita.Rows.Add(ds_cita_citaRow_dermas)

                                            '    lidermalia_ws.AltaCita("cima.ws", "Idermalia1", lds_alta_cita_idermalia)
                                            '    ldermas_ws.AltaCita("cima.ws", "Dermas10", lds_alta_cita_dermas)

                                            'End If

                                            ''' Fin de la conexión.

                                        End If

                                        '''''''''''

                                        ''''''''''''''''''''''''''''''''''''''''''

                                        Session("pers_key_padre") = ""
                                        Session("epis_key_padre") = ""
                                        Me.Label17.Text = ""

                                        Response.Write("<scr" & "ipt>" & vbCrLf)
                                        Response.Write("alert('Cita FORZADA con éxito.');" & vbCrLf)
                                        Response.Write("</scr" & "ipt>")

                                        'JGM Modificació 09/06/2010 - si marquem el codi web el generem
                                        If objDS.Tables(0).Rows.Count > 0 And (Me.CheckBox1.Checked = True Or Me.CheckBox3.Checked = True) Then

                                            If Me.CheckBox1.Checked = True Then
                                                Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                                Response.Write("var control=2;" & vbCrLf)
                                                Response.Write("f_abre(""../reports/cr_hoja_citacion.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,900,"""");" & vbCrLf)
                                                Response.Write("</scr" & "ipt>" & vbCrLf)
                                            End If

                                            If Me.CheckBox3.Checked = True Then
                                                Response.Write("<script src=""../js/cima.js""></script>" & vbCrLf)
                                                Response.Write("<scr" & "ipt>" & vbCrLf)
                                                Response.Write("var control=2;" & vbCrLf)
                                                Response.Write("f_abre(""../formularios/form_generar_codigo_web.aspx?episcode=" & objDS.Tables(0).Rows(0).Item(1) & """,600,830,"""");" & vbCrLf)
                                                Response.Write("</scr" & "ipt>" & vbCrLf)
                                            End If

                                        Else

                                            Response.Write("<scr" & "ipt>" & vbCrLf)
                                            Response.Write("location.href='form_citas_rapidas.aspx';" & vbCrLf)
                                            Response.Write("</scr" & "ipt>" & vbCrLf)

                                        End If

                                        ' Corrección del agencode a char.

                                        End If

                                Else

                                    Response.Write("<scr" & "ipt>" & vbCrLf)
                                    Response.Write("alert('Lo sentimos, debe seleccionar un PACIENTE.');" & vbCrLf)
                                    Response.Write("</scr" & "ipt>")

                                End If

                            End If

                        End If

                    Else

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Lo sentimos, el intervalo horario seleccionado no es aceptable.');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")

                    End If

                End If

        End Select

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

    Private Sub Textbox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Textbox3.TextChanged

        Session("time_fin") = Me.Textbox3.Text
        Session("time_ini") = Me.Dropdownlist7.SelectedValue

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Len(Trim(Session("pers_key_paciente"))) = 0 Or Trim(Session("pers_key_paciente")) = "0" Then

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Es necesario seleccionar un PACIENTE para asociar a un episodio PADRE.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            Me.SqlDataAdapter16.SelectCommand.Parameters(1).Value = Session("pers_key_paciente")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter16.Fill(Me.Ds_episodios_multicitas1.SP_CIMACEX_EPISODIOS_MULTICITAS)
            Me.SqlConnection1.Close()

            Me.DataGrid2.DataBind()

            Me.DataGrid2.Visible = True

            Me.DataGrid2.SelectedIndex = -1

            Me.Panel5.Visible = True

        End If

    End Sub

    Private Sub DataGrid2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid2.SelectedIndexChanged

        Me.Label17.Text = Me.DataGrid2.SelectedItem.Cells(2).Text
        Me.Label18.Text = Me.DataGrid2.SelectedItem.Cells(1).Text

        Me.Panel5.Visible = False

        Session("epis_key_padre") = Me.DataGrid2.SelectedItem.Cells(1).Text

    End Sub

    Private Sub DropDownList10_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList10.SelectedIndexChanged
        Dim str_uid As String

        str_uid = Request.Cookies("usuario").Value
        'JGM Si canviem el bloc horari, cal recarregar les prestacions.
        Me.Ds_prestaciones1.prestaciones.Clear()

        If Len(Trim(Me.Dropdownlist5.SelectedValue)) > 0 Then

            Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = Me.Dropdownlist5.SelectedValue
            If Me.DropDownList10.SelectedValue = "--TODOS--" Then
                Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = -1
            Else
                Me.SqlDataAdapter7.SelectCommand.Parameters(1).Value = Me.DropDownList10.SelectedValue
            End If

            'JGM Modificació 15/05/2012 -- Si els usuarios són 'meritxell.sanjuan' o 'tania.navas' canviem la select.
            If Trim(str_uid) = "meritxell.sanjuan" Or Trim(str_uid) = "ana.herrera" Or Trim(str_uid) = "tania.navas" Or Trim(str_uid) = "jordi.gonzalez" Or Trim(str_uid) = "mari.sanchez" Or Trim(str_uid) = "juancarlos.pachon" Then
                Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
          "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
          "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
          "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
          " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
          " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
          "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
          "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
          "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') " & _
          " OR (@agencode = 'LABO') AND (hpro.hproacti = 'Y') " & _
          " AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
          " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (hpro." & _
          "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
          "Y')"
            Else
                Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
          "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
          "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
          "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
          " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
          " = btimetab.agencode AND (btimetab.btimetabcode = @bloque_horario OR @bloque_hor" & _
          "ario = - 1) LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE (proctit" & _
          "a.agencode = @agencode) AND (@agencode <> 'LABO') AND (hpro.hproacti = 'Y') AND " & _
          "(proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y') AND (prod.prodco" & _
          "de LIKE 'DN%' or prod.prodcode = 'FA0001') OR (@agencode = 'LABO') AND (hpro.hpr" & _
          "oacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = 'Y')" & _
          " AND (hpro.hprocode = 'LB9900') OR (proctita.agencode = @agencode) AND (proctita" & _
          ".agencode in (SELECT resoagen.agencode FROM resoagen inner join agen on agen.age" & _
          "ncode = resoagen.agencode where agen.agenacti='Y' and reso_key = 13)) AND (hpro." & _
          "hproacti = 'Y') AND (proctita.proctitaacti = 'Y') AND (btimetab.btimetabacti = '" & _
          "Y')"
            End If
            'JGM Fi Modificació 15/05/2012


            Me.SqlConnection1.Open()
            Me.SqlDataAdapter7.Fill(Me.Ds_prestaciones1.prestaciones)
            Me.SqlConnection1.Close()

        End If

        Me.Dropdownlist4.DataBind()

        Me.Dropdownlist4.Items.Insert(0, "")

        Me.Dropdownlist4.SelectedValue = ""
        Session("requiere_autorizacion") = "N"

    End Sub
End Class

Public Class MyPolicy

    Implements ICertificatePolicy

    Public Function CheckValidationResult(ByVal srvPoint As ServicePoint, _
                  ByVal cert As X509Certificate, ByVal request As WebRequest, _
                  ByVal certificateProblem As Integer) _
              As Boolean Implements ICertificatePolicy.CheckValidationResult

        'Return True to force the certificate to be accepted.

        Return True

    End Function

End Class
