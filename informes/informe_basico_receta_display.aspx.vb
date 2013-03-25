Public Class informe_basico_receta_display
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_medicacion_receta1 = New cimaweb.ds_medicacion_receta
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_medicacion_receta1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_medicacion_receta1
        '
        Me.Ds_medicacion_receta1.DataSetName = "ds_medicacion_receta"
        Me.Ds_medicacion_receta1.EnforceConstraints = False
        Me.Ds_medicacion_receta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_medicacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_medicacion", "id_medicacion"), New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("drugselecode_key", "drugselecode_key"), New System.Data.Common.DataColumnMapping("drugseledesc", "drugseledesc"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("posologia", "posologia"), New System.Data.Common.DataColumnMapping("tipo_duracion", "tipo_duracion"), New System.Data.Common.DataColumnMapping("duracion", "duracion"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cima_medicacion.id_medicacion, cima_medicacion.pers_key, cima_medicacion.d" & _
        "rugselecode_key, cima_medicacion.drugseledesc, cima_medicacion.fecha, cima_medic" & _
        "acion.episcode, cima_medicacion.posologia, cima_medicacion.tipo_duracion, cima_m" & _
        "edicacion.duracion, cima_medicacion.observaciones FROM cima_medicacion INNER JOI" & _
        "N cima_recetas_tmp ON cima_medicacion.id_medicacion = cima_recetas_tmp.id_medica" & _
        "cion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        CType(Me.Ds_medicacion_receta1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_medicacion_receta1 As cimaweb.ds_medicacion_receta
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
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

    Dim objCR_rpt_receta As New cr_obj_receta

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        Dim ls_array() As String



        cargar()

        If Len(Trim(Request("impresora_p"))) > 0 Then
            ls_array = Split(Request("impresora_p"), ",", , CompareMethod.Text)
            Session("impresora_p") = ls_array(0) 'Request("impresora_p")
            objCR_rpt_receta.PrintOptions.PrinterName = Session("impresora_p")
            objCR_rpt_receta.PrintToPrinter(1, False, 0, 0)
        End If

    End Sub

    Private Sub cargar()

        'Dim objExport As New CrystalDecisions.Shared.ExportOptions
        'Dim objDiskFileDestination As New CrystalDecisions.Shared.DiskFileDestinationOptions

        'Dim kk As cr_obj_receta

        'Dim objCR_rpt_prestaciones As New cr_obj_prestaciones
        Dim objCIMA As New CIMA_Clases.CIMA

        Me.Ds_medicacion_receta1.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.Fill(Me.Ds_medicacion_receta1.cima_medicacion)
        'Me.DataList1.DataBind()

        Me.SqlConnection1.Close()

        objCR_rpt_receta.SetDataSource(Me.Ds_medicacion_receta1)

        Me.CrystalReportViewer1.ReportSource = objCR_rpt_receta

        Me.CrystalReportViewer1.DataBind()

    End Sub

End Class
