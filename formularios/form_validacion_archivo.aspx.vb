Public Class form_validacion_archivo
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_validacion_poliza1 = New cimaweb.ds_validacion_poliza
        Me.Ds_cima_SANITAS1 = New cimaweb.ds_cima_SANITAS
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_validacion_du1 = New cimaweb.ds_validacion_du
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Ds_v_producto1 = New cimaweb.ds_v_producto
        CType(Me.Ds_validacion_poliza1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_SANITAS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_validacion_du1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_v_producto1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_validacion_poliza1
        '
        Me.Ds_validacion_poliza1.DataSetName = "ds_validacion_poliza"
        Me.Ds_validacion_poliza1.EnforceConstraints = False
        Me.Ds_validacion_poliza1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_SANITAS1
        '
        Me.Ds_cima_SANITAS1.DataSetName = "ds_cima_SANITAS"
        Me.Ds_cima_SANITAS1.EnforceConstraints = False
        Me.Ds_cima_SANITAS1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_SANITAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("valor", "valor")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT valor FROM cima_SANITAS ORDER BY id_valor"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CM_SNT_CLAVE_500", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("retorno", "retorno")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[SP_CM_SNT_CLAVE_500]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pericode", System.Data.SqlDbType.Int, 4))
        '
        'Ds_validacion_du1
        '
        Me.Ds_validacion_du1.DataSetName = "ds_validacion_du"
        Me.Ds_validacion_du1.EnforceConstraints = False
        Me.Ds_validacion_du1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT DISTINCT invs.invs_key, CONVERT(varchar(10), invs.invsdate, 103) AS invsda" & _
        "te, cast(invs.pericode AS varchar) + '-' + replace([dbo].[f_cima_blancos_derecha" & _
        "](cast(invs.invsnumb AS varchar), 10), '*', ' ') AS factura, epis.episcode, repo" & _
        "rting.f_cima_paciente(epis.epis_key) AS paciente, [dbo].[f_cima_ceros_izquierda]" & _
        "([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 1), 4) + [dbo].[f_cima_ceros_" & _
        "izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13) + [dbo].[f_" & _
        "cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2) A" & _
        "S du, len([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs" & _
        ".invsobse, 1), 4) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs" & _
        "_ref](invs.invsobse, 2), 13) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_deco" & _
        "difica_invs_ref](invs.invsobse, 3), 2)) AS longitud, nota, multigarante, [dbo].[" & _
        "f_cima_dc_du]([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](" & _
        "invs.invsobse, 1), 4), [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_i" & _
        "nvs_ref](invs.invsobse, 2), 13)) AS dc FROM invs INNER JOIN lins ON invs.invs_ke" & _
        "y = lins.invs_key INNER JOIN detalepi ON lins.invs_key = detalepi.invs_key AND l" & _
        "ins.linsnumb = detalepi.linsnumb INNER JOIN [dbo].[cima_SNT_no_TIS] ON invs.invs" & _
        "numb = [cima_SNT_no_TIS].invsnumb AND invs.pericode = [cima_SNT_no_TIS].pericode" & _
        " AND invs.salecent_key = 6 LEFT JOIN [CIMACEX].[dbo].[cima_notas_episodio] ON [C" & _
        "IMACEX].[dbo].[cima_notas_episodio].epis_key = detalepi.epis_key LEFT JOIN epis " & _
        "ON epis.epis_key = detalepi.epis_key WHERE invs.firm_key = 6036 AND lins.linspro" & _
        "dtype = 'P' AND multigarante = 'N' AND (len([dbo].[f_cima_ceros_izquierda]([dbo]" & _
        ".[f_cima_decodifica_invs_ref](invs.invsobse, 1), 4) + [dbo].[f_cima_ceros_izquie" & _
        "rda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13) + [dbo].[f_cima_c" & _
        "eros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2)) <> 19 " & _
        "OR [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsob" & _
        "se, 1), 4) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](i" & _
        "nvs.invsobse, 2), 13) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_" & _
        "invs_ref](invs.invsobse, 3), 2) = '0000000000000000000' OR [dbo].[f_cima_dc_du](" & _
        "[dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse," & _
        " 1), 4), [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs." & _
        "invsobse, 2), 13)) = 'N') UNION ALL SELECT DISTINCT invs.invs_key, CONVERT(varch" & _
        "ar(10), invs.invsdate, 103) AS invsdate, cast(invs.pericode AS varchar) + '-' + " & _
        "replace([dbo].[f_cima_blancos_derecha](cast(invs.invsnumb AS varchar), 10), '*'," & _
        " ' ') AS factura, epis.episcode, reporting.f_cima_paciente(epis.epis_key) AS pac" & _
        "iente, [dbo].[f_cima_ceros_izquierda](LEFT(ltrim(COALESCE ([nota], '')), 3), 4) " & _
        "+ [dbo].[f_cima_ceros_izquierda](substring(ltrim(rtrim(COALESCE (COALESCE ([nota" & _
        "], ''), ''))), 4, 9), 13) + [dbo].[f_cima_ceros_izquierda](RIGHT(rtrim(COALESCE " & _
        "([nota], '')), 2), 2) AS du, len([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_de" & _
        "codifica_invs_ref](invs.invsobse, 1), 4) + [dbo].[f_cima_ceros_izquierda]([dbo]." & _
        "[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13) + [dbo].[f_cima_ceros_izquie" & _
        "rda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2)) AS longitud, nota" & _
        ", multigarante, [dbo].[f_cima_dc_du]([dbo].[f_cima_ceros_izquierda](LEFT(ltrim(C" & _
        "OALESCE ([nota], '')), 3), 4), [dbo].[f_cima_ceros_izquierda](substring(ltrim(rt" & _
        "rim(COALESCE (COALESCE ([nota], ''), ''))), 4, 9), 13)) AS dc FROM invs INNER JO" & _
        "IN lins ON invs.invs_key = lins.invs_key INNER JOIN detalepi ON lins.invs_key = " & _
        "detalepi.invs_key AND lins.linsnumb = detalepi.linsnumb INNER JOIN [dbo].[cima_S" & _
        "NT_no_TIS] ON invs.invsnumb = [cima_SNT_no_TIS].invsnumb AND invs.pericode = [ci" & _
        "ma_SNT_no_TIS].pericode AND invs.salecent_key = 6 LEFT JOIN [CIMACEX].[dbo].[cim" & _
        "a_notas_episodio] ON [CIMACEX].[dbo].[cima_notas_episodio].epis_key = detalepi.e" & _
        "pis_key LEFT JOIN epis ON epis.epis_key = detalepi.epis_key WHERE invs.firm_key " & _
        "= 6036 AND lins.linsprodtype = 'P' AND multigarante = 'S' AND (len(nota) <> 14 O" & _
        "R [dbo].[f_cima_dc_du]([dbo].[f_cima_ceros_izquierda](LEFT(ltrim(COALESCE ([nota" & _
        "], '')), 3), 4), [dbo].[f_cima_ceros_izquierda](substring(ltrim(rtrim(COALESCE (" & _
        "COALESCE ([nota], ''), ''))), 4, 9), 13)) = 'N')"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "invs", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("paciente", "paciente"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("longitud", "longitud"), New System.Data.Common.DataColumnMapping("invsnumb", "invsnumb"), New System.Data.Common.DataColumnMapping("dc", "dc")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT TOP 100 epis.episcode, reporting.f_cima_paciente(epis.epis_key) A" & _
        "S paciente, [reporting].f_cima_poliza_SNT(epis.epis_key) AS poliza, LEN([reporti" & _
        "ng].f_cima_poliza_SNT(epis.epis_key)) AS longitud, invs.invsnumb, [dbo].f_cima_d" & _
        "c_poliza([reporting].f_cima_poliza_SNT(epis.epis_key)) AS dc FROM invs INNER JOI" & _
        "N lins ON invs.invs_key = lins.invs_key INNER JOIN detalepi ON lins.invs_key = d" & _
        "etalepi.invs_key AND lins.linsnumb = detalepi.linsnumb INNER JOIN epis ON epis.e" & _
        "pis_key = detalepi.epis_key INNER JOIN cima_SNT_no_TIS ON invs.invsnumb = cima_S" & _
        "NT_no_TIS.invsnumb AND invs.pericode = cima_SNT_no_TIS.pericode LEFT OUTER JOIN " & _
        "CIMACEX.dbo.cima_notas_episodio ON CIMACEX.dbo.cima_notas_episodio.epis_key = de" & _
        "talepi.epis_key WHERE (invs.salecent_key = 6) AND (lins.linsprodtype = 'P') AND " & _
        "(invs.firm_key = 6036) AND (LEN([reporting].f_cima_poliza_SNT(epis.epis_key)) <>" & _
        " 24) OR (invs.salecent_key = 6) AND (lins.linsprodtype = 'P') AND (invs.firm_key" & _
        " = 6036) AND ([reporting].f_cima_poliza_SNT(epis.epis_key) = '000000000000000000" & _
        "000000') OR (invs.salecent_key = 6) AND (lins.linsprodtype = 'P') AND (invs.firm" & _
        "_key = 6036) AND ([dbo].f_cima_dc_poliza([reporting].f_cima_poliza_SNT(epis.epis" & _
        "_key)) = 'N')"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT invs.invs_key, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONVERT(varchar(10), invs.invsdate, 103) AS invs" & _
        "date, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "cast(invs.pericode AS varchar) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "+ '-' + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "replace([dbo].[f_cima_blancos" & _
        "_derecha](cast(invs.invsnumb AS varchar), 10), '*', ' ') AS factura, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "epis.epis" & _
        "code, reporting.f_cima_paciente(epis.epis_key) AS paciente, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_cero" & _
        "s_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 1), 4) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo]." & _
        "[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 1" & _
        "3) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.in" & _
        "vsobse, 3), 2) AS du, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "len([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodif" & _
        "ica_invs_ref](invs.invsobse, 1), 4) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquierda]([dbo].[f_" & _
        "cima_decodifica_invs_ref](invs.invsobse, 2), 13) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquier" & _
        "da]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2)) AS longitud, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "not" & _
        "a, multigarante, [dbo].[f_cima_dc_du] ([dbo].[f_cima_ceros_izquierda]([dbo].[f_c" & _
        "ima_decodifica_invs_ref](invs.invsobse, 1), 4),[dbo].[f_cima_ceros_izquierda]([d" & _
        "bo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13)) as dc" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "FROM invs INNER " & _
        "JOIN lins ON invs.invs_key = lins.invs_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER JOIN detalepi ON lins.invs_ke" & _
        "y = detalepi.invs_key AND lins.linsnumb = detalepi.linsnumb " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER JOIN [dbo].[" & _
        "cima_SNT_no_TIS] " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ON invs.invsnumb = [cima_SNT_no_TIS].invsnumb AND invs.perico" & _
        "de = [cima_SNT_no_TIS].pericode " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "AND invs.salecent_key = 6 " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "LEFT JOIN [CIMACEX" & _
        "].[dbo].[cima_notas_episodio] " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ON [CIMACEX].[dbo].[cima_notas_episodio].epis_ke" & _
        "y = detalepi.epis_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "LEFT JOIN epis ON epis.epis_key = detalepi.epis_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WH" & _
        "ERE invs.firm_key = 6036 AND lins.linsprodtype = 'P' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "AND multigarante = 'N'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "A" & _
        "ND (len([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.i" & _
        "nvsobse, 1), 4) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_invs_r" & _
        "ef](invs.invsobse, 2), 13) + [dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodi" & _
        "fica_invs_ref](invs.invsobse, 3), 2)) <> 19 OR [dbo].[f_cima_ceros_izquierda]([d" & _
        "bo].[f_cima_decodifica_invs_ref](invs.invsobse, 1), 4) + [dbo].[f_cima_ceros_izq" & _
        "uierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13) + [dbo].[f_cim" & _
        "a_ceros_izquierda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2) = '0" & _
        "000000000000000000'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "OR [dbo].[f_cima_dc_du] ([dbo].[f_cima_ceros_izquierda]([db" & _
        "o].[f_cima_decodifica_invs_ref](invs.invsobse, 1), 4),[dbo].[f_cima_ceros_izquie" & _
        "rda]([dbo].[f_cima_decodifica_invs_ref](invs.invsobse, 2), 13)) = 'N')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "UNION " & _
        "ALL " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "SELECT DISTINCT invs.invs_key, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONVERT(varchar(10), invs.invsdate, 103" & _
        ") AS invsdate, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "cast(invs.pericode AS varchar) + '-' + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "replace([dbo].[f_cima_" & _
        "blancos_derecha](cast(invs.invsnumb AS varchar), 10), '*', ' ') AS factura, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ep" & _
        "is.episcode, reporting.f_cima_paciente(epis.epis_key) AS paciente, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_ci" & _
        "ma_ceros_izquierda](LEFT(ltrim(COALESCE ([nota], '')), 3), 4) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_" & _
        "ceros_izquierda](substring(ltrim(rtrim(COALESCE (COALESCE ([nota], ''), ''))), 4" & _
        ", 9), 13) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquierda](RIGHT(rtrim(COALESCE ([nota], ''))," & _
        " 2), 2) AS du, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "len([dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_decodifica_inv" & _
        "s_ref](invs.invsobse, 1), 4) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquierda]([dbo].[f_cima_de" & _
        "codifica_invs_ref](invs.invsobse, 2), 13) + " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[dbo].[f_cima_ceros_izquierda]([db" & _
        "o].[f_cima_decodifica_invs_ref](invs.invsobse, 3), 2)) AS longitud, " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "nota, mult" & _
        "igarante, [dbo].[f_cima_dc_du] ([dbo].[f_cima_ceros_izquierda](LEFT(ltrim(COALES" & _
        "CE ([nota], '')), 3), 4),[dbo].[f_cima_ceros_izquierda](substring(ltrim(rtrim(CO" & _
        "ALESCE (COALESCE ([nota], ''), ''))), 4, 9), 13)) as dc" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "FROM invs " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER JOIN " & _
        "lins ON invs.invs_key = lins.invs_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER JOIN detalepi ON lins.invs_key = d" & _
        "etalepi.invs_key AND lins.linsnumb = detalepi.linsnumb " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER JOIN [dbo].[cima_" & _
        "SNT_no_TIS] ON invs.invsnumb = [cima_SNT_no_TIS].invsnumb " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "AND invs.pericode = " & _
        "[cima_SNT_no_TIS].pericode AND invs.salecent_key = 6 " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "LEFT JOIN [CIMACEX].[dbo]" & _
        ".[cima_notas_episodio] " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ON [CIMACEX].[dbo].[cima_notas_episodio].epis_key = det" & _
        "alepi.epis_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "LEFT JOIN epis " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ON epis.epis_key = detalepi.epis_key " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE i" & _
        "nvs.firm_key = 6036 AND lins.linsprodtype = 'P' AND multigarante = 'S' AND " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(le" & _
        "n(nota) <> 14 OR [dbo].[f_cima_dc_du] ([dbo].[f_cima_ceros_izquierda](LEFT(ltrim" & _
        "(COALESCE ([nota], '')), 3), 4),[dbo].[f_cima_ceros_izquierda](substring(ltrim(r" & _
        "trim(COALESCE (COALESCE ([nota], ''), ''))), 4, 9), 13)) = 'N' OR nota is null)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CM_SNT_CLAVE_500_V_PRODUCTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("factura", "factura"), New System.Data.Common.DataColumnMapping("linsprodcode", "linsprodcode"), New System.Data.Common.DataColumnMapping("linsproddesc", "linsproddesc")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "[SP_CM_SNT_CLAVE_500_V_PRODUCTO]"
        Me.SqlSelectCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'Ds_v_producto1
        '
        Me.Ds_v_producto1.DataSetName = "ds_v_producto"
        Me.Ds_v_producto1.EnforceConstraints = False
        Me.Ds_v_producto1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_validacion_poliza1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_SANITAS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_validacion_du1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_v_producto1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid3 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_validacion_poliza1 As cimaweb.ds_validacion_poliza
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Ds_cima_SANITAS1 As cimaweb.ds_cima_SANITAS
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_validacion_du1 As cimaweb.ds_validacion_du
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_v_producto1 As cimaweb.ds_v_producto

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

        Me.Ds_validacion_du1.Clear()
        Me.Ds_validacion_poliza1.Clear()
        Me.Ds_v_producto1.Clear()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_validacion_du1.du)
        Me.SqlDataAdapter1.Fill(Me.Ds_validacion_poliza1.poliza)
        Me.SqlDataAdapter6.Fill(Me.Ds_v_producto1.v_producto)
        Me.SqlConnection1.Close()

        Me.DataGrid3.DataBind()
        Me.DataGrid1.DataBind()
        Me.DataGrid2.DataBind()

        If Me.Ds_validacion_du1.du.Rows.Count > 0 Or Me.Ds_validacion_poliza1.poliza.Rows.Count > 0 Or Me.Ds_v_producto1.v_producto.Rows.Count > 0 Then

            Me.Panel1.Visible = False

        Else

            Me.Panel1.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim objRow As ds_cima_SANITAS.cima_SANITASRow
        Dim objStreamWriter As System.IO.StreamWriter



        If IsNumeric(Me.TextBox1.Text) Then

            If IsDate(Me.TextBox2.Text) And IsDate(Me.TextBox3.Text) Then

                Me.SqlDataAdapter4.SelectCommand.Parameters(1).Value = Me.TextBox2.Text
                Me.SqlDataAdapter4.SelectCommand.Parameters(2).Value = Me.TextBox3.Text
                Me.SqlDataAdapter4.SelectCommand.Parameters(3).Value = Me.TextBox1.Text

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter4.SelectCommand.ExecuteNonQuery()
                Me.SqlConnection1.Close()

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter3.Fill(Me.Ds_cima_SANITAS1.cima_SANITAS)
                Me.SqlConnection1.Close()

                objStreamWriter = New System.IO.StreamWriter("\\atenea\z$\Administracion\clave_500\clave_500.txt")

                For Each objRow In Me.Ds_cima_SANITAS1.Tables(0).Rows

                    objStreamWriter.WriteLine(objRow.Item("valor"))

                Next

                objStreamWriter.Close()

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('El archivo clave_500.txt se ha creado con éxito en el compartido de Administracion\clave_500\ y está preparado para ser cargado en el portal.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Formato de fechas incorrecto.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Formato de periodo incorrecto.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If
        

    End Sub
End Class
