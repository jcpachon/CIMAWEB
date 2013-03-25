Public Class form_medicacion_global
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
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Ds_medicacion1 As cimaweb.ds_medicacion
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_drugsele1 As cimaweb.ds_drugsele

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

        'Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.Fill(Me.Ds_drugsele1.SP_CIMACEX_MEDICACION)
        'Me.DropDownList1.DataBind()

        'Me.OdbcConnection1.Close()

        'If IsPostBack = True Then
        'Me.DropDownList1.SelectedValue = Request("DropDownList1")
        'End If

        'Me.TextBox1.Text = CStr(Today())
        'Me.TextBox5.Text = Session("episcode")

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Dim contador As Integer

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        str_menu = "dbo.SP_CIMACEX_RECUPERA_MEDICACION_PACIENTE " & Session("pers_key") & ""

        objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

        If objDS.Tables(0).Rows.Count > 0 Then
            Me.Panel1.Visible = False
        Else
            Me.Panel1.Visible = True
        End If

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("window.close();" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

End Class
