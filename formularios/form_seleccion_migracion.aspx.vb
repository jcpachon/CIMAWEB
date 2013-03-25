Public Class form_seleccion_migracion
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_agendas1 = New cimaweb.ds_agendas
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection2 = New System.Data.Odbc.OdbcConnection
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_migracion1 = New cimaweb.ds_migracion
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_migracion1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";per" & _
        "sist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_agendas1
        '
        Me.Ds_agendas1.DataSetName = "ds_agendas"
        Me.Ds_agendas1.EnforceConstraints = False
        Me.Ds_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agenname", "agenname")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT agen.agencode, agen.agenname FROM cima_usuarios_agen INNER JOIN agen ON ci" & _
        "ma_usuarios_agen.agencode = agen.agencode WHERE (cima_usuarios_agen.id_usuario =" & _
        " @id_usuario) ORDER BY agen.agenname"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_MIGRACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episodio", "episodio"), New System.Data.Common.DataColumnMapping("appostatdesc", "appostatdesc"), New System.Data.Common.DataColumnMapping("nombre_completo", "nombre_completo"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("idenperscod1", "idenperscod1"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("idenperscod2", "idenperscod2"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2"), New System.Data.Common.DataColumnMapping("fecha_nacimiento", "fecha_nacimiento"), New System.Data.Common.DataColumnMapping("persmai1", "persmai1"), New System.Data.Common.DataColumnMapping("persmai2", "persmai2"), New System.Data.Common.DataColumnMapping("estado_civil", "estado_civil"), New System.Data.Common.DataColumnMapping("terrleve", "terrleve"), New System.Data.Common.DataColumnMapping("terrcode", "terrcode"), New System.Data.Common.DataColumnMapping("terrdesc", "terrdesc"), New System.Data.Common.DataColumnMapping("persdatecalc", "persdatecalc"), New System.Data.Common.DataColumnMapping("garante_habitual", "garante_habitual"), New System.Data.Common.DataColumnMapping("prestacion", "prestacion"), New System.Data.Common.DataColumnMapping("mp", "mp"), New System.Data.Common.DataColumnMapping("mr", "mr"), New System.Data.Common.DataColumnMapping("doctor", "doctor"), New System.Data.Common.DataColumnMapping("dia", "dia")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "{? = CALL [SP_CIMACEX_MIGRACION]( ?, ?, ? )}"
        Me.OdbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection2
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@agencode", System.Data.Odbc.OdbcType.VarChar, 6))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@fecha_ini", System.Data.Odbc.OdbcType.DateTime, 8))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@fecha_fin", System.Data.Odbc.OdbcType.DateTime, 8))
        '
        'OdbcConnection2
        '
        Me.OdbcConnection2.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CSaludR;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        Me.OdbcConnection2.ConnectionTimeout = 0
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CSaludR;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        Me.OdbcConnection1.ConnectionTimeout = 0
        '
        'Ds_migracion1
        '
        Me.Ds_migracion1.DataSetName = "ds_migracion"
        Me.Ds_migracion1.EnforceConstraints = False
        Me.Ds_migracion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "acco", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("acco_key", "acco_key"), New System.Data.Common.DataColumnMapping("acco_keyfath", "acco_keyfath"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("accoleve", "accoleve"), New System.Data.Common.DataColumnMapping("accocode", "accocode"), New System.Data.Common.DataColumnMapping("accodescshor", "accodescshor"), New System.Data.Common.DataColumnMapping("accodesclong", "accodesclong"), New System.Data.Common.DataColumnMapping("accoreceentr", "accoreceentr"), New System.Data.Common.DataColumnMapping("accoorde", "accoorde"), New System.Data.Common.DataColumnMapping("accoflagjobk", "accoflagjobk"), New System.Data.Common.DataColumnMapping("accofalgobli", "accofalgobli"), New System.Data.Common.DataColumnMapping("accodefacode", "accodefacode"), New System.Data.Common.DataColumnMapping("tfircode", "tfircode"), New System.Data.Common.DataColumnMapping("accoflaggeac", "accoflaggeac"), New System.Data.Common.DataColumnMapping("accoflagacti", "accoflagacti"), New System.Data.Common.DataColumnMapping("tfircod2", "tfircod2")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT acco_key, acco_keyfath, plancode, accoleve, accocode, accodescshor, accode" & _
        "sclong, accoreceentr, accoorde, accoflagjobk, accofalgobli, accodefacode, tfirco" & _
        "de, accoflaggeac, accoflagacti, tfircod2 FROM acco"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection2
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_migracion1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_agendas1 As cimaweb.ds_agendas
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Ds_migracion1 As cimaweb.ds_migracion
    Protected WithEvents OdbcConnection2 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_migracion As New cr_obj_migracion

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Introducir aquí el código de usuario para inicializar la página
        Dim login As String

        login = Request.Cookies("usuario").Value

        Session("id_usuario") = login

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
        'Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
        'Me.DropDownList1.DataBind()
        'Me.SqlConnection1.Close()

        'Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'cargar()

    End Sub

    Private Sub cargar()

        'Dim objCR_rpt_prestaciones As New cr_obj_prestaciones
        Dim objCIMA As New CIMA_Clases.CIMA
        Dim ls_array1(), ls_array2() As String
        Dim ls_fecha_ini, ls_fecha_fin As String

        Me.Ds_migracion1.Clear()

        ls_array1 = Split(CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text, "/", , CompareMethod.Text)
        ls_array2 = Split(CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text, "/", , CompareMethod.Text)

        ls_fecha_ini = ls_array1(1) & "/" & ls_array1(0) & "/" & ls_array1(2)
        ls_fecha_fin = ls_array2(1) & "/" & ls_array2(0) & "/" & ls_array2(2)

        Me.OdbcConnection2.Open()

        'Me.OdbcDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        'Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text
        'Me.OdbcDataAdapter1.SelectCommand.Parameters(2).Value = CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text

        Me.OdbcDataAdapter2.SelectCommand.CommandText = " select pers.pers_key, appo.epis_key, persfullname as nombre_completo, " & _
        " tsex.tsexdesc as sexo,  " & _
        " coalesce(persbirtdate,'') as fecha_nacimiento, " & _
        " [reporting].[f_cima_paciente_direccion_pers_key] (pers.pers_key) as direccion, " & _
        " [reporting].[f_cima_paciente_telefonos] (pers.pers_key) as telefonos, " & _
        " [reporting].[f_cima_paciente_dni_pers_key] (pers.pers_key) as dni, " & _
        " [reporting].[f_cima_paciente_email_pers_key] (pers.pers_key) as email , " & _
        " [dbo].[f_cima_garante_habitual] (pers.pers_key,book.agencode,[dbo].[f_cima_garante_principal] (appo.epis_key)) as garante_habitual,   " & _
        " hpro.hprodesclong as prestacion,   " & _
        " coalesce([reporting].[f_cima_doctor] (appo.epis_key),'') as doctor, " & _
" cima_informes_master.cabecera,    " & _
" cima_informes.valor,  " & _
" cima_informes_master.id_usuario,   " & _
" [dbo].[f_cima_fecha] (cima_informes_master.fecha_creacion) as 'fecha_creacion', " & _
" cima_informes.padre, " & _
" [dbo].[f_cima_display_name_padre] (padre) AS display_name_padre,cima_informes.id_informe_master " & _
        " from appo   " & _
        " inner join book on appo.book_key = book.book_key   " & _
        " inner join pers on pers.pers_key = appo.pers_keypati   " & _
        " inner join pati on pers.pers_key = pati.pers_key   " & _
        " inner join bookproc on bookproc.book_key=book.book_key   " & _
        " inner join hpro on  bookproc.hpro_key=hpro.hpro_key    " & _
        " left join tsex on pers.tsexcode = tsex.tsexcode   " & _
" inner join epis on appo.epis_key = epis.epis_key   " & _
" inner join cima_informes_master on epis.episcode = cima_informes_master.episodio   " & _
" inner join cima_informes on cima_informes_master.id_informe = cima_informes.id_informe_master   " & _
        " where diardate between '" & ls_fecha_ini & "' and '" & ls_fecha_fin & "' " & _
" and cima_informes_master.id_usuario in (   " & _
" SELECT DISTINCT a.id_usuario FROM cima_usuarios_grupos AS a   " & _
" WHERE a.id_grupo in (   " & _
" SELECT distinct b.id_grupo    " & _
" FROM cima_usuarios_grupos AS b   " & _
" WHERE b.id_usuario = '" & Session("id_usuario") & "') )   " & _
        " order by diardate"

        '"where book.agencode = '" & Me.DropDownList1.SelectedValue & "' and diardate between '" & ls_fecha_ini & "' and '" & ls_fecha_fin & "' " & _
        '"where book.agencode = '" & Me.DropDownList1.SelectedValue & "' and diardate between '" & ls_fecha_ini & "' and '" & ls_fecha_fin & "' " & _
        '"order by episcode"

        'Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter2.Fill(Me.Ds_migracion1.SP_CIMACEX_MIGRACION)
        'Me.OdbcConnection1.Close()

        objCR_rpt_migracion.SetDataSource(Me.Ds_migracion1)
        'Ds_migracion1.e()
        Me.CrystalReportViewer1.ReportSource = objCR_rpt_migracion

        Me.OdbcConnection2.Close()

        Me.CrystalReportViewer1.DataBind()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Session("fecha_ini") = CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text
        'Session("fecha_fin") = CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text
        'Session("agencode") = Me.DropDownList1.SelectedValue

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar()

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".xls"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_migracion.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.Excel '.PortableDocFormat

        objCR_rpt_migracion.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/octet-stream"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() + ".xls" & """")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        System.IO.File.Delete(Fname)

    End Sub

End Class
