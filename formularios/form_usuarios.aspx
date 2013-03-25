<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_usuarios.aspx.vb" Inherits="zeus.form_usuarios"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_usuarios</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Mantenimiento 
						de Usuarios</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Usuario: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" DataValueField="id_usuario" DataTextField="descripcion" DataMember="cima_usuarios" DataSource="<%# Ds_usuarios1 %>" AutoPostBack="True">
						</asp:dropdownlist>
						&nbsp;&nbsp;
						<asp:Button id="Button2" runat="server" Text="Nuevo" Width="120px"></asp:Button></TD>
					<td></td>
					<td></td>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3" height="120"><asp:datalist id=DataList1 runat="server" DataMember="cima_usuarios" DataSource="<%# Ds_usuarios1 %>" DataKeyField="id_usuario" BorderColor="#3366CC" BorderStyle="None" BackColor="White" CellPadding="4" GridLines="Both" BorderWidth="1px" Height="120px" Width="100%" Font-Size="7pt" Font-Names="Verdana">
							<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
							<HeaderTemplate>
								Usuario del Sistema
							</HeaderTemplate>
							<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
							<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
							<ItemTemplate>
								<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra_pequena">ID Usuario:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=id_usuario runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_usuario") %>'>
												</asp:TextBox></P>
										</TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra_pequena">Descripción Usuario:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=descripcion runat="server" Width="275px" Text='<%# DataBinder.Eval(Container, "DataItem.descripcion") %>'>
												</asp:TextBox></P>
										</TD>
										<TD width="11"></TD>
										<TD class="letra_pequena">Perfil:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=perfil runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.perfil") %>'>
												</asp:TextBox></P>
										</TD>
									</TR>
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra_pequena">Grupo:</TD>
										<TD>
											<asp:DropDownList id="grupo" runat="server" CssClass="letra_pequena">
												<asp:ListItem Value="A">Administrativo</asp:ListItem>
												<asp:ListItem Value="M">M&#233;dico</asp:ListItem>
												<asp:ListItem Value="E">Enfermeria</asp:ListItem>
												<asp:ListItem Value="D">Administrador</asp:ListItem>
												<asp:ListItem Value="U">MC-Mutual</asp:ListItem>
												<asp:ListItem Value="G">EGARSAT</asp:ListItem>
												<asp:ListItem Value="W">AXA</asp:ListItem>
												<asp:ListItem Value="I">SANITAS</asp:ListItem>
												<asp:ListItem Value="L">Institut Marquès</asp:ListItem>
											</asp:DropDownList></TD>
										<TD width="11"></TD>
										<TD class="letra_pequena">Activo:</TD>
										<TD>
											<asp:CheckBox id=activo runat="server" Checked='<%# CheckBoxEval(DataBinder.Eval(Container, "DataItem.activo")) %>'>
											</asp:CheckBox></TD>
									</TR>
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra_pequena">Nº de Colegiado:</TD>
										<TD>
											<asp:TextBox id=n_colegiado runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.n_colegiado") %>'>
											</asp:TextBox></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
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
						<asp:Button id="Button1" runat="server" Text="Actualizar" Width="120px"></asp:Button></TD>
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
