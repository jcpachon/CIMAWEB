Public Class form_mantenimiento_consentimientos
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
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("acceso_libre", "acceso_libre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT descripcion, informacion, permiso_acceso FROM cima_consentimientos WHERE (" & _
        "id_consentimiento = @id_consentimiento)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_consentimiento", System.Data.SqlDbType.Int, 4, "id_consentimiento"))
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
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim login As String
        Dim login_array() As String

        Dim objRow As Data.DataRow

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        If Len(Request("texto")) > 0 Then
            Session("texto") = Request("texto")
        Else
            Session("texto") = ""
        End If

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'login = login_array(1)

            Session("usuario") = Request.Cookies("usuario").Value 'login

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORMACION_USUARIO '" & Session("usuario") & "'"

            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Session("grupos") = ""

            For Each objRow In objDS.Tables(0).Rows

                Session("descripcion") = objRow.Item(0)
                Session("grupos") = Session("grupos") & " " & objRow.Item(1)

            Next

            objDS = Nothing

            Session("id_consentimiento") = Request("id_consentimiento")

        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim ls_seleccion As String

        Me.Ds_consentimientos1.cima_consentimientos.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("id_consentimiento")
        Me.SqlDataAdapter1.Fill(Me.Ds_consentimientos1.cima_consentimientos)

        Me.TextBox3.DataBind()
        Me.TextBox4.DataBind()

        'Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE " & Session("descripcion")

        Me.SqlConnection1.Close()

        If Request("ok") = "S" Then

            Actualizar()

        End If

    End Sub

    Public Sub Actualizar()

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        Dim str_activo As String

        If Request("actiu") = True Then
            str_activo = "S"
        Else
            str_activo = "N"
        End If

        str_sql = "dbo.SP_CIMACEX_MODIFICACION_CONSENTIMIENTO " & Session("id_consentimiento") & "," & Request("permisos") & ",'" & Session("texto") & "','" & str_activo & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

    End Sub

End Class
