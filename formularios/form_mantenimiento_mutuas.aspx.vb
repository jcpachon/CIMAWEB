Public Class form_mantenimiento_mutuas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_cima_garantes1 = New cimaweb.ds_cima_garantes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_garante, firm_name FROM cima_garantes ORDER BY firm_name"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_cima_garantes1
        '
        Me.Ds_cima_garantes1.DataSetName = "ds_cima_garantes"
        Me.Ds_cima_garantes1.EnforceConstraints = False
        Me.Ds_cima_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_garante", "id_garante"), New System.Data.Common.DataColumnMapping("firm_key", "firm_key"), New System.Data.Common.DataColumnMapping("firmcode", "firmcode"), New System.Data.Common.DataColumnMapping("firm_name", "firm_name"), New System.Data.Common.DataColumnMapping("id_creador", "id_creador"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cima_garantes WHERE (id_garante = @Original_id_garante) AND (fecha_cr" & _
        "eacion = @Original_fecha_creacion OR @Original_fecha_creacion IS NULL AND fecha_" & _
        "creacion IS NULL) AND (firm_key = @Original_firm_key OR @Original_firm_key IS NU" & _
        "LL AND firm_key IS NULL) AND (firm_name = @Original_firm_name OR @Original_firm_" & _
        "name IS NULL AND firm_name IS NULL) AND (firmcode = @Original_firmcode OR @Origi" & _
        "nal_firmcode IS NULL AND firmcode IS NULL) AND (id_creador = @Original_id_creado" & _
        "r OR @Original_id_creador IS NULL AND id_creador IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_garante", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_garante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_creacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_creacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_firm_key", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "firm_key", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_firm_name", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "firm_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_firmcode", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "firmcode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_creador", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_creador", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cima_garantes (firm_key, firmcode, firm_name, id_creador) VALUES (@fi" & _
        "rm_key, @firmcode, @firm_name, @id_creador)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4, "firm_key"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmcode", System.Data.SqlDbType.VarChar, 15, "firmcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_name", System.Data.SqlDbType.VarChar, 250, "firm_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_creador", System.Data.SqlDbType.VarChar, 50, "id_creador"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_garante, firm_key, firmcode, firm_name, id_creador, fecha_creacion FROM" & _
        " cima_garantes WHERE (id_garante = @id_garante)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_garante", System.Data.SqlDbType.Int, 4, "id_garante"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cima_garantes SET firm_key = @firm_key, firmcode = @firmcode, firm_name = " & _
        "@firm_name WHERE (id_garante = @id_garante)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_key", System.Data.SqlDbType.Int, 4, "firm_key"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firmcode", System.Data.SqlDbType.VarChar, 15, "firmcode"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firm_name", System.Data.SqlDbType.VarChar, 250, "firm_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_garante", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_garante", System.Data.DataRowVersion.Original, Nothing))
        CType(Me.Ds_cima_garantes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_cima_garantes1 As cimaweb.ds_cima_garantes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand

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

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_cima_garantes1.cima_garantes)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.Items.Insert(0, "")

        If ib_control = False Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

            Me.Ds_cima_garantes1.Clear()

            If Len(Trim(Request("DropDownList1"))) > 0 Then

                Me.SqlConnection1.Open()
                Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
                Me.SqlDataAdapter2.Fill(Me.Ds_cima_garantes1.cima_garantes)
                Me.DataList1.DataBind()
                Me.SqlConnection1.Close()

            End If

            If Me.Ds_cima_garantes1.cima_garantes.Count <= 0 Then

                Me.DataList1.Visible = False
                Me.Button1.Visible = False
                Me.Button2.Visible = False

            Else

                Me.DataList1.Visible = True
                Me.Button1.Visible = True
                Me.Button2.Visible = True

            End If

        Else

            Me.DropDownList1.SelectedValue = ""

            Me.DataList1.Visible = True
            Me.Button1.Visible = True
            Me.Button2.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        CType(DataList1.Items(0).FindControl("id_garante"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("firm_key"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("firmcode"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("id_creador"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("fecha_creacion"), TextBox).Text = ""

        ib_control = True

        Me.DropDownList1.Enabled = False
        Me.Button2.Enabled = False

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        ib_control = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim li_firm_key As Integer

        If IsNumeric(CType(DataList1.Items(0).FindControl("firm_key"), TextBox).Text) = True Then
            li_firm_key = CInt(CType(DataList1.Items(0).FindControl("firm_key"), TextBox).Text)
        Else
            li_firm_key = 0
        End If

        ' Control por botón de Nuevo.
        If Me.Button2.Enabled = True Then

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.UpdateCommand.Parameters(0).Value = li_firm_key
            Me.SqlDataAdapter2.UpdateCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("firmcode"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(3).Value = Me.DropDownList1.SelectedValue 'IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")

            Me.SqlDataAdapter2.UpdateCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        Else

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.InsertCommand.Parameters(0).Value = li_firm_key
            Me.SqlDataAdapter2.InsertCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("firmcode"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(3).Value = Session("usuario")

            Me.SqlDataAdapter2.InsertCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        End If

        ib_control = False

        Me.Button2.Enabled = True
        Me.DropDownList1.Enabled = True

    End Sub
End Class
