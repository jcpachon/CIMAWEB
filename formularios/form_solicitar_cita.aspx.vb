Public Class form_solicitar_cita
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_agen_agenname1 = New cimaweb.ds_agen_agenname
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_btimetab1 = New cimaweb.ds_btimetab
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_prestaciones1 = New cimaweb.ds_prestaciones
        Me.Ds_franja_horaria1 = New cimaweb.ds_franja_horaria
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.OdbcDataAdapter3 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
        Me.Ds_medicos1 = New cimaweb.ds_medicos
        CType(Me.Ds_agen_agenname1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_medicos1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Ds_agen_agenname1
        '
        Me.Ds_agen_agenname1.DataSetName = "ds_agen_agenname"
        Me.Ds_agen_agenname1.EnforceConstraints = False
        Me.Ds_agen_agenname1.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_btimetab1
        '
        Me.Ds_btimetab1.DataSetName = "ds_btimetab"
        Me.Ds_btimetab1.EnforceConstraints = False
        Me.Ds_btimetab1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'Ds_prestaciones1
        '
        Me.Ds_prestaciones1.DataSetName = "ds_prestaciones"
        Me.Ds_prestaciones1.EnforceConstraints = False
        Me.Ds_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_franja_horaria1
        '
        Me.Ds_franja_horaria1.DataSetName = "ds_franja_horaria"
        Me.Ds_franja_horaria1.EnforceConstraints = False
        Me.Ds_franja_horaria1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'OdbcDataAdapter3
        '
        Me.OdbcDataAdapter3.SelectCommand = Me.OdbcSelectCommand3
        Me.OdbcDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cstahper", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key")})})
        '
        'OdbcSelectCommand3
        '
        Me.OdbcSelectCommand3.CommandText = "SELECT pers.persfullname AS nombre, cstahper.pers_key AS pers_key FROM cstahper I" & _
        "NNER JOIN pers ON cstahper.pers_key = pers.pers_key INNER JOIN agen ON agen.csta" & _
        "_key = cstahper.csta_key WHERE agencode = @agencode AND cstahperacti = 'Y' ORDER" & _
        " BY pers.persfullname"
        Me.OdbcSelectCommand3.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand3.Parameters.Add(New System.Data.Odbc.OdbcParameter("agencode", System.Data.Odbc.OdbcType.VarChar, 6, "agencode"))
        '
        'Ds_medicos1
        '
        Me.Ds_medicos1.DataSetName = "ds_medicos"
        Me.Ds_medicos1.EnforceConstraints = False
        Me.Ds_medicos1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_agen_agenname1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_btimetab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_franja_horaria1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_medicos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_agen_agenname1 As cimaweb.ds_agen_agenname
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_btimetab1 As cimaweb.ds_btimetab
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_prestaciones1 As cimaweb.ds_prestaciones
    Protected WithEvents Ds_franja_horaria1 As cimaweb.ds_franja_horaria
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Image2 As System.Web.UI.WebControls.Image
    Protected WithEvents Image3 As System.Web.UI.WebControls.Image
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents OdbcDataAdapter3 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_medicos1 As cimaweb.ds_medicos
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

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
        Dim li_dia As Integer

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;")
        Response.Write("</scr" & "ipt>" & vbCrLf)

        If IsPostBack = False Then

            'Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("agencode") = Request("agencode")
            Session("dia_origen") = Request("dia_seleccionado")
            'ls_array = Split(Request("dia_seleccionado"), "/")
            Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("pers_key") = ""
            'Session("pers_key") = Request("pers_key")

            Select Case Weekday(Request("dia_seleccionado"))
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

        End If

        Session("time_ini") = Request("DropDownList3")
        Session("time_fin") = Request("TextBox1")

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("agencode")
        Me.SqlDataAdapter1.Fill(Me.Ds_agen_agenname1.agen)

        Me.SqlConnection1.Close()

        Me.Label1.DataBind()

        Me.Label2.Text = Session("dia_seleccionado")

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

        If Len(Trim(Request("DropDownList4"))) > 0 Then
            Me.DropDownList4.SelectedValue = Request("DropDownList4")
        Else
            Me.DropDownList4.SelectedValue = ""
        End If

        'If IsPostBack = False Then

        actualizar()

        If Request("persona_ok") = "S" Then

            Me.Label3.Text = Request("persona")

            Session("pers_key") = Request("pers_key")

        End If

        'End If

    End Sub

    Public Sub actualizar()

        Dim n As Integer

        Me.Ds_prestaciones1.Clear()

        Me.DropDownList2.Items.Clear()
        Me.DropDownList3.Items.Clear()

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT ltrim(rtrim(hpro.hprodesclong)) + ' - ' + cast(proctita.proctitadura as varchar) + ' min' as 'Descripción', cast(proctita.proctitadura as varchar) + '/' + cast(hpro.hpro_key as varchar) as 'Tiempo' " & _
        "FROM hpro, proctita, btimetab " & _
        "WHERE ( proctita.hpro_key = hpro.hpro_key ) and " & _
        "( btimetab.btimetabcode = proctita.btimetabcode ) and ( proctita.agencode = btimetab.agencode ) and " & _
        "( ( proctita.agencode = '" & Session("agencode") & "' ) AND  " & _
        "( hpro.hproacti = 'Y' ) AND  " & _
        "( proctita.proctitaacti = 'Y' ) ) AND  btimetab.btimetabacti = 'Y' " & _
        "AND '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and proctita.btimetabcode = " & Me.DropDownList1.SelectedValue.ToString & " " & _
        "ORDER BY hpro.hprodesclong"

        Me.OdbcDataAdapter2.Fill(Me.Ds_prestaciones1.prestaciones)

        Me.OdbcConnection1.Close()

        Me.DropDownList2.DataBind()

        For n = 0 To Me.DropDownList2.Items.Count - 1
            If Me.DropDownList2.Items(n).Value = Request("DropDownList2") Then
                Me.DropDownList2.SelectedValue = Request("DropDownList2")
            End If
        Next

        Me.Ds_franja_horaria1.Clear()

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT DATEPART (hh,btimetabhourinit) as hora_inicio, DATEPART (mi,btimetabhourinit) as minuto_inicio,DATEPART (hh,btimetabhour_end) as hora_fin,DATEPART (mi,btimetabhour_end) as minuto_fin, btimetabgran FROM btimetab where agencode = '" & Session("agencode") & "' and '" & Session("dia_seleccionado") & "' between btimetabdateinit and btimetabdate_end and CHARINDEX ( '" & Session("cadena_semana") & "' , btimetabdaysweek) > 0 and btimetabcode = " & Me.DropDownList1.SelectedValue.ToString

        Me.OdbcDataAdapter1.Fill(Me.Ds_franja_horaria1.franja_horaria)

        montar_desplegable(Me.Ds_franja_horaria1.franja_horaria.Rows(0))

        Me.OdbcConnection1.Close()

        Me.TextBox1.Text = ""

    End Sub

    Public Sub montar_desplegable(ByVal objRow As ds_franja_horaria.franja_horariaRow)

        Dim li_hora, li_minuto As Integer
        Dim li_gran As Integer

        Dim li_hora_ini, li_hora_fin As Integer

        Dim lb_primera As Boolean

        li_gran = objRow.Item(4)

        li_hora = objRow.Item(0)
        li_minuto = objRow.Item(1)

        lb_primera = True

        li_hora_ini = li_hora * 60 + li_minuto
        li_hora_fin = objRow.Item(2) * 60 + objRow.Item(3)

        Me.DropDownList3.Items.Clear()

        While li_hora_ini <= li_hora_fin

            If lb_primera = False Then
                Me.DropDownList3.Items.Add(formatear_minutos(CStr(li_hora)) & ":" & formatear_minutos(CStr(li_minuto)))
                li_minuto = li_minuto + 5
            Else
                Me.DropDownList3.Items.Add("")
            End If

            If li_minuto Mod 60 = 0 And lb_primera = False Then
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

    Private Sub DropDownList3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList3.SelectedIndexChanged

        Dim ls_array(), ls_array2() As String

        Dim li_hora, li_minuto, li_total As Integer

        actualizar()

        Me.DropDownList3.SelectedValue = Request("DropDownList3")

        Me.DropDownList2.SelectedValue = Request("DropDownList2")

        ls_array = Split(Me.DropDownList3.SelectedValue.ToString, ":", , CompareMethod.Text)

        li_hora = CInt(ls_array(0)) * 60
        li_minuto = CInt(ls_array(1))

        ls_array2 = Split(Me.DropDownList2.SelectedValue.ToString, "/", , CompareMethod.Text)

        li_total = li_hora + li_minuto + CInt(ls_array2(0))

        Me.TextBox1.Text = CStr(Int(li_total / 60)) & ":" & formatear_minutos(CStr(li_total Mod 60))

        Session("time_fin") = CStr(Int(li_total / 60)) & ":" & formatear_minutos(CStr(li_total Mod 60))

    End Sub

    Private Sub DropDownList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged

        Me.DropDownList2.SelectedValue = Request("DropDownList2")

        actualizar()

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

        ' Controles.

        'If CDate(Session("dia_origen")) < Today() Then

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("alert('Lo sentimos, el día seleccionado es anterior al actual.');" & vbCrLf)
        'Response.Write("</scr" & "ipt>")

        'Else

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

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                lb_no_ok = False

                'For Each objRow In objDS.Tables(0).Rows

                'If (presencia_intervalo(objRow.Item(2), objRow.Item(24), Trim(Session("time_ini"))) = True And objRow.Item(24) <> (Trim(Session("time_ini")) & ":00")) Or (presencia_intervalo(objRow.Item(2), objRow.Item(24), Trim(Session("time_fin"))) = True And objRow.Item(2) <> (Trim(Session("time_fin")) & ":00")) Or intervalo_contenido(objRow.Item(2), objRow.Item(24), Trim(Session("time_ini")), Trim(Session("time_fin"))) = True Then

                'lb_no_ok = True

                'End If

                'Next

            ' Comprobación pertenencia a intervalos de bloqueo.

            str_menu = "[dbo].[SP_CIMACEX_BLOQUEOS] '" & Session("dia_seleccionado") & "','" & Session("agencode") & "'," & Me.DropDownList1.SelectedValue

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

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

                If Len(Trim(Session("pers_key"))) > 0 Then

                    ' OK!!!

                    ls_duracion = Split(Me.DropDownList2.SelectedValue.ToString, "/", , CompareMethod.Text)

                    If Len(Trim(Me.DropDownList4.SelectedValue)) > 0 Then
                        li_medico = Me.DropDownList4.SelectedValue
                    Else
                        li_medico = 0
                    End If

                    str_menu = "[dbo].[SP_CIMACEX_ALTA_CITA] '" & Session("dia_seleccionado") & "','" & Session("agencode") & "','" & Session("time_ini") & ":00','" & Session("time_fin") & ":00'," & ls_duracion(0) & "," & Me.DropDownList1.SelectedValue.ToString & "," & ls_duracion(1) & "," & Session("pers_key") & "," & li_medico

                    'response.write (str_menu)

                    ''''''''''''''''''''''''''''''''''''''''''

                    Dim objConn As New Odbc.OdbcConnection

                    Dim objCommand As New Odbc.OdbcCommand

                    'Dim objDA As New Odbc.OdbcDataAdapter(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN") ' SqlClient.SqlDataAdapter(sql, cadena_conexion)

                    'Dim objDS As New Data.DataSet
                    'pepino.Connection.ConnectionString = ""

                    objConn.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"

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

                    'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Cita registrada con éxito.');" & vbCrLf)

                    ' Corrección del agencode a char.

                    str_cadena_naciente = Session("agencode")

                    For n = Len(Session("agencode")) To 5
                        str_cadena_naciente = str_cadena_naciente + " "
                    Next

                    ' Fin Corrección del agencode a char.

                    Response.Write("opener.location.href='../formularios/form_agendas.aspx?agenda_origen=" & str_cadena_naciente & "&dia_en_seleccion=" & Session("dia_origen") & "';")
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

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

        Response.Redirect("form_busca_pers_solicitar_cita.aspx?dia_seleccionado=" & Session("dia_origen") & "&agencode=" & Session("agencode") & "&DropDownList1=" & Session("DropDownList1") & "&DropDownList2=" & Session("DropDownList2") & "&DropDownList3=" & Session("DropDownList3") & "&TextBox1=" & Session("TextBox1") & "&DropDownList4=" & Session("DropDownList4"))

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("control = 1;")
        'Response.Write("</scr" & "ipt>" & vbCrLf)

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

        actualizar()

    End Sub

    Private Sub DropDownList4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged

    End Sub
End Class
