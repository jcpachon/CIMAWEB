<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_medicacion_global.aspx.vb" Inherits="zeus.form_medicacion_global"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Medicación</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
	<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form name="seleccion" method="post">
			<input type="hidden" name="cadena_creciente">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Medicación</TD>
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
					<asp:panel id="Panel1" runat="server" Visible="False">
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD align="center" height="150"></TD>
								</TR>
								<TR>
									<TD class="letra_muy_pequena_rojo_negrita" align="center" height="22">NO 
										EXISTE&nbsp;MEDICACIÓN ASOCIADA A ESTE PACIENTE</TD>
								</TR>
								<TR>
									<TD align="center" height="50"></TD>
								</TR>
								<TR>
									<TD align="center"></TD>
								</TR>
							</TABLE>
						</asp:panel>
						<%
						Dim str_menu as string
							
						Dim objCIMA as New CIMA_Clases.CIMA
						
						Dim objDS as New Data.DataSet
						
						Dim objRow as Data.DataRow
						
						Dim contador as integer
						
						Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
						
						str_menu = "dbo.SP_CIMACEX_RECUPERA_MEDICACION_PACIENTE " & Session("pers_key") & ""
		
						objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
						if objDS.Tables(0).Rows.Count > 0 then
						%>
						<TABLE id="Medicacion1" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<tr height="11">
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
							</tr>
							<tr height="11" class="fondo_formulario">
								<td></td>
								<td>Medicación</td>
								<td>Fecha</td>
								<td>Duración</td>
								<td>Episodio</td>
								<td>Posología</td>
								<td>Observaciones</td>
							</tr>
							<tr height="11">
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
							</tr>
							<%
									
												for each objRow in objDS.Tables(0).Rows
												
												contador = contador + 1
												
												%>
							<tr height="11" class="letra_pequena">
								<td></td>
								<td><% =objRow.Item(0) %></td>
								<td><% =objRow.Item(1) %></td>
								<td><% =objRow.Item(2) %></td>
								<td><% =objRow.Item(3) %></td>
								<td><% =objRow.Item(4) %></td>
								<td><% =objRow.Item(5) %></td>
							</tr>
							<%
												
												next
												
												Session("contador") = contador
												
												objRow = Nothing
												objDS = Nothing
												objCIMA = Nothing
												
												%>
							<tr height="11">
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
							</tr>
						</TABLE>
						<% 
						end if
						%>
					</TD>
					<TD></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11"><asp:button id="Button2" runat="server" Width="150px" Text="Cerrar"></asp:button></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
