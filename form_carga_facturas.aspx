<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_carga_facturas.aspx.vb" Inherits="cimaweb.form_carga_facturas"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_carga_facturas</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				id="Table1" border="0" cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22" colSpan="4">Mantenimiento 
						CIMA - HCIS</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="11"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Tipo mapeo:</asp:label></TD>
					<TD height="11"><asp:dropdownlist id="DropDownList1" runat="server" CssClass="letra_pequena" AutoPostBack="True" Width="100px">
							<asp:ListItem Value="AG">AGENDA</asp:ListItem>
							<asp:ListItem Value="PR">PRESTACI&#211;N</asp:ListItem>
							<asp:ListItem Value="GA">GARANTE</asp:ListItem>
						</asp:dropdownlist></TD>
					<TD height="11"><asp:button id="Button1" runat="server" Width="120px" Text="Nuevo" Enabled="False"></asp:button></TD>
				</TR>
				<TR>
					<TD height="11"><asp:label id="Label7" runat="server" CssClass="letra_pequena">Agenda:</asp:label></TD>
					<TD height="11"><asp:dropdownlist id=DropDownList3 runat="server" CssClass="letra_pequena" AutoPostBack="True" Width="250px" DataValueField="Código" DataTextField="Agenda" DataMember="agen" DataSource="<%# Ds_agen3 %>">
						</asp:dropdownlist></TD>
					<TD height="11"></TD>
				</TR>
				<asp:panel id="Panel2" runat="server">
					<TR>
						<TD colSpan="3" height="250">
							<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD class="menu_lateral_izquierdo" align="center" width="50%" colSpan="3" height="11">Par 
										CIMA - HCIS</TD>
								</TR>
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD vAlign="top" align="center" width="50%" colSpan="3">
										<asp:datagrid id=DataGrid1 runat="server" Width="650px" DataSource="<%# Ds_par_SNT_CIMA1 %>" DataMember="ds_par_SNT_CIMA" AutoGenerateColumns="False" Font-Names="Verdana" Font-Size="7pt" ForeColor="Black" BackColor="White" AllowPaging="True" PageSize="15" GridLines="Vertical" BorderColor="#999999" BorderWidth="1px" CellPadding="3" DataKeyField="id">
											<FooterStyle BackColor="#CCCCCC"></FooterStyle>
											<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
											<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
											<ItemStyle Font-Size="XX-Small"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
											<Columns>
												<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id" SortExpression="id" HeaderText="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="codigo_CIMA" SortExpression="codigo_CIMA" HeaderText="C&#243;digo CIMA"></asp:BoundColumn>
												<asp:BoundColumn DataField="desc_CIMA" SortExpression="desc_CIMA" HeaderText="Descripci&#243;n CIMA"></asp:BoundColumn>
												<asp:BoundColumn DataField="codigo_HCIS" SortExpression="codigo_HCIS" HeaderText="C&#243;digo HCIS"></asp:BoundColumn>
												<asp:BoundColumn DataField="desc_HCIS" SortExpression="desc_HCIS" HeaderText="Descripci&#243;n HCIS"></asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</asp:panel><asp:panel id="Panel3" runat="server">
					<TR>
						<TD colSpan="3" height="250">
							<TABLE id="Table3" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD class="menu_lateral_izquierdo" align="center" width="50%" colSpan="3" height="11">Par 
										CIMA - HCIS</TD>
								</TR>
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD colSpan="3" height="11"></TD>
								</TR>
								<TR>
									<TD vAlign="top" align="center" width="50%" colSpan="3">
										<asp:DataGrid id=DataGrid2 runat="server" Width="750px" DataSource="<%# Ds_par_SNT_CIMA_garante1 %>" DataMember="ds_par_SNT_CIMA_garante" AutoGenerateColumns="False" Font-Names="Verdana" Font-Size="7pt" ForeColor="Black" AllowPaging="True" GridLines="Vertical" BorderColor="#999999" BorderWidth="1px" DataKeyField="id">
											<FooterStyle BackColor="#CCCCCC"></FooterStyle>
											<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
											<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
											<ItemStyle Font-Size="XX-Small"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
											<Columns>
												<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id" SortExpression="id" HeaderText="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="agenname" SortExpression="agenname" HeaderText="Agenda"></asp:BoundColumn>
												<asp:BoundColumn DataField="codigo_CIMA" SortExpression="codigo_CIMA" HeaderText="C&#243;digo CIMA"></asp:BoundColumn>
												<asp:BoundColumn DataField="desc_CIMA" SortExpression="desc_CIMA" HeaderText="Descripci&#243;n CIMA"></asp:BoundColumn>
												<asp:BoundColumn DataField="codigo_HCIS" SortExpression="codigo_HCIS" HeaderText="C&#243;digo HCIS"></asp:BoundColumn>
												<asp:BoundColumn DataField="desc_HCIS" SortExpression="desc_HCIS" HeaderText="Descripci&#243;n HCIS"></asp:BoundColumn>
												<asp:BoundColumn Visible="False" DataField="covegrou_key" SortExpression="covegrou_key" HeaderText="covegrou_key"></asp:BoundColumn>
												<asp:BoundColumn DataField="covegroudesclong" SortExpression="covegroudesclong" HeaderText="Agrupaci&#243;n Cobertura"></asp:BoundColumn>
												<asp:BoundColumn Visible="False" DataField="agencode" SortExpression="agencode" HeaderText="agencode"></asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
										</asp:DataGrid></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</asp:panel>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD align="center"></TD>
					<td align="center"><asp:button id="Button2" runat="server" Width="120px" Text="Modificar" Visible="False"></asp:button></td>
					<td align="center"><asp:button id="Button3" runat="server" Width="120px" Text="Eliminar" Visible="False"></asp:button></td>
				</TR>
				<asp:panel id="Panel1" runat="server">
					<TR>
						<TD vAlign="top" colSpan="3" align="right">
							<TABLE id="Table4" border="0" cellSpacing="0" cellPadding="0" width="100%" bgColor="lightgrey">
								<TBODY>
									<TR>
										<TD bgColor="#ffffff" height="11" width="11"></TD>
										<TD bgColor="white" height="11" colSpan="3"></TD>
										<TD bgColor="#ffffff" height="11" width="11"></TD>
									</TR>
									<TR>
										<TD height="11"></TD>
										<TD height="11" colSpan="2"></TD>
										<TD height="11" width="11"></TD>
										<TD height="11" width="11"></TD>
									</TR>
									<TR>
										<TD class="fecha_letra" height="11" colSpan="5">Definición del par CIMA - HCIS</TD>
									</TR>
									<TR>
										<TD height="11" width="11"></TD>
										<TD height="11" colSpan="2"></TD>
										<TD height="11" width="11"></TD>
										<TD height="11" width="11"></TD>
									</TR>
									<TR>
										<TD height="11" width="11"></TD>
										<TD height="11" width="99"><asp:label id="Label2" runat="server" CssClass="letra_pequena_negrita">Identificador:</asp:label></TD>
										<TD height="11"><asp:textbox id="identificador" runat="server" CssClass="letra_pequena" AutoPostBack="True" Enabled="False"
												ReadOnly="True"></asp:textbox></TD>
										<TD height="11" colSpan="2"></TD>
									</TR>
									<TR>
										<TD height="11" width="11"></TD>
										<TD height="11" width="99"><asp:label id="Label3" runat="server" CssClass="letra_pequena_negrita">Código CIMA:</asp:label></TD>
										<TD height="11"><asp:dropdownlist id=DropDownList2 runat="server" CssClass="letra_pequena" AutoPostBack="True" Width="200px" DataValueField="Código" DataTextField="Código" DataMember="agen" DataSource="<%# Ds_agen1 %>">
											</asp:dropdownlist></TD>
										<TD height="11"><asp:label id="Label4" runat="server" CssClass="letra_pequena_negrita">Descripción CIMA:</asp:label></TD>
										<TD height="11"><asp:textbox id="desc_CIMA" runat="server" CssClass="letra_pequena" AutoPostBack="True" Width="250px"
												Enabled="False"></asp:textbox></TD>
									</TR>
									<asp:Panel id="Panel5" runat="server">
										<TR>
											<TD width="11" height="11"></TD>
											<TD width="99" height="11">
												<asp:label id="Label5" runat="server" CssClass="letra_pequena_negrita">Código HCIS:</asp:label></TD>
											<TD height="11">
												<asp:textbox id="codigo_HCIS" runat="server" CssClass="letra_pequena" AutoPostBack="True"></asp:textbox></TD>
											<TD height="11">
												<asp:label id="Label6" runat="server" CssClass="letra_pequena_negrita">Descripción HCIS:</asp:label></TD>
											<TD height="11">
												<asp:textbox id="desc_HCIS" runat="server" CssClass="letra_pequena" Width="250px"></asp:textbox></TD>
										</TR>
									</asp:Panel>
									<asp:panel id="Panel4" runat="server">
										<TR>
											<TD width="11" height="11"></TD>
											<TD width="99" height="11">
												<asp:Label id="Label8" runat="server" CssClass="letra_pequena_negrita">Agenda:</asp:Label>
											<TD width="11" height="11">
												<asp:DropDownList id=DropDownList4 runat="server" CssClass="letra_pequena" Width="200px" AutoPostBack="True" DataSource="<%# Ds_agen4 %>" DataMember="agen" DataTextField="Agenda" DataValueField="Código">
												</asp:DropDownList></TD>
											<TD height="11">
												<asp:Label id="Label9" runat="server" CssClass="letra_pequena_negrita">Agrupación Cobertura:</asp:Label></TD>
											<TD width="11" height="11">
												<asp:DropDownList id=DropDownList5 runat="server" CssClass="letra_pequena" Width="250px" AutoPostBack="True" DataSource="<%# Ds_covegrou1 %>" DataMember="covegrou" DataTextField="covegroudesclong" DataValueField="covegrou_key">
												</asp:DropDownList></TD>
										</TR>
										<TR>
											<TD width="11" height="11"></TD>
											<TD width="99" height="11">
												<asp:Label id="Label10" runat="server" CssClass="letra_pequena_negrita">Código HCIS:</asp:Label></TD>
											<TD colSpan="2" height="11">
												<asp:DropDownList id=DropDownList6 runat="server" CssClass="letra_pequena" Width="300px" AutoPostBack="True" DataSource="<%# Ds_garante_hcis1 %>" DataMember="garante_hcis" DataTextField="hcis_desc" DataValueField="hcis">
												</asp:DropDownList></TD>
											<TD width="11" height="11"></TD>
										</TR>
									</asp:panel>
						</TD>
					<TR>
						<TD height="11" width="11"></TD>
						<TD height="11" colSpan="2"></TD>
						<TD height="11" width="11"></TD>
						<TD height="11" width="11"></TD>
					</TR>
			</TABLE>
			</TD></TR>
			<TR>
				<TD height="11" colSpan="3" align="center"><asp:button id="Button4" runat="server" Width="120px" Text="Aceptar" Visible="False"></asp:button></TD>
			</TR>
			</asp:panel>
			<TR>
				<TD height="11"></TD>
				<TD height="11"></TD>
				<TD height="11"></TD>
			</TR>
			<TR>
				<TD height="11"></TD>
				<TD height="11"></TD>
				<TD height="11"></TD>
			</TR>
			</TBODY></TABLE></form>
	</body>
</HTML>
