<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_busca_pers_solicitar_cita.aspx.vb" Inherits="zeus.form_busca_pers_solicitar_cita"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Búsqueda de Pacientes</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="javascript:window.Form1.apnombre.focus();">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
	function enviar(pers_key,dni,persona){
	
		/*opener.recarga.persona.value=persona;
		opener.recarga.pers_key.value=pers_key;
		opener.recarga.persona_ok.value='S';
		opener.recarga.dia_seleccionado.value='<% =Session("dia_seleccionado") %>';
		opener.recarga.agencode.value='<% =Session("agencode") %>';
		opener.recarga.DropDownList1.value='<% =Session("DropDownList1") %>';
		opener.recarga.DropDownList2.value='<% =Session("DropDownList2") %>';
		opener.recarga.DropDownList3.value='<% =Session("DropDownList3") %>';
		opener.recarga.DropDownList4.value='<% =Session("DropDownList4") %>';
        opener.recarga.submit();
        window.close();*/
        
        retorno.retorno_ok.value="S";
        retorno.retorno_pers_key.value=pers_key;
        retorno.retorno_persona.value=persona;
        retorno.submit();
       
	
	}
		</script>
		<form name="retorno">
			<input type="hidden" name="retorno_ok"> <input type="hidden" name="retorno_pers_key">
			<input type="hidden" name="retorno_persona">
		</form>
		<%
		if Session("control") = "True" then
		%>
		<form name=persona 
