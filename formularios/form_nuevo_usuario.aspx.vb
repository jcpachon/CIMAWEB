Public Class form_nuevo_usuario
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_troa1 = New cimaweb.ds_troa
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.Ds_idenpers1 = New cimaweb.ds_idenpers
        Me.OdbcDataAdapter3 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand3 = New System.Data.Odbc.OdbcCommand
        Me.Ds_tsex1 = New cimaweb.ds_tsex
        Me.OdbcDataAdapter4 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand4 = New System.Data.Odbc.OdbcCommand
        Me.Ds_siaf1 = New cimaweb.ds_siaf
        Me.OdbcSelectCommand5 = New System.Data.Odbc.OdbcCommand
        Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcUpdateCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDeleteCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDataAdapter5 = New System.Data.Odbc.OdbcDataAdapter
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Ds_terr1 = New cimaweb.ds_terr
        Me.Ds_terr2 = New cimaweb.ds_terr
        Me.Ds_terr3 = New cimaweb.ds_terr
        Me.Ds_ver_datos1 = New cimaweb.ds_ver_datos
        Me.AdapterModificarUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_troa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_idenpers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_tsex1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_siaf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_terr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_terr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_terr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_ver_datos1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "troa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("troacode", "troacode"), New System.Data.Common.DataColumnMapping("troaname", "troaname")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT troacode, troaname FROM troa WHERE (troaacti = 'Y') ORDER BY troaorde"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_troa1
        '
        Me.Ds_troa1.DataSetName = "ds_troa"
        Me.Ds_troa1.EnforceConstraints = False
        Me.Ds_troa1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "idenpers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idenperscode", "idenperscode"), New System.Data.Common.DataColumnMapping("idenpersdesc", "idenpersdesc")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT idenperscode, idenpersdesc FROM idenpers WHERE (idenpersacti = 'Y') ORDER " & _
        "BY idenpersorde"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
        '
        'Ds_idenpers1
        '
        Me.Ds_idenpers1.DataSetName = "ds_idenpers"
        Me.Ds_idenpers1.EnforceConstraints = False
        Me.Ds_idenpers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter3
        '
        Me.OdbcDataAdapter3.SelectCommand = Me.OdbcSelectCommand3
        Me.OdbcDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tsex", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("tsexcode", "tsexcode"), New System.Data.Common.DataColumnMapping("tsexdesc", "tsexdesc")})})
        '
        'OdbcSelectCommand3
        '
        Me.OdbcSelectCommand3.CommandText = "SELECT tsexcode, tsexdesc FROM tsex WHERE (tsexacti = 'Y') ORDER BY tsexorde"
        Me.OdbcSelectCommand3.Connection = Me.OdbcConnection1
        '
        'Ds_tsex1
        '
        Me.Ds_tsex1.DataSetName = "ds_tsex"
        Me.Ds_tsex1.EnforceConstraints = False
        Me.Ds_tsex1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcDataAdapter4
        '
        Me.OdbcDataAdapter4.SelectCommand = Me.OdbcSelectCommand4
        Me.OdbcDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "siaf", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("siafcode", "siafcode"), New System.Data.Common.DataColumnMapping("siafdesc", "siafdesc"), New System.Data.Common.DataColumnMapping("siafacti", "siafacti")})})
        '
        'OdbcSelectCommand4
        '
        Me.OdbcSelectCommand4.CommandText = "SELECT siafcode, siafdesc, siafacti FROM siaf WHERE (siafacti = 'Y')"
        Me.OdbcSelectCommand4.Connection = Me.OdbcConnection1
        '
        'Ds_siaf1
        '
        Me.Ds_siaf1.DataSetName = "ds_siaf"
        Me.Ds_siaf1.EnforceConstraints = False
        Me.Ds_siaf1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'OdbcSelectCommand5
        '
        Me.OdbcSelectCommand5.CommandText = "SELECT terr_key,terr_keyfath, terrleve,terrdesc FROM terr WHERE plancode='PT' and" & _
        " terracti = 'Y' and terrleve = 1 order by terrdesc"
        Me.OdbcSelectCommand5.Connection = Me.OdbcConnection1
        '
        'OdbcDataAdapter5
        '
        Me.OdbcDataAdapter5.DeleteCommand = Me.OdbcDeleteCommand1
        Me.OdbcDataAdapter5.InsertCommand = Me.OdbcInsertCommand1
        Me.OdbcDataAdapter5.SelectCommand = Me.OdbcSelectCommand5
        Me.OdbcDataAdapter5.UpdateCommand = Me.OdbcUpdateCommand1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT terr_key,terr_keyfath, terrleve,terrdesc FROM terr WHERE plancode='PT' and" & _
        " terracti = 'Y' and terrleve = @terrleve and terr_keyfath = @terr_keyfath order " & _
        "by terrdesc"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terr_keyfath", System.Data.SqlDbType.Int, 4, "terr_keyfath"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terrleve", System.Data.SqlDbType.SmallInt, 2, "terrleve"))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'Ds_terr1
        '
        Me.Ds_terr1.DataSetName = "ds_terr"
        Me.Ds_terr1.EnforceConstraints = False
        Me.Ds_terr1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_terr2
        '
        Me.Ds_terr2.DataSetName = "ds_terr"
        Me.Ds_terr2.EnforceConstraints = False
        Me.Ds_terr2.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_terr3
        '
        Me.Ds_terr3.DataSetName = "ds_terr"
        Me.Ds_terr3.EnforceConstraints = False
        Me.Ds_terr3.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_ver_datos1
        '
        Me.Ds_ver_datos1.DataSetName = "ds_ver_datos"
        Me.Ds_ver_datos1.EnforceConstraints = False
        Me.Ds_ver_datos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'AdapterModificarUsuario
        '
        Me.AdapterModificarUsuario.SelectCommand = Me.SqlSelectCommand2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_DATOS_MODIFICAR_USUARIO]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pers", System.Data.SqlDbType.Int, 4, "pers_key"))
        CType(Me.Ds_troa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_idenpers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_tsex1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_siaf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_terr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_terr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_terr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_ver_datos1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents DropDownList4 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_troa1 As cimaweb.ds_troa
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_idenpers1 As cimaweb.ds_idenpers
    Protected WithEvents OdbcDataAdapter3 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand3 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_tsex1 As cimaweb.ds_tsex
    Protected WithEvents nombre As System.Web.UI.WebControls.TextBox
    Protected WithEvents nif As System.Web.UI.WebControls.TextBox
    Protected WithEvents telefono As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList3 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents edad As System.Web.UI.WebControls.TextBox
    Protected WithEvents fecha_nacimiento As System.Web.UI.WebControls.TextBox
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList5 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents OdbcDataAdapter4 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand4 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_siaf1 As cimaweb.ds_siaf
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents direccion As System.Web.UI.WebControls.TextBox
    Protected WithEvents numero As System.Web.UI.WebControls.TextBox
    Protected WithEvents piso As System.Web.UI.WebControls.TextBox
    Protected WithEvents puerta As System.Web.UI.WebControls.TextBox
    Protected WithEvents cp As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents apellido1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents apellido2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents movil As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As WebControlCIMA.Buttons.ButtonEnviar
    Protected WithEvents CustomValidator1 As System.Web.UI.WebControls.CustomValidator
    Protected WithEvents DropDownList6 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList7 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList8 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents email As System.Web.UI.WebControls.TextBox
    Protected WithEvents OdbcSelectCommand5 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcUpdateCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDeleteCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcDataAdapter5 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Ds_terr1 As cimaweb.ds_terr
    Protected WithEvents Ds_terr2 As cimaweb.ds_terr
    Protected WithEvents Ds_terr3 As cimaweb.ds_terr
    Protected WithEvents LBEncabezado As System.Web.UI.WebControls.Label
    Public WithEvents Ds_ver_datos1 As cimaweb.ds_ver_datos
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents AdapterModificarUsuario As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents aux_pers_key As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    'Dim ib_control As Boolean

    'CARLOS - MODIFICACION *****
    Dim pais, provincia, ciudad, sexo, ident, troa, siaf As String
    'CARLOS - MODIFICACION *****

    Dim lb_ok_fecha_nacimiento As Boolean

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página

        Dim login As String

        login = Request.Cookies("usuario").Value

        Session("login") = login

        'JGM evitar modificar dades altre usuari
        If IsPostBack = False Then
            Me.aux_pers_key.Text = Session("pers_key")
        End If

        'CARLOS - MODIFICACION *****
        If Request("clave") = "" Then
            LBEncabezado.Text = "Nuevo Usuario"
            Me.Button1.Text = "Aceptar"
        Else
            LBEncabezado.Text = "Modificar Usuario"
            Me.Button1.Text = "Modificar"
        End If
        'CARLOS - MODIFICACION ******

        If IsPostBack = False Then

            'CARLOS - MODIFICACION ******
            If LBEncabezado.Text = "Modificar Usuario" Then
                Dim i As Integer

                Me.AdapterModificarUsuario.SelectCommand.Parameters(1).Value = Me.aux_pers_key.Text

                Me.SqlConnection1.Open()
                Me.AdapterModificarUsuario.Fill(Me.Ds_ver_datos1.SP_CIMACEX_DATOS_MODIFICAR_USUARIO)
                Me.SqlConnection1.Close()

                For i = 0 To Me.Ds_ver_datos1.Tables("SP_CIMACEX_DATOS_MODIFICAR_USUARIO").Rows.Count - 1
                    Dim fila As DataRow
                    fila = Ds_ver_datos1.Tables("SP_CIMACEX_DATOS_MODIFICAR_USUARIO").Rows(i)

                    If IsDBNull(fila("perssur1")) Then
                        Me.apellido1.Text = ""
                    Else
                        Me.apellido1.Text = RTrim(fila("perssur1"))
                    End If
                    If IsDBNull(fila("perssur2")) Then
                        Me.apellido2.Text = ""
                    Else
                        Me.apellido2.Text = RTrim(fila("perssur2"))
                    End If
                    If IsDBNull(fila("persname")) Then
                        Me.nombre.Text = ""
                    Else
                        Me.nombre.Text = RTrim(fila("persname"))
                    End If
                    If IsDBNull(fila("persidencod1")) Then
                        Me.nif.Text = ""
                    Else
                        Me.nif.Text = RTrim(fila("persidencod1"))
                    End If
                    If IsDBNull(fila("persbirtdate")) Then
                        Me.fecha_nacimiento.Text = ""
                    Else
                        Me.fecha_nacimiento.Text = RTrim(fila("persbirtdate"))
                    End If
                    If IsDBNull(fila("addrnamestre")) Then
                        Me.direccion.Text = ""
                    Else
                        Me.direccion.Text = RTrim(fila("addrnamestre"))
                    End If
                    If IsDBNull(fila("addrnumb")) Then
                        Me.numero.Text = ""
                    Else
                        Me.numero.Text = RTrim(fila("addrnumb"))
                    End If
                    If IsDBNull(fila("addrfloo")) Then
                        Me.piso.Text = ""
                    Else
                        Me.piso.Text = RTrim(fila("addrfloo"))
                    End If
                    If IsDBNull(fila("addrdoor")) Then
                        Me.puerta.Text = ""
                    Else
                        Me.puerta.Text = RTrim(fila("addrdoor"))
                    End If
                    If IsDBNull(fila("addrpostcode")) Then
                        Me.cp.Text = ""
                    Else
                        Me.cp.Text = RTrim(fila("addrpostcode"))
                    End If
                    If IsDBNull(fila("addrtel1")) Then
                        Me.telefono.Text = ""
                    Else
                        Me.telefono.Text = RTrim(fila("addrtel1"))
                    End If
                    If IsDBNull(fila("addrtel2")) Then
                        Me.movil.Text = ""
                    Else
                        Me.movil.Text = RTrim(fila("addrtel2"))
                    End If
                    If IsDBNull(fila("addrmail")) Then
                        Me.email.Text = ""
                    Else
                        Me.email.Text = RTrim(fila("addrmail"))
                    End If
                    If IsDBNull(fila("Column1")) Then
                        pais = ""
                    Else
                        pais = fila("Column1")
                    End If
                    If IsDBNull(fila("Column2")) Then
                        provincia = ""
                    Else
                        provincia = fila("Column2")
                    End If
                    If IsDBNull(fila("Column3")) Then
                        ciudad = ""
                    Else
                        ciudad = fila("Column3")
                    End If
                    If IsDBNull(fila("tsexdesc")) Then
                        sexo = ""
                    Else
                        sexo = fila("tsexdesc")
                    End If
                    If IsDBNull(fila("idenpersdesc")) Then
                        ident = ""
                    Else
                        ident = fila("idenpersdesc")
                    End If
                    If IsDBNull(fila("troaname")) Then
                        troa = ""
                    Else
                        troa = fila("troaname")
                    End If
                    If IsDBNull(fila("siafcode")) Then
                        siaf = ""
                    Else
                        siaf = fila("siafcode")
                    End If
                    'Calcular con la edad de nacimiento los años que tiene
                    Validacion_Fecha_Nacimiento()
                Next
            End If
            'CARLOS - MODIFICACION ******

            Session("agencode") = Request("agencode")
            Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("estable") = Request("estable")
            Session("citas_rapidas") = Request("citas_rapidas")
            Session("multicitas") = Request("multicitas")

        End If

        Me.Label1.Visible = False

        Me.OdbcConnection1.Open()

        Me.OdbcDataAdapter1.Fill(Me.Ds_troa1.troa)

        Me.OdbcDataAdapter2.Fill(Me.Ds_idenpers1.idenpers)

        Me.OdbcDataAdapter3.Fill(Me.Ds_tsex1.tsex)

        Me.OdbcDataAdapter4.Fill(Me.Ds_siaf1.siaf)

        'JGM - Afegim el país
        Me.OdbcDataAdapter5.Fill(Me.Ds_terr1.terr)
        'JGM

        Me.OdbcConnection1.Close()

        Me.DropDownList2.DataBind()

        Me.DropDownList4.DataBind()

        Me.DropDownList1.DataBind()

        Me.DropDownList5.DataBind()

        'JGM - Afegim el país 
        Me.DropDownList6.Items.Clear()
        Me.DropDownList6.DataBind()
        Me.DropDownList6.Items.Insert(0, "")

        If Len(Trim(Request("DropDownList6"))) > 0 Then
            Me.DropDownList6.SelectedValue = Request("DropDownList6")
        Else
            Me.DropDownList7.Items.Clear()
            Me.DropDownList8.Items.Clear()
        End If

        If Len(Trim(Request("DropDownList7"))) > 0 Then
            Me.DropDownList7.SelectedValue = Request("DropDownList7")
        Else
            Me.DropDownList8.Items.Clear()
        End If

        If Len(Trim(Request("DropDownList8"))) > 0 Then
            Me.DropDownList8.SelectedValue = Request("DropDownList8")
        End If

        'JGM

        'CARLOS - MODIFICACION ******
        If LBEncabezado.Text = "Modificar Usuario" And pais <> "" Then
            Me.DropDownList6.SelectedIndex = DropDownList6.Items.IndexOf(DropDownList6.Items.FindByText(pais))
            cargarProvincias()
            If provincia <> "" Then
                Me.DropDownList7.SelectedIndex = DropDownList7.Items.IndexOf(DropDownList7.Items.FindByText(provincia))
                cargarCiudades()
                If ciudad <> "" Then
                    Me.DropDownList8.SelectedIndex = DropDownList8.Items.IndexOf(DropDownList8.Items.FindByText(ciudad))
                End If
            End If
        End If

        If IsPostBack = False Then
            If LBEncabezado.Text = "Modificar Usuario" Then
                Me.DropDownList2.SelectedIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(troa))
                Me.DropDownList4.SelectedIndex = DropDownList4.Items.IndexOf(DropDownList4.Items.FindByText(ident))
                Me.DropDownList5.SelectedIndex = DropDownList5.Items.IndexOf(DropDownList5.Items.FindByValue(siaf))
                Me.DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(sexo))
            Else
                Me.DropDownList5.SelectedValue = "TI"
            End If
        Else
            Me.DropDownList1.SelectedValue = Request("DropDownList1")
            Me.DropDownList5.SelectedValue = Request("DropDownList5")
        End If
        'CARLOS - MODIFICACION ******
        'If IsPostBack = False Then

        '    Me.DropDownList5.SelectedValue = "TI"

        'Else

        '    Me.DropDownList1.SelectedValue = Request("DropDownList1")

        'End If

    End Sub

    'CARLOS - MODIFICACION ******
    Private Sub cargarProvincias()
        'JGM -- Afegim la província
        If Me.DropDownList6.SelectedIndex > 0 Then
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList6.SelectedValue
            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 2

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_terr2.terr)
            Me.SqlConnection1.Close()

            Me.DropDownList7.DataBind()
            Me.DropDownList7.Items.Insert(0, "")
            Me.DropDownList8.Items.Clear()
        Else
            Me.DropDownList7.Items.Clear()
            Me.DropDownList8.Items.Clear()
        End If

        'JGM
    End Sub

    Private Sub cargarCiudades()
        'JGM -- Afegim la població
        If Me.DropDownList6.SelectedIndex > 0 Then
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList7.SelectedValue
            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 3
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_terr3.terr)
            Me.SqlConnection1.Close()

            Me.DropDownList8.DataBind()
            Me.DropDownList8.Items.Insert(0, "")
        Else
            Me.DropDownList8.Items.Clear()
        End If
        'JGM
    End Sub
    'CARLOS - MODIFICACION ******

    Private Sub fecha_nacimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha_nacimiento.TextChanged

        Validacion_Fecha_Nacimiento()

    End Sub

    Private Sub Validacion_Fecha_Nacimiento()

        Dim ls_fecha() As String
        Dim ls_fecha_tmp As String

        ls_fecha = Split(Me.fecha_nacimiento.Text, "/", , CompareMethod.Text)

        If UBound(ls_fecha) <> 2 Then
            Session("ib_control") = False
        Else
            ls_fecha_tmp = ls_fecha(2) + "/" + ls_fecha(1) + "/" + ls_fecha(0)
            If IsDate(ls_fecha_tmp) Then
                Label1.Visible = False
                Me.DropDownList3.SelectedValue = 1
                Me.edad.Text = CStr(Int(DateDiff(DateInterval.Month, CDate(ls_fecha_tmp), Today()) / 12))
                lb_ok_fecha_nacimiento = True
                Session("ib_control") = True
            Else
                Label1.Text = "Formato de fecha incorrecto."
                Label1.Visible = True
                lb_ok_fecha_nacimiento = False
                Session("ib_control") = False
            End If
        End If

    End Sub

    Private Sub Validacion_Edad()

        If IsNumeric(Me.edad.Text) Then

            Label1.Visible = False

            If lb_ok_fecha_nacimiento = False Then
                Me.fecha_nacimiento.Text = ""
            End If

            Session("ib_control") = True

        Else

            Label1.Text = "Formato de edad incorrecto."
            Label1.Visible = True
            Session("ib_control") = False

        End If

    End Sub

    Private Sub edad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edad.TextChanged

        Validacion_Edad()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        'Dim objRow As Data.DataRow

        'Dim contador As Integer

        Dim ls_array(), ls_array2() As String

        Dim lstr_fecha_nacimiento As String

        Dim ls_dia_seleccionado As String

        Dim lb_no_ok_fecha As Boolean

        'JGM - Definició de variables
        Dim terr1 As Integer
        Dim terr2 As Integer
        Dim terr3 As Integer
        'JGM

        'Dim str_cadena_naciente As String

        'contador = 0

        lstr_fecha_nacimiento = ""

        'CARLOS - MODIFICACION ******
        'JGM si no informen res
        If Len(Trim(Request("DropDownList6"))) = 0 Then
            terr1 = 0
        Else
            terr1 = Me.DropDownList6.SelectedValue
        End If

        If Len(Trim(Request("DropDownList7"))) = 0 Then
            terr2 = 0
        Else
            terr2 = Me.DropDownList7.SelectedValue
        End If

        If Len(Trim(Request("DropDownList8"))) = 0 Then
            terr3 = 0
        Else
            terr3 = Me.DropDownList8.SelectedValue
        End If
        'JGM

        If LBEncabezado.Text = "Nuevo Usuario" Then
            'CARLOS - MODIFICACION ******

            'If IsDate(Me.fecha_nacimiento.Text) Then
            ls_array = Split(Trim(Me.fecha_nacimiento.Text), "/")
            lstr_fecha_nacimiento = Me.fecha_nacimiento.Text 'ls_array(2) + "-" + ls_array(1) + "-" + ls_array(0)
            'End If

            If IsDate(lstr_fecha_nacimiento) Then
                If CInt(ls_array(0)) > 31 Or CInt(ls_array(1)) > 12 Or CInt(ls_array(2)) < 1500 Then
                    lb_no_ok_fecha = True
                End If
            End If

            If (IsDate(lstr_fecha_nacimiento) Or IsNumeric(Me.edad.Text)) And lb_no_ok_fecha = False Then

                'If IsDate(lstr_fecha_nacimiento) = False Then
                'lstr_fecha_nacimiento = "01/01/1900"
                'End If

                Validacion_Fecha_Nacimiento()

                Validacion_Edad()

                If Session("ib_control") = True Then

                    str_menu = "dbo.SP_CIMACEX_ALTA_PACIENTE_POBLACION '" & UCase(Me.apellido1.Text) & "','" & UCase(Me.apellido2.Text) & "','" & UCase(Me.nombre.Text) & "','" & Me.DropDownList1.SelectedValue.ToString & "','" & Me.DropDownList4.SelectedValue.ToString & "','" & Me.nif.Text & "','" & lstr_fecha_nacimiento & "','" & Me.DropDownList5.SelectedValue.ToString & "','" & Me.direccion.Text & "','" & Me.numero.Text & "','" & Me.piso.Text & "','" & Me.puerta.Text & "','" & Me.cp.Text & "','" & Me.DropDownList2.SelectedValue.ToString & "','" & Left(LCase(LTrim(RTrim(Session("login")))), 15) & "','" & Me.telefono.Text & "','" & Me.movil.Text & "'," & Me.DropDownList3.SelectedValue & "," & Me.edad.Text & "," & terr1 & "," & terr2 & "," & terr3 & ",'" & Me.email.Text & "'"
                    'str_menu = "dbo.SP_CIMACEX_ALTA_PACIENTE '" & UCase(Me.apellido1.Text) & "','" & UCase(Me.apellido2.Text) & "','" & UCase(Me.nombre.Text) & "','" & Me.DropDownList1.SelectedValue.ToString & "','" & Me.DropDownList4.SelectedValue.ToString & "','" & Me.nif.Text & "','" & lstr_fecha_nacimiento & "','" & Me.DropDownList5.SelectedValue.ToString & "','" & Me.direccion.Text & "','" & Me.numero.Text & "','" & Me.piso.Text & "','" & Me.puerta.Text & "','" & Me.cp.Text & "','" & Me.DropDownList2.SelectedValue.ToString & "','" & Left(LCase(LTrim(RTrim(Session("login")))), 15) & "','" & Me.telefono.Text & "','" & Me.movil.Text & "'," & Me.DropDownList3.SelectedValue & "," & Me.edad.Text

                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    If Session("estable") = "1" Then
                        Session("estable") = ""
                        Response.Redirect("form_menu_2.aspx")
                    Else
                        If Session("citas_rapidas") = "S" Then

                            Response.Redirect("form_busca_persona_citas_rapidas.aspx?apnombre=" & objDS.Tables(0).Rows(0).Item(1) & "&control=True")
                            'Response.Redirect("form_busca_persona_citas_rapidas.aspx?apnombre=PACHON CONTRERAS, JUAN CARLOS&control=True")

                            'Response.Write("<scr" & "ipt>" & vbCrLf)

                            'Response.Write("opener.Form1.retorno_pers_key.value = " & CStr(objDS.Tables(0).Rows(0).Item(0)) & ";" & vbCrLf)
                            'Response.Write("opener.Form1.nombre.value = '" & objDS.Tables(0).Rows(0).Item(1) & "';" & vbCrLf)
                            'Response.Write("opener.Form1.submit();" & vbCrLf)
                            'Response.Write("window.close();" & vbCrLf)

                            'Response.Write("</scr" & "ipt>" & vbCrLf)

                        ElseIf Session("multicitas") = "S" Then

                            Response.Redirect("form_busca_persona_multicitas.aspx?apnombre=" & objDS.Tables(0).Rows(0).Item(1) & "&control=True")
                            'Response.Redirect("form_busca_persona_multicitas.aspx?apnombre=PACHON CONTRERAS, JUAN CARLOS&control=True")

                        Else

                            ls_array2 = Split(Session("dia_seleccionado"), "/", , CompareMethod.Text)
                            ls_dia_seleccionado = ls_array2(1) & "/" & ls_array2(0) & "/" & ls_array2(2)
                            Response.Redirect("../formularios/form_solicitar_cita.aspx?persona_ok=S&dia_seleccionado=" & Session("dia_seleccionado") & "&dia_seleccionado_corregido=" & Session("dia_seleccionado") & "&agencode=" & Session("agencode") & "&persona=" & objDS.Tables(0).Rows(0).Item(1) & "&pers_key=" & CStr(objDS.Tables(0).Rows(0).Item(0)))

                        End If
                    End If


                    'Dim pp As String
                    'pp = "opener.location.href='../formularios/form_solicitar_cita.aspx?persona_ok=S&dia_seleccionado=" & Session("dia_seleccionado") & "&agencode=" & Session("agencode") & "&persona=" & objDS.Tables(0).Rows(0).Item(1) & "&pers_key=" & objDS.Tables(0).Rows(0).Item(0) & ";"
                    'Response.Write("<scr" & "ipt>" & vbCrLf)
                    'Response.Write("alert('Paciente registrado con éxito.');" & vbCrLf)
                    'Response.Write("opener.location.href='../formularios/form_solicitar_cita.aspx?persona_ok=S&dia_seleccionado=" & Session("dia_seleccionado") & "&agencode=" & Session("agencode") & "&persona=" & objDS.Tables(0).Rows(0).Item(1) & "&pers_key=" & objDS.Tables(0).Rows(0).Item(0) & ";")
                    'Response.Write("window.close();")
                    'Response.Write("</scr" & "ipt>" & vbCrLf)
                    'End If

                Else

                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Error en la validación de los datos. Por favor, repase el formulario de alta de paciente.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>" & vbCrLf)

                End If

            Else

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Fecha de Nacimiento con formato incorrecto.');" & vbCrLf)
                Response.Write("</scr" & "ipt>" & vbCrLf)

            End If
            'CARLOS - MODIFICACION ******
        Else
            If CInt(Me.aux_pers_key.Text) <> CInt(Session("pers_key")) Then
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('El paciente que se intenta modificar no es el que se está visualizando. Se cerrará la ventana');" & vbCrLf)
                Response.Write("</scr" & "ipt>" & vbCrLf)
                Response.Write("<script language='javascript'>window.close();</script>" & vbCrLf)
            Else
                str_menu = "dbo.SP_CIMACEX_MODIFICAR_USUARIO " & Me.aux_pers_key.Text & ",'" & UCase(Me.apellido1.Text) & "','" & UCase(Me.apellido2.Text) & "','" & UCase(Me.nombre.Text) & "'," & Me.DropDownList1.SelectedValue & ",'" & Me.DropDownList4.SelectedValue.ToString & "','" & Me.nif.Text & "','" & Me.fecha_nacimiento.Text & "','" & Me.DropDownList5.SelectedValue & "','" & Me.direccion.Text & "','" & Me.numero.Text & "','" & Me.piso.Text & "','" & Me.puerta.Text & "','" & Me.cp.Text & "','" & Me.DropDownList2.SelectedValue.ToString & "','" & Left(LCase(LTrim(RTrim(Session("login")))), 15) & "','" & Me.telefono.Text & "','" & Me.movil.Text & "'," & terr1 & "," & terr2 & "," & terr3 & ",'" & Me.email.Text & "'"

                objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("opener.location.href='../formularios/form_pers.aspx?pers_key=" & Session("pers_key") & "';")
                Response.Write("</scr" & "ipt>")
                Response.Write("<script language='javascript'>window.close();</script>" & vbCrLf)
            End If
        End If
        'CARLOS - MODIFICACION ******
    End Sub

    Private Sub DropDownList6_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList6.SelectedIndexChanged

        'JGM -- Afegim la província
        If Len(Trim(Request("DropDownList6"))) > 0 Then
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList6.SelectedValue
            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 2
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_terr2.terr)
            Me.SqlConnection1.Close()

            Me.DropDownList7.DataBind()
            Me.DropDownList7.Items.Insert(0, "")
            Me.DropDownList8.Items.Clear()
        Else
            Me.DropDownList7.Items.Clear()
            Me.DropDownList8.Items.Clear()
        End If
        'JGM

    End Sub

    Private Sub DropDownList7_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList7.SelectedIndexChanged

        'JGM -- Afegim la població
        If Len(Trim(Request("DropDownList7"))) > 0 Then
            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = Me.DropDownList7.SelectedValue
            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = 3
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.Fill(Me.Ds_terr3.terr)
            Me.SqlConnection1.Close()

            Me.DropDownList8.DataBind()
            Me.DropDownList8.Items.Insert(0, "")
        Else
            Me.DropDownList8.Items.Clear()
        End If
        'JGM

    End Sub

    'CARLOS - MODIFICACION ******
    Private Sub DropDownList5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList5.SelectedIndexChanged
        Me.DropDownList5.SelectedValue = Request("dropdownlist5")
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Me.DropDownList1.SelectedValue = Request("DropDownList1")
    End Sub
    'CARLOS - MODIFICACION ******
End Class
