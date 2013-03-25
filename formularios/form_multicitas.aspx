<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_multicitas.aspx.vb" Inherits="cimaweb.form_multicitas"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_multicitas</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		if (control=="1"){
			f_abre_modal("../formularios/form_busca_persona_multicitas.aspx?Dropdownlist1=<% =Request("Dropdownlist1") %>&Dropdownlist5=<% =Request("Dropdownlist5") %>",600,900,"");
		};
		</script>
		<script type="text/javascript">
		
		
		
		function citar(fecha,hora_ini,hora_fin,btimetabcode){
			
			document.envio_cita.fecha_cita.value=fecha;
			document.envio_cita.btimetabcode.value = btimetabcode;
			document.envio_cita.hora_final.value = hora_fin;
			document.envio_cita.hora_inicial.value = hora_ini;
			document.envio_cita.ok_cita.value="S";
			document.envio_cita.retorno_pers_key.value=document.Form1.pers_key_paciente.value;
			document.envio_cita.garante.value=<% if len(trim(me.label15.text)) > 0 then response.write (me.label15.text) else response.write ("0") %>;
			//document.envio_cita.agencode.value = agencode;
			//document.envio_cita.agencode.value = agencode;
		
			document.envio_cita.submit();
		
		}
		
		function enviar_padre(epis_key,episcode){
			
			document.seleccion_padre.epis_key.value=epis_key;
			document.seleccion_padre.episcode.value=episcode;
			
			document.seleccion_padre.ok_padre.value="S";
			
		
			document.seleccion_padre.submit();
		
		}
		
		</script>
		<form name="seleccion" method="post">
			<input type="hidden" name="cadena_creciente">
		</form>
		<form name="seleccion_padre">
			<input type=hidden 
value='<% =Request("pers_key_paciente") %>' name=pers_key_paciente> <input type=hidden value='<% = Request("nombre") %>' 
name=nombre> <input type="hidden" name="epis_key"> <input type="hidden" name="episcode"> <input type="hidden" name="ok_padre">
		</form>
		<form name="envio_cita">
			<input type="hidden" name="fecha_cita"> <input type="hidden" name="hora_inicial">
			<input type="hidden" name="hora_final"> <input type="hidden" value="N" name="ok_cita">
			<input type="hidden" name="btimetabcode"><input type="hidden" name="garante"> <input type="hidden" name="retorno_pers_key">
			<input type=hidden 
