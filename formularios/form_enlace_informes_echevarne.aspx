<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_enlace_informes_echevarne.aspx.vb" Inherits="cimaweb.form_enlace_informes_echevarne" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_enlace_informes_echevarne</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server"
				Width="150px" Text="Comprobar"></asp:button>
			<% 
		
		Dim di As New System.IO.DirectoryInfo(Server.MapPath("../ftp_echevarne"))
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
		</form>
	</body>
</HTML>
