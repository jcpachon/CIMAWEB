<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm1.aspx.vb" Inherits="zeus.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<script type="text/javascript">
	
	function citar(id_cita){
	
	formulario_citar.id_cita.value=id_cita;
	formulario_citar.submit();
	
	}
	
		</script>
		<form name="formulario_citar">
			<input type="hidden" name="envio_cita" value="S"> <input type="hidden" name="id_cita">
		</form>
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="DataGrid1" style="Z-INDEX: 101; LEFT: 48px; POSITION: absolute; TOP: 136px"
				runat="server"></asp:DataGrid>
			<%
			
			'Private service As New CIMAServeiIntegracio.ServeiIntegracio

			Dim n As Integer
			
			
			
			if Me.DataGrid1.Items.Count() > 0 then
        
			%>
			<TABLE id="Table1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD>N</TD>
					<TD>Hora</TD>
					<TD>Duración</TD>
				</TR>
				<%
				
				For n = 0 To Me.DataGrid1.Items.Count() - 1
				
				%>
				<TR>
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD><INPUT type="button" value="CITAR" onclick="javascript:citar('<% =cstr(n) %>');"></TD>
					<TD><% =Me.DataGrid1.Items(n).Cells(2).Text() %></TD>
					<TD><% =Me.DataGrid1.Items(n).Cells(3).Text() %></TD>
				</TR>
				<%
				
				next
				
				%>
			</TABLE>
			<%
			
			end if
			
			%>
			<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 96px" runat="server"
				Text="Huecos" Width="150px"></asp:Button>
		</form>
	</body>
</HTML>
