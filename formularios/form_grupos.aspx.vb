Public Class form_mant_grupos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_pers_grupos1 = New cimaweb.ds_pers_grupos
        Me.Ds_pers_grupos2 = New cimaweb.ds_pers_grupos
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_grupos1 = New cimaweb.ds_grupos
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Ds_grupos2 = New cimaweb.ds_grupos
        CType(Me.Ds_pers_grupos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_pers_grupos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_grupos2, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_usuario AS 'Código Usuario', descripcion AS Descripción FROM cima_usuar" & _
        "ios WHERE (id_usuario NOT IN (SELECT cima_usuarios_grupos.id_usuario FROM cima_u" & _
        "suarios_grupos WHERE cima_usuarios_grupos.id_grupo = @id_grupo)) AND (activo = '" & _
        "S') ORDER BY id_usuario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_grupo", System.Data.SqlDbType.Int, 4, "id_grupo"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_pers_grupos1
        '
        Me.Ds_pers_grupos1.DataSetName = "ds_pers_grupos"
        Me.Ds_pers_grupos1.EnforceConstraints = False
        Me.Ds_pers_grupos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_pers_grupos2
        '
        Me.Ds_pers_grupos2.DataSetName = "ds_pers_grupos"
        Me.Ds_pers_grupos2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_grupo", "id_grupo"), New System.Data.Common.DataColumnMapping("desc_grupo", "desc_grupo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_grupo, desc_grupo FROM cima_grupos ORDER BY desc_grupo"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Ds_grupos1
        '
        Me.Ds_grupos1.DataSetName = "ds_grupos"
        Me.Ds_grupos1.EnforceConstraints = False
        Me.Ds_grupos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cima_usuarios.id_usuario AS 'Código Usuario', cima_usuarios.descripcion AS" & _
        " Descripción FROM cima_usuarios INNER JOIN cima_usuarios_grupos ON cima_usuarios" & _
        ".id_usuario = cima_usuarios_grupos.id_usuario WHERE (cima_usuarios_grupos.id_gru" & _
        "po = @id_grupo) ORDER BY cima_usuarios.id_usuario"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_grupo", System.Data.SqlDbType.Int, 4, "id_grupo"))
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_grupo", "id_grupo"), New System.Data.Common.DataColumnMapping("desc_grupo", "desc_grupo")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_grupo, desc_grupo, sms FROM cima_grupos WHERE (id_grupo = @id_grupo)"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_grupo", System.Data.SqlDbType.Int, 4, "id_grupo"))
        '
        'Ds_grupos2
        '
        Me.Ds_grupos2.DataSetName = "ds_grupos"
        Me.Ds_grupos2.EnforceConstraints = False
        Me.Ds_grupos2.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_pers_grupos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_pers_grupos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_grupos2, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_pers_grupos1 As cimaweb.ds_pers_grupos
    Protected WithEvents Ds_pers_grupos2 As cimaweb.ds_pers_grupos
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_grupos1 As cimaweb.ds_grupos
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button6 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_grupos2 As cimaweb.ds_grupos
    Protected WithEvents Button7 As System.Web.UI.WebControls.Button

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

        'If IsPostBack = False Then
        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        'End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim str_menu As String

        Dim str_ok As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        If Len(Session("id_grupo")) > 0 Then

            If Me.CheckBox1.Checked = True Then
                str_ok = "S"
            Else
                str_ok = "N"
            End If
            str_menu = "dbo.SP_CIMACEX_MODIFICACION_GRUPO '" & Me.TextBox1.Text & "', " & Session("id_grupo") & ",'" & str_ok & "'"
            Session("id_grupo") = ""

        Else

            If Me.CheckBox1.Checked = True Then
                str_ok = "S"
            Else
                str_ok = "N"
            End If
            str_menu = "dbo.SP_CIMACEX_ALTA_GRUPO '" & Me.TextBox1.Text & "','" & str_ok & "'"

        End If

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        actualizar()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Panel1.Visible = True
        Me.Panel2.Visible = False

        Me.Button2.Enabled = False
        Me.Button5.Enabled = False
        Me.Button6.Enabled = False
        Me.Button7.Enabled = False

        Me.TextBox1.Text = ""
        Me.CheckBox1.Checked = False

    End Sub

    Private Sub actualizar()

        Me.Ds_grupos1.cima_grupos.Clear()
        Me.Ds_pers_grupos1.cima_usuarios.Clear()
        Me.Ds_pers_grupos2.cima_usuarios.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter2.Fill(Me.Ds_grupos1.cima_grupos)

        Me.DropDownList1.DataBind()

        If Len(Request("DropDownList1")) > 0 Then
            Me.DropDownList1.SelectedValue = Request("DropDownList1")
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Request("DropDownList1")
        Else
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        End If

        Me.SqlDataAdapter1.Fill(Me.Ds_pers_grupos1.cima_usuarios)

        Me.DataGrid1.DataBind()

        If Len(Request("DropDownList1")) > 0 Then
            'Me.DropDownList1.SelectedValue = Request("DropDownList1")
            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Request("DropDownList1")
        Else
            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        End If

        'Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = 1

        Me.SqlDataAdapter3.Fill(Me.Ds_pers_grupos2.cima_usuarios)

        Me.DataGrid2.DataBind()

        Me.SqlConnection1.Close()

        Me.Panel1.Visible = False
        Me.Panel2.Visible = True

        Me.Button2.Enabled = True
        Me.Button5.Enabled = True
        Me.Button6.Enabled = True
        Me.Button7.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        If Len(Me.DataGrid1.SelectedItem.Cells(1).Text) > 0 Then

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.SP_CIMACEX_ALTA_GRUPO_USUARIO '" & Me.DataGrid1.SelectedItem.Cells(1).Text & "'," & Me.DropDownList1.SelectedValue.ToString

            objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            actualizar()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        If Len(Me.DataGrid2.SelectedItem.Cells(1).Text) > 0 Then

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.SP_CIMACEX_BAJA_GRUPO_USUARIO '" & Me.DataGrid2.SelectedItem.Cells(1).Text & "'," & Me.DropDownList1.SelectedValue.ToString

            objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            actualizar()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Me.Panel1.Visible = True
        Me.Panel2.Visible = False

        Me.Button2.Enabled = False
        Me.Button5.Enabled = False
        Me.Button6.Enabled = False
        'Me.Button7.Enabled = False

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter4.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue

        Me.SqlDataAdapter4.Fill(Me.Ds_grupos2.cima_grupos)

        Me.SqlConnection1.Close()

        Me.TextBox1.Text = Me.Ds_grupos2.cima_grupos.Rows(0).Item(1)

        If Me.Ds_grupos2.cima_grupos.Rows(0).Item(2) = "S" Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If

        Session("id_grupo") = Me.DropDownList1.SelectedValue

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_BAJA_GRUPO " & Me.DropDownList1.SelectedValue

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("location.href='form_grupos.aspx';" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged

        Me.DataGrid1.SelectedIndex = -1

        Me.DataGrid1.CurrentPageIndex = e.NewPageIndex()

    End Sub

    Private Sub DataGrid2_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid2.PageIndexChanged

        Me.DataGrid2.SelectedIndex = -1

        Me.DataGrid2.CurrentPageIndex = e.NewPageIndex()

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        actualizar()

    End Sub
End Class
