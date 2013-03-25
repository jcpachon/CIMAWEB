<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_enlace_informes_cetir.aspx.vb" Inherits="cimaweb.form_enlace_informes_cetir" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_enlace_informes_cetir</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<input type="hidden" name="mp">
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server"
				Text="Comprobar" Width="150px"></asp:button><asp:button id="Button3" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 232px" runat="server"
				Text="CETIR" Width="150px"></asp:button>
			<asp:Button id="Button2" style="Z-INDEX: 102; LEFT: 88px; POSITION: absolute; TOP: 128px" runat="server"
				Text="A" Width="150px"></asp:Button>
			<INPUT style="Z-INDEX: 104; LEFT: 408px; POSITION: absolute; TOP: 240px" type="button"
				value="Abrir ventana" onclick="javascript: var datos = showModalDialog('form_medico_prescriptor.aspx',datos,'status:no;resizable:no;dialogheight:160px;dialogwidth:450px'); Form1.mp.value = datos; ">
			<% 
		
		Dim di As New System.IO.DirectoryInfo(Server.MapPath("../ftp_cetir"))
        ' Get a reference to each file in that directory.
        Dim fiArr As System.IO.FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As System.IO.FileInfo

        Dim ls_array() As String
        Dim ls_array_2() As String



        For Each fri In fiArr

            'Response.Write(fri.Name & "<br>")
            ls_array = Split(fri.Name, "_")
            
            If ls_array.Length() = 2 Then
            
				ls_array_2 = Split(ls_array(1), ".")
				
				'if ls_array_2.Length() = 2 and len(ls_array_2(0)) = 11 Then
				
					'Response.Write(ls_array(1) & ": " & ls_array_2(0) & "<br>")
				
				'end if
				
                'Response.Write(ls_array(1) & "<br>")
                
            Else
                'Response.Write("MAL:   " & cstr(ls_array.Length()) & " ; " & fri.Name & "<br>")
            End If


        Next fri
        
        %>
			<INPUT style="Z-INDEX: 105; LEFT: 496px; POSITION: absolute; TOP: 296px" type="button"
				value="Valor MP" onclick="javascript: alert(Form1.mp.value);"></form>
	</body>
</HTML>
