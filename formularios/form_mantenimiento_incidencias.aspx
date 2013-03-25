<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_incidencias.aspx.vb" Inherits="cimaweb.form_mantenimiento_incidencias" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_incidencias</title>
		<meta name="vs_showGrid" content="True">
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
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Mantenimiento 
						de Incidencias</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="30"><asp:label id="Label6" runat="server" CssClass="letra_pequena">Incidencia: </asp:label><asp:dropdownlist id=Dropdownlist1 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataMember="incidencias" DataValueField="id_incidencia" DataTextField="descripcion_inc" DataSource="<%# Ds_incidencias1 %>">
						</asp:dropdownlist>
						&nbsp;&nbsp;
						<asp:button id="Button1" runat="server" Width="120px" Text="Nuevo"></asp:button></TD>
					<td></td>
					<td></td>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="120" vAlign="top" colSpan="3"><asp:datalist id=DataList1 runat="server" DataMember="incidencias" Height="120px" Width="75%" DataSource="<%# Ds_incidencias1 %>" DataKeyField="id_incidencia" BorderColor="#3366CC" BorderStyle="None" BackColor="White" CellPadding="4" GridLines="Both" BorderWidth="1px" Font-Size="7pt" Font-Names="Verdana">
							<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
							<HeaderTemplate>
								Incidencia
							</HeaderTemplate>
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
							<ItemTemplate>
								<TABLE id="Table2" border="0" cellSpacing="0" cellPadding="0" width="75%">
									<TR height="11">
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="11"></TD>
										<TD class="letra_pequena">ID Incidencia:</TD>
										<TD>
											<P>
												<asp:TextBox id=id_incidencia runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_incidencia") %>' Enabled="False" ReadOnly="True">
												</asp:TextBox></P>
										</TD>
									</TR>
									<TR height="11">
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="11"></TD>
										<TD class="letra_pequena">Servicio:</TD>
										<TD>
											<asp:DropDownList id="tactcode" runat="server" CssClass="letra_pequena">
												<asp:ListItem Value="RX">RADIOLOGIA</asp:ListItem>
												<asp:ListItem Value="CE">CONSULTAS EXTERNAS</asp:ListItem>
												<asp:ListItem Value="LA">LABORATORIO</asp:ListItem>
												<asp:ListItem Value="UR">URGENCIAS</asp:ListItem>
												<asp:ListItem Value="FA">FARMACIA</asp:ListItem>
											</asp:DropDownList></TD>
										<TD width="11"></TD>
									</TR>
									<TR height="11">
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="11"></TD>
										<TD class="letra_pequena">Código Incidencia:</TD>
										<TD>
											<P>
												<asp:TextBox id=codigo_inc runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.codigo_inc") %>'>
												</asp:TextBox></P>
										</TD>
									<TR height="11">
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="11"></TD>
										<TD class="letra_pequena">Descripción:</TD>
										<TD>
											<P>
												<asp:TextBox id=descripcion_inc runat="server" Width="275px" Text='<%# DataBinder.Eval(Container, "DataItem.descripcion_inc") %>'>
												</asp:TextBox></P>
										</TD>
									</TR>
									<TR height="11">
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="11"></TD>
										<TD class="letra_pequena">Activo:</TD>
										<TD>
											<P>
												<asp:CheckBox id=activo runat="server" Checked='<%# CheckBoxEval(DataBinder.Eval(Container, "DataItem.activo")) %>'>
												</asp:CheckBox></P>
										</TD>
									</TR>
								</TABLE>
							</ItemTemplate>
							<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
						</asp:datalist></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD width="125" height="11">
						<asp:button id="Button2" runat="server" Width="120px" Text="Actualizar"></asp:button></TD>
					<TD width="125" height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD></TD>
					<TD></TD>
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
