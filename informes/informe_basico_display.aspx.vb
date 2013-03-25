Public Class informe_basico_display
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_informes_master1 = New cimaweb.ds_informes_master
        Me.Ds_pacientes1 = New cimaweb.ds_pacientes
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        CType(Me.Ds_informes_master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_informes_master", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cabecera", "cabecera"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion"), New System.Data.Common.DataColumnMapping("episodio", "episodio")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cabecera, id_usuario, fecha_creacion, episodio FROM cima_informes_master W" & _
        "HERE (id_informe = @id_informe)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_informe", System.Data.SqlDbType.Int, 4, "id_informe"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'Ds_informes_master1
        '
        Me.Ds_informes_master1.DataSetName = "ds_informes_master"
        Me.Ds_informes_master1.EnforceConstraints = False
        Me.Ds_informes_master1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_pacientes1
        '
        Me.Ds_pacientes1.DataSetName = "ds_pacientes"
        Me.Ds_pacientes1.EnforceConstraints = False
        Me.Ds_pacientes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_PACIENTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("persfullname", "persfullname")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "{? = CALL [SP_CIMACEX_RECUPERA_PACIENTE]( ? )}"
        Me.OdbcSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("@episcode", System.Data.Odbc.OdbcType.VarChar, 50))
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        CType(Me.Ds_informes_master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_informes_master1 As cimaweb.ds_informes_master
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Ds_pacientes1 As cimaweb.ds_pacientes
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection

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

            Dim str_menu As String

            Dim objCIMA As New CIMA_Clases.CIMA

            Session("id_informe") = Request("id_informe")

            If Request("cerrar") = "S" Then

                Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

                str_menu = "dbo.SP_CIMACEX_CERRAR_INFORME '" & Session("id_informe") & "'"

                objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                objCIMA = Nothing

            End If

        End If

        Me.SqlConnection1.Open()

        Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = CInt(Session("id_informe"))

        Me.SqlDataAdapter1.Fill(Me.Ds_informes_master1.cima_informes_master)

        Me.Label1.DataBind()
        Me.Label2.DataBind()
        Me.Label3.DataBind()
        Me.Label4.DataBind()

        ' Recuperación del paciente por episodio.

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = Me.Ds_informes_master1.cima_informes_master.Rows(0).Item(3)
        Me.OdbcDataAdapter1.Fill(Me.Ds_pacientes1.pacientes)

        Me.Label5.Text = Me.Ds_pacientes1.pacientes.Rows(0).Item(1)

        Me.OdbcConnection1.Close()

        ' Fin.

        Me.SqlConnection1.Close()

    End Sub

End Class
