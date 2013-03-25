Public Class form_mantenimiento_hcis
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_par_SNT_CIMA1 = New cimaweb.ds_par_SNT_CIMA
        Me.Ds_par_SNT_CIMA2 = New cimaweb.ds_par_SNT_CIMA
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen1 = New cimaweb.ds_agen
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen2 = New cimaweb.ds_agen
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen3 = New cimaweb.ds_agen
        Me.SqlDataAdapter7 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter8 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Ds_par_SNT_CIMA_garante1 = New cimaweb.ds_par_SNT_CIMA_garante
        Me.SqlDataAdapter9 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen4 = New cimaweb.ds_agen
        Me.SqlDataAdapter10 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Ds_covegrou1 = New cimaweb.ds_covegrou
        Me.SqlDataAdapter11 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.Ds_garante_hcis1 = New cimaweb.ds_garante_hcis
        Me.SqlDataAdapter12 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter13 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_par_SNT_CIMA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_par_SNT_CIMA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_par_SNT_CIMA_garante1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_garante_hcis1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_MAPEOS_TIPO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")}), New System.Data.Common.DataTableMapping("Table2", "Table2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_MAPEOS_TIPO]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.Char, 2))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_par_SNT_CIMA1
        '
        Me.Ds_par_SNT_CIMA1.DataSetName = "ds_par_SNT_CIMA"
        Me.Ds_par_SNT_CIMA1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_par_SNT_CIMA2
        '
        Me.Ds_par_SNT_CIMA2.DataSetName = "ds_par_SNT_CIMA"
        Me.Ds_par_SNT_CIMA2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_ID_MAPEO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")}), New System.Data.Common.DataTableMapping("Table2", "Table2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_RECUPERA_ID_MAPEO]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.VarChar, 2))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4))
        '
        'Ds_agen1
        '
        Me.Ds_agen1.DataSetName = "ds_agen"
        Me.Ds_agen1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT agencode AS Código, agenname AS Agenda FROM agen WHERE (agenacti = 'Y') OR" & _
        "DER BY agenname"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hpro", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT hprocode AS Código, hprodesclong AS Agenda FROM hpro WHERE (hproacti = 'Y'" & _
        ") ORDER BY hprodesclong"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'Ds_agen2
        '
        Me.Ds_agen2.DataSetName = "ds_agen"
        Me.Ds_agen2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT agencode AS Código, RTRIM(LTRIM(agenname)) AS Agenda FROM agen WHERE (agen" & _
        "code = @agencode)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 20, "Código"))
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT agencode AS Código, LTRIM(RTRIM(agenname)) + ' - ' + agencode AS Agenda FR" & _
        "OM agen WHERE (agenacti = 'Y') AND (NOT EXISTS (SELECT * FROM cima_SNT_mapeo_age" & _
        "n WHERE cima_SNT_mapeo_agen.agencode = agen.agencode)) ORDER BY agenname"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'Ds_agen3
        '
        Me.Ds_agen3.DataSetName = "ds_agen"
        Me.Ds_agen3.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter7
        '
        Me.SqlDataAdapter7.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter7.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT COALESCE (cima_SNT_mapeo_firm.agencode, ' ') AS Código, COALESCE " & _
        "(LTRIM(RTRIM(agen.agenname)) + ' - ' + LTRIM(RTRIM(cima_SNT_mapeo_firm.agencode)" & _
        "), COALESCE (cima_SNT_mapeo_firm.agencode, ' ')) AS Agenda FROM cima_SNT_mapeo_f" & _
        "irm LEFT OUTER JOIN agen ON agen.agencode = cima_SNT_mapeo_firm.agencode ORDER B" & _
        "Y COALESCE (LTRIM(RTRIM(agen.agenname)) + ' - ' + LTRIM(RTRIM(cima_SNT_mapeo_fir" & _
        "m.agencode)), COALESCE (cima_SNT_mapeo_firm.agencode, ' '))"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter8
        '
        Me.SqlDataAdapter8.SelectCommand = Me.SqlSelectCommand8
        Me.SqlDataAdapter8.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_MAPEOS_TIPO_GARANTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("codigo_CIMA", "codigo_CIMA"), New System.Data.Common.DataColumnMapping("desc_CIMA", "desc_CIMA"), New System.Data.Common.DataColumnMapping("codigo_HCIS", "codigo_HCIS"), New System.Data.Common.DataColumnMapping("desc_HCIS", "desc_HCIS"), New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong"), New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agen_HCIS", "agen_HCIS")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "[SP_CIMACEX_RECUPERA_MAPEOS_TIPO_GARANTE]"
        Me.SqlSelectCommand8.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'Ds_par_SNT_CIMA_garante1
        '
        Me.Ds_par_SNT_CIMA_garante1.DataSetName = "ds_par_SNT_CIMA_garante"
        Me.Ds_par_SNT_CIMA_garante1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter9
        '
        Me.SqlDataAdapter9.SelectCommand = Me.SqlSelectCommand9
        Me.SqlDataAdapter9.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "firm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT firm.firm_key AS Código, LTRIM(RTRIM(firm.firmcode)) + ' - ' + firm.firmna" & _
        "me AS Agenda FROM firm LEFT OUTER JOIN firmclas ON firm.firmclascode = firmclas." & _
        "firmclascode INNER JOIN curr ON firm.currcode = curr.currcode LEFT OUTER JOIN la" & _
        "ng ON firm.langcode = lang.langcode INNER JOIN ttaxgfir ON firm.ttaxgfircode = t" & _
        "taxgfir.ttaxgfircode INNER JOIN invc ON firm.invccode = invc.invccode INNER JOIN" & _
        " payc ON firm.payccode = payc.payccode WHERE (firm.tfircode = 'CU') AND (firm.fi" & _
        "rmguar = 'G') AND (firm.plancode = 'PF') AND (firm.firmacti = 'Y') ORDER BY LTRI" & _
        "M(RTRIM(firm.firmcode)) + ' - ' + firm.firmname"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'Ds_agen4
        '
        Me.Ds_agen4.DataSetName = "ds_agen"
        Me.Ds_agen4.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter10
        '
        Me.SqlDataAdapter10.SelectCommand = Me.SqlSelectCommand10
        Me.SqlDataAdapter10.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código"), New System.Data.Common.DataColumnMapping("Agenda", "Agenda")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT DISTINCT COALESCE (cima_SNT_mapeo_agen.agencode, ' ') AS Código, COALESCE " & _
        "(LTRIM(RTRIM(agen.agenname)) + ' - ' + LTRIM(RTRIM(cima_SNT_mapeo_agen.agencode)" & _
        "), COALESCE (cima_SNT_mapeo_agen.agencode, ' ')) AS Agenda FROM cima_SNT_mapeo_a" & _
        "gen LEFT OUTER JOIN agen ON agen.agencode = cima_SNT_mapeo_agen.agencode ORDER B" & _
        "Y COALESCE (LTRIM(RTRIM(agen.agenname)) + ' - ' + LTRIM(RTRIM(cima_SNT_mapeo_age" & _
        "n.agencode)), COALESCE (cima_SNT_mapeo_agen.agencode, ' '))"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'Ds_covegrou1
        '
        Me.Ds_covegrou1.DataSetName = "ds_covegrou"
        Me.Ds_covegrou1.EnforceConstraints = False
        Me.Ds_covegrou1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter11
        '
        Me.SqlDataAdapter11.SelectCommand = Me.SqlSelectCommand11
        Me.SqlDataAdapter11.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_COBERTURAS_FIRM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("covegrou_key", "covegrou_key"), New System.Data.Common.DataColumnMapping("covegroudesclong", "covegroudesclong")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "[SP_CIMACEX_COBERTURAS_FIRM]"
        Me.SqlSelectCommand11.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'Ds_garante_hcis1
        '
        Me.Ds_garante_hcis1.DataSetName = "ds_garante_hcis"
        Me.Ds_garante_hcis1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter12
        '
        Me.SqlDataAdapter12.SelectCommand = Me.SqlSelectCommand12
        Me.SqlDataAdapter12.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "x$_GARANTE_HCIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hcis", "hcis"), New System.Data.Common.DataColumnMapping("hcis_desc", "hcis_desc")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT GARANTE_HCIS AS hcis, LTRIM(RTRIM(GARANTE_HCIS)) + ' - ' + LTRIM(RTRIM(GAR" & _
        "ANTE_HCIS_DESC)) AS hcis_desc FROM x$_GARANTE_HCIS WHERE (NOT EXISTS (SELECT * F" & _
        "ROM cima_SNT_mapeo_firm WHERE agencode = @agencode AND ltrim(rtrim(GARANTE_HCIS)" & _
        ") = ltrim(rtrim(HCIScode)))) ORDER BY LTRIM(RTRIM(GARANTE_HCIS)) + ' - ' + LTRIM" & _
        "(RTRIM(GARANTE_HCIS_DESC))"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        Me.SqlSelectCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.Char, 6))
        '
        'SqlDataAdapter13
        '
        Me.SqlDataAdapter13.SelectCommand = Me.SqlSelectCommand13
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT GARANTE_HCIS AS hcis, LTRIM(RTRIM(GARANTE_HCIS)) + ' - ' + LTRIM(RTRIM(GAR" & _
        "ANTE_HCIS_DESC)) AS hcis_desc FROM x$_GARANTE_HCIS WHERE EXISTS (SELECT * FROM c" & _
        "ima_SNT_mapeo_firm WHERE agencode = @agencode AND ltrim(rtrim(GARANTE_HCIS)) = l" & _
        "trim(rtrim(HCIScode))) ORDER BY LTRIM(RTRIM(GARANTE_HCIS)) + ' - ' + LTRIM(RTRIM" & _
        "(GARANTE_HCIS_DESC))"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        Me.SqlSelectCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.Char, 6))
        CType(Me.Ds_par_SNT_CIMA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_par_SNT_CIMA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_par_SNT_CIMA_garante1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_covegrou1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_garante_hcis1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_par_SNT_CIMA1 As cimaweb.ds_par_SNT_CIMA
    Protected WithEvents Ds_par_SNT_CIMA2 As cimaweb.ds_par_SNT_CIMA
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_agen1 As cimaweb.ds_agen
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents codigo_HCIS As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents desc_HCIS As System.Web.UI.WebControls.TextBox
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents identificador As System.Web.UI.WebControls.TextBox
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents desc_CIMA As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_agen2 As cimaweb.ds_agen
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_agen3 As cimaweb.ds_agen
    Protected WithEvents SqlDataAdapter7 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter8 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Ds_par_SNT_CIMA_garante1 As cimaweb.ds_par_SNT_CIMA_garante
    Protected WithEvents SqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_agen4 As cimaweb.ds_agen
    Protected WithEvents SqlDataAdapter10 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_covegrou1 As cimaweb.ds_covegrou
    Protected WithEvents SqlDataAdapter11 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_garante_hcis1 As cimaweb.ds_garante_hcis
    Protected WithEvents SqlDataAdapter12 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter13 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand

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

        If IsPostBack = False Then
            Me.DropDownList1.Items.Insert(0, "")
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            Me.Button1.Visible = False

            Me.DropDownList3.Visible = False
            Me.Label7.Visible = False
        End If

        'Inicialitzem aquest camp perquè en el botó nou, canviem el datatextfield.
        Me.DropDownList2.DataTextField = "Código"

    End Sub

    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid1.CurrentPageIndex = e.NewPageIndex()

        cargar_pares()

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Me.Panel2.Visible = False
        Me.Panel3.Visible = False

        Me.DataGrid2.SelectedIndex = -1
        Me.DataGrid2.CurrentPageIndex = 0

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid1.CurrentPageIndex = 0

        Me.Button1.Visible = True

        If Me.DropDownList1.SelectedValue = "AG" Or Me.DropDownList1.SelectedValue = "PR" Then
            Me.Panel2.Visible = True

            Me.Label7.Visible = False
            Me.DropDownList3.Visible = False

            cargar_pares()

        Else
            If Me.DropDownList1.SelectedValue = "GA" Then

                Me.Panel3.Visible = True


                Me.Label7.Visible = True
                Me.DropDownList3.Visible = True

                ' Informem el desplegable de l'agenda

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter7.Fill(Me.Ds_agen3.agen)
                Me.SqlConnection1.Close()

                Me.DropDownList3.DataBind()

                Me.DropDownList3.Items.Add("-- TODAS --")
                cargar_pares_garante()
            Else
                Me.Button1.Visible = False
            End If
        End If

        Me.Panel1.Visible = False

        Me.Button1.Enabled = True
        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.Button2.Enabled = False
        Else
            Me.Button2.Enabled = True
        End If
        Me.Button3.Enabled = True

        Me.Button2.Visible = False
        Me.Button3.Visible = False
        Me.Button4.Visible = False



    End Sub

    Public Sub cargar_pares()

        If Len(Trim(Me.DropDownList1.SelectedValue)) > 0 Then

            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.DropDownList1.SelectedValue

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_par_SNT_CIMA1.ds_par_SNT_CIMA)

            Me.DataGrid1.DataBind()
            Me.SqlConnection1.Close()


        End If

    End Sub

    Public Sub cargar_pares_garante()

        Dim ls_agencode As String

        If Len(Trim(Me.DropDownList1.SelectedValue)) > 0 Then
            If Me.DropDownList3.SelectedValue = "-- TODAS --" Then
                ls_agencode = "TODAS"
            Else
                ls_agencode = Me.DropDownList3.SelectedValue
            End If

            Me.SqlDataAdapter8.SelectCommand.Parameters(0).Value = ls_agencode
            Me.SqlConnection1.Open()

            Me.SqlDataAdapter8.Fill(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante)

            Me.SqlConnection1.Close()

            Me.DataGrid2.DataBind()


        End If

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

        Me.Button2.Visible = True
        Me.Button3.Visible = True

        Me.Button1.Enabled = True
        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.Button2.Enabled = False
        End If
        Me.Button3.Enabled = True

        Me.Panel1.Visible = False
        Me.Button4.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Botó Nuevo
        Me.Panel1.Visible = True
        Me.Button4.Visible = True

        Me.SqlConnection1.Open()
        If Me.DropDownList1.SelectedValue = "AG" Then
            Me.SqlDataAdapter6.SelectCommand.CommandText = "SELECT agencode AS Código, ltrim(rtrim(agenname)) + ' - ' + agencode AS Agenda FROM agen WHERE (agenacti = 'Y') and not exists (select * from cima_SNT_mapeo_agen where cima_SNT_mapeo_agen.agencode = agen.agencode) ORDER BY agenname"
            Me.SqlDataAdapter6.Fill(Me.Ds_agen1.agen)
        End If

        If Me.DropDownList1.SelectedValue = "PR" Then
            Me.SqlDataAdapter6.SelectCommand.CommandText = "SELECT hprocode AS Código, hprocode + ' - ' + ltrim(rtrim(hprodesclong)) AS Agenda FROM hpro WHERE (hproacti = 'Y') ORDER BY 2"
            Me.SqlDataAdapter6.Fill(Me.Ds_agen1.agen)
        End If

        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.SqlDataAdapter9.Fill(Me.Ds_agen1.agen)
        End If

        Me.DropDownList2.DataTextField = "Agenda"

        Me.DropDownList2.DataBind()

        'Si estem en els garants, afegim el privat.
        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.DropDownList2.Items.Add("-- PRIVADO --")
        End If

        Me.DropDownList2.Enabled = True

        Me.SqlConnection1.Close()

        omplir_descripcio()

        Me.identificador.Text = ""
        Me.codigo_HCIS.Text = ""
        Me.desc_HCIS.Text = ""

        Me.codigo_HCIS.Enabled = True
        Me.desc_HCIS.Enabled = True


        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.Panel4.Visible = True
            Me.Panel5.Visible = False
            Me.DropDownList2.Enabled = True
            Me.DropDownList4.Enabled = True
            Me.DropDownList5.Enabled = True
            Me.DropDownList6.Enabled = True

            cargar_agendas()

            cargar_coberturas()

            If Len(Trim(Me.DropDownList3.SelectedValue)) > 0 And Me.DropDownList3.SelectedValue <> "-- TODAS --" Then
                Me.DropDownList4.SelectedValue = Me.DropDownList3.SelectedValue
            End If

            Me.SqlDataAdapter12.SelectCommand.Parameters(0).Value = Me.DropDownList4.SelectedValue
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter12.Fill(Me.Ds_garante_hcis1.garante_hcis)
            Me.SqlConnection1.Close()

            Me.DropDownList6.DataBind()

        Else
            Me.Panel4.Visible = False
            Me.Panel5.Visible = True
        End If

        Me.Button2.Enabled = False
        Me.Button3.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Botó Modificar

        If Me.DropDownList1.SelectedValue = "GA" Then
            If CInt(Me.DataGrid2.Items(Me.DataGrid2.SelectedIndex).Cells(1).Text) > 0 Then

                Me.Panel4.Visible = True
                Me.Panel5.Visible = False
                Me.DropDownList4.Enabled = False
                cargar_identificador_garante()

                cargar_agendas()

                If Len(Trim(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("agencode"))) > 0 Then
                    Me.DropDownList4.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("agencode")
                End If

                cargar_coberturas()

                If Len(Trim(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("covegrou_key"))) > 0 Then
                    Me.DropDownList5.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("covegrou_key")
                End If

                Me.SqlDataAdapter13.SelectCommand.Parameters(0).Value = Me.DropDownList4.SelectedValue
                Me.SqlConnection1.Open()
                Me.SqlDataAdapter13.Fill(Me.Ds_garante_hcis1.garante_hcis)
                Me.SqlConnection1.Close()

                Me.DropDownList6.DataBind()

                Me.DropDownList6.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("codigo_HCIS")

            End If
        Else
            Me.Panel4.Visible = False
            Me.Panel5.Visible = True
            If CInt(Me.DataGrid1.Items(Me.DataGrid1.SelectedIndex).Cells(1).Text) > 0 Then

                cargar_identificador()

            End If
        End If

        Me.Button1.Enabled = False
        Me.Button3.Enabled = False

        Me.codigo_HCIS.Enabled = True
        Me.desc_HCIS.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Botó Eliminar
        If Me.DropDownList1.SelectedValue = "GA" Then
            If CInt(Me.DataGrid2.Items(Me.DataGrid2.SelectedIndex).Cells(1).Text) > 0 Then

                Me.Panel4.Visible = True
                Me.Panel5.Visible = False
                cargar_identificador_garante()

                cargar_agendas()

                If Len(Trim(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("agencode"))) > 0 Then
                    Me.DropDownList4.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("agencode")
                End If

                cargar_coberturas()

                If Len(Trim(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("covegrou_key"))) > 0 Then
                    Me.DropDownList5.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("covegrou_key")
                End If

                Me.SqlDataAdapter13.SelectCommand.Parameters(0).Value = Me.DropDownList4.SelectedValue
                Me.SqlConnection1.Open()
                Me.SqlDataAdapter13.Fill(Me.Ds_garante_hcis1.garante_hcis)
                Me.SqlConnection1.Close()

                Me.DropDownList6.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("codigo_HCIS")

            End If
        Else
            Me.Panel4.Visible = False
            Me.Panel5.Visible = True
            If CInt(Me.DataGrid1.Items(Me.DataGrid1.SelectedIndex).Cells(1).Text) > 0 Then

                cargar_identificador()

            End If
        End If

        Me.codigo_HCIS.Enabled = False
        Me.desc_HCIS.Enabled = False

        Me.DropDownList4.Enabled = False
        Me.DropDownList5.Enabled = False
        Me.DropDownList6.Enabled = False

        Me.Button1.Enabled = False
        Me.Button2.Enabled = False


    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click

        'Botó Aceptar
        Dim str_menu As String
        Dim objDS As New Data.DataSet
        Dim objCIMA As New CIMA_Clases.CIMA

        Dim id_fila As Integer
        Dim li_codigo_cima_garante As Integer

        If Len(Trim(Me.identificador.Text)) > 0 Then
            id_fila = CInt(Me.identificador.Text)
        Else
            id_fila = 0
        End If

        If Me.Button1.Enabled = True Then

            ' Cal comprovar si estem donant d'alta una prestació que aquesta no existeixi!


            If Me.DropDownList1.SelectedValue = "GA" Then

                If Me.DropDownList2.SelectedValue = "-- PRIVADO --" Then
                    li_codigo_cima_garante = 0
                Else
                    li_codigo_cima_garante = CInt(Me.DropDownList2.SelectedValue)
                End If
                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO_GARANTE] 'I','" & Me.DropDownList1.SelectedValue & "',0," & li_codigo_cima_garante & ",'" & Me.desc_CIMA.Text & "','" & Me.DropDownList6.SelectedValue & "'," & Me.DropDownList5.SelectedValue & ",'" & Me.DropDownList4.SelectedValue & "'"
            Else
                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO] 'I','" & Me.DropDownList1.SelectedValue & "',0,'" & Me.DropDownList2.SelectedValue & "','" & Me.desc_CIMA.Text & "','" & Me.codigo_HCIS.Text & "','" & Me.desc_HCIS.Text & "'"
            End If


            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            If Me.DropDownList1.SelectedValue = "PR" Then
                If objDS.Tables(0).Rows(0).Item(0) = -1 Then
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Esta prestación ya está mapeada.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")
                Else
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Alta realizada con éxito.');" & vbCrLf)
                    Response.Write("alert(bt_control);" & vbCrLf)
                    Response.Write("</scr" & "ipt>")
                End If
            Else
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Alta realizada con éxito.');" & vbCrLf)
                Response.Write("alert(bt_control);" & vbCrLf)
                Response.Write("</scr" & "ipt>")
            End If

        End If

        If Me.Button2.Enabled = True Then

            If Me.DropDownList1.SelectedValue = "GA" Then

                If Me.DropDownList2.SelectedValue = "-- PRIVADO --" Then
                    li_codigo_cima_garante = 0
                Else
                    li_codigo_cima_garante = CInt(Me.DropDownList2.SelectedValue)
                End If

                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO_GARANTE] 'U','" & Me.DropDownList1.SelectedValue & "'," & id_fila & "," & li_codigo_cima_garante & ",'" & Me.desc_CIMA.Text & "','" & Me.DropDownList6.SelectedValue & "'," & Me.DropDownList5.SelectedValue & ",'" & Me.DropDownList4.SelectedValue & "'"
            Else
                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO] 'U','" & Me.DropDownList1.SelectedValue & "'," & id_fila & ",' ',' ','" & Me.codigo_HCIS.Text & "','" & Me.desc_HCIS.Text & "'"
            End If


            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Modificación realizada con éxito.');" & vbCrLf)
            Response.Write("alert(bt_control);" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        If Me.Button3.Enabled = True Then

            If Me.DropDownList1.SelectedValue = "GA" Then
                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO_GARANTE] 'D','" & Me.DropDownList1.SelectedValue & "'," & id_fila & ",0,' ',' ',0,' '"
            Else
                str_menu = "[dbo].[SP_CIMACEX_MODIFICACION_ID_MAPEO] 'D','" & Me.DropDownList1.SelectedValue & "'," & id_fila & ",' ',' ',' ',' '"
            End If


            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Baja realizada con éxito.');" & vbCrLf)
            Response.Write("alert(bt_control);" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        Me.Panel1.Visible = False
        Me.Button4.Visible = False

        Me.Button2.Visible = False
        Me.Button3.Visible = False

        If Me.DropDownList1.SelectedValue = "GA" Then
            cargar_pares_garante()
        Else
            cargar_pares()
        End If


        Me.DataGrid1.SelectedIndex = -1

        Me.DataGrid2.SelectedIndex = -1

    End Sub

    Public Sub cargar_identificador()

        Me.Panel1.Visible = True
        Me.Button4.Visible = True


        Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter2.SelectCommand.Parameters(2).Value = CInt(Me.DataGrid1.Items(Me.DataGrid1.SelectedIndex).Cells(1).Text)

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA)

        Me.SqlConnection1.Close()

        'Omplim els camps

        Me.identificador.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("id")

        'Si hem seleccionat agendes, carreguem el desplegable amb les agendes, i així successivament

        If Me.DropDownList1.SelectedValue = "AG" Then

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_agen1.agen)
            Me.SqlConnection1.Close()

            Me.DropDownList2.DataBind()

            Me.DropDownList2.SelectedValue = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("codigo_CIMA")
            Me.DropDownList2.Enabled = False

            Me.desc_CIMA.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("desc_CIMA")

            Me.codigo_HCIS.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("codigo_HCIS")
            Me.desc_HCIS.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("desc_HCIS")
        End If

        If Me.DropDownList1.SelectedValue = "PR" Then

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter4.Fill(Me.Ds_agen1.agen)
            Me.SqlConnection1.Close()

            Me.DropDownList2.DataBind()

            Me.DropDownList2.SelectedValue = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("codigo_CIMA")
            Me.DropDownList2.Enabled = False

            Me.desc_CIMA.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("desc_CIMA")

            Me.codigo_HCIS.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("codigo_HCIS")
            Me.desc_HCIS.Text = Me.Ds_par_SNT_CIMA2.ds_par_SNT_CIMA.Rows(0).Item("desc_HCIS")

        End If


    End Sub

    Public Sub cargar_identificador_garante()

        Me.Panel1.Visible = True
        Me.Button4.Visible = True

        Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter2.SelectCommand.Parameters(2).Value = CInt(Me.DataGrid2.Items(Me.DataGrid2.SelectedIndex).Cells(1).Text)

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante)

        Me.SqlConnection1.Close()

        'Omplim els camps

        Me.identificador.Text = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("id")

        'Carreguem el desplegable dels garants (camp CODI CIMA)

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter9.Fill(Me.Ds_agen1.agen)
        Me.SqlConnection1.Close()

        Me.DropDownList2.DataBind()

        Me.DropDownList2.Items.Add("-- PRIVADO --")

        If Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("codigo_CIMA") <> "0" Then
            Me.DropDownList2.SelectedValue = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("codigo_CIMA")
        Else
            Me.DropDownList2.SelectedValue = "-- PRIVADO --"
        End If

        Me.DropDownList2.Enabled = False

        Me.desc_CIMA.Text = Me.Ds_par_SNT_CIMA_garante1.ds_par_SNT_CIMA_garante.Rows(0).Item("desc_CIMA")

    End Sub

    Public Sub omplir_descripcio()

        'Omplim la descripció
        If Me.DropDownList1.SelectedValue = "AG" Then

            Me.SqlDataAdapter5.SelectCommand.CommandText = "SELECT agencode AS Código, RTRIM(LTRIM(agenname)) AS Agenda FROM agen WHERE (agencode = @agencode)"
            Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.DropDownList2.SelectedValue

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter5.Fill(Me.Ds_agen2.agen)

            Me.SqlConnection1.Close()

            Me.desc_CIMA.Text = Me.Ds_agen2.agen.Rows(0).Item("Agenda")
        End If

        If Me.DropDownList1.SelectedValue = "PR" Then

            Me.SqlDataAdapter5.SelectCommand.CommandText = "SELECT hprocode AS Código, RTRIM(LTRIM(hprodesclong)) AS Agenda FROM hpro WHERE (hprocode = @agencode)"
            Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = Me.DropDownList2.SelectedValue

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter5.Fill(Me.Ds_agen2.agen)

            Me.SqlConnection1.Close()

            Me.desc_CIMA.Text = Me.Ds_agen2.agen.Rows(0).Item("Agenda")
        End If

        If Me.DropDownList1.SelectedValue = "GA" Then

            Me.SqlDataAdapter5.SelectCommand.CommandText = "SELECT firm_key AS Código, LTRIM(RTRIM(firm.firmcode)) + ' - ' + firm.firmname AS Agenda FROM firm WHERE (firm_key = @agencode)"

            If Me.DropDownList2.SelectedValue = "-- PRIVADO --" Then
                Me.desc_CIMA.Text = "-- PRIVADO --"
            Else
                Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = CInt(Me.DropDownList2.SelectedValue)
                Me.SqlConnection1.Open()

                Me.SqlDataAdapter5.Fill(Me.Ds_agen2.agen)

                Me.SqlConnection1.Close()

                Me.desc_CIMA.Text = Me.Ds_agen2.agen.Rows(0).Item("Agenda")
            End If

        End If
    End Sub

    Public Sub cargar_agendas()

        Me.Ds_agen4.Clear()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter10.Fill(Me.Ds_agen4.agen)

        Me.SqlConnection1.Close()

        Me.DropDownList4.DataBind()


    End Sub

    Public Sub cargar_coberturas()

        Dim li_cobertura As Integer

        Me.Ds_covegrou1.Clear()

        If Me.DropDownList2.SelectedValue = "-- PRIVADO --" Then
            li_cobertura = 0
        Else
            li_cobertura = CInt(Me.DropDownList2.SelectedValue)
        End If

        Me.SqlDataAdapter11.SelectCommand.Parameters(0).Value = li_cobertura
        Me.SqlConnection1.Open()

        Me.SqlDataAdapter11.Fill(Me.Ds_covegrou1.covegrou)

        Me.SqlConnection1.Close()

        Me.DropDownList5.DataBind()

    End Sub

    Private Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged

        omplir_descripcio()

        If Me.DropDownList1.SelectedValue = "GA" Then
            cargar_coberturas()
        End If

    End Sub

    Private Sub DropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList3.SelectedIndexChanged

        Me.Panel1.Visible = False
        Me.Panel4.Visible = False
        Me.Panel5.Visible = False

        Me.Button1.Enabled = True
        Me.Button2.Visible = False
        Me.Button3.Visible = False

        Me.DataGrid2.SelectedIndex = -1
        Me.DataGrid2.CurrentPageIndex = 0

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid1.CurrentPageIndex = 0

        cargar_pares_garante()

    End Sub

    Private Sub DataGrid2_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid2.PageIndexChanged

        Me.DataGrid2.SelectedIndex = -1
        Me.DataGrid2.CurrentPageIndex = e.NewPageIndex()

        cargar_pares_garante()
    End Sub

    Private Sub DataGrid2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.SelectedIndexChanged
        Me.Button2.Visible = True
        Me.Button3.Visible = True

        Me.Button1.Enabled = True
        If Me.DropDownList1.SelectedValue = "GA" Then
            Me.Button2.Enabled = False
        End If
        Me.Button3.Enabled = True

        Me.Panel1.Visible = False
        Me.Button4.Visible = False
    End Sub

    Private Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged

        Me.SqlDataAdapter12.SelectCommand.Parameters(0).Value = Me.DropDownList4.SelectedValue
        Me.SqlConnection1.Open()
        Me.SqlDataAdapter12.Fill(Me.Ds_garante_hcis1.garante_hcis)
        Me.SqlConnection1.Close()

        Me.DropDownList6.DataBind()
    End Sub
End Class
