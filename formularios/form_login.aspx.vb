Public Class form_login
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_usuarios1 = New cimaweb.ds_usuarios
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("pws", "pws")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_usuario, pws FROM cima_usuarios WHERE (id_usuario = @uid) AND (pws = @p" & _
        "ws)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@uid", System.Data.SqlDbType.VarChar, 50, "id_usuario"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pws", System.Data.SqlDbType.VarChar, 50, "pws"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SRCIMAIISINT1;packet size=4096;user id=sa;data source=""10.8.50.213"";pers" & _
        "ist security info=False;initial catalog=CIMACEX; password=kampeon10"
        '
        'Ds_usuarios1
        '
        Me.Ds_usuarios1.DataSetName = "ds_usuarios"
        Me.Ds_usuarios1.EnforceConstraints = False
        Me.Ds_usuarios1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_usuarios1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents uid As System.Web.UI.WebControls.TextBox
    Protected WithEvents pws As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_usuarios1 As cimaweb.ds_usuarios

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim obj_autenticado As New CIMA_AD.Service1
        'Dim obj_autenticado As New Prueba.Service2

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        Dim lb_ok As Boolean

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS As New Data.DataSet

        Dim str_sql As String

        str_uid = LCase(Me.uid.Text)
        str_pws = Me.pws.Text

        ' Conexión con AD de CIMA y validación.

        If obj_autenticado.IsAuthenticated("cima.net", str_uid, str_pws) = True Then

            lb_ok = True

        Else

            lb_ok = False

        End If

        'Me.SqlConnection1.Open()

        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = str_uid
        'Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = str_pws

        'Me.SqlDataAdapter1.Fill(Me.Ds_usuarios1.cima_usuarios)

        'Me.SqlConnection1.Close()

        'If Me.Ds_usuarios1.Tables(0).Rows.Count > 0 Then
        'lb_ok = True
        'Else
        'lb_ok = False
        'End If

        ' Fin.

        If lb_ok = True Then

            str_sesion_id = Session.SessionID.ToString()

            Response.Cookies("usuario").Value = str_uid
            Response.Cookies("session_id").Value = str_sesion_id


            ' Modificació JGM 30/05/2012
            ' Comprovem si ja té una sessió oberta i en cas afirmatiu no podem accedir

            str_sql = "dbo.SP_CIMACEX_COMPRUEBA_SESION '" & str_uid & "'"

            objDS = objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            If objDS.Tables(0).Rows.Count > 0 Then

                Me.Label1.Text = "SÓLO UNA SESIÓN POR USUARIO"
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert(""Solo se permite un acceso por usuario a la aplicación de CIMAWEB."");" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                ' Registro del SessionID en DB.

                str_sql = "dbo.SP_CIMACEX_ALTA_SESION '" & str_sesion_id & "','" & str_uid & "'"

                objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

                objCIMA = Nothing

                ' Fin.

                Response.Redirect("../inicio.asp")


            End If
            ' Fi modificació JGM 30/05/2012

        Else

            Me.Label1.Text = "USUARIO NO VALIDADO"

        End If

    End Sub
End Class
