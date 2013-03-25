Public Class form_alertas_mensajes
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_usuarios1 = New cimaweb.ds_usuarios
        Me.Ds_agen1 = New cimaweb.ds_agen
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_grupos_agendas1 = New cimaweb.ds_grupos_agendas
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_grupos1 = New cimaweb.ds_grupos
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_grupos_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";per" & _
        "sist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT agencode AS Código, agenname AS Agenda FROM agen"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Ds_usuarios1
        '
        Me.Ds_usuarios1.DataSetName = "ds_usuarios"
        Me.Ds_usuarios1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agen1
        '
        Me.Ds_agen1.DataSetName = "ds_agen"
        Me.Ds_agen1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios_agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cima_grupos_agen.agencode AS Código, agen.agenname AS Agenda, cima_grupos_" & _
        "agen.horas_previas AS Horas FROM cima_grupos_agen INNER JOIN agen ON cima_grupos" & _
        "_agen.agencode = agen.agencode WHERE (cima_grupos_agen.id_grupo = @id_grupo) ORD" & _
        "ER BY agen.agenname"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_grupo", System.Data.SqlDbType.Int, 4, "id_grupo"))
        '
        'Ds_grupos_agendas1
        '
        Me.Ds_grupos_agendas1.DataSetName = "ds_grupos_agendas"
        Me.Ds_grupos_agendas1.EnforceConstraints = False
        Me.Ds_grupos_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("desc_grupo", "desc_grupo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT desc_grupo FROM cima_grupos WHERE (id_grupo = @id_grupo)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_grupo", System.Data.SqlDbType.Int, 4, "id_grupo"))
        '
        'Ds_grupos1
        '
        Me.Ds_grupos1.DataSetName = "ds_grupos"
        Me.Ds_grupos1.EnforceConstraints = False
        Me.Ds_grupos1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_grupos_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_usuarios1 As cimaweb.ds_usuarios
    Protected WithEvents Ds_agen1 As cimaweb.ds_agen
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_grupos_agendas1 As cimaweb.ds_grupos_agendas
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_grupos1 As cimaweb.ds_grupos

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

        If IsPostBack = False Then
            Session("id_grupo") = Request("id_grupo")
        End If

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("id_grupo")
        Me.SqlDataAdapter1.Fill(Me.Ds_grupos1.cima_grupos)
        Me.SqlConnection1.Close()

        Me.Label2.DataBind()

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.SelectCommand.CommandText = Me.SqlDataAdapter3.SelectCommand.CommandText + " WHERE (agencode NOT IN" & _
        " (SELECT     agencode " & _
        " FROM cima_grupos_agen " & _
        " WHERE      id_grupo = " + Session("id_grupo") + ")) ORDER BY agen.agenname"
        'Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue.ToString
        Me.SqlDataAdapter3.Fill(Me.Ds_agen1.agen)
        Me.DataGrid1.DataBind()
        Me.SqlConnection1.Close()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = CInt(Session("id_grupo"))
        Me.SqlDataAdapter2.Fill(Me.Ds_grupos_agendas1.cima_grupos_agen)
        Me.DataGrid2.DataBind()
        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid1.SelectedIndex >= 0 And IsNumeric(Me.TextBox1.Text) Then

            str_sql = "dbo.SP_CIMACEX_ALTA_AGENDA_GRUPO '" & Me.DataGrid1.SelectedItem.Cells(1).Text & "'," & Me.TextBox1.Text + "," + Session("id_grupo")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Else

            'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        End If

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid2.SelectedIndex = -1

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid2.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_BAJA_AGENDA_GRUPO '" & Me.DataGrid2.SelectedItem.Cells(1).Text & "'," + Session("id_grupo")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Else

            '

        End If

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid2.SelectedIndex = -1

    End Sub

    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged

        Me.DataGrid1.SelectedIndex = -1

        Me.DataGrid1.CurrentPageIndex = e.NewPageIndex()

    End Sub

    Private Sub DataGrid2_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid2.PageIndexChanged

        Me.DataGrid2.SelectedIndex = -1

        Me.DataGrid2.CurrentPageIndex = e.NewPageIndex()

    End Sub

End Class
