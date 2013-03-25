<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_poliza.aspx.vb" Inherits="cimaweb.form_poliza" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Número de Póliza</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 8px; LEFT: 8px" id="Table1" border="0"
				cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD class="cabecera_formulario" height="22" colSpan="5">Número de Póliza</TD>
				</TR>
				<TR>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11" width="11"><asp:textbox id="TextBox1" runat="server" CssClass="letra_pequena"></asp:textbox></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11" width="11"><asp:label style="Z-INDEX: 0" id="Label1" runat="server" Visible="False">mutua</asp:label></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11" width="11"><asp:button id="Button1" runat="server" CssClass="letra_pequena" Text="Aceptar" Width="150px"></asp:button></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
