Public Class form_mantenimiento_incidencias
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_incidencias1 = New cimaweb.ds_incidencias
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_incidencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_incidencias1
        '
        Me.Ds_incidencias1.DataSetName = "ds_incidencias"
        Me.Ds_incidencias1.Locale = New System.Globalization.CultureInfo("es")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlCommand2
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "INSERT INTO cima_incidencias (codigo_inc, descripcion_inc, tactcode, activo) VALU" & _
        "ES (@codigo_inc, @descripcion_inc, @tactcode, @activo)"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codigo_inc", System.Data.SqlDbType.VarChar, 6, "codigo_inc"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion_inc", System.Data.SqlDbType.VarChar, 60, "descripcion_inc"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tactcode", System.Data.SqlDbType.VarChar, 2, "tactcode"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.VarChar, 1, "activo"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_INCIDENCIAS]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_incidencia", System.Data.SqlDbType.Int, 4))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "UPDATE cima_incidencias SET codigo_inc = @codigo_inc, descripcion_inc = @descripc" & _
        "ion_inc, tactcode = @tactcode, activo = @activo WHERE (id_incidencia = @id_incid" & _
        "encia)"
        Me.SqlCommand2.Connection = Me.SqlConnection1
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_incidencia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_incidencia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codigo_inc", System.Data.SqlDbType.VarChar, 6, "codigo_inc"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion_inc", System.Data.SqlDbType.VarChar, 60, "descripcion_inc"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tactcode", System.Data.SqlDbType.VarChar, 2, "tactcode"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activo", System.Data.SqlDbType.VarChar, 1, "activo"))
        CType(Me.Ds_incidencias1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_incidencias1 As cimaweb.ds_incidencias
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents DataList1 As System.Web.UI.WebControls.DataList
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim ib_control As Boolean

    Public Function CheckBoxEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "S" Then
            returnValue = "True"
        Else
            returnValue = "False"
        End If

        Return returnValue

    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

    End Sub
    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 0
        Me.SqlDataAdapter1.Fill(Me.Ds_incidencias1.incidencias)
        Me.Dropdownlist1.DataBind()
        Me.SqlConnection1.Close()

        Me.Dropdownlist1.Items.Insert(0, "")

        If ib_control = False Then

            Me.Dropdownlist1.SelectedValue = Request("DropDownList1")
            Me.Ds_incidencias1.Clear()

            If Len(Trim(Request("DropDownList1"))) > 0 Then
                Me.SqlConnection1.Open()
                Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Me.Dropdownlist1.SelectedValue
                Me.SqlDataAdapter1.Fill(Me.Ds_incidencias1.incidencias)
                Me.DataList1.DataBind()
                Me.SqlConnection1.Close()

                CType(DataList1.Items(0).FindControl("tactcode"), DropDownList).SelectedValue = Me.Ds_incidencias1.incidencias.Rows(0).Item("tactcode")

                Me.Button1.Visible = True
                Me.Button2.Visible = True
                Me.DataList1.Visible = True

            Else
                Me.Button1.Visible = False
                Me.Button2.Visible = False
                Me.DataList1.Visible = False
            End If
        Else
            Me.Dropdownlist1.SelectedValue = ""

            Me.DataList1.Visible = True
            Me.Button1.Visible = True
            Me.Button2.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        CType(DataList1.Items(0).FindControl("id_incidencia"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("tactcode"), DropDownList).SelectedValue = "RX"
        CType(DataList1.Items(0).FindControl("codigo_inc"), TextBox).Text = ""
        CType(DataList1.Items(0).FindControl("descripcion_inc"), TextBox).Text = ""

        ib_control = True

        Me.Dropdownlist1.Enabled = False
        Me.Button1.Enabled = False


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Control por botón de Nuevo.
        If Me.Button1.Enabled = True Then

            Me.DataList1.Visible = True
            Me.SqlConnection1.Open()

            Me.SqlDataAdapter1.UpdateCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("id_incidencia"), TextBox).Text
            Me.SqlDataAdapter1.UpdateCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("codigo_inc"), TextBox).Text
            Me.SqlDataAdapter1.UpdateCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("descripcion_inc"), TextBox).Text
            Me.SqlDataAdapter1.UpdateCommand.Parameters(3).Value = CType(DataList1.Items(0).FindControl("tactcode"), DropDownList).SelectedValue
            Me.SqlDataAdapter1.UpdateCommand.Parameters(4).Value = IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")

            Me.SqlDataAdapter1.UpdateCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        Else

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter1.InsertCommand.Parameters(0).Value = CType(DataList1.Items(0).FindControl("codigo_inc"), TextBox).Text
            Me.SqlDataAdapter1.InsertCommand.Parameters(1).Value = CType(DataList1.Items(0).FindControl("descripcion_inc"), TextBox).Text
            Me.SqlDataAdapter1.InsertCommand.Parameters(2).Value = CType(DataList1.Items(0).FindControl("tactcode"), DropDownList).SelectedValue
            Me.SqlDataAdapter1.InsertCommand.Parameters(3).Value = IIf(CType(DataList1.Items(0).FindControl("activo"), CheckBox).Checked, "S", "N")

            Me.SqlDataAdapter1.InsertCommand.ExecuteNonQuery()

            Me.SqlConnection1.Close()

        End If

        ib_control = False

        Me.Button1.Enabled = True
        Me.Dropdownlist1.Enabled = True


        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("alert('Incidencia guardada con éxito.');" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub



End Class
