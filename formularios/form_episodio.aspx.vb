Public Class form_episodio
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_pacientes1 = New cimaweb.ds_pacientes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_grupos1 = New cimaweb.ds_grupos
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_garantes_epis1 = New cimaweb.ds_cima_garantes_epis
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_garantes_epis1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_PACIENTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("persfullname", "persfullname")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "{? = CALL [SP_CIMACEX_RECUPERA_PACIENTE]( ? )}"
        Me.OdbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@episcode", System.Data.Odbc.OdbcType.VarChar, 50))
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_pacientes1
        '
        Me.Ds_pacientes1.DataSetName = "ds_pacientes"
        Me.Ds_pacientes1.EnforceConstraints = False
        Me.Ds_pacientes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_grupos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_grupo", "id_grupo"), New System.Data.Common.DataColumnMapping("desc_grupo", "desc_grupo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cima_grupos.id_grupo, cima_grupos.desc_grupo FROM cima_grupos INNER JOIN c" & _
        "ima_usuarios_grupos ON cima_grupos.id_grupo = cima_usuarios_grupos.id_grupo WHER" & _
        "E (cima_usuarios_grupos.id_usuario = @id_usuario) ORDER BY cima_grupos.desc_grup" & _
        "o"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'Ds_grupos1
        '
        Me.Ds_grupos1.DataSetName = "ds_grupos"
        Me.Ds_grupos1.EnforceConstraints = False
        Me.Ds_grupos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_garantes1
        '
        Me.Ds_cima_garantes1.DataSetName = "ds_cima_garantes"
        Me.Ds_cima_garantes1.EnforceConstraints = False
        Me.Ds_cima_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Mutua", "Mutua")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cima_garantes.id_garante AS Código, cima_garantes.firm_name AS Mutua FROM " & _
        "cima_epis INNER JOIN cima_garantes ON cima_epis.id_garante = cima_garantes.id_ga" & _
        "rante WHERE (cima_epis.episcode = @episcode)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'Ds_cima_garantes_epis1
        '
        Me.Ds_cima_garantes_epis1.DataSetName = "ds_cima_garantes_epis"
        Me.Ds_cima_garantes_epis1.EnforceConstraints = False
        Me.Ds_cima_garantes_epis1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_MUTUAS_ENTIDAD", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_MUTUAS_ENTIDAD]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@entidad", System.Data.SqlDbType.VarChar, 250))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo_entidad", System.Data.SqlDbType.Int, 4))
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_grupos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_garantes_epis1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_pacientes1 As cimaweb.ds_pacientes
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_grupos1 As cimaweb.ds_grupos
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_garantes_epis1 As cimaweb.ds_cima_garantes_epis
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Datagrid1 As System.Web.UI.WebControls.DataGrid

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
        Dim login_array() As String

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        If IsPostBack = False Then

            Session("episodio") = Request("episodio")
            Session("episodio_origen") = Request("episodio_origen")
            Session("pers_key_origen") = Request("pers_key_origen")
            Session("DropDownList1_origen") = Request("DropDownList1_origen")
            Session("control") = Request("control")

            Session("mutua") = Request("mutua")
            Session("nacimiento") = Request("nacimiento")

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            Session("usuario") = Request.Cookies("usuario").Value 'login

            ' Recuperación del paciente por episodio.

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = Session("episodio")
            Me.OdbcDataAdapter1.Fill(Me.Ds_pacientes1.pacientes)

            Session("paciente") = Me.Ds_pacientes1.pacientes.Rows(0).Item(1)

            Me.OdbcConnection1.Close()

            ' Fin.

        End If

        If Len(Trim(Request("episodio"))) > 0 Then
            Session("episodio_origen") = Request("episodio")
        Else
            Session("episodio_origen") = Session("episodio")
        End If

        Label1.Text = "Episodio " & Session("episodio_origen") 'Session("episodio")

        Me.Label3.Text = Session("paciente")

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        actualizar()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        'str_menu = "dbo.SP_CIMACEX_ALTA_GARANTE_EPISODIO " & Me.DropDownList1.SelectedValue & ",'" & Session("episodio") & "'"
        str_menu = "dbo.SP_CIMACEX_ALTA_GARANTE_EPISODIO " & Me.DropDownList1.SelectedValue & ",'" & Session("episodio_origen") & "'"

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        actualizar()

    End Sub

    Public Sub actualizar()

        Dim str_grupo_seleccionado As String

        If Me.RadioButton1.Checked = True Then
            Session("tipo") = "1"
            Session("entidad") = "CIMA"
        ElseIf Me.RadioButton2.Checked = True Then
            Session("tipo") = "2"
            Session("entidad") = Me.DropDownList2.SelectedValue
        Else
            Session("tipo") = "3"
            Session("entidad") = Session("usuario")
        End If

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("entidad")
        Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = Session("tipo")

        Me.SqlDataAdapter1.Fill(Me.Ds_cima_garantes1.cima_garantes)

        Me.DropDownList1.DataBind()

        Me.SqlConnection1.Close()

        Me.Ds_cima_garantes1.cima_garantes.Clear()

        Me.SqlConnection1.Open()

        str_grupo_seleccionado = Me.DropDownList2.SelectedValue

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Session("usuario")

        Me.SqlDataAdapter2.Fill(Me.Ds_grupos1.cima_grupos)

        Me.DropDownList2.DataBind()

        Me.SqlConnection1.Close()

        If Len(Trim(str_grupo_seleccionado)) > 0 Then
            Me.DropDownList2.SelectedValue = str_grupo_seleccionado
        End If

        Me.Ds_cima_garantes_epis1.cima_garantes.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Session("episodio_origen") 'Session("episodio")

        Me.SqlDataAdapter3.Fill(Me.Ds_cima_garantes_epis1.cima_garantes)

        Me.DataGrid1.DataBind()

        Me.SqlConnection1.Close()

        ' Sólo un garante por episodio. Si se elimina este código, hasta n.

        If Me.Ds_cima_garantes_epis1.Tables(0).Rows.Count >= 1 Then
            Me.Button1.Enabled = False
        Else
            Me.Button1.Enabled = True
        End If

        ' Fin.

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid1.SelectedIndex >= 0 Then

            'str_sql = "dbo.SP_CIMACEX_BAJA_GARANTE_EPISODIO " & Me.DataGrid1.SelectedItem.Cells(1).Text & ",'" & Session("episodio") & "'"
            str_sql = "dbo.SP_CIMACEX_BAJA_GARANTE_EPISODIO " & Me.DataGrid1.SelectedItem.Cells(1).Text & ",'" & Session("episodio_origen") & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Else

            'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        End If

        Me.DataGrid1.SelectedIndex = -1
        'Me.DataGrid2.SelectedIndex = -1

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 2;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 3;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub
End Class
