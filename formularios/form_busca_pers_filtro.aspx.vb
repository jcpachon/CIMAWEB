Public Class form_busca_pers_filtro
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_busca_pers_filtro1 = New cimaweb.ds_busca_pers_filtro
        CType(Me.Ds_busca_pers_filtro1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PACIENTES_FILTRO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2"), New System.Data.Common.DataColumnMapping("pati_hfn", "pati_hfn")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_PACIENTES_FILTRO]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dni", System.Data.SqlDbType.VarChar, 14))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@persfullname", System.Data.SqlDbType.VarChar, 100))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nhc_imarques", System.Data.SqlDbType.VarChar, 150))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@grupo", System.Data.SqlDbType.VarChar, 1))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_busca_pers_filtro1
        '
        Me.Ds_busca_pers_filtro1.DataSetName = "ds_busca_pers_filtro"
        Me.Ds_busca_pers_filtro1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_busca_pers_filtro1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection

    Protected WithEvents apnombre As System.Web.UI.WebControls.TextBox
    Protected WithEvents dni As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents NHC As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_busca_pers_filtro1 As cimaweb.ds_busca_pers_filtro

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

    Public Function f_depuracion_dni(ByVal dni As String) As String

        Dim dni_temporal As String

        Dim n As Integer

        dni = Trim(dni)

        dni_temporal = ""

        For n = 0 To Len(dni) - 1
            If dni.Chars(n).IsLetterOrDigit(dni.Chars(n)) = True Then
                dni_temporal = dni_temporal & dni.Chars(n).ToString
            End If
        Next

        f_depuracion_dni = UCase(dni_temporal)

    End Function

End Class
