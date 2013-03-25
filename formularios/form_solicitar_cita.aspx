<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_solicitar_cita.aspx.vb" Inherits="zeus.form_solicitar_cita"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Solicitar Cita</title>
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
		if (control==1){
			seleccionar_paciente();
		}
		function seleccionar_paciente()
		{
		f_abre("../formularios/form_busca_pers_solicitar_cita.aspx?dia_seleccionado=<% =Session("dia_origen") %>&agencode=<% =Session("agencode") %>&DropDownList1=<% =Request("DropDownList1") %>&DropDownList2=<% =Request("DropDownList2") %>&DropDownList3=<% =Request("DropDownList3") %>&TextBox1=<% =Request("TextBox1") %>&DropDownList4=<% =Request("DropDownList4") %>",600,800,"");
		}
		</script>
		<form name="recarga" action="" method="post">
			<input type="hidden" name="persona"> <input type="hidden" name="pers_key"> <input type="hidden" name="persona_ok">
			<input type="hidden" name="dia_seleccionado"> <input type="hidden" name="agencode">
			<input type="hidden" name="DropDownList1"> <input type="hidden" name="DropDownList2">
			<input type="hidden" name="DropDownList3"> <input type="hidden" name="DropDownList4">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Solicitar Cita</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 97px" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD class="letra" height="11">Paciente:
						<asp:label id=Label3 runat="server" Text='<%# DataBinder.Eval(Ds_agen_agenname1, "Tables[agen].DefaultView.[0].agenname") %>' CssClass="letra_negrita">
						</asp:label></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"><asp:button id="Button2" runat="server" Text="Paciente" Width="150px"></asp:button></TD>
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
								<TD class="letra">Franjas Horarias</TD>
								<TD width="11"></TD>
								<TD class="letra">Prestaciones</TD>
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
								<TD style="HEIGHT: 14px" width="200"><asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra" Width="200px" AutoPostBack="True" DataSource="<%# Ds_btimetab1 %>" DataMember="btimetab" DataValueField="btimetabcode" DataTextField="btimetabdesc">
									</asp:dropdownlist></TD>
								<TD style="HEIGHT: 14px" width="11"></TD>
								<TD style="HEIGHT: 14px" width="150" colSpan="4"><asp:dropdownlist id=DropDownList2 runat="server" CssClass="letra" Width="300px" AutoPostBack="True" DataSource="<%# Ds_prestaciones1 %>" DataMember="prestaciones" DataValueField="Tiempo" DataTextField="Descripción"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 17px" width="200"></TD>
								<TD style="HEIGHT: 17px" width="11"></TD>
								<TD style="HEIGHT: 17px" width="150" colSpan="4"></TD>
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
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
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
								<TD colSpan="6" height="11">
									<%
									
									'Dim str_menu as string
											
									'Dim objCIMA as New CIMA_Clases.CIMA
									
									'Dim objDS as New Data.DataSet
									
									'Dim objRow as Data.DataRow
									
									'Dim contador as integer
									
									'Dim agenproc_key() as string
									
									Session("cadena_conexion")="DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
									
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
									%>
								</TD>
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
								<TD class="letra" style="HEIGHT: 20px">Hora Inicio:
									<asp:dropdownlist id="DropDownList3" runat="server" Width="75px" AutoPostBack="True" BackColor="Yellow"></asp:dropdownlist></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD class="letra" style="HEIGHT: 20px">Hora Fin:
									<asp:textbox id="TextBox1" runat="server" CssClass="letra_centrada" Width="75px" BackColor="Yellow"
										ReadOnly="True"></asp:textbox></TD>
								<TD style="HEIGHT: 20px" width="11"></TD>
								<TD style="HEIGHT: 20px"></TD>
								<TD style="HEIGHT: 20px"></TD>
							</TR>
							<TR>
								<TD class="letra" height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD class="letra" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD class="letra" colSpan="6" style="HEIGHT: 15px">Médico Prescriptor:
									<asp:dropdownlist id=DropDownList4 runat="server" Width="300px" DataSource="<%# Ds_medicos1 %>" DataMember="medicos" DataValueField="pers_key" DataTextField="nombre" CssClass="letra_pequena">
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="letra"></TD>
								<TD width="11"></TD>
								<TD class="letra"></TD>
								<TD></TD>
								<TD align="right"><asp:button id="Button1" runat="server" Text="Aceptar" Width="150px"></asp:button></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="right" colSpan="3" height="11">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD height="11"></TD>
								<TD width="11" height="11"></TD>
								<TD colSpan="4"></TD>
							</TR>
							<%
							
							'Dim inicio as integer
							'Dim fin as integer
							
							'Dim objRow as Data.DataRow
							
							'Dim n,hora_corrida,minuto_corrido as integer
							
							'Dim lb_ok as boolean
							
							'Dim contador as integer
							
							'if Me.Ds_franja_horaria1.franja_horaria.Rows.Count > 0 then
				
							'inicio=(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) * 60) + Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1)
							'fin=(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) * 60) + Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3)
				
							'hora_corrida = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0)
							'minuto_corrido = Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1)
				
							'lb_ok = false
				
							'contador = -1
				
							'for n= inicio to fin 'step Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(4)
							'contador = contador + 1
							'if lb_ok = true
							'	if n mod 60 = 0 then
							'		hora_corrida = hora_corrida + 1
							'		minuto_corrido = 0
							'	else
							'		minuto_corrido = minuto_corrido + 1'Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(4)
							'	end if
							'end if
							
							'if contador mod 15 = 0 then
							
							%>
							<!--TR>
								<TD class="letra_negrita"><% '=cstr(hora_corrida) & ":" & cstr(minuto_corrido) %>
								</TD>
								<TD width="11"></TD>
								<TD align="center"></TD>
							</TR-->
							<% 
							
							'else 
							
							%>
							<!--TR>
								<TD height=1></TD>
								<TD width="11"></TD>
								<TD align="center"></TD>
							</TR-->
							<%
							
							'end if
							
							'lb_ok = true
							
							'next
							
							'Me.Ds_franja_horaria1.Clear()
							
							'end if
							
							%>
							<TR>
								<TD class="cabecera_busca_pacientes" colSpan="11">Citas<% '="Rango: " & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1)) & " - " & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) & ":" & formatear_minutos(Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3)) %></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<%
							
							'Dim str_menu as string
					
							'Dim objCIMA as New CIMA_Clases.CIMA
							
							'Dim objDS as New Data.DataSet
							
							'Dim objRow as Data.DataRow
							
							Dim a as Integer
							
							'Dim contador as integer
							
							Dim ls_array() as String
							
							contador = 0
							
							'if Session("dia_seleccionado") <> Nothing then
							'	ls_array = Split(Session("dia_seleccionado"), "/")
            				'	Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)
							'end if
							
							str_menu = "dbo.SP_CIMACEX_CITAS_DIA_TODAS '" & Session("dia_seleccionado") & "','" & Session("agencode") & "'"','" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(0) & ":" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(1) & ":00','" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(2) & ":" & Me.Ds_franja_horaria1.franja_horaria.Rows(0).Item(3) & ":00'"
			
							'response.write (str_menu)
			
							objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CIMACEX;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
							
							for each objRow in objDS.Tables(0).Rows
								contador= contador + 1
							
							Me.Ds_cima_garantes1.Clear()
							Me.SqlConnection1.Open()
							Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = objRow.Item(0)
							Me.SqlDataAdapter2.Fill(Me.Ds_cima_garantes1.cima_garantes)
							Me.SqlConnection1.Close()
							
							%>
							<TR class="letra_onMouseOut" height="11">
								<% if trim(objRow.Item(11)) = "ANULADA" then %>
								<TD><asp:image id="Image1" runat="server" ImageUrl="../imagenes/anulada.gif"></asp:image><% =" " & objRow.Item(11) %></TD>
								<% elseif trim(objRow.Item(11)) = "REALIZADA" then %>
								<TD><asp:image id="Image2" runat="server" ImageUrl="../imagenes/realizada.gif"></asp:image><% =" " & objRow.Item(11) %></TD>
								<% else %>
								<TD><asp:image id="Image3" runat="server" ImageUrl="../imagenes/pendiente.gif"></asp:image><% =" " & objRow.Item(11) %></TD>
								<% end if %>
								<% for a= 2 to 10 
								
								if a<7 or a>9 then
								
								if a=2 then
								
								%>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(a) %></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(24) %></TD>
								<% 
								
								else
								
								%>
								<TD class="letra_muy_pequena"><% =objRow.Item(a) %></TD>
								<% 
								
								end if
								
								end if
								
								next 
								%>
								<TD class="letra_muy_pequena"></TD>
								<TD class="letra_muy_pequena"><% =objRow.Item(26) %></TD>
								<%
								if me.Ds_cima_garantes1.Tables(0).Rows.Count() > 0 then
								%>
								<TD class="letra_muy_pequena_negrita"><% =me.Ds_cima_garantes1.Tables(0).Rows(0).Item(3) %></TD>
								<%
								end if
								%>
							</TR>
							<%
							
							next
							
							Me.Ds_cima_garantes1.Clear()
							
							objRow = Nothing
							objDS = Nothing
							objCIMA = Nothing
							
							'end if
							
							%>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="right" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD align="right" colSpan="3" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
