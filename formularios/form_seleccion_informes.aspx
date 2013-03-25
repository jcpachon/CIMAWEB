<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_seleccion_informes.aspx.vb" Inherits="zeus.form_seleccion_informes"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_seleccion_informes</title>
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
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Selección 
						de Plantillas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 640px" height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Plantilla: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" DataValueField="id_plantilla" DataTextField="descripcion" DataMember="cima_plantillas" DataSource="<%# Ds_plantillas1 %>" AutoPostBack="True" Width="250px">
						</asp:dropdownlist>&nbsp;&nbsp;<asp:button id="Button3" runat="server" Width="120px" Text="Detalles"></asp:button>&nbsp;&nbsp;<asp:button id="Button2" runat="server" Width="120px" Text="Nuevo"></asp:button></TD>
					<td width="11"></td>
					<td></td>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3" height="120"><asp:datalist id=DataList1 runat="server" DataMember="cima_plantillas" DataSource="<%# Ds_plantillas1 %>" DESIGNTIMEDRAGDROP="463" DataKeyField="id_plantilla" BorderColor="Black" BorderStyle="None" BackColor="White" CellPadding="4" GridLines="Both" BorderWidth="1px" Height="120px" Width="100%" Font-Size="XX-Small" Font-Names="Verdana">
							<SelectedItemStyle Font-Bold="True"></SelectedItemStyle>
							<HeaderTemplate>
								Plantilla&nbsp;
							</HeaderTemplate>
							<ItemStyle ForeColor="Black" BackColor="White"></ItemStyle>
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
										<TD class="letra_pequena" width="120">ID Plantilla:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=id_plantilla runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.id_plantilla") %>' Enabled="False">
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
										<TD class="letra_pequena">Nombre:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=descripcion runat="server" Width="200px" Text='<%# DataBinder.Eval(Container, "DataItem.descripcion") %>'>
												</asp:TextBox></P>
										</TD>
										<TD width="11"></TD>
										<TD class="letra_pequena">Descripción:&nbsp; &nbsp;
										</TD>
										<TD>
											<P>
												<asp:TextBox id=informacion runat="server" Width="200px" Text='<%# DataBinder.Eval(Container, "DataItem.informacion") %>'>
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
										<TD class="letra_pequena" style="HEIGHT: 27px">Versión:</TD>
										<TD style="HEIGHT: 27px">
											<asp:Label id=Label2 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.version") %>'>
											</asp:Label></TD>
										<TD style="HEIGHT: 27px" width="11"></TD>
										<TD class="letra_pequena" style="HEIGHT: 27px" width="100">Fecha de Creación:</TD>
										<TD style="HEIGHT: 27px">
											<asp:Label id=Label3 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.fecha_creacion") %>'>
											</asp:Label></TD>
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
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
						</asp:datalist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 640px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 640px" width="640" height="11"><asp:button id="Button1" runat="server" Width="120px" Text="Actualizar"></asp:button></TD>
					<TD width="125" height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 640px"></TD>
					<TD></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 640px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
