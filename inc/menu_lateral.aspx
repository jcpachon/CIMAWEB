<%@ Page Language="vb" AutoEventWireup="false" Codebehind="menu_lateral.aspx.vb" Inherits="zeus.menu_lateral"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>menu_lateral</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" bottomMargin="0" leftMargin="0" topMargin="0" rightMargin="0">
		<script type="text/javascript">
	function desconectar(){
		f_menu_lateral.desconn.value="S";
		f_menu_lateral.submit();
	}
		</script>
		<form name="f_menu_lateral" method="post">
			<input type="hidden" name="opcion" value='<% =Request("opcion") %>'> <input type="hidden" name="valor" value='<% =Request("valor") %>'>
			<input type="hidden" name="desconn">
		</form>
		<TABLE id="Table1" height="100%" cellSpacing="0" cellPadding="0" width="200" border="0"
			class="fondo_menu_lateral">
			<TR>
				<TD class="menu_lateral" width="200">
					<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0"
						class="menu_lateral">
						<TR>
							<TD colSpan="3" height="11"></TD>
						</TR>
						<TR>
							<td width="11"></td>
							<TD height="18" align="center" class="fondo_formulario" style="CURSOR: hand" onclick="javascript:desconectar();">DESCONECTAR</TD>
							<td width="11"></td>
						</TR>
						<TR>
							<TD colSpan="3" height="11"></TD>
						</TR>
						<TR>
							<TD width="11"><%	
					
					Dim str_menu as string
					Dim str_menu_2 as string
					Dim objCIMA as New CIMA_Clases.CIMA
					Dim objCIMA_2 as New CIMA_Clases.CIMA
					Dim objDS as New Data.DataSet
					Dim objDS_2 as New Data.DataSet
					Dim objDS_USR as New Data.DataSet
					Dim objRow as Data.DataRow
					Dim objRow_2 as Data.DataRow
					
					Dim contador as integer
					
					Dim str_uid As String
					
					if Request("desconn") <> "S" then
					
						str_uid = Request.Cookies("usuario").Value
					
						Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
						str_menu = "dbo.sp_permiso '" & trim(str_uid) & "'"
			
						objDS_USR = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
					
					end if
					
					contador = 0
					
						%></TD>
							<TD vAlign="top" align="left">
								<%
								
							'Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							if len(trim(Request("opcion"))) > 0 and Request("desconn") <> "S" then
					
								str_menu = "dbo.sp_menu_lateral " & Request("opcion") & ",'" & objDS_USR.Tables(0).Rows(0).Item(0) & "'"
			
								objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
				
							%>
								<table id="t_capa1" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<tr class="menu_lateral_izquierdo">
										<td height="20">Contenido</td>
									</tr>
									<tr height="22">
										<td height="11"></td>
									</tr>
									<%	
								
								for each objRow in objDS.Tables(0).Rows
								contador= contador + 1
								%>
									<tr class="letra_pequena" style="CURSOR:hand" onclick="javascript:top.main.location.href='../<% =objRow.Item(1) %>';top.contents.document.f_menu_lateral.valor.value='<% =objRow.Item(2) %>';top.contents.document.f_menu_lateral.submit();">
										<td><img src="../imagenes/indica.gif">&nbsp;<% =objRow.Item(0) %></td>
									</tr>
									<tr height="11">
										<td>
											<div id="capa<% =contador %>">
												<% 								
								if len(trim(Request("valor"))) > 0 then
								if Request("valor") = objRow.Item(2) then
								str_menu_2 = "dbo.sp_menu_sublateral " & objRow.Item(2)
			
								objDS_2 = objCIMA_2.f_consulta(str_menu_2, Session("cadena_conexion"))
								
								%>
												<table border="0" cellspacing="0" cellpadding="0" height="0">
													<%
								
								for each objRow_2 in objDS_2.Tables(0).Rows
								'if Request("valor") = objRow_2.Item(2) then
								%>
													<tr height="11">
														<td colspan="3" height="11"></td>
													</tr>
													<tr class="letra_pequena" style="CURSOR:hand" onclick="javascript:top.main.location.href='../<% =objRow_2.Item(1) %>';">
														<td width="11">&nbsp;</td>
														<td><% =objRow_2.Item(0) %></td>
														<td width="11">&nbsp;</td>
													</tr>
													<%
								'end if
								next
								
								%>
													<tr height="11">
														<td colspan="3" height="11"></td>
													</tr>
												</table>
												<% 
								end if
								end if 
								
								%>
											</div>
										</td>
									</tr>
									<%
							
								next
							%>
								</table>
								<%
							
							end if
							
							'objRow_2 = Nothing
							'objDS_2 = Nothing
							'objCIMA_2 = Nothing
							
							%>
							</TD>
							<TD width="11"></TD>
						</TR>
						<TR>
							<TD colSpan="3"></TD>
						</TR>
					</TABLE>
				</TD>
			</TR>
		</TABLE>
	</body>
</HTML>
