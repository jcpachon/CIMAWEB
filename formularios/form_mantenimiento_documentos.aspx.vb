Public Class form_mantenimiento_documentos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agenproc1 = New cimaweb.ds_agenproc
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_agenproc2 = New cimaweb.ds_agenproc
        CType(Me.Ds_agenproc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agenproc2, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT hprodesclong AS agenprocdesc, hpro_key AS agenproc_key FROM hpro ORDER BY " & _
        "hprodesclong"
        Me.SqlSelectCommand1.CommandTimeout = 0
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Ds_agenproc1
        '
        Me.Ds_agenproc1.DataSetName = "ds_agenproc"
        Me.Ds_agenproc1.EnforceConstraints = False
        Me.Ds_agenproc1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT hprocode AS agenproccode, hprodesclong AS agenprocdesc FROM hpro WHERE (hp" & _
        "ro_key = @hpro_key)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, "hpro_key"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cima_hpro (hpro_key) VALUES (@hpro_key)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, "hpro_key"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cima_hpro WHERE (hpro_key = @hpro_key)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hpro_key", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hpro_key", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name"), New System.Data.Common.DataColumnMapping("id_creador", "id_creador"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agenproc", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agenproc_key", "agenproc_key")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT hcon_key AS agenproc_key FROM hcon WHERE (hprocode = @hprocode)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hprocode", System.Data.SqlDbType.Variant))
        '
        'Ds_agenproc2
        '
        Me.Ds_agenproc2.DataSetName = "ds_agenproc"
        Me.Ds_agenproc2.EnforceConstraints = False
        Me.Ds_agenproc2.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_agenproc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agenproc2, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agenproc1 As cimaweb.ds_agenproc
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_agenproc2 As cimaweb.ds_agenproc
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents lblResults As System.Web.UI.WebControls.Label
    Protected WithEvents file As System.Web.UI.HtmlControls.HtmlInputFile

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim ib_control As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        'ib_control = True

        Dim login As String
        Dim login_array() As String

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;")
        Response.Write("</scr" & "ipt>" & vbCrLf)

        If IsPostBack = False Then

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

        If Trim(Request("modo_borrado")) = "S" Then
            elimina_documento(Request("agenproc_key"), Request("line"))
            'Response.Redirect("form_mantenimiento_documentos.aspx")
        End If

        If Len(Trim(Request("DropDownList1"))) > 0 Then
            Session("DropDownList1") = Request("DropDownList1")
        End If

        'If Request("control") = "S" Then

        'recargar()

        'End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_agenproc1.agenproc)
        Me.Dropdownlist1.DataBind()
        Me.SqlConnection1.Close()

        Me.Dropdownlist1.Items.Insert(0, "")

        If ib_control = False Then

            Me.Dropdownlist1.SelectedValue = Request("DropDownList1")

            Me.Ds_agenproc1.Clear()

            If Len(Trim(Request("DropDownList1"))) > 0 Then

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.Dropdownlist1.SelectedValue
                Me.SqlDataAdapter2.Fill(Me.Ds_agenproc1.agenproc)
                Me.DataList1.DataBind()
                Me.SqlConnection1.Close()

            End If

            If Me.Ds_agenproc1.agenproc.Count <= 0 Then

                Me.DataList1.Visible = False
                'Me.Button1.Visible = False
                Me.Button2.Visible = False

            Else

                Me.DataList1.Visible = True
                'Me.Button1.Visible = True
                Me.Button2.Visible = True

                Me.Panel1.Visible = True
                Me.Panel2.Visible = True

            End If

        Else

            Me.Dropdownlist1.SelectedValue = ""

            Me.DataList1.Visible = True
            'Me.Button1.Visible = True
            Me.Button2.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        'Me.SqlDataAdapter2.Fill(Me.Ds_agenproc1.agenproc)
        'Me.DataList1.DataBind()
        'Me.SqlConnection1.Close()

        CType(DataList1.Items(0).FindControl("id_procedimiento"), TextBox).Enabled = True
        CType(DataList1.Items(0).FindControl("id_procedimiento"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("descripcion"), Label).Text = ""

        ib_control = True

        Me.Button1.Visible = True
        Me.Panel1.Visible = False
        Me.Panel2.Visible = False

        Me.Dropdownlist1.Enabled = False
        Me.Button2.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim li_agenproc_key As Integer
        ' Control por botón de Nuevo.
        'If Me.Button2.Enabled = True Then

        Me.SqlConnection1.Open()

        'Me.SqlDataAdapter2.UpdateCommand.Parameters(0).Value = li_firm_key
        'Me.SqlDataAdapter2.UpdateCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("firmcode"), TextBox).Text
        'Me.SqlDataAdapter2.UpdateCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
        'Me.SqlDataAdapter2.UpdateCommand.Parameters(3).Value = Me.Dropdownlist1.SelectedValue 'IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")

        'Me.SqlDataAdapter2.UpdateCommand.ExecuteNonQuery()
        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("id_procedimiento"), TextBox).Text
        Me.SqlDataAdapter3.Fill(Me.Ds_agenproc2.agenproc)

        Me.SqlConnection1.Close()

        'Else

        If Me.Ds_agenproc2.Tables(0).Rows.Count > 0 Then

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.InsertCommand.Parameters(0).Value = Me.Ds_agenproc2.Tables(0).Rows(0).Item(0)
            'Me.SqlDataAdapter2.InsertCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("firmcode"), TextBox).Text
            'Me.SqlDataAdapter2.InsertCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            'Me.SqlDataAdapter2.InsertCommand.Parameters(3).Value = Session("usuario")

            Me.SqlDataAdapter2.InsertCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

            'End If

            ib_control = False

            Me.Button2.Enabled = True
            Me.Dropdownlist1.Enabled = True

            Me.Button1.Visible = False

            Me.TextBox1.Text = ""
            Me.DropDownList2.SelectedValue = 1

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        Dim str_file() As String

        Dim str_email As String

        'If Me.DataGrid1.SelectedIndex >= 0 Then

        str_file = Split(file.PostedFile.FileName, "\", , CompareMethod.Text)
        'str_file = Split(Request("file"), "\", , CompareMethod.Text)

        If Me.CheckBox1.Checked = True Then
            str_email = "S"
        Else
            str_email = "N"
        End If

        str_sql = "dbo.SP_CIMACEX_ASIGNACION_DOCUMENTO " & Me.Dropdownlist1.SelectedValue & "," & Me.DropDownList2.SelectedValue & ",'../documentos/" & str_file(UBound(str_file)) & "','" & Me.TextBox1.Text & "','" & str_email & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Me.TextBox1.Text = ""
        Me.DropDownList2.SelectedValue = 1

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 'S';")
        Response.Write("</scr" & "ipt>" & vbCrLf)

        'Response.Redirect("form_mantenimiento_documentos.aspx?DropDownList1=" & Session("DropDownList1") & "&control=S")

        'Else

        'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        'End If

    End Sub

    Private Sub elimina_documento(ByVal clave As String, ByVal line As String)

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        str_sql = "dbo.SP_CIMACEX_ELIMINAR_DOCUMENTO " & clave & "," & line

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        'Else

        'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        'End If

    End Sub

    Private Sub Dropdownlist1_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dropdownlist1.SelectedIndexChanged

        ib_control = False

        Me.Panel1.Visible = True
        Me.Panel2.Visible = True

        Me.Button1.Visible = False

    End Sub

End Class



