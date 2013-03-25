<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_cambio_prueba.aspx.vb" Inherits="cimaweb.form_cambio_prueba"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Cambio Prueba DI</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="5" height="22">Nueva prestación</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="5" style="HEIGHT: 14px">
						<asp:DropDownList id=DropDownList1 runat="server" CssClass="letra_pequena" DataSource="<%# Ds_prestaciones1 %>" DataTextField="Descripción" DataValueField="Tiempo" Width="350px" AutoPostBack="True">
						</asp:DropDownList></TD>
				</TR>
				<TR>
					<TD colSpan="5" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="5" height="11">
						<asp:Button id="Button1" runat="server" Width="150px" Text="Aceptar"></asp:Button></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
