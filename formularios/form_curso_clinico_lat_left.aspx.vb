Public Class form_curso_clinico_lat_left
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.Ds_curso_clinico1 = New cimaweb.ds_curso_clinico
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_nombre_paciente1 = New cimaweb.ds_nombre_paciente
        Me.Ds_episcode1 = New cimaweb.ds_episcode
        CType(Me.Ds_curso_clinico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_nombre_paciente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_episcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "epis", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("epis_key", "epis_key"), New System.Data.Common.DataColumnMapping("tactcode", "tactcode"), New System.Data.Common.DataColumnMapping("clip_key", "clip_key"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("episdatecrea", "episdatecrea"), New System.Data.Common.DataColumnMapping("epis_keyfath", "epis_keyfath"), New System.Data.Common.DataColumnMapping("episopen", "episopen"), New System.Data.Common.DataColumnMapping("episflag_new", "episflag_new"), New System.Data.Common.DataColumnMapping("episdatearri", "episdatearri"), New System.Data.Common.DataColumnMapping("epistimearri", "epistimearri"), New System.Data.Common.DataColumnMapping("episdisc_num", "episdisc_num"), New System.Data.Common.DataColumnMapping("episflagjudg", "episflagjudg"), New System.Data.Common.DataColumnMapping("episdiag", "episdiag"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("csta_keysour", "csta_keysour"), New System.Data.Common.DataColumnMapping("csta_keydest", "csta_keydest"), New System.Data.Common.DataColumnMapping("cstahper_keysour", "cstahper_keysour"), New System.Data.Common.DataColumnMapping("cstahper_keydest", "cstahper_keydest"), New System.Data.Common.DataColumnMapping("cent_keysour", "cent_keysour"), New System.Data.Common.DataColumnMapping("cent_keydest", "cent_keydest"), New System.Data.Common.DataColumnMapping("hspecodesour", "hspecodesour"), New System.Data.Common.DataColumnMapping("hspecodedest", "hspecodedest"), New System.Data.Common.DataColumnMapping("epistimecrea", "epistimecrea"), New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstahper_key", "cstahper_key"), New System.Data.Common.DataColumnMapping("episflaginfo", "episflaginfo"), New System.Data.Common.DataColumnMapping("insicode", "insicode"), New System.Data.Common.DataColumnMapping("episdat1", "episdat1"), New System.Data.Common.DataColumnMapping("episdat2", "episdat2"), New System.Data.Common.DataColumnMapping("episdat3", "episdat3"), New System.Data.Common.DataColumnMapping("episdat4", "episdat4"), New System.Data.Common.DataColumnMapping("epismedisour", "epismedisour"), New System.Data.Common.DataColumnMapping("epismedidest", "epismedidest"), New System.Data.Common.DataColumnMapping("msrepl_tran_version", "msrepl_tran_version")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT epis_key, tactcode, clip_key, docu_key, episcode, episdatecrea, epis_keyfa" & _
        "th, episopen, episflag_new, episdatearri, epistimearri, episdisc_num, episflagju" & _
        "dg, episdiag, txts_key, csta_keysour, csta_keydest, cstahper_keysour, cstahper_k" & _
        "eydest, cent_keysour, cent_keydest, hspecodesour, hspecodedest, epistimecrea, cs" & _
        "ta_key, cstahper_key, episflaginfo, insicode, episdat1, episdat2, episdat3, epis" & _
        "dat4, epismedisour, epismedidest, msrepl_tran_version FROM epis ORDER BY episdat" & _
        "ecrea"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'Ds_curso_clinico1
        '
        Me.Ds_curso_clinico1.DataSetName = "ds_curso_clinico"
        Me.Ds_curso_clinico1.EnforceConstraints = False
        Me.Ds_curso_clinico1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_INFORMES_EPISODIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cabecera", "cabecera"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("cerrado", "cerrado"), New System.Data.Common.DataColumnMapping("Column1", "Column1"), New System.Data.Common.DataColumnMapping("id_informe", "id_informe"), New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_CURSO_CLINICO_GRUPO]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episodio", System.Data.SqlDbType.VarChar, 50))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";per" & _
        "sist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("persfullname", "persfullname")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT persfullname FROM pers WHERE (pers_key = ?)"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand2.Parameters.Add(New System.Data.Odbc.OdbcParameter("pers_key", System.Data.Odbc.OdbcType.Int, 4, "pers_key"))
        '
        'Ds_nombre_paciente1
        '
        Me.Ds_nombre_paciente1.DataSetName = "ds_nombre_paciente"
        Me.Ds_nombre_paciente1.EnforceConstraints = False
        Me.Ds_nombre_paciente1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_episcode1
        '
        Me.Ds_episcode1.DataSetName = "ds_episcode"
        Me.Ds_episcode1.EnforceConstraints = False
        Me.Ds_episcode1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_curso_clinico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_nombre_paciente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_episcode1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_curso_clinico1 As cimaweb.ds_curso_clinico
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_nombre_paciente1 As cimaweb.ds_nombre_paciente
    Protected WithEvents Ds_episcode1 As cimaweb.ds_episcode

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

        'Dim objDS As New Data.DataSet

        Dim login As String
        Dim login_array() As String

        Dim objRow As Data.DataRow

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'Session("usuario") = "juancarlos.pachon"

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT distinct epis.episcode, [dbo].[f_cima_fecha] (epis.episdatecrea) AS 'episdatecrea',epis.episdatecrea " & _
        "FROM epis inner join clip ON epis.clip_key=clip.clip_key  INNER  JOIN pers ON clip.pers_key=pers.pers_key inner join tact on tact.tactcode=epis.tactcode left join appo on epis.epis_key = appo.epis_key " & _
        "WHERE pers.pers_key = " & Session("pers_key") & " ORDER BY epis.episdatecrea desc"

        Me.OdbcDataAdapter1.Fill(Me.Ds_episcode1.episcode)

        Me.OdbcConnection1.Close()

        Me.Ds_curso_clinico1.Clear()

        For Each objRow In Me.Ds_episcode1.Tables(0).Rows

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = objRow.Item(0)

            Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = Session("usuario")

            Me.SqlDataAdapter1.Fill(Me.Ds_curso_clinico1.cima_informes_master)

            Me.SqlConnection1.Close()

        Next

        If IsPostBack = False Then

            Me.OdbcConnection1.Open()
            Me.OdbcDataAdapter2.SelectCommand.Parameters(0).Value = Session("pers_key")
            Me.OdbcDataAdapter2.Fill(Me.Ds_nombre_paciente1.paciente)
            Me.OdbcConnection1.Close()

            Session("nombre_paciente") = Me.Ds_nombre_paciente1.Tables(0).Rows(0).Item(1)

        End If

    End Sub

End Class
