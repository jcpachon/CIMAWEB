Public Class uo_documentos_rel
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents lblResults As System.Web.UI.WebControls.Label
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile

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

    Public Sub F_Grabar(ByVal file As String)

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_ALTA_DOCUMENTO_EPISODIO '" & file & "'," & Session("pers_key") & ",'" & Session("usuario") & "','" & Me.DropDownList2.SelectedValue.ToString & "'"

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

    End Sub


End Class
