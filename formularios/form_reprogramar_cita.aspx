<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="WebControlCIMA.Buttons" Assembly="WebControlCIMA" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_reprogramar_cita.aspx.vb" Inherits="cimaweb.form_reprogramar_cita"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Reprogramar Cita</title>
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
	
		function citar_cetir(id_cita,fecha_hora,duracion){
		
			//alert("kk");
			document.getElementById("b_citar_hueco" + id_cita).disabled=true;
			document.envio_cita.id_cita.value=id_cita;
			document.envio_cita.fecha_cita.value=fecha_hora;
			document.envio_cita.btimetabcode.value = "0";
			document.envio_cita.hora_final.value = duracion;
			document.envio_cita.hora_inicial.value = fecha_hora;
			document.envio_cita.ok_cita.value="S";
			document.envio_cita.retorno_pers_key.value=<% =Session("pers_key") %>;
			document.envio_cita.prestacion.value="<% =Me.DropDownList2.SelectedValue.ToString %>";
			
			document.envio_cita.submit();
					
		}
	
		</script>
		<script type="text/javascript">
		if (control==1){
			seleccionar_paciente();
		}
		function seleccionar_paciente()
		{
		f_abre("../formularios/form_busca_pers_solicitar_cita.aspx?dia_seleccionado=<% =Session("dia_origen") %>&agencode=<% =Session("agencode") %>&DropDownList1=<% =Request("DropDownList1") %>&DropDownList2=<% =Request("DropDownList2") %>&DropDownList3=<% =Request("DropDownList3") %>&TextBox1=<% =Request("TextBox1") %>&DropDownList4=<% =Request("DropDownList4") %>",600,800,"");
		}
		</script>
		<script type="text/javascript">
		
		function citar(fecha,hora_ini,hora_fin,btimetabcode){
			
			
			document.envio_cita.fecha_cita.value=fecha;
			document.envio_cita.btimetabcode.value = btimetabcode;
			document.envio_cita.hora_final.value = hora_fin;
			document.envio_cita.hora_inicial.value = hora_ini;
			document.envio_cita.ok_cita.value="S";
			document.envio_cita.retorno_pers_key.value=<% =Session("pers_key") %>;
			document.envio_cita.prestacion.value="<% =Me.DropDownList2.SelectedValue.ToString %>";
			
		
			document.envio_cita.submit();
		
		}
		
		</script>
		<form name="envio_cita">
			<input type="hidden" name="prestacion"> <input type="hidden" name="fecha_cita"> <input type="hidden" name="hora_inicial"> <input type="hidden" name="id_cita">
			<input type="hidden" name="hora_final"> <input type="hidden" value="N" name="ok_cita">
			<input type="hidden" name="btimetabcode"> <input type="hidden" name="retorno_pers_key">
			<input type="hidden" name="garante"> <input type=hidden 
