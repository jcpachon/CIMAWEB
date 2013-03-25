<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="uo_fechas" TagName="uo_fechas" Src="../user_objects/uo_fechas.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_seleccion_listado_mutuas.aspx.vb" Inherits="zeus.form_seleccion_listado_mutuas"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_seleccion_listado_mutuas</title>
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
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Selección 
						de Visitas por Mutua</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:Label id="Label1" runat="server" CssClass="letra_pequena_negrita"> Seleccione la Agenda:</asp:Label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataSource="<%# Ds_agendas1 %>" DataMember="cima_usuarios_agen" DataTextField="agenname" DataValueField="agencode">
						</asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:Label id="Label2" runat="server" CssClass="letra_pequena_negrita">Seleccione la franja diaria:</asp:Label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="250">
									<uo_fechas:uo_fechas id="uo_fechas1" runat="server"></uo_fechas:uo_fechas></TD>
								<TD width="11"></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<HR width="100%" SIZE="1">
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11" align="right">
						<asp:Button id="Button1" runat="server" Width="150px" Text="Enviar"></asp:Button></TD>
				</TR>
				<TR>
					<TD colSpan="3">
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
