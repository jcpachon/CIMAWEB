<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="uo_documentos_rel" TagName="uo_documentos_rel" Src="../user_objects/uo_documentos_rel.ascx" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_pers_externos.aspx.vb" Inherits="cimaweb.form_pers_externos" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_pers_externos</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
	<script type=text/javascript>
	
	function abrir_visor(id_estudio,studyuid){
		
	window.open("agfahc://impax-client-epr/?user=cima&password=cima2009&domain=Agfa%20Healthcare&studyuid=" + studyuid + "","Visor","");
	window.close();
	
	}
	
	function abrir_informe(episcode,numero,nombre){
	
	open_informe.abrir_informe.value="S";
	open_informe.episcode_informe.value=episcode;
	open_informe.numero_informe.value=numero;
	open_informe.nombre_informe.value=nombre;
	
	open_informe.submit();
	
	}
	</script>
		<form id="volver" action="form_agendas.aspx" method="post">
			<input type="hidden" name="servicio_origen" style="LEFT: 10px; POSITION: absolute; TOP: 59px">
			<input type="hidden" name="agenda_origen" style="LEFT: 10px; POSITION: absolute; TOP: 59px">
			<input type="hidden" name="dia_origen" style="LEFT: 136px; POSITION: absolute; TOP: 59px">
			<input type="hidden" name="dia_en_seleccion" style="LEFT: 262px; POSITION: absolute; TOP: 59px">
		</form>
		
		<form id="open_informe">
		
		<input type="hidden" name="abrir_informe">
		<input type="hidden" name="episcode_informe">
		<input type="hidden" name="numero_informe">
		<input type="hidden" name="nombre_informe">
		
		<input type="hidden" name="pers_key" value="<% =Session("pers_key") %>">
		<input type="hidden" name="episcode" value="<% =Session("episcode") %>">
		<input type="hidden" name="mutua" value="<% =Session("mutua") %>">
		<input type="hidden" name="nacimiento" value="<% =Session("nacimiento") %>">
		<input type="hidden" name="cove" value="<% =Session("cove") %>">
		<input type="hidden" name="estado" value="<% =Session("estado") %>">
		<input type="hidden" name="realizada" value="<% =Request("realizada") %>">
		
		<input type=hidden value='<% =Session("DropDownList2") %>' name=DropDownList2> 
		<input type=hidden value='<% =Session("DropDownList1") %>' name=DropDownList1> 
		<input type=hidden value='<% =Session("dia_seleccionado") %>' name=VisibleDate>
		<input type=hidden value='<% =Session("dia_seleccionado") %>' name=dia_seleccionado> 
		<input type=hidden value='<% =Session("servicio_seleccionado") %>' name=servicio_seleccionado>
		<input type=hidden value='<% =Session("agenda_seleccionada") %>' name=agenda_seleccionada> 
		
		</form>
		
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		//ventana.close();
	if (control=="1"){
		f_abre("../formularios/form_antecedentes.aspx",500,700,"");
	}
	else if (control=="2"){
		f_abre("../formularios/form_medicacion.aspx",600,800,"");
		//window.showModalDialog("../formularios/form_medicacion.aspx", "","dialogWidth=48;dialogHeight=30;")
	}
	else if (control=="3"){
		window.showModalDialog("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episcode") %>", "","dialogWidth=40;dialogHeight=15;")
		//f_abre_modal("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episcode") %>",300,600,"");
	}
	else if (control=="4"){
		f_abre("../formularios/form_medicacion_global.aspx",500,800,"");
	}
	else if (control=="5"){
		f_abre("../informes/informe_curso_clinico.aspx?pers_key=<% =Session("pers_key") %>",700,1000,"");
	}
	else if (control=="6"){
		f_abre("../formularios/form_diagnosticos.aspx",500,800,"");
	}
	else if (control=="7"){
	<% if Session("debusqueda") = "0" then %>
			//window.showModalDialog('../formularios/form_curso_clinico.htm?pers_key=<% =Session("pers_key") %>&episodio=<% =Session("episcode") %>&id_plantilla=1','','dialogWidth=410px;dialogHeight=430p x;edge=Raised;center=Yes;help=NO;resizable=No;scro ll=NO;status=NO')
			f_abre("../formularios/form_curso_clinico.htm?pers_key=<% =Session("pers_key") %>&episodio=<% =Session("episcode") %>&id_plantilla=1",640,1000,"");
	<% else %>
			f_abre("../informes/informe_curso_clinico_grupo.aspx?pers_key=<% =Session("pers_key") %>",700,1000,"");
	<% end if %>
			
	}
	else if (control=="8"){
		volver.servicio_origen.value='<% =Session("servicio_seleccionado") %>';
		volver.agenda_origen.value='<% =Session("agenda_seleccionada") %>';
		volver.dia_en_seleccion.value='<% =Session("dia_seleccionado") %>';
		volver.submit();
	}
	else if (control=="9"){
		//f_abre("../formularios/form_reprogramar_cita.aspx?servicio_seleccionado=<% =Session("servicio_seleccionado") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&agencode=<% =Session("agenda_seleccionada") %>&pers_key=<% =Session("pers_key") %>&episcode=<% =Session("episcode") %>",600,800,"");
	}
	else if (control=="10"){
		f_abre("http://raim.cimaclinic.com/raimserver/web/DirectRetrieve.aspx?AccessionNumber=<% =Session("episcode") %>&Format=z100i0q30h.j12",700,1000,"");
	}
	else if (control=="11"){
		f_abre("../formularios/form_captura.aspx?episcode=<% =Session("episcode") %>",600,800,"");
	}
	else if (control=="12"){
		f_abre("../reports/cr_hoja_citacion.aspx?episcode=<% =Session("episcode") %>",600,900,"");
	}
	;;
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="805" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Ficha Paciente</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:panel id="Panel1" runat="server" Width="100%">
							<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD class="letra_negrita" vAlign="top">EPISODIO:
										<asp:label id="Label19" runat="server" Width="224px" CssClass="letra_negrita"></asp:label></TD>
									<TD width="11"></TD>
									<TD>
										<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
											<TR>
												<TD class="letra_negrita" align="right"></TD>
												<TD class="letra_negrita" align="right" width="22"></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<CR:CrystalReportViewer id="CrystalReportViewer1" runat="server" Visible="False" Width="350px" Height="50px"></CR:CrystalReportViewer></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="10"><asp:button id="Button9" runat="server" Width="150px" Text="Volver"></asp:button></TD>
								<TD width="7">&nbsp;</TD>
								<TD width="11"><asp:button id="Button10" runat="server" Width="150px" Text="Reprogramar" Enabled="false"></asp:button></TD>
								<TD width="7">&nbsp;</TD>
								<TD width="100%"></TD>
								<TD width="7">&nbsp;</TD>
								<TD width="11"></TD>
								<TD width="7">&nbsp;</TD>
								<TD align="right" width="100">
									<asp:button id="Button11" runat="server" Width="150px" Text="RAIM Web" BackColor="#C0FFFF" Font-Bold="True"
										Enabled="False" Visible="false"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" valign="top">
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD class="letra_formulario" colSpan="2" height="11">ESTADO:&nbsp;
									<asp:label id=Label5 runat="server" Width="224px" Text='<%# EstadoEval(DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persacti")) %>'>
									</asp:label></TD>
							</TR>
							<TR>
									<TD colspan="2" height="11"></TD>
								</TR>
							<TR>
								<TD vAlign="top" colSpan="2" height="50">
									<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fondo_formulario" width="120" height="11">Nombre</TD>
											<TD width="11" height="11"></TD>
											<TD class="fondo_formulario" width="120" height="11">1º Apellido</TD>
											<TD width="11" height="11"></TD>
											<TD class="fondo_formulario" width="120" height="11">2º Apellido</TD>
											<TD width="11" height="11"></TD>
											<TD class="fondo_formulario" width="50" height="11">Sexo</TD>
											<TD width="11" height="11"></TD>
											<TD class="fondo_formulario" width="150" height="11">Fecha de Nacimiento</TD>
											<TD width="11" height="11"></TD>
											<TD class="fondo_formulario" width="11" height="11">DNI</TD>
										</TR>
										<TR>
											<TD width="120"><asp:label id=Label1 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persname") %>'>
												</asp:label></TD>
											<TD></TD>
											<TD width="120"><asp:label id=Label2 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].perssur1") %>'>
												</asp:label></TD>
											<TD></TD>
											<TD width="120"><asp:label id=Label3 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].perssur2") %>'>
												</asp:label></TD>
											<TD></TD>
											<TD width="50"><asp:label id=Label8 runat="server" CssClass="letra_formulario" Text='<%# SexoEval(DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].tsexcode")) %>'>
												</asp:label></TD>
											<TD></TD>
											<TD><asp:label id=Label9 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persbirtdate") %>'>
												</asp:label></TD>
											<TD></TD>
											<TD><asp:label id=Label4 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persidencod1") %>'>
												</asp:label></TD>
										</TR>
										<TR>
											<TD class="fondo_formulario" width="50" colSpan="11" height="11">Dirección</TD>
										</TR>
										<TR>
											<TD width="120" colSpan="11" height="19">
												<asp:label id=Label10 runat="server" Width="568px" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrnameaddr") %>'>
												</asp:label></TD>
										</TR>
										<TR>
											<TD class="fondo_formulario" width="120">
												Teléfono</TD>
											<TD></TD>
											<TD class="fondo_formulario" width="120">
												Móvil</TD>
											<TD></TD>
											<TD class="fondo_formulario" width="120">E-mail 1</TD>
											<TD></TD>
											<TD class="fondo_formulario" width="120" colSpan="3">E-mail 2</TD>
											<TD></TD>
											<TD class="fondo_formulario">NHC</TD>
										</TR>
										<TR>
											<TD width="120" height="11"><asp:label id=Label6 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrtel1") %>'>
												</asp:label></TD>
											<TD height="11"></TD>
											<TD width="120" height="11"><asp:label id=Label7 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrtel2") %>'>
												</asp:label></TD>
											<TD height="11"></TD>
											<TD width="120" height="11"><asp:label id=Label18 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persmai1") %>'>
												</asp:label></TD>
											<TD height="11"></TD>
											<TD width="120" colSpan="3" height="11"><asp:label id=Label20 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persmai2") %>'>
												</asp:label></TD>
											<TD height="11"></TD>
											<TD height="11"><asp:label id=Label15 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].pati_hfn") %>'>
												</asp:label></TD>
										</TR>
										<TR>
											<TD width="120" colSpan="6" height="*"></TD>
											<TD width="50"></TD>
											<TD></TD>
											<TD></TD>
											<TD></TD>
											<TD></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" colSpan="2" height="11"><HR width="100%" size="1">
								</TD>
							</TR>
						</TABLE>
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<% if Session("Grupo") = "L" then %>
							<TR>
								<TD class="cabecera_formulario" colSpan="3">Informes de Laboratorio</TD>
							</TR>
							<% else %>
							<TR>
								<TD class="cabecera_formulario" colSpan="3">Informes de Radiología</TD>
							</TR>
							<% end if %>
							<TR  height=22>
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<%
							Dim str_menu as string
											
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							Dim contador as integer
							
							'JGM Modificació 29/12/2010
							Dim ls_pers_key as string
							Dim ls_epis_key as string
							Dim ls_pers_key_aux as string
							Dim li_id_episodio_CETIR as integer
							Dim a as integer
							'JGM Fi Modificació 29/12/2010
							
							'JGM Modificació 07/02/2011
							Dim ls_usuario as string
							if Session("grupo") = "L" 
								ls_usuario = "echevarne.carga"
							else
								ls_usuario = "cetir.carga"
							end if
							'JGM Fi Modificació 07/02/2011
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							'JGM Modificació 07/02/2011
							'str_menu = "dbo.[SP_CIMACEX_RECUPERA_EPIS_INFORMES_MOD] '" & Session("episcode") & "','cetir.carga'"
							str_menu = "dbo.[SP_CIMACEX_RECUPERA_EPIS_INFORMES_MOD] '" & Session("episcode") & "','" & ls_usuario & "'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							contador = 0
							
							for each objRow in objDS.Tables(0).Rows
							
							Dim ls_retorno() as string
							
							contador = contador + 1
							
							'JGM Modificació 29/12/2010
							' Si el usuario es cetir.carga no llamos al webservice

							if objRow.Item("id_usuario") = "cetir.carga"
								
								ls_pers_key_aux = Cstr(objRow.Item("pers_key_cetir"))
								if ls_pers_key_aux > 0
									ls_pers_key = ls_pers_key_aux
								else
									ls_pers_key = Cstr(Session("pers_key"))
								end if
																
								ls_epis_key = Cstr(objRow.Item("episcode"))
								
								service.GetIDEpisodiCGM(ls_pers_key, ls_epis_key, li_id_episodio_CETIR, True)
								
								if li_id_episodio_CETIR > 0 then
								
									Try

									ls_retorno = service.GetDICOMEstudisUID(li_id_episodio_CETIR, True)
									
									Catch 
									
										li_id_episodio_CETIR = 0

									End Try
								end if
							end if									
							'JGM Fi Modificació 29/12/2010		
							%>
							<TR>
								<!-- JGM Inici Modificació 29/12/2010 -->
							<TD colspan=3 class="letra_pequena_negrita">
							<% 	if li_id_episodio_CETIR > 0 then	
									if ls_retorno.Length > 0 then
																																
										for a = 0 to UBound(ls_retorno)
								
							%>
										<IMG alt="" src="../imagenes/placa.jpg" onclick="javascript:abrir_visor('<% =Cstr(li_id_episodio_CETIR) %>','<% =ls_retorno(a) %>');" style="CURSOR: hand">&nbsp;&nbsp;
							<%			response.write (ls_retorno(a))
								
										next
								
									end if
								
								end if	
							%>
							<IMG alt="" src="../imagenes/acrobat.gif" onclick='javascript:abrir_informe("<% =objRow.Item("episcode") %>",<% =objRow.Item("numero") %>,"<% =objRow.Item("nombre") %>");'style="CURSOR: hand">&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %>
							</TD>
								<!--<TD colspan=3 class="letra_pequena_negrita" style="CURSOR: hand" onclick="javascript:abrir_informe('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"><IMG alt="" src="../imagenes/acrobat.gif" >&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %></TD>-->
								<!-- JGM Fi Modificació 29/12/2010 -->
							</TR>
							<TR>
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
