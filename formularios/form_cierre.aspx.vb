Public Class form_cierre
    Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
        'No la modifique con el editor de c�digo.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aqu� el c�digo de usuario para inicializar la p�gina

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim str_sql As String
        Dim str_uid, str_pws As String
        Dim str_sesion_id As String

        str_uid = Request.Cookies("usuario").Value
        str_sesion_id = Request.Cookies("session_id").Value



        ' Eliminaci�n del SessionID en DB.

        str_sql = "dbo.SP_CIMACEX_BAJA_SESION '" & str_sesion_id & "','" & str_uid & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        objCIMA = Nothing

        ' Fin.

        ' Eliminaci�n de cookies.

        Request.Cookies.Remove("usuario")

        Request.Cookies.Remove("session_id")

    End Sub

End Class
