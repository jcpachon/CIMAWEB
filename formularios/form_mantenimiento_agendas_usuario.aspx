<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_agendas_usuario.aspx.vb" Inherits="zeus.form_mantenimiento_agendas_usuario"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_agendas_usuario</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">
						Agendas por Usuario</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="menu_lateral_izquierdo" align="center" height="11" width="50%">Agendas</TD>
								<TD width="11" height="11"></TD>
								<TD class="menu_lateral_izquierdo" align="center" height="11" width="50%">Agendas 
									de Carga</TD>
							</TR>
							<TR>
								<TD align="center" height="11" width="50%"></TD>
								<TD width="11" height="11"></TD>
								<TD align="center" height="11" width="50%"></TD>
							</TR>
							<TR>
								<TD align="center" vAlign="top" width="50%">
									<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# Ds_agen1 %>" DataMember="agen" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" AllowPaging="True" Font-Size="7pt" PageSize="15" Width="325px" ForeColor="Black" Font-Names="Verdana">
										<FooterStyle BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
										<ItemStyle Font-Size="XX-Small"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:DataGrid></TD>
								<TD vAlign="middle" width="11">
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100" border="0">
										<TR>
											<TD>
												<asp:Button id="Button1" runat="server" Text="Asignar >>>" Width="100px" CssClass="letra_pequena"></asp:Button></TD>
										</TR>
										<TR>
											<TD height="22"></TD>
										</TR>
										<TR>
											<TD height="22">
												<asp:Button id="Button3" runat="server" CssClass="letra_pequena" Width="100px" Text="Asignar Todas >"></asp:Button></TD>
										</TR>
										<TR>
											<TD height="22"></TD>
										</TR>
										<TR>
											<TD height="22">
												<asp:Button id="Button4" runat="server" CssClass="letra_pequena" Width="100px" Text="< Desasignar Todas"></asp:Button></TD>
										</TR>
										<TR>
											<TD height="22"></TD>
										</TR>
										<TR>
											<TD>
												<asp:Button id="Button2" runat="server" Text="<<< Desasignar" Width="100px" CssClass="letra_pequena"></asp:Button></TD>
										</TR>
									</TABLE>
								</TD>
								<TD align="center" vAlign="top" width="50%">
									<asp:DataGrid id=DataGrid2 runat="server" DataSource="<%# Ds_usuarios_agendas1 %>" DataMember="cima_usuarios_agen" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" AllowPaging="True" Font-Size="7pt" PageSize="15" Width="325px" ForeColor="Black" Font-Names="Verdana">
										<FooterStyle BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
										<ItemStyle Font-Size="XX-Small"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
									</asp:DataGrid></TD>
							</TR>
						</TABLE>
					</TD>
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
