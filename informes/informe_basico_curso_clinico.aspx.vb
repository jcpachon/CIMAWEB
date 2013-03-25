Public Class informe_basico_curso_clinico
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.Ds_pacientes1 = New cimaweb.ds_pacientes
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.Ds_cabecera1 = New cimaweb.ds_cabecera
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Ds_plantillas1 = New cimaweb.ds_plantillas
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cabecera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SFFM1DR130;packet size=4096;user id=sa;data source=""10.8.50.213"";p" & _
        "ersist security info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .N" & _
        "ET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
        '
        'Ds_pacientes1
        '
        Me.Ds_pacientes1.DataSetName = "ds_pacientes"
        Me.Ds_pacientes1.EnforceConstraints = False
        Me.Ds_pacientes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_informes_master", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cabecera", "cabecera")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cabecera FROM cima_informes_master WHERE (id_informe = @id_informe)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_informe", System.Data.SqlDbType.Int, 4, "id_informe"))
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
        'Ds_cabecera1
        '
        Me.Ds_cabecera1.DataSetName = "ds_cabecera"
        Me.Ds_cabecera1.EnforceConstraints = False
        Me.Ds_cabecera1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cima_plantillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_plantilla", "id_plantilla"), New System.Data.Common.DataColumnMapping("version", "version"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("acceso_libre", "acceso_libre"), New System.Data.Common.DataColumnMapping("informacion", "informacion"), New System.Data.Common.DataColumnMapping("id_propietario", "id_propietario"), New System.Data.Common.DataColumnMapping("fecha_creacion", "fecha_creacion"), New System.Data.Common.DataColumnMapping("permiso_acceso", "permiso_acceso"), New System.Data.Common.DataColumnMapping("consentimiento", "consentimiento")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_plantilla, version, descripcion, acceso_libre, informacion, id_propieta" & _
        "rio, fecha_creacion, permiso_acceso, consentimiento FROM cima_plantillas WHERE (" & _
        "id_plantilla = @id_plantilla)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_plantilla", System.Data.SqlDbType.Int, 4, "id_plantilla"))
        '
        'Ds_plantillas1
        '
        Me.Ds_plantillas1.DataSetName = "ds_plantillas"
        Me.Ds_plantillas1.EnforceConstraints = False
        Me.Ds_plantillas1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_pacientes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cabecera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_plantillas1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Protected WithEvents Ds_pacientes1 As cimaweb.ds_pacientes
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Protected WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Protected WithEvents Ds_cabecera1 As cimaweb.ds_cabecera
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_plantillas1 As cimaweb.ds_plantillas
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label

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

        Me.Label1.Text = Session("episcode")

        If IsPostBack = False Then

            'Me.control.Text = Session("episcode")

            If Request("id_informe") = Nothing Then
                Session("id_informe") = "0"
                Session("cabecera") = ""
                'Me.Button2.Enabled = False
            Else
                Session("id_informe") = Request("id_informe")
            End If

            'Session("usuario") = Request("usuario")
            Session("usuario") = Request.Cookies("usuario").Value
            Session("episodio") = Request("episodio")
            Session("id_plantilla") = Request("id_plantilla")

            ' Recuperación del paciente por episodio.

            Me.OdbcConnection1.Open()

            Me.OdbcDataAdapter1.SelectCommand.Parameters(1).Value = Session("episcode")
            Me.OdbcDataAdapter1.Fill(Me.Ds_pacientes1.pacientes)

            'Me.Label4.Text = Me.Ds_pacientes1.pacientes.Rows(0).Item(1)

            Me.OdbcConnection1.Close()

            ' Fin.
            'Modificació JGM 23/03/2009-- 
            'Recuperem la data/hora admissió i el motiu de la visita de l'episodi.

            Dim str_menu As String
            Dim objCIMA As New CIMA_Clases.CIMA

            Dim objDS As New Data.DataSet

            Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"

            str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORME_RESTO '" & Session("episcode") & "'"

            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            Me.Label4.Text = objDS.Tables(0).Rows(0).Item(1)
            Me.Label5.Text = objDS.Tables(0).Rows(0).Item(2)
            Me.Label7.Text = objDS.Tables(0).Rows(0).Item(3)

            'Fi Modificació JGM 23/03/2009--

            ' Título propuesto.

            If Len(Session("id_plantilla")) > 0 And Session("id_plantilla") > "0" Then

                Me.SqlConnection1.Open()

                Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Session("id_plantilla")

                Me.SqlDataAdapter2.Fill(Me.Ds_plantillas1.cima_plantillas)

                Session("titulo_propuesto") = Me.Ds_plantillas1.Tables(0).Rows(0).Item("informacion")

                Me.SqlConnection1.Close()

            End If

            ' Fin.

        End If

    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim n As Integer

        Dim matriz_memoria() As String

        Dim objDS As New Data.DataSet

        Dim li_id_informe As Integer

        Dim lb_error As Boolean

        'Dim lint_id_informe_master As Integer

        lb_error = False

        

        If Request("ok") = "S" Then

            If Request("control_episcode") <> Session("episcode") Then

                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('Lo sentimos. Se ha detectado un problema en la aplicación. Esta ventana será cerrada y no se salvará ningún cambio.');" & vbCrLf)
                Response.Write("top.window.close();" & vbCrLf)
                Response.Write("</scr" & "ipt>")

            Else

                Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

                If Request("tipo") = "N" Then

                    str_menu = "dbo.SP_CIMACEX_ALTA_INFORMES_CC '" & Request("cabecera") & "', '" & Session("usuario") & "', '" & Session("episcode") & "', '" & Request("motivo") & "', '" & Request("diagnostico") & "', 1"

                    objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                    li_id_informe = objDS.Tables(0).Rows(0).Item(0)

                    If matriz_memoria Is Nothing Then
                        li_id_informe = li_id_informe
                    Else
                        matriz_memoria.Clear(matriz_memoria, 0, UBound(matriz_memoria) - 1)
                    End If

                    If li_id_informe > 0 Then

                        ' Todo OK.

                        matriz_memoria = Split(Session("memoria"), ",", , CompareMethod.Text)

                        For n = 1 To (UBound(matriz_memoria))

                            str_menu = "dbo.SP_CIMACEX_ALTA_INFORMES_PROPIOS " & matriz_memoria(n) & ",'" & Request("rte" & matriz_memoria(n)) & "', " & CStr(li_id_informe)
                            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                            If objDS.Tables(0).Rows(0).Item(0) > 0 Then
                                lb_error = True
                                n = UBound(matriz_memoria)
                            End If

                        Next

                        Response.Write("<scr" & "ipt>" & vbCrLf)
                        Response.Write("alert('Informe guardado con éxito.');" & vbCrLf)
                        Response.Write("top.window.close();" & vbCrLf)
                        Response.Write("</scr" & "ipt>")

                    Else

                        ' Hay algún error.
                        lb_error = True

                    End If

                Else

                    str_menu = "dbo.SP_CIMACEX_UPDATE_INFORMES_MASTER " & Session("id_informe") & ",'" & Request("cabecera") & "'"
                    objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                    If objDS.Tables(0).Rows(0).Item(0) > 0 Then
                        lb_error = True
                    End If

                End If

                If Request("tipo") = "N" Then

                    'str_menu = "dbo.SP_CIMACEX_ALTA_INFORMES 1,'" & Request("motivo") & "', " & lint_id_informe_master

                Else

                    str_menu = "dbo.SP_CIMACEX_UPDATE_INFORMES " & Session("id_informe") & ",'" & Request("motivo") & "',1"
                    objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                    If objDS.Tables(0).Rows(0).Item(0) > 0 Then
                        lb_error = True
                    End If

                End If

                If Request("tipo") = "N" Then

                    'str_menu = "dbo.SP_CIMACEX_ALTA_INFORMES 2,'" & Request("diagnostico") & "', " & lint_id_informe_master

                Else

                    str_menu = "dbo.SP_CIMACEX_UPDATE_INFORMES " & Session("id_informe") & ",'" & Request("diagnostico") & "',2"
                    objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                    If objDS.Tables(0).Rows(0).Item(0) > 0 Then
                        lb_error = True
                    End If

                End If

                If Request("tipo") = "N" Then

                    'str_menu = "dbo.SP_CIMACEX_ALTA_INFORMES 2,'" & Request("diagnostico") & "', " & lint_id_informe_master

                Else

                    matriz_memoria = Split(Session("memoria"), ",", , CompareMethod.Text)

                    For n = 1 To UBound(matriz_memoria)

                        str_menu = "dbo.SP_CIMACEX_UPDATE_INFORMES " & Session("id_informe") & ",'" & Request("rte" & matriz_memoria(n)) & "'," & matriz_memoria(n)
                        objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                        If objDS.Tables(0).Rows(0).Item(0) > 0 Then
                            lb_error = True
                        End If

                    Next

                End If

                If lb_error = True Then

                    If Request("tipo") = "N" Then

                        ' Borrado de alta.
                        str_menu = "dbo.SP_CIMACEX_ELIMINAR_INFORME_ERRONEO " & CStr(li_id_informe)
                        objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

                    End If

                    objCIMA = Nothing
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Se ha producido un error inespecífico. Por favor, contacte de inmediato con el administrador de la aplicación.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                Else

                    objCIMA = Nothing
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                End If

                Session("id_informe") = "0"
                Session("cabecera") = ""

            End If

        End If

        If Session("id_informe") <> "0" Then

            Me.SqlConnection1.Open()

            Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = CInt(Session("id_informe"))

            Me.SqlDataAdapter1.Fill(Me.Ds_cabecera1.cima_informes_master)

            'Me.cabecera.DataBind()

            Session("cabecera") = Me.Ds_cabecera1.cima_informes_master.Rows(0).Item(0)

            'Me.TextBox1.DataBind()

            Me.SqlConnection1.Close()

        End If



    End Sub


    Public Sub F_Pintar()

        Dim str_menu As String
        Dim str_cadena_creciente As String

        Dim matriz() As String
        Dim array() As String

        Dim n As Integer

        Dim str_option As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        Session("memoria") = "o"
        Session("memoria2") = "o"

        If Len(Trim(Session("id_plantilla"))) > 0 Then

            str_menu = "dbo.SP_CIMACEX_PINTA_CAMPOS " & Session("id_plantilla")

            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            str_cadena_creciente = "<TABLE id=""Tabla"" cellSpacing=""0"" cellPadding=""0"" width=""100%"" border=""0"">"

            For Each objRow In objDS.Tables(0).Rows

                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"
                str_cadena_creciente = str_cadena_creciente & "<TR><TD class=""letra_negrita"">" & objRow.Item(0) & ":</TD></TR>"
                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"

                str_option = ""

                If matriz Is Nothing Then

                Else
                    matriz.Clear(matriz, 0, UBound(matriz) - 1)
                End If

                If array Is Nothing Then

                Else
                    array.Clear(array, 0, UBound(array) - 1)
                End If

                Session("memoria") = Session("memoria") & "," & CStr(objRow.Item(4))
                Session("memoria2") = Session("memoria2") & "," & CStr(objRow.Item(2))

                If objRow.Item(2) = 3 Then

                    matriz = Split(objRow.Item(1), "#", , CompareMethod.Text)
                    array = Split(objRow.Item(3), ",", , CompareMethod.Text)

                    For n = 0 To UBound(array)
                        str_option = str_option & "<option value=""" & "v" & CStr(n + 1) & """>" & array(n) & "</option>"
                    Next

                    str_cadena_creciente = str_cadena_creciente & "<TR><TD>" & matriz(0) & str_option & matriz(1) & "</TD></TR>"

                Else

                    str_cadena_creciente = str_cadena_creciente & "<TR><TD>" & objRow.Item(1) & "</TD></TR>"

                End If

                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"

            Next

            str_cadena_creciente = str_cadena_creciente & "</TABLE>"

        End If

        objRow = Nothing
        objDS = Nothing
        objCIMA = Nothing

        Response.Write(str_cadena_creciente)

    End Sub

    Public Sub F_Pintar_SinPintar()

        Dim str_menu As String
        Dim str_cadena_creciente As String

        Dim matriz() As String
        Dim array() As String

        Dim n As Integer

        Dim str_option As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim objRow As Data.DataRow

        Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

        Session("memoria") = "o"
        Session("memoria2") = "o"

        If Len(Trim(Session("id_plantilla"))) > 0 Then

            str_menu = "dbo.SP_CIMACEX_PINTA_CAMPOS " & Session("id_plantilla")

            objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

            str_cadena_creciente = "<TABLE id=""Tabla"" cellSpacing=""0"" cellPadding=""0"" width=""100%"" border=""0"">"

            For Each objRow In objDS.Tables(0).Rows

                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"
                str_cadena_creciente = str_cadena_creciente & "<TR><TD class=""letra_negrita"">" & objRow.Item(0) & ":</TD></TR>"
                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"

                str_option = ""

                If matriz Is Nothing Then

                Else
                    matriz.Clear(matriz, 0, UBound(matriz) - 1)
                End If

                If array Is Nothing Then

                Else
                    array.Clear(array, 0, UBound(array) - 1)
                End If

                Session("memoria") = Session("memoria") & "," & CStr(objRow.Item(4))
                Session("memoria2") = Session("memoria2") & "," & CStr(objRow.Item(2))

                If objRow.Item(2) = 3 Then

                    matriz = Split(objRow.Item(1), "#", , CompareMethod.Text)
                    array = Split(objRow.Item(3), ",", , CompareMethod.Text)

                    For n = 0 To UBound(array)
                        str_option = str_option & "<option value=""" & "v" & CStr(n + 1) & """>" & array(n) & "</option>"
                    Next

                    str_cadena_creciente = str_cadena_creciente & "<TR><TD>" & matriz(0) & str_option & matriz(1) & "</TD></TR>"

                Else

                    str_cadena_creciente = str_cadena_creciente & "<TR><TD>" & objRow.Item(1) & "</TD></TR>"

                End If

                str_cadena_creciente = str_cadena_creciente & "<TR height=""11""><TD></TD></TR>"

            Next

            str_cadena_creciente = str_cadena_creciente & "</TABLE>"

        End If

        objRow = Nothing
        objDS = Nothing
        objCIMA = Nothing

        'Response.Write(str_cadena_creciente)

    End Sub

    Public Sub F_Pintar_Hidden()

        Dim matriz_memoria() As String

        Dim n As Integer

        matriz_memoria = Split(Session("memoria"), ",", , CompareMethod.Text)

        For n = 1 To (UBound(matriz_memoria))

            Response.Write("<input type=""hidden"" name=""rte" & matriz_memoria(n) & """>")

        Next

    End Sub

    Public Sub F_Pintar_Enviar()

        Dim matriz_memoria() As String
        Dim matriz_memoria2() As String

        Dim contador As Integer

        contador = 0

        Dim n As Integer

        F_Pintar_SinPintar()

        matriz_memoria = Split(Session("memoria"), ",", , CompareMethod.Text)
        matriz_memoria2 = Split(Session("memoria2"), ",", , CompareMethod.Text)

        For n = 1 To (UBound(matriz_memoria))

            If matriz_memoria2(n) = 1 Then
                contador = contador + 1
                Response.Write("var oRTE" & CStr(contador) & " = document.frames[" & CStr(contador) & "].document.body;")
                Response.Write("informe.rte" & matriz_memoria(n) & ".value=escape(oRTE" & CStr(contador) & ".innerHTML);")
            ElseIf matriz_memoria2(n) = 3 Then
                Response.Write("informe.rte" & matriz_memoria(n) & ".value=document.getElementById(""rte" & matriz_memoria(n) & """).value;")
                'Response.Write("alert(document.getElementById(""rte" & matriz_memoria(n) & """).value);")
                'ElseIf matriz_memoria2(n) = 4 Then
                'Response.Write("informe.rte" & matriz_memoria(n) & ".value=escape(f_sustitucion_textarea_br(document.getElementById(""rte" & matriz_memoria(n) & """).value));")
                'Response.Write("alert(document.getElementById(""rte" & matriz_memoria(n) & """).value);")
            Else
                Response.Write("informe.rte" & matriz_memoria(n) & ".value=document.getElementById(""rte" & matriz_memoria(n) & """).value;")
            End If

        Next

        contador = contador + 1

        Response.Write("var oRTE" & CStr(contador) & " = document.frames[" & CStr(contador) & "].document.body;")
        Response.Write("informe.diagnostico.value=escape(oRTE" & CStr(contador) & ".innerHTML);")

    End Sub

End Class
