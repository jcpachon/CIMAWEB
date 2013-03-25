Public Class form_usuarios_agendas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_usuarios1 = New cimaweb.ds_usuarios
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_usuarios_agendas1 = New cimaweb.ds_usuarios_agendas
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agen1 = New cimaweb.ds_agen
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_usuarios_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_usuarios1
        '
        Me.Ds_usuarios1.DataSetName = "ds_usuarios"
        Me.Ds_usuarios1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("perfil", "perfil"), New System.Data.Common.DataColumnMapping("activo", "activo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_usuario, descripcion, perfil, activo FROM cima_usuarios WHERE (activo =" & _
        " 'S') ORDER BY descripcion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios_agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT agen.agencode AS Código, agen.agenname AS Agenda FROM cima_usuarios_agen I" & _
        "NNER JOIN agen ON cima_usuarios_agen.agencode = agen.agencode WHERE (cima_usuari" & _
        "os_agen.id_usuario = @id_usuario) AND (agen.agenacti = 'Y') ORDER BY agen.agenna" & _
        "me"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'Ds_usuarios_agendas1
        '
        Me.Ds_usuarios_agendas1.DataSetName = "ds_usuarios_agendas"
        Me.Ds_usuarios_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT agencode AS Código, agenname AS Agenda FROM agen WHERE (agenacti = 'Y')"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Ds_agen1
        '
        Me.Ds_agen1.DataSetName = "ds_agen"
        Me.Ds_agen1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_usuarios_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_usuarios1 As cimaweb.ds_usuarios
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_usuarios_agendas1 As cimaweb.ds_usuarios_agendas
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agen1 As cimaweb.ds_agen
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button

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

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_usuarios1.cima_usuarios)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter3.SelectCommand.CommandText = Me.SqlDataAdapter3.SelectCommand.CommandText + " AND (agencode NOT IN" & _
        " (SELECT cima_usuarios_agen.agencode " & _
        " FROM cima_usuarios_agen INNER JOIN agen ON cima_usuarios_agen.agencode = agen.agencode AND agen.agenacti='Y' " & _
        " WHERE id_usuario = '" + Me.DropDownList1.SelectedValue.ToString + "')) ORDER BY agen.agenname"
        'Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue.ToString
        Me.SqlDataAdapter3.Fill(Me.Ds_agen1.agen)
        Me.DataGrid1.DataBind()
        Me.SqlConnection1.Close()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue.ToString
        Me.SqlDataAdapter2.Fill(Me.Ds_usuarios_agendas1.cima_usuarios_agen)
        Me.DataGrid2.DataBind()
        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_ALTA_AGENDA_USUARIO '" & Me.DataGrid1.SelectedItem.Cells(1).Text & "','" & Me.DataGrid1.SelectedItem.Cells(2).Text + "','" + Me.DropDownList1.SelectedValue.ToString & "'"

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

            str_sql = "dbo.SP_CIMACEX_BAJA_AGENDA_USUARIO '" & Me.DataGrid2.SelectedItem.Cells(1).Text & "','" + Me.DropDownList1.SelectedValue.ToString & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Else



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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        'If Me.DataGrid1.SelectedIndex >= 0 Then

        str_sql = "dbo.SP_CIMACEX_ALTA_AGENDA_USUARIO_TODAS '" + Me.DropDownList1.SelectedValue.ToString & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        'Else

        'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        'End If

        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid2.SelectedIndex = -1

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        'If Me.DataGrid2.SelectedIndex >= 0 Then

        str_sql = "dbo.SP_CIMACEX_BAJA_AGENDA_USUARIO_TODAS '" + Me.DropDownList1.SelectedValue.ToString & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        'Else



        'End If
        Me.DataGrid1.SelectedIndex = -1
        Me.DataGrid2.SelectedIndex = -1

    End Sub
End Class
