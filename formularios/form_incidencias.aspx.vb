Public Class form_incidencias
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_incidencia_episodio1 = New cimaweb.ds_incidencia_episodio
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_incidencia_episodio1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_incidencia_episodio1
        '
        Me.Ds_incidencia_episodio1.DataSetName = "ds_incidencia_episodio"
        Me.Ds_incidencia_episodio1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_INCIDENCIAS_EPISODIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_incidencia_episodio", "id_incidencia_episodio"), New System.Data.Common.DataColumnMapping("codigo_inc", "codigo_inc"), New System.Data.Common.DataColumnMapping("descripcion_inc", "descripcion_inc")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_INCIDENCIAS_EPISODIO]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        CType(Me.Ds_incidencia_episodio1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_incidencia_episodio1 As cimaweb.ds_incidencia_episodio
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

        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

    End Sub

End Class
