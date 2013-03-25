<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_seleccion_plantilla.aspx.vb" Inherits="zeus.form_seleccion_plantilla"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Selección Plantilla</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
	function enviar(id_plantilla){
		var winTop = (screen.height - 768) / 2;
        var winLeft = (screen.width - 1024) / 2;
        ventana=window.open('../informes/informe_basico.aspx?usuario=<% =Session("usuario") %>&episodio=<% =Session("episo") %>&episo=<% =Session("episo") %>&id_plantilla=' + id_plantilla , '', 'height=768,width=1024,top=' + winTop + ',left=' + winLeft + ',screenX=' + winTop + ',screenY=' + winLeft + ', scrollbars=yes');
        window.close();
	}
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="fondo_pie" colSpan="3" height="11">Plantillas disponibles</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" height="100%" border="0">
							<TR>
								<TD class="fondo_formulario">Nombre</TD>
								<TD class="fondo_formulario">Descripción</TD>
								<TD class="fondo_formulario">Propietario</TD>
								<TD class="fondo_formulario">Fecha de Creación</TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<%
							
							Dim str_menu as string
							
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
								
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.SP_CIMACEX_PLANTILLAS_DISPONIBLES '" & Session("usuario") & "'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
				
							for each objRow in objDS.Tables(0).Rows
							
							%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" onclick="javascript:enviar(<% =objRow.Item(0) %>);"
								onmouseout="javascript:this.className='letra_pequena';">
								<TD class="letra_pequena"><% =objRow.Item(1) %></TD>
								<TD class="letra_pequena"><% =objRow.Item(2) %></TD>
								<TD class="letra_pequena"><% =objRow.Item(3) %></TD>
								<TD class="letra_pequena"><% =objRow.Item(4) %></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
							
							next
							
							%>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