action='../formularios/form_solicitar_cita.aspx?persona_ok=S&amp;dia_seleccionado=<% =Session("dia_seleccionado") %>&amp;agencode=<% =Session("agencode") %>' 
method=post>
			<!--input type="hidden" name="pers_key"> 
			<input type="hidden" name="dni"> 
			<input type="hidden" name="nombre">
			<input type="hidden" name="control"--></form>
		<%
		else
		%>
		<form name="persona" action="form_pers.aspx" method="post">
			<!--input type="hidden" name="pers_key"> 
			<input type="hidden" name="nombre"> 
			<input type="hidden" name="dni">
			<input type="hidden" name="control"--></form>
		<%
		end if
		%>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="9" height="22">Búsqueda de Pacientes</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" width="11"><asp:label id="Label1" runat="server" CssClass="letra_pequena" Width="170px">Apellidos, Nombre (* de comodín):   </asp:label></TD>
					<TD style="WIDTH: 12px; HEIGHT: 22px" width="12"><asp:textbox id="apnombre" tabIndex="1" runat="server" Width="250px"></asp:textbox></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px" width="11"><asp:label id="Label2" runat="server" CssClass="letra_pequena">DNI:   </asp:label></TD>
					<TD style="HEIGHT: 22px" width="11"><asp:textbox id="dni" runat="server"></asp:textbox></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px" width="11"><asp:button id="Button1" tabIndex="2" runat="server" Width="150px" Text="Buscar"></asp:button></TD>
					<TD style="HEIGHT: 22px" width="11"></TD>
					<TD style="HEIGHT: 22px"><asp:image id="Image1" runat="server" ImageUrl="../imagenes/lupa.jpg"></asp:image></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="2" height="11"><asp:checkbox id="CheckBox1" tabIndex="3" runat="server" CssClass="letra_pequena_negrita" Width="144px"
							Text="Pacientes propios" TextAlign="Left" Enabled="False"></asp:checkbox></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
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
					<TD width="11" height="11"></TD>
					<TD align="right" colSpan="3" height="11"><asp:button id="Button2" tabIndex="2" runat="server" Width="150px" Text="Nuevo Paciente" Visible="False"></asp:button></TD>
				</TR>
				<% if ispostback then 
				
				%>
				<TR>
					<TD height="11"></TD>
					<TD style="WIDTH: 12px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD class="cabecera_busca_pacientes" colSpan="9" height="11">Resultado de la 
						búsqueda
					</TD>
				</TR>
				<TR>
					<TD colSpan="9" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD class="fondo_formulario">Paciente</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">DNI</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Nº HC</TD>
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
							
							Dim objRow as Data.DataRow
						
							Dim contador as integer
							
							Dim str_dni as string
							
							str_dni = f_depuracion_dni(Request("dni"))
							
							'Me.OdbcConnection1.Open()
							Me.OdbcConnection2.Open()
							
							'OdbcDataAdapter1.SelectCommand.Transaction = Me.OdbcConnection1.BeginTransaction(IsolationLevel.ReadUncommitted)

							if len(Trim(UCase(Request("apnombre")))) = 0 and len(Trim(UCase(str_dni))) > 0 then
							
								'Me.OdbcDataAdapter1.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persidencod1) like '%" & Trim(UCase(str_dni)) & "%' or upper(persidencod2) like '%" & Trim(UCase(str_dni)) & "%' order by persfullname"
								ME.OdbcDataAdapter2.SelectCommand.Parameters(1).Value=Trim(UCase(str_dni))
								Me.OdbcDataAdapter2.Fill(Me.Ds_busca_pers1.pers)
								'Me.OdbcDataAdapter2.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persidencod1) like '%" & Trim(UCase(str_dni)) & "%' or upper(persidencod2) like '%" & Trim(UCase(str_dni)) & "%' order by persfullname"
							
							elseif len(Trim(UCase(Request("apnombre")))) > 0 and len(Trim(UCase(str_dni))) > 0 then
							
								'Me.OdbcDataAdapter1.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persfullname) like '%" & Trim(UCase(Request("apnombre"))) & "%' and (upper(persidencod1) like '%" & Trim(UCase(str_dni)) & "%' or upper(persidencod2) like '%" & Trim(UCase(str_dni)) & "%') order by persfullname"
								ME.OdbcDataAdapter3.SelectCommand.Parameters(1).Value=Trim(UCase(str_dni))
								ME.OdbcDataAdapter3.SelectCommand.Parameters(2).Value=Trim(UCase(Request("apnombre")))
								Me.OdbcDataAdapter3.Fill(Me.Ds_busca_pers1.pers)
								'Me.OdbcDataAdapter2.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persfullname) like '%" & Trim(UCase(Request("apnombre"))) & "%' and (upper(persidencod1) like '%" & Trim(UCase(str_dni)) & "%' or upper(persidencod2) like '%" & Trim(UCase(str_dni)) & "%') order by persfullname"
							
							else
							
								'Me.OdbcDataAdapter1.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persfullname) like '%" & Trim(UCase(Request("apnombre"))) & "%' order by persfullname"
								ME.OdbcDataAdapter4.SelectCommand.Parameters(1).Value=Trim(UCase(Request("apnombre")))
								Me.OdbcDataAdapter4.Fill(Me.Ds_busca_pers1.pers)
								'Me.OdbcDataAdapter2.SelectCommand.CommandText = "select pers_key, persfullname, persidencod1, persidencod2 from pers where upper(persfullname) like '%" & Trim(UCase(Request("apnombre"))) & "%' order by persfullname"
							
							end if
			
							'Me.OdbcDataAdapter1.Fill(Me.Ds_busca_pers1.pers)
				
							for each objRow in Me.Ds_busca_pers1.pers.Rows
							
							contador = contador + 1
							
							%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" 
        onclick="javascript:enviar(<% =objRow.Item(0) %>,'<% =objRow.Item(2) %>','<% =objRow.Item(1) %>');"onmouseout="javascript:this.className='letra_pequena';" height=11 
        >
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(1) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(2) %></TD>
								<TD width="11"></TD>
								<TD class="letra_pequena_negrita_hand"><% =objRow.Item(4) %></TD>
								<TD width="11"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
							
							next
							
							Me.OdbcConnection1.Close()
							
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
					<TD colSpan="9" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
