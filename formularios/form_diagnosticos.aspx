<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_diagnosticos.aspx.vb" Inherits="zeus.form_diagnosticos"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Diagnósticos</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" height="100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Diagnósticos</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="350"></TD>
					<TD vAlign="top" align="center" height="350"><asp:datagrid id=DataGrid1 runat="server" AllowPaging="True" DataSource="<%# Ds_diagnosticos1 %>" DataMember="diagnosticos" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" CssClass="letra_pequena" ForeColor="Black" Font-Size="7pt" Font-Names="Verdana" Width="100%" AutoGenerateColumns="False">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="6pt" Font-Names="Verdana"></ItemStyle>
							<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
								<asp:BoundColumn DataField="Episodio" SortExpression="Episodio" HeaderText="Episodio"></asp:BoundColumn>
								<asp:BoundColumn DataField="C&#243;digo" SortExpression="C&#243;digo" HeaderText="C&#243;digo"></asp:BoundColumn>
								<asp:BoundColumn DataField="Diagn&#243;stico" SortExpression="Diagn&#243;stico" HeaderText="Diagn&#243;stico"></asp:BoundColumn>
								<asp:BoundColumn DataField="Fecha Diagn&#243;stico" SortExpression="Fecha Diagn&#243;stico" HeaderText="Fecha Diagn&#243;stico">
									<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="Doctor" SortExpression="Doctor" HeaderText="Doctor"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
						</asp:datagrid></TD>
					<TD height="350"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11">
						<HR width="100%" SIZE="1">
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="letra_pequena_negrita" height="11"></TD>
								<TD align="right" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita">Diagnóstico:
									<asp:dropdownlist id=DropDownList1 runat="server" DataSource="<%# Ds_cie91 %>" DataMember="cie9" CssClass="letra_pequena" Width="350px" DataValueField="cie9_key" DataTextField="cie9desc">
									</asp:dropdownlist></TD>
								<TD align="right"><asp:button id="Button4" runat="server" Width="150px" Text="Insertar"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="33"></TD>
					<TD align="center" height="33">
						<HR width="100%" SIZE="1">
					</TD>
					<TD height="33"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="right" height="11">&nbsp;
						<asp:button id="Button3" runat="server" Width="150px" Text="Eliminar"></asp:button>&nbsp;
						<asp:button id="Button2" runat="server" Width="150px" Text="Cerrar"></asp:button></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
