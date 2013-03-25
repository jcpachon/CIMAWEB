Public Class form_seleccion_listado_mutuas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_agendas1 = New cimaweb.ds_agendas
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SqlSelectCommand1.CommandText = "SELECT agen.agencode, agen.agenname FROM CIMACEX.dbo.cima_usuarios_agen INNER JOI" & _
        "N CIMACEX.dbo.agen ON cima_usuarios_agen.agencode = agen.agencode WHERE (cima_us" & _
        "uarios_agen.id_usuario = @id_usuario) AND (agen.agenacti = 'Y') AND (agen.agenty" & _
        "pecode = 'CE') ORDER BY agen.agenname"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        CType(Me.Ds_agendas1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_agendas1 As cimaweb.ds_agendas
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection

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

        Dim login As String

        login = Request.Cookies("usuario").Value

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = login
        Me.SqlDataAdapter1.Fill(Me.Ds_agendas1.cima_usuarios_agen)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Session("fecha_ini") = CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text
        Session("fecha_fin") = CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text
        Session("agencode") = Me.DropDownList1.SelectedValue

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("open(""../reports/cr_mutuas.aspx"",""informe"");" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub
End Class
