Public Class form_mantenimiento_agendas_usuario
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_usuarios1 = New cimaweb.ds_usuarios
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_usuarios_agendas1 = New cimaweb.ds_usuarios_agendas
        Me.Ds_agen1 = New cimaweb.ds_agen
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_usuarios_agendas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_usuarios1
        '
        Me.Ds_usuarios1.DataSetName = "ds_usuarios"
        Me.Ds_usuarios1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT agencode AS Código, agenname AS Agenda FROM agen WHERE (agenacti = 'Y')"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Ds_usuarios_agendas1
        '
        Me.Ds_usuarios_agendas1.DataSetName = "ds_usuarios_agendas"
        Me.Ds_usuarios_agendas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_agen1
        '
        Me.Ds_agen1.DataSetName = "ds_agen"
        Me.Ds_agen1.Locale = New System.Globalization.CultureInfo("en-US")
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
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_usuarios_agendas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_agen1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Ds_usuarios1 As cimaweb.ds_usuarios
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_usuarios_agendas1 As cimaweb.ds_usuarios_agendas
    Protected WithEvents Ds_agen1 As cimaweb.ds_agen
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand

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
    End Sub

End Class
