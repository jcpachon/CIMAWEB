Public Class form_pers
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_pers1 = New cimaweb.ds_pers
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_epis1 = New cimaweb.ds_epis
        Me.Ds_cima_epis_claves1 = New cimaweb.ds_cima_epis_claves
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_epis_informes1 = New cimaweb.ds_cima_epis_informes
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Ds_apporend1 = New cimaweb.ds_apporend
        Me.Ds_cima_alertas1 = New cimaweb.ds_cima_alertas
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_notas1 = New cimaweb.ds_cima_notas
        Me.Ds_recuperarDatosCita1 = New cimaweb.ds_recuperarDatosCita
        Me.AdapterRecuperarDatosCita = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_epis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_apporend1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_alertas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_notas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_recuperarDatosCita1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("idenperscod1", "idenperscod1"), New System.Data.Common.DataColumnMapping("addrcode", "addrcode"), New System.Data.Common.DataColumnMapping("idenperscod2", "idenperscod2"), New System.Data.Common.DataColumnMapping("titlcode", "titlcode"), New System.Data.Common.DataColumnMapping("posttitlcode", "posttitlcode"), New System.Data.Common.DataColumnMapping("apuscode", "apuscode"), New System.Data.Common.DataColumnMapping("tsexcode", "tsexcode"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("persdatechag", "persdatechag"), New System.Data.Common.DataColumnMapping("persacti", "persacti"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2"), New System.Data.Common.DataColumnMapping("persbirtdate", "persbirtdate"), New System.Data.Common.DataColumnMapping("persnickname", "persnickname"), New System.Data.Common.DataColumnMapping("imag_key", "imag_key"), New System.Data.Common.DataColumnMapping("persmai1", "persmai1"), New System.Data.Common.DataColumnMapping("persmai2", "persmai2"), New System.Data.Common.DataColumnMapping("persrema", "persrema"), New System.Data.Common.DataColumnMapping("codetmplcode", "codetmplcode"), New System.Data.Common.DataColumnMapping("perscode", "perscode"), New System.Data.Common.DataColumnMapping("perssitucode", "perssitucode"), New System.Data.Common.DataColumnMapping("civistatcode", "civistatcode"), New System.Data.Common.DataColumnMapping("terr_key", "terr_key"), New System.Data.Common.DataColumnMapping("persdatecalc", "persdatecalc"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("msrepl_tran_version", "msrepl_tran_version")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT pers_key, idenperscod1, addrcode, idenperscod2, titlcode, posttitlcode, ap" & _
        "uscode, tsexcode, plancode, persdatechag, persacti, perssur1, perssur2, persname" & _
        ", persidencod1, persidencod2, persbirtdate, persnickname, imag_key, persmai1, pe" & _
        "rsmai2, persrema, codetmplcode, perscode, perssitucode, civistatcode, terr_key, " & _
        "persdatecalc, docu_key, persfullname, msrepl_tran_version FROM pers"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_pers1
        '
        Me.Ds_pers1.DataSetName = "ds_pers"
        Me.Ds_pers1.EnforceConstraints = False
        Me.Ds_pers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT episcode FROM epis"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
        '
        'Ds_epis1
        '
        Me.Ds_epis1.DataSetName = "ds_epis"
        Me.Ds_epis1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_epis_claves1
        '
        Me.Ds_cima_epis_claves1.DataSetName = "ds_cima_epis_claves"
        Me.Ds_cima_epis_claves1.EnforceConstraints = False
        Me.Ds_cima_epis_claves1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_claves", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("clave", "clave"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("descargado", "descargado")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT episcode, clave, fecha, descargado FROM cima_epis_claves WHERE (episcode =" & _
        " @episcode)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_CLAVE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_ALTA_CLAVE]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10))
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_informes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("numero", "numero"), New System.Data.Common.DataColumnMapping("informe", "informe"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT episcode, id_usuario, numero, informe, fecha FROM cima_epis_informes WHERE" & _
        " (episcode = @episcode) AND (numero = @numero)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero", System.Data.SqlDbType.Int, 4, "numero"))
        '
        'Ds_cima_epis_informes1
        '
        Me.Ds_cima_epis_informes1.DataSetName = "ds_cima_epis_informes"
        Me.Ds_cima_epis_informes1.EnforceConstraints = False
        Me.Ds_cima_epis_informes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "appo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("apporendcode", "apporendcode")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT COALESCE (appo.apporendcode, '0') AS apporendcode FROM appo INNER JOIN epi" & _
        "s ON appo.epis_key = epis.epis_key WHERE (epis.episcode = @episcode)"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=PLUTON;packet size=4096;user id=sa;data source=JUPITER;persist sec" & _
        "urity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_apporend1
        '
        Me.Ds_apporend1.DataSetName = "ds_apporend"
        Me.Ds_apporend1.EnforceConstraints = False
        Me.Ds_apporend1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_alertas1
        '
        Me.Ds_cima_alertas1.DataSetName = "ds_cima_alertas"
        Me.Ds_cima_alertas1.EnforceConstraints = False
        Me.Ds_cima_alertas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlCommand1
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_informes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("numero", "numero"), New System.Data.Common.DataColumnMapping("informe", "informe"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "[SP_CIMACEX_RECUPERA_NOTAS_PERS]"
        Me.SqlCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        '
        'Ds_cima_notas1
        '
        Me.Ds_cima_notas1.DataSetName = "ds_cima_notas"
        Me.Ds_cima_notas1.EnforceConstraints = False
        Me.Ds_cima_notas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_recuperarDatosCita1
        '
        Me.Ds_recuperarDatosCita1.DataSetName = "ds_recuperarDatosCita"
        Me.Ds_recuperarDatosCita1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'AdapterRecuperarDatosCita
        '
        Me.AdapterRecuperarDatosCita.SelectCommand = Me.SqlSelectCommand5
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "[SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA]"
        Me.SqlSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.Char, 11))
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50))
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_epis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_apporend1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_alertas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_notas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_recuperarDatosCita1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_epis1 As cimaweb.ds_epis
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Button8 As System.Web.UI.WebControls.Button
    Protected WithEvents Button9 As System.Web.UI.WebControls.Button
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Button10 As System.Web.UI.WebControls.Button
    Protected WithEvents Label21 As System.Web.UI.WebControls.Label
    Protected WithEvents Label22 As System.Web.UI.WebControls.Label
    Protected WithEvents Label23 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Button11 As System.Web.UI.WebControls.Button
    Protected WithEvents Button12 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button13 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_cima_epis_claves1 As cimaweb.ds_cima_epis_claves
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_epis_informes1 As cimaweb.ds_cima_epis_informes
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_apporend1 As cimaweb.ds_apporend
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label111 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Textbox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button14 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_cima_alertas1 As cimaweb.ds_cima_alertas
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_notas1 As cimaweb.ds_cima_notas
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button15 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button16 As System.Web.UI.WebControls.Button
    Protected WithEvents Button17 As System.Web.UI.WebControls.Button
    Protected WithEvents BTmodificarDatos As System.Web.UI.WebControls.Button
    Public WithEvents Ds_recuperarDatosCita1 As cimaweb.ds_recuperarDatosCita
    Protected WithEvents AdapterRecuperarDatosCita As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents chek_anulada As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Button18 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button19 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel
    Protected WithEvents alerta As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Label24 As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_informes As New cr_obj_clave

    Public Function CheckBoxEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "S" Then
            returnValue = "True"
        Else
            returnValue = "False"
        End If

        Return returnValue

    End Function

    Public Function InactivaEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "Y" Then
            returnValue = "False"
        Else
            returnValue = "True"
        End If

        Return returnValue

    End Function

    Public Function EstadoEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "Y" Then
            returnValue = "<span class=""letra_muy_pequena_azul_negrita"">&nbsp;ACTIVO&nbsp;</span>"
        Else
            returnValue = "<span class=""letra_muy_pequena_rojo_negrita"">&nbsp;INACTIVO&nbsp;</span>"
        End If

        Return returnValue

    End Function

    Public Function SexoEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "2" Then
            returnValue = "MASCULINO"
        Else
            returnValue = "FEMENINO"
        End If

        Return returnValue

    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        Dim str_uid As String

        Dim str_menu As String
        Dim str_menu_ei As String

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS_USR As New Data.DataSet
        Dim objDS_ei As New Data.DataSet

        Dim lstr_fecha_nacimiento() As String
        Dim lstr_temporal() As String

        Dim ls_episcode_informe As String

        Dim ls_array_fecha_entrega() As String

        Dim ls_tipo As String



        If Request("abrir_informe") = "S" Then

            ls_episcode_informe = Request("episcode_informe")

            If Len(ls_episcode_informe) <> 11 Then

                ls_episcode_informe = Right(Request("episcode_informe"), 11)

            End If

            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = ls_episcode_informe
            Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = Request("numero_informe")

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_cima_epis_informes1.cima_epis_informes)
            Me.SqlConnection1.Close()

            Response.ClearContent()
            Response.ClearHeaders()
            Response.ContentType = "application/pdf"
            Response.AddHeader("Content-Disposition", _
            "attachment; filename=""" & ls_episcode_informe & ".pdf""")
            Response.BinaryWrite(Me.Ds_cima_epis_informes1.cima_epis_informes.Rows(0).Item("informe"))
            Response.Flush()
            Response.Close()

        ElseIf Request("abrir_informe") = "I" And Session("apporendcode") = "0" Then

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

            ls_array_fecha_entrega = Split(Request("fecha_entrega"), "/", , CompareMethod.Text)

            str_menu = "[dbo].[SP_CIMACEX_UPDATE_ESTADO_INFORME] '" & Request("episcode_informe") & "','10','" & Request("tipo") & "','" & ls_array_fecha_entrega(2) & "-" & ls_array_fecha_entrega(1) & "-" & ls_array_fecha_entrega(0) & "','" & Session("usuario") & "','" & Request("comentario") & "'"

            objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        End If

        If Session("grupo") = "A" Then

            Me.Button5.Visible = False
            Me.Button6.Visible = False
            'Me.Button9.Visible = False
            'Me.Button10.Visible = False
            'Me.Panel1.Visible = False
            'Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button7.Visible = False
            Me.Button8.Visible = False

            Me.TextBox1.Visible = True
            Me.Button14.Visible = True
            Me.Label14.Visible = True

        ElseIf Session("grupo") = "D" Then

            Me.TextBox1.Visible = True
            Me.Button14.Visible = True
            Me.Label14.Visible = True

        Else

            'Me.TextBox1.Visible = False
            'Me.Button14.Visible = False
            'Me.Label14.Visible = False

        End If

        If Session("episcode") Is Nothing And Request("episcode") Is Nothing Then



        Else

            If Len(Trim(Request("episcode"))) > 0 Then
                'If Len(Trim(Session("episcode"))) > 0 Then
                Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Request("episcode")
                'Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Session("episcode")
            Else
                'Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Request("episcode")
                Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Session("episcode")
            End If

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter4.Fill(Me.Ds_apporend1.apporend)
            Me.SqlConnection2.Close()

            If Me.Ds_apporend1.apporend.Rows.Count > 0 Then

                If Me.Ds_apporend1.apporend.Rows(0).Item("apporendcode") = "10" Then

                    Session("apporendcode") = "10"
                    Me.Label11.Visible = True

                    Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

                    str_menu_ei = "[dbo].[SP_CIMACEX_RECUPERA_ESTADO_INFORME] '" & Request("episcode") & "'"

                    objDS_ei = objCIMA.f_consulta(str_menu_ei, Session("cadena_conexion"))

                    If objDS_ei.Tables(0).Rows.Count > 0 Then

                        Me.Label111.Visible = True

                        Select Case objDS_ei.Tables(0).Rows(0).Item("tipo")

                            Case "V"
                                ls_tipo = "VALIJA"

                            Case "M"
                                ls_tipo = "MANUAL"

                            Case "W"
                                ls_tipo = "WEB"

                        End Select

                        Me.Label111.Text = "Fecha: " & objDS_ei.Tables(0).Rows(0).Item("fecha") & ". Usuario: " & objDS_ei.Tables(0).Rows(0).Item("id_usuario") & ". Tipo de entrega: " & ls_tipo & ". " & objDS_ei.Tables(0).Rows(0).Item("comentario")

                    End If

                Else

                    Session("apporendcode") = "0"
                    Me.Label11.Visible = False
                    Me.Label111.Visible = False

                End If

            Else

                Session("apporendcode") = "0"
                Me.Label11.Visible = False
                Me.Label111.Visible = False

            End If

        End If

        'JGM Recuperamos el dia_seleccionado del literal
        If IsPostBack = True And Session("episcode") <> Nothing Then
            Session("dia_seleccionado") = objCIMA.f_formato_fecha(Me.Label13.Text)
        End If

        If IsPostBack = False Then

            Session("pers_key") = Request("pers_key")
            Session("episcode") = Request("episcode")
            Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("dia_en_seleccion") = Session("dia_seleccionado_corregido")
            Session("servicio_seleccionado") = Request("servicio_seleccionado")
            Session("agenda_seleccionada") = Request("agenda_seleccionada")
            Session("DropDownList2") = Request("DropDownList2")
            Session("DropDownList1") = Request("DropDownList1")
            Session("control") = Request("control")

            Session("mutua") = Request("mutua")
            Session("nacimiento") = Request("nacimiento")
            Session("cove") = Request("cove")
            Session("estado") = Trim(Request("estado"))

            Session("realizada") = Trim(Request("realizada"))

            Session("inactiva") = Request("inactiva")

            If Session("estado") <> "P" Then
                Me.Button10.Enabled = False
            End If

            If Session("estado") <> "D" Then
                Me.Button12.Text = "Ver Prestaciones"
            Else
                Me.Button12.Text = "Capturar"
            End If

            If Session("estado") = "R" Then
                Me.Button13.Text = "Ver Incidencias"
            Else
                Me.Button13.Text = "Hoja de Citación"
            End If
            'JGM - Habilitem un botó de veure incidències quan la cita ja estigui capturada, sino es poden veure per la captura
            'JGM 22/02/2011
            ' Pel cas de radiologia, en cas que la cita estigui admesa, habilitarem el 'botó de reprogramació per canvi de prestació
            If Session("estado") = "D" And Session("servicio_seleccionado") = "RX" Then
                Me.Button10.Enabled = True
                Me.Button10.Text = "Cambio Prestación"
            Else
                Me.Button10.Text = "Reprogramar"
            End If
            'JGM Fi 22/02/2011


            Me.SqlDataAdapter5.SelectCommand.Parameters(1).Value = Session("pers_key")
            'Me.SqlDataAdapter5.SelectCommand.Parameters(2).Value = 4

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter5.Fill(Me.Ds_cima_notas1.cima_notas)

            Me.SqlConnection1.Close()

            If Me.Ds_cima_notas1.cima_notas.Rows.Count > 0 Then

                Me.TextBox1.Text = Me.Ds_cima_notas1.cima_notas.Rows(0).Item("nota")
            End If

            'JGM -- Recuperem les notes de l'episodi si cal 
            If Session("episcode") <> Nothing Then
                Dim objDS As New Data.DataSet
                Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

                str_menu = "dbo.SP_CIMACEX_RECUPERA_NOTAS_EPISODIO '" & Session("episcode") & "'"

                objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                If objDS.Tables(0).Rows.Count > 0 Then
                    Me.Textbox3.Text = objDS.Tables(0).Rows(0).Item(0)
                End If

            End If
            'JGM -- 


            lstr_fecha_nacimiento = Split(Request("nacimiento"), "/", , CompareMethod.Text)

            If UBound(lstr_fecha_nacimiento) > 0 Then
                'JGM -- Inici modificació 04/05/2009 
                '-- Canviem la manera de recuperar l'edat. La recuperarem amb una SP

                Dim objDS As New Data.DataSet
                Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

                str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORME_RESTO '" & Session("episcode") & "'"

                objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                Session("edad") = objDS.Tables(0).Rows(0).Item(0)

                'Session("edad") = CStr(CInt(DateDiff(DateInterval.Month, CDate(lstr_fecha_nacimiento(2) & "-" & lstr_fecha_nacimiento(1) & "-" & lstr_fecha_nacimiento(0)), Today()) / 12))
                'JGM -- Fi modificació 04/05/2009
                lstr_temporal = Split(Session("edad"), ".", , CompareMethod.Text)
                If UBound(lstr_temporal) > 0 Then
                    Session("edad") = lstr_temporal(0)
                End If
            Else
                Session("edad") = ""
            End If

            str_uid = Request.Cookies("usuario").Value

            Session("usuario") = str_uid

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.sp_permiso '" & Trim(str_uid) & "'"

            objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Session("grupo") = objDS_USR.Tables(0).Rows(0).Item(0)

            If Session("grupo") = "A" Then

                Me.Panel2.Visible = False

            End If

            objDS_USR = Nothing

            'JGM Ocultem el panel de notes de l'episodi. 
            If Session("episcode") = Nothing Then
                Me.Panel3.Visible = False
            End If

            If Session("episcode") = Nothing Or Request("control") = "S" Then
                Me.Button5.Visible = False
                Me.Button6.Visible = False
                Me.Button9.Visible = False
                Me.Button10.Visible = False
                Me.Button11.Visible = False
                Me.Button12.Visible = False
                Me.Button13.Visible = False
                Me.Panel1.Visible = False
                Session("debusqueda") = "1"
            Else
                Session("debusqueda") = "0"
            End If


        End If

        If Session("episcode") = Nothing Or Request("control") = "S" Then
        Else

            If Session("realizada") <> "N" Or CDate(Session("dia_seleccionado")) > Today() Then
                'Me.Button12.Enabled = True
                'Me.Button12.Text = "Ver Prestaciones"
            End If

        End If

        Me.Label19.Text = Session("episcode")
        Me.Label12.Text = Session("agenda_seleccionada")
        Me.Label13.Text = Left(Session("dia_seleccionado"), 10)

        Me.Label21.Text = Session("mutua")
        Me.Label22.Text = Session("edad")
        Me.Label23.Text = Session("cove")

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers_key, idenperscod1, addrcode, idenperscod2, titlcode, posttitlcode, apuscode, tsexcode, plancode, persdatechag, persacti, perssur1, perssur2, persname, persidencod1, persidencod2, persbirtdate, persnickname, imag_key, persmai1, persmai2, persrema, codetmplcode, perscode, perssitucode, civistatcode, terr_key, persdatecalc, docu_key, persfullname, msrepl_tran_version FROM pers WHERE pers_key = " + Request("pers_key")
        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers.pers_key,pers.tsexcode,pers.persacti,pers.perssur1,pers.perssur2,pers.persname,pers.persidencod1,[reporting].[f_cima_fecha] (pers.persbirtdate) as persbirtdate,addr.troacode,[reporting].[f_cima_paciente_direccion_pers_key_sg](pers.pers_key) as addrnameaddr,addr.addrnamestre,addr.addrnumb,addr.addrblok,addr.addrstai,addr.addrfloo,addr.addrdoor,addr.addrpostcode,addr.addrtel1,addr.addrtel2,addr.addrmail,addr.addrpweb, pati.pati_hfn, pers.persmai1, pers.persmai2,pers.persfullname FROM pers left join pati on pati.pers_key = pers.pers_key left join addr on pers.addrcode = addr.addrcode WHERE pers.pers_key = " + Session("pers_key")
        'Me.OdbcDataAdapter1.SelectCommand.Parameters(0).Value = 8

        Me.OdbcDataAdapter1.Fill(Me.Ds_pers1.pers)

        Me.Label1.DataBind()
        Me.Label2.DataBind()
        Me.Label3.DataBind()

        Me.Label4.DataBind()

        Me.Label5.DataBind()
        Me.Label6.DataBind()
        Me.Label7.DataBind()
        Me.Label8.DataBind()
        Me.Label9.DataBind()
        Me.Label10.DataBind()
        'Me.Label11.DataBind()
        'Me.Label12.DataBind()
        'Me.Label13.DataBind()
        'Me.Label14.DataBind()
        Me.Label15.DataBind()
        'Me.Label16.DataBind()
        'Me.Label17.DataBind()

        Me.Label18.DataBind()
        Me.Label20.DataBind()

        'Me.Label24.DataBind()
        'JGM Informem a la capçalera el nom del pacient
        Me.Label24.DataBind()


        Me.OdbcConnection1.Close()

        Me.OdbcConnection1.Open()

        OdbcDataAdapter2.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

        'JGM 02/06/2011 -- chequeo anuladas
        If Me.chek_anulada.Checked = True Then
            Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT 'Fecha' = CASE tact.tactcode	when 'UR' then [reporting].[f_cima_fecha](coalesce(epis.episdatecrea,'01/01/1900'))	else [reporting].[f_cima_fecha] (coalesce(book.diardate,'01/01/1900')) END,'Hora' = CASE tact.tactcode	when 'UR' then coalesce(convert(varchar,epis.epistimecrea,108),'') else coalesce(convert(varchar,bookhini,108),'') END,tact.tactdesc as 'Área', epis.episcode as 'Episodio', coalesce([reporting].[f_cima_doctor] (epis.epis_key),'') as 'Doctor', 'Estado' = CASE tact.tactcode	when 'UR' then	case when epis.episopen = 'Y' then 'ADMITIDA' else 'REALIZADA' end else case book.bookcanccode when 'R' then 'REPROGRAMADA' else coalesce([reporting].[f_cima_estado_episodio] (appo.appostatcode),'')	end end, 'Agenda' = CASE tact.tactcode	when 'UR' then 'URGENCIAS' else coalesce(agen.agenname,'') END, 'Prestacion' = CASE tact.tactcode when 'UR' then '' else hprodescshor END " & _
            "FROM epis inner join clip ON epis.clip_key=clip.clip_key  INNER  JOIN pers ON clip.pers_key=pers.pers_key inner join tact on tact.tactcode=epis.tactcode left join appo on epis.epis_key = appo.epis_key left join book on appo.book_key = book.book_key left join agen on book.agencode = agen.agencode " & _
            " left join bookproc on bookproc.book_key = book.book_key and bookprocorde = 1 left join hpro on hpro.hpro_key = bookproc.hpro_key " & _
            "WHERE pers.pers_key = " + Session("pers_key") + " ORDER BY epis.episdatecrea DESC , book.bookhini DESC"
        Else
            Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT 'Fecha' = CASE tact.tactcode	when 'UR' then [reporting].[f_cima_fecha](coalesce(epis.episdatecrea,'01/01/1900'))	else [reporting].[f_cima_fecha] (coalesce(book.diardate,'01/01/1900')) END,'Hora' = CASE tact.tactcode	when 'UR' then coalesce(convert(varchar,epis.epistimecrea,108),'') else coalesce(convert(varchar,bookhini,108),'') END,tact.tactdesc as 'Área', epis.episcode as 'Episodio', coalesce([reporting].[f_cima_doctor] (epis.epis_key),'') as 'Doctor', 'Estado' = CASE tact.tactcode	when 'UR' then	case when epis.episopen = 'Y' then 'ADMITIDA' else 'REALIZADA' end else case book.bookcanccode when 'R' then 'REPROGRAMADA' else coalesce([reporting].[f_cima_estado_episodio] (appo.appostatcode),'')	end end, 'Agenda' = CASE tact.tactcode	when 'UR' then 'URGENCIAS' else coalesce(agen.agenname,'') END, 'Prestacion' = CASE tact.tactcode when 'UR' then '' else hprodescshor END " & _
            "FROM epis inner join clip ON epis.clip_key=clip.clip_key  INNER  JOIN pers ON clip.pers_key=pers.pers_key inner join tact on tact.tactcode=epis.tactcode left join appo on epis.epis_key = appo.epis_key left join book on appo.book_key = book.book_key left join agen on book.agencode = agen.agencode " & _
            " left join bookproc on bookproc.book_key = book.book_key and bookprocorde = 1 left join hpro on hpro.hpro_key = bookproc.hpro_key " & _
            "WHERE pers.pers_key = " + Session("pers_key") + " and ((tact.tactcode not in ('UR','HO','QU') and appo.appostatcode <> 'A') or tact.tactcode in ('UR','HO','QU')) ORDER BY epis.episdatecrea DESC , book.bookhini DESC"
        End If


        Me.OdbcDataAdapter2.Fill(Me.Ds_epis1.epis)
        Me.DataGrid1.DataBind()

        Me.OdbcConnection1.Close()

        'JGM -- Control de l'alerta
        comprovar_antecedents()

        'Mostrem u ocultem les dades del pacient i de l'històric d'episodis segons hagin clicat el botó.
        If IsPostBack = False Then
            If Session("episcode") Is Nothing Then
                Me.Button18.Text = "Ocultar Datos"
                Me.Button19.Text = "Ocultar"
                Me.Panel4.Visible = True
                Me.Panel5.Visible = True
                Me.Button1.Enabled = True
                Me.Button16.Enabled = True
                Me.Button17.Enabled = True
                Me.chek_anulada.Enabled = True
            Else
                Me.Panel4.Visible = False
                Me.Panel5.Visible = False
                Me.Button1.Enabled = False
                Me.Button16.Enabled = False
                Me.Button17.Enabled = False
                Me.chek_anulada.Enabled = False
            End If
        End If


    End Sub

    Public Sub comprovar_antecedents()

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim str_sql, str_sql2, str_sql3 As String
        Dim objDS As New Data.DataSet
        Dim objDS2 As New Data.DataSet
        Dim objDS3 As New Data.DataSet

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
        str_sql = "dbo.SP_CIMACEX_RECUPERA_ALERTAS_PERS " & Session("pers_key") & ",1"
        str_sql2 = "dbo.SP_CIMACEX_RECUPERA_ALERTAS_PERS " & Session("pers_key") & ",2"
        str_sql3 = "dbo.SP_CIMACEX_RECUPERA_ALERTAS_PERS " & Session("pers_key") & ",3"

        objDS = objCIMA.f_consulta(str_sql, Session("cadena_conexion"))
        objDS2 = objCIMA.f_consulta(str_sql2, Session("cadena_conexion"))
        objDS3 = objCIMA.f_consulta(str_sql3, Session("cadena_conexion"))

        alerta.Visible = False

        If objDS.Tables(0).Rows.Count() > 0 Then
            If Trim(objDS.Tables(0).Rows(0).Item(2)) = "S" Then
                alerta.Visible = True
            End If
        End If

        If objDS2.Tables(0).Rows.Count() > 0 Then
            If Trim(objDS2.Tables(0).Rows(0).Item(2)) = "S" Then
                alerta.Visible = True
            End If
        End If

        If objDS3.Tables(0).Rows.Count() > 0 Then
            If Trim(objDS3.Tables(0).Rows(0).Item(2)) = "S" Then
                alerta.Visible = True
            End If
        End If

    End Sub

    'CARLOS - MODIFICACION **************************
    Private Sub llenarDataset()
        'VAMOS A SACAR LA INFORMACION DE LA QUERY EN UNOS RESPONSE.WRITE ASI SABREMOS SI SE HA ECHO CORRECTAMENTE 
        Me.Ds_recuperarDatosCita1.Clear()   'Borramos el dataset para se vuelva a llenar
        Me.AdapterRecuperarDatosCita.SelectCommand.Parameters(1).Value = Me.DataGrid1.SelectedItem.Cells(7).Text
        Me.AdapterRecuperarDatosCita.SelectCommand.Parameters(2).Value = Request.Cookies("usuario").Value

        Me.SqlConnection2.Open()
        Me.AdapterRecuperarDatosCita.Fill(Me.Ds_recuperarDatosCita1.SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA)
        Me.SqlConnection2.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim area As String
        Dim estado As String
        Dim nacimiento() As String      'Para hacer un split y cambiar los "-" por "/" de la fecha de nacimiento
        Dim nac As String               'Para guardar la fecha con formato correcto

        If Me.DataGrid1.SelectedIndex >= 0 Then
            llenarDataset()
            area = Me.DataGrid1.SelectedItem.Cells(3).Text
            estado = Me.DataGrid1.SelectedItem.Cells(8).Text
            area = RTrim(area)              'Esto quitara los espacios en blanco de la derecha del valor de la variable
            estado = RTrim(estado)          'Esto quitara los espacios en blanco de la derecha del valor de la variable

            'Aqui convertiremos la fecha de formato "00-00-0000" a formato "00/00/0000"
            nacimiento = Split(Me.Label9.Text, "-", -1, CompareMethod.Text)
            nac = nacimiento(0) & "/" & nacimiento(1) & "/" & nacimiento(2)

            'RECUPERAMOS LOS DATOS DEL DATASET Y SE LOS ASSIGNAMOS A LAS VARIABLES DE SESSION
            If area = "CONSULTAS EXTERNAS" Or area = "RADIODIAGNOSTICO" Or area = "LABORATORIO" Then
                For i = 0 To Me.Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows.Count - 1
                    Dim fila As DataRow
                    fila = Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows(i)
                    If fila("agenda_ok") = "F" Then
                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Usuario no autorizado para esta agenda');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")
                    Else
                        If estado <> "ANULADA" And estado <> "REPROGRAMADA" Then
                            Session("agenda_seleccionada") = fila("Agenda_seleccionada")
                            Session("dia_seleccionado") = fila("Dia_seleccionado")
                            Session("servicio_seleccionado") = fila("Servicio_seleccionado")
                            Session("mutua") = fila("Mutua")
                            Session("cove") = fila("Cove")
                            Session("estado") = fila("estado")
                            Session("nacimiento") = nac
                            Session("inactiva") = InactivaEval(fila("agenacti"))
                            Response.Redirect("form_pers.aspx?pers_key=" & Session("pers_key") & "&episcode=" & Me.DataGrid1.SelectedItem.Cells(7).Text & "&dia_seleccionado=" & Session("dia_seleccionado") & "&servicio_seleccionado=" & Session("servicio_seleccionado") & "&agenda_seleccionada=" & Session("agenda_seleccionada") & "&mutua=" & Session("mutua") & "&cove=" & Session("cove") & "&estado=" & Session("estado") & "&edad=" & Session("edad") & "&nacimiento=" & Session("nacimiento") & "&inactiva=" & Session("inactiva"))
                        Else
                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Sólo se pueden ver detalles de las citas Realizadas, Pendientes o Admitidas');" & vbCrLf)
                            Response.Write("</scr" & "ipt>")
                        End If
                    End If
                Next
            Else
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Sólo se pueden ver los detalles de las citas de Consultas externas, Radiologia o Laboratorio');" & vbCrLf)
                Response.Write("</scr" & "ipt>")
            End If
            Me.DataGrid1.SelectedIndex = -1
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar un episodio');" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If
        'CARLOS - MODIFICACION **************************


        'If Me.DataGrid1.SelectedIndex >= 0 Then
        '    Session("episodio") = Me.DataGrid1.SelectedItem.Cells(3).Text
        '    'Session("epis_key") = Me.DataGrid1.SelectedItem.Cells(0).Text
        '    Response.Redirect("form_episodio.aspx?episodio=" & Session("episodio") & "&episodio_origen=" & Session("episcode") & "&pers_key_origen=" & Session("pers_key") & "&DropDownList2_origen=" & Session("DropDownList2") & "&DropDownList1_origen=" & Session("DropDownList1") & "&servicio_origen=" & Session("servicio_seleccionado") & "&agenda_origen=" & Session("agenda_seleccionada") & "&dia_origen=" & Session("dia_seleccionado") & "&control=" & Session("control") & "&mutua=" & Session("mutua") & "&nacimiento=" & Session("nacimiento") & "&cove=" & Session("cove") & "&inactiva=" & Session("inactiva"))
        'Else
        '    'Response.Write("<scr" & "ipt>" & vbCrLf)
        '    'Response.Write("alert('Debe seleccionar un episodio');" & vbCrLf)
        '    'Response.Write("</scr" & "ipt>")
        'End If

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("env_episodio.submit();" & vbCrLf)
        'Response.Write("</scr" & "ipt>")

        'Dim kk As New oswinsck.TCP
        'Dim objSendSMS As New SMSCOM.SMSSend

        'Dim resultado As Integer

        'Dim getResult, getDescription, getCredit As String

        'kk.Connect("217.76.128.8", 8080)


        'objSendSMS = Server.CreateObject("SMSCOM.SMSSend")

        'Defino las propiedades
        'objSendSMS.setAccount("juancarlos.pachon@cimaclinic.com")
        'objSendSMS.setPwd("suburbia")
        'objSendSMS.setText("Este es mi texto")
        'objSendSMS.setTo("652459786")
        'objSendSMS.setFrom("mi remite")       ' Parámetro opcional 

        'Recupero los valores establecidos
        'Account = objSendSMS.getAccount
        'Pwd = objSendSMS.getPwd
        'Texto = objSendSMS.getText
        'Para = objSendSMS.getTo
        'Remite = objSendSMS.getFrom

        'Envío del mensaje
        'resultado = objSendSMS.Send

        'Resultado de la operación
        'getResult = objSendSMS.getResult
        'getDescription = objSendSMS.getDescription
        'getCredit = objSendSMS.getCredit

        'Response.Write("El resultado es " & resultado & "<br>")
        'Response.Write("getResult es " & getResult & "<br>")
        'Response.Write("getDescription es " & getDescription & "<br>")
        'Response.Write("getCredit es " & getCredit & "<br>")

        'objSendSMS = Nothing

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 4;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 3;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'JGM Modificació 05/07/2011 Indiquem el tipus de curs clínic que es mostrarà.
        Session("id_tipo") = "P"
        Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("control = 2;" & vbCrLf)
        Response.Write("control = 7;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 5;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 6;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        'JGM Modificació 05/07/2011 Indiquem el tipus de curs clínic que es mostrarà.
        Session("id_tipo") = "G"
        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 7;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 8;" & vbCrLf)
        Response.Write("</scr" & "ipt>")
        'Response.Redirect("form_agendas.aspx?DropDownList1=" & Session("agenda_seleccionada") & "&VisibleDate=" & Session("dia_seleccionado"))

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        'JGM 22/02/2011 Modificación para poder recitar radiologia
        If Me.Button10.Text = "Reprogramar" Then
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 9;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 16;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control = 10;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        If Me.Button12.Text = "Ver Prestaciones" Then
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 13;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 11;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If Me.Button13.Text = "Ver Incidencias" Then
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 15;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("control = 12;" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If


        'Dim ls_clave As String
        'Dim n As Integer
        'Dim ls_rnd As String

        'Dim objExport As New CrystalDecisions.Shared.ExportOptions
        'Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        'Dim Fname As String


        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("episcode")

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter1.Fill(Me.Ds_cima_epis_claves1.cima_epis_claves)
        'Me.SqlConnection1.Close()

        'If Me.Ds_cima_epis_claves1.cima_epis_claves.Rows.Count >= 1 Then

        ' Clave generada.
        'ls_clave = Me.Ds_cima_epis_claves1.cima_epis_claves.Rows(0).Item("clave")

        'Else

        ' A generar clave.

        'ls_clave = ""

        'For n = 1 To 10

        'ls_rnd = CStr(CInt(10 * Rnd()))

        'If ls_rnd = "10" Then
        'ls_clave = ls_clave + "9"
        'Else
        'ls_clave = ls_clave + ls_rnd
        'End If

        'Next

        'If Len(ls_clave) > 10 Then
        'ls_clave = Left(ls_clave, 10)
        'End If

        'Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Session("episcode")
        'Me.SqlDataAdapter2.SelectCommand.Parameters(2).Value = ls_clave

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter2.SelectCommand.ExecuteNonQuery()
        'Me.SqlConnection1.Close()

        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("episcode")

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter1.Fill(Me.Ds_cima_epis_claves1.cima_epis_claves)
        'Me.SqlConnection1.Close()

        'End If

        'objCR_rpt_informes.SetDataSource(Me.Ds_cima_epis_claves1)

        'Me.CrystalReportViewer1.ReportSource = objCR_rpt_informes


        'Me.CrystalReportViewer1.DataBind()

        'Fname = "c:\\CIMACEX\\pdf\\" + Session("episcode") + ".pdf"

        'objDiskFileDestination.DiskFileName = Fname
        'objExport = objCR_rpt_informes.ExportOptions

        'objExport.DestinationOptions = objDiskFileDestination
        'objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        'objExport.ExportFormatType = objExport.ExportFormatType.PortableDocFormat

        'objCR_rpt_informes.Export()

        'Response.Write("<script>")

        'Response.Write("var winTop = (screen.availHeight - 600) / 2;" & vbCrLf)
        'Response.Write("var winLeft = (screen.availWidth - 800) / 2;" & vbCrLf)

        'Response.Write("ventana=window.open(""../pdf/" & Session("episcode") & ".pdf"" , """", ""height=600,width=800,top="" + winTop + "",left="" + winLeft + "",screenX= "" + winTop + "",screenY="" + winLeft + "", scrollbars=yes"");" & vbCrLf)

        'Response.Write("</script>")

    End Sub

    Private Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        'If Me.control.Text = Session("pers_key") Then

        If IsNumeric(Session("pers_key")) = True Then

            str_sql = "dbo.SP_CIMACEX_ALTA_NOTA " & Session("pers_key") & ",'" & Trim(Request("TextBox1")) & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Nota actualizadas con éxito.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

    End Sub

    Private Sub Button4_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 2;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If IsNumeric(Session("pers_key")) = True And Session("episcode") <> Nothing Then

            str_sql = "dbo.SP_CIMACEX_ALTA_NOTA_EPISODIO " & "'" & Session("episcode") & "'," & Session("pers_key") & ",'" & Trim(Request("TextBox3")) & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Nota del episodio actualizada con éxito.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

    End Sub

    'CARLOS - MODIFICACION ***********
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim i As Integer
        Dim area As String
        Dim estado As String
        Session("form") = 1
        If Me.DataGrid1.SelectedIndex >= 0 Then
            area = Me.DataGrid1.SelectedItem.Cells(3).Text
            estado = Me.DataGrid1.SelectedItem.Cells(8).Text
            area = RTrim(area)              'Esto quitara los espacios en blanco de la derecha del valor de la variable
            estado = RTrim(estado)          'Esto quitara los espacios en blanco de la derecha del valor de la variable

            llenarDataset()

            'RECUPERAMOS LOS DATOS DEL DATASET Y SE LOS ASSIGNAMOS A LAS VARIABLES DE SESSION
            If area = "CONSULTAS EXTERNAS" Or area = "LABORATORIO" Or area = "RADIODIAGNOSTICO" Then
                For i = 0 To Me.Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows.Count - 1
                    Dim fila As DataRow
                    fila = Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows(i)
                    If fila("agenda_ok") = "F" Then
                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Usuario no autorizado para esta agenda');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")
                    Else
                        If estado = "PENDIENTE" Then
                            Session("agenda_seleccionada") = fila("Agenda_seleccionada")
                            Session("dia_seleccionado") = fila("Dia_seleccionado")
                            Session("servicio_seleccionado") = fila("Servicio_seleccionado")
                            Session("mutua") = fila("Mutua")

                            Response.Write("<script type='text/javascript'>window.open('../formularios/form_reprogramar_cita.aspx?servicio_seleccionado=" & Session("servicio_seleccionado") & "&dia_seleccionado=" & Session("dia_seleccionado") & "&agencode=" & Session("agenda_seleccionada") & "&pers_key=" & Session("pers_key") & "&episcode=" & Me.DataGrid1.SelectedItem.Cells(7).Text & "&inactiva=" & Session("inactiva") & "&garante=" & Session("mutua") & "&formulario=" & Session("form") & "','cal','width=900,height=600,left=200,top=200');</script>")
                        Else
                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Sólo se pueden reprogramar las citas PENDIENTES');" & vbCrLf)
                            Response.Write("</scr" & "ipt>")
                        End If
                    End If

                Next
            Else
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Sólo se pueden reprogramar las citas de CONSULTAS EXTERNAS, RADIOLOGIA  o LABORATORIO');" & vbCrLf)
                Response.Write("</scr" & "ipt>")
            End If
            Me.DataGrid1.SelectedIndex = -1
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar un episodio');" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim i As Integer
        Dim area As String
        Session("form") = 1

        If Me.DataGrid1.SelectedIndex >= 0 Then
            area = Me.DataGrid1.SelectedItem.Cells(3).Text
            area = RTrim(area)              'Esto quitara los espacios en blanco de la derecha del valor de la variable

            llenarDataset()

            'RECUPERAMOS LOS DATOS DEL DATASET Y SE LOS ASSIGNAMOS A LAS VARIABLES DE SESSION
            If area = "CONSULTAS EXTERNAS" Or area = "LABORATORIO" Or area = "RADIODIAGNOSTICO" Then
                For i = 0 To Me.Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows.Count - 1
                    Dim fila As DataRow
                    fila = Ds_recuperarDatosCita1.Tables("SP_CIMACEX_RECUPERAR_DATOS_MOSTRAR_CITA").Rows(i)
                    If fila("agenda_ok") = "F" Then
                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Usuario no autorizado para esta agenda');" & vbCrLf)
                        Response.Write("</scr" & "ipt>")
                    Else
                        If RTrim(Me.DataGrid1.SelectedItem.Cells(8).Text) = "PENDIENTE" Then
                            Session("dia_seleccionado") = fila("Dia_seleccionado")
                            Session("agenda_seleccionada") = fila("Agenda_seleccionada")
                            'JGM Modificació 02/02/11 Passem el servei origen
                            If area = "CONSULTAS EXTERNAS" Then
                                Session("servicio_origen") = "CE"
                            End If
                            If area = "LABORATORIO" Then
                                Session("servicio_origen") = "LA"
                            End If
                            If area = "RADIODIAGNOSTICO" Then
                                Session("servicio_origen") = "RX"
                            End If

                            Response.Write("<script type='text/javascript'>window.open('../formularios/form_anular_cita.aspx?servicio_origen=" & Session("servicio_origen") & "&dia_seleccionado=" & Session("dia_seleccionado") & "&agencode=" & Session("agenda_seleccionada") & "&DropDownList2=" & area & "&ristra=" & fila("epis_key") & "&formulario=" & Session("form") & "','cal','width=185,height=110,top=400, left=500');</script>")
                        Else
                            Response.Write("<scr" & "ipt>" & vbCrLf)
                            Response.Write("alert('Sólo se pueden anular las citas PENDIENTES');" & vbCrLf)
                            Response.Write("</scr" & "ipt>")
                        End If
                    End If

                Next
            Else
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Sólo se pueden anular las citas de CONSULTAS EXTERNAS, RADIOLOGIA o LABORATORIO');" & vbCrLf)
                Response.Write("</scr" & "ipt>")
            End If
            Me.DataGrid1.SelectedIndex = -1
        Else
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Debe seleccionar un episodio');" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If
    End Sub

    Private Sub BTmodificarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTmodificarDatos.Click
        'Aqui habra un POPUP que nos enviara a una ventana de modificación de los datos a la que le passaremos el pers_key
        Response.Write("<script type='text/javascript'>window.open('../formularios/form_nuevo_usuario.aspx?clave=" & Session("pers_key") & "','cal','width=900,height=600,left=200,top=200');</script>")
    End Sub
    'CARLOS - MODIFICACION ***********

    Private Sub Button18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.Click

        If Me.Button18.Text = "Mostrar Datos" Then
            Me.Button18.Text = "Ocultar Datos"
            Me.Panel4.Visible = True
        Else
            Me.Button18.Text = "Mostrar Datos"
            Me.Panel4.Visible = False
        End If

    End Sub

    Private Sub Button19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.Click

        If Me.Button19.Text = "Mostrar" Then
            Me.Button19.Text = "Ocultar"
            Me.Panel5.Visible = True
            Me.Button1.Enabled = True
            Me.Button16.Enabled = True
            Me.Button17.Enabled = True
            Me.chek_anulada.Enabled = True
        Else
            Me.Button19.Text = "Mostrar"
            Me.Panel5.Visible = False
            Me.Button1.Enabled = False
            Me.Button16.Enabled = False
            Me.Button17.Enabled = False
            Me.chek_anulada.Enabled = False
        End If

    End Sub

    Private Sub Textbox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Textbox3.TextChanged

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If IsNumeric(Session("pers_key")) = True And Session("episcode") <> Nothing Then

            str_sql = "dbo.SP_CIMACEX_ALTA_NOTA_EPISODIO " & "'" & Session("episcode") & "'," & Session("pers_key") & ",'" & Trim(Request("TextBox3")) & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            'Response.Write("<scr" & "ipt>" & vbCrLf)
            'Response.Write("alert('Nota del episodio actualizada con éxito.');" & vbCrLf)
            'Response.Write("</scr" & "ipt>")

        End If

    End Sub
End Class
