<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_login.aspx.vb" Inherits="cimaweb.form_login"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CIMAWEB</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0" height="100%">
				<TR height="30%">
					<TD></TD>
					<TD align="center"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD height="150"></TD>
					<TD height="150" align="center"><IMG alt="" src="../imagenes/logo.JPG"></TD>
					<TD height="150"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD class="letra_grande_negrita" align="center" height="11">CIMAWEB</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="22"></TD>
					<TD class="letra_pequena" align="center" height="22">V. 2.0. / 26082010</TD>
					<TD height="22"></TD>
				</TR>
				<TR>
					<TD height="100"></TD>
					<TD vAlign="top" align="center" height="100">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="300" border="0">
							<TR>
								<TD bgColor="lightgrey" colSpan="3" height="22" align="center">
									<asp:Label id="Label1" runat="server" CssClass="letra_pequena_negrita"></asp:Label></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario">Usuario:</TD>
								<TD width="11"></TD>
								<TD align="right">
									<asp:TextBox id="uid" runat="server" Width="150px" CssClass="letra_centrada" tabIndex="1"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario">Password:</TD>
								<TD></TD>
								<TD align="right" width="150">
									<asp:TextBox id="pws" runat="server" Width="150px" TextMode="Password" CssClass="letra_centrada"
										tabIndex="2"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="3" height="22">
									<asp:Button id="Button1" runat="server" Width="150px" Text="Aceptar" tabIndex="3"></asp:Button></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="3" height="22"></TD>
							</TR>
						</TABLE>
					</TD>
					<TD height="100"></TD>
				</TR>
				<TR height="70%">
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
			</TABLE>
			&nbsp;
			<script type="text/javascript">
			document.Form1.uid.focus();
			</script>
		</form>
	</body>
</HTML>
