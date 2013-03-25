<%@ Page Language="vb" AutoEventWireup="false" Codebehind="pie.aspx.vb" Inherits="zeus.pie"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>pie</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE class='<%
			select case Session("grupo") 
			case "D" 
			Response.Write("fondo_pie_d") 
			case "M" 
			Response.Write("fondo_pie") 
			case "A" 
			Response.Write("fondo_pie_a") 
			case "U" 
			Response.Write("fondo_pie_u")
			case "G" 
			Response.Write("fondo_pie_u")
			case "E"
			Response.Write("fondo_pie_e")
			case "W" 
			Response.Write("fondo_pie_u")
			case "I" 
			Response.Write("fondo_pie_u")			
			case "L" 
			Response.Write("fondo_pie_l")			
			end select
			%>' id="Table1" style="Z-INDEX: 101; POSITION: absolute" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD align="right" height="22" style="PADDING-RIGHT: 11px">Centro Internacional de 
						Medicina Avanzada (CIMA)</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
