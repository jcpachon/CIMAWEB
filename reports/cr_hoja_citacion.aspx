<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="cr_hoja_citacion.aspx.vb" Inherits="zeus.cr_hoja_citacion" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Hoja de Citación</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table2" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD vAlign="top" align="left" colSpan="4" height="60">
						<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
							<TR>
								<TD vAlign="middle" align="center" width="1"></TD>
								<TD vAlign="middle" align="center" width="1"></TD>
								<TD vAlign="middle" align="center" width="1"></TD>
								<TD vAlign="middle" align="center" width="90">
									<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="../imagenes/word.gif" BorderStyle="Solid"
										BorderWidth="1px"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD vAlign="middle" borderColor="#000000" align="center" width="1" bgColor="black"></TD>
								<TD vAlign="middle" borderColor="#000000" align="center" width="1" bgColor="black"></TD>
								<TD vAlign="middle" borderColor="#000000" align="center" width="1" bgColor="black"></TD>
								<TD vAlign="middle" borderColor="#000000" align="center" width="90" bgColor="#c0c0c0">
									<asp:label id="Label4" runat="server" CssClass="letra_pequena">Exportar a Word</asp:label></TD>
							</TR>
						</TABLE>
						<HR width="100%" SIZE="1">
						<asp:TextBox id="TextBox1" runat="server" Visible="False"></asp:TextBox>
						<asp:TextBox id="TextBox2" runat="server" Visible="False"></asp:TextBox>
					</TD>
				</TR>
				<TR>
					<TD align="center" width="40" colSpan="4" style="BORDER-RIGHT: blue 1px solid; BORDER-TOP: blue 1px solid; BORDER-LEFT: blue 1px solid; BORDER-BOTTOM: blue 1px solid">
						<CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" runat="server" BorderColor="Black" Width="350px" Height="50px"
							HasGotoPageButton="False" DisplayGroupTree="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
