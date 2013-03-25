<%@ Page Language="vb" AutoEventWireup="false" Codebehind="cabecera.aspx.vb" Inherits="zeus.cabecera"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>cabecera</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0" MS_POSITIONING="GridLayout">
		<form name="info" method="post">
			<input type=hidden 
value='<% =Session("usuario") %>' name=id_usuario>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE class='<% 
			dim ls_pdf_ayuda as string
			
			
			
			select case Session("grupo") 
			case "D" 
			Response.Write("fondo_cabecera_d")
			ls_pdf_ayuda = "CIMAWEB_med.pdf" 
			case "M" 
			Response.Write("fondo_cabecera") 
			ls_pdf_ayuda = "CIMAWEB_med.pdf" 
			case "A" 
			Response.Write("fondo_cabecera_a")
			ls_pdf_ayuda = "CIMAWEB_adm.pdf"  
			case "U" 
			Response.Write("fondo_cabecera_u")
			ls_pdf_ayuda = "CIMAWEB_mida.pdf" 
			case "G" 
			Response.Write("fondo_cabecera_u")
			ls_pdf_ayuda = "CIMAWEB_mida.pdf" 
			case "E"
			Response.Write("fondo_cabecera_e")
			ls_pdf_ayuda = "CIMAWEB_adm.pdf" 
			case "W"
			Response.Write("fondo_cabecera_u")
			ls_pdf_ayuda = "CIMAWEB_adm.pdf" 
			case "I"
			Response.Write("fondo_cabecera_u")
			ls_pdf_ayuda = "CIMAWEB_adm.pdf"
			case "L"
			Response.Write("fondo_cabecera_l")
			ls_pdf_ayuda = "CIMAWEB_mida.pdf"			
			end select %>' id="Table1" style="Z-INDEX: 101; POSITION: absolute" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="CURSOR: hand" onclick="javascript:top.location.href='../inicio.asp';" align="center"
						width="125" bgColor="#ffffff" height="94"><asp:image id="Image1" runat="server" AlternateText="CIMAWEB" ImageUrl="../imagenes/logo_portada.JPG"></asp:image></TD>
					<TD width="*" height="94">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="marco" vAlign="bottom">
									<TABLE id="Table4" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD width="22" height="33%"></TD>
											<TD colSpan="3" height="33%"></TD>
										</TR>
										<TR>
											<TD class="letra_grande_negrita" width="22" height="33%"></TD>
											<TD class="letra_grande_negrita" colSpan="3" height="33%">
												<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD class="letra_grande_negrita">CIMAWEB - <DIV style="FONT-SIZE: x-small">CENTRO INTERNACIONAL DE MEDICINA AVANZADA</DIV></TD>
														<TD align="right" vAlign="middle">
															<TABLE id="Table51" cellSpacing="0" cellPadding="0" width="150" border="0" style="HEIGHT: 100%">
																<TR>
																	<TD></TD>
																	<TD class="letra_centrada"></TD>
																	<TD></TD>
																</TR>
																<!--TR height="22">
																	<TD></TD>
																	<TD class="letra_centrada" bgcolor="dimgray" style=" FONT-SIZE: 8pt; MARGIN: 0px; CURSOR: hand; COLOR: white; BORDER-TOP-STYLE: groove; BORDER-RIGHT-STYLE: groove; BORDER-LEFT-STYLE: groove; BORDER-BOTTOM-STYLE: groove" valign=middle>CAMBIAR 
																		DE AREA</TD>
																	<TD width="11"></TD>
																</TR-->
																<TR>
																	<TD></TD>
																	<TD class="letra_pequena" align="right"></TD>
																	<TD></TD>
																</TR>
															</TABLE>
														</TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD class="letra_pequena" align="left" width="22" height="50%"></TD>
											<TD class="letra_pequena" align="left" height="50%" style="WIDTH: 379px">Usuario:
												<asp:label id="Label11" runat="server">Label</asp:label></TD>
											<TD class="letra_pequena" align="right" width="*" colSpan="3" height="50%" style="PADDING-RIGHT: 11px">
												<SCRIPT type="text/javascript">
								document.write (f_fecha_actual());
												</SCRIPT>
											</TD>
										</TR>
										<TR>
											<TD class="letra_pequena" align="left" width="22" height="33%"></TD>
											<TD class="letra_pequena" align="left" colSpan="2" height="33%"></TD>
											<TD class="letra_pequena" align="right" height="33%"></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD height="22">
									<TABLE class="fondo_menu" id="Table3" height="22" cellSpacing="0" cellPadding="0" width="100%"
										border="1">
										<TR>
											<% if mid(Session("perfil"),1,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_1.aspx';top.contents.document.f_menu_lateral.opcion.value='1';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label1" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),2,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_2.aspx';top.contents.document.f_menu_lateral.opcion.value='2';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label2" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),3,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_3.aspx';top.contents.document.f_menu_lateral.opcion.value='3';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label3" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),4,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_4.aspx';top.contents.document.f_menu_lateral.opcion.value='4';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label4" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),5,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_5.aspx';top.contents.document.f_menu_lateral.opcion.value='5';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label5" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),6,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_6.aspx';top.contents.document.f_menu_lateral.opcion.value='6';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label6" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),7,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_7.aspx';top.contents.document.f_menu_lateral.opcion.value='7';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label7" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),8,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_8.aspx';top.contents.document.f_menu_lateral.opcion.value='8';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label8" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),9,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../formularios/form_menu_9.aspx';top.contents.document.f_menu_lateral.opcion.value='9';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label9" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
											<% if mid(Session("perfil"),10,1)="1" then %>
											<TD onmouseover="javascript:this.className='fondo_menu_onMouseOver';" style="CURSOR: hand"
												onclick="javascript:top.main.location.href = '../pdf/<%=ls_pdf_ayuda%>';top.contents.document.f_menu_lateral.opcion.value='10';top.contents.document.f_menu_lateral.submit();"
												onmouseout="javascript:this.className='fondo_menu';" align="center" width="10%"><asp:label id="Label10" runat="server"></asp:label></TD>
											<% 
											else
											%>
											<TD align="center" width="10%"></TD>
											<% end if %>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
