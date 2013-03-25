Public Class form_diagnosticos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_diagnosticos1 = New cimaweb.ds_diagnosticos
        Me.Ds_cie91 = New cimaweb.ds_cie9
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        CType(Me.Ds_diagnosticos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cie91, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ANTECEDENTES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("anep_key", "anep_key"), New System.Data.Common.DataColumnMapping("anepcode", "anepcode"), New System.Data.Common.DataColumnMapping("anepdesc", "anepdesc"), New System.Data.Common.DataColumnMapping("anepdateacti", "anepdateacti"), New System.Data.Common.DataColumnMapping("tantdesc", "tantdesc")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "{? = CALL [SP_CIMACEX_DIAGNOSTICOS]( ? )}"
        Me.OdbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@pers_key", System.Data.Odbc.OdbcType.Int, 4))
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_diagnosticos1
        '
        Me.Ds_diagnosticos1.DataSetName = "ds_diagnosticos"
        Me.Ds_diagnosticos1.EnforceConstraints = False
        Me.Ds_diagnosticos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cie91
        '
        Me.Ds_cie91.DataSetName = "ds_cie9"
        Me.Ds_cie91.EnforceConstraints = False
        Me.Ds_cie91.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cie9", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cie9_key", "cie9_key"), New System.Data.Common.DataColumnMapping("caco_key", "caco_key"), New System.Data.Common.DataColumnMapping("vcodvers", "vcodvers"), New System.Data.Common.DataColumnMapping("cie9code", "cie9code"), New System.Data.Common.DataColumnMapping("cie9desc", "cie9desc"), New System.Data.Common.DataColumnMapping("cie9type", "cie9type"), New System.Data.Common.DataColumnMapping("cie9vers", "cie9vers"), New System.Data.Common.DataColumnMapping("cie9upda", "cie9upda"), New System.Data.Common.DataColumnMapping("cie9numetimsrequ", "cie9numetimsrequ"), New System.Data.Common.DataColumnMapping("cie9numetimsepis", "cie9numetimsepis"), New System.Data.Common.DataColumnMapping("cie9main", "cie9main"), New System.Data.Common.DataColumnMapping("cie9epid", "cie9epid")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cie9_key, caco_key, vcodvers, cie9code, cie9desc, cie9type, cie9vers, cie9" & _
        "upda, cie9numetimsrequ, cie9numetimsepis, cie9main, cie9epid FROM cie9 WHERE (ci" & _
        "e9type = 'D') AND (cie9upda = 'Y') ORDER BY cie9desc"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        CType(Me.Ds_diagnosticos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cie91, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_diagnosticos1 As cimaweb.ds_diagnosticos
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents Button4 As System.Web.UI.WebControls.Button
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Ds_cie91 As cimaweb.ds_cie9
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

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = CInt(Session("pers_key"))
        Me.OdbcDataAdapter1.Fill(Me.Ds_diagnosticos1.diagnosticos)

        Me.DataGrid1.DataBind()

        Me.OdbcConnection1.Close()

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.Fill(Me.Ds_cie91.cie9)

        Me.SqlConnection1.Close()

        Me.DropDownList1.DataBind()

        If Len(Trim(Request("DropDownList1"))) > 0 Then

            Me.DropDownList1.SelectedValue = Request("DropDownList1")

        End If

        If Len(Trim(Request("episcode"))) > 0 Then

            Session("episcode") = Request("episcode")

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("window.close();" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("window.close();" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        'If Me.control.Text = Session("pers_key") Then

        'Dim str_sql As String
        Dim str_uid As String
        'Dim str_sesion_id As String



        str_uid = Request.Cookies("usuario").Value

        If Len(Trim(Me.DropDownList1.SelectedValue)) > 0 And Len(Trim(Session("episcode"))) > 0 Then

            str_sql = "dbo.SP_CIMACEX_ALTA_DIAGNOSTICO '" & Session("episcode") & "'," & Me.DropDownList1.SelectedValue & ",'4','" & str_uid & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Diagnóstico registrado con éxito.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Diagnóstico NO registrado con éxito. Por favor, compruebe los campos de registro.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        Me.OdbcConnection1.Open()

        Me.Ds_diagnosticos1.Clear()

        Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = CInt(Session("pers_key"))
        Me.OdbcDataAdapter1.Fill(Me.Ds_diagnosticos1.diagnosticos)

        Me.DataGrid1.DataBind()

        Me.OdbcConnection1.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String


        If Me.DataGrid1.SelectedIndex >= 0 Then

            str_sql = "dbo.SP_CIMACEX_BAJA_DIAGNOSTICO '" & Me.DataGrid1.SelectedItem.Cells(1).Text & "','" & Me.DataGrid1.SelectedItem.Cells(2).Text + "','" + Me.DataGrid1.SelectedItem.Cells(4).Text & "'"

            objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CSaludR;password=kampeon10")

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Diagnóstico dado de baja con éxito.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Diagnóstico NO dado de baja con éxito. Por favor, compruebe que ha seleccionado uno.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        Me.OdbcConnection1.Open()

        Me.Ds_diagnosticos1.Clear()

        Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = CInt(Session("pers_key"))
        Me.OdbcDataAdapter1.Fill(Me.Ds_diagnosticos1.diagnosticos)

        Me.DataGrid1.DataBind()

        Me.OdbcConnection1.Close()


    End Sub
End Class
