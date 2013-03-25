<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_botonera_hcis.aspx.vb" Inherits="cimaweb.informe_botonera_hcis"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>informe_botonera_hcis</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<script language="javascript">
	
	function visualizar_historico_radiologia(){
	
	var sFeatures="dialogHeight: 400px; dialogWidth: 600px; center:yes; resizable:no;";
	window.showModalDialog("../formularios/form_historico_radiologia_hcis.aspx?NUMHC=<% =Request("NUMHC") %>","",sFeatures)
	
	}
	
	function visualizar_historico_laboratorio(){
	
	var sFeatures="dialogHeight: 400px; dialogWidth: 500px; center:yes; resizable:no;";
	window.showModalDialog("../formularios/form_historico_laboratorio_hcis.aspx?NUMHC=<% =Request("NUMHC") %>","",sFeatures)
	
	}
	
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD height="3"></TD>
					<TD height="3"></TD>
					<TD height="3"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 23px" align="center">
						<INPUT style="WIDTH: 150px" onclick="javascript:visualizar_historico_laboratorio();" value="Histórico LABORATORIO"
							type="button"></TD>
					<TD style="HEIGHT: 23px" width="150"></TD>
					<TD style="HEIGHT: 23px" align="center">
						<INPUT style="WIDTH: 150px" onclick="javascript:visualizar_historico_radiologia();" value="Histórico RADIOLOGÍA"
							type="button"></TD>
				</TR>
				<TR>
					<TD height="3"></TD>
					<TD height="3"></TD>
					<TD height="3"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
