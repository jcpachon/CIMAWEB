Public Class form_mantenimiento_episodios
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents RadioButton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents RadioButton3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents RadioButton4 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Button5 As System.Web.UI.WebControls.Button
    Protected WithEvents Panel5 As System.Web.UI.WebControls.Panel

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

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim a As Integer

        Dim contador As Integer

        Dim ls_array() As String



        contador = 0

        'if Session("dia_seleccionado") <> Nothing then
        '	ls_array = Split(Session("dia_seleccionado"), "/")
        '	Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)
        'end if

        If Len(Trim(Me.TextBox1.Text)) > 0 Then

            str_menu = "dbo.SP_CIMACEX_EPIS_KEY '" & UCase(Trim(Me.TextBox1.Text)) & "'"

            'response.write (str_menu)

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            If objDS.Tables(0).Rows.Count > 0 Then

                Session("epis_key") = CStr(objDS.Tables(0).Rows(0).Item("epis_key"))

                Me.Panel1.Visible = True

                Me.RadioButton1.Checked = False
                Me.RadioButton2.Checked = False

                Me.Button1.Enabled = False
                Me.TextBox1.Enabled = False

            Else

                Session("epis_key") = 0

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Número de episodio erróneo.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        Me.Panel2.Visible = True
        Me.Panel3.Visible = False
        Me.Panel4.Visible = False
        Me.Panel5.Visible = False

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Me.Panel2.Visible = False
        Me.Panel3.Visible = True
        Me.Panel4.Visible = False
        Me.Panel5.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim a As Integer

        Dim contador As Integer

        Dim ls_array() As String



        contador = 0

        str_menu = "dbo.SP_CIMACEX_RECUPERA_NHC_IMARQUES '" & UCase(Trim(Me.TextBox1.Text)) & "'"

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        If objDS.Tables(0).Rows.Count > 0 Then

            Me.TextBox3.Text = objDS.Tables(0).Rows(0).Item("NHC_imarques")
            Me.DropDownList1.SelectedValue = objDS.Tables(0).Rows(0).Item("origen")

        End If

        Me.Panel2.Visible = False
        Me.Panel3.Visible = False
        Me.Panel4.Visible = True
        Me.Panel5.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim a As Integer

        Dim contador As Integer

        Dim ls_array() As String



        contador = 0

        'if Session("dia_seleccionado") <> Nothing then
        '	ls_array = Split(Session("dia_seleccionado"), "/")
        '	Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)
        'end if

        If Len(Trim(Me.TextBox2.Text)) > 0 Then

            str_menu = "dbo.SP_CIMACEX_EPIS_KEY '" & UCase(Trim(Me.TextBox2.Text)) & "'"

            'response.write (str_menu)

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            If objDS.Tables(0).Rows.Count > 0 Then

                str_menu = "[dbo].[SP_CIMACEX_UPDATE_EPIS_KEYFATH] '" & UCase(Trim(Me.TextBox1.Text)) & "','" & UCase(Trim(Me.TextBox2.Text)) & "'"

                'response.write (str_menu)

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('El episodio " & UCase(Trim(Me.TextBox1.Text)) & " se ha vinculado con éxito al episodio " & UCase(Trim(Me.TextBox2.Text)) & ".');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Número de episodio a vincular erróneo.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim a As Integer

        Dim contador As Integer

        Dim ls_array() As String



        contador = 0

        str_menu = "[dbo].[SP_CIMACEX_UPDATE_EPIS_KEYFATH] '" & UCase(Trim(Me.TextBox1.Text)) & "','-1'"

        'response.write (str_menu)

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("alert('El episodio " & UCase(Trim(Me.TextBox1.Text)) & " se ha desvinculado con éxito.');" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim a As Integer

        Dim contador As Integer

        Dim ls_array() As String



        contador = 0

        str_menu = "[dbo].[SP_CIMACEX_UPDATE_NHC_IMARQUES] '" & UCase(Trim(Me.TextBox1.Text)) & "','" & UCase(Trim(Me.TextBox3.Text)) & "','" & Me.DropDownList1.SelectedValue & "'"

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("alert('Datos actualizados con éxito.');" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.Panel2.Visible = False
        Me.Panel3.Visible = False
        Me.Panel4.Visible = False
        Me.Panel5.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim str_menu As String
        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS As New Data.DataSet
        Dim objRow As Data.DataRow

        Dim a As Integer
        Dim contador As Integer
        Dim ls_array() As String

        contador = 0

        If Len(Trim(Me.TextBox1.Text)) > 0 Then

            str_menu = "dbo.SP_CIMACEX_EPIS_KEYFATH '" & UCase(Trim(Me.TextBox1.Text)) & "'"

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            If objDS.Tables(0).Rows.Count > 0 Then

                str_menu = "[dbo].[SP_CIMACEX_UPDATE_EPIS_KEYFATH] '" & UCase(Trim(Me.TextBox1.Text)) & "','-2'"

                'response.write (str_menu)

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('El episodio " & UCase(Trim(Me.TextBox1.Text)) & " se ha convertido con éxito en episodio padre.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Este episodio no está ligado a ningún otro.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            End If

        End If
    End Sub
End Class
