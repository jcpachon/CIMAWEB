Public Class form_medicacion
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_medicacion1 = New cimaweb.ds_medicacion
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_drugsele1 = New cimaweb.ds_drugsele
        CType(Me.Ds_medicacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_drugsele1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_medicacion1
        '
        Me.Ds_medicacion1.DataSetName = "ds_medicacion"
        Me.Ds_medicacion1.EnforceConstraints = False
        Me.Ds_medicacion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_MEDICACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("drugselecode_key", "drugselecode_key"), New System.Data.Common.DataColumnMapping("drugseledesc", "drugseledesc")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "{? = CALL [SP_CIMACEX_MEDICACION]}"
        Me.OdbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_drugsele1
        '
        Me.Ds_drugsele1.DataSetName = "ds_drugsele"
        Me.Ds_drugsele1.EnforceConstraints = False
        Me.Ds_drugsele1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_medicacion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_drugsele1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_medicacion1 As cimaweb.ds_medicacion
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_drugsele1 As cimaweb.ds_drugsele
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents memoria As System.Web.UI.WebControls.TextBox
    Protected WithEvents contador As System.Web.UI.WebControls.TextBox

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

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.Fill(Me.Ds_drugsele1.SP_CIMACEX_MEDICACION)
        Me.DropDownList1.DataBind()

        Me.OdbcConnection1.Close()

        If IsPostBack = True Then
            Me.DropDownList1.SelectedValue = Request("DropDownList1")
        Else
            Me.TextBox1.Text = CStr(Today())
            Me.TextBox5.Text = Session("episcode")
            Me.memoria.Text = Session("pers_key")
        End If

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("window.close();" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_ALTA_MEDICACION " & Me.memoria.Text & ",'" & Me.TextBox5.Text & "', " & Me.DropDownList1.SelectedItem.Value & ", '" & Me.DropDownList1.SelectedItem.Text & "','" & Me.TextBox2.Text & "','" & _
        Me.TextBox3.Text & "','" & Me.DropDownList2.SelectedItem.Value & "'," & Me.TextBox6.Text & ""

        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim array() As String
        Dim n As Integer

        Dim str_menu As String
        Dim objCIMA As New CIMA_Clases.CIMA

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        If Len(Request("cadena_creciente")) > 0 Then

            array = Split(Request("cadena_creciente"), "*", , CompareMethod.Text)

            str_menu = "SP_CIMACEX_ELIMINAR_MEDICACION_RECETA"
            objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            For n = 0 To UBound(array)

                If array(n) <> "" Then

                    str_menu = "dbo.SP_CIMACEX_INSERTAR_MEDICACION_RECETA " & array(n)
                    objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                End If

            Next

            Response.Write("<script src='../js/cima.js'></script>")
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("f_abre('../informes/informe_basico_receta_display.aspx',600,850,'');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        objCIMA = Nothing

        'Me.SqlConnection1.Open()

        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("episcode")
        'Me.SqlDataAdapter1.Fill(Me.Ds_medicacion1.cima_medicacion)

        'If Me.Ds_medicacion1.cima_medicacion.Rows.Count = 0 Then

        'Me.DataGrid1.Visible = False
        'Me.Button2.Visible = False
        'Me.DataList1.Visible = False
        'Me.Button3.Visible = False
        'Me.Panel1.Visible = True

        'Else

        'Me.DataGrid1.Visible = True
        'Me.Button2.Visible = True
        'Me.DataList1.Visible = True
        'Me.Button3.Visible = True
        'Me.Panel1.Visible = False
        'Me.DataGrid1.DataBind()

        'End If

        'Me.SqlConnection1.Close()

    End Sub
End Class
