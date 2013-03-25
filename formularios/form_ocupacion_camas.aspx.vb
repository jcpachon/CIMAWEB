Public Class form_ocupacion_camas
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_plantas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_query = New System.Data.SqlClient.SqlDataAdapter
        Me.Adapter_Historico = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_plantas2 = New cimaweb.ds_plantas
        Me.Ds_recuperar_camas1 = New cimaweb.ds_recuperar_camas
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Desplegable_camas = New System.Data.SqlClient.SqlDataAdapter
        Me.Ds_elije_cama1 = New cimaweb.ds_elije_cama
        Me.Ds_historico_camas1 = New cimaweb.ds_historico_camas
        CType(Me.Ds_plantas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_recuperar_camas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_elije_cama1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_historico_camas1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT spdi_key, spdidesclong FROM spdi WHERE (spdi_key IN (3, 4, 5, 6, 8))"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Adapter_plantas
        '
        Me.Adapter_plantas.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_plantas.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_plantas.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_plantas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_RECUPERA_CAMAS]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spdi_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@todas", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@acomp", System.Data.SqlDbType.Int, 4))
        '
        'Adapter_query
        '
        Me.Adapter_query.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_query.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_query.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_query.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Adapter_Historico
        '
        Me.Adapter_Historico.SelectCommand = Me.SqlSelectCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "[SP_CIMACEX_HISTORICO_CAMAS]"
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@beds_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.NVarChar, 10))
        '
        'Ds_plantas2
        '
        Me.Ds_plantas2.DataSetName = "ds_plantas"
        Me.Ds_plantas2.EnforceConstraints = False
        Me.Ds_plantas2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_recuperar_camas1
        '
        Me.Ds_recuperar_camas1.DataSetName = "ds_recuperar_camas"
        Me.Ds_recuperar_camas1.EnforceConstraints = False
        Me.Ds_recuperar_camas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[SP_CIMACEX_ELEJIR_CAMAS]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spdi_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@todas", System.Data.SqlDbType.Int, 4))
        '
        'Adapter_Desplegable_camas
        '
        Me.Adapter_Desplegable_camas.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adapter_Desplegable_camas.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Desplegable_camas.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Desplegable_camas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'Ds_elije_cama1
        '
        Me.Ds_elije_cama1.DataSetName = "ds_elije_cama"
        Me.Ds_elije_cama1.EnforceConstraints = False
        Me.Ds_elije_cama1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_historico_camas1
        '
        Me.Ds_historico_camas1.DataSetName = "ds_historico_camas"
        Me.Ds_historico_camas1.EnforceConstraints = False
        Me.Ds_historico_camas1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_plantas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_recuperar_camas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_elije_cama1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_historico_camas1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Dropdown_plantas As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Adapter_plantas As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Adapter_query As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents RadioButton1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Radiobutton2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents a As System.Web.UI.WebControls.Label
    Protected WithEvents b As System.Web.UI.WebControls.Label
    Protected WithEvents Adapter_Historico As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Public WithEvents Ds_plantas2 As cimaweb.ds_plantas
    Public WithEvents Ds_recuperar_camas1 As cimaweb.ds_recuperar_camas
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Adapter_Desplegable_camas As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Public WithEvents Ds_elije_cama1 As cimaweb.ds_elije_cama
    Public WithEvents Ds_historico_camas1 As cimaweb.ds_historico_camas
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox

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

        'Llenamos el dropdown list de las plantas
        data_load()
    End Sub

    Private Sub data_load()
        Me.Ds_plantas2.Clear()
        Me.Dropdown_plantas.Items.Clear()

        Me.SqlConnection2.Open()
        Me.Adapter_plantas.Fill(Me.Ds_plantas2.spdi)
        Me.SqlConnection2.Close()

        Me.Dropdown_plantas.DataBind()

        Me.Dropdown_plantas().Items.Insert(0, "- TODOS -")

        Me.Dropdown_plantas.SelectedValue = Request("Dropdown_plantas")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pp As String          'Variable para hacer el SPLIT
        Dim matriz() As String    'Matriz para hacer el SPLIT
        Dim concat As String      'Variable para concatenar los diferentes datos de la matriz 

        Me.Ds_recuperar_camas1.Clear()
        Me.Ds_historico_camas1.Clear()
        If Me.RadioButton1.Checked = True Then
            If Me.Dropdown_plantas.SelectedIndex > 0 Then
                Me.Label3.Visible = True
                Me.Label4.Visible = True
                Me.a.Visible = True
                Me.b.Visible = True
                Me.Adapter_query.SelectCommand.Parameters(1).Value = Me.Dropdown_plantas.SelectedValue
                Me.Adapter_query.SelectCommand.Parameters(2).Value = 0
                If Me.CheckBox1.Checked = True Then
                    Me.Adapter_query.SelectCommand.Parameters(3).Value = 1
                Else
                    Me.Adapter_query.SelectCommand.Parameters(3).Value = 0
                End If


                Me.SqlConnection2.Open()
                Me.Adapter_query.Fill(Me.Ds_recuperar_camas1.SP_CIMACEX_RECUPERA_CAMAS)
                Me.SqlConnection2.Close()
            Else
                Me.Label3.Visible = True
                Me.Label4.Visible = True
                Me.a.Visible = True
                Me.b.Visible = True
                Me.Adapter_query.SelectCommand.Parameters(1).Value = 0
                Me.Adapter_query.SelectCommand.Parameters(2).Value = 1
                If Me.CheckBox1.Checked = True Then
                    Me.Adapter_query.SelectCommand.Parameters(3).Value = 1
                Else
                    Me.Adapter_query.SelectCommand.Parameters(3).Value = 0
                End If

                Me.SqlConnection2.Open()
                Me.Adapter_query.Fill(Me.Ds_recuperar_camas1.SP_CIMACEX_RECUPERA_CAMAS)
                Me.SqlConnection2.Close()
            End If
        ElseIf Me.Radiobutton2.Checked = True Then
            Try
                'CAMBIAR DE FORMATO A LA FECHA
                pp = CType(Me.FindControl("uo_fecha1").FindControl("fecha_ini"), TextBox).Text()    'Pasamos la fecha a la variable 
                matriz = Split(pp, "/")
                concat = matriz(2) & "-" & matriz(1) & "-" & matriz(0)
                'TERMINA LA CONVERSION DE FORMATO

                Me.Adapter_Historico.SelectCommand.Parameters(1).Value = Me.DropDownList2.SelectedValue
                Me.Adapter_Historico.SelectCommand.Parameters(2).Value = concat

                Me.SqlConnection2.Open()
                Me.Adapter_Historico.Fill(Me.Ds_historico_camas1.SP_CIMACEX_HISTORICO_CAMAS)
                Me.SqlConnection2.Close()
            Catch ex As Exception
                Response.Write("<script type=""text/javascript"">alert(""Seleccione CAMA y FECHA"")</script>")
            End Try
        Else
                Response.Write("<script type=""text/javascript"">alert(""Debe seleccionar una opción"")</script>")
        End If
    End Sub

    Private Sub Radiobutton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Radiobutton2.CheckedChanged
        Me.FindControl("uo_fecha1").Visible = True
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.a.Visible = False
        Me.b.Visible = False
        Me.Label2.Enabled = True
        Me.DropDownList2.Enabled = True
        Me.CheckBox1.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.FindControl("uo_fecha1").Visible = False
        Me.Label2.Enabled = False
        Me.DropDownList2.Enabled = False
        Me.CheckBox1.Enabled = True
    End Sub

    Private Sub Dropdown_plantas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dropdown_plantas.SelectedIndexChanged
        If Me.Dropdown_plantas.SelectedIndex > 0 Then
            Me.Adapter_Desplegable_camas.SelectCommand.Parameters(1).Value = Me.Dropdown_plantas.SelectedValue
            Me.Adapter_Desplegable_camas.SelectCommand.Parameters(2).Value = 0

            Me.SqlConnection2.Open()
            Me.Adapter_Desplegable_camas.Fill(Me.Ds_elije_cama1.SP_CIMACEX_ELEJIR_CAMAS)
            Me.SqlConnection2.Close()

            Me.DropDownList2.DataBind()
        Else
            Me.Adapter_Desplegable_camas.SelectCommand.Parameters(1).Value = 0
            Me.Adapter_Desplegable_camas.SelectCommand.Parameters(2).Value = 1

            Me.SqlConnection2.Open()
            Me.Adapter_Desplegable_camas.Fill(Me.Ds_elije_cama1.SP_CIMACEX_ELEJIR_CAMAS)
            Me.SqlConnection2.Close()

            Me.DropDownList2.DataBind()
        End If
    End Sub
End Class
