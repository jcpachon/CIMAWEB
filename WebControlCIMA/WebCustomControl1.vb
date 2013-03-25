Imports System.ComponentModel
Imports System
Imports System.Web.UI
Imports System.Drawing
Imports System.Globalization
Imports System.Web
Imports System.Web.UI.WebControls

Namespace Buttons
    <DefaultProperty("Text"), ToolboxData("<{0}:ButtonEnviar runat=server></{0}:ButtonEnviar>")> Public Class ButtonEnviar
        Inherits System.Web.UI.WebControls.Button

        Public _VstrTexoEnviando As String

        <Bindable(True), Category("Appearance"), DefaultValue("Enviando..."), Description("enviar")> Public Shadows Property [Text]() As String
            Get
                Return _VstrTexoEnviando
            End Get
            Set(ByVal Value As String)
                _VstrTexoEnviando = Value
            End Set
        End Property

        'Public Property TextoEnviando() As String
        ' Get
        ' Return _VstrTexoEnviando
        ' End Get
        ' Set(ByVal Value As String)
        ' _VstrTexoEnviando = Value
        ' End Set
        'End Property
        Protected Overrides Sub Render(ByVal output As System.Web.UI.HtmlTextWriter)
            'Creamos el panel donde va el botón principal
            output.Write("<div id='div1_" & ID & "' style='display: inline'>")
            output.AddAttribute("onclick", "Enviar_" & ID & "('" & ID & "');")
            output.AddAttribute("value", _VstrTexoEnviando)
            MyBase.Render(output)
            output.Write("</div>")

            'Creamos el panel y el botón secundario de envío
            output.Write("<div class='letra_negrita' id='div2_" & ID & "' style='display: none'>")
            output.Write("<img src=""wait.gif"">&nbsp;&nbsp;ENVIANDO...&nbsp;&nbsp;<!--input disabled type=submit value='" & _VstrTexoEnviando & "' /-->")
            output.Write("</div>")
        End Sub
        Private Function FuncionEnviarBoton() As String
            Dim txt As String = "<script language='javascript'> "
            txt &= " function Enviar_" & ID & "(id) { "
            txt &= " if (typeof(Page_ClientValidate) == 'function') {"
            txt &= " if (Page_ClientValidate() == true ) { "
            txt &= " document.getElementById('div1_' + id).style.display = 'none'; "
            txt &= " document.getElementById('div2_' + id).style.display ='inline'; "
            txt &= " return true; "
            txt &= " } "
            txt &= " else { "
            txt &= " return false; "
            txt &= " } "
            txt &= " } "
            txt &= " else { "
            txt &= " document.getElementById('div1_' + id).style.display = 'none'; "
            txt &= " document.getElementById('div2_' + id).style.display = 'inline'; "
            txt &= " return true; "
            txt &= " }"
            txt &= " }"
            txt &= " </script>"

            Return txt
        End Function

        Protected Overrides Sub onInit(ByVal e As EventArgs)
            'Me.Text = "Enviar"
            Me.CausesValidation = False
        End Sub
        Protected Overrides Sub onPrerender(ByVal e As EventArgs)
            'Registramos la función de envío del botón
            Page.RegisterClientScriptBlock("fEnviar_" & ID, FuncionEnviarBoton())
            MyBase.OnPreRender(e)
        End Sub
    End Class
End Namespace
