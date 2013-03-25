<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="uo_barra_informes" TagName="uo_barra_informes" Src="../user_objects/uo_barra_informes.ascx" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_basico_receta_display.aspx.vb" Inherits="zeus.informe_basico_receta_display"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Receta</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/vbscript">
		<!-- 
		function imprimir ()
		dim WSHNetwork 
		dim clPrinters
		dim WSHShell 



		Set WSHShell = CreateObject("WScript.Shell")
		'Set WSHNetwork = CreateObject("WScript.Network")
		'Set clPrinters = WshNetwork.EnumPrinterConnections
	
		Form1.impresora_p.value=WSHShell.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows\Device")
		Form1.submit
		
		end function
		-->
		</script>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" name="impresora_p">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<td><IMG onclick="imprimir()" alt="" src="../imagenes/print.gif" style="CURSOR: hand"></td>
				</TR>
				<TR>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="BORDER-RIGHT: blue 1px solid; BORDER-TOP: blue 1px solid; BORDER-LEFT: blue 1px solid; BORDER-BOTTOM: blue 1px solid"
						height="11"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" runat="server" SeparatePages="False" DisplayGroupTree="False"
							HasGotoPageButton="False" Height="50px" BorderColor="Black" Width="350px" HasZoomFactorList="False" HasDrillUpButton="False"
							DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER></TD>
				</TR>
				<TR>
					<TD vAlign="top" height="100%"></TD>
				</TR>
				<TR>
					<TD class="letra_pequena" vAlign="bottom" align="center" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