value='<% =me.Dropdownlist5.SelectedValue.ToString %>' name=agencode> <input type=hidden 
value='<% =me.Dropdownlist2.SelectedValue.ToString %>' name=doctor> <input type=hidden 
value='<%
IF me.Dropdownlist3.SelectedValue.ToString = "PRIVADO" THEN
RESPONSE.WRITE("0")
ELSE
RESPONSE.WRITE(me.Dropdownlist3.SelectedValue.ToString)
END IF
%>' 
name=firm_key> <input type=hidden 
value='<% =me.Dropdownlist6.SelectedValue.ToString %>' name=covegrou_key> <input type=hidden 
value='<% =me.Dropdownlist4.SelectedValue.ToString %>' name=prestacion>
		</form>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" value="S" name="ok_control"> <INPUT type="hidden" value="0" name="contador">
			<TABLE id="Table1" style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; TOP: 11px; LEFT: 11px"
				height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" style="HEIGHT: 22px" colSpan="3" height="22">Multicitas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><asp:label id="Label14" runat="server" CssClass="letra_pequena" Font-Bold="True">Paciente: </asp:label><INPUT 
            style="WIDTH: 400px" readOnly value='<% =Request("nombre") %>' name=nombre 
            ><input type=hidden 
            value='<% =Request("pers_key_paciente") %>' name=pers_key_paciente 
            ></TD>
								<TD align="right"><asp:button id="Button2" runat="server" Width="150px" Text="Paciente"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<HR width="100%" SIZE="1">
						<asp:panel id="Panel6" runat="server" Visible="False">
							<TABLE id="Table5" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD width="20"></TD>
									<TD width="11"></TD>
									<TD class="fondo_formulario" width="100">Episodio</TD>
									<TD width="11"></TD>
									<TD class="fondo_formulario" width="100">Tipo actividad</TD>
									<TD width="11"></TD>
									<TD class="fondo_formulario" width="100">Servicio</TD>
									<TD width="11"></TD>
									<TD class="fondo_formulario" width="100">Prestación</TD>
									<TD width="11"></TD>
									<TD class="fondo_formulario" width="100">Fecha creación</TD>
									<TD width="11"></TD>
									<TD></TD>
								</TR>
								<TR height="11">
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<%
								Dim objRow2 as Data.DataRow
								
								if Me.Ds_episodios_multicitas1.SP_CIMACEX_EPISODIOS_MULTICITAS.Rows.Count > 0 then
								for each objRow2 in Me.Ds_episodios_multicitas1.SP_CIMACEX_EPISODIOS_MULTICITAS.Rows
								%>
								<TR>
									<TD class="letra_pequena"><% if objRow2.Item("episopen")="Y" then %><IMG alt="" src="../imagenes/sem_verde.gif">
										<% else %>
										<IMG alt="" src="../imagenes/sem_rojo.gif">
										<% end if %>
									</TD>
									<TD></TD>
									<TD class="letra_pequena"><% =objRow2.Item("episcode") %></TD>
									<TD></TD>
									<TD class="letra_pequena"><% =objRow2.Item("tactdesc") %></TD>
									<TD></TD>
									<TD class="letra_pequena"><% =objRow2.Item("cstadesclong") %></TD>
									<TD></TD>
									<TD class="letra_pequena"><% =objRow2.Item("hprodesclong") %></TD>
									<TD></TD>
									<TD class="letra_pequena"><% =objRow2.Item("episdatecrea") %></TD>
									<TD></TD> <!--JGM asteriscar per veure en mode DISSENY -->
          <TD align=right><INPUT style="WIDTH: 150px" type="button" value="Seleccionar" onclick="javascript:enviar_padre(<% =objRow2.Item("epis_key") %>,'<% =objRow2.Item("episcode") %>');"></TD>
          <!-- JGM -->
								<TR height="3">
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<%
								next
								end if
								%>
							</TABLE>
						</asp:panel></TD>
				</TR>
				<asp:panel id="Panel5" runat="server" Visible="false">
					<TR>
						<TD height="11" vAlign="middle" colSpan="3">
							<asp:label id="Label16" runat="server" CssClass="letra_pequena_negrita">Episodio PADRE: </asp:label>&nbsp;&nbsp;
							<asp:label id="Label17" runat="server" CssClass="letra_pequena_negrita"></asp:label><INPUT 
      value='<% =Request("epis_key") %>' type=hidden name=epis_keyfath></TD>
					</TR>
					<TR>
						<TD height="11" vAlign="middle" colSpan="3"></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 14px" height="14" vAlign="middle" colSpan="3">
							<asp:label id="Label1" runat="server" CssClass="letra_pequena">Servicio: </asp:label>&nbsp;
							<asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" Width="150px" DataValueField="csta_key" DataTextField="cstadesclong" DataMember="csta" DataSource="<%# Ds_csta1 %>" AutoPostBack="True">
							</asp:dropdownlist>&nbsp;
							<asp:label id="Label6" runat="server" Font-Bold="True" CssClass="letra_pequena">Agenda: </asp:label>&nbsp;
							<asp:dropdownlist id=Dropdownlist5 runat="server" CssClass="letra_pequena" Width="200px" DataValueField="agencode" DataTextField="agenname" DataMember="agen" DataSource="<%# Ds_agen_tabla1 %>" AutoPostBack="True">
							</asp:dropdownlist>&nbsp;&nbsp;
							<asp:label id="Label2" runat="server" CssClass="letra_pequena">Doctor: </asp:label>&nbsp;
							<asp:dropdownlist id=Dropdownlist2 runat="server" CssClass="letra_pequena" Width="225px" DataValueField="pers_key" DataTextField="persfullname" DataMember="pers" DataSource="<%# Ds_pers1 %>" AutoPostBack="True">
							</asp:dropdownlist>&nbsp;
							<asp:Label id="Label19" runat="server" CssClass="letra_pequena" Visible="False"></asp:Label></TD>
					</TR>
					<TR>
						<TD class="letra_pequena" height="11" vAlign="middle" colSpan="3"></TD>
					</TR>
					<TR>
						<TD class="letra_pequena" height="22" vAlign="middle" colSpan="3">&nbsp;
							<asp:panel id="Panel4" runat="server" Visible="False" Height="22px">
								<asp:Label id="Label11" runat="server" Width="104px">Horarios de Visita:</asp:Label>
								<asp:label id="Label18" runat="server" CssClass="letra_pequena" Width="560px" Visible="False"></asp:label>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 31px" height="31" colSpan="3">
							<asp:label id="Label3" runat="server" Font-Bold="True" CssClass="letra_pequena">Mutua: </asp:label>&nbsp;
							<asp:dropdownlist id=Dropdownlist3 runat="server" CssClass="letra_pequena" Width="200px" DataValueField="firm_key" DataTextField="firmname" DataMember="firm" DataSource="<%# Ds_firm_garantes1 %>" AutoPostBack="True">
							</asp:dropdownlist>&nbsp;
							<asp:label id="Label12" runat="server" CssClass="letra_pequena" Visible="False">Garante: </asp:label>
							<asp:label id="Label13" runat="server" CssClass="letra_pequena" Width="200px" Visible="False"></asp:label>&nbsp;
							<asp:label id="Label7" runat="server" CssClass="letra_pequena" Visible="False">Agr. de Cob.: </asp:label>&nbsp;
							<asp:dropdownlist id=Dropdownlist6 runat="server" CssClass="letra_pequena" Width="175px" Visible="False" DataValueField="covegrou_key" DataTextField="covegroudesclong" DataMember="covegrou" DataSource="<%# Ds_covegrou1 %>" AutoPostBack="True">
							</asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<asp:Label id="Label15" runat="server" CssClass="letra_pequena" Visible="false"></asp:Label></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<asp:panel id="Panel1" runat="server" Width="100%" Visible="False">
								<asp:TextBox id="TextBox1" runat="server" CssClass="letra" Width="100%" TextMode="MultiLine"
									Rows="3" ReadOnly="True"></asp:TextBox>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD height="11" vAlign="bottom" colSpan="3">
							<HR SIZE="1" width="100%">
						</TD>
					</TR>
					<TR>
						<TD height="11" vAlign="bottom" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<TABLE id="Table6" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD>
										<asp:label id="Label4" runat="server" Font-Bold="True" CssClass="letra_pequena">Prestación: </asp:label>
										<asp:dropdownlist id=Dropdownlist4 runat="server" CssClass="letra_pequena" Width="350px" DataValueField="Tiempo" DataTextField="Descripción" DataMember="prestaciones" DataSource="<%# Ds_prestaciones1 %>" AutoPostBack="True">
										</asp:dropdownlist>&nbsp;&nbsp;
										<asp:Label id="Label10" runat="server" CssClass="letra_muy_pequena_rojo_negrita" Width="175px"
											Visible="False">REQUIERE AUTORIZACIÓN</asp:Label></TD>
									<TD align="right">
										<asp:Button id="Button3" runat="server" Text="Añadir" Width="150px"></asp:Button></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"><%
									
					Dim str_menu_2 as string
											
					Dim objCIMA_2 as New CIMA_Clases.CIMA
					
					Dim objDS_2 as New Data.DataSet
					
					Dim objRow_2 as Data.DataRow
					
					Dim contador_2 as integer
					
					Dim agenproc_key() as string
					
					
					
					Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
					
					if len(trim(Me.DropDownList4.SelectedValue)) > 0 then
					
					agenproc_key=split(Me.DropDownList4.SelectedValue,"/",,1)
					
					str_menu_2 = "dbo.SP_CIMACEX_RECUPERA_DOCUMENTOS " & agenproc_key(UBound(agenproc_key)) & ""
	
					objDS_2 = objCIMA_2.f_consulta(str_menu_2, Session("cadena_conexion"))
					
					if objDS_2.Tables(0).Rows.Count > 0 then
					
					%>
							<TABLE id="Table444" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD class="fecha_letra" colSpan="5">Documentos asociados</TD>
								</TR>
								<TR>
									<TD height="11" colSpan="6"></TD>
								</TR>
								<%
						
					contador_2 = 0
					
					for each objRow_2 in objDS_2.Tables(0).Rows
					
					contador_2 = contador_2 + 1
					
					%>
								<TR style="CURSOR: hand"> <!-- JGM Asteriscar per veure en mode DISSENY -->
          <TD 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% 
						select case objRow_2.Item(0)
							case 1
								response.write("<IMG alt="""" src=""../imagenes/word.gif"">")
							case 2
								response.write("<IMG alt="""" src=""../imagenes/excel.gif"">")
							case 3
								response.write("<IMG alt="""" src=""../imagenes/acrobat.gif"">")
						end select
						%></TD>
          <TD class=letra_pequena_negrita 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow_2.Item(3) %></TD>
          <TD class=letra_pequena 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow_2.Item(1) %></TD>
          <TD class=letra_pequena 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow_2.Item(2) %></TD>
          <!-- JGM -->
									<TD class="letra_pequena" align="center"><% 
							if objRow_2.Item(6)="S" then
								response.write("Enviar por e-mail <input type=""checkbox"" name=""" & cstr(objRow_2.Item(4)) & "*" & cstr(objRow_2.Item(5)) & """>")
							end if
							%></TD>
									<TD class="letra_pequena" align="right"></TD>
								</TR>
								<%
								
					next
					
					'Session("contador") = contador
					
					
					
					%>
								<TR>
									<TD height="11" colSpan="6"></TD>
								</TR>
							</TABLE>
							<%
					end if
					end if
					%>
						</TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<HR SIZE="1" width="100%">
						</TD>
					</TR>
					<TR>
						<TD class="cabecera_busca_pacientes" height="11" colSpan="3">Citas</TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3" align="right">
							<asp:Button id="Button4" runat="server" Text="Eliminar" Width="150px" Visible="false" Enabled="False"></asp:Button></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" vAlign="top" colSpan="3">
							<asp:DataGrid id="DataGrid1" runat="server" Width="100%" Visible="False" BorderWidth="1px" BackColor="White"
								ForeColor="Black" Font-Size="7pt" Font-Names="Verdana" BorderColor="#999999" BorderStyle="Solid"
								CellPadding="3" GridLines="Vertical" PageSize="15">
								<FooterStyle BackColor="#CCCCCC"></FooterStyle>
								<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
								<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
								<ItemStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="Black" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
								<Columns>
									<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
								</Columns>
							</asp:DataGrid></TD>
					</TR>
					<TR>
						<TD height="22" colSpan="3"></TD>
					</TR>
					<TR>
						<TD class="fondo_pie" height="11" colSpan="3">Selección de Cita</TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<asp:radiobutton id="RadioButton1" runat="server" CssClass="letra" Text="Búsqueda de huecos" AutoPostBack="True"
								Checked="True" GroupName="grupo"></asp:radiobutton>
							<asp:radiobutton id="RadioButton2" runat="server" CssClass="letra" Text="Forzar Cita" AutoPostBack="True"
								Enabled="false" GroupName="grupo"></asp:radiobutton></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<TABLE id="Table3" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<asp:panel id="Panel2" runat="server" Visible="true">
									<TBODY>
										<TR>
											<TD width="75">
												<asp:Label id="Label8" runat="server" CssClass="letra">A partir de: </asp:Label></TD>
											<TD>
												<asp:textbox id="fecha_ini" runat="server" CssClass="letra_pequena_centrada" Width="90px" Enabled="False">__/__/____</asp:textbox>
												<asp:imagebutton id="ImageButton1" runat="server" ImageUrl="../imagenes/lupa_pequena.gif"></asp:imagebutton>&nbsp;&nbsp;&nbsp;
												<asp:DropDownList id="DropDownList8" runat="server" CssClass="letra_pequena" Width="150px">
													<asp:ListItem Value="07:00" Selected="True">07:00</asp:ListItem>
													<asp:ListItem Value="08:00">08:00</asp:ListItem>
													<asp:ListItem Value="09:00">09:00</asp:ListItem>
													<asp:ListItem Value="10:00">10:00</asp:ListItem>
													<asp:ListItem Value="11:00">11:00</asp:ListItem>
													<asp:ListItem Value="12:00">12:00</asp:ListItem>
													<asp:ListItem Value="13:00">13:00</asp:ListItem>
													<asp:ListItem Value="14:00">14:00</asp:ListItem>
													<asp:ListItem Value="15:00">15:00</asp:ListItem>
													<asp:ListItem Value="16:00">16:00</asp:ListItem>
													<asp:ListItem Value="17:00">17:00</asp:ListItem>
													<asp:ListItem Value="18:00">18:00</asp:ListItem>
													<asp:ListItem Value="19:00">19:00</asp:ListItem>
													<asp:ListItem Value="20:00">20:00</asp:ListItem>
												</asp:DropDownList></TD>
											<TD align="right">
												<asp:button id="Button1" runat="server" Text="Buscar" Width="150px"></asp:button></TD>
										</TR>
										<TR>
											<TD width="75"></TD>
											<TD>
												<asp:calendar id="Calendar1" runat="server" Width="250px" Visible="False" Height="160px" BorderWidth="1px"
													BackColor="White" ForeColor="Black" Font-Size="9pt" Font-Names="Verdana" BorderColor="White"
													FirstDayOfWeek="Monday" NextPrevFormat="FullMonth">
													<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
													<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
													<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
													<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
													<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
														BackColor="White"></TitleStyle>
													<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
												</asp:calendar></TD>
											<TD></TD>
										</TR>
										<TR>
											<TD width="75"></TD>
											<TD></TD>
											<TD></TD>
										</TR>
								</asp:panel>
								<asp:panel id="Panel3" runat="server" Visible="false">
									<TR>
										<TD class="letra">Fecha:&nbsp;&nbsp;&nbsp;
											<asp:textbox id="Textbox2" runat="server" CssClass="fecha" Width="90px">__/__/____</asp:textbox>
											<asp:imagebutton id="Imagebutton2" runat="server" ImageUrl="../imagenes/lupa_pequena.gif"></asp:imagebutton></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD class="letra">
											<asp:calendar id="Calendar2" runat="server" Width="250px" Visible="False" Height="160px" BorderWidth="1px"
												BackColor="White" ForeColor="Black" Font-Size="9pt" Font-Names="Verdana" BorderColor="White"
												FirstDayOfWeek="Monday" NextPrevFormat="FullMonth">
												<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
												<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
												<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
												<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
												<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
													BackColor="White"></TitleStyle>
												<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
											</asp:calendar></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR>
										<TD height="11" colSpan="3"></TD>
									</TR>
									<TR>
										<TD colSpan="3"><% 
          
          'if Session("dt") <> Nothing then
          
          if Session("dt").Rows.Count > 0 then 
          
          %>
											<TABLE id="Table7" border="0" cellSpacing="0" cellPadding="0" width="100%">
												<TR class="fecha_letra">
													<TD>Servicio</TD>
													<TD></TD>
													<TD>Agenda</TD>
													<TD></TD>
													<TD>Garante</TD>
													<TD></TD>
													<TD>Agr. de Cob.</TD>
													<TD></TD>
													<TD>Prestación</TD>
													<TD></TD>
													<TD>H. Ini.</TD>
													<TD>H. Fin.</TD>
												</TR>
												<TR height="11">
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
												</TR>
												<%
              Dim contador_3 as Integer
              
              Dim objRow_3 as Data.DataRow
              
              
              
              contador_3 = 0
					
			  for each objRow_3 in Session("dt").Rows
					
			  contador_3 = contador_3 + 1
              
              %>
												<TR>
													<TD><% =objRow_3.Item(1) %></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD><SELECT style="BACKGROUND-COLOR: yellow; WIDTH: 75px" class="letra_centrada">
															<OPTION selected></OPTION>
														</SELECT></TD>
													<TD><INPUT style="BACKGROUND-COLOR: yellow; WIDTH: 75px" class="letra_centrada"></TD>
												</TR>
												<TR>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
													<TD></TD>
												</TR>
												<%
                
                next
                
                %>
											</TABLE>
											<%
                
                end if
                
                'end if
                
                %>
										</TD>
									</TR>
								</asp:panel></TABLE>
						</TD>
					</TR>
					<TR>
						<TD colSpan="3"><%
	Dim str_menu as string
							
	Dim objCIMA as New CIMA_Clases.CIMA
	
	Dim objDS as New Data.DataSet
	
	Dim objRow as Data.DataRow
	
	Dim ls_array() as string
	
	dim contador as integer
	
	
	
	if Session("ok_busca_huecos") = "S" then
	
	'Session("ok_busca_huecos") = "N"
	
	%>
							<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR height="11">
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<TR class="fecha_letra" align="center">
									<TD style="HEIGHT: 14px"></TD>
									<TD style="HEIGHT: 14px">Agenda</TD>
									<TD style="HEIGHT: 14px">Fecha</TD>
									<TD style="HEIGHT: 14px">Día</TD>
									<TD style="HEIGHT: 14px">Bloque Horario</TD>
									<TD style="HEIGHT: 14px">Prestación</TD>
									<TD style="HEIGHT: 14px">Hora Inicio</TD>
									<TD style="HEIGHT: 14px">Hora Fin</TD>
								</TR>
								<TR height="11">
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<%
								
		Dim i As Integer
		dim li_persona as integer
		
		dim lb_avance_dia as boolean
		
		dim dia_ok as date
		dim dia_ok_old as date
		dim dia_de_carga as date
		
		dim li_memoria(Me.DataGrid1.Items().Count - 1) as integer
		
		dim lb_avance as boolean
		
		dim li_contador_1, li_contador_2 as integer
		
		dim lb_control_pr As Boolean
		
        
        
        lb_avance_dia = true
        
        lb_control_pr = False
        
        dia_ok = Me.Calendar1.SelectedDate
        
        dia_ok_old = dia_ok
        
        while lb_avance_dia = true and datediff(DateInterval.Day,dia_ok_old,dia_ok) <= 60
        
        Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.clear()
        
        'li_memoria.clear() 
        if ubound(li_memoria) > 0 then
			array.Clear(li_memoria,0,ubound(li_memoria)-1)
		end if
        
        lb_avance = true
        
        If Me.DataGrid1.Items().Count > 0 Then

			li_contador_1 = 0
			li_contador_2 = 0

			while lb_avance = true and datediff(DateInterval.Day,dia_ok_old,dia_ok) <= 60
				
				if ubound(li_memoria) > 0 then
					array.Clear(li_memoria,0,ubound(li_memoria)-1)
				end if
				
				For i = 0 To Me.DataGrid1.Items().Count - 1
	                
					ls_array = split(Me.DataGrid1.Items(i).Cells(6).Text,"/")
					
					if len(trim(Me.DataGrid1.Items(i).Cells(7).Text)) > 0 and trim(Me.DataGrid1.Items(i).Cells(7).Text) <> "&nbsp;" and trim(Me.DataGrid1.Items(i).Cells(7).Text) <> "" then
						li_persona = cint(Me.DataGrid1.Items(i).Cells(7).Text)
					else
						li_persona = 0
					end if
					
					'''' CETIR.
					
					If TRIM(Me.DataGrid1.Items(i).Cells(1).Text) = "RADIOLOGIA" Then
					
						lb_control_pr = True
	                    
					else
					
					''' Fin CETIR.
					
						Me.SqlDataAdapter8.SelectCommand.Parameters(1).Value = Me.DataGrid1.Items(i).Cells(2).Text
						Me.SqlDataAdapter8.SelectCommand.Parameters(2).Value = day(dia_ok)
						Me.SqlDataAdapter8.SelectCommand.Parameters(3).Value = month(dia_ok)
						Me.SqlDataAdapter8.SelectCommand.Parameters(4).Value = year(dia_ok)
						Me.SqlDataAdapter8.SelectCommand.Parameters(5).Value = ls_array(1)
						Me.SqlDataAdapter8.SelectCommand.Parameters(6).Value = li_persona
						Me.SqlDataAdapter8.SelectCommand.Parameters(7).Value = Me.DataGrid1.Items(i).Cells(8).Text
						Me.SqlDataAdapter8.SelectCommand.Parameters(8).Value = Me.DataGrid1.Items(i).Cells(9).Text
						Me.SqlDataAdapter8.SelectCommand.Parameters(9).Value = ls_array(0)'Me.DataGrid1.Items(i).Cells(9).Text
						Me.SqlDataAdapter8.SelectCommand.Parameters(10).Value = Me.DropDownList8.SelectedValue.ToString

						Me.SqlConnection1.Open()
						Me.SqlDataAdapter8.Fill(Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS)
						Me.SqlConnection1.Close()
					
					end if
					
					li_memoria(i) = Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.rows.count

				Next
	            
				lb_avance = false
	            
				if Me.DataGrid1.Items().Count - 1 > 0 then
	            
					for i = 0 To Me.DataGrid1.Items().Count - 1
		            
						if i > 0 then
							if li_memoria(i) = li_memoria(i-1) then
							
								lb_avance = true
								dia_ok = DateAdd(DateInterval.Day, 1, dia_ok)
								
								'li_contador_1 = li_contador_1 + 1
		
								'if li_contador_1 >= 61 then
								
								'	lb_avance_dia = false
								
								'end if
								
								Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.clear()
							
							end if
						end if
		            
					next
		            
				end if
            
            end while

        End If
	
	contador = 0
	
	if Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows.count = 0 then
	
		lb_avance_dia = true
		dia_ok = DateAdd(DateInterval.Day, 1, dia_ok) 
		
		'li_contador_2 = li_contador_2 + 1
		
		'if li_contador_2 >= 61 then
		
		'	lb_avance_dia = false
		
		'end if
		
	else
	
		lb_avance_dia = false
		
	end if
			
	'for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
	
	'	contador = contador + 1
		
	'	if contador = 1 then
		
	'		dia_de_carga = objRow.Item(3)
		
	'	end if
		
	'	if objRow.Item(3) <> dia_de_carga and lb_avance_dia = false then
		
	'		lb_avance_dia = true
	'		dia_ok = DateAdd(DateInterval.Day, 1, dia_ok) 
		
	'	end if
		
	'	dia_de_carga = objRow.Item(3)
	
	'next
	
	end while
		
	'Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CSaludR;password=kampeon10"
	
	
	
	'str_menu = "dbo.SP_CIMACEX_BUSCA_HUECOS '" & Me.DropDownList5.SelectedValue.ToString & "'," & day(Me.Calendar1.SelectedDate) & "," & month(Me.Calendar1.SelectedDate) & "," & year(Me.Calendar1.SelectedDate) & "," & ls_array(1)

	'objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

	if lb_control_pr = True then
	
		Response.Write("<script language=javascript>alert(""Existe una o más de una PRESTACIÓN del servicio de RADIOLOGÍA. Estas prestaciones deben añadirse desde el menú Estación de Citas."");</script>")
		
	ELSE
	
		if datediff(DateInterval.Day,dia_ok_old,dia_ok) >= 61 then
	
			%>
								<SCRIPT type="text/javascript">
			
			alert("Lo sentimos. En 60 días no ha habido correspondencia entre las prestaciones seleccionadas.");
			
								</SCRIPT>
								<%
	
		end if
	
	end if

	contador = 0

	for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
	
	contador = contador + 1
	
	%>
								<TR class="letra_pequena" height="11" align="center"> <!-- JGM Asteriscar per veure en mode DISSENY -->
          <TD><INPUT id="cb<% =Cstr(contador) %>" value="<% =objRow.Item(3) & "#" & objRow.Item(0) & "#" & objRow.Item(1) & "#" & objRow.Item(2) & "#" & objRow.Item(8) & "#" & objRow.Item(9) & "#" & objRow.Item(10) & "#" & objRow.Item(11) & "#" & objRow.Item("hpro_key") & "#" & objRow.Item("duracion") %>" type=checkbox></TD>
          <!-- JGM -->
									<TD><% =objRow.Item("agenname") %></TD>
									<TD><% =objRow.Item(3) %></TD>
									<TD><% =objRow.Item("dia_semana") %></TD>
									<TD><% =objRow.Item("btimetabdesc") %></TD>
									<TD><% =objRow.Item("hprodesclong") %></TD>
									<TD><% =objRow.Item(0) %></TD>
									<TD><% =objRow.Item(1) %></TD>
								</TR>
								<TR height="11">
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
									<TD></TD>
								</TR>
								<%
	
	next
	
	
	%>
								<SCRIPT type="text/javascript">
	Form1.contador.value='<% =contador %>';
								</SCRIPT>
								<SCRIPT type="text/javascript">
	
		function generar_cadena(){

			var cadena;
			
			cadena = ""

			for (i=1;i<=<% =cint(contador) %>;i++){

			if (document.getElementById("cb" + i).checked == true){
			
				cadena = cadena + document.getElementById("cb" + i).value + "*";
			
			}
			
			}
			
			seleccion.cadena_creciente.value=cadena;
			
			seleccion.submit();
			
		}
	
								</SCRIPT>
							</TABLE>
							<%
	
	
	
	end if
	
	%>
						</TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD class="letra" height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"><% 
						
						if Session("ok_busca_huecos") = "S" then
	
						Session("ok_busca_huecos") = "N"
						
						%><INPUT style="WIDTH: 150px" onclick="javascript:generar_cadena();" value="Citar" type="button"><% end if %></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
				</asp:panel>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD vAlign="top" height="*"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD width="125" colSpan="3" height="11"></TD>
				</TR>
				</TBODY></TABLE>
		</form>
	</body>
</HTML>
