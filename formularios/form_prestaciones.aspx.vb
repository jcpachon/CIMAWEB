Public Class form_prestaciones
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_hpro1 = New cimaweb.ds_hpro
        Me.SqlDataAdapter9 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_hpro1
        '
        Me.Ds_hpro1.DataSetName = "ds_hpro"
        Me.Ds_hpro1.EnforceConstraints = False
        Me.Ds_hpro1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter9
        '
        Me.SqlDataAdapter9.SelectCommand = Me.SqlSelectCommand9
        Me.SqlDataAdapter9.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PRESTACIONES_EPISODIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("hpro_keyfath", "hpro_keyfath"), New System.Data.Common.DataColumnMapping("hprocode", "hprocode"), New System.Data.Common.DataColumnMapping("hprodescshor", "hprodescshor"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong"), New System.Data.Common.DataColumnMapping("hprodura", "hprodura"), New System.Data.Common.DataColumnMapping("hproleve", "hproleve"), New System.Data.Common.DataColumnMapping("hproacti", "hproacti"), New System.Data.Common.DataColumnMapping("hproupda", "hproupda"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("txts_key", "txts_key"), New System.Data.Common.DataColumnMapping("hproorde", "hproorde"), New System.Data.Common.DataColumnMapping("hpro_uvr", "hpro_uvr"), New System.Data.Common.DataColumnMapping("hprogrouclos", "hprogrouclos"), New System.Data.Common.DataColumnMapping("hprocodenorm", "hprocodenorm"), New System.Data.Common.DataColumnMapping("hprotypecode", "hprotypecode"), New System.Data.Common.DataColumnMapping("hprovaliperi", "hprovaliperi"), New System.Data.Common.DataColumnMapping("hprocode_crc", "hprocode_crc")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CIMACEX_PRESTACIONES_EPISODIO]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_hpro1 As cimaweb.ds_hpro
    Protected WithEvents SqlDataAdapter9 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand

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

        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

    End Sub

End Class
