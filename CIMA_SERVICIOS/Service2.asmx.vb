Imports System.Web.Services

<System.Web.Services.WebService(Namespace := "http://tempuri.org/CIMA_Servicios/Service2")> _
Public Class Service2
    Inherits System.Web.Services.WebService

#Region " C�digo generado por el Dise�ador de servicios Web "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de servicios Web requiere esta llamada.
        InitializeComponent()

        'Agregar su propio c�digo de inicializaci�n despu�s de llamar a InitializeComponent()

    End Sub

    'Requerido por el Dise�ador de servicios Web
    Private components As System.ComponentModel.IContainer

    'NOTE: el Dise�ador de servicios Web requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de servicios Web. 
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: el Dise�ador de servicios Web requiere este procedimiento
        'No lo modifique con el editor de c�digo.
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
    ' Para generar, quite los comentarios de las siguientes l�neas y, a continuaci�n, guarde y genere el proyecto.
    ' Para probar este servicio Web, compruebe que la p�gina de inicio es el archivo .asmx
    ' y presione F5.
    '
    <WebMethod()> Public Function HelloWorld() As String
        HelloWorld = "Hello World"
    End Function

End Class
