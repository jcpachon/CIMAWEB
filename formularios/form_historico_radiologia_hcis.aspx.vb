Public Class form_historico_radiologia_hcis
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.Ds_cima_epis_informes1 = New cimaweb.ds_cima_epis_informes
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Ds_pers1 = New cimaweb.ds_pers
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT episcode, id_usuario, numero, informe, fecha FROM cima_epis_informes WHERE" & _
        " (episcode = @episcode) AND (numero = @numero)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero", System.Data.SqlDbType.Int, 4, "numero"))
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
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT pers_key FROM cima_SNT_mapeo_NHC WHERE (NUMHC = @NUMHC)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NUMHC", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "NUMHC", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_pers1
        '
        Me.Ds_pers1.DataSetName = "ds_pers"
        Me.Ds_pers1.EnforceConstraints = False
        Me.Ds_pers1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Ds_cima_epis_informes1 As cimaweb.ds_cima_epis_informes
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Public service As New CIMAServeiIntegracio.ServeiIntegracio

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        If Len(Trim(Request("NUMHC"))) > 0 Then

            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Request("NUMHC")

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter2.Fill(Me.Ds_pers1.pers)
            Me.SqlConnection2.Close()

            If Me.Ds_pers1.pers.Rows.Count > 0 Then

                Session("pers_key") = Me.Ds_pers1.pers.Rows(0).Item("pers_key")

            Else

                Response.Redirect("informe_sin_informe.aspx")

            End If

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
