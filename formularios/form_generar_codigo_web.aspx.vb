Public Class form_generar_codigo_web
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_cima_epis_claves1 = New cimaweb.ds_cima_epis_claves
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_CLAVE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_ALTA_CLAVE]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_cima_epis_claves1
        '
        Me.Ds_cima_epis_claves1.DataSetName = "ds_cima_epis_claves"
        Me.Ds_cima_epis_claves1.EnforceConstraints = False
        Me.Ds_cima_epis_claves1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Imagebutton4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_cima_epis_claves1 As cimaweb.ds_cima_epis_claves
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_clave As New cr_obj_clave

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String



        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

        cargar(Session("episcode"))

    End Sub

    Private Sub cargar(ByVal episcode As String)

        Dim objCIMA As New CIMA_Clases.CIMA



        Me.Ds_cima_epis_claves1.Clear()

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = episcode

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.Fill(Me.Ds_cima_epis_claves1.cima_epis_claves)

        Me.SqlConnection1.Close()

        objCR_rpt_clave.SetDataSource(Me.Ds_cima_epis_claves1)

        Me.CrystalReportViewer1.ReportSource = objCR_rpt_clave

        Me.CrystalReportViewer1.DataBind()

    End Sub

    Private Sub Imagebutton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton4.Click

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar(Session("episcode"))

        'Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".pdf"
        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".pdf"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_clave.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.PortableDocFormat

        objCR_rpt_clave.Export()

        'System.Threading.Thread.Sleep(5000)

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() & ".pdf""")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        'System.Threading.Thread.Sleep(10000)

        'System.IO.File.Delete(Fname)

    End Sub

End Class
