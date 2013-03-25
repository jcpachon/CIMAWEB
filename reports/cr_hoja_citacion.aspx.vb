Public Class cr_hoja_citacion
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_hoja_citacion1 = New cimaweb.ds_hoja_citacion
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_hoja_citacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_hoja_citacion1
        '
        Me.Ds_hoja_citacion1.DataSetName = "ds_hoja_citacion"
        Me.Ds_hoja_citacion1.EnforceConstraints = False
        Me.Ds_hoja_citacion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_HOJA_CITACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("paciente", "paciente"), New System.Data.Common.DataColumnMapping("NHC", "NHC"), New System.Data.Common.DataColumnMapping("fecha_nacimiento", "fecha_nacimiento"), New System.Data.Common.DataColumnMapping("garante", "garante"), New System.Data.Common.DataColumnMapping("poliza", "poliza"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("hora", "hora"), New System.Data.Common.DataColumnMapping("hprocode", "hprocode"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong"), New System.Data.Common.DataColumnMapping("servicio", "servicio"), New System.Data.Common.DataColumnMapping("edad", "edad"), New System.Data.Common.DataColumnMapping("dni", "dni")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_HOJA_CITACION]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        CType(Me.Ds_hoja_citacion1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Imagebutton4 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_hoja_citacion1 As cimaweb.ds_hoja_citacion
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_hoja_citacion As New cr_obj_hoja_citacion

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

        cargar(Session("episcode"))

        

        'cargar(Session("episcode"))

        

        'Dim objExport As New CrystalDecisions.Shared.ExportOptions
        'Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        'Dim Fname As String

        'cargar(Session("episcode"))

        

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("window.close();")
        'Response.Write("</scr" & "ipt>" & vbCrLf)

    End Sub

    Private Sub cargar(ByVal episcode As String)

        Dim objCIMA As New CIMA_Clases.CIMA

        Me.Ds_hoja_citacion1.Clear()

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = episcode

        Me.SqlConnection2.Open()

        Me.SqlDataAdapter1.Fill(Me.Ds_hoja_citacion1.SP_CIMACEX_HOJA_CITACION)


        Me.SqlConnection2.Close()

        objCR_rpt_hoja_citacion.SetDataSource(Me.Ds_hoja_citacion1)

        Me.CrystalReportViewer1.ReportSource = objCR_rpt_hoja_citacion

        Me.CrystalReportViewer1.DataBind()

    End Sub

    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar(Session("episcode"))

        'Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".pdf"
        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".pdf"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_hoja_citacion.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.PortableDocFormat

        objCR_rpt_hoja_citacion.Export()

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

    Private Sub ImageButton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar(Session("episcode"))

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".xls"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_hoja_citacion.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.Excel '.PortableDocFormat

        objCR_rpt_hoja_citacion.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/octet-stream"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() + ".xls" & """")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        'System.IO.File.Delete(Fname)

    End Sub

    Private Sub Imagebutton4_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton4.Click

        Dim objExport As New CrystalDecisions.Shared.ExportOptions
        Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim Fname As String

        cargar(Session("episcode"))

        Fname = "c:\\TEMP\\" + Session.SessionID.ToString() + ".doc"
        objDiskFileDestination.DiskFileName = Fname
        objExport = objCR_rpt_hoja_citacion.ExportOptions

        objExport.DestinationOptions = objDiskFileDestination
        objExport.ExportDestinationType = objExport.ExportDestinationType.DiskFile
        objExport.ExportFormatType = objExport.ExportFormatType.WordForWindows '.PortableDocFormat

        objCR_rpt_hoja_citacion.Export()

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/octet-stream"
        Response.AddHeader("Content-Disposition", _
        "attachment; filename=""" & Session.SessionID.ToString() + ".doc" & """")
        Response.WriteFile(Fname)
        Response.Flush()
        Response.Close()

        'System.IO.File.Delete(Fname)

    End Sub

End Class
