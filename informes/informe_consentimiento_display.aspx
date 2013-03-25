<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_consentimiento_display.aspx.vb" Inherits="zeus.informe_consentimiento_display"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Consentimiento</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px;"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD valign=top>
					<% 
					
					Dim str_menu as string
					
					Dim objCIMA as New CIMA_Clases.CIMA
					
					Dim objDS as New Data.DataSet
					
					str_menu = "dbo.SP_CIMACEX_RECUPERA_CONSENTIMIENTO_BASICO " & Request("id_consentimiento")

					'response.write (str_menu)

					Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

					objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
					
					'response.write(str_menu)
					if objDS.Tables(0).Rows.count > 0 then
					
						Response.Write("<script type=text/javascript>") 
						Response.Write("document.write(unescape('" & objDS.Tables(0).Rows(0).Item(0) & "'))")
						Response.Write("</script>") 
					
					end if
					
					objDS = nothing
								
					%>
					</TD>
				</TR>
			</TABLE>
		</form>
		<script type=text/javascript>
		printPage();
		window.close();
		</script>
	</body>
</HTML>
