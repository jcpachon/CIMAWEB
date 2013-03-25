Public Class form_historico_laboratorio
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.Ds_cima_epis_informes1 = New cimaweb.ds_cima_epis_informes
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT episcode, id_usuario, numero, informe, fecha FROM cima_epis_informes WHERE" & _
        " (episcode = @episcode) AND (numero = @numero) and id_usuario = 'echevarne.carga" & _
        "'"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero", System.Data.SqlDbType.Int, 4, "numero"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_informes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("numero", "numero"), New System.Data.Common.DataColumnMapping("informe", "informe"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        '
        'Ds_cima_epis_informes1
        '
        Me.Ds_cima_epis_informes1.DataSetName = "ds_cima_epis_informes"
        Me.Ds_cima_epis_informes1.EnforceConstraints = False
        Me.Ds_cima_epis_informes1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Ds_cima_epis_informes1 As cimaweb.ds_cima_epis_informes

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

        If Len(Trim(Request("pers_key"))) > 0 Then

            Session("pers_key") = Request("pers_key")

        End If

        If Request("abrir_informe") = "S" Then

            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Request("episcode_informe")
            Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = Request("numero_informe")

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_cima_epis_informes1.cima_epis_informes)
            Me.SqlConnection1.Close()

            Response.ClearContent()
            Response.ClearHeaders()
            Response.ContentType = "application/pdf"
            Response.AddHeader("Content-Disposition", _
            "attachment; filename=""" & Request("episcode_informe") & ".pdf""")
            Response.BinaryWrite(Me.Ds_cima_epis_informes1.cima_epis_informes.Rows(0).Item("informe"))
            Response.Flush()
            Response.Close()

        End If

    End Sub

End Class
