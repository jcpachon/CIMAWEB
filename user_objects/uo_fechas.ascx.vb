Public Class uo_fechas
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents fecha_ini As System.Web.UI.WebControls.TextBox
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents fecha_fin As System.Web.UI.WebControls.TextBox
    Protected WithEvents Imagebutton2 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Calendar2 As System.Web.UI.WebControls.Calendar

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

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If Me.Calendar1.Visible = True Then
            Me.Calendar1.Visible = False
        Else
            Me.Calendar1.Visible = True
        End If
    End Sub

    Private Sub Imagebutton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton2.Click
        If Me.Calendar2.Visible = True Then
            Me.Calendar2.Visible = False
            ' me.Calendar2.
        Else
            Me.Calendar2.Visible = True
        End If
    End Sub

    Private Sub Calendar2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        Me.fecha_fin.Text = Me.Calendar2.SelectedDate.ToShortDateString.ToString
        Me.Calendar2.Visible = False
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        Me.fecha_ini.Text = Me.Calendar1.SelectedDate.ToShortDateString.ToString
        Me.Calendar1.Visible = False
    End Sub

End Class
