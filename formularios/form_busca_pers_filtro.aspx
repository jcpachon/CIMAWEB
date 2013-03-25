<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_busca_pers_filtro.aspx.vb" Inherits="cimaweb.form_busca_pers_filtro"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Búsqueda de Pacientes</title>
		<META content="text/html; charset=windows-1252" http-equiv="Content-Type">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
	
	function enviar(pers_key,episcode,dia,agenda,servicio,persona){
	
		location.href='../formularios/form_pers_externos.aspx?pers_key=' + pers_key + '&episcode=' + episcode + '&dia_seleccionado=' + dia +'&agenda_seleccionada=' + agenda + '&servicio_seleccionado=' + servicio + '';
				
	}
		</script>
		<form name="persona" method="post" action="form_busca_pers_filtro.aspx">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; LEFT: 11px; POSITION: absolute; TOP: 11px" id="Table1" border="0"
				cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD class="cabecera_formulario" height="22" colSpan="15">Búsqueda de Pacientes</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" width="11"><asp:label id="Label1" runat="server" CssClass="letra_pequena" Width="170px">Apellidos, Nombre (* de comodín):</asp:label></TD>
					<TD style="WIDTH: 12px; HEIGHT: 22px" width="12">
						<asp:TextBox id="apnombre" tabIndex="1" runat="server" Width="250px"></asp:TextBox></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px" width="11"><asp:label id="Label2" runat="server" CssClass="letra_pequena">DNI:   </asp:label></TD>
					<TD style="HEIGHT: 22px" width="11">
						<asp:TextBox id="dni" runat="server"></asp:TextBox></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px" width="11">
						<asp:Button id="Button1" tabIndex="2" runat="server" Width="150px" Text="Buscar"></asp:Button></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px"><asp:image id="Image1" runat="server" ImageUrl="../imagenes/lupa.jpg"></asp:image></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11">
						<asp:Label id="Label3" runat="server" CssClass="letra_pequena">NHC:</asp:Label></TD>
					<TD style="WIDTH: 12px" height="11">
						<asp:TextBox id="NHC" runat="server"></asp:TextBox></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11" align="right"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<% if ispostback then %>
				<TR>
					<TD class="cabecera_busca_pacientes" height="11" colSpan="15">Resultado de la 
						búsqueda
					</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="15">
						<TABLE id="Table2" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD class="fondo_formulario">NHC I. Marqués</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Paciente</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">DNI</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Agenda</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Episodio</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" align="center">Fecha</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" align="center">Hora</TD>
								<TD width="11"></TD>
							</TR>
							<%
							Dim objRow as Data.DataRow
						
							Dim contador as integer
							
							Dim str_dni as string
							
							
							str_dni = f_depuracion_dni(Request("dni"))
							
							Me.SqlConnection1.Open()
							
							Me.SqlDataAdapter1.SelectCommand.Parameters(1).Value = Trim(UCase(str_dni))
							Me.SqlDataAdapter1.SelectCommand.Parameters(2).Value = Trim(UCase(Request("apnombre")))
							Me.SqlDataAdapter1.SelectCommand.Parameters(3).Value = Trim(UCase(Request("NHC")))
							Me.SqlDataAdapter1.SelectCommand.Parameters(4).Value = Session("grupo")
							
							Me.SqlDataAdapter1.Fill(Me.Ds_busca_pers_filtro1.pers_filtro)
							
							for each objRow in Me.Ds_busca_pers_filtro1.pers_filtro.Rows
							
							contador = contador + 1
							%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" 
        onmouseout="javascript:this.className='letra_pequena';" 
        onclick="javascript:enviar(<% =objRow.Item(0) %>,'<% =objRow.Item(5) %>','<% =objRow.Item(6) %>','<% =objRow.Item(9) %>','<% =objRow.Item(10) %>','<% =objRow.Item(1) %>');"height=11>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(4) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(1) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(2) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(8) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(5) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand" align="center"><% =objRow.Item(6) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand" align="center"><% =objRow.Item(7) %></TD>
								<TD width="11"></TD>
							</TR>
							<%
							
							next
							
							Me.SqlConnection1.Close()
							
							%>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<% end if %>
				<TR>
					<TD height="11" colSpan="15"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
