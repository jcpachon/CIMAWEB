Public Class form_galeria
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents lblResults As System.Web.UI.WebControls.Label
    Protected WithEvents File1 As System.Web.UI.HtmlControls.HtmlInputFile
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents memoria As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label

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

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        If IsPostBack = False Then

            Session("epis") = Request("episcode")

            Me.memoria.Text = Request("episcode")

            'login = Request.ServerVariables("AUTH_USER")

            'login = "cima\juancarlos.pachon"

            'login_array = Split(login, "\")

            'login = login_array(1)

            Session("usuario") = Request.Cookies("usuario").Value 'login

        Else

            If Session("epis") <> Me.memoria.Text Then

                Session("epis") = Me.memoria.Text

            End If

        End If

        If Request("id_galeria") > 0 Then

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.SP_CIMACEX_BAJA_IMAGEN_EPISODIO " & Request("id_galeria") & ",'" & Session("usuario") & "'"

            objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        End If

    End Sub

    Public Sub F_Grabar(ByVal path As String)

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_ALTA_IMAGEN_EPISODIO '" & Session("epis") & "','" & path & "','" & Session("usuario") & "','" & Me.TextBox1.Text & "'"

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Response.Redirect("")

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub


End Class
