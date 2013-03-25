<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_envio_sms.aspx.vb" Inherits="cimaweb.form_envio_sms"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_envio_sms</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22" style="HEIGHT: 22px">
						Envío de SMS</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:label id="Label1" runat="server" CssClass="letra_pequena">Móvil: </asp:label>&nbsp;&nbsp;
						<asp:TextBox id="TextBox1" runat="server"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:label id="Label2" runat="server" CssClass="letra_pequena">Cuerpo del SMS (hasta 160 caracteres): </asp:label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22">
						<asp:TextBox id="TextBox2" runat="server" Width="100%" MaxLength="160" TextMode="MultiLine" Rows="4"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:Button id="Button1" runat="server" Width="120px" Text="Enviar"></asp:Button></TD>
				</TR>
				<TR>
					<TD colSpan="3">
					</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
