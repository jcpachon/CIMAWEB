Public Class form_medico_prescriptor
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_csta1 = New cimaweb.ds_csta
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_datos_captura_cstahper1 = New cimaweb.ds_datos_captura_cstahper
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_datos_captura_cstahper1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_csta1
        '
        Me.Ds_csta1.DataSetName = "ds_csta"
        Me.Ds_csta1.EnforceConstraints = False
        Me.Ds_csta1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "csta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("csta_key", "csta_key"), New System.Data.Common.DataColumnMapping("cstadesclong", "cstadesclong")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT csta_key, cstadesclong FROM csta WHERE (cent_key = 1) AND (cstaacti = 'Y') UNION ALL SELECT 0, '-- DESCONOCIDO --'" & _
        " ORDER BY cstadesclong"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_datos_captura_cstahper1
        '
        Me.Ds_datos_captura_cstahper1.DataSetName = "ds_datos_captura_cstahper"
        Me.Ds_datos_captura_cstahper1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cstahper", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cstahper_key", "cstahper_key"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cstahper.cstahper_key, pers.perssur1, pers.perssur2, pers.persname, pers.p" & _
        "ersfullname FROM cstahper INNER JOIN pers ON cstahper.pers_key = pers.pers_key A" & _
        "ND pers.persacti = 'Y' INNER JOIN hper ON cstahper.pers_key = hper.pers_key INNE" & _
        "R JOIN hperclas ON hper.hperclascode = hperclas.hperclascode WHERE (cstahper.cst" & _
        "a_key = @csta_key) AND (cstahper.cstahperdate_end IS NULL) AND (hperclas.hpergro" & _
        "ucode IN ('C', 'F')) UNION ALL SELECT 0, '-- DESCONOCIDO --','-- DESCONOCIDO --','-- DESCONOCIDO --','-- DESCONOCIDO --' WHERE @csta_key = 0 ORDER BY pers.perssur1"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@csta_key", System.Data.SqlDbType.Int, 4, "csta_key"))
        CType(Me.Ds_csta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_datos_captura_cstahper1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Ds_csta1 As cimaweb.ds_csta
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_datos_captura_cstahper1 As cimaweb.ds_datos_captura_cstahper
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents DropDownList3 As Anthem.DropDownList
    Protected WithEvents DropDownList2 As Anthem.DropDownList

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

        If IsPostBack Then

            Me.DropDownList2.SelectedValue = Request("DropDownList2")

        Else

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_csta1.csta)
            Me.SqlConnection1.Close()

            Me.DropDownList2.DataBind()

            Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.DropDownList2.SelectedValue

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter2.Fill(Me.Ds_datos_captura_cstahper1.cstahper)
            Me.SqlConnection1.Close()

            Me.DropDownList3.DataBind()

        End If
        
    End Sub

End Class
