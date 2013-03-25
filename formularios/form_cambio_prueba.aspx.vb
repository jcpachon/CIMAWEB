Public Class form_cambio_prueba
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_prestaciones1 = New cimaweb.ds_prestaciones
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "prod", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Descripción", "Descripción"), New System.Data.Common.DataColumnMapping("Tiempo", "Tiempo"), New System.Data.Common.DataColumnMapping("prod_key", "prod_key"), New System.Data.Common.DataColumnMapping("proddesclong", "proddesclong")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT LTRIM(RTRIM(hpro.hprodesclong)) + ' - ' + CAST(proctita.proctitad" & _
        "ura AS varchar) + ' min' AS Descripción, CAST(proctita.proctitadura AS varchar) " & _
        "+ '/' + CAST(hpro.hpro_key AS varchar) AS Tiempo, prod.prod_key, prod.proddesclo" & _
        "ng FROM hpro INNER JOIN proctita ON proctita.hpro_key = hpro.hpro_key INNER JOIN" & _
        " btimetab ON btimetab.btimetabcode = proctita.btimetabcode AND proctita.agencode" & _
        " = btimetab.agencode LEFT OUTER JOIN prod ON hpro.hprocode = prod.prodcode WHERE" & _
        " (proctita.agencode = @agencode) AND (hpro.hproacti = 'Y') AND (proctita.proctit" & _
        "aacti = 'Y') AND (btimetab.btimetabacti = 'Y')"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6, "agencode"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_prestaciones1
        '
        Me.Ds_prestaciones1.DataSetName = "ds_prestaciones"
        Me.Ds_prestaciones1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_prestaciones1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList

    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_prestaciones1 As cimaweb.ds_prestaciones

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    Private service As New CIMAServeiIntegracio.ServeiIntegracio

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim str_uid As String

        Session("agencode") = Request("agencode")
        Session("episcode") = Request("episcode")

        str_uid = Request.Cookies("usuario").Value

        ' Omplim el desplegable amb les diferents prestacions
        If IsPostBack = False Then

            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Session("agencode")

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_prestaciones1.prestaciones)
            Me.SqlConnection1.Close()

            Me.DropDownList1.DataBind()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim str_menu, str_menu_2 As String

        Dim objDS As New Data.DataSet
        Dim objDS_2 As New Data.DataSet
        Dim objRow As Data.DataRow

        Dim li_id_prova() As Integer
        Dim lstr_id_prova As String
        Dim ls_cadena As String
        Dim ls_prestacion As String
        Dim ls_pers_key_cetir As String
        Dim ls_array() As String

        Dim l_transaccion As New CIMAServeiIntegracio.Transaccio
        Dim l_transaccion_retorno As New CIMAServeiIntegracio.Transaccio

        'Recuperem l'identificador de prestació de CETIR
        ls_array = Split(Me.DropDownList1.SelectedValue.ToString, "/", , CompareMethod.Text)

        str_menu_2 = "dbo.SP_CIMACEX_RECUPERA_PRESTACION_CETIR " & ls_array(1)

        objDS_2 = objCIMA.f_consulta_CSaludR(str_menu_2, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        ls_prestacion = CStr(objDS_2.Tables(0).Rows(0).Item("ID_Prova"))

        'Recuperem el pers_key de CETIR
        str_menu = "dbo.SP_CIMACEX_EPIS_NOTIFICADO_CETIR '" & Session("episcode") & "'"

        objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

        If objDS.Tables(0).Rows.Count > 0 Then
            l_transaccion = service.BegginTransaction()

            ls_pers_key_cetir = objDS.Tables(0).Rows(0).Item("pers_key_cetir")

            li_id_prova = service.CanviDadesRecepcioDePacient(l_transaccion.ID, True, ls_pers_key_cetir, Session("episcode"), ls_prestacion, "")

            l_transaccion_retorno = service.CommitTransaccio(l_transaccion.ID, True)

            ls_cadena = "episcode=" & Session("episcode") & "#" & "id_prueba_old=" & objDS.Tables(0).Rows(0).Item("ID_Prova_CETIR") & "#" & "id_prueba_new=" & CStr(li_id_prova(0)) & "#" & "transaccion_retorno=" & l_transaccion_retorno.Estat_Transaccio

            str_menu = "[dbo].[SP_CIMAWEB_ALTA_TRAZA_CETIR] '','" & ls_cadena & "','UCI'"

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=NEPTUNO;Network=DBMSSOCN")

            'Actualitzem la nostra base de dades
            If li_id_prova.Length > 0 Then

                lstr_id_prova = CStr(li_id_prova(0))

            Else

                lstr_id_prova = "0"

            End If
            'Actualitzem l'identificador de prova en la nostra BBDD
            str_menu = "dbo.SP_CIMACEX_UPDATE_EPIS_NOTIFICADOS_CETIR '" & Session("episcode") & "'," & ls_array(1) & ",'" & ls_prestacion & "'," & lstr_id_prova

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Prestación cambiada con éxito.');" & vbCrLf)
            Response.Write("window.close();" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Me.DropDownList1.SelectedValue = Request("DropDownList1")

    End Sub
End Class
