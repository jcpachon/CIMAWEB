Imports System.Web.Services

<System.Web.Services.WebService(Namespace := "http://tempuri.org/CIMA_Servicios/Service1")> _
Public Class Service1
    Inherits System.Web.Services.WebService

#Region " Código generado por el Diseñador de servicios Web "

    Public Sub New()
        MyBase.New()

        'El Diseñador de servicios Web requiere esta llamada.
        InitializeComponent()

        'Agregar su propio código de inicialización después de llamar a InitializeComponent()

    End Sub

    'Requerido por el Diseñador de servicios Web
    Private components As System.ComponentModel.IContainer

    'NOTE: el Diseñador de servicios Web requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de servicios Web. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: el Diseñador de servicios Web requiere este procedimiento
        'No lo modifique con el editor de código.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' EJEMPLO DE SERVICIO WEB
    ' El servicio de ejemplo HelloWorld() devuelve la cadena Hello World.
    ' Para generar, quite los comentarios de las siguientes líneas y, a continuación, guarde y genere el proyecto.
    ' Para probar este servicio Web, compruebe que la página de inicio es el archivo .asmx
    ' y presione F5.
    '
    <WebMethod()> Public Function IsAuthenticated(ByVal domain As String, ByVal username As String, ByVal pwd As String) As Boolean

        Dim domainAndUsername As String

        domainAndUsername = domain + "\" + username

        Dim entry As New DirectoryServices.DirectoryEntry("LDAP://DC=cima,DC=net", domainAndUsername, pwd)

        Try

            Dim obj As Object

            ' Bind to the native AdsObject to force authentication. 
            'obj = entry.NativeObject

            Dim search As New DirectoryServices.DirectorySearcher(entry)


            search.Filter = "(SAMAccountName=" + username + ")"
            search.PropertiesToLoad.Add("cn")

            If (search.FindAll.Count >= 1) Then
                IsAuthenticated = True
            Else
                IsAuthenticated = False
            End If

        Catch

            IsAuthenticated = False

        End Try



    End Function

    <WebMethod()> Public Function ChangePassword(ByVal domain As String, ByVal username As String, ByVal pwd_old As String, ByVal pwd_new As String) As Boolean

        Dim domainAndUsername As String

        Dim ls_script As String


        domainAndUsername = domain + "\" + username

        Dim entry As New DirectoryServices.DirectoryEntry("LDAP://DC=cima,DC=net", domainAndUsername, pwd_old)

        ChangePassword = True

        ls_script = "Const ADS_UF_DONT_EXPIRE_PASSWD = &h10000" & vbCrLf & _
                                    "Dim objCommand, objConnection, strBase, strFilter, strAttributes" & vbCrLf & _
                                    "Dim strQuery, objRecordset, strName, strCN, strPP" & vbCrLf & _
                                    "set objCommand = CreateObject(""ADODB.Command"")" & vbCrLf & _
                                    "set objConnection = CreateObject(""ADODB.Connection"")" & vbCrLf & _
                                    "objConnection.Provider = ""ADsDSOObject""" & vbCrLf & _
                                    "objConnection.Open ""Active Directory Provider""" & vbCrLf & _
                                    "objCommand.ActiveConnection = objConnection" & vbCrLf & _
                                    "strBase = ""<LDAP://dc=cima,dc=net>""" & vbCrLf & _
                                    "strFilter = ""(&(objectCategory=person)(objectClass=user))""" & vbCrLf & _
                                    "strAttributes = ""sAMAccountName,cn,distinguishedName """ & vbCrLf & _
                                    "strQuery = strBase & "";"" & strFilter & "";"" & strAttributes & "";subtree""" & vbCrLf & _
                                    "objCommand.CommandText = strQuery" & vbCrLf & _
                                    "objCommand.Properties(""Page Size"") = 100" & vbCrLf & _
                                    "objCommand.Properties(""Timeout"") = 30" & vbCrLf & _
                                    "objCommand.Properties(""Cache Results"") = False" & vbCrLf & _
                                    "set objRecordset = objCommand.Execute" & vbCrLf & _
                                    "Do Until objRecordset.EOF" & vbCrLf & _
                                        "strName = objRecordset.Fields(""sAMAccountName"").Value" & vbCrLf & _
                                        "If LCase(strName) = """ & username & """ Then" & vbCrLf & _
                                            "set objUser = GetObject(""LDAP://"" & objRecordset.Fields(""distinguishedName""))" & vbCrLf & _
                                            "objUser.ChangePassword """ & pwd_old & """, """ & pwd_new & """" & vbCrLf & _
                                            "intUAC = objUser.Get(""userAccountControl"") " & vbCrLf & _
                                        "End If" & vbCrLf & _
                                        "objRecordset.MoveNext()" & vbCrLf & _
                                    "Loop" & vbCrLf & _
                                    "objConnection.Close()"

        Dim C As New MSScriptControl.ScriptControl
        C.Timeout = -1
        Try
            C.Language = "VBScript"
            'Using 'This' enable me to communicate from vbscript with the winform 
            C.AddObject("This", Me)
            'Textbox1.text is a mutliline textbox with the vbscript code. 
            C.ExecuteStatement(ls_script)
            'Return True
        Catch Er As Exception

            ChangePassword = False
            'Return False
        Finally
            'MsgBox("Code Run Completed..." & Now)
        End Try



    End Function

End Class
