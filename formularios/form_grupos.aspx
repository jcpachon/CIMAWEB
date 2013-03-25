<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_grupos.aspx.vb" Inherits="zeus.form_mant_grupos"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mant_grupos</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		if (control=="1"){
			f_abre("../formularios/form_alertas_mensajes.aspx?id_grupo=<% =Session("id_grupo") %>",600,800,"");
		};
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; POSITION: absolute; TOP: 11px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Mantenimiento de Grupos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
				<TR>
					<TD height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Grupos: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataSource="<%# Ds_grupos1 %>" DataMember="cima_grupos" DataTextField="desc_grupo" DataValueField="id_grupo">
						</asp:dropdownlist>&nbsp;&nbsp;
						<asp:button id="Button2" runat="server" Text="Nuevo" Width="120px"></asp:button>&nbsp;&nbsp;
						<asp:button id="Button5" runat="server" Text="Editar" Width="120px"></asp:button>&nbsp;&nbsp;
						<asp:button id="Button6" runat="server" Text="Eliminar" Width="120px"></asp:button></TD>
					<td></td>
					<td></td>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:Panel id="Panel1" runat="server" Visible="False">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD>
										<asp:Label id="Label2" runat="server" CssClass="letra_pequena">Descripción del Grupo: </asp:Label>
										<asp:TextBox id="TextBox1" runat="server" Width="250px"></asp:TextBox>&nbsp;&nbsp;
										<asp:button id="Button4" runat="server" Width="120px" Text="Aceptar"></asp:button></TD>
								</TR>
								<TR>
									<TD height="11"></TD>
								</TR>
								<TR>
									<TD height="11">
										<asp:CheckBox id="CheckBox1" runat="server" CssClass="letra_pequena" Text="Contrato alerta recordatoria de cita vía SMS"
											TextAlign="Left"></asp:CheckBox>
										<asp:Button id="Button7" runat="server" Text="Configurar alertas"></asp:Button></TD>
								</TR>
							</TABLE>
						</asp:Panel></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 19px" colSpan="3" height="19">
						<asp:Panel id="Panel2" runat="server">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD vAlign="top" width="50%">
										<asp:DataGrid id=DataGrid1 runat="server" DataMember="cima_usuarios" DataSource="<%# Ds_pers_grupos1 %>" Width="325px" AllowPaging="True" Font-Names="Verdana" ForeColor="Black" DataKeyField="Código Usuario" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" Font-Size="7pt" PageSize="20">
											<FooterStyle BackColor="#CCCCCC"></FooterStyle>
											<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
											<ItemStyle Font-Size="XX-Small"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
											<Columns>
												<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
										</asp:DataGrid></TD>
									<TD align="center" width="11">
										<P>
											<asp:Button id="Button1" runat="server" Width="100px" Text="Asignar >>>"></asp:Button></P>
										<P>
											<asp:Button id="Button3" runat="server" Width="100px" Text="<<< Desasignar"></asp:Button></P>
									</TD>
									<TD vAlign="top" align="right" width="50%">
										<asp:DataGrid id=DataGrid2 runat="server" DataMember="cima_usuarios" DataSource="<%# Ds_pers_grupos2 %>" Width="325px" AllowPaging="True" Font-Names="Verdana" ForeColor="Black" DataKeyField="Código Usuario" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" Font-Size="7pt" PageSize="20">
											<FooterStyle BackColor="#CCCCCC"></FooterStyle>
											<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
											<ItemStyle Font-Size="XX-Small"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
											<Columns>
												<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
										</asp:DataGrid></TD>
								</TR>
							</TABLE>
						</asp:Panel></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				</TR></TABLE>
		</form>
	</body>
</HTML>
