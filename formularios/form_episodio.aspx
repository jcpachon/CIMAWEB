<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_episodio.aspx.vb" Inherits="zeus.form_episodio"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_episodio</title>
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
		//f_abre("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episodio_origen") %>",300,600,"");
		window.showModalDialog("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episodio_origen") %>", "","dialogWidth=40;dialogHeight=20;")
        this.close();
	}
	else if (control=="2"){
		//location.href="../formularios/form_pers.aspx?episcode=<% =Session("episodio_origen") %>&pers_key=<% =Session("pers_key_origen") %>&DropDownList1=<% =Session("DropDownList1_origen") %>&agenda_seleccionada=<% =Session("agenda_seleccionada") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&control=<% =Session("control") %>&mutua=<% =Session("mutua") %>&nacimiento=<% =Session("nacimiento") %>&cove=<% =Session("cove") %>";
		location.href="../formularios/form_pers.aspx?episcode=<% =Session("episcode") %>&pers_key=<% =Session("pers_key_origen") %>&DropDownList1=<% =Session("DropDownList1_origen") %>&agenda_seleccionada=<% =Session("agenda_seleccionada") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&control=<% =Session("control") %>&mutua=<% =Session("mutua") %>&nacimiento=<% =Session("nacimiento") %>&cove=<% =Session("cove") %>";
	}
	else if (control=="3"){
		//window.showModalDialog("../galeria/form_galeria.aspx?episcode=<% =Session("episodio_origen") %>", "","dialogWidth=65;dialogHeight=45;")
		f_abre("../galeria/form_galeria.aspx?episcode=<% =Session("episodio_origen") %>",650,900,"");
	};
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100" border="0">
				<TR>
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22"><asp:label id="Label1" runat="server">Label</asp:label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:label id="Label2" runat="server" CssClass="letra_negrita">Paciente:</asp:label><asp:label id="Label3" runat="server" CssClass="letra" Width="472px"></asp:label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="11"><asp:button id="Button5" runat="server" Width="130px" ForeColor="White" BackColor="MidnightBlue"
										Text="Informe Visita"></asp:button></TD>
								<TD width="11"></TD>
								<TD><asp:button id="Button3" runat="server" Width="150px" Text="Volver"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" colSpan="3" height="22">Galería Multimedia</TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD><asp:button id="Button4" runat="server" Width="150px" Text="Galería"></asp:button></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" height="22">Mutuas</TD>
								<TD width="11" height="22"></TD>
								<TD height="22"></TD>
								<TD height="22"></TD>
								<TD height="22"></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD vAlign="top" width="350" height="11">
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD><asp:radiobutton id="RadioButton1" runat="server" CssClass="letra_pequena" Text="CIMA" AutoPostBack="True"
													Checked="True" GroupName="tipo"></asp:radiobutton></TD>
											<TD><asp:radiobutton id="RadioButton2" runat="server" CssClass="letra_pequena" Text="Grupo" AutoPostBack="True"
													GroupName="tipo"></asp:radiobutton></TD>
											<TD><asp:dropdownlist id=DropDownList2 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataValueField="id_grupo" DataTextField="desc_grupo" DataMember="cima_grupos" DataSource="<%# Ds_grupos1 %>">
												</asp:dropdownlist></TD>
											<TD><asp:radiobutton id="RadioButton3" runat="server" CssClass="letra_pequena" Text="Persona" AutoPostBack="True"
													GroupName="tipo"></asp:radiobutton></TD>
										</TR>
									</TABLE>
								</TD>
								<TD width="11" height="11"></TD>
								<TD vAlign="top" height="11"><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" Width="240px" DataValueField="id_garante" DataTextField="firm_name" DataMember="cima_garantes" DataSource="<%# Ds_cima_garantes1 %>">
									</asp:dropdownlist></TD>
								<TD vAlign="top" height="11"></TD>
								<TD vAlign="top" height="11"><asp:button id="Button1" runat="server" Width="150px" Text="Añadir"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
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
					<TD colSpan="3" height="11">
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD>
									<asp:datagrid id=Datagrid1 runat="server" Width="450px" BackColor="White" ForeColor="Black" DataSource="<%# Ds_cima_garantes_epis1 %>" DataMember="cima_garantes" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical" DataKeyField="Código" ShowFooter="True" Font-Size="7pt" Font-Names="Verdana">
										<FooterStyle Width="60%" BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
										<ItemStyle CssClass="letra_pequena"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
									</asp:datagrid></TD>
								<TD width="11"></TD>
								<TD vAlign="top" align="right"><asp:button id="Button2" runat="server" Width="150px" Text="Eliminar"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 262px"></TD>
					<TD></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
