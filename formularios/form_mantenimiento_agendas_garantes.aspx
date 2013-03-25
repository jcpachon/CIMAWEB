<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_agendas_garantes.aspx.vb" Inherits="zeus.form_mantenimiento_agendas_garantes"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_agendas_garantes</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form name="seleccion" method="post">
			<input type="hidden" name="cadena_creciente"> <input type="hidden" name="id_agenda_garante" value='<% =me.dropdownlist1.selectedvalue %>'>
			<input type=hidden name="Dropdownlist1" value='<% =me.dropdownlist1.selectedvalue %>'>
		</form>
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="count" runat="server" Visible="False"></asp:TextBox>
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px"
				height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Mantenimiento 
						Agendas - Garantes</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:label id="Label1" runat="server" Font-Bold="True" CssClass="letra_pequena">Pares: </asp:label><asp:dropdownlist id=Dropdownlist1 runat="server" CssClass="letra_pequena" DataSource="<%# Ds_agendas_garantes1 %>" DataMember="cima_agendas_garantes" DataTextField="descripcion" DataValueField="id_agenda_garante" AutoPostBack="True" Width="300px">
						</asp:dropdownlist>&nbsp;&nbsp;
						<asp:button id="Button2" runat="server" Width="120px" Text="Nuevo"></asp:button>&nbsp;&nbsp;&nbsp;
						<asp:button id="Button5" runat="server" Width="120px" Text="Eliminar"></asp:button></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<asp:panel id="Panel1" runat="server" Visible="False">
					<TR>
						<TD class="fondo_pie" colSpan="3" height="11">Par</TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11">
							<asp:label id="Label2" runat="server" Font-Bold="True" CssClass="letra_pequena">Descripción: </asp:label>&nbsp;
							<asp:TextBox id="TextBox1" runat="server" Width="300px"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="3" height="32" style="HEIGHT: 32px">
							<asp:label id="Label6" runat="server" Font-Bold="True" CssClass="letra_pequena">Agenda: </asp:label>&nbsp;
							<asp:dropdownlist id=Dropdownlist5 runat="server" CssClass="letra_pequena" DataSource="<%# Ds_agen_tabla1 %>" DataMember="agen" DataTextField="agenname" DataValueField="agencode" Width="200px">
							</asp:dropdownlist>&nbsp;
							<asp:label id="Label3" runat="server" Font-Bold="True" CssClass="letra_pequena">Mutua: </asp:label>
							<asp:dropdownlist id=Dropdownlist3 runat="server" CssClass="letra_pequena" DataSource="<%# Ds_firm_garantes1 %>" DataMember="firm" DataTextField="firmname" DataValueField="firm_key" Width="200px">
							</asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11">
							<asp:label id="Label7" runat="server" Font-Bold="True" CssClass="letra_pequena">Comentario: </asp:label></TD>
					</TR>
					<TR>
						<TD vAlign="top" colSpan="3" height="11"></TD>
					</TR>
					<TR>
						<TD vAlign="top" colSpan="3" height="11">
							<asp:TextBox id="TextBox2" runat="server" Width="100%" TextMode="MultiLine" Rows="5" CssClass="letra"></asp:TextBox></TD>
					</TR>
					<TR>
						<TD align="right" colSpan="3" valign="top">
							<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="100%" bgColor="lightgrey" border="0">
								<TR>
									<TD width="11" bgColor="#ffffff" height="11"></TD>
									<TD bgColor="white" colSpan="3" height="11"></TD>
									<TD width="11" bgColor="#ffffff" height="11"></TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD colSpan="3" height="11"></TD>
									<TD width="11" height="11"></TD>
								</TR>
								<TR>
									<TD class="fecha_letra" colSpan="5" height="11">Definición del par</TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD colSpan="3" height="11"></TD>
									<TD width="11" height="11"></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 9px" height="9"></TD>
									<TD style="HEIGHT: 9px" width="300" height="9">
										<asp:label id="Label24" runat="server" CssClass="letra_pequena_negrita">Garante: </asp:label>
										<asp:dropdownlist id=Dropdownlist9 runat="server" CssClass="letra_pequena" DataSource="<%# Ds_firm_garantes2 %>" DataMember="firm" DataTextField="firmname" DataValueField="firm_key" AutoPostBack="True" Width="225px">
										</asp:dropdownlist></TD>
									<TD style="HEIGHT: 9px" width="11" height="9"></TD>
									<TD style="HEIGHT: 9px" height="9"></TD>
									<TD style="HEIGHT: 9px" width="11" height="9"></TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD colSpan="3" height="11">
										<asp:Panel id="Panel2" runat="server" Visible="false">
											<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TBODY>
													<TR>
														<TD></TD>
														<TD></TD>
														<TD></TD>
													</TR>
													<TR>
														<TD width="250">
															<asp:label id="Label25" runat="server" CssClass="letra_pequena_negrita">Agrupación de Coberturas: </asp:label>
															<asp:dropdownlist id=Dropdownlist10 runat="server" CssClass="letra_pequena" Width="225px" DataValueField="covegrou_key" DataTextField="covegroudesclong" DataMember="covegrou" DataSource="<%# Ds_covegrou1 %>">
															</asp:dropdownlist></TD>
														<TD width="100">&nbsp;
															<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100" border="0">
																<TR>
																	<TD>
																		<asp:Button id="Button1" runat="server" CssClass="letra_pequena" Width="100px" Text="Asignar >>>"></asp:Button></TD>
																</TR>
																<TR>
																	<TD height="22"></TD>
																</TR>
																<TR>
																	<TD>
																		<asp:Button id="Button3" runat="server" CssClass="letra_pequena" Width="100px" Text="<<< Desasignar"></asp:Button></TD>
																</TR>
															</TABLE>
														</TD>
														<TD vAlign="middle" align="right">
															<asp:DataGrid id=DataGrid1 runat="server" Visible="False" Width="400px" DataMember="cima_coberturas" DataSource="<%# Ds_cima_coberturas1 %>" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" Font-Size="7pt" PageSize="15" ForeColor="Black" Font-Names="Verdana" AutoGenerateColumns="False">
																<FooterStyle BackColor="#CCCCCC"></FooterStyle>
																<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
																<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
																<ItemStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="Black" BackColor="White"></ItemStyle>
																<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
																<Columns>
																	<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
																	<asp:BoundColumn Visible="False" DataField="id_agenda_garante" SortExpression="id_agenda_garante"
																		HeaderText="id_agenda_garante"></asp:BoundColumn>
																	<asp:BoundColumn Visible="False" DataField="covegrou_key" SortExpression="covegrou_key" HeaderText="covegrou_key"></asp:BoundColumn>
																	<asp:BoundColumn DataField="covegroudesclong" SortExpression="covegroudesclong" HeaderText="Agrupaci&#243;n de Coberturas"></asp:BoundColumn>
																</Columns>
																<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
															</asp:DataGrid></TD>
													</TR>
													<TR>
														<TD colSpan="3"></TD>
													</TR>
										</asp:Panel>
							</TABLE>
						</TD>
						<TD height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="5" height="11"></TD>
					</TR>
					<TR>
						<TD bgColor="white" colSpan="5" height="11" align="right"></TD>
					</TR>
					<TR>
						<TD align="right" bgColor="#ffffff" colSpan="5" height="11">
							<asp:button id="Button4" runat="server" Width="150px" Text="Actualizar"></asp:button></TD>
					</TR>
					<TR>
						<TD bgColor="#ffffff" colSpan="5"></TD>
					</TR>
			</TABLE>
			<%
			if len(trim(me.Dropdownlist5.selectedvalue)) > 0 and len(trim(me.Dropdownlist1.selectedvalue)) > 0 then
			%>
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR height="22">
					<TD></TD>
					<TD width="150"></TD>
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
					<TD width="160"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD class="fondo_formulario" width="150" align="center">Código Prestación</TD>
					<TD width="11"></TD>
					<TD class="fondo_formulario">Prestación</TD>
					<TD width="11"></TD>
					<TD class="fondo_formulario" width="160" align="center">Requiere autorización</TD>
				</TR>
				<%
				
				Dim str_menu as string
											
				Dim objCIMA as New CIMA_Clases.CIMA
									
				Dim objDS as New Data.DataSet
									
				Dim objRow as Data.DataRow
									
				Dim contador as integer
									
									
					
				Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"
				
				str_menu = "dbo.SP_CIMACEX_PRESTACIONES_AGENDA '" & me.Dropdownlist5.selectedvalue & "'," & me.Dropdownlist1.selectedvalue

				objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
				
				contador = 0
				
				if objDS.Tables(0).Rows.Count > 0 then
				
				for each objRow in objDS.Tables(0).Rows
									
				contador = contador + 1
				
				%>
				<TR height="11">
					<TD></TD>
					<TD width="150"></TD>
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
					<TD width="160"></TD>
				</TR>
				<TR height="11">
					<TD></TD>
					<TD width="150" class="letra_pequena" align="center"><% =objRow.Item("hprocode") %></TD>
					<TD width="11"></TD>
					<TD class="letra_pequena"><% =objRow.Item("hprodesclong") %></TD>
					<TD width="11"></TD>
					<TD width="160" align="center"><% 
					if objRow.Item("autorizacion") = "0" then %>
						<INPUT id="cb<% =Cstr(contador) %>" value='<% =objRow.Item("hpro_key") %>' type="checkbox">
						<%
					else
					%>
						<INPUT id="cb<% =Cstr(contador) %>" value='<% =objRow.Item("hpro_key") %>' type="checkbox" checked>
						<%
					end if
					%>
					</TD>
				</TR>
				<%
				
				next
				
				end if
				
				response.write ("<script>var tope = " & contador & ";</script>")
				
				'me.count.text = contador
				
				%>
				<TR height="22">
					<TD></TD>
					<TD width="150"></TD>
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
					<TD width="160"></TD>
				</TR>
				<TR height="11">
					<TD colspan="6" align="right"><INPUT class="letra_pequena" style="WIDTH: 150px" type="button" value="Actualizar" onclick="javascript:actualizar_autorizaciones();"></TD>
				</TR>
				<TR height="11">
					<TD colspan="6" align="right"></TD>
				</TR>
			</TABLE>
			<% 
			end if 
			%>
			</TD></TR></asp:panel>
			<TR>
				<TD colSpan="3" align="right">
				</TD>
			</TR>
			<TR>
				<TD width="125" colSpan="3"></TD>
			</TR>
			</TBODY></TABLE>
		</form>
		<script type="text/javascript">
	
		function actualizar_autorizaciones(){

			var cadena;
			
			cadena = ""

			for (i=1;i<=tope;i++){

			if (document.getElementById("cb" + i).checked == true){
			
				cadena = cadena + document.getElementById("cb" + i).value + "*";
				//alert(cadena);
			
			}
			
			}
			
			seleccion.cadena_creciente.value=cadena;
			
			seleccion.submit();
			
		}
	
		</script>
	</body>
</HTML>
