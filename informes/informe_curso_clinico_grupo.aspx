<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_curso_clinico_grupo.aspx.vb" Inherits="zeus.informe_curso_clinico_grupo"%>
<%@ Register TagPrefix="uo_barra_informes" TagName="uo_barra_informes" Src="../user_objects/uo_barra_informes.ascx" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Curso Clínico Grupo</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<% 
		
		Dim str_menu as string
		'Dim str_menu_2 as string
		Dim objCIMA_2 as New CIMA_Clases.CIMA
		'Dim objCIMA_3 as New CIMA_Clases.CIMA

		Dim objDS as New Data.DataSet
		'Dim objDS_2 as New Data.DataSet

		Dim objRow as Data.DataRow
		Dim objRow2 as Data.DataRow
		
		Dim str_memorion as String
		
		'Dim contador as Integer
		
		'Dim m,d as string
		
		Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
		
		str_menu = "dbo.SP_CIMACEX_RECUPERA_CAMPOS_INFORME " & Session("id_informe")
		
		'objDS = objCIMA_2.f_consulta(str_menu, Session("cadena_conexion"))

		objCIMA_2 = nothing		

		%>
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<td><uo_barra_informes:uo_barra_informes id="uo_barra_informes1" runat="server"></uo_barra_informes:uo_barra_informes></td>
				</TR>
				<TR>
					<TD height="11">
						<HR width="100%" SIZE="1">
					</TD>
				</TR>
				<TR>
					<TD vAlign="top">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 610px" width="610" vAlign="top">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD width="11"><asp:image id="Image1" runat="server" ImageUrl="../imagenes/logo.JPG"></asp:image></TD>
											<TD></TD>
											<TD vAlign="middle">
												<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD class="letra_pequena_negrita" width="11"></TD>
														<TD class="letra_pequena_negrita"></TD>
														<TD class="letra_pequena_negrita" width="11"></TD>
														<TD class="letra_grande_negrita">CURSO CLÍNICO</TD>
													</TR>
													<TR>
														<TD width="11" height="8"></TD>
														<TD width="11" height="8"></TD>
														<TD height="8"></TD>
														<TD height="8"></TD>
													</TR>
													<TR>
														<TD class="letra_pequena_negrita" align="left" width="11"></TD>
														<TD class="letra_pequena_negrita" align="left"></TD>
														<TD class="letra_pequena_negrita"></TD>
														<TD class="letra_pequena_negrita">Paciente:<% =" " & Session("nombre_paciente") %></TD>
													</TR>
													<TR>
														<TD align="left" width="11" height="11"></TD>
														<TD align="left" height="11"></TD>
														<TD height="11"></TD>
														<TD height="11"></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
								</TD>
								<TD style="WIDTH: 11px"></TD>
								<TD vAlign="top" align="left"></TD>
							</TR>
							<%
							
							For Each objRow In Me.Ds_episcode1.Tables(0).Rows

								Me.Ds_curso_clinico1.Clear()

								Me.SqlConnection1.Open()

								Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = objRow.Item(0)

								Me.SqlDataAdapter1.Fill(Me.Ds_curso_clinico1.cima_informes_master)

								Me.SqlConnection1.Close()
								
							For Each objRow2 In Me.Ds_curso_clinico1.Tables(0).Rows
							
							if objRow2.Item(5)<>str_memorion then
							
							str_memorion=objRow2.Item(5)
							
							%>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD class="menu_lateral_izquierdo" colSpan="3" height="11">Episodio:<% =" " & objRow.Item(0) %>
								</TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita" colSpan="3" height="11">Fecha del Episodio:<% =" " & objRow.Item(1) %>&nbsp;&nbsp;Hora 
									de admisión:<% =" " & objRow.Item(4) %></TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita" colSpan="3" height="11">Motivo visita:<% =" " & objRow.Item(5) %></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_titulo_informe" colSpan="3" height="11">Título Informe:<% =" " & objRow2.Item(0) & "   " %></TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita" colSpan="3" height="11">Fecha de Creación:<% =" " & objRow2.Item(3) & "   " %></TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita" colSpan="3" height="11">Autor:<% =" " & objRow2.Item(2) & "   " %></TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<%
							
							end if
							
							%>
							<TR>
								<TD class="fondo_formulario_2" colSpan="3" height="11"><% =objRow2.Item(6) %></TD>
							</TR>
							<TR>
								<TD class="letra" colSpan="3" height="11">
									<script type="text/javascript">
								document.write(unescape('<% =objRow2.Item(1) %>'))
									</script>
								</TD>
							</TR>
							<TR>
								<TD colSpan="3" height="11"></TD>
							</TR>
							<%
							
							next
							
							next
							
							%>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
