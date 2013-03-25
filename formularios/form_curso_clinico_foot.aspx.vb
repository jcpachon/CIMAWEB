Public Class form_curso_clinico_foot
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_cima_alertas1 = New cimaweb.ds_cima_alertas
        Me.Ds_cima_alertas2 = New cimaweb.ds_cima_alertas
        Me.Ds_cima_alertas3 = New cimaweb.ds_cima_alertas
        Me.Ds_cima_alertas4 = New cimaweb.ds_cima_alertas
        CType(Me.Ds_cima_alertas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_alertas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_alertas3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_alertas4, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_ALERTAS_PERS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tipo_alerta", "tipo_alerta"), New System.Data.Common.DataColumnMapping("alerta", "alerta")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_ALERTAS_PERS]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers_key", System.Data.SqlDbType.Int, 4))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipo_alerta", System.Data.SqlDbType.VarChar, 1))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist sec" & _
        "urity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_cima_alertas1
        '
        Me.Ds_cima_alertas1.DataSetName = "ds_cima_alertas"
        Me.Ds_cima_alertas1.EnforceConstraints = False
        Me.Ds_cima_alertas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_alertas2
        '
        Me.Ds_cima_alertas2.DataSetName = "ds_cima_alertas"
        Me.Ds_cima_alertas2.EnforceConstraints = False
        Me.Ds_cima_alertas2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_alertas3
        '
        Me.Ds_cima_alertas3.DataSetName = "ds_cima_alertas"
        Me.Ds_cima_alertas3.EnforceConstraints = False
        Me.Ds_cima_alertas3.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_cima_alertas4
        '
        Me.Ds_cima_alertas4.DataSetName = "ds_cima_alertas"
        Me.Ds_cima_alertas4.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_cima_alertas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_alertas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_alertas3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_alertas4, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_cima_alertas1 As cimaweb.ds_cima_alertas
    Protected WithEvents Ds_cima_alertas2 As cimaweb.ds_cima_alertas
    Protected WithEvents Ds_cima_alertas3 As cimaweb.ds_cima_alertas
    Protected WithEvents control As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Textbox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Ds_cima_alertas4 As cimaweb.ds_cima_alertas

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

        If IsPostBack = False Then
            Me.control.Text = Session("pers_key")
        End If

        actualizar()

    End Sub

    Public Sub actualizar()

        Dim n As Integer

        Me.Ds_cima_alertas1.Clear()
        Me.Ds_cima_alertas2.Clear()
        Me.Ds_cima_alertas3.Clear()
        Me.Ds_cima_alertas4.Clear()

        Me.SqlConnection1.Open()

        For n = 1 To 4

            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("pers_key")
            Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = n

            Select Case n
                Case 1
                    Me.SqlDataAdapter1.Fill(Me.Ds_cima_alertas1.cima_alertas)
                Case 2
                    Me.SqlDataAdapter1.Fill(Me.Ds_cima_alertas2.cima_alertas)
                Case 3
                    Me.SqlDataAdapter1.Fill(Me.Ds_cima_alertas3.cima_alertas)
                Case 4
                    Me.SqlDataAdapter1.Fill(Me.Ds_cima_alertas4.cima_alertas)
            End Select

        Next

        Me.SqlConnection1.Close()

        If Me.Ds_cima_alertas1.cima_alertas.Rows.Count = 1 Then
            Me.TextBox1.DataBind()
        End If

        If Me.Ds_cima_alertas2.cima_alertas.Rows.Count = 1 Then
            Me.TextBox2.DataBind()
        End If

        If Me.Ds_cima_alertas3.cima_alertas.Rows.Count = 1 Then
            Me.TextBox3.DataBind()
        End If

        If Me.Ds_cima_alertas4.cima_alertas.Rows.Count = 1 Then
            Me.Textbox4.DataBind()
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim str_sql As String

        If Me.control.Text = Session("pers_key") Then

            If IsNumeric(Session("pers_key")) = True Then

                str_sql = "dbo.SP_CIMACEX_ALTA_ALERTAS_PERS " & Session("pers_key") & ",'" & Trim(Request("TextBox1")) & "','" & Trim(Request("TextBox2")) & "','" & Trim(Request("TextBox3")) & "','" & Trim(Request("TextBox4")) & "'"

                objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""JUPITER"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

            End If

        Else

            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('Lo sentimos. Se ha detectado un problema en la aplicación. Esta ventana será cerrada y no se salvará ningún cambio.');" & vbCrLf)
            Response.Write("top.window.close();" & vbCrLf)
            Response.Write("</scr" & "ipt>")

        End If

        actualizar()

    End Sub
End Class
