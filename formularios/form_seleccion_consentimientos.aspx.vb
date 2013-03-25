Public Class form_seleccion_consentimientos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds_consentimientos1 = New cimaweb.ds_consentimientos
        CType(Me.Ds_consentimientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("version", "version"), New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_consentimiento, version, descripcion, informacion, id_usuario, fecha_cr" & _
        "eacion FROM cima_consentimientos WHERE (id_usuario = @id_usuario)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla"), New System.Data.Common.DataColumnMapping("version", "version"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("acceso_libre", "acceso_libre"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("id_propietario", "id_propietario"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cima_consentimientos (descripcion, informacion, id_usuario, version) " & _
        "VALUES (@descripcion, @informacion, @id_usuario, 1)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 250, "descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@informacion", System.Data.SqlDbType.VarChar, 500, "informacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_consentimiento, version, descripcion, informacion, id_usuario, fecha_cr" & _
        "eacion FROM cima_consentimientos WHERE (id_consentimiento = @id_consentimiento)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_consentimiento", System.Data.SqlDbType.Int, 4, "id_consentimiento"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cima_consentimientos SET descripcion = @descripcion, informacion = @inform" & _
        "acion WHERE (id_consentimiento = @id_consentimiento)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 250, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@informacion", System.Data.SqlDbType.VarChar, 500, "informacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_consentimiento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_consentimiento", System.Data.DataRowVersion.Original, Nothing))
        '
        'Ds_consentimientos1
        '
        Me.Ds_consentimientos1.DataSetName = "ds_consentimientos"
        Me.Ds_consentimientos1.EnforceConstraints = False
        Me.Ds_consentimientos1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_consentimientos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_consentimientos1 As cimaweb.ds_consentimientos

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

        Dim login As String
        Dim login_array() As String

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'login = login_array(1)

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim li_seleccion As Integer

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("usuario")
        Me.SqlDataAdapter1.Fill(Me.Ds_consentimientos1.cima_consentimientos)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.Items.Insert(0, "")

        If ib_control = False Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

            Me.Ds_consentimientos1.Clear()

            Me.SqlConnection1.Open()

            If Me.DropDownList1.SelectedValue = "" Or Me.DropDownList1.SelectedValue = Nothing Then

                li_seleccion = 0

            Else

                li_seleccion = Me.DropDownList1.SelectedValue

            End If

            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = li_seleccion 'Me.DropDownList1.SelectedValue
            Me.SqlDataAdapter2.Fill(Me.Ds_consentimientos1.cima_consentimientos)
            Me.DataList1.DataBind()
            Me.SqlConnection1.Close()

            If Me.Ds_consentimientos1.cima_consentimientos.Count <= 0 Then

                Me.DataList1.Visible = False
                Me.Button1.Visible = False
                If IsPostBack = False Then
                    Me.Button2.Visible = True
                Else
                    Me.Button2.Visible = False
                End If

                Me.Button3.Visible = False

            Else

                Me.DataList1.Visible = True
                Me.Button1.Visible = True
                Me.Button2.Visible = True
                Me.Button3.Visible = True

            End If

        Else

            Me.DropDownList1.SelectedValue = ""

            Me.DataList1.Visible = True
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim dt As DataTable = Me.Ds_consentimientos1.Tables(0)
        Dim dtrow As DataRow

        If DataList1.Visible = True Then

            CType(DataList1.Items(0).FindControl("id_consentimiento"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("informacion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("label2"), Label).Text = ""
            CType(DataList1.Items(0).FindControl("label3"), Label).Text = ""
            'CType(DataList1.Items(0).FindContrl("activo"), CheckBox).Checked = False

        Else

            'Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = 1 'Me.DropDownList1.SelectedValue
            'Me.SqlDataAdapter2.Fill(Me.Ds_consentimientos1.cima_consentimientos)
            'Me.DataList1.DataBind()
            'Me.SqlConnection1.Close()

            'If Me.Ds_consentimientos1.cima_consentimientos.Rows.Count <= 0 Then

            dtrow = dt.NewRow()

            dtrow("descripcion") = ""

            dtrow("informacion") = ""

            Me.Ds_consentimientos1.cima_consentimientos.Rows.Add(dtrow)
            Me.Ds_consentimientos1.AcceptChanges()

            Me.DataList1.DataBind()
            Me.DataList1.SelectedIndex = 1

            'End If

            'CType(DataList1.Items(0).FindControl("id_consentimiento"), TextBox).Text = ""
            'CType(DataList1.Items(1).FindControl("descripcion"), TextBox).Text = ""
            'CType(DataList1.Items(1).FindControl("informacion"), TextBox).Text = ""
            'CType(DataList1.Items(1).FindControl("label2"), Label).Text = ""
            'CType(DataList1.Items(1).FindControl("label3"), Label).Text = ""

        End If

        ib_control = True

        Me.DropDownList1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Control por botón de Nuevo.
        If Me.Button2.Enabled = True Then

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.UpdateCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("informacion"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(2).Value = CInt(CType(DataList1.Items(0).FindControl("id_consentimiento"), TextBox).Text)

            Me.SqlDataAdapter2.UpdateCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        Else

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.InsertCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("informacion"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(2).Value = Session("usuario")

            Me.SqlDataAdapter2.InsertCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        End If

        ib_control = False

        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.DropDownList1.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Response.Write("<script type=""text/javascript"">")
        Response.Write("location.href='form_mantenimiento_consentimientos.aspx?id_consentimiento=" & CType(DataList1.Items(0).FindControl("id_consentimiento"), TextBox).Text & "';")
        Response.Write("</script>")

    End Sub

End Class
