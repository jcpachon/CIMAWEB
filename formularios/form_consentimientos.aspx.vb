Public Class form_consentimientos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_consentimientos1 = New cimaweb.ds_consentimientos
        CType(Me.Ds_consentimientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_CONSENTIMIENTOS_DISPONIBLES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_consentimiento", "id_consentimiento"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion"), New System.Data.Common.DataColumnMapping("permiso_acceso", "permiso_acceso")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_CONSENTIMIENTOS_DISPONIBLES]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_persona", System.Data.SqlDbType.VarChar, 50))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_consentimientos1
        '
        Me.Ds_consentimientos1.DataSetName = "ds_consentimientos"
        Me.Ds_consentimientos1.EnforceConstraints = False
        Me.Ds_consentimientos1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_consentimientos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_consentimientos1 As cimaweb.ds_consentimientos
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
        Dim login_array() As String

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'login = login_array(1)

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("usuario")

        Me.SqlDataAdapter1.Fill(Me.Ds_consentimientos1.cima_consentimientos)

        Me.DropDownList1.DataBind()

        Me.DropDownList1.Items.Insert(0, "")

        Me.SqlConnection1.Close()

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

        If Me.DropDownList1.SelectedValue = Nothing Then

            Session("id_consentimiento") = "0"

            'Me.Panel1.Visible = False

        Else

            Session("id_consentimiento") = Me.DropDownList1.SelectedValue

            'Me.Panel1.Visible = True

        End If

    End Sub
End Class
