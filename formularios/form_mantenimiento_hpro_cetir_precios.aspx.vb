Public Class form_mantenimiento_hpro_cetir_precios
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_hpro_cetir_precios1 = New cimaweb.ds_hpro_cetir_precios
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_hpro_cetir_precios1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_hpro_cetir_precios1
        '
        Me.Ds_hpro_cetir_precios1.DataSetName = "ds_hpro_cetir_precios"
        Me.Ds_hpro_cetir_precios1.EnforceConstraints = False
        Me.Ds_hpro_cetir_precios1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_hpro_cetir_precios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("hprocode", "hprocode"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong"), New System.Data.Common.DataColumnMapping("importe", "importe")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT hpro_key, hprocode, hprodesclong, coalesce(importe,0.00) as importe FROM cima_hpro_cetir_precios ORD" & _
        "ER BY hprocode"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        CType(Me.Ds_hpro_cetir_precios1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_hpro_cetir_precios1 As cimaweb.ds_hpro_cetir_precios
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



        If Request("actualizacion") = "S" Then

            str_sql = "dbo.SP_CIMACEX_UPDATE_HPRO_CETIR_PRECIO " & Request("clave") & "," & Request("importe")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        End If

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.Fill(Me.Ds_hpro_cetir_precios1.cima_hpro_cetir_precios)

        Me.SqlConnection1.Close()

    End Sub

End Class
