Public Class form_listado_cex
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_agen_tabla1 = New cimaweb.ds_agen_tabla
        Me.Ds_reso1 = New cimaweb.ds_reso
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_listado_cex1 = New cimaweb.ds_listado_cex
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_reso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_listado_cex1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "csta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT * FROM reso WHERE (tablcode = 'csta') ORDER BY resodesc"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_agen_tabla1
        '
        Me.Ds_agen_tabla1.DataSetName = "ds_agen_tabla"
        Me.Ds_agen_tabla1.EnforceConstraints = False
        Me.Ds_agen_tabla1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_reso1
        '
        Me.Ds_reso1.DataSetName = "ds_reso"
        Me.Ds_reso1.EnforceConstraints = False
        Me.Ds_reso1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "agen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("agencode", "agencode"), New System.Data.Common.DataColumnMapping("agenname", "agenname")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT agen.agencode, agen.agenname FROM agen INNER JOIN resoagen ON age" & _
        "n.agencode = resoagen.agencode INNER JOIN CIMACEX.dbo.cima_usuarios_agen ON CIMA" & _
        "CEX.dbo.cima_usuarios_agen.agencode = agen.agencode AND CIMACEX.dbo.cima_usuario" & _
        "s_agen.id_usuario = @id_usuario WHERE (agen.agenacti = 'Y') AND (agen.cent_key =" & _
        " 1) AND (resoagen.tablcode = 'csta') AND (resoagen.reso_key = @reso_key) ORDER B" & _
        "Y agen.agenname"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reso_key", System.Data.SqlDbType.Int, 4, "reso_key"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        '
        'Ds_listado_cex1
        '
        Me.Ds_listado_cex1.DataSetName = "ds_listado_cex"
        Me.Ds_listado_cex1.EnforceConstraints = False
        Me.Ds_listado_cex1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_LISTADO_CEX", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("pati_hfn", "pati_hfn"), New System.Data.Common.DataColumnMapping("hora_cita", "hora_cita"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("fecha_nacimiento", "fecha_nacimiento"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("agenprocdesc", "agenprocdesc"), New System.Data.Common.DataColumnMapping("appostatdesc", "appostatdesc"), New System.Data.Common.DataColumnMapping("apporenddesc", "apporenddesc"), New System.Data.Common.DataColumnMapping("agenprocdesc1", "agenprocdesc1"), New System.Data.Common.DataColumnMapping("bookhend", "bookhend"), New System.Data.Common.DataColumnMapping("appostatcode", "appostatcode"), New System.Data.Common.DataColumnMapping("appoharr", "appoharr")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("pati_hfn", "pati_hfn"), New System.Data.Common.DataColumnMapping("hora_cita", "hora_cita"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("fecha_nacimiento", "fecha_nacimiento"), New System.Data.Common.DataColumnMapping("agenname", "agenname"), New System.Data.Common.DataColumnMapping("agenprocdesc", "agenprocdesc"), New System.Data.Common.DataColumnMapping("appostatdesc", "appostatdesc"), New System.Data.Common.DataColumnMapping("apporenddesc", "apporenddesc"), New System.Data.Common.DataColumnMapping("agenprocdesc1", "agenprocdesc1"), New System.Data.Common.DataColumnMapping("bookhend", "bookhend"), New System.Data.Common.DataColumnMapping("appostatcode", "appostatcode"), New System.Data.Common.DataColumnMapping("appoharr", "appoharr")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "[SP_CIMACEX_LISTADO_CEX]"
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agencode", System.Data.SqlDbType.VarChar, 6))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reso_key", System.Data.SqlDbType.Int, 4))
        CType(Me.Ds_agen_tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_reso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_listado_cex1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_agen_tabla1 As cimaweb.ds_agen_tabla
    Protected WithEvents Ds_reso1 As cimaweb.ds_reso
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_listado_cex1 As cimaweb.ds_listado_cex
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand

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

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_reso1.reso)
        Me.SqlConnection1.Close()

        Me.DropDownList1.DataBind()

        Me.DropDownList1.Items.Insert(0, "")

        If Len(Request("DropDownList1")) > 0 Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

        End If

    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

        Dim str_uid As String

        str_uid = Request.Cookies("usuario").Value

        Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList1.SelectedValue
        Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = str_uid

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_agen_tabla1.agen)
        Me.SqlConnection1.Close()

        Me.Dropdownlist2.DataBind()

        Me.Dropdownlist2.Items.Insert(0, "")

        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.DropDownList1.SelectedValue = "" Or IsDate(CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text) = False Or IsDate(CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text) = False Then



        Else

            Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = CType(Me.FindControl("uo_fechas1").FindControl("fecha_ini"), TextBox).Text
            Me.SqlDataAdapter3.SelectCommand.Parameters(2).Value = CType(Me.FindControl("uo_fechas1").FindControl("fecha_fin"), TextBox).Text
            Me.SqlDataAdapter3.SelectCommand.Parameters(3).Value = Me.Dropdownlist2.SelectedValue
            Me.SqlDataAdapter3.SelectCommand.Parameters(4).Value = Me.DropDownList1.SelectedValue

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_listado_cex1.SP_CIMACEX_LISTADO_CEX)
            Me.SqlConnection1.Close()

        End If

    End Sub

End Class
