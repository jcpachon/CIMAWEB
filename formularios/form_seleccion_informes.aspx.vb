Public Class form_seleccion_informes
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_plantillas1 = New cimaweb.ds_plantillas
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("version", "version"), New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_plantilla, version, descripcion, acceso_libre, informacion, id_propieta" & _
        "rio, fecha_creacion FROM cima_plantillas WHERE (id_propietario = @id_propietario" & _
        ")"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_propietario", System.Data.SqlDbType.VarChar, 50, "id_propietario"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_plantillas1
        '
        Me.Ds_plantillas1.DataSetName = "ds_plantillas"
        Me.Ds_plantillas1.EnforceConstraints = False
        Me.Ds_plantillas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla"), New System.Data.Common.DataColumnMapping("version", "version"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("acceso_libre", "acceso_libre"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("id_propietario", "id_propietario"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cima_plantillas WHERE (id_plantilla = @Original_id_plantilla) AND (ve" & _
        "rsion = @Original_version) AND (acceso_libre = @Original_acceso_libre OR @Origin" & _
        "al_acceso_libre IS NULL AND acceso_libre IS NULL) AND (descripcion = @Original_d" & _
        "escripcion OR @Original_descripcion IS NULL AND descripcion IS NULL) AND (fecha_" & _
        "creacion = @Original_fecha_creacion OR @Original_fecha_creacion IS NULL AND fech" & _
        "a_creacion IS NULL) AND (id_propietario = @Original_id_propietario OR @Original_" & _
        "id_propietario IS NULL AND id_propietario IS NULL) AND (informacion = @Original_" & _
        "informacion OR @Original_informacion IS NULL AND informacion IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_plantilla", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_plantilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_version", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "version", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_acceso_libre", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "acceso_libre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_creacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_creacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_propietario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_propietario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_informacion", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "informacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cima_plantillas (descripcion, informacion, id_propietario) VALUES (@d" & _
        "escripcion, @informacion, @id_propietario)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 250, "descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@informacion", System.Data.SqlDbType.VarChar, 500, "informacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_propietario", System.Data.SqlDbType.VarChar, 50, "id_propietario"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_plantilla, version, descripcion, acceso_libre, informacion, id_propieta" & _
        "rio, fecha_creacion FROM cima_plantillas WHERE (id_plantilla = @id_plantilla)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_plantilla", System.Data.SqlDbType.Int, 4, "id_plantilla"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cima_plantillas SET descripcion = @descripcion, informacion = @informacion" & _
        " WHERE (id_plantilla = @Original_id_plantilla)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 250, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@informacion", System.Data.SqlDbType.VarChar, 500, "informacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_plantilla", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_plantilla", System.Data.DataRowVersion.Original, Nothing))
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_plantillas1 As cimaweb.ds_plantillas
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

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
        Me.SqlDataAdapter1.Fill(Me.Ds_plantillas1.cima_plantillas)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.Items.Insert(0, "")

        If ib_control = False Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

            Me.Ds_plantillas1.Clear()

            Me.SqlConnection1.Open()

            If Me.DropDownList1.SelectedValue = "" Or Me.DropDownList1.SelectedValue = Nothing Then

                li_seleccion = 0

            Else

                li_seleccion = Me.DropDownList1.SelectedValue

            End If

            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = li_seleccion 'Me.DropDownList1.SelectedValue
            Me.SqlDataAdapter2.Fill(Me.Ds_plantillas1.cima_plantillas)
            Me.DataList1.DataBind()
            Me.SqlConnection1.Close()

            If Me.Ds_plantillas1.cima_plantillas.Count <= 0 Then

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

        If DataList1.Visible = True Then
            CType(DataList1.Items(0).FindControl("id_plantilla"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("informacion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("label2"), Label).Text = ""
            CType(DataList1.Items(0).FindControl("label3"), Label).Text = ""
            'CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked = False
        Else
            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = 1 'Me.DropDownList1.SelectedValue
            Me.SqlDataAdapter2.Fill(Me.Ds_plantillas1.cima_plantillas)
            Me.DataList1.DataBind()
            Me.SqlConnection1.Close()
            CType(DataList1.Items(0).FindControl("id_plantilla"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("informacion"), TextBox).Text = ""
            CType(DataList1.Items(0).FindControl("label2"), Label).Text = ""
            CType(DataList1.Items(0).FindControl("label3"), Label).Text = ""
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
            Me.SqlDataAdapter2.UpdateCommand.Parameters(2).Value = CInt(CType(DataList1.Items(0).FindControl("id_plantilla"), TextBox).Text)

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
        Response.Write("location.href='form_mantenimiento_informes.aspx?id_plantilla=" & CType(DataList1.Items(0).FindControl("id_plantilla"), TextBox).Text & "';")
        Response.Write("</script>")

    End Sub
End Class
