Public Class cr_mutuas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.Ds_cr_prestaciones1 = New cimaweb.ds_cr_prestaciones
        CType(Me.Ds_cr_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
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
        'Ds_cr_prestaciones1
        '
        Me.Ds_cr_prestaciones1.DataSetName = "ds_cr_prestaciones"
        Me.Ds_cr_prestaciones1.EnforceConstraints = False
        Me.Ds_cr_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cr_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Imagebutton4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_cr_prestaciones1 As cimaweb.ds_cr_prestaciones

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_mutuas As New cr_obj_mutuas

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        'Session("cadena_conexion") = "packet size=4096;user id=sa;data source=""JUPITER"";persist security info=False;initial catalog=Incima;password=kampeon10"

        If Not IsPostBack Then
            Me.TextBox1.Text = Session("fecha_ini")
            Me.TextBox2.Text = Session("fecha_fin")
        End If

        cargar()

    End Sub

    Private Sub cargar()

        Dim objCIMA As New CIMA_Clases.CIMA

        Me.Ds_cr_prestaciones1.Clear()

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT cima_garantes.firm_name as 'prestacion', count(*) as 'numero' " & _
        "FROM pati  INNER  JOIN pers ON pati.pers_key=pers.pers_key INNER  JOIN appo ON appo.pers_keypati=pati.pers_key  INNER  JOIN appostat ON appo.appostatcode=appostat.appostatcode LEFT  JOIN apporend ON appo.apporendcode=apporend.apporendcode INNER  JOIN book ON appo.book_key=book.book_key  INNER  JOIN agen ON book.agencode=agen.agencode INNER  JOIN bookproc ON bookproc.book_key=book.book_key  INNER  JOIN agenproc ON bookproc.agenproc_key=agenproc.agenproc_key INNER  JOIN btimetab ON book.agencode=btimetab.agencode AND book.btimetabcode=btimetab.btimetabcode INNER  JOIN epis ON epis.epis_key=appo.epis_key  LEFT  JOIN diag ON diag.epis_key=epis.epis_key AND diag.diagmain = 'Y' INNER  JOIN csta ON appo.csta_keymake=csta.csta_key INNER JOIN episfirm ON episfirm.epis_key=appo.epis_key LEFT JOIN cima_epis ON cima_epis.episcode = epis.episcode LEFT JOIN cima_garantes ON cima_epis.id_garante = cima_garantes.id_garante " & _
        "WHERE bookproc.bookprocorde = 1 AND book.diardate >= '" & objCIMA.f_formato_fecha(Me.TextBox1.Text) & "' AND book.diardate <= '" & objCIMA.f_formato_fecha(Me.TextBox2.Text) & "' AND book.agencode = '" & Session("agencode") & "' AND episfirm.episfirmmain = 'Y' AND appo.appostatcode in ('D','R') " & _
        "GROUP BY cima_garantes.firm_name"

        Me.OdbcDataAdapter1.Fill(Me.Ds_cr_prestaciones1.cr_prestaciones)

        objCR_rpt_mutuas.SetParameterValue("arg_fecha_ini", objCIMA.f_formato_fecha(Me.TextBox1.Text))
        objCR_rpt_mutuas.SetParameterValue("arg_fecha_fin", objCIMA.f_formato_fecha(Me.TextBox2.Text))
        objCR_rpt_mutuas.SetParameterValue("arg_agenda_desc", Session("agencode")) ' El código de la agenda.

        objCR_rpt_mutuas.SetDataSource(Me.Ds_cr_prestaciones1)

        Me.CrystalReportViewer1.ReportSource = objCR_rpt_mutuas

        Me.OdbcConnection1.Close()

        Me.CrystalReportViewer1.DataBind()

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar()

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".pdf"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_mutuas.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.PortableDocFormat

        objCR_rpt_mutuas.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() & ".pdf""")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        System.IO.File.Delete(Fname)

    End Sub

    Private Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar()

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".xls"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_mutuas.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.Excel '.PortableDocFormat

        objCR_rpt_mutuas.Export()

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

    Private Sub Imagebutton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton4.Click

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar()

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".doc"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_mutuas.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.WordForWindows '.PortableDocFormat

        objCR_rpt_mutuas.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/octet-stream"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() + ".doc" & """")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        System.IO.File.Delete(Fname)

    End Sub
End Class
