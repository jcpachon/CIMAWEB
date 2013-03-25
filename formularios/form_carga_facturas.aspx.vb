Public Class form_carga_facturas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_cima_SNT_no_TIS1 = New cimaweb.ds_cima_SNT_no_TIS
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_cima_SNT_no_TIS1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_cima_SNT_no_TIS1
        '
        Me.Ds_cima_SNT_no_TIS1.DataSetName = "ds_cima_SNT_no_TIS"
        Me.Ds_cima_SNT_no_TIS1.EnforceConstraints = False
        Me.Ds_cima_SNT_no_TIS1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_SNT_no_TIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pericode", "pericode"), New System.Data.Common.DataColumnMapping("invsnumb", "invsnumb"), New System.Data.Common.DataColumnMapping("salecent_key", "salecent_key"), New System.Data.Common.DataColumnMapping("multigarante", "multigarante")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pericode, invsnumb, salecent_key, multigarante FROM cima_SNT_no_TIS ORDER " & _
        "BY pericode, invsnumb"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        CType(Me.Ds_cima_SNT_no_TIS1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_cima_SNT_no_TIS1 As cimaweb.ds_cima_SNT_no_TIS
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection

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
        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        If Request("borrar_ok") = "S" Then

            'If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_C500_BORRAR_FACTURAS "

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

        End If

        If Request("eliminar_ok") = "S" Then

            'If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_C500_BAJA_FACTURA " & Request("pericode") & "," & Request("invsnumb")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

        End If

        Me.Ds_cima_SNT_no_TIS1.Clear()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_cima_SNT_no_TIS1.cima_SNT_no_TIS)
        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String



        str_sql = "dbo.SP_CIMACEX_C500_ALTA_FACTURA " & Me.TextBox1.Text & "," & Me.TextBox2.Text & ",'" & Me.DropDownList1.SelectedValue & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

        Me.Ds_cima_SNT_no_TIS1.Clear()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_cima_SNT_no_TIS1.cima_SNT_no_TIS)
        Me.SqlConnection1.Close()

    End Sub

End Class
