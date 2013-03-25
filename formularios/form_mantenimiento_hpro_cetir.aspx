<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_hpro_cetir.aspx.vb" Inherits="zeus.form_mantenimiento_hpro_cetir" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_hpro_cetir</title>
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
	
	function eliminar(id_hpro_cetir){
	
		document.eliminar_mapeo.id_hpro_cetir.value = id_hpro_cetir;
		document.eliminar_mapeo.eliminar.value = "S";
		document.eliminar_mapeo.submit();
	
	}
	
		</script>
		<form name="eliminar_mapeo">
			<input type="hidden" name="eliminar"> <input type="hidden" name="id_hpro_cetir">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Mapeo Prestaciones CIMA - 
						CETIR</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="menu_lateral_izquierdo" align="center" height="11" width="50%">Prestación 
									CIMA</TD>
								<TD width="11" height="11"></TD>
								<TD class="menu_lateral_izquierdo" align="center" height="11" width="50%">
									Prestación CETIR</TD>
							</TR>
							<TR>
								<TD align="center" height="11" width="50%"></TD>
								<TD width="11" height="11"></TD>
								<TD align="center" height="11" width="50%"></TD>
							</TR>
							<TR>
								<TD align="center" width="50%" height="11">
									<asp:dropdownlist id=Dropdownlist2 runat="server" CssClass="letra_pequena" DataValueField="hpro_key" DataTextField="hprodesclong" DataMember="hpro" DataSource="<%# Ds_hpro1 %>" Width="280px" AutoPostBack="True">
									</asp:dropdownlist></TD>
								<TD width="11" height="11">
									<asp:Button id="Button1" runat="server" Text="<< Mapear >>" Width="100px" CssClass="letra_pequena"></asp:Button></TD>
								<TD align="center" width="50%" height="11">
									<asp:dropdownlist id=Dropdownlist3 runat="server" CssClass="letra_pequena" DataValueField="ID_Prova" DataTextField="descripcion" DataMember="cima_prestaciones_cetir" DataSource="<%# Ds_cima_prestaciones_cetir1 %>" Width="280px" AutoPostBack="True">
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD align="center" width="50%" height="33"></TD>
								<TD width="11" height="33"></TD>
								<TD align="center" width="50%" height="33"></TD>
							</TR>
							<TR>
								<TD vAlign="top" width="50%" colSpan="3">
									<%
											'Dim str_menu as string
																	
											'Dim objCIMA as New CIMA_Clases.CIMA
											
											'Dim objDS as New Data.DataSet
											
											Dim objRow as Data.DataRow
											
											
											if Me.Ds_hpro_cetir1.cima_hpro_cetir.Rows.Count > 0 then
										%>
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fecha_letra" width="200">Prestación CIMA</TD>
											<TD class="fecha_letra" width="11"></TD>
											<TD class="fecha_letra" width="200">Prestación CETIR</TD>
											<TD class="fecha_letra" width="11"></TD>
											<TD class="fecha_letra"></TD>
										</TR>
										<TR>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD align="right" height="11"></TD>
										</TR>
										<%
										for each objRow in Me.Ds_hpro_cetir1.cima_hpro_cetir.Rows
										%>
										<TR>
											<TD class="letra_pequena"><% =objRow.Item("hprodesclong") %></TD>
											<TD></TD>
											<TD class="letra_pequena"><% =objRow.Item("descripcion") %></TD>
											<TD></TD>
											<TD align="right"><INPUT style="WIDTH: 150px" type="button" value="Eliminar" onclick="javascript:eliminar(<% =objRow.Item("id_hpro_cetir") %>);"></TD>
										</TR>
										<TR>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
										</TR>
										<%
										next
										%>
									</TABLE>
									<%
									
									end if
									
									%>
								</TD>
							</TR>
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
