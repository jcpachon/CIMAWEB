Public Class form_seleccion_plantilla
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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

        If IsPostBack = False Then

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'login = login_array(1)

            Session("usuario") = Request.Cookies("usuario").Value 'login

        End If

    End Sub

End Class
