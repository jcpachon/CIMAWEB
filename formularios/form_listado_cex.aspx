<%@ Register TagPrefix="uo_fechas" TagName="uo_fechas" Src="../user_objects/uo_fechas.ascx" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_listado_cex.aspx.vb" Inherits="cimaweb.form_listado_cex"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_listado_cex</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 90%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Listado de Consultas 
						Externas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="30">
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><asp:label id="Label1" runat="server" CssClass="letra_pequena">Servicio: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" Width="150px" DataValueField="reso_key" DataTextField="resodesc" DataMember="reso" DataSource="<%# Ds_reso1 %>" AutoPostBack="True">
									</asp:dropdownlist>&nbsp;&nbsp;
									<asp:label id="Label2" runat="server" CssClass="letra_pequena">Agenda: </asp:label><asp:dropdownlist id=Dropdownlist2 runat="server" CssClass="letra_pequena" Width="200px" DataValueField="agencode" DataTextField="agenname" DataMember="agen" DataSource="<%# Ds_agen_tabla1 %>">
									</asp:dropdownlist></TD>
								<TD align="right">&nbsp;&nbsp;
									<asp:button id="Button1" runat="server" Width="150px" Text="Listar"></asp:button></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD align="right" height="11"></TD>
							</TR>
							<TR>
								<TD height="11" colSpan="2">
									<uo_fechas:uo_fechas id="uo_fechas1" runat="server"></uo_fechas:uo_fechas></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22" align="right"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<%
				
				If Me.Ds_listado_cex1.SP_CIMACEX_LISTADO_CEX.Rows.Count >= 1 Then
				
				%>
							<TR>
								<TD vAlign="top" colSpan="3">
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD align="right" colSpan="19" height="16" style="HEIGHT: 16px">
												<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD class="letra">Fecha listado:
															<script type="text/javascript">  
														var ahora = new Date()  
														//document.write(ahora)
														document.write(ahora.getDate())  
														document.write("/")
														var meses = ahora.getMonth() + 1
														if (meses < 10) { meses = '0' + meses; }  
														document.write(meses)  
														document.write("/")  
														document.write(ahora.getYear())
														document.write("&nbsp;")
														document.write(ahora.getHours())  
														document.write(":")  
														var minutos = ahora.getMinutes()
														if (minutos < 10) { minutos = '0' + minutos; }
														document.write(minutos)  
														//document.write(".")  
														//document.write(ahora.getSeconds())  
															</script>
														</TD>
														<TD align="right"><IMG height="16" alt="" src="../imagenes/print.gif" onclick="javascript:printPage();"></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
										<TR>
											<TD width="50" colSpan="13" height="11"></TD>
										</TR>
										<TR>
											<TD class="fondo_formulario" width="50">NHC</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" width="200">Paciente</TD>
											<TD width="11"></TD>
											<!--TD class="fondo_formulario" align="center" width="75">F. Nac.</TD>
											<TD width="11"></TD-->
											<TD class="fondo_formulario" width="175">Agenda</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" align="center" width="100">Día</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" align="center" width="100">Hora</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" width="275">Prestación</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" align="center" width="75">Estado</TD>
											<TD width="11"></TD>
											<TD class="fondo_formulario" align="center" width="100">Garante</TD>
										</TR>
										<TR>
											<TD colSpan="19" height="11"></TD>
										</TR>
										<%
										
										Dim objRow as Data.DataRow
										
										for each objRow in Me.Ds_listado_cex1.SP_CIMACEX_LISTADO_CEX.Rows
										
										%>
										<TR>
											<TD class="letra_muy_pequena"><% =objRow.Item(1) %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena"><% =objRow.Item(3) %></TD>
											<TD class="letra_muy_pequena"></TD>
											<!--TD class="letra_muy_pequena" align="center"><% =objRow.Item(4) %></TD>
											<TD class="letra_muy_pequena"></TD-->
											<TD class="letra_muy_pequena"><% =objRow.Item(5) %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena" align="center"><% =objRow.Item("diardate")  %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena" align="center"><% =objRow.Item("bookhini") %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena"><% =objRow.Item(6) %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena" align="center"><% =objRow.Item(11) %></TD>
											<TD class="letra_muy_pequena"></TD>
											<TD class="letra_muy_pequena" align="center"><% =objRow.Item("garante_principal") %></TD>
										</TR>
										<TR>
											<TD colSpan="19"></TD>
										</TR>
										<%
										
										next
										
										%>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="3" height="11"></TD>
							</TR>
							<%
							
							end if
							
							%>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
