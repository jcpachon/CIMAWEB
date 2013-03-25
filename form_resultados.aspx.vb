Public Class form_resultados
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_epis_informes1 = New cimaweb.ds_cima_epis_informes
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_informes_master", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pdf", "pdf")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cima_epis_informes.informe FROM cima_epis_informes INNER JOIN cima_epis_cl" & _
        "aves ON cima_epis_claves.episcode = cima_epis_informes.episcode WHERE (cima_epis" & _
        "_claves.episcode = @episcode) AND (cima_epis_claves.clave = @clave) AND (cima_ep" & _
        "is_claves.clave_sms = @clave_sms)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10, "clave"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@clave_sms", System.Data.SqlDbType.VarChar, 10, "clave_sms"))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=NEPTUNO;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_UPDATE_EPIS_CLAVES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_UPDATE_EPIS_CLAVES]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'Ds_cima_epis_informes1
        '
        Me.Ds_cima_epis_informes1.DataSetName = "ds_cima_epis_informes"
        Me.Ds_cima_epis_informes1.EnforceConstraints = False
        Me.Ds_cima_epis_informes1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
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

        If Len(Trim(Request("episcode"))) > 0 And Len(Trim(Request("clave"))) > 0 Then

            Session("episcode") = Request("episcode")
            Session("clave") = Request("clave")
            Session("clave_sms") = Request("clave_sms")

            'Me.Button1.Text = Session("episcode")

        End If

        If Request("ok") = "S" Then

            Descarga_PDF()

        End If

    End Sub

    Sub Descarga_PDF()

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS_USR As New Data.DataSet



        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("episcode")
        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("clave")
        Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = Session("clave_sms")

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_cima_epis_informes1.cima_epis_informes)
        Me.SqlConnection2.Close()

        If Me.Ds_cima_epis_informes1.cima_epis_informes.Rows.Count > 0 Then

            Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = Session("episcode")

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter2.SelectCommand.ExecuteNonQuery()
            Me.SqlConnection2.Close()

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

            'ls_array_fecha_entrega = Split(Request("fecha_entrega"), "/", , CompareMethod.Text)

            str_menu = "[dbo].[SP_CIMACEX_UPDATE_ESTADO_INFORME] '" & Session("episcode") & "','10','W','" & CStr(Year(Today())) & "-" & CStr(Month(Today())) & "-" & CStr(Day(Today())) & "','',''"

            objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Response.ClearContent()
            Response.ClearHeaders()
            Response.ContentType = "application/pdf"
            Response.AddHeader("Content-Disposition", _
            "attachment; filename=""" & Session("episcode") & ".pdf""")
            Response.BinaryWrite(Me.Ds_cima_epis_informes1.cima_epis_informes.Rows(0).Item("informe"))
            Response.Flush()
            'Response.Close()
            '    'Response.Close()

            Response.Write("<script type=""text/javascript"">")
            Response.Write("window.close();")
            Response.Write("</script>")

        Else

            Response.Write("<script type=""text/javascript"">")
            Response.Write("alert('En estos momentos su informe aún no está disponible. En caso que hayan transcurrido más de 10 días desde la realización de la prueba, por favor contacte con el Departamento de Informática de la clínica - 93 552 27 45.');")
            'Response.Write("window.close();")
            Response.Write("</script>")

        End If

    End Sub

End Class
