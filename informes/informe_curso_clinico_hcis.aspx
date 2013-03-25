<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_curso_clinico_hcis.aspx.vb" Inherits="cimaweb.informe_curso_clinico_hcis"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<TITLE>informe_curso_clinico_hcis</TITLE>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<FRAMESET rows="*,40">
		<frame name="alto" src="informe_curso_clinico.aspx?tipo=hcis&NUMHC=<% =Request("NUMHC") %>">
		<frame name="central" src="informe_botonera_hcis.aspx?tipo=hcis&NUMHC=<% =Request("NUMHC") %>">
	</FRAMESET>
</HTML>
