Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication

#Region " Código generado por el Diseñador de componentes "

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    'Se puede modificar utilizando el Diseñador de componentes.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la aplicación
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se inicia la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al principio de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando ocurre un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la sesión

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        ' Eliminación del SessionID en DB.

        str_uid = Request.Cookies("usuario").Value

        str_sesion_id = Request.Cookies("session_id").Value

        str_sql = "dbo.SP_CIMACEX_BAJA_SESION '" & str_sesion_id & "','" & str_uid & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        objCIMA = Nothing

        ' Fin.

        ' Eliminación de cookies.

        Request.Cookies.Remove("usuario")

        Request.Cookies.Remove("session_id")

        ' Fin.

    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando termina la aplicación
    End Sub

End Class
