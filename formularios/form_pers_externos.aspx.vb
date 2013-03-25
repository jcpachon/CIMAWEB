Public Class form_pers_externos
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Ds_pers1 = New cimaweb.ds_pers
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.OdbcDataAdapter2 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand2 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_cima_epis_claves1 = New cimaweb.ds_cima_epis_claves
        Me.Ds_epis1 = New cimaweb.ds_epis
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_cima_epis_informes1 = New cimaweb.ds_cima_epis_informes
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_epis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Ds_pers1
        '
        Me.Ds_pers1.DataSetName = "ds_pers"
        Me.Ds_pers1.EnforceConstraints = False
        Me.Ds_pers1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_claves", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("clave", "clave"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("descargado", "descargado")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT episcode, clave, fecha, descargado FROM cima_epis_claves WHERE (episcode =" & _
        " @episcode)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'OdbcDataAdapter2
        '
        Me.OdbcDataAdapter2.SelectCommand = Me.OdbcSelectCommand2
        Me.OdbcDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode")})})
        '
        'OdbcSelectCommand2
        '
        Me.OdbcSelectCommand2.CommandText = "SELECT episcode FROM epis"
        Me.OdbcSelectCommand2.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;PWD=kampeon10;DSN=CIMACEX;UID=sa;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_cima_epis_claves1
        '
        Me.Ds_cima_epis_claves1.DataSetName = "ds_cima_epis_claves"
        Me.Ds_cima_epis_claves1.EnforceConstraints = False
        Me.Ds_cima_epis_claves1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Ds_epis1
        '
        Me.Ds_epis1.DataSetName = "ds_epis"
        Me.Ds_epis1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_CLAVE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_ALTA_CLAVE]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 10))
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pers_key", "pers_key"), New System.Data.Common.DataColumnMapping("idenperscod1", "idenperscod1"), New System.Data.Common.DataColumnMapping("addrcode", "addrcode"), New System.Data.Common.DataColumnMapping("idenperscod2", "idenperscod2"), New System.Data.Common.DataColumnMapping("titlcode", "titlcode"), New System.Data.Common.DataColumnMapping("posttitlcode", "posttitlcode"), New System.Data.Common.DataColumnMapping("apuscode", "apuscode"), New System.Data.Common.DataColumnMapping("tsexcode", "tsexcode"), New System.Data.Common.DataColumnMapping("plancode", "plancode"), New System.Data.Common.DataColumnMapping("persdatechag", "persdatechag"), New System.Data.Common.DataColumnMapping("persacti", "persacti"), New System.Data.Common.DataColumnMapping("perssur1", "perssur1"), New System.Data.Common.DataColumnMapping("perssur2", "perssur2"), New System.Data.Common.DataColumnMapping("persname", "persname"), New System.Data.Common.DataColumnMapping("persidencod1", "persidencod1"), New System.Data.Common.DataColumnMapping("persidencod2", "persidencod2"), New System.Data.Common.DataColumnMapping("persbirtdate", "persbirtdate"), New System.Data.Common.DataColumnMapping("persnickname", "persnickname"), New System.Data.Common.DataColumnMapping("imag_key", "imag_key"), New System.Data.Common.DataColumnMapping("persmai1", "persmai1"), New System.Data.Common.DataColumnMapping("persmai2", "persmai2"), New System.Data.Common.DataColumnMapping("persrema", "persrema"), New System.Data.Common.DataColumnMapping("codetmplcode", "codetmplcode"), New System.Data.Common.DataColumnMapping("perscode", "perscode"), New System.Data.Common.DataColumnMapping("perssitucode", "perssitucode"), New System.Data.Common.DataColumnMapping("civistatcode", "civistatcode"), New System.Data.Common.DataColumnMapping("terr_key", "terr_key"), New System.Data.Common.DataColumnMapping("persdatecalc", "persdatecalc"), New System.Data.Common.DataColumnMapping("docu_key", "docu_key"), New System.Data.Common.DataColumnMapping("persfullname", "persfullname"), New System.Data.Common.DataColumnMapping("msrepl_tran_version", "msrepl_tran_version")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT pers_key, idenperscod1, addrcode, idenperscod2, titlcode, posttitlcode, ap" & _
        "uscode, tsexcode, plancode, persdatechag, persacti, perssur1, perssur2, persname" & _
        ", persidencod1, persidencod2, persbirtdate, persnickname, imag_key, persmai1, pe" & _
        "rsmai2, persrema, codetmplcode, perscode, perssitucode, civistatcode, terr_key, " & _
        "persdatecalc, docu_key, persfullname, msrepl_tran_version FROM pers"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_epis_informes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("episcode", "episcode"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("numero", "numero"), New System.Data.Common.DataColumnMapping("informe", "informe"), New System.Data.Common.DataColumnMapping("fecha", "fecha")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT episcode, id_usuario, numero, informe, fecha FROM cima_epis_informes WHERE" & _
        " (episcode = @episcode) AND (numero = @numero)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero", System.Data.SqlDbType.Int, 4, "numero"))
        '
        'Ds_cima_epis_informes1
        '
        Me.Ds_cima_epis_informes1.DataSetName = "ds_cima_epis_informes"
        Me.Ds_cima_epis_informes1.EnforceConstraints = False
        Me.Ds_cima_epis_informes1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_pers1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_epis_claves1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_epis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cima_epis_informes1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer
    Protected WithEvents Button9 As System.Web.UI.WebControls.Button
    Protected WithEvents Button10 As System.Web.UI.WebControls.Button
    Protected WithEvents Button11 As System.Web.UI.WebControls.Button
    Protected WithEvents Ds_pers1 As cimaweb.ds_pers
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents OdbcDataAdapter2 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand2 As System.Data.Odbc.OdbcCommand
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_cima_epis_claves1 As cimaweb.ds_cima_epis_claves
    Protected WithEvents Ds_epis1 As cimaweb.ds_epis
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Label19 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label18 As System.Web.UI.WebControls.Label
    Protected WithEvents Label20 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_cima_epis_informes1 As cimaweb.ds_cima_epis_informes

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Dim objCR_rpt_informes As New cr_obj_clave

    Public service As New CIMAServeiIntegracio.ServeiIntegracio

    Public Function CheckBoxEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "S" Then
            returnValue = "True"
        Else
            returnValue = "False"
        End If

        Return returnValue

    End Function

    Public Function EstadoEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "Y" Then
            returnValue = "<span class=""letra_muy_pequena_azul_negrita"">&nbsp;ACTIVO&nbsp;</span>"
        Else
            returnValue = "<span class=""letra_muy_pequena_rojo_negrita"">&nbsp;INACTIVO&nbsp;</span>"
        End If

        Return returnValue

    End Function

    Public Function SexoEval(ByVal strValue As String) As String

        Dim returnValue As String = ""

        If strValue = "2" Then
            returnValue = "MASCULINO"
        Else
            returnValue = "FEMENINO"
        End If

        Return returnValue

    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Net.ServicePointManager.CertificatePolicy = New MyPolicy

        'Introducir aquí el código de usuario para inicializar la página
        Dim str_uid As String

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA
        Dim objDS_USR As New Data.DataSet

        Dim lstr_fecha_nacimiento() As String
        Dim lstr_temporal() As String

        If Request("abrir_informe") = "S" Then

            Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = Request("episcode_informe")
            Me.SqlDataAdapter3.SelectCommand.Parameters(1).Value = Request("numero_informe")

            Me.SqlConnection1.Open()
            Me.SqlDataAdapter3.Fill(Me.Ds_cima_epis_informes1.cima_epis_informes)
            Me.SqlConnection1.Close()

            Response.ClearContent()
            Response.ClearHeaders()
            Response.ContentType = "application/pdf"
            Response.AddHeader("Content-Disposition", _
            "attachment; filename=""" & Request("episcode_informe") & ".pdf""")
            Response.BinaryWrite(Me.Ds_cima_epis_informes1.cima_epis_informes.Rows(0).Item("informe"))
            Response.Flush()
            Response.Close()

        End If

        If Session("grupo") = "A" Then
            'Me.Button5.Visible = False
            'Me.Button6.Visible = False
            'Me.Button9.Visible = False
            'Me.Button10.Visible = False
            'Me.Panel1.Visible = False
            'Me.Button1.Visible = False
            'Me.Button2.Visible = False
            'Me.Button3.Visible = False
            'Me.Button4.Visible = False
            'Me.Button7.Visible = False
            'Me.Button8.Visible = False
        End If

        If IsPostBack = False Then

            Session("pers_key") = Request("pers_key")
            Session("episcode") = Request("episcode")
            Session("dia_seleccionado") = Request("dia_seleccionado")
            Session("dia_en_seleccion") = Session("dia_seleccionado_corregido")
            Session("servicio_seleccionado") = Request("servicio_seleccionado")
            Session("agenda_seleccionada") = Request("agenda_seleccionada")
            Session("DropDownList2") = Request("DropDownList2")
            Session("DropDownList1") = Request("DropDownList1")
            Session("control") = Request("control")

            Session("mutua") = Request("mutua")
            Session("nacimiento") = Request("nacimiento")
            Session("cove") = Request("cove")
            Session("estado") = Trim(Request("estado"))

            Session("realizada") = Trim(Request("realizada"))

            lstr_fecha_nacimiento = Split(Request("nacimiento"), "/", , CompareMethod.Text)

            If UBound(lstr_fecha_nacimiento) > 0 Then
                Session("edad") = CStr(CInt(DateDiff(DateInterval.Month, CDate(lstr_fecha_nacimiento(2) & "-" & lstr_fecha_nacimiento(1) & "-" & lstr_fecha_nacimiento(0)), Today()) / 12))
                lstr_temporal = Split(Session("edad"), ".", , CompareMethod.Text)
                If UBound(lstr_temporal) > 0 Then
                    Session("edad") = lstr_temporal(0)
                End If
            Else
                Session("edad") = ""
            End If

            str_uid = Request.Cookies("usuario").Value

            Session("usuario") = str_uid

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

            str_menu = "dbo.sp_permiso '" & Trim(str_uid) & "'"

            objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Session("grupo") = objDS_USR.Tables(0).Rows(0).Item(0)

            objDS_USR = Nothing

            If Session("episcode") = Nothing Or Request("control") = "S" Then
                'Me.Button5.Visible = False
                'Me.Button6.Visible = False
                Me.Button9.Visible = False
                Me.Button10.Visible = False
                Me.Button11.Visible = False
                'Me.Button12.Visible = False
                'Me.Button13.Visible = False
                Me.Panel1.Visible = False
                Session("debusqueda") = "1"
            Else
                Session("debusqueda") = "0"
            End If

        End If

        If Session("estado") <> "P" Then
            Me.Button10.Enabled = False
        End If

        If Session("episcode") = Nothing Or Request("control") = "S" Then
        Else

            If Session("realizada") <> "N" Or CDate(Session("dia_seleccionado")) > Today() Then
                'Me.Button12.Enabled = False
            End If
        End If

        Me.Label19.Text = Session("episcode")

        'Me.Label21.Text = Session("mutua")
        'Me.Label22.Text = Session("edad")
        'Me.Label23.Text = Session("cove")

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

        Me.OdbcConnection1.Open()

        'Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers_key, idenperscod1, addrcode, idenperscod2, titlcode, posttitlcode, apuscode, tsexcode, plancode, persdatechag, persacti, perssur1, perssur2, persname, persidencod1, persidencod2, persbirtdate, persnickname, imag_key, persmai1, persmai2, persrema, codetmplcode, perscode, perssitucode, civistatcode, terr_key, persdatecalc, docu_key, persfullname, msrepl_tran_version FROM pers WHERE pers_key = " + Request("pers_key")
        'JGM Modificació 17/02/2011 per Institut Marquès mostrem el seu NHC_imarques.
        If Session("grupo") = "L" Then
            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT top 1 pers.pers_key,pers.tsexcode,pers.persacti,pers.perssur1,pers.perssur2,pers.persname,pers.persidencod1,[reporting].[f_cima_fecha] (pers.persbirtdate) as persbirtdate,addr.troacode,[reporting].[f_cima_paciente_direccion_pers_key_sg](pers.pers_key) as addrnameaddr,addr.addrnamestre,addr.addrnumb,addr.addrblok,addr.addrstai,addr.addrfloo,addr.addrdoor,addr.addrpostcode,addr.addrtel1,addr.addrtel2,addr.addrmail,addr.addrpweb,NHC_imarques as pati_hfn, pers.persmai1, pers.persmai2 FROM pers left join addr on pers.addrcode = addr.addrcode left join cima_nhc_imarques on pers.pers_key = cima_nhc_imarques.pers_key WHERE pers.pers_key = " + Session("pers_key")
        Else
            Me.OdbcDataAdapter1.SelectCommand.CommandText = "SELECT pers.pers_key,pers.tsexcode,pers.persacti,pers.perssur1,pers.perssur2,pers.persname,pers.persidencod1,[reporting].[f_cima_fecha] (pers.persbirtdate) as persbirtdate,addr.troacode,[reporting].[f_cima_paciente_direccion_pers_key_sg](pers.pers_key) as addrnameaddr,addr.addrnamestre,addr.addrnumb,addr.addrblok,addr.addrstai,addr.addrfloo,addr.addrdoor,addr.addrpostcode,addr.addrtel1,addr.addrtel2,addr.addrmail,addr.addrpweb, pati.pati_hfn, pers.persmai1, pers.persmai2 FROM pers left join pati on pati.pers_key = pers.pers_key left join addr on pers.addrcode = addr.addrcode WHERE pers.pers_key = " + Session("pers_key")
        End If
        'Me.OdbcDataAdapter1.SelectCommand.Parameters(0).Value = 8

        Me.OdbcDataAdapter1.Fill(Me.Ds_pers1.pers)

        Me.Label1.DataBind()
        Me.Label2.DataBind()
        Me.Label3.DataBind()

        Me.Label4.DataBind()

        Me.Label5.DataBind()
        Me.Label6.DataBind()
        Me.Label7.DataBind()
        Me.Label8.DataBind()
        Me.Label9.DataBind()
        Me.Label10.DataBind()
        'Me.Label11.DataBind()
        'Me.Label12.DataBind()
        'Me.Label13.DataBind()
        'Me.Label14.DataBind()
        Me.Label15.DataBind()
        'Me.Label16.DataBind()
        'Me.Label17.DataBind()

        Me.Label18.DataBind()
        Me.Label20.DataBind()

        'Me.Label24.DataBind()

        Me.OdbcConnection1.Close()

        Me.OdbcConnection1.Open()

        OdbcDataAdapter2.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

        Me.OdbcDataAdapter2.SelectCommand.CommandText = "SELECT [reporting].[f_cima_fecha] (coalesce(book.diardate,'01/01/1900')) as 'Fecha',coalesce(convert(varchar,bookhini,108),'') as 'Hora',tact.tactdesc as 'Área', epis.episcode as 'Episodio', coalesce([reporting].[f_cima_doctor] (epis.epis_key),'') as 'Doctor', coalesce([reporting].[f_cima_estado_episodio] (appo.appostatcode),'') as 'Estado' , coalesce(agen.agenname,'') as 'Agenda' " & _
        "FROM epis inner join clip ON epis.clip_key=clip.clip_key  INNER  JOIN pers ON clip.pers_key=pers.pers_key inner join tact on tact.tactcode=epis.tactcode left join appo on epis.epis_key = appo.epis_key left join book on appo.book_key = book.book_key left join agen on book.agencode = agen.agencode " & _
        "WHERE pers.pers_key = " + Session("pers_key") + " ORDER BY epis.episdatecrea DESC"

        Me.OdbcDataAdapter2.Fill(Me.Ds_epis1.epis)
        'Me.DataGrid1.DataBind()

        Me.OdbcConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("env_episodio.submit();" & vbCrLf)
        'Response.Write("</scr" & "ipt>")

        'Dim kk As New oswinsck.TCP
        'Dim objSendSMS As New SMSCOM.SMSSend

        'Dim resultado As Integer

        'Dim getResult, getDescription, getCredit As String

        'kk.Connect("217.76.128.8", 8080)


        'objSendSMS = Server.CreateObject("SMSCOM.SMSSend")

        'Defino las propiedades
        'objSendSMS.setAccount("juancarlos.pachon@cimaclinic.com")
        'objSendSMS.setPwd("suburbia")
        'objSendSMS.setText("Este es mi texto")
        'objSendSMS.setTo("652459786")
        'objSendSMS.setFrom("mi remite")       ' Parámetro opcional 

        'Recupero los valores establecidos
        'Account = objSendSMS.getAccount
        'Pwd = objSendSMS.getPwd
        'Texto = objSendSMS.getText
        'Para = objSendSMS.getTo
        'Remite = objSendSMS.getFrom

        'Envío del mensaje
        'resultado = objSendSMS.Send

        'Resultado de la operación
        'getResult = objSendSMS.getResult
        'getDescription = objSendSMS.getDescription
        'getCredit = objSendSMS.getCredit

        'Response.Write("El resultado es " & resultado & "<br>")
        'Response.Write("getResult es " & getResult & "<br>")
        'Response.Write("getDescription es " & getDescription & "<br>")
        'Response.Write("getCredit es " & getCredit & "<br>")

        'objSendSMS = Nothing

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 1;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 4;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 3;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 2;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 5;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 6;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 7;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 8;" & vbCrLf)
        Response.Write("</scr" & "ipt>")
        'Response.Redirect("form_agendas.aspx?DropDownList1=" & Session("agenda_seleccionada") & "&VisibleDate=" & Session("dia_seleccionado"))

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        'Response.Write("<scr" & "ipt>" & vbCrLf)
        'Response.Write("control = 9;" & vbCrLf)
        'Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("var control = 10;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Response.Write("<scr" & "ipt>" & vbCrLf)
        Response.Write("control = 11;" & vbCrLf)
        Response.Write("</scr" & "ipt>")

    End Sub

End Class
