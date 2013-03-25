Public Class form_envio_sms
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button

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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x As New MSXML2.DOMDocument
        Dim h As New MSXML2.XMLHTTP

        Dim n As Integer

        Dim ws_snt As New srweblogic01.enviaParams
        Dim ws_snt_sms As New srweblogic01.WsSanitasService



        ws_snt.funcionalidad = 82
        ws_snt.telefono = CInt(Trim(Me.TextBox1.Text))
        ws_snt.texto = Me.TextBox2.Text

        ws_snt_sms.enviaConTexto(ws_snt)

        'x.loadXML("<soap-env:Envelope xmlns:soap-env=""http://schemas.xmlsoap.org/soap/envelope/"">" & _
        '"<soap-env:Header>" & _
        '"<vodh:VODHeader xmlns:vodh=""http://www.vodafone.com/soap/header/"">" & _
        '"<vodh:commandId>ServiceDelivery</vodh:commandId>" & _
        '"<vodh:authentication>" & _
        '"<vodh:username>cimaclinic</vodh:username>" & _
        '"<vodh:password>cLm4cL</vodh:password>" & _
        '"</vodh:authentication>" & _
        '"<vodh:service>" & _
        '"<vodh:serviceID>63900001</vodh:serviceID>" & _
        '"<vodh:serviceType>SMS</vodh:serviceType>" & _
        '"</vodh:service>" & _
        '"</vodh:VODHeader>" & _
        '"</soap-env:Header>" & _
        '"<soap-env:Body>" & _
        '"<vodb:VODBody xmlns:vodb=""http://www.vodafone.com/soap/body/"" version=""1.0""> <vodb:contextID /> " & _
        '"<vodb:destAddress>34" & Trim(Me.TextBox1.Text) & "</vodb:destAddress>" & _
        '"<vodb:subServiceId>100600124343</vodb:subServiceId>" & _
        '"<vodb:messageBody>" & Me.TextBox2.Text & "</vodb:messageBody>" & _
        '"<vodb:bodyIsText>true</vodb:bodyIsText>" & _
        '"<vodb:deliveryReport>true</vodb:deliveryReport>" & _
        '"<vodb:priorityFlag>0</vodb:priorityFlag>" & _
        '"<vodb:validityPeriod />" & _
        '"<vodb:dataCodingScheme>0</vodb:dataCodingScheme>" & _
        '"<vodb:sourceTON>5</vodb:sourceTON>" & _
        '"<vodb:destTON>1</vodb:destTON>" & _
        '"<vodb:sourceNPI>0</vodb:sourceNPI>" & _
        '"<vodb:destNPI>1</vodb:destNPI>" & _
        '"<vodb:esmClass>0</vodb:esmClass>" & _
        '"<vodb:protocolId>0</vodb:protocolId>" & _
        '"<vodb:scheduleDeliveryTime />" & _
        '"</vodb:VODBody>" & _
        '"</soap-env:Body>" & _
        '"</soap-env:Envelope>")

        'h.open("POST", "http://serv.cdm.vodafone.es/soap/SOAPSMS")
        'h.send(x)
        'While h.readyState <> 4
        'End While

    End Sub

End Class
