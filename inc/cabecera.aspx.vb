Public Class cabecera
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DataSet1 = New System.Data.DataSet
        Me.DataSet2 = New System.Data.DataSet
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "sp_menu", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("desc_menu", "desc_menu"), New System.Data.Common.DataColumnMapping("id_menu", "id_menu")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[sp_menu]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "sp_login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("perfil", "perfil"), New System.Data.Common.DataColumnMapping("activo", "activo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[sp_login]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("es-ES")
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DataSet1 As System.Data.DataSet
    Protected WithEvents DataSet2 As System.Data.DataSet

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

        Dim row As DataRow
        Dim contador As Integer
        Dim valor As String

        Dim login As String
        Dim login_array() As String

        ' Seguridad.

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim str_sql As String
        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value

        If objCIMA.f_conectado(str_uid, str_sesion_id) <> "S" Then

            ' Eliminación del SessionID en DB.

            str_sql = "dbo.SP_CIMACEX_BAJA_SESION '" & str_sesion_id & "','" & str_uid & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            objCIMA = Nothing

            ' Fin.

            ' Eliminación de cookies.

            Request.Cookies.Remove("usuario")

            Request.Cookies.Remove("session_id")

            ' Fin.

            Response.Write("<script type=""text/javascript"">")
            Response.Write("top.location.href='../login.aspx';")
            Response.Write("</script>")

        End If

        ' Fin.

        'login = Request.ServerVariables("AUTH_USER")

        'login = "cima\juancarlos.pachon"

        'login_array = Split(login, "\")

        'login = login_array(1)

        Session("usuario") = Request.Cookies("usuario").Value 'login

        'Response.Cookies("usuario").Value = "cima\juancarlos.pachon"

        'Dim aCookie As New HttpCookie("lastVisit")
        'aCookie.Value = DateTime.Now.ToString
        'aCookie.Expires = DateTime.Now.AddDays(1)
        'Response.Cookies.Add(aCookie)
        'Response.Cookies("usuario").Expires = "2/12/2001"

        Session("cadena_conexion") = "Persist Security Info=False;User ID=sa;Data Source=JUPITER;Initial Catalog=CIMACEX;password=kampeon10"

        Me.SqlConnection1.ConnectionString = Session("cadena_conexion")

        ' Carga variables de Session por usuario.

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Session("usuario")
        Me.SqlDataAdapter2.Fill(Me.DataSet2)

        contador = 0

        For Each row In Me.DataSet2.Tables(0).Rows

            contador = contador + 1

            Session("id_usuario") = row.Item(0)
            Session("descripcion_usuario") = row.Item(1)
            Session("perfil") = row.Item(2)
            Session("activo") = row.Item(3)
            Session("grupo") = row.Item(4)

        Next

        Me.SqlConnection1.Close()

        ' Fin de la carga.

        If contador = 0 Then ' Usuario no validado.

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("top.location.href='../usuario_no_validado.htm';" & vbCrLf)
            Response.Write("</scr" & "ipt>")

            'Response.Redirect("../usuario_no_validado.htm")
        End If

        Label11.Text = Session("descripcion_usuario")

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.Fill(Me.DataSet1)

        contador = 0

        For Each row In Me.DataSet1.Tables(0).Rows

            contador = contador + 1

            Select Case contador

                Case 1
                    Label1.Text = row.Item(0)
                Case 2
                    Label2.Text = row.Item(0)
                Case 3
                    Label3.Text = row.Item(0)
                Case 4
                    Label4.Text = row.Item(0)
                Case 5
                    Label5.Text = row.Item(0)
                Case 6
                    Label6.Text = row.Item(0)
                Case 7
                    Label7.Text = row.Item(0)
                Case 8
                    Label8.Text = row.Item(0)
                Case 9
                    Label9.Text = row.Item(0)
                Case 10
                    Label10.Text = row.Item(0)

            End Select

        Next

        Me.SqlConnection1.Close()

    End Sub



End Class
