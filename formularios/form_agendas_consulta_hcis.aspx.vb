Public Class form_agendas_consulta_hcis
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_agendas1 = New cimaweb.ds_agendas
        Me.DataView1 = New System.Data.DataView
        Me.Ds_citas1 = New cimaweb.ds_citas
        Me.Ds_hcis_servicio1 = New cimaweb.ds_hcis_servicio
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_hcis_agenda1 = New cimaweb.ds_hcis_agenda
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_citas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hcis_servicio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hcis_agenda1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_agendas1
        '
        Me.Ds_agendas1.DataSetName = "ds_agendas"
        Me.Ds_agendas1.EnforceConstraints = False
        Me.Ds_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_citas1
        '
        Me.Ds_citas1.DataSetName = "ds_citas"
        Me.Ds_citas1.EnforceConstraints = False
        Me.Ds_citas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_hcis_servicio1
        '
        Me.Ds_hcis_servicio1.DataSetName = "ds_hcis_servicio"
        Me.Ds_hcis_servicio1.EnforceConstraints = False
        Me.Ds_hcis_servicio1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_SNT_mapeo_agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("HCIScode_servicio", "HCIScode_servicio"), New System.Data.Common.DataColumnMapping("HCIScodedesc_servicio", "HCIScodedesc_servicio")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT HCIScode_servicio, HCIScodedesc_servicio FROM cima_SNT_mapeo_agen GROUP BY" & _
        " HCIScode_servicio, HCIScodedesc_servicio ORDER BY HCIScodedesc_servicio"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_SNT_mapeo_agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("HCIScode", "HCIScode"), New System.Data.Common.DataColumnMapping("HCISdesc", "HCISdesc")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cima_SNT_mapeo_agen.HCIScode AS HCIScode_agenda, cima_SNT_mapeo_agen.HCISd" & _
        "esc AS HCIScodedesc_agenda FROM CIMACEX.dbo.cima_usuarios_agen INNER JOIN cima_S" & _
        "NT_mapeo_agen ON CIMACEX.dbo.cima_usuarios_agen.agencode = cima_SNT_mapeo_agen.a" & _
        "gencode WHERE (CIMACEX.dbo.cima_usuarios_agen.id_usuario = @id_usuario) AND (cim" & _
        "a_SNT_mapeo_agen.HCIScode_servicio = @HCIScode_servicio)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HCIScode_servicio", System.Data.SqlDbType.VarChar, 250, "HCIScode_servicio"))
        '
        'Ds_hcis_agenda1
        '
        Me.Ds_hcis_agenda1.DataSetName = "ds_hcis_agenda"
        Me.Ds_hcis_agenda1.EnforceConstraints = False
        Me.Ds_hcis_agenda1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_citas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hcis_servicio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hcis_agenda1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_agendas1 As cimaweb.ds_agendas
    Protected WithEvents DataView1 As System.Data.DataView
    Protected WithEvents Ds_citas1 As cimaweb.ds_citas
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Ds_hcis_servicio1 As cimaweb.ds_hcis_servicio
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_hcis_agenda1 As cimaweb.ds_hcis_agenda

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Public ds_citas As New SANITAS_WS.ds_citas
    Public objRow As SANITAS_WS.ds_citas.citasRow

    Public ws_sanitas As New SANITAS_WS.Service1

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Introducir aquí el código de usuario para inicializar la página

        Dim dt As New Data.DataTable

        Dim criterios As String
        Dim orden As String

        Dim citas As DataTable = ds_citas.Tables("citas")



        Session("usuario") = Request.Cookies("usuario").Value

        If IsPostBack Then

            orden = orden

        Else

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_hcis_servicio1.hcis_servicio)
            Me.SqlConnection1.Close()

            Me.Dropdownlist2.DataBind()

            Me.Dropdownlist2.Items.Insert(0, "")

        End If

        'ds_citas = ws_sanitas.ConsultaAgendaDia("usr.facultativo", "12345", "301CIMA", "ALCMMA", "27/09/2011")


        'Me.Ds_citas1.Tables.Clear()

        'Me.Ds_citas1.Tables.Add(ds_citas.citas)

        'Me.DataView1.Table = ds_citas.citas

        'Me.DataView1.Sort = "nombre asc"

        'Me.ds_citas.Tables.Clear()

        'Me.ds_citas.Tables.Add(Me.DataView1.Table)

        'criterios = ""

    End Sub

    Private Sub Dropdownlist2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist2.SelectedIndexChanged

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Session("usuario")
        Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Me.Dropdownlist2.SelectedValue

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_hcis_agenda1.hcis_agenda)
        Me.SqlConnection1.Close()

        Me.DropDownList1.DataBind()

        Me.DropDownList1.Items.Insert(0, "")

        'actualizar()

        ds_citas.Clear()
        Me.DataGrid1.Visible = False

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        actualizar()

    End Sub

    Sub actualizar()

        ds_citas = ws_sanitas.ConsultaAgendaDia("usr.facultativo", "12345", Me.Dropdownlist2.SelectedValue, Me.DropDownList1.SelectedValue, CStr(Me.Calendar1.SelectedDate))

        Me.DataView1.Table = ds_citas.citas
        Me.DataView1.Sort = "hora asc"
        Me.DataView1.RowFilter = "estadoCita <> 'LIB'"
        'Me.Ds_citas1.Tables.Clear()
        'Me.Ds_citas1.Tables.Add(Me.DataView1.Table)
        Me.DataGrid1.DataBind()

        If Me.DataView1.Count > 0 Then

            Me.DataGrid1.Visible = True

        Else

            Me.DataGrid1.Visible = False

        End If

    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        actualizar()

    End Sub

End Class
