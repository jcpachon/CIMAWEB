Public Class form_captura
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_datos_captura1 = New cimaweb.ds_datos_captura
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_apporend1 = New cimaweb.ds_apporend
        Me.Ds_datos_captura_garante1 = New cimaweb.ds_datos_captura_garante
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_csta1 = New cimaweb.ds_datos_captura_csta
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_cstahper1 = New cimaweb.ds_datos_captura_cstahper
        Me.Ds_datos_captura_cstahper2 = New cimaweb.ds_datos_captura_cstahper
        Me.Ds_csta1 = New cimaweb.ds_csta
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Ds_csta2 = New cimaweb.ds_csta
        Me.SqlDataAdapter7 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_cstahper3 = New cimaweb.ds_datos_captura_cstahper
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_cstahper4 = New cimaweb.ds_datos_captura_cstahper
        Me.Ds_hpro1 = New cimaweb.ds_hpro
        Me.SqlDataAdapter9 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_prestaciones_agen1 = New cimaweb.ds_datos_captura_prestaciones_agen
        Me.SqlDataAdapter10 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter11 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.Ds_firm_garantes1 = New cimaweb.ds_firm_garantes
        Me.Ds_covegrou1 = New cimaweb.ds_covegrou
        Me.SqlDataAdapter12 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.Ds_episcode1 = New cimaweb.ds_episcode
        Me.SqlDataAdapter13 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.Ds_datos_captura_garante_poliza1 = New cimaweb.ds_datos_captura_garante_poliza
        Me.SqlDataAdapter14 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.Ds_incidencias1 = New cimaweb.ds_incidencias
        Me.SqlDataAdapter15 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter16 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        Me.Ds_incidencia_episodio1 = New cimaweb.ds_incidencia_episodio
        CType(Me.Ds_datos_captura1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_apporend1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_garante1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_csta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_cstahper1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_cstahper2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_csta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_cstahper3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_cstahper4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_prestaciones_agen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_episcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_garante_poliza1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_incidencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_incidencia_episodio1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_datos_captura1
        '
        Me.Ds_datos_captura1.DataSetName = "ds_datos_captura"
        Me.Ds_datos_captura1.EnforceConstraints = False
        Me.Ds_datos_captura1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_DATOS_CAPTURA]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.Char, 11))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "apporend", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("apporendcode", "apporendcode"), New System.Data.Common.DataColumnMapping("apporenddesc", "apporenddesc")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT apporendcode, apporenddesc FROM apporend WHERE (apporendacti = 'Y') ORDER " & _
        "BY apporenddesc"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Ds_apporend1
        '
        Me.Ds_apporend1.DataSetName = "ds_apporend"
        Me.Ds_apporend1.EnforceConstraints = False
        Me.Ds_apporend1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_datos_captura_garante1
        '
        Me.Ds_datos_captura_garante1.DataSetName = "ds_datos_captura_garante"
        Me.Ds_datos_captura_garante1.EnforceConstraints = False
        Me.Ds_datos_captura_garante1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_DATOS_CAPTURA_GARANTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firmname", "firmname"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "[SP_CIMACEX_DATOS_CAPTURA_GARANTE]"
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cstahper_key", "cstahper_key"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cstahper.cstahper_key, pers.perssur1, pers.perssur2, pers.persname, pers.p" & _
        "ersfullname FROM hper INNER JOIN pers ON hper.pers_key = pers.pers_key AND pers." & _
        "persacti = 'Y' INNER JOIN hperclas ON hper.hperclascode = hperclas.hperclascode " & _
        "INNER JOIN cstahper ON pers.pers_key = cstahper.pers_key WHERE (cstahper.csta_ke" & _
        "y = @csta_key) AND (cstahper.cstahperdate_end IS NULL) AND (hper.hperclascode IN" & _
        " (SELECT hperclascode FROM hperclas WHERE hpergroucode IN ('C', 'F'))) ORDER BY " & _
        "pers.perssur1, pers.perssur2, pers.persname"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        '
        'Ds_datos_captura_csta1
        '
        Me.Ds_datos_captura_csta1.DataSetName = "ds_datos_captura_csta"
        Me.Ds_datos_captura_csta1.EnforceConstraints = False
        Me.Ds_datos_captura_csta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "appo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_keymake", "csta_keymake"), New System.Data.Common.DataColumnMapping("cstahper_keymake", "cstahper_keymake"), New System.Data.Common.DataColumnMapping("cstahper_keyinfo", "cstahper_keyinfo"), New System.Data.Common.DataColumnMapping("insicode", "insicode")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT appo.csta_keymake, appo.cstahper_keymake, appo.cstahper_keyinfo, epis.insi" & _
        "code FROM appo INNER JOIN epis ON appo.epis_key = epis.epis_key WHERE (epis.epis" & _
        "code = @episcode)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'Ds_datos_captura_cstahper1
        '
        Me.Ds_datos_captura_cstahper1.DataSetName = "ds_datos_captura_cstahper"
        Me.Ds_datos_captura_cstahper1.EnforceConstraints = False
        Me.Ds_datos_captura_cstahper1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_datos_captura_cstahper2
        '
        Me.Ds_datos_captura_cstahper2.DataSetName = "ds_datos_captura_cstahper"
        Me.Ds_datos_captura_cstahper2.EnforceConstraints = False
        Me.Ds_datos_captura_cstahper2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_csta1
        '
        Me.Ds_csta1.DataSetName = "ds_csta"
        Me.Ds_csta1.EnforceConstraints = False
        Me.Ds_csta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "csta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT csta_key, cstadesclong FROM csta WHERE (cent_key = 1) ORDER BY cstadesclon" & _
        "g"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'Ds_csta2
        '
        Me.Ds_csta2.DataSetName = "ds_csta"
        Me.Ds_csta2.EnforceConstraints = False
        Me.Ds_csta2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter7
        '
        Me.SqlDataAdapter7.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter7.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cstahper", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cstahper_key", "cstahper_key"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cstahper.cstahper_key, pers.perssur1, pers.perssur2, pers.persname, pers.p" & _
        "ersfullname FROM cstahper INNER JOIN pers ON cstahper.pers_key = pers.pers_key A" & _
        "ND pers.persacti = 'Y' INNER JOIN hper ON cstahper.pers_key = hper.pers_key INNE" & _
        "R JOIN hperclas ON hper.hperclascode = hperclas.hperclascode WHERE (cstahper.cst" & _
        "a_key = @csta_key) AND (cstahper.cstahperdate_end IS NULL) AND (hperclas.hpergro" & _
        "ucode IN ('C', 'F')) ORDER BY pers.perssur1"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        '
        'Ds_datos_captura_cstahper3
        '
        Me.Ds_datos_captura_cstahper3.DataSetName = "ds_datos_captura_cstahper"
        Me.Ds_datos_captura_cstahper3.EnforceConstraints = False
        Me.Ds_datos_captura_cstahper3.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter8
        '
        Me.SqlDataAdapter8.SelectCommand = Me.SqlSelectCommand8
        Me.SqlDataAdapter8.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cstahper", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cstahper_key", "cstahper_key"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT cstahper.cstahper_key, pers.perssur1, pers.perssur2, pers.persname, pers.p" & _
        "ersfullname FROM cstahper INNER JOIN pers ON cstahper.pers_key = pers.pers_key A" & _
        "ND pers.persacti = 'Y' INNER JOIN hper ON cstahper.pers_key = hper.pers_key INNE" & _
        "R JOIN hperclas ON hper.hperclascode = hperclas.hperclascode WHERE (cstahper.cst" & _
        "a_key = @csta_key) AND (cstahper.cstahperdate_end IS NULL) AND (hperclas.hpergro" & _
        "ucode IN ('C', 'F')) ORDER BY pers.perssur1"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        '
        'Ds_datos_captura_cstahper4
        '
        Me.Ds_datos_captura_cstahper4.DataSetName = "ds_datos_captura_cstahper"
        Me.Ds_datos_captura_cstahper4.EnforceConstraints = False
        Me.Ds_datos_captura_cstahper4.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_hpro1
        '
        Me.Ds_hpro1.DataSetName = "ds_hpro"
        Me.Ds_hpro1.EnforceConstraints = False
        Me.Ds_hpro1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter9
        '
        Me.SqlDataAdapter9.SelectCommand = Me.SqlSelectCommand9
        Me.SqlDataAdapter9.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PRESTACIONES_EPISODIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("hpro_keyfath", "hpro_keyfath"), New System.Data.Common.DataColumnMapping("hprocode", "hprocode"), New System.Data.Common.DataColumnMapping("hprodescshor", "hprodescshor"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong"), New System.Data.Common.DataColumnMapping("hprodura", "hprodura"), New System.Data.Common.DataColumnMapping("hproleve", "hproleve"), New System.Data.Common.DataColumnMapping("hproacti", "hproacti"), New System.Data.Common.DataColumnMapping("hproupda", "hproupda"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("hproorde", "hproorde"), New System.Data.Common.DataColumnMapping("hpro_uvr", "hpro_uvr"), New System.Data.Common.DataColumnMapping("hprogrouclos", "hprogrouclos"), New System.Data.Common.DataColumnMapping("hprocodenorm", "hprocodenorm"), New System.Data.Common.DataColumnMapping("hprotypecode", "hprotypecode"), New System.Data.Common.DataColumnMapping("hprovaliperi", "hprovaliperi"), New System.Data.Common.DataColumnMapping("hprocode_crc", "hprocode_crc")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CIMACEX_PRESTACIONES_EPISODIO]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'Ds_datos_captura_prestaciones_agen1
        '
        Me.Ds_datos_captura_prestaciones_agen1.DataSetName = "ds_datos_captura_prestaciones_agen"
        Me.Ds_datos_captura_prestaciones_agen1.EnforceConstraints = False
        Me.Ds_datos_captura_prestaciones_agen1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter10
        '
        Me.SqlDataAdapter10.SelectCommand = Me.SqlSelectCommand10
        Me.SqlDataAdapter10.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PRESTACIONES_AGEN", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("proctita_key", "proctita_key"), New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("btimetabcode", "btimetabcode"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("btimetabdesc", "btimetabdesc"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong"), New System.Data.Common.DataColumnMapping("proctitadura", "proctitadura"), New System.Data.Common.DataColumnMapping("proctitaacti", "proctitaacti"), New System.Data.Common.DataColumnMapping("proctitadefa", "proctitadefa"), New System.Data.Common.DataColumnMapping("proctitavalu", "proctitavalu"), New System.Data.Common.DataColumnMapping("proctitanumbpres", "proctitanumbpres")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "[SP_CIMACEX_PRESTACIONES_AGEN]"
        Me.SqlSelectCommand10.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlDataAdapter11
        '
        Me.SqlDataAdapter11.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter11.SelectCommand = Me.SqlSelectCommand11
        Me.SqlDataAdapter11.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("addrcodemain", "addrcodemain"), New System.Data.Common.DataColumnMapping("addrcodedeli", "addrcodedeli"), New System.Data.Common.DataColumnMapping("addrcodeinvo", "addrcodeinvo"), New System.Data.Common.DataColumnMapping("ttaxgfircode", "ttaxgfircode"), New System.Data.Common.DataColumnMapping("paymdocucode", "paymdocucode"), New System.Data.Common.DataColumnMapping("firmclascode", "firmclascode"), New System.Data.Common.DataColumnMapping("currcode", "currcode"), New System.Data.Common.DataColumnMapping("langcode", "langcode"), New System.Data.Common.DataColumnMapping("addrcodepaym", "addrcodepaym"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("payccode", "payccode"), New System.Data.Common.DataColumnMapping("idenfirmcode", "idenfirmcode"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firmname", "firmname"), New System.Data.Common.DataColumnMapping("firmnamecomm", "firmnamecomm"), New System.Data.Common.DataColumnMapping("firmidencode", "firmidencode"), New System.Data.Common.DataColumnMapping("firmdateacti", "firmdateacti"), New System.Data.Common.DataColumnMapping("firmrema", "firmrema"), New System.Data.Common.DataColumnMapping("firmfilename", "firmfilename"), New System.Data.Common.DataColumnMapping("firmacti", "firmacti"), New System.Data.Common.DataColumnMapping("plancodeterr", "plancodeterr"), New System.Data.Common.DataColumnMapping("tfircode", "tfircode"), New System.Data.Common.DataColumnMapping("firmea13", "firmea13"), New System.Data.Common.DataColumnMapping("firm_abc", "firm_abc"), New System.Data.Common.DataColumnMapping("invccode", "invccode"), New System.Data.Common.DataColumnMapping("firmguar", "firmguar"), New System.Data.Common.DataColumnMapping("firmnameshor", "firmnameshor"), New System.Data.Common.DataColumnMapping("funccodebrne", "funccodebrne"), New System.Data.Common.DataColumnMapping("funccodeprpr", "funccodeprpr"), New System.Data.Common.DataColumnMapping("firm_keyfath", "firm_keyfath"), New System.Data.Common.DataColumnMapping("funccodebrnedeli", "funccodebrnedeli"), New System.Data.Common.DataColumnMapping("funccodeprprdeli", "funccodeprprdeli"), New System.Data.Common.DataColumnMapping("funccodebrneorde", "funccodebrneorde"), New System.Data.Common.DataColumnMapping("funccodeprprorde", "funccodeprprorde"), New System.Data.Common.DataColumnMapping("buni_key", "buni_key"), New System.Data.Common.DataColumnMapping("codetmplcode", "codetmplcode"), New System.Data.Common.DataColumnMapping("funccodeacce", "funccodeacce"), New System.Data.Common.DataColumnMapping("firmtrantime", "firmtrantime"), New System.Data.Common.DataColumnMapping("firmpartserv", "firmpartserv"), New System.Data.Common.DataColumnMapping("firmminiperc", "firmminiperc"), New System.Data.Common.DataColumnMapping("firmrealqualctrl", "firmrealqualctrl"), New System.Data.Common.DataColumnMapping("firmleve", "firmleve"), New System.Data.Common.DataColumnMapping("firmorde", "firmorde"), New System.Data.Common.DataColumnMapping("firmdelidays", "firmdelidays"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("firmdatedrop", "firmdatedrop"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("plancodeter2", "plancodeter2"), New System.Data.Common.DataColumnMapping("addrcodezone", "addrcodezone"), New System.Data.Common.DataColumnMapping("tfircod2", "tfircod2"), New System.Data.Common.DataColumnMapping("plancodefir2", "plancodefir2"), New System.Data.Common.DataColumnMapping("firminvonumb", "firminvonumb"), New System.Data.Common.DataColumnMapping("firm_keytabl", "firm_keytabl"), New System.Data.Common.DataColumnMapping("tablcode", "tablcode"), New System.Data.Common.DataColumnMapping("trac_key", "trac_key")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO firm(firm_key, addrcodemain, addrcodedeli, addrcodeinvo, ttaxgfircode" & _
        ", paymdocucode, firmclascode, currcode, langcode, addrcodepaym, plancode, paycco" & _
        "de, idenfirmcode, firmcode, firmnamecomm, firmidencode, firmdateacti, firmrema, " & _
        "firmfilename, firmacti, plancodeterr, tfircode, firmea13, firm_abc, invccode, fi" & _
        "rmguar, firmnameshor, funccodebrne, funccodeprpr, firm_keyfath, funccodebrnedeli" & _
        ", funccodeprprdeli, funccodebrneorde, funccodeprprorde, buni_key, codetmplcode, " & _
        "funccodeacce, firmtrantime, firmpartserv, firmminiperc, firmrealqualctrl, firmle" & _
        "ve, firmorde, firmdelidays, txts_key, firmdatedrop, docu_key, plancodeter2, addr" & _
        "codezone, tfircod2, plancodefir2, firminvonumb, firm_keytabl, tablcode, trac_key" & _
        ") VALUES (@firm_key, @addrcodemain, @addrcodedeli, @addrcodeinvo, @ttaxgfircode," & _
        " @paymdocucode, @firmclascode, @currcode, @langcode, @addrcodepaym, @plancode, @" & _
        "payccode, @idenfirmcode, @firmcode, @firmnamecomm, @firmidencode, @firmdateacti," & _
        " @firmrema, @firmfilename, @firmacti, @plancodeterr, @tfircode, @firmea13, @firm" & _
        "_abc, @invccode, @firmguar, @firmnameshor, @funccodebrne, @funccodeprpr, @firm_k" & _
        "eyfath, @funccodebrnedeli, @funccodeprprdeli, @funccodebrneorde, @funccodeprpror" & _
        "de, @buni_key, @codetmplcode, @funccodeacce, @firmtrantime, @firmpartserv, @firm" & _
        "miniperc, @firmrealqualctrl, @firmleve, @firmorde, @firmdelidays, @txts_key, @fi" & _
        "rmdatedrop, @docu_key, @plancodeter2, @addrcodezone, @tfircod2, @plancodefir2, @" & _
        "firminvonumb, @firm_keytabl, @tablcode, @trac_key)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4, "firm_key"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@addrcodemain", System.Data.SqlDbType.Int, 4, "addrcodemain"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@addrcodedeli", System.Data.SqlDbType.Int, 4, "addrcodedeli"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@addrcodeinvo", System.Data.SqlDbType.Int, 4, "addrcodeinvo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ttaxgfircode", System.Data.SqlDbType.VarChar, 2, "ttaxgfircode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@paymdocucode", System.Data.SqlDbType.VarChar, 4, "paymdocucode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmclascode", System.Data.SqlDbType.VarChar, 2, "firmclascode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@currcode", System.Data.SqlDbType.VarChar, 3, "currcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@langcode", System.Data.SqlDbType.VarChar, 2, "langcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@addrcodepaym", System.Data.SqlDbType.Int, 4, "addrcodepaym"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plancode", System.Data.SqlDbType.VarChar, 4, "plancode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payccode", System.Data.SqlDbType.VarChar, 4, "payccode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@idenfirmcode", System.Data.SqlDbType.VarChar, 4, "idenfirmcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmcode", System.Data.SqlDbType.VarChar, 15, "firmcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmnamecomm", System.Data.SqlDbType.VarChar, 30, "firmnamecomm"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmidencode", System.Data.SqlDbType.VarChar, 14, "firmidencode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmdateacti", System.Data.SqlDbType.DateTime, 8, "firmdateacti"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmrema", System.Data.SqlDbType.VarChar, 100, "firmrema"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmfilename", System.Data.SqlDbType.VarChar, 100, "firmfilename"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmacti", System.Data.SqlDbType.VarChar, 1, "firmacti"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plancodeterr", System.Data.SqlDbType.VarChar, 4, "plancodeterr"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tfircode", System.Data.SqlDbType.VarChar, 2, "tfircode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmea13", System.Data.SqlDbType.VarChar, 13, "firmea13"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_abc", System.Data.SqlDbType.VarChar, 1, "firm_abc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invccode", System.Data.SqlDbType.VarChar, 2, "invccode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmguar", System.Data.SqlDbType.VarChar, 1, "firmguar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmnameshor", System.Data.SqlDbType.VarChar, 15, "firmnameshor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodebrne", System.Data.SqlDbType.Int, 4, "funccodebrne"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodeprpr", System.Data.SqlDbType.Int, 4, "funccodeprpr"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_keyfath", System.Data.SqlDbType.Int, 4, "firm_keyfath"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodebrnedeli", System.Data.SqlDbType.Int, 4, "funccodebrnedeli"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodeprprdeli", System.Data.SqlDbType.Int, 4, "funccodeprprdeli"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodebrneorde", System.Data.SqlDbType.Int, 4, "funccodebrneorde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodeprprorde", System.Data.SqlDbType.Int, 4, "funccodeprprorde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buni_key", System.Data.SqlDbType.Int, 4, "buni_key"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codetmplcode", System.Data.SqlDbType.VarChar, 2, "codetmplcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@funccodeacce", System.Data.SqlDbType.Int, 4, "funccodeacce"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmtrantime", System.Data.SqlDbType.SmallInt, 2, "firmtrantime"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmpartserv", System.Data.SqlDbType.VarChar, 1, "firmpartserv"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmminiperc", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(2, Byte), "firmminiperc", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmrealqualctrl", System.Data.SqlDbType.VarChar, 1, "firmrealqualctrl"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmleve", System.Data.SqlDbType.SmallInt, 2, "firmleve"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmorde", System.Data.SqlDbType.SmallInt, 2, "firmorde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmdelidays", System.Data.SqlDbType.SmallInt, 2, "firmdelidays"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@txts_key", System.Data.SqlDbType.Int, 4, "txts_key"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmdatedrop", System.Data.SqlDbType.DateTime, 8, "firmdatedrop"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@docu_key", System.Data.SqlDbType.Int, 4, "docu_key"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plancodeter2", System.Data.SqlDbType.VarChar, 4, "plancodeter2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@addrcodezone", System.Data.SqlDbType.Int, 4, "addrcodezone"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tfircod2", System.Data.SqlDbType.VarChar, 2, "tfircod2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@plancodefir2", System.Data.SqlDbType.VarChar, 4, "plancodefir2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firminvonumb", System.Data.SqlDbType.SmallInt, 2, "firminvonumb"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_keytabl", System.Data.SqlDbType.Int, 4, "firm_keytabl"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tablcode", System.Data.SqlDbType.VarChar, 18, "tablcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@trac_key", System.Data.SqlDbType.Int, 4, "trac_key"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT firm.firm_key, firm.addrcodemain, firm.addrcodedeli, firm.addrcodeinvo, fi" & _
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
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
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
        'Ds_episcode1
        '
        Me.Ds_episcode1.DataSetName = "ds_episcode"
        Me.Ds_episcode1.EnforceConstraints = False
        Me.Ds_episcode1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter13
        '
        Me.SqlDataAdapter13.SelectCommand = Me.SqlSelectCommand13
        Me.SqlDataAdapter13.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "acco", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("acco_key", "acco_key")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT acco_key FROM acco"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        '
        'Ds_datos_captura_garante_poliza1
        '
        Me.Ds_datos_captura_garante_poliza1.DataSetName = "ds_datos_captura_garante_poliza"
        Me.Ds_datos_captura_garante_poliza1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter14
        '
        Me.SqlDataAdapter14.SelectCommand = Me.SqlSelectCommand14
        Me.SqlDataAdapter14.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_DATOS_CAPTURA_GARANTE2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("num_poliza", "num_poliza"), New System.Data.Common.DataColumnMapping("num_autori", "num_autori")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "[SP_CIMACEX_DATOS_CAPTURA_GARANTE2]"
        Me.SqlSelectCommand14.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        Me.SqlSelectCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand14.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'Ds_incidencias1
        '
        Me.Ds_incidencias1.DataSetName = "ds_incidencias"
        Me.Ds_incidencias1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter15
        '
        Me.SqlDataAdapter15.SelectCommand = Me.SqlSelectCommand15
        Me.SqlDataAdapter15.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_INCIDENCIAS_EPISODIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_incidencia_episodio", "id_incidencia_episodio"), New System.Data.Common.DataColumnMapping("codigo_inc", "codigo_inc"), New System.Data.Common.DataColumnMapping("descripcion_inc", "descripcion_inc")})})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "[SP_CIMACEX_INCIDENCIAS_EPISODIO]"
        Me.SqlSelectCommand15.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand15.Connection = Me.SqlConnection2
        Me.SqlSelectCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand15.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter16
        '
        Me.SqlDataAdapter16.SelectCommand = Me.SqlSelectCommand16
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = "[SP_CIMACEX_INCIDENCIAS]"
        Me.SqlSelectCommand16.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand16.Connection = Me.SqlConnection2
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand16.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'Ds_incidencia_episodio1
        '
        Me.Ds_incidencia_episodio1.DataSetName = "ds_incidencia_episodio"
        Me.Ds_incidencia_episodio1.EnforceConstraints = False
        Me.Ds_incidencia_episodio1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_datos_captura1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_apporend1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_garante1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_csta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_cstahper1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_cstahper2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_csta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_cstahper3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_cstahper4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_prestaciones_agen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_firm_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_episcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_garante_poliza1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_incidencias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_incidencia_episodio1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_datos_captura1 As cimaweb.ds_datos_captura
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_apporend1 As cimaweb.ds_apporend
    Protected WithEvents Ds_datos_captura_garante1 As cimaweb.ds_datos_captura_garante
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_datos_captura_csta1 As cimaweb.ds_datos_captura_csta
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_datos_captura_cstahper1 As cimaweb.ds_datos_captura_cstahper
    Protected WithEvents Ds_datos_captura_cstahper2 As cimaweb.ds_datos_captura_cstahper
    Protected WithEvents Ds_csta1 As cimaweb.ds_csta
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_csta2 As cimaweb.ds_csta
    Protected WithEvents SqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_datos_captura_cstahper3 As cimaweb.ds_datos_captura_cstahper
    Protected WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_datos_captura_cstahper4 As cimaweb.ds_datos_captura_cstahper
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents Ds_hpro1 As cimaweb.ds_hpro
    Protected WithEvents SqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_datos_captura_prestaciones_agen1 As cimaweb.ds_datos_captura_prestaciones_agen
    Protected WithEvents SqlDataAdapter10 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter11 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Ds_firm_garantes1 As cimaweb.ds_firm_garantes
    Protected WithEvents Ds_covegrou1 As cimaweb.ds_covegrou
    Protected WithEvents SqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_episcode1 As cimaweb.ds_episcode
    Protected WithEvents SqlDataAdapter13 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist9 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label25 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist10 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label16 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents num_poliza As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label26 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents firm_key_1 As System.Web.UI.WebControls.Label
    Protected WithEvents covegrou_key_1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label27 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label28 As System.Web.UI.WebControls.Label
    Protected WithEvents num_peticion As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_datos_captura_garante_poliza1 As cimaweb.ds_datos_captura_garante_poliza
    Protected WithEvents SqlDataAdapter14 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label29 As System.Web.UI.WebControls.Label
    Protected WithEvents Label32 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist11 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter15 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter16 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataList2 As System.Web.UI.WebControls.DataList
    Protected WithEvents Ds_incidencias1 As cimaweb.ds_incidencias
    Protected WithEvents Ds_incidencia_episodio1 As cimaweb.ds_incidencia_episodio

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

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If Len(Trim(Request("episcode"))) > 0 Then
            Session("episcode") = Request("episcode")
        End If

        If Request("eliminar_prestacion") = "S" Then

            str_sql = "dbo.SP_CIMACEX_BAJA_PRESTACION " & Request("bookproc_key")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            'Response.Write("aaa: " & Request("bookproc_key"))

            

            If Len(Trim(Request("DropDownList5"))) > 0 And Request("DropDownList5") <> "-- PROPIO PACIENTE --" Then

                Me.Ds_datos_captura_cstahper3.Clear()

                Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = Request("DropDownList4")
                Me.SqlConnection1.Open()
                Me.SqlDataAdapter7.Fill(Me.Ds_datos_captura_cstahper3.cstahper)
                Me.SqlConnection1.Close()
                Me.DropDownList5.DataBind()

                Me.DropDownList5.SelectedValue = Request("DropDownList5")

            End If

            

            If Len(Trim(Request("DropDownList7"))) > 0 And Request("DropDownList7") <> "-- PROPIO PACIENTE --" Then

                Me.Ds_datos_captura_cstahper4.Clear()

                Me.SqlDataAdapter8.SelectCommand.Parameters(0).Value = Request("DropDownList6")
                Me.SqlConnection1.Open()
                Me.SqlDataAdapter8.Fill(Me.Ds_datos_captura_cstahper4.cstahper)
                Me.SqlConnection1.Close()
                Me.DropDownList7.DataBind()

                Me.DropDownList7.SelectedValue = Request("DropDownList7")

            End If

        End If

        'JGM - Funcion dar de baja la incidencia
        If Request("eliminar_incidencia") = "S" Then

            str_sql = "dbo.SP_CIMACEX_BAJA_INCIDENCIA_EPISODIO " & Request("id_incidencia_episodio")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        End If
        'JGM

        'Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_apporend1.apporend)
        Me.SqlConnection1.Close()

        Me.DropDownList1.DataBind()

        If Len(Trim(Request("DropDownList1"))) > 0 Then
            Me.DropDownList1.SelectedValue = Request("DropDownList1")
        Else
            Me.DropDownList1.SelectedValue = "5 "
        End If

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_datos_captura1.SP_CIMACEX_DATOS_CAPTURA)
        Me.SqlConnection1.Close()

        Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_datos_captura_garante1.SP_CIMACEX_DATOS_CAPTURA_GARANTE)
        Me.SqlConnection1.Close()

        Me.SqlDataAdapter14.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter14.Fill(Me.Ds_datos_captura_garante_poliza1.SP_CIMACEX_DATOS_CAPTURA_GARANTE2)
        Me.SqlConnection1.Close()

        Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter5.Fill(Me.Ds_datos_captura_csta1.csta)
        Me.SqlConnection1.Close()

        Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Me.Ds_datos_captura_csta1.csta.Rows(0).Item(0)
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter4.Fill(Me.Ds_datos_captura_cstahper1.cstahper)
        Me.SqlDataAdapter4.Fill(Me.Ds_datos_captura_cstahper2.cstahper)
        Me.SqlConnection1.Close()

        'Me.SqlDataAdapter6.SelectCommand.Parameters(0).Value = Me.Ds_datos_captura_csta1.csta.Rows(0).Item(0)
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter6.Fill(Me.Ds_csta1.csta)
        Me.SqlDataAdapter6.Fill(Me.Ds_csta2.csta)
        Me.SqlConnection1.Close()

        Me.DropDownList2.DataBind()
        Me.DropDownList3.DataBind()

        Me.DropDownList4.DataBind()
        Me.DropDownList6.DataBind()

        Me.DropDownList2.Items.Insert(0, "")
        Me.DropDownList3.Items.Insert(0, "")

        'Me.DropDownList4.Items.Insert(0, "")
        Me.DropDownList4.Items.Insert(0, "-- PROPIO PACIENTE --")
        'Me.DropDownList6.Items.Insert(0, "")
        Me.DropDownList6.Items.Insert(0, "-- PROPIO PACIENTE --")

        If Len(Trim(Request("DropDownList2"))) > 0 Then
            Me.DropDownList2.SelectedValue = Request("DropDownList2")
        End If
        If Len(Trim(Request("DropDownList3"))) > 0 Then
            Me.DropDownList3.SelectedValue = Request("DropDownList3")
        End If
        If Len(Trim(Request("DropDownList4"))) > 0 Then
            Me.DropDownList4.SelectedValue = Request("DropDownList4")
        End If
        If Len(Trim(Request("DropDownList6"))) > 0 Then
            Me.DropDownList6.SelectedValue = Request("DropDownList6")
        End If

        Me.Label2.DataBind()
        Me.Label4.DataBind()
        If IsPostBack = False Then
            Me.TextBox2.DataBind()
            Me.TextBox1.DataBind()
        End If

        Me.Label10.DataBind()
        Me.Label11.DataBind()
        Me.firm_key_1.DataBind()
        Me.covegrou_key_1.DataBind()
        If IsPostBack = False Then
            Me.TextBox5.DataBind()
            Me.TextBox6.DataBind()
        End If

        Me.SqlDataAdapter9.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter9.Fill(Me.Ds_hpro1.hpro)
        Me.SqlConnection1.Close()

        Me.DataList1.DataBind()

        Me.SqlDataAdapter10.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter10.Fill(Me.Ds_datos_captura_prestaciones_agen1.SP_CIMACEX_PRESTACIONES_AGEN)
        Me.SqlConnection1.Close()

        Me.Dropdownlist8.DataBind()

        Me.Dropdownlist8.Items.Insert(0, "")

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter11.Fill(Me.Ds_firm_garantes1.firm)
        Me.SqlConnection1.Close()

        Me.Dropdownlist9.DataBind()

        Me.Dropdownlist9.Items.Insert(0, "")
        Me.Dropdownlist9.Items.Insert(1, "PROPIO PACIENTE")

        'JGM -- Recuperem les incidències de l'episodi:
        Me.SqlDataAdapter15.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection2.Open()
        Me.SqlDataAdapter15.Fill(Me.Ds_incidencia_episodio1.incidencia_episodio)
        Me.SqlConnection2.Close()

        Me.DataList2.DataBind()

        'Recuperem les incidències possibles:
        Me.SqlDataAdapter16.SelectCommand.Parameters(1).Value = Session("episcode")
        Me.SqlConnection2.Open()
        Me.SqlDataAdapter16.Fill(Me.Ds_incidencias1.incidencias)
        Me.SqlConnection2.Close()

        Me.Dropdownlist11.DataBind()
        Me.Dropdownlist11.Items.Insert(0, "")

        'JGM 
    End Sub

    Private Sub DropDownList4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged

        If Request("DropDownList4") = "-- PROPIO PACIENTE --" Then

            Me.Ds_datos_captura_cstahper3.cstahper.Clear()
            Me.DropDownList5.DataBind()

        Else

            Me.SqlDataAdapter7.SelectCommand.Parameters(0).Value = Request("DropDownList4")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter7.Fill(Me.Ds_datos_captura_cstahper3.cstahper)
            Me.SqlConnection1.Close()
            Me.DropDownList5.DataBind()

        End If

        Me.DropDownList4.SelectedValue = Request("DropDownList4")
        Me.DropDownList6.SelectedValue = Request("DropDownList6")
        Me.Dropdownlist9.SelectedValue = Request("DropDownList9")

    End Sub

    Private Sub DropDownList6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList6.SelectedIndexChanged

        If Request("DropDownList4") = "-- PROPIO PACIENTE --" Then

            Me.Ds_datos_captura_cstahper4.cstahper.Clear()
            Me.DropDownList7.DataBind()

        Else

            Me.SqlDataAdapter8.SelectCommand.Parameters(0).Value = Request("DropDownList6")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter8.Fill(Me.Ds_datos_captura_cstahper4.cstahper)
            Me.SqlConnection1.Close()
            Me.DropDownList7.DataBind()

        End If

        Me.DropDownList6.SelectedValue = Request("DropDownList6")
        Me.DropDownList4.SelectedValue = Request("DropDownList4")
        Me.Dropdownlist9.SelectedValue = Request("DropDownList9")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Panel1.Visible = True
        Me.Button1.Enabled = False

    End Sub

    Private Sub Dropdownlist9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist9.SelectedIndexChanged

        Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = Request("DropDownList9")
        If Me.SqlDataAdapter12.SelectCommand.Parameters(1).Value = "PROPIO PACIENTE" Then
            Me.Dropdownlist10.Items.Clear()
            Me.Dropdownlist10.Items.Insert(0, "PRIVADO")
        Else
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter12.Fill(Me.Ds_covegrou1.covegrou)
            Me.SqlConnection1.Close()
            Me.Dropdownlist10.DataBind()

            Me.Dropdownlist10.Items.Insert(0, "")
        End If

        Me.DropDownList6.SelectedValue = Request("DropDownList6")
        Me.DropDownList4.SelectedValue = Request("DropDownList4")
        Me.Dropdownlist9.SelectedValue = Request("DropDownList9")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If Len(Trim(Request("Dropdownlist9"))) > 0 And Len(Trim(Request("Dropdownlist10"))) > 0 Then
            If Request("Dropdownlist9") = "PROPIO PACIENTE" Then
                str_sql = "dbo.SP_CIMACEX_ALTA_GARANTE_EPISODIO_CAPTURA " & 0 & ",'" & Session("episcode") & "'," & 6 & ",'" & Me.num_poliza.Text & "','" & Me.num_peticion.Text & "'"
            Else
                str_sql = "dbo.SP_CIMACEX_ALTA_GARANTE_EPISODIO_CAPTURA " & Request("Dropdownlist9") & ",'" & Session("episcode") & "'," & Request("Dropdownlist10") & ",'" & Me.num_poliza.Text & "','" & Me.num_peticion.Text & "'"
            End If
            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            Me.Ds_datos_captura_garante1.Clear()
            Me.Ds_datos_captura_garante_poliza1.Clear()

            Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = Session("episcode")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_datos_captura_garante1.SP_CIMACEX_DATOS_CAPTURA_GARANTE)
            Me.SqlConnection1.Close()

            Me.SqlDataAdapter14.SelectCommand.Parameters(1).Value = Session("episcode")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter14.Fill(Me.Ds_datos_captura_garante_poliza1.SP_CIMACEX_DATOS_CAPTURA_GARANTE2)
            Me.SqlConnection1.Close()

            Me.Label10.DataBind()
            Me.Label11.DataBind()
            Me.firm_key_1.DataBind()
            Me.covegrou_key_1.DataBind()
            Me.TextBox5.DataBind()
            Me.TextBox6.DataBind()

            Me.DropDownList6.SelectedValue = Request("DropDownList6")
            Me.DropDownList4.SelectedValue = Request("DropDownList4")
            Me.Dropdownlist9.SelectedValue = Request("DropDownList9")


            Me.Panel1.Visible = False
            Me.Button1.Enabled = True

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Par mal definido o ausencia de garante. Imposible continuar.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If Len(Trim(Request("Dropdownlist8"))) > 0 Then

            str_sql = "dbo.SP_CIMACEX_ALTA_PRESTACION '" & Session("episcode") & "'," & Request("Dropdownlist8")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            Me.Ds_hpro1.Clear()

            Me.SqlDataAdapter9.SelectCommand.Parameters(1).Value = Session("episcode")
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter9.Fill(Me.Ds_hpro1.hpro)
            Me.SqlConnection1.Close()

            Me.DataList1.DataBind()

            'Me.DropDownList6.SelectedValue = Request("DropDownList6")
            'Me.DropDownList4.SelectedValue = Request("DropDownList4")
            'Me.Dropdownlist9.SelectedValue = Request("DropDownList9")

            Me.Panel1.Visible = False
            Me.Button1.Enabled = True

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar una prestación.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ls_sql As String
        Dim ls_servicio_origen, ls_servicio_destino, ls_medico_origen, ls_medico_destino, ls_informador As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        Dim objDS As New Data.DataSet

        Dim ls_firm_key, ls_covegrou_key As String



        If Len(Trim(Me.DropDownList2.SelectedValue)) > 0 Then

            If Me.DropDownList4.SelectedValue = "-- PROPIO PACIENTE --" Then
                ls_servicio_origen = "0"
                ls_medico_origen = "0"
            Else
                ls_servicio_origen = Me.DropDownList4.SelectedValue
                ls_medico_origen = Me.DropDownList5.SelectedValue
            End If

            If Me.DropDownList6.SelectedValue = "-- PROPIO PACIENTE --" Then
                ls_servicio_destino = "0"
                ls_medico_destino = "0"
            Else
                ls_servicio_destino = Me.DropDownList6.SelectedValue
                ls_medico_destino = Me.DropDownList7.SelectedValue
            End If

            If Len(Trim(Me.DropDownList3.SelectedValue)) > 0 Then

                ls_informador = Me.DropDownList3.SelectedValue

            Else

                ls_informador = "0"

            End If

            If CInt(Me.firm_key_1.Text) > 0 Then

                ls_firm_key = Me.firm_key_1.Text

            Else

                ls_firm_key = "0"

            End If

            If CInt(Me.covegrou_key_1.Text) > 0 Then

                ls_covegrou_key = Me.covegrou_key_1.Text

            Else

                ls_covegrou_key = "0"

            End If

            ls_sql = "[dbo].[SP_CIMACEX_CAPTURAR] " & _
               "'" & Session("episcode") & "','" & Me.TextBox2.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList1.SelectedValue & "," & ls_servicio_origen & "," & ls_servicio_destino & "," & ls_medico_origen & "," & _
            ls_medico_destino & "," & ls_informador & "," & Me.DropDownList2.SelectedValue & ",'" & _
            Me.TextBox2.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList2.SelectedValue & "," & ls_firm_key & "," & ls_covegrou_key & ",'" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "'"

            'ls_sql = "[dbo].[SP_CIMACEX_CAPTURAR] " & _
            '   "'" & Session("episcode") & "','" & Me.TextBox2.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList1.SelectedValue & "," & ls_servicio_origen & "," & ls_servicio_destino & "," & ls_medico_origen & "," & _
            'ls_medico_destino & "," & ls_informador & "," & Me.DropDownList2.SelectedValue & ",'" & _
            'Me.TextBox2.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList2.SelectedValue & "" '," & ls_firm_key & "," & ls_covegrou_key & ",'" & Me.num_poliza.Text & "','" & Me.num_peticion.Text & "'"

            'Me.SqlDataAdapter13.SelectCommand.Parameters(1).Value = Session("episcode")
            'Me.SqlDataAdapter13.SelectCommand.Parameters(2).Value = Me.TextBox2.Text
            'Me.SqlDataAdapter13.SelectCommand.Parameters(3).Value = Me.TextBox1.Text
            'Me.SqlDataAdapter13.SelectCommand.Parameters(4).Value = Me.DropDownList1.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(5).Value = Me.DropDownList4.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(6).Value = Me.DropDownList6.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(7).Value = Me.DropDownList5.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(8).Value = Me.DropDownList7.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(9).Value = Me.DropDownList3.SelectedValue
            'Me.SqlDataAdapter13.SelectCommand.Parameters(10).Value = Me.DropDownList2.SelectedValue

            'Me.SqlDataAdapter13.SelectCommand.Parameters(11).Value = Me.TextBox2.Text
            'Me.SqlDataAdapter13.SelectCommand.Parameters(12).Value = Me.TextBox1.Text
            'Me.SqlDataAdapter13.SelectCommand.Parameters(13).Value = Me.DropDownList2.SelectedValue

            objDS = objCIMA.f_consulta_CSaludR(ls_sql, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
            'objCIMA.f_consulta(ls_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            'Me.SqlDataAdapter13.SelectCommand.CommandText = ls_sql

            'Me.SqlConnection1.Open()
            'Me.SqlDataAdapter13.SelectCommand.ExecuteNonQuery()
            'Me.SqlConnection1.Close()

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Cita CAPTURADA con éxito.');" & vbCrLf)
            Response.Write("window.close();" & vbCrLf)
            Response.Write("window.opener.location.href='form_agendas.aspx?servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & Session("agenda_seleccionada") & "&dia_en_seleccion=" & Session("dia_seleccionado") & "';" & vbCrLf)
            Response.Write("</scr" & "ipt>")


        Else

                Response.Write("<script language=javascript>alert(""Falta especificar un MEDICO ACTUAL."");</script>")

            End If

    End Sub

   
   
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Len(Trim(Request("Dropdownlist11"))) > 0 Then

            str_sql = "dbo.SP_CIMACEX_ALTA_INCIDENCIA_EPISODIO '" & Session("episcode") & "'," & Request("Dropdownlist11")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Me.Ds_incidencia_episodio1.Clear()

            Me.SqlDataAdapter15.SelectCommand.Parameters(1).Value = Session("episcode")
            Me.SqlConnection2.Open()
            Me.SqlDataAdapter15.Fill(Me.Ds_incidencia_episodio1.incidencia_episodio)
            Me.SqlConnection2.Close()

            Me.DataList2.DataBind()

            Me.Panel1.Visible = False
            Me.Button1.Enabled = True

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar una incidencia.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

    End Sub
End Class
