Public Class form_busca_pers
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.Ds_busca_pers1 = New cimaweb.ds_busca_pers
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection2 = New System.Data.Odbc.OdbcConnection
        Me.OdbcDataAdapter3 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDataAdapter4 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand4 = New System.Data.Odbc.OdbcCommand
        Me.OdbcSelectCommand5 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDataAdapter5 = New System.Data.Odbc.OdbcDataAdapter
        CType(Me.Ds_busca_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT * FROM pers"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        '
        'Ds_busca_pers1
        '
        Me.Ds_busca_pers1.DataSetName = "ds_busca_pers"
        Me.Ds_busca_pers1.EnforceConstraints = False
        Me.Ds_busca_pers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PACIENTES_DNI", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "{? = CALL [SP_CIMACEX_PACIENTES_DNI]( ? )}"
        Me.OdbcSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection2
        Me.OdbcSelectCommand2.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand2.Parameters.Add(New System.Data.Odbc.OdbcParameter("@dni", System.Data.Odbc.OdbcType.VarChar, 14))
        '
        'OdbcConnection2
        '
        Me.OdbcConnection2.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'OdbcDataAdapter3
        '
        Me.OdbcDataAdapter3.SelectCommand = Me.OdbcSelectCommand3
        Me.OdbcDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PACIENTES_DNI_NOMBRE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2")})})
        '
        'OdbcSelectCommand3
        '
        Me.OdbcSelectCommand3.CommandText = "{? = CALL [SP_CIMACEX_PACIENTES_DNI_NOMBRE]( ?, ? )}"
        Me.OdbcSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand3.Connection = Me.OdbcConnection2
        Me.OdbcSelectCommand3.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand3.Parameters.Add(New System.Data.Odbc.OdbcParameter("@dni", System.Data.Odbc.OdbcType.VarChar, 14))
        Me.OdbcSelectCommand3.Parameters.Add(New System.Data.Odbc.OdbcParameter("@persfullname", System.Data.Odbc.OdbcType.VarChar, 100))
        '
        'OdbcDataAdapter4
        '
        Me.OdbcDataAdapter4.SelectCommand = Me.OdbcSelectCommand4
        Me.OdbcDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_PACIENTES_NOMBRE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2")})})
        '
        'OdbcSelectCommand4
        '
        Me.OdbcSelectCommand4.CommandText = "{? = CALL [SP_CIMACEX_PACIENTES_NOMBRE]( ? )}"
        Me.OdbcSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand4.Connection = Me.OdbcConnection2
        Me.OdbcSelectCommand4.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand4.Parameters.Add(New System.Data.Odbc.OdbcParameter("@persfullname", System.Data.Odbc.OdbcType.VarChar, 100))
        '
        'OdbcSelectCommand5
        '
        Me.OdbcSelectCommand5.CommandText = "{? = CALL [SP_CIMACEX_PACIENTES_NHC]( ? )}"
        Me.OdbcSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure
        Me.OdbcSelectCommand5.Connection = Me.OdbcConnection2
        Me.OdbcSelectCommand5.Parameters.Add(New System.Data.Odbc.OdbcParameter("@RETURN_VALUE", System.Data.Odbc.OdbcType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcSelectCommand5.Parameters.Add(New System.Data.Odbc.OdbcParameter("@nhc", System.Data.Odbc.OdbcType.Int, 4))
        '
        'OdbcDataAdapter5
        '
        Me.OdbcDataAdapter5.SelectCommand = Me.OdbcSelectCommand5
        CType(Me.Ds_busca_pers1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents Ds_busca_pers1 As cimaweb.ds_busca_pers
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents CheckBox1 As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents apnombre As System.Web.UI.WebControls.TextBox
    Protected WithEvents dni As System.Web.UI.WebControls.TextBox
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection2 As System.Data.Odbc.OdbcConnection
    Protected WithEvents OdbcDataAdapter3 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDataAdapter4 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand4 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcSelectCommand5 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDataAdapter5 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents NHC As System.Web.UI.WebControls.TextBox
    Protected WithEvents Regularexpressionvalidator1 As System.Web.UI.WebControls.RegularExpressionValidator

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

            Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("agencode") = Request("agencode")

        Else

            'Me.Button2.Visible = True

        End If

        If Trim(Session("dia_seleccionado")) = "" Or Session("dia_seleccionado") = Nothing Then

            Session("control") = "True"

        Else

            Session("control") = "False"

        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Response.Redirect("form_nuevo_usuario.aspx?estable=1")

    End Sub

    Public Function f_depuracion_dni(ByVal dni As String) As String

        Dim dni_temporal As String

        Dim n As Integer

        dni = Trim(dni)

        dni_temporal = ""

        For n = 0 To Len(dni) - 1
            If dni.Chars(n).IsLetterOrDigit(dni.Chars(n)) = True Then
                dni_temporal = dni_temporal & dni.Chars(n).ToString
            End If
        Next

        f_depuracion_dni = UCase(dni_temporal)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
