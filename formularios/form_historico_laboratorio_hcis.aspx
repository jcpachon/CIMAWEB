<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_historico_laboratorio_hcis.aspx.vb" Inherits="cimaweb.form_historico_laboratorio_hcis"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Histórico Laboratorio</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		
		<script type="text/javascript">
		
		function abrir_informe(episcode,numero,nombre){
		
		open_informe.abrir_informe.value="S";
		open_informe.episcode_informe.value=episcode;
		open_informe.numero_informe.value=numero;
		open_informe.nombre_informe.value=nombre;
		
		open_informe.submit();
		
		}
		</script>
		<form id="open_informe">
			<input type="hidden" name="abrir_informe"><input type="hidden" name="episcode_informe">
			<input type="hidden" name="numero_informe"> <input type="hidden" name="nombre_informe">
			<input type="hidden" name="pers_key" value='<% =Session("pers_key") %>'>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="98%" border="0">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Histórico Laboratorio -
						<% =Session("pers_key") %>
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD vAlign="middle" align="center">
						<TABLE id="Table22" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR height="11">
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
									
							Dim str_menu as string
											
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							Dim contador as integer
							
							
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.[SP_CIMACEX_RECUPERA_PERS_INFORMES] '" & Session("pers_key") & "','echevarne.carga'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							contador = 0
							
							for each objRow in objDS.Tables(0).Rows
							
							contador = contador + 1
									
							%>
							<TR>
								<TD colspan="2" class="letra_pequena_negrita" style="CURSOR: hand" onclick="javascript:abrir_informe('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"><IMG alt="" src="../imagenes/acrobat.gif">&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %></TD>
								<TD class="letra_pequena_negrita" style="CURSOR: hand" align="right"><asp:label id="Label11" runat="server" Height="18" Visible="False" CssClass="informe_entregado"
										Width="175px">Informe Entregado</asp:label></TD>
							</TR>
							<TR height="11">
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
								
								next
							
								end if
								
							%>
						</TABLE>
					</TD>
					<TD></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11"><INPUT style="WIDTH: 150px" onclick="javascript:window.close();" type="button" value="Cerrar">
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
