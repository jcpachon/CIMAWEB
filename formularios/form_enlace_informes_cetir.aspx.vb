Public Class form_enlace_informes_cetir
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Ds_movil1 = New cimaweb.ds_movil
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Ds_numero1 = New cimaweb.ds_numero
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        CType(Me.Ds_movil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_numero1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_EPIS_INFORMES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[SP_CIMACEX_ALTA_EPIS_INFORMES]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 50))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episodio", System.Data.SqlDbType.VarChar, 50))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@path", System.Data.SqlDbType.VarChar, 150))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_ALTA_INFORMES_CETIR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_ALTA_INFORMES_CETIR]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CIMACEX;password=kampeon10"
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("movil_paciente", "movil_paciente")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CSaludR.[reporting].f_cima_paciente_telefono_movil(CSaludR.[reporting].f_c" & _
        "ima_paciente_pers_key(epis_key)) AS movil_paciente, clave_sms FROM cima_epis_cla" & _
        "ves WHERE (episcode = @episcode) AND (envio_sms = 'N') AND (CSaludR.[reporting]." & _
        "f_cima_paciente_telefono_movil(CSaludR.[reporting].f_cima_paciente_pers_key(epis" & _
        "_key)) IS NOT NULL)"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'Ds_movil1
        '
        Me.Ds_movil1.DataSetName = "ds_movil"
        Me.Ds_movil1.EnforceConstraints = False
        Me.Ds_movil1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMA_ALTA_INFORME_EGARSAT", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")}), New System.Data.Common.DataTableMapping("Table1", "Table1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[SP_CIMA_ALTA_INFORME_EGARSAT]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection3
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11))
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=jupiter;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("numero", "numero")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT COUNT(*) AS numero FROM cima_epis_informes WHERE (episcode = @episcode)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@episcode", System.Data.SqlDbType.VarChar, 11, "episcode"))
        '
        'Ds_numero1
        '
        Me.Ds_numero1.DataSetName = "ds_numero"
        Me.Ds_numero1.EnforceConstraints = False
        Me.Ds_numero1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_B", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "[SP_B]"
        Me.SqlSelectCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fichero", System.Data.SqlDbType.VarChar, 250))
        CType(Me.Ds_movil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_numero1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Protected WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_movil1 As cimaweb.ds_movil
    Protected WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Button3 As System.Web.UI.WebControls.Button
    Protected WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Protected WithEvents Ds_numero1 As cimaweb.ds_numero
    Protected WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand

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

        Dim di As New System.IO.DirectoryInfo(Server.MapPath("../ftp_cetir"))

        ' Get a reference to each file in that directory.
        Dim fiArr As System.IO.FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As System.IO.FileInfo

        Dim ls_array() As String
        Dim ls_array_2() As String

        Dim li_dim_array As Integer

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim ls_e_mail As String

        'JGM Modificació 27/02 Moure els arxius carregats
        Dim destino As String

        If Request("spid") = "15121971" Then

            Session("spid") = Request("spid")

            For Each fri In fiArr

                'Response.Write(fri.Name & "<br>")
                ls_array = Split(fri.Name, "_")

                If ls_array.Length() >= 2 Then

                    li_dim_array = UBound(ls_array)

                    ls_array_2 = Split(ls_array(li_dim_array), ".")

                    If ls_array_2.Length() = 2 And Len(ls_array_2(0)) >= 11 Then

                        'Response.Write(ls_array(1) & ": " & ls_array_2(0) & "<br>")
                        Carga_PDF(ls_array_2(0), fri.Name)

                        'JGM Modificació 27/02 Moure els arxius carregats
                        destino = "\\10.8.50.60\ftp\ftp_cetir_old\" & fri.Name

                        'Esborrem l'arxiu per si existeix
                        System.IO.File.Delete(destino)

                        fri.MoveTo(destino)


                        ' Envío de e-mail a EGARSAT cuando llega el informe de algún mutualista.

                        Me.SqlDataAdapter4.SelectCommand.Parameters(1).Value = ls_array_2(0)

                        Me.SqlConnection3.Open()

                        Me.SqlDataAdapter4.SelectCommand.ExecuteNonQuery()

                        Me.SqlConnection3.Close()

                        ' Fin envío de e-mail a EGARSAT cuando llega el informe de algún mutualista.

                        ' Envío de SMS al paciente para avisar de la disponibilidad del informe.

                        'If ls_array_2(0) = "2009L030735" Then

                        Me.Ds_movil1.movil.Clear()

                        Me.SqlDataAdapter3.SelectCommand.Parameters(0).Value = ls_array_2(0)

                        Me.SqlConnection2.Open()

                        Me.SqlDataAdapter3.Fill(Me.Ds_movil1.movil)

                        Me.SqlConnection2.Close()

                        If Me.Ds_movil1.movil.Rows.Count > 0 Then

                            If Len(Trim(Me.Ds_movil1.movil.Rows(0).Item("movil_paciente"))) > 0 Then

                                Envio_SMS(Me.Ds_movil1.movil.Rows(0).Item("movil_paciente"), ls_array_2(0), Me.Ds_movil1.movil.Rows(0).Item("clave_sms"))

                            End If

                        End If

                        'End If

                        ' Fin del envío de SMS al paciente para avisar de la disponibilidad del informe.

                    End If

                        'Response.Write(ls_array(1) & "<br>")

                    Else
                    'Response.Write("MAL:   " & cstr(ls_array.Length()) & " ; " & fri.Name & "<br>")
                End If


            Next fri

        End If

    End Sub

    Private Sub Envio_SMS(ByVal movil_paciente As String, ByVal episcode As String, ByVal clave_sms As String)

        Dim x As New MSXML2.DOMDocument
        Dim h As New MSXML2.XMLHTTP

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim str_sql As String

        Dim n As Integer



        x.loadXML("<soap-env:Envelope xmlns:soap-env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        "<soap-env:Header>" & _
        "<vodh:VODHeader xmlns:vodh=""http://www.vodafone.com/soap/header/"">" & _
        "<vodh:commandId>ServiceDelivery</vodh:commandId>" & _
        "<vodh:authentication>" & _
        "<vodh:username>cimaclinic</vodh:username>" & _
        "<vodh:password>cLm4cL</vodh:password>" & _
        "</vodh:authentication>" & _
        "<vodh:service>" & _
        "<vodh:serviceID>63900001</vodh:serviceID>" & _
        "<vodh:serviceType>SMS</vodh:serviceType>" & _
        "</vodh:service>" & _
        "</vodh:VODHeader>" & _
        "</soap-env:Header>" & _
        "<soap-env:Body>" & _
        "<vodb:VODBody xmlns:vodb=""http://www.vodafone.com/soap/body/"" version=""1.0""> <vodb:contextID /> " & _
        "<vodb:destAddress>34" & Trim(movil_paciente) & "</vodb:destAddress>" & _
        "<vodb:subServiceId>100600124343</vodb:subServiceId>" & _
        "<vodb:messageBody>Su informe con código " & episcode & " está preparado para ser descargado a través de nuestro portal www.cimaclinic.com. Clave: " & clave_sms & "</vodb:messageBody>" & _
        "<vodb:bodyIsText>true</vodb:bodyIsText>" & _
        "<vodb:deliveryReport>true</vodb:deliveryReport>" & _
        "<vodb:priorityFlag>0</vodb:priorityFlag>" & _
        "<vodb:validityPeriod />" & _
        "<vodb:dataCodingScheme>0</vodb:dataCodingScheme>" & _
        "<vodb:sourceTON>5</vodb:sourceTON>" & _
        "<vodb:destTON>1</vodb:destTON>" & _
        "<vodb:sourceNPI>0</vodb:sourceNPI>" & _
        "<vodb:destNPI>1</vodb:destNPI>" & _
        "<vodb:esmClass>0</vodb:esmClass>" & _
        "<vodb:protocolId>0</vodb:protocolId>" & _
        "<vodb:scheduleDeliveryTime />" & _
        "</vodb:VODBody>" & _
        "</soap-env:Body>" & _
        "</soap-env:Envelope>")

        h.open("POST", "http://serv.cdm.vodafone.es/soap/SOAPSMS")
        h.send(x)
        While h.readyState <> 4
        End While

        str_sql = "dbo.SP_UPDATE_ENVIO_SMS '" & episcode & "','" & h.statusText & "'"

        'response.write (str_menu)

        objDS = objCIMA.f_consulta_CSaludR(str_sql, "DATABASE=CIMACEX;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

    End Sub

    Private Sub Carga_PDF(ByVal episcode As String, ByVal nombre_file As String)

        Dim str_uid As String
        'Dim str_sesion_id As String

        Dim ls_array() As String



        ls_array = Split(episcode, "-")

        'str_uid = Request.Cookies("usuario").Value

        Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = "cetir.carga" 'str_uid
        Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = episcode
        Me.SqlDataAdapter1.SelectCommand.Parameters(3).Value = "\\10.8.50.60\ftp\ftp_cetir\" & nombre_file

        Me.SqlConnection1.Open()
        Me.SqlDataAdapter1.SelectCommand.ExecuteNonQuery()
        Me.SqlConnection1.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim di As New System.IO.DirectoryInfo(Server.MapPath("../ftp_cetir/H"))
        ' Get a reference to each file in that directory.
        Dim fiArr As System.IO.FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As System.IO.FileInfo

        Dim ls_array() As String
        Dim ls_array_2() As String

        Dim li_dim_array As Integer



        'If Session("spid") = "15121971" Then

        For Each fri In fiArr

            'Response.Write(fri.Name & "<br>")
            ls_array = Split(fri.Name, "_")

            If ls_array.Length() >= 2 Then

                li_dim_array = UBound(ls_array)

                ls_array_2 = Split(ls_array(li_dim_array), ".")

                If ls_array_2.Length() = 2 And Len(ls_array_2(0)) = 11 Then

                    'Response.Write(ls_array(1) & ": " & ls_array_2(0) & "<br>")
                    'Carga_PDF(ls_array_2(0), fri.Name)
                    Me.SqlDataAdapter2.SelectCommand.Parameters(1).Value = ls_array_2(0)

                    Me.SqlConnection2.Open()
                    Me.SqlDataAdapter2.SelectCommand.ExecuteNonQuery()
                    Me.SqlConnection2.Close()

                End If

                'Response.Write(ls_array(1) & "<br>")

            Else
                'Response.Write("MAL:   " & cstr(ls_array.Length()) & " ; " & fri.Name & "<br>")
            End If


        Next fri

        'End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ls_a As String



        ls_a = "W"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim di As New System.IO.DirectoryInfo(Server.MapPath("../ftp_cetir_old"))

        ' Get a reference to each file in that directory.
        Dim fiArr As System.IO.FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As System.IO.FileInfo

        Dim ls_array() As String
        Dim ls_array_2() As String

        Dim li_dim_array As Integer

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim ls_e_mail As String



        For Each fri In fiArr

            ls_array = Split(fri.Name, "_")

            If ls_array.Length() >= 2 Then

                li_dim_array = UBound(ls_array)

                ls_array_2 = Split(ls_array(li_dim_array), ".")

                If ls_array_2.Length() = 2 And Len(ls_array_2(0)) >= 11 Then

                    'Carga_PDF(ls_array_2(0), fri.Name)

                    Me.SqlDataAdapter5.SelectCommand.Parameters(0).Value = ls_array_2(0)
                    Me.SqlConnection2.Open()
                    Me.SqlDataAdapter5.Fill(Me.Ds_numero1.numero)
                    Me.SqlConnection2.Close()

                    If Me.Ds_numero1.numero.Rows.Count > 0 Then

                        If Me.Ds_numero1.numero.Rows(0).Item("numero") > 0 Then

                            str_menu = str_menu

                        Else

                            Me.SqlDataAdapter6.SelectCommand.Parameters(1).Value = fri.Name
                            Me.SqlConnection2.Open()
                            Me.SqlDataAdapter6.SelectCommand.ExecuteNonQuery()
                            Me.SqlConnection2.Close()

                            'REGISTRO!!!

                        End If

                    Else

                        Me.SqlDataAdapter6.SelectCommand.Parameters(1).Value = fri.Name
                        Me.SqlConnection2.Open()
                        Me.SqlDataAdapter6.SelectCommand.ExecuteNonQuery()
                        Me.SqlConnection2.Close()
                        'REGISTRO!!!

                    End If

                Else

                    Me.SqlDataAdapter6.SelectCommand.Parameters(1).Value = fri.Name
                    Me.SqlConnection2.Open()
                    Me.SqlDataAdapter6.SelectCommand.ExecuteNonQuery()
                    Me.SqlConnection2.Close()
                    'REGISTRO!!!

                End If

            Else

                Me.SqlDataAdapter6.SelectCommand.Parameters(1).Value = fri.Name
                Me.SqlConnection2.Open()
                Me.SqlDataAdapter6.SelectCommand.ExecuteNonQuery()
                Me.SqlConnection2.Close()
                'REGISTRO!!!

            End If


        Next fri

    End Sub

End Class
