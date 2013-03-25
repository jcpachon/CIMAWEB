Public Class form_usuarios
    Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_usuarios1 = New cimaweb.ds_usuarios
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("perfil", "perfil"), New System.Data.Common.DataColumnMapping("activo", "activo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_usuario, descripcion, perfil, activo, grupo, n_colegiado FROM cima_usua" & _
        "rios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_usuarios1
        '
        Me.Ds_usuarios1.DataSetName = "ds_usuarios"
        Me.Ds_usuarios1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("perfil", "perfil"), New System.Data.Common.DataColumnMapping("activo", "activo")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cima_usuarios WHERE (id_usuario = @Original_id_usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cima_usuarios (id_usuario, descripcion, perfil, activo, grupo, n_cole" & _
        "giado) VALUES (@id_usuario, @descripcion, @perfil, @activo, @grupo, @n_colegiado" & _
        ")"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 150, "descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@perfil", System.Data.SqlDbType.VarChar, 10, "perfil"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.VarChar, 1, "activo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 1, "grupo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@n_colegiado", System.Data.SqlDbType.VarChar, 50, "n_colegiado"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_usuario, descripcion, perfil, activo, grupo, n_colegiado FROM cima_usua" & _
        "rios WHERE (id_usuario = @id_usuario)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cima_usuarios SET id_usuario = @id_usuario, descripcion = @descripcion, pe" & _
        "rfil = @perfil, activo = @activo, grupo = @grupo, n_colegiado = @n_colegiado WHE" & _
        "RE (id_usuario = @Original_id_usuario)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 150, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@perfil", System.Data.SqlDbType.VarChar, 10, "perfil"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.VarChar, 1, "activo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 1, "grupo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@n_colegiado", System.Data.SqlDbType.VarChar, 50, "n_colegiado"))
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_usuarios1 As cimaweb.ds_usuarios
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button

    'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
        'No la modifique con el editor de c�digo.
        InitializeComponent()
    End Sub

#End Region

    Dim ib_control As Boolean

    Public Function CheckBoxEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "S" Then
            returnValue = "True"
        Else
            returnValue = "False"
        End If

        Return returnValue

    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aqu� el c�digo de usuario para inicializar la p�gina

        'Me.Ds_usuarios1.Clear()

        'Me.SqlConnection1.Open()
        'Me.SqlDataAdapter1.Fill(Me.Ds_usuarios1.cima_usuarios)
        'Me.DropDownList1.DataBind()
        'Me.SqlConnection1.Close()

        'Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'Me.Ds_usuarios1.Clear()

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_usuarios1.cima_usuarios)
        Me.DropDownList1.DataBind()
        Me.SqlConnection1.Close()

        Me.DropDownList1.Items.Insert(0, "")

        If ib_control = False Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

            Me.Ds_usuarios1.Clear()

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
            Me.SqlDataAdapter2.Fill(Me.Ds_usuarios1.cima_usuarios)
            Me.DataList1.DataBind()
            Me.SqlConnection1.Close()

            If Me.Ds_usuarios1.cima_usuarios.Count <= 0 Then

                Me.DataList1.Visible = False
                Me.Button1.Visible = False
                Me.Button2.Visible = False

            Else

                CType(DataList1.Items(0).FindControl("grupo"), DropDownList).SelectedValue = Me.Ds_usuarios1.cima_usuarios.Rows(0).Item("grupo")

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Control por bot�n de Nuevo.
        If Me.Button2.Enabled = True Then

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.UpdateCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("id_usuario"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("perfil"), TextBox).Text
            Me.SqlDataAdapter2.UpdateCommand.Parameters(3).Value = IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")
            Me.SqlDataAdapter2.UpdateCommand.Parameters(4).Value = CType(DataList1.Items(0).FindControl("grupo"), DropDownList).SelectedValue
            Me.SqlDataAdapter2.UpdateCommand.Parameters(5).Value = Me.DropDownList1.SelectedValue 'IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")
            Me.SqlDataAdapter2.UpdateCommand.Parameters(6).Value = CType(DataList1.Items(0).FindControl("n_colegiado"), TextBox).Text

            Me.SqlDataAdapter2.UpdateCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        Else

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter2.InsertCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("id_usuario"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("perfil"), TextBox).Text
            Me.SqlDataAdapter2.InsertCommand.Parameters(3).Value = IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")
            Me.SqlDataAdapter2.InsertCommand.Parameters(4).Value = CType(DataList1.Items(0).FindControl("grupo"), DropDownList).SelectedValue
            Me.SqlDataAdapter2.InsertCommand.Parameters(5).Value = CType(DataList1.Items(0).FindControl("n_colegiado"), TextBox).Text

            Me.SqlDataAdapter2.InsertCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        End If

        ib_control = False

        Me.Button2.Enabled = True
        Me.DropDownList1.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        CType(DataList1.Items(0).FindControl("id_usuario"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("descripcion"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("perfil"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked = False

        CType(DataList1.Items(0).FindControl("grupo"), DropDownList).SelectedValue = "A"

        CType(DataList1.Items(0).FindControl("n_colegiado"), TextBox).Text = ""

        ib_control = True

        Me.DropDownList1.Enabled = False
        Me.Button2.Enabled = False

    End Sub

End Class
