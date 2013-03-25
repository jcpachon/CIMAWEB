Public Class form_usuarios_mutuas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_garantes1 = New cimaweb.ds_garantes
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_id_identidad1 = New cimaweb.ds_id_identidad
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_garantes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_id_identidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave de CIMA", "Clave de CIMA"), New System.Data.Common.DataColumnMapping("Código de CIMA", "Código de CIMA")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cima_garantes.id_garante AS 'Código Mutua', cima_garantes.firm_name AS Nom" & _
        "bre, cima_garantes.firm_key AS 'Clave CIMA', cima_garantes.firmcode AS 'Código C" & _
        "IMA' FROM cima_entidades INNER JOIN cima_garantes_entidades ON cima_entidades.id" & _
        "_entidad = cima_garantes_entidades.id_entidad INNER JOIN cima_garantes ON cima_g" & _
        "arantes_entidades.id_garante = cima_garantes.id_garante WHERE (cima_entidades.no" & _
        "mbre = @nombre) AND (cima_entidades.tipo_entidad = @tipo_entidad)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 250, "nombre"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo_entidad", System.Data.SqlDbType.Int, 4, "tipo_entidad"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_garantes1
        '
        Me.Ds_garantes1.DataSetName = "ds_garantes"
        Me.Ds_garantes1.EnforceConstraints = False
        Me.Ds_garantes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_entidades", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_entidad", "id_entidad")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_entidad FROM cima_entidades WHERE (nombre = @nombre)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 250, "nombre"))
        '
        'Ds_id_identidad1
        '
        Me.Ds_id_identidad1.DataSetName = "ds_id_identidad"
        Me.Ds_id_identidad1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código Mutua", "Código Mutua"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave CIMA", "Clave CIMA"), New System.Data.Common.DataColumnMapping("Código CIMA", "Código CIMA")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_garante AS 'Código Mutua', firm_name AS Nombre, firm_key AS 'Clave CIMA" & _
        "', firmcode AS 'Código CIMA' FROM cima_garantes"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_garantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código Mutua", "Código Mutua"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave CIMA", "Clave CIMA"), New System.Data.Common.DataColumnMapping("Código CIMA", "Código CIMA")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_garante AS 'Código Mutua', firm_name AS Nombre, firm_key AS 'Clave CIMA" & _
        "', firmcode AS 'Código CIMA' FROM cima_garantes"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        CType(Me.Ds_garantes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_id_identidad1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_garantes1 As cimaweb.ds_garantes
    'Protected WithEvents Ds_id_garante1 As cimaweb.ds_id_garante
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_id_identidad1 As cimaweb.ds_id_identidad
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand

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

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.Ds_garantes1.cima_garantes.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("usuario")
        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 3

        Me.SqlDataAdapter1.Fill(Me.Ds_garantes1.cima_garantes)

        Me.DataGrid2.DataBind()

        Me.SqlConnection1.Close()

        Me.Ds_garantes1.cima_garantes.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter4.SelectCommand.CommandText = "SELECT id_garante AS 'Código Mutua', firm_name AS 'Nombre', firm_key AS 'Clave CIMA', firmcode AS 'Código CIMA' FROM cima_garantes WHERE (id_garante NOT IN (SELECT cima_garantes_entidades.id_garante FROM cima_entidades , cima_garantes_entidades WHERE cima_entidades.id_entidad = cima_garantes_entidades.id_entidad AND cima_entidades.nombre = '" & Session("usuario") & "' AND cima_entidades.tipo_entidad = 3))"

        'Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Session("usuario")
        'Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = 2

        Me.SqlDataAdapter4.Fill(Me.Ds_garantes1.cima_garantes)

        Me.DataGrid1.DataBind()

        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.DataGrid1.SelectedIndex >= 0 Then

            ' Recuperación del id_entidad.

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Session("usuario")
            Me.SqlDataAdapter3.Fill(Me.Ds_id_identidad1.cima_entidades)

            Session("id_entidad") = Me.Ds_id_identidad1.cima_entidades.Rows(0).Item(0)

            Me.SqlConnection1.Close()

            ' Fin.

            str_sql = "dbo.SP_CIMACEX_ALTA_GARANTE_USUARIO " & Me.DataGrid1.SelectedItem.Cells(1).Text & "," & Session("id_entidad") & ",3"

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

            ' Recuperación del id_entidad.

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Session("usuario")
            Me.SqlDataAdapter3.Fill(Me.Ds_id_identidad1.cima_entidades)

            Session("id_entidad") = Me.Ds_id_identidad1.cima_entidades.Rows(0).Item(0)

            Me.SqlConnection1.Close()

            ' Fin.

            str_sql = "dbo.SP_CIMACEX_BAJA_GARANTE_USUARIO " & Me.DataGrid2.SelectedItem.Cells(1).Text & "," & Session("id_entidad") & ",3"

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

End Class
