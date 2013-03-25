<%@ Page Language="vb" AutoEventWireup="false" Codebehind="inicio.aspx.vb" Inherits="cimaweb.inicio"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>inicio</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 100%; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="1" cellPadding="1" border="0">
				<TR>
					<TD align="left" colSpan="3" height="11">
						<!--marquee loop="1" direction="left">CENTRO INTERNACIONAL DE MEDICINA AVANZADA (CIMA)</marquee-->
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="33" align="center" vAlign="top">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0" height="100">
							<TR>
								<TD width="11" vAlign="top">
									<asp:Image id="Image3" runat="server" ImageUrl="../imagenes/clinica.jpg" BorderColor="Black"
										BorderWidth="1px"></asp:Image></TD>
								<TD width="11"></TD>
								<TD vAlign="top">
									<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
										<TR>
											<TD>
												<asp:Label id="Label1" runat="server" CssClass="fondo_formulario_2" Width="100%">Lo NUEVO:</asp:Label>
											</TD>
										</TR>
										<TR>
											<TD height="11"></TD>
										</TR>
										<TR>
											<TD>
												<MARQUEE style="WIDTH: 100%; HEIGHT: 136px" scrollAmount="1" direction="up">
													<%
											Dim objRow as Data.DataRow 
											
											for each objRow in Me.Ds_cima_novedades1.Tables(0).Rows
											%>
													<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
														<TR>
															<TD width="22" valign="top">
																<asp:Image id="Image2" runat="server" ImageUrl="../imagenes/indica.gif"></asp:Image></TD>
															<TD class="letra_pequena_negrita">
																<% =objRow.Item(0) %>
															</TD>
														</TR>
														<TR>
															<TD height="11" colspan="2"></TD>
														</TR>
													</TABLE>
													<%
											next
											%>
												</MARQUEE>
											</TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<tr>
							</tr>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD vAlign="top" align="right" colSpan="3">
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="letra" style="FONT-WEIGHT: bold; FONT-SIZE: x-small; FONT-FAMILY: Tahoma"
									colSpan="3" height="33"></TD>
							</TR>
							<TR>
								<TD colSpan="3" class="letra_cursiva" vAlign="middle">
									CIMAWEB está optimizado para ser utilizado en navegadores Internet Explorer 8 y 
									superiores.<br>
									<br>
									El uso en otros navegadores puede provocar un mal funcionamiento en 
									determinadas funcionalidades.
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
