<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_alertas_mensajes.aspx.vb" Inherits="zeus.form_alertas_mensajes"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Alerta recordatoria de cita vía SMS</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Alerta recordatoria de cita 
						vía SMS</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="30">
						<asp:label id="Label1" runat="server" CssClass="letra_pequena">Grupo: </asp:label>
						<asp:Label id="Label2" runat="server" CssClass="letra" Width="264px" Text='<%# DataBinder.Eval(Ds_grupos1, "Tables[cima_grupos].DefaultView.[0].desc_grupo") %>'>
						</asp:Label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="menu_lateral_izquierdo" align="center" height="11">Agendas</TD>
								<TD style="WIDTH: 11px" width="11" height="11"></TD>
								<TD class="menu_lateral_izquierdo" align="center" height="11">Agendas asignadas al 
									Grupo</TD>
							</TR>
							<TR>
								<TD align="center" height="11"></TD>
								<TD style="WIDTH: 11px" width="11" height="11"></TD>
								<TD align="center" height="11"></TD>
							</TR>
							<TR>
								<TD align="center" vAlign="top" width="375">
									<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# Ds_agen1 %>" DataMember="agen" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" AllowPaging="True" Font-Size="XX-Small" PageSize="15" Width="300px">
										<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
										<AlternatingItemStyle Font-Size="XX-Small" BackColor="#F7F7F7"></AlternatingItemStyle>
										<ItemStyle Font-Size="XX-Small" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
									</asp:DataGrid></TD>
								<TD vAlign="middle" width="*">
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100" border="0">
										<TR>
											<TD height="11">
												<asp:Label id="Label3" runat="server" CssClass="letra_pequena_negrita">Horas previas:</asp:Label></TD>
										</TR>
										<TR>
											<TD height="11"></TD>
										</TR>
										<TR>
											<TD height="11">
												<asp:TextBox id="TextBox1" runat="server" CssClass="letra_pequena" Width="100px"></asp:TextBox></TD>
										</TR>
										<TR>
											<TD height="11"></TD>
										</TR>
										<TR>
											<TD height="22">
												<asp:Button id="Button1" runat="server" Text="Asignar >>>" Width="100px" CssClass="letra_pequena"></asp:Button></TD>
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
								<TD align="center" vAlign="top" width="375">
									<asp:DataGrid id=DataGrid2 runat="server" DataSource="<%# Ds_grupos_agendas1 %>" DataMember="cima_grupos_agen" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" AllowPaging="True" Font-Size="XX-Small" PageSize="15" Width="300px">
										<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
										<AlternatingItemStyle Font-Size="XX-Small" BackColor="#F7F7F7"></AlternatingItemStyle>
										<ItemStyle Font-Size="XX-Small" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
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
