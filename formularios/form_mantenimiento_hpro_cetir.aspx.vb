Public Class form_mantenimiento_hpro_cetir
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_hpro1 = New cimaweb.ds_hpro
        Me.Ds_cima_prestaciones_cetir1 = New cimaweb.ds_cima_prestaciones_cetir
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Ds_hpro_cetir1 = New cimaweb.ds_hpro_cetir
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_prestaciones_cetir1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_hpro_cetir1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_hpro1
        '
        Me.Ds_hpro1.DataSetName = "ds_hpro"
        Me.Ds_hpro1.EnforceConstraints = False
        Me.Ds_hpro1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_prestaciones_cetir1
        '
        Me.Ds_cima_prestaciones_cetir1.DataSetName = "ds_cima_prestaciones_cetir"
        Me.Ds_cima_prestaciones_cetir1.EnforceConstraints = False
        Me.Ds_cima_prestaciones_cetir1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hpro", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("hprodesclong", "hprodesclong")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT hpro_key, hprocode + ' - ' + hprodesclong AS hprodesclong FROM hpro WHERE " & _
        "(hproacti = 'Y') AND (hprotypecode = 'RX') ORDER BY hprodesclong"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist sec" & _
        "urity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_prestaciones_cetir", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Prova", "ID_Prova"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Prova, ID_Prova + ' - ' + descripcion AS descripcion FROM cima_prestaci" & _
        "ones_cetir ORDER BY descripcion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_hpro_cetir1
        '
        Me.Ds_hpro_cetir1.DataSetName = "ds_hpro_cetir"
        Me.Ds_hpro_cetir1.EnforceConstraints = False
        Me.Ds_hpro_cetir1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_hpro_cetir", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_hpro_cetir", "id_hpro_cetir"), New System.Data.Common.DataColumnMapping("hpro_key", "hpro_key"), New System.Data.Common.DataColumnMapping("IP_Prova", "IP_Prova")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cima_hpro_cetir.id_hpro_cetir, cima_hpro_cetir.hpro_key, cima_hpro_cetir.I" & _
        "D_Prova, cima_prestaciones_cetir.ID_Prova + ' - ' + cima_prestaciones_cetir.desc" & _
        "ripcion AS descripcion, CSaludR.dbo.hpro.hprocode + ' - ' + CSaludR.dbo.hpro.hpr" & _
        "odesclong AS hprodesclong FROM cima_hpro_cetir INNER JOIN cima_prestaciones_ceti" & _
        "r ON cima_hpro_cetir.ID_Prova = cima_prestaciones_cetir.ID_Prova INNER JOIN CSal" & _
        "udR.dbo.hpro ON cima_hpro_cetir.hpro_key = CSaludR.dbo.hpro.hpro_key ORDER BY ci" & _
        "ma_hpro_cetir.id_hpro_cetir"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_BAJA_HPRO_CETIR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[SP_CIMACEX_BAJA_HPRO_CETIR]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_hpro_cetir", System.Data.SqlDbType.Int, 4))
        CType(Me.Ds_hpro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_prestaciones_cetir1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_hpro_cetir1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Dropdownlist2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Dropdownlist3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_hpro1 As cimaweb.ds_hpro
    Protected WithEvents Ds_cima_prestaciones_cetir1 As cimaweb.ds_cima_prestaciones_cetir
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_hpro_cetir1 As cimaweb.ds_hpro_cetir
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand

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



        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_hpro1.hpro)
        Me.SqlConnection1.Close()

        Me.Dropdownlist2.DataBind()

        If Len(Trim(Request("Dropdownlist2"))) > 0 Then
            Me.Dropdownlist2.SelectedValue = Request("Dropdownlist2")
        End If

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_cima_prestaciones_cetir1.cima_prestaciones_cetir)
        Me.SqlConnection2.Close()

        Me.Dropdownlist3.DataBind()

        If Len(Trim(Request("Dropdownlist3"))) > 0 Then
            Me.Dropdownlist3.SelectedValue = Request("Dropdownlist3")
        End If

        If Request("eliminar") = "S" Then

            'If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_BAJA_HPRO_CETIR " & Request("id_hpro_cetir")

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            Me.Ds_hpro1.Clear()

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_hpro1.hpro)
            Me.SqlConnection1.Close()

            Me.Dropdownlist2.DataBind()

            'Me.Dropdownlist2.SelectedIndex = 1

            Me.Ds_hpro_cetir1.Clear()

            Me.SqlConnection2.Open()
            Me.SqlDataAdapter2.Fill(Me.Ds_cima_prestaciones_cetir1.cima_prestaciones_cetir)
            Me.SqlConnection2.Close()

            Me.Dropdownlist3.DataBind()

            'Me.Dropdownlist3.SelectedIndex = 1
            'Me.SqlConnection2.Open()
            'Me.SqlDataAdapter4.SelectCommand.ExecuteNonQuery()
            'Me.SqlConnection2.Close()

        End If

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_hpro_cetir1.cima_hpro_cetir)
        Me.SqlConnection2.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        'If Me.DataGrid1.SelectedIndex >= 0 Then

        str_sql = "dbo.SP_CIMACEX_ALTA_HPRO_CETIR " & Me.Dropdownlist2.SelectedValue & ",'" & Me.Dropdownlist3.SelectedValue & "'"

        objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        Me.Ds_hpro1.Clear()

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.Fill(Me.Ds_hpro1.hpro)
        Me.SqlConnection1.Close()

        Me.Dropdownlist2.DataBind()

        'Me.Dropdownlist2.SelectedIndex = 1

        Me.Ds_hpro_cetir1.Clear()

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter2.Fill(Me.Ds_cima_prestaciones_cetir1.cima_prestaciones_cetir)
        Me.SqlConnection2.Close()

        Me.Dropdownlist3.DataBind()

        Me.SqlConnection2.Open()
        Me.SqlDataAdapter3.Fill(Me.Ds_hpro_cetir1.cima_hpro_cetir)
        Me.SqlConnection2.Close()
        'Else

            'Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una agenda"")</script>")

        'End If

    End Sub

End Class
