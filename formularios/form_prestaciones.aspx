<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_prestaciones.aspx.vb" Inherits="zeus.form_prestaciones" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Prestaciones</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="98%" border="0">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Prestaciones -
						<% =Session("episcode") %>
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
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="cabecera_formulario" width="150">Código</TD>
								<TD width="11"></TD>
								<TD class="cabecera_formulario">Descripción</TD>
							</TR>
							<TR height="22">
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
							
							'Dim str_menu as string
											
							'Dim objCIMA as New CIMA_Clases.CIMA
							
							'Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							'Dim contador as integer
							
							
							
							Me.SqlDataAdapter9.SelectCommand.Parameters(1).Value = Session("episcode")
							Me.SqlConnection1.Open()
							Me.SqlDataAdapter9.Fill(Me.Ds_hpro1.hpro)
							Me.SqlConnection1.Close()
							
							if Me.Ds_hpro1.hpro.rows.count > 0 then
							
							'Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							'str_menu = "dbo.[SP_CIMACEX_RECUPERA_EPIS_INFORMES] '" & Session("episcode") & "'"
			
							'objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							for each objRow in Me.Ds_hpro1.hpro.Rows
							
							%>
							<TR class="letra_pequena_negrita">
								<TD height="11" style="padding-left: 11px;"><% =objRow.Item("hprocode") %></TD>
								<TD height="11"></TD>
								<TD height="11" style="padding-left: 11px;"><% =objRow.Item("hprodesclong") %></TD>
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
					<TD align="center" height="11">
						<INPUT type="button" value="Cerrar" onclick="javascript:window.close();" style="WIDTH: 150px">
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
