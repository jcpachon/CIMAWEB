<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_basico_display.aspx.vb" Inherits="zeus.informe_basico_display"%>
<%@ Register TagPrefix="uo_barra_informes" TagName="uo_barra_informes" Src="../user_objects/uo_barra_informes.ascx" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Informe</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		
		<form id="Form1" method="post" runat="server">
			<% 
		
		Dim str_menu as string
		'Dim str_menu_2 as string
		Dim objCIMA_2 as New CIMA_Clases.CIMA
		'Dim objCIMA_3 as New CIMA_Clases.CIMA

		Dim objDS as New Data.DataSet
		'Dim objDS_2 as New Data.DataSet

		Dim objRow as Data.DataRow
		
		'Dim contador as Integer
		
		'Dim m,d as string
		
		
		
		Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
		
		str_menu = "dbo.SP_CIMACEX_RECUPERA_CAMPOS_INFORME " & Session("id_informe")
		
		objDS = objCIMA_2.f_consulta(str_menu, Session("cadena_conexion"))

		objCIMA_2 = nothing		

		%>
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<td>
						<uo_barra_informes:uo_barra_informes id="uo_barra_informes1" runat="server"></uo_barra_informes:uo_barra_informes>
					</td>
				</TR>
				<TR>
					<TD height="11">
						<HR width="100%" SIZE="1">
					</TD>
				</TR>
				<TR>
					<TD vAlign="top">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 610px" width="610">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD width="11">
												<asp:image id="Image1" runat="server" ImageUrl="../imagenes/logo.JPG"></asp:image></TD>
											<TD></TD>
											<TD vAlign="bottom">
												<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD class="letra_pequena_negrita" width="11"></TD>
														<TD class="letra_pequena_negrita">Redactor:
															<asp:label id=Label2 runat="server" Text='<%# DataBinder.Eval(Ds_informes_master1, "Tables[cima_informes_master].DefaultView.[0].id_usuario") %>'>
															</asp:label></TD>
														<TD class="letra_pequena_negrita" width="11"></TD>
														<TD class="letra_pequena_negrita"></TD>
													</TR>
													<TR>
														<TD width="11" height="8"></TD>
														<TD width="11" height="8"></TD>
														<TD height="8"></TD>
														<TD height="8"></TD>
													</TR>
													<TR>
														<TD class="letra_pequena_negrita" align="left" width="11"></TD>
														<TD class="letra_pequena_negrita" align="left">Fecha de Creación:
															<asp:Label id=Label3 runat="server" Text='<%# DataBinder.Eval(Ds_informes_master1, "Tables[cima_informes_master].DefaultView.[0].fecha_creacion") %>'>
															</asp:Label></TD>
														<TD class="letra_pequena_negrita"></TD>
														<TD class="letra_pequena_negrita"></TD>
													</TR>
													<TR>
														<TD align="left" width="11" height="11"></TD>
														<TD align="left" height="11"></TD>
														<TD height="11"></TD>
														<TD height="11"></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
								</TD>
								<TD style="WIDTH: 11px"></TD>
								<TD vAlign="top" align="left"></TD>
							</TR>
							<TR>
								<TD class="letra_negrita" style="TEXT-INDENT: 11pt" colSpan="3" height="11">PACIENTE:
									<asp:Label id=Label5 runat="server" Text='<%# DataBinder.Eval(Ds_informes_master1, "Tables[cima_informes_master].DefaultView.[0].episodio") %>' Width="432px" CssClass="letra_negrita">
									</asp:Label></TD>
							</TR>
							<TR>
								<TD style="TEXT-INDENT: 11pt" colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_negrita" style="TEXT-INDENT: 11pt" bgColor="darkgray" colSpan="3" height="11">EPISODIO:
									<asp:Label id=Label4 runat="server" Text='<%# DataBinder.Eval(Ds_informes_master1, "Tables[cima_informes_master].DefaultView.[0].episodio") %>' CssClass="letra_negrita">
									</asp:Label></TD>
							</TR>
							<TR>
								<TD height="11" width="609" style="WIDTH: 609px"></TD>
								<TD style="WIDTH: 17px" height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario_2" style="TEXT-INDENT: 11pt" colSpan="3" height="11">Informe:
									<asp:Label id=Label1 runat="server" Text='<%# DataBinder.Eval(Ds_informes_master1, "Tables[cima_informes_master].DefaultView.[0].cabecera") %>' CssClass="letra_negrita">
									</asp:Label></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11" style="TEXT-INDENT: 11pt">
								</TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<%
							
							for each objRow in objDS.Tables(0).Rows
		
							%>
							<TR>
								<TD class="fondo_formulario_2" colSpan="3" height="11"><% =objRow.Item(2) %></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11" style="TEXT-INDENT: 11pt" class="letra_pequena">
									<script type="text/javascript">
								<%
								Dim str_valor as String
								Dim ls_array() as String

								if objRow.Item(3) = 3 then
									
									ls_array = split(objRow.Item(4),",",,CompareMethod.Text)
									str_valor = trim(ls_array(cint(mid(objRow.Item(0),2,len(objRow.Item(0)))) - 1))
									
								else
								
									str_valor = objRow.Item(0)
									
								end if
								
								response.write ("document.write(unescape('" & str_valor & "'));")
								
								%>
									</script>
								</TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<%
							
							next
							
							%>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
