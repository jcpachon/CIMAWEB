Public Class form_mantenimiento_informes
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_plantillas1 = New cimaweb.ds_plantillas
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_campos1 = New cimaweb.ds_campos
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_campos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("acceso_libre", "acceso_libre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT descripcion, informacion, acceso_libre, permiso_acceso FROM cima_plantilla" & _
        "s WHERE (id_plantilla = @id_plantilla)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_plantilla", System.Data.SqlDbType.Int, 4, "id_plantilla"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_plantillas1
        '
        Me.Ds_plantillas1.DataSetName = "ds_plantillas"
        Me.Ds_plantillas1.EnforceConstraints = False
        Me.Ds_plantillas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas_campos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Tipo de Dato", "Tipo de Dato"), New System.Data.Common.DataColumnMapping("Descripción Campo", "Descripción Campo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cima_plantillas_campos.id_plantilla_campos AS Código, cima_plantillas_camp" & _
        "os.display_name AS Nombre, cima_tipo_datos.descripcion AS 'Tipo de Dato', cima_p" & _
        "lantillas_campos.descripcion AS 'Descripción Campo', cima_plantillas_campos.posi" & _
        "cion AS Orden, cima_plantillas_campos.campo_visible_informe AS 'Visible en Infor" & _
        "me' FROM cima_plantillas_campos INNER JOIN cima_tipo_datos ON cima_plantillas_ca" & _
        "mpos.id_tipo_datos = cima_tipo_datos.id_tipo_datos WHERE (cima_plantillas_campos" & _
        ".id_plantilla = @id_plantilla) order by cima_plantillas_campos.posicion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_plantilla", System.Data.SqlDbType.Int, 4, "id_plantilla"))
        '
        'Ds_campos1
        '
        Me.Ds_campos1.DataSetName = "ds_campos"
        Me.Ds_campos1.EnforceConstraints = False
        Me.Ds_campos1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_campos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_plantillas1 As cimaweb.ds_plantillas
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_campos1 As cimaweb.ds_campos
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DataGrid2 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button

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

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            Session("tipo_update") = "I"

            str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORMACION_USUARIO '" & Session("usuario") & "'"

            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Session("grupos") = ""

            For Each objRow In objDS.Tables(0).Rows

                Session("descripcion") = objRow.Item(0)
                Session("grupos") = Session("grupos") & " " & objRow.Item(1)

            Next

            objDS = Nothing

            Session("id_plantilla") = Request("id_plantilla")

        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        If Me.DropDownList1.SelectedValue = "3" Then

            Me.Panel1.Visible = True

        Else

            Me.Panel1.Visible = False

        End If

    End Sub



    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim ls_seleccion As String

        Me.Ds_plantillas1.cima_plantillas.Clear()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("id_plantilla")
        Me.SqlDataAdapter1.Fill(Me.Ds_plantillas1.cima_plantillas)

        Me.TextBox3.DataBind()
        Me.TextBox4.DataBind()

        If Request("DropDownList2") > 0 Then

            ls_seleccion = Request("DropDownList2")

        Else

            ls_seleccion = Me.Ds_plantillas1.Tables(0).Rows(0).Item("permiso_acceso")

        End If

        Select Case ls_seleccion
            Case "1"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE " & Session("descripcion")
            Case "2"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE LOS GRUPOS: " & Session("grupos")
            Case "3"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE TODOS LOS USUARIOS DEL SISTEMA"
            Case Else
                Me.Label1.Text = ""
        End Select

        Me.DropDownList2.SelectedValue = CInt(ls_seleccion)

        'Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE " & Session("descripcion")

        Me.SqlConnection1.Close()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Session("id_plantilla")
        Me.SqlDataAdapter2.Fill(Me.Ds_campos1.cima_plantillas_campos)

        'Me.DataGrid1.DataBind()
        Me.DataGrid2.DataBind()

        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.TextBox1.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.DropDownList3.SelectedValue = "S" 'Me.Textbox7.Text = ""
        Me.DropDownList1.Enabled = True

        Me.DataGrid2.SelectedIndex = -1

        Me.Button2.Enabled = False

        Session("tipo_update") = "I"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        str_sql = "dbo.SP_CIMACEX_MODIFICACION_PERFIL_PLANTILLA " & Session("id_plantilla") & "," & Me.DropDownList2.SelectedValue.ToString

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

    End Sub


    Private Sub DropDownList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged

        Select Case Me.DropDownList2.SelectedValue
            Case "1"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE " & Session("descripcion")
            Case "2"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE LOS GRUPOS: " & Session("grupos")
            Case "3"
                Me.Label1.Text = "PLANTILLA A DISPOSICIÓN DE TODOS LOS USUARIOS DEL SISTEMA"
            Case Else
                Me.Label1.Text = ""
        End Select

    End Sub

    Private Sub DataGrid2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid2.SelectedIndexChanged

        Me.TextBox1.Text = Me.DataGrid2.SelectedItem.Cells(2).Text
        Me.TextBox5.Text = Me.DataGrid2.SelectedItem.Cells(4).Text
        Me.TextBox6.Text = Me.DataGrid2.SelectedItem.Cells(5).Text
        Me.DropDownList3.SelectedValue = Me.DataGrid2.SelectedItem.Cells(6).Text
        'Me.Textbox7.Text = Me.DataGrid2.SelectedItem.Cells(6).Text
        Me.DropDownList1.Enabled = False

        Me.Button2.Enabled = True

        Session("codigo") = Me.DataGrid2.SelectedItem.Cells(1).Text

        Session("tipo_update") = "U"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If IsNumeric(Me.TextBox6.Text) = True Then

            If Session("tipo_update") = "I" Then

                If Me.DropDownList1.SelectedValue = 3 Then

                    str_sql = "dbo.SP_CIMACEX_ALTA_CAMPODESPLEGABLE_PLANTILLA '" & Me.TextBox5.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList1.SelectedValue.ToString & ", " & Session("id_plantilla") & ",'" & Me.TextBox2.Text & "'," & Me.TextBox6.Text & ",'" & Me.DropDownList3.SelectedValue & "'"

                Else

                    str_sql = "dbo.SP_CIMACEX_ALTA_CAMPO_PLANTILLA '" & Me.TextBox5.Text & "','" & Me.TextBox1.Text & "'," & Me.DropDownList1.SelectedValue.ToString & ", " & Session("id_plantilla") & "," & Me.TextBox6.Text & ",'" & Me.DropDownList3.SelectedValue & "'"

                End If

            Else

                str_sql = "dbo.SP_CIMACEX_UPDATE_CAMPO_PLANTILLA '" & Me.TextBox5.Text & "','" & Me.TextBox1.Text & "'," & Me.TextBox6.Text & ", " & Session("codigo") & ",'" & Me.DropDownList3.SelectedValue & "'"

            End If

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Me.TextBox1.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.DropDownList3.SelectedValue = "S"
            Me.DropDownList1.Enabled = True

            Me.DataGrid2.SelectedIndex = -1

            'Me.Button2.Enabled = False

            Me.Button2.Enabled = False

            Session("tipo_update") = "I"

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        ' Comentado para la no eliminación.

        If IsNumeric(Session("codigo")) = True Then

            str_sql = "dbo.SP_CIMACEX_BAJA_CAMPO_PLANTILLA " & Session("codigo")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Me.TextBox1.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.DropDownList3.SelectedValue = "S"
            Me.DropDownList1.Enabled = True

            Me.DataGrid2.SelectedIndex = -1

            Me.Button2.Enabled = False

            Session("tipo_update") = "I"

        End If

        ' Fin.

    End Sub
End Class
