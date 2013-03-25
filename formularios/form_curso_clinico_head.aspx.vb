Public Class form_curso_clinico_head
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_pers1 = New cimaweb.ds_pers
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Public Function CheckBoxEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "S" Then
            returnValue = "True"
        Else
            returnValue = "False"
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

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers_key, idenperscod1, addrcode, idenperscod2, titlcode, posttitlcode, apuscode, tsexcode, plancode, persdatechag, persacti, perssur1, perssur2, persname, persidencod1, persidencod2, persbirtdate, persnickname, imag_key, persmai1, persmai2, persrema, codetmplcode, perscode, perssitucode, civistatcode, terr_key, persdatecalc, docu_key, persfullname, msrepl_tran_version FROM pers WHERE pers_key = " + Request("pers_key")
        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers.pers_key,pers.tsexcode,pers.persacti,pers.perssur1,pers.perssur2,pers.persname,pers.persidencod1,[reporting].[f_cima_fecha] (pers.persbirtdate) as persbirtdate,addr.troacode,[reporting].[f_cima_paciente_direccion_pers_key_sg](pers.pers_key) as addrnameaddr,addr.addrnamestre,addr.addrnumb,addr.addrblok,addr.addrstai,addr.addrfloo,addr.addrdoor,addr.addrpostcode,addr.addrtel1,addr.addrtel2,addr.addrmail,addr.addrpweb, pati.pati_hfn, pers.persmai1, pers.persmai2,pers.persfullname FROM pers left join pati on pati.pers_key = pers.pers_key left join addr on pers.addrcode = addr.addrcode WHERE pers.pers_key = " + Session("pers_key")
        'Me.OdbcDataAdapter1.SelectCommand.Parameters(0).Value = 8

        Me.OdbcDataAdapter1.Fill(Me.Ds_pers1.pers)

        Me.Label1.DataBind()

        'Modificació JGM 23/03/2009-- 
        'Recuperem l'edat, la data/hora admissió i el motiu de la visita de l'episodi.

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORME_RESTO '" & Session("episcode") & "'"

        objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        Me.Label2.Text = objDS.Tables(0).Rows(0).Item(0)

        'Fi Modificació JGM 23/03/2009--
        

    End Sub

End Class
