<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_mutuas.aspx.vb" Inherits="zeus.form_mantenimiento_mutuas"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
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
						de Mutuas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Mutua: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" DataValueField="id_garante" DataTextField="firm_name" DataMember="cima_garantes" DataSource="<%# Ds_cima_garantes1 %>" AutoPostBack="True">
						</asp:dropdownlist>
						&nbsp;&nbsp;
						<asp:Button id="Button2" runat="server" Text="Nuevo" Width="120px" Visible="False"></asp:Button></TD>
					<td></td>
					<td></td>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3" height="120"><asp:datalist id=DataList1 runat="server" DataMember="cima_garantes" DataSource="<%# Ds_cima_garantes1 %>" DataKeyField="id_garante" BorderColor="#3366CC" BorderStyle="None" BackColor="White" CellPadding="4" GridLines="Both" BorderWidth="1px" Height="120px" Width="100%" Font-Size="7pt" Font-Names="Verdana">
							<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
							<HeaderTemplate>
								Mutua
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
										<TD class="letra_pequena">ID Mutua:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=id_garante runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_garante") %>' Enabled="False">
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
									<TR height="11">
										<TD class="letra_pequena">firm_key (Sólo CIMA):</TD>
										<TD>
											<asp:TextBox id=firm_key runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.firm_key") %>'>
											</asp:TextBox></TD>
										<TD width="11"></TD>
										<TD class="letra_pequena">firm_code (Sólo CIMA):</TD>
										<TD>
											<asp:TextBox id=firmcode runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.firmcode") %>'>
											</asp:TextBox></TD>
									</TR>
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD width="11"></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra_pequena">Descripción Mutua:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=descripcion runat="server" Width="275px" Text='<%# DataBinder.Eval(Container, "DataItem.firm_name") %>'>
												</asp:TextBox></P>
										</TD>
										<TD width="11"></TD>
										<TD class="letra_pequena"></TD>
										<TD>
											<P>&nbsp;</P>
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
										<TD class="letra_pequena">Creador:</TD>
										<TD>
											<asp:TextBox id=id_creador runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_creador") %>' Enabled="False">
											</asp:TextBox></TD>
										<TD width="11"></TD>
										<TD class="letra_pequena">Fecha Creación:
										</TD>
										<TD>
											<asp:TextBox id=fecha_creacion runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.fecha_creacion") %>' Enabled="False">
											</asp:TextBox></TD>
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
