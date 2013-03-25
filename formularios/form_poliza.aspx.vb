Public Class form_poliza
    Inherits System.Web.UI.Page

#Region " C�digo generado por el Dise�ador de Web Forms "

    'El Dise�ador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Ds_poliza1 = New cimaweb.ds_poliza
        CType(Me.Ds_poliza1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CIMACEX_RECUPERA_NUMERO_POLIZA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Column1", "Column1"), New System.Data.Common.DataColumnMapping("Column2", "Column2"), New System.Data.Common.DataColumnMapping("Column3", "Column3")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SP_CIMACEX_RECUPERA_NUMERO_POLIZA]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@epis_key", System.Data.SqlDbType.Int, 4))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MINERVA;packet size=4096;user id=sa;data source=JUPITER;persist se" & _
        "curity info=True;initial catalog=CSaludR;password=kampeon10"
        '
        'Ds_poliza1
        '
        Me.Ds_poliza1.DataSetName = "ds_poliza"
        Me.Ds_poliza1.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.Ds_poliza1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Protected WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Protected WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Protected WithEvents Ds_poliza1 As cimaweb.ds_poliza

    'NOTA: el Dise�ador de Web Forms necesita la siguiente declaraci�n del marcador de posici�n.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Dise�ador de Web Forms requiere esta llamada de m�todo
        'No la modifique con el editor de c�digo.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aqu� el c�digo de usuario para inicializar la p�gina

        If IsPostBack = False Then
            'Recuperem el n�mero de p�lissa per a aquest episodi.
            Me.SqlConnection1.Open()
            Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Session("episkey")
            Me.SqlDataAdapter1.Fill(Me.Ds_poliza1.poliza)

            Me.SqlConnection1.Close()

            ' En el label1 pondremos la mutua (firm_key)
            Me.Label1.Text = Me.Ds_poliza1.poliza.Rows(0).Item("firm_key")

            If Len(Trim(Me.Ds_poliza1.poliza.Rows(0).Item("episfirmassu"))) > 0 Then
                Me.TextBox1.Text = Trim(Me.Ds_poliza1.poliza.Rows(0).Item("episfirmassu"))
            Else
                Me.TextBox1.Text = Trim(Me.Ds_poliza1.poliza.Rows(0).Item("patifirmassu"))
            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str_menu As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        'Validacions para mutua MGC
        If Me.Label1.Text = 1803 Then
            'Validem que sigui num�ric
            If IsNumeric(Me.TextBox1.Text) Then
                'Validem la longitud del textbox
                If Me.TextBox1.Text.Length <> 15 Then
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('Longitud incorrecta.\n(15 caracteres num�ricos).');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")
                Else
                    ' Si �s tot correcte, actualitzarem el n�mero de p�lissa de l'episodi.

                    str_menu = "dbo.SP_CIMACEX_UPDATE_POLIZA_EPISODIO " & Session("episkey") & "," & Me.Label1.Text & ",'" & Me.TextBox1.Text & "'"

                    objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft� Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

                    'Donem l'av�s de tot correcte
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("alert('N�mero de p�liza guardado con �xito.');" & vbCrLf)
                    Response.Write("</scr" & "ipt>")

                    ' Tanquem la finestra
                    Response.Write("<scr" & "ipt>" & vbCrLf)
                    Response.Write("window.close();" & vbCrLf)
                    Response.Write("</scr" & "ipt>")
                End If
            Else
                Response.Write("<scr" & "ipt>" & vbCrLf)
                Response.Write("alert('El n�mero de p�liza ha de ser num�rico.');" & vbCrLf)
                Response.Write("</scr" & "ipt>")
            End If
        Else
            ' Si �s tot correcte, actualitzarem el n�mero de p�lissa de l'episodi.

            str_menu = "dbo.SP_CIMACEX_UPDATE_POLIZA_EPISODIO " & Session("episkey") & "," & Me.Label1.Text & ",'" & Me.TextBox1.Text & "'"

            objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft� Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")

            'Donem l'av�s de tot correcte
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("alert('N�mero de p�liza guardado con �xito.');" & vbCrLf)
            Response.Write("</scr" & "ipt>")

            ' Tanquem la finestra
            Response.Write("<scr" & "ipt>" & vbCrLf)
            Response.Write("window.close();" & vbCrLf)
            Response.Write("</scr" & "ipt>")
        End If

        
    End Sub
End Class
