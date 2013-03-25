<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_seleccion_migracion.aspx.vb" Inherits="zeus.form_seleccion_migracion"%>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="uo_fechas" TagName="uo_fechas" Src="../user_objects/uo_fechas.ascx" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_seleccion_migracion</title>
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
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Migración 
						Datos de Grupo</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:label id="Label2" runat="server" CssClass="letra_pequena_negrita">Seleccione la franja diaria:</asp:label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="250"><uo_fechas:uo_fechas id="uo_fechas1" runat="server"></uo_fechas:uo_fechas></TD>
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
					<TD align="right" colSpan="3" height="11"><asp:button id="Button1" runat="server" Text="Enviar" Width="150px"></asp:button></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<CR:CrystalReportViewer id="CrystalReportViewer1" runat="server" Width="350px" Height="50px" HasSearchButton="False"
							HasZoomFactorList="False" HasDrillUpButton="False" HasGotoPageButton="False" HasPageNavigationButtons="False"
							DisplayToolbar="False" SeparatePages="False" BestFitPage="False" Visible="False"></CR:CrystalReportViewer></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
