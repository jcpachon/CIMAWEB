<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_consentimientos.aspx.vb" Inherits="zeus.form_consentimientos"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_consentimientos</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<%
		
		Dim str_menu as string
					
		Dim objCIMA as New CIMA_Clases.CIMA
		
		Dim objDS as New Data.DataSet
		
		str_menu = "dbo.SP_CIMACEX_RECUPERA_CONSENTIMIENTO_BASICO " & Session("id_consentimiento")

		'response.write (str_menu)

		Session("cadena_conexion") = "workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"

		objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
		
		%>
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px"
				cellSpacing="0" cellPadding="0" width="100%" border="0" height="100%">
				<TR>
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Consentimientos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Consentimientos: </asp:label><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataSource='<%# Ds_consentimientos1 %>' DataMember="cima_consentimientos" DataTextField="descripcion" DataValueField="id_consentimiento" Width="250px"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<%
					if objDS.Tables(0).Rows.count > 0 then
					%>
						<DIV class="letra_pequena" style="DISPLAY: inline; WIDTH: 100%; HEIGHT: 15px" ms_positioning="FlowLayout"><b>Descripción 
								Consentimiento:</b><% =" " & objDS.Tables(0).Rows(0).Item(3) %></DIV>
						<%
					end if
					%>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<%
					if objDS.Tables(0).Rows.count > 0 then
					%>
						<DIV class="letra_pequena" style="DISPLAY: inline; WIDTH: 100%; HEIGHT: 15px" ms_positioning="FlowLayout"><b>Autor:</b><% =" " & objDS.Tables(0).Rows(0).Item(4) & " " %><b>Fecha 
								Creación:</b><% =" " & objDS.Tables(0).Rows(0).Item(5) & " " %></DIV>
						<%
					end if
					%>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<HR width="100%" SIZE="1">
					</TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<%
					if objDS.Tables(0).Rows.count > 0 then
					%>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0" height="100%">
							<TR height="11">
								<TD>
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="letra_pequena" style="WIDTH: 70px; CURSOR: hand" onclick='javascript:f_abre("../informes/informe_consentimiento_display.aspx?id_consentimiento=<% =Session("id_consentimiento") %>",700,1000,"consentimiento");'><IMG alt="" src="../imagenes/print.gif" width="16" height="16">&nbsp;&nbsp;Imprimir</TD>
											<TD></TD>
											<TD></TD>
										</TR>
										<tr>
											<TD colSpan="3" height="11">
												<HR width="100%" SIZE="1">
											</TD>
										</tr>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" height="*">
									<% 
								
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
						<%
					end if
					%>
					</TD>
				</TR>
				<TR>
					<TD width="125" height="11"></TD>
					<TD width="125" height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