value='<% =Session("agencode") %>' name=agencode> <input 
type=hidden value="<% =me.DropDownList4.SelectedValue.ToString %>" name=doctor>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Reprogramar&nbsp;Cita</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 97px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD class="letra" vAlign="middle" align="center" colSpan="3" height="11">
						<TABLE id="Table4" style="WIDTH: 100%" cellSpacing="0" cellPadding="0" border="0">
							<TR>
								<TD align="center"><asp:calendar id="Calendar1" runat="server" FirstDayOfWeek="Monday" ShowGridLines="True" Font-Names="Verdana"
										Font-Size="6pt" Height="165px" DayNameFormat="FirstLetter" BorderColor="#999999" CellPadding="4" ForeColor="Black"
										BackColor="White" Width="152px">
										<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
										<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
										<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
										<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#CCCCCC"></DayHeaderStyle>
										<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="Red"></SelectedDayStyle>
										<TitleStyle Font-Bold="True" BorderColor="Black" BackColor="#999999"></TitleStyle>
										<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
										<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
									</asp:calendar></TD>
								<TD width="11"></TD>
								<TD align="center"><asp:calendar id="Calendar2" runat="server" FirstDayOfWeek="Monday" ShowGridLines="True" Font-Names="Verdana"
										Font-Size="6pt" Height="165px" DayNameFormat="FirstLetter" BorderColor="#999999" CellPadding="4" ForeColor="Black"
										BackColor="White" Width="152px">
										<TodayDayStyle ForeColor="Black" BackColor="#CCCCCC"></TodayDayStyle>
										<SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
										<NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
										<DayHeaderStyle Font-Size="7pt" Font-Bold="True" BackColor="#CCCCCC"></DayHeaderStyle>
										<SelectedDayStyle Font-Bold="True" ForeColor="White" BackColor="Red"></SelectedDayStyle>
										<TitleStyle Font-Bold="True" BorderColor="Black" BackColor="#999999"></TitleStyle>
										<WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
										<OtherMonthDayStyle ForeColor="Gray"></OtherMonthDayStyle>
									</asp:calendar></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD class="letra" height="11"></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra" height="11">Paciente:
						<asp:label id=Label3 runat="server" Text='<%# DataBinder.Eval(Ds_agen_agenname1, "Tables[agen].DefaultView.[0].agenname") %>' CssClass="letra_negrita">
						</asp:label></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"><asp:button id="Button2" runat="server" Width="150px" Text="Paciente" Visible="False"></asp:button></TD>
				</TR>
				<TR>
					<TD class="letra" style="HEIGHT: 19px" height="19">Agenda:
						<asp:label id=Label1 runat="server" Text='<%# DataBinder.Eval(Ds_agen_agenname1, "Tables[agen].DefaultView.[0].agenname") %>' CssClass="letra_negrita">
						</asp:label></TD>
					<TD style="HEIGHT: 19px" height="19"></TD>
					<TD style="HEIGHT: 19px" height="19"></TD>
				</TR>
				<TR>
					<TD class="letra" height="11">Día:
						<asp:label id="Label2" runat="server" CssClass="letra_negrita"></asp:label></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 97px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD width="100%" colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="letra">Prestaciones</TD>
								<TD width="11"></TD>
								<TD class="letra"></TD>
								<TD></TD>
								<TD class="letra"></TD>
								<TD class="letra"></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 16px" width="200"><asp:dropdownlist id=DropDownList2 runat="server" Width="300px" CssClass="letra" AutoPostBack="True" DataSource="<%# Ds_prestaciones1 %>" DataMember="prestaciones" DataValueField="Tiempo" DataTextField="Descripción"></asp:dropdownlist></TD>
								<TD style="HEIGHT: 16px" width="11"></TD>
								<TD style="HEIGHT: 16px" width="150" colSpan="4"><asp:dropdownlist id=DropDownList1 runat="server" Width="200px" CssClass="letra" Visible="False" AutoPostBack="True" DataSource="<%# Ds_btimetab1 %>" DataMember="btimetab" DataValueField="btimetabcode" DataTextField="btimetabdesc">
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 17px" colSpan="6">
									<%
									
									Dim str_menu as string
											
									Dim objCIMA as New CIMA_Clases.CIMA
									
									Dim objDS as New Data.DataSet
									
									Dim objRow as Data.DataRow
									
									Dim contador as integer
									
									Dim agenproc_key() as string
									
									Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
									
									if len(trim(Me.DropDownList2.SelectedValue)) > 0 then
									
									agenproc_key=split(Me.DropDownList2.SelectedValue,"/",,1)
									
									str_menu = "dbo.SP_CIMACEX_RECUPERA_DOCUMENTOS " & agenproc_key(UBound(agenproc_key)) & ""
					
									objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
									
									if objDS.Tables(0).Rows.Count > 0 then
									
									%>
									<TABLE id="Table444" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fecha_letra" colSpan="5">Documentos asociados</TD>
										</TR>
										<TR>
											<TD colSpan="6" height="11"></TD>
										</TR>
										<%
									contador = 0
									for each objRow in objDS.Tables(0).Rows
									
									contador = contador + 1
									
									%>
										<TR style="CURSOR: hand">
											<TD 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
                ><% 
										select case objRow.Item(0)
											case 1
												response.write("<IMG alt="""" src=""../imagenes/word.gif"">")
											case 2
												response.write("<IMG alt="""" src=""../imagenes/excel.gif"">")
											case 3
												response.write("<IMG alt="""" src=""../imagenes/acrobat.gif"">")
										end select
										%></TD>
											<TD class=letra_pequena_negrita 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
                ><% =objRow.Item(3) %></TD>
											<TD class=letra_pequena 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
                ><% =objRow.Item(1) %></TD>
											<TD class=letra_pequena 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
                ><% =objRow.Item(2) %></TD>
											<TD class="letra_pequena" align="center"><% 
											if objRow.Item(6)="S" then
												response.write("Enviar por e-mail <input type=""checkbox"" name=""" & cstr(objRow.Item(4)) & "*" & cstr(objRow.Item(5)) & """>")
											end if
											%></TD>
											<TD class="letra_pequena" align="right"></TD>
										</TR>
										<%
												
									next
									
									'Session("contador") = contador
									
									
									
									%>
										<TR>
											<TD colSpan="6" height="11"></TD>
										</TR>
									</TABLE>
									<%
									end if
									end if
									%>
								</TD>
							</TR>
							<TR>
								<TD class="letra" style="HEIGHT: 11px" colSpan="6">
									<%
									
									'Dim str_menu as string
											
									'Dim objCIMA as New CIMA_Clases.CIMA
									
									'Dim objDS as New Data.DataSet
									
									'Dim objRow as Data.DataRow
									
									'Dim contador as integer
									
									'Dim agenproc_key() as string
									
									contador = 0
									
									If Trim(Session("agencode")) <> "ECG" and Trim(Session("agencode")) <> "RM" and Trim(Session("agencode")) <> "RXC" and Trim(Session("agencode")) <> "TLM" and Trim(Session("agencode")) <> "MM" and Trim(Session("agencode")) <> "DN" and Trim(Session("agencode")) <> "TC" and Trim(Session("agencode")) <> "UR RX" Then
									
										Session("cadena_conexion")="DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
										
										if len(trim(Me.DropDownList1.SelectedValue)) > 0 then
										
											'agenproc_key=split(Me.DropDownList2.SelectedValue,"/",,1)
											
											str_menu = "[dbo].[SP_CIMACEX_BLOQUEOS] '" & Session("dia_seleccionado") & "','" & Session("agencode") & "'," & Me.DropDownList1.SelectedValue
							
											objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))
											
											if objDS.Tables(0).Rows.Count > 0 then
											
												%>
									<TABLE id="Table44" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fecha_letra" colSpan="6">Bloqueos Horarios</TD>
										</TR>
										<TR>
											<TD colSpan="6" height="11"></TD>
										</TR>
										<%
												
												for each objRow in objDS.Tables(0).Rows
												
												contador = contador + 1
												
												%>
										<TR>
											<TD class="letra_pequena_negrita" width="11"><IMG src="../imagenes/warning.jpg"></TD>
											<TD class="letra_pequena_negrita" width="11"><% =objRow.Item(0) %></TD>
											<TD class="letra_pequena_negrita" width="11"></TD>
											<TD class="letra_pequena_negrita" width="11"><% =objRow.Item(1) %></TD>
											<TD class="letra_pequena_negrita" colSpan="2"></TD>
										</TR>
										<%
															
												next
												
												'Session("contador") = contador
												
												%>
									</TABLE>
									<%
											
											end if
										
										end if
									
									end if
									
									%>
								</TD>
							</TR>
							<TR>
								<TD class="letra" colSpan="6" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra" style="HEIGHT: 20px" colSpan="6">
									<TABLE id="Table33" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<asp:panel id="Panel2" runat="server" Visible="true">
											<TBODY>
												<TR>
													<TD width="75">
														<asp:Label id="Label8" runat="server" CssClass="letra">A partir de: </asp:Label></TD>
													<TD>&nbsp;&nbsp;
														<asp:textbox id="fecha_ini" runat="server" Width="90px" CssClass="letra_pequena_centrada" Enabled="False">__/__/____</asp:textbox>&nbsp;&nbsp;&nbsp;
														<asp:DropDownList id="DropDownList8" runat="server" Width="150px" CssClass="letra_pequena"></asp:DropDownList></TD>
													<TD align="right">
														<cc1:ButtonEnviar id="Button3" runat="server" Width="150px" Text="Buscar"></cc1:ButtonEnviar></TD>
												</TR>
												<TR>
													<TD colSpan="3"><%
	'Dim str_menu as string
							
	'Dim objCIMA as New CIMA_Clases.CIMA
	
	'Dim objDS as New Data.DataSet
	
	Dim objRow as Data.DataRow
	
	Dim ls_array() as string
	
	dim li_persona as integer
	
	Dim dr As Data.DataRow
	
	dim n as integer
	
	
	
	if Session("ok_busca_huecos") = "S" then
	
	Session("ok_busca_huecos") = "N"
	
	%>
														<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
															<TR height="11">
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
															</TR>
															<TR class="fecha_letra" align="center">
																<TD style="HEIGHT: 14px"></TD>
																<TD style="HEIGHT: 14px">Fecha</TD>
																<TD style="HEIGHT: 14px">Día</TD>
																<TD style="HEIGHT: 14px">Bloque Horario</TD>
																<TD style="HEIGHT: 14px"><%IF Trim(Session("agencode")) = "ECG" OR Trim(Session("agencode")) = "RM" OR Trim(Session("agencode")) = "RXC" OR Trim(Session("agencode")) = "TLM" OR Trim(Session("agencode")) = "MM" OR Trim(Session("agencode")) = "DN" OR Trim(Session("agencode")) = "TC" OR Trim(Session("agencode")) = "UR RX" then%>Duración
																	<%else%>
																	Hora Inicio
																	<%end if%>
																</TD>
																<TD style="HEIGHT: 14px">Hora Fin</TD>
															</TR>
															<TR height="11">
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
																<TD></TD>
															</TR>
															<%
				
	ls_array = split(Me.DropDownList2.SelectedValue.ToString,"/")
	
	'if len(trim(me.Dropdownlist2.SelectedValue)) > 0 then
	'	li_persona = cint(me.Dropdownlist2.SelectedValue)
	'else
	'	li_persona = 0
	'end if
	
	if Trim(Session("agencode")) = "ECG" OR Trim(Session("agencode")) = "RM" OR Trim(Session("agencode")) = "RXC" OR Trim(Session("agencode")) = "TLM" OR Trim(Session("agencode")) = "MM" OR Trim(Session("agencode")) = "DN" OR Trim(Session("agencode")) = "TC" OR Trim(Session("agencode")) = "UR RX" then
	
        if Me.DataGrid1.Items.Count() > 0 then   
		
		For n = 0 To Me.DataGrid1.Items.Count() - 1    
	
		'for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
	
		%>
															<TR class="letra_pequena" align="center" height="11">
																<TD><INPUT id="b_citar_hueco<% =cstr(n) %>" onclick="javascript:citar_cetir('<% =cstr(n) %>','<% =Me.DataGrid1.Items(n).Cells(2).Text() %>',<% =Me.DataGrid1.Items(n).Cells(3).Text() %>);" type=button value=CITAR></TD>
																<TD><% =Me.DataGrid1.Items(n).Cells(2).Text() %></TD>
																<TD></TD>
																<TD></TD>
																<TD><% =Me.DataGrid1.Items(n).Cells(3).Text() %></TD>
																<TD></TD>
															<TR height="11">
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
	
	else
			
		Me.SqlDataAdapter8.SelectCommand.Parameters(1).Value = Session("agencode")'Me.DropDownList5.SelectedValue.ToString
		Me.SqlDataAdapter8.SelectCommand.Parameters(2).Value = day(Me.Calendar1.SelectedDate)
		Me.SqlDataAdapter8.SelectCommand.Parameters(3).Value = month(Me.Calendar1.SelectedDate)
		Me.SqlDataAdapter8.SelectCommand.Parameters(4).Value = year(Me.Calendar1.SelectedDate)
		Me.SqlDataAdapter8.SelectCommand.Parameters(5).Value = ls_array(1)
		Me.SqlDataAdapter8.SelectCommand.Parameters(6).Value = Session("pers_key")'li_persona
		Me.SqlDataAdapter8.SelectCommand.Parameters(7).Value = 0'cint(Me.Label15.Text)
		Me.SqlDataAdapter8.SelectCommand.Parameters(8).Value = 0'me.Dropdownlist6.SelectedValue
		Me.SqlDataAdapter8.SelectCommand.Parameters(9).Value = ls_array(0)'Me.DataGrid1.Items(i).Cells(9).Text
		Me.SqlDataAdapter8.SelectCommand.Parameters(10).Value = Me.DropDownList8.SelectedValue.ToString'Me.DataGrid1.Items(i).Cells(9).Text
		Me.SqlDataAdapter8.SelectCommand.Parameters(11).Value = -1

		Me.SqlConnection2.Open()
		Me.SqlDataAdapter8.Fill(Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS)
		Me.SqlConnection2.Close()
    
		for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
	
		%>
															<TR class="letra_pequena" align="center" height="11">
																<TD><INPUT class=letra_pequena_negrita style="WIDTH: 50px" onclick="javascript:citar('<% =objRow.Item(3) %>','<% =objRow.Item(0) %>','<% =objRow.Item(1) %>',<% =objRow.Item(2) %>);" type=button value=CITAR></TD>
																<TD><% =objRow.Item(3) %></TD>
																<TD><% =objRow.Item("dia_semana") %></TD>
																<TD><% =objRow.Item("btimetabdesc") %></TD>
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
															</TR>
															<%
	
		next
	
		end if
	
		%>
														</TABLE>
														<%
	
	end if
	
	%>
													</TD>
												</TR>
										</asp:panel>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD class="letra" style="HEIGHT: 20px"></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD class="letra" style="HEIGHT: 20px"></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD style="HEIGHT: 20px"></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<!--TR>
								<TD class="letra" style="HEIGHT: 20px">Hora Inicio:
									<asp:dropdownlist id="DropDownList3" runat="server" BackColor="Yellow" Width="75px" AutoPostBack="True"></asp:dropdownlist></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD class="letra" style="HEIGHT: 20px">Hora Fin:
									<asp:textbox id="TextBox1" runat="server" BackColor="Yellow" Width="75px" CssClass="letra_centrada"
										ReadOnly="True"></asp:textbox></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD style="HEIGHT: 20px"></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR-->
							<TR>
								<TD class="letra" height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD class="letra" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD class="letra" colSpan="6" height="11">Médico Prescriptor:
									<asp:dropdownlist id=DropDownList4 runat="server" Width="300px" CssClass="letra" AutoPostBack="true" DataSource="<%# Ds_medicos1 %>" DataMember="medicos" DataValueField="pers_key" DataTextField="nombre">
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="letra"></TD>
								<TD width="11"></TD>
								<TD class="letra"></TD>
								<TD></TD>
								<TD align="right"><asp:button id="Button1" runat="server" Width="150px" Text="Aceptar" Visible="False"></asp:button></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="right" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD align="left" colSpan="3" height="11"><asp:datagrid id="DataGrid1" runat="server" Width="100%" Visible="False"></asp:datagrid></TD>
				</TR>
				<TR>
					<TD align="right" colSpan="3" height="11"></TD>
				</TR>
				</TBODY></TABLE>
		</form>
	</body>
</HTML>
