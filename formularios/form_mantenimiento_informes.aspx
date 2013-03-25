<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_informes.aspx.vb" Inherits="zeus.form_mantenimiento_informes"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_informes</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Mantenimiento de Plantillas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_muy_pequena_azul_negrita" colSpan="3" height="11">Informe</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" width="250">Nombre Plantilla</TD>
								<TD class="fondo_formulario" width="11"></TD>
								<TD class="fondo_formulario">Descripción Plantilla</TD>
							</TR>
							<TR>
								<TD width="250"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD width="250"><asp:textbox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Ds_plantillas1, "Tables[cima_plantillas].DefaultView.[0].descripcion") %>' Enabled="False" CssClass="letra_pequena" Width="200px">
									</asp:textbox></TD>
								<TD></TD>
								<TD><asp:textbox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Ds_plantillas1, "Tables[cima_plantillas].DefaultView.[0].informacion") %>' Enabled="False" CssClass="letra_pequena" Width="100%">
									</asp:textbox></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_muy_pequena_azul_negrita" colSpan="3" height="11">Campos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:datagrid id=DataGrid2 runat="server" Width="100%" DataMember="cima_plantillas_campos" DataSource="<%# Ds_campos1 %>" Font-Size="7pt" GridLines="Vertical" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="Solid" BorderColor="#999999" DataKeyField="Código" ForeColor="Black" Font-Names="Verdana">
							<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="7pt" Font-Names="Verdana" ForeColor="Black" BackColor="White"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" style="HEIGHT: 13px">Nombre Campo</TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px" width="11"></TD>
								<TD class="fondo_formulario" style="WIDTH: 189px; HEIGHT: 13px" width="189">Descripción 
									Campo</TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px" width="11"></TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px">Visible en Informe</TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px" width="11"></TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px">Orden</TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px" width="11"></TD>
								<TD class="fondo_formulario" style="HEIGHT: 13px">Tipo de Dato</TD>
							</TR>
							<TR>
								<TD></TD>
								<TD width="11"></TD>
								<TD style="WIDTH: 189px"></TD>
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD width="11"><asp:textbox id="TextBox1" runat="server" CssClass="letra_pequena" Width="150px"></asp:textbox></TD>
								<TD width="11"></TD>
								<TD style="WIDTH: 189px"><asp:textbox id="TextBox5" runat="server" Width="200px"></asp:textbox></TD>
								<TD width="11"></TD>
								<TD>
									<asp:DropDownList id="DropDownList3" runat="server" CssClass="letra_pequena">
										<asp:ListItem Value="S">SI</asp:ListItem>
										<asp:ListItem Value="N">NO</asp:ListItem>
									</asp:DropDownList></TD>
								<TD width="11"></TD>
								<TD><asp:textbox id="TextBox6" runat="server" Width="30px"></asp:textbox></TD>
								<TD width="11"></TD>
								<TD><asp:dropdownlist id="DropDownList1" runat="server" CssClass="letra_pequena" AutoPostBack="True">
										<asp:ListItem Value="1" Selected="True">Texto</asp:ListItem>
										<asp:ListItem Value="4">Texto Corto</asp:ListItem>
										<asp:ListItem Value="2">N&#250;mero</asp:ListItem>
										<asp:ListItem Value="3">Desplegable</asp:ListItem>
										<asp:ListItem Value="5">Cabecera</asp:ListItem>
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 363px" width="363" colSpan="3" height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="9" height="11"><asp:panel id="Panel1" runat="server" Visible="False">
										<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
											<TR>
												<TD vAlign="top" width="250">
													<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
														<TR>
															<TD class="fondo_formulario">Valores del desplegable (entre comas):</TD>
														</TR>
														<TR>
															<TD></TD>
														</TR>
													</TABLE>
												</TD>
												<TD width="11"></TD>
												<TD>
													<asp:TextBox id="TextBox2" runat="server" Width="100%" CssClass="letra_pequena" TextMode="MultiLine"
														Height="80px"></asp:TextBox></TD>
											</TR>
										</TABLE>
									</asp:panel></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="9" height="11">
									<asp:button id="Button4" runat="server" Width="150px" Text="Eliminar Campo"></asp:button><asp:button id="Button3" runat="server" Text="Actualizar Campo" Width="150px"></asp:button><asp:button id="Button2" runat="server" Text="Añadir Campo" Enabled="False" Width="150px"></asp:button></TD>
							</TR>
							<TR>
								<TD width="11" colSpan="7" height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD width="11" height="11"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD class="fondo_pie" colSpan="3" height="11">Permisos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 39px" colSpan="3" height="39">
						<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="11"><asp:dropdownlist id="DropDownList2" runat="server" CssClass="letra_pequena" Width="112px" AutoPostBack="True">
										<asp:ListItem Value="1">Por Usuario</asp:ListItem>
										<asp:ListItem Value="2">Por Grupo</asp:ListItem>
										<asp:ListItem Value="3">Para Todos</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD width="11"></TD>
								<TD><asp:label id="Label1" runat="server" CssClass="letra_pequena" Width="100%">Label</asp:label></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<HR width="100%" SIZE="1">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"><asp:button id="Button1" runat="server" Text="Aceptar" Width="150px"></asp:button></TD>
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
