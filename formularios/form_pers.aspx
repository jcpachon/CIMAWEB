<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_pers.aspx.vb" Inherits="cimaweb.form_pers" buffer="True"%>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="uo_documentos_rel" TagName="uo_documentos_rel" Src="../user_objects/uo_documentos_rel.ascx" %>
<%@ Register TagPrefix="uo_fecha" TagName="uo_fecha" Src="../user_objects/uo_fecha.ascx" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_pers</title>
		<META content="text/html; charset=windows-1252" http-equiv="Content-Type">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="volver" method="post" action="form_agendas.aspx">
			<input style="POSITION: absolute; TOP: 59px; LEFT: 10px" type="hidden" name="servicio_origen">
			<input style="POSITION: absolute; TOP: 59px; LEFT: 10px" type="hidden" name="agenda_origen">
			<input style="POSITION: absolute; TOP: 59px; LEFT: 136px" type="hidden" name="dia_origen">
			<input style="POSITION: absolute; TOP: 59px; LEFT: 262px" type="hidden" name="dia_en_seleccion">
			<input style="POSITION: absolute; TOP: 59px; LEFT: 262px" type="hidden" name="inactiva">
		</form>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		//ventana.close();
	if (control=="1"){
		f_abre("../formularios/form_antecedentes.aspx?pers_key=<% =Session("pers_key") %>" ,550,700,"");
	}
	else if (control=="2"){
		f_abre("../formularios/form_medicacion.aspx",600,850,"");
		//window.showModalDialog("../formularios/form_medicacion.aspx", "","dialogWidth=48;dialogHeight=30;")
	}
	else if (control=="3"){
		window.showModalDialog("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episcode") %>", "","dialogWidth=50;dialogHeight=15;")
		//f_abre_modal("../formularios/form_seleccion_informes_episodio.aspx?episodio=<% =Session("episcode") %>",300,600,"");
	}
	else if (control=="4"){
		f_abre("../formularios/form_medicacion_global.aspx",500,800,"");
	}
	else if (control=="5"){
		f_abre("../informes/informe_curso_clinico.aspx?pers_key=<% =Session("pers_key") %>",700,1000,"");
	}
	else if (control=="6"){
		f_abre("../formularios/form_diagnosticos.aspx?episcode=<% =Session("episcode") %>",500,800,"");
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
		volver.inactiva.value='<% =Session("inactiva") %>';
		volver.submit();
	}
	else if (control=="9"){
		
		<% if Session("servicio_seleccionado") = "RX" then %>
		//alert('No está permitido reprogramar citas de RADIOLOGIA. Anule la cita y créela de nuevo.');
		f_abre("../formularios/form_reprogramar_cita.aspx?servicio_seleccionado=<% =Session("servicio_seleccionado") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&agencode=<% =Session("agenda_seleccionada") %>&pers_key=<% =Session("pers_key") %>&episcode=<% =Session("episcode") %>&inactiva=<% =Session("inactiva") %>&garante=<% =me.Label21.text %>",700,800,"");
		<% else %>
		//f_abre("../formularios/form_reprogramar_cita.aspx?servicio_seleccionado=<% =Session("servicio_seleccionado") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&agencode=<% =Session("agenda_seleccionada") %>&pers_key=<% =Session("pers_key") %>&episcode=<% =Session("episcode") %>&inactiva=<% =Session("inactiva") %>&garante=<% =me.Label21.text %>",700,800,"");
		<% end if %>
	
	}
	else if (control=="10"){
		//f_abre("http://raim.cimaclinic.com/raimserver/web/DirectRetrieve.aspx?AccessionNumber=<% =Session("episcode") %>&Format=z100i0q30h.j12",700,1000,"");
		f_abre("../formularios/form_generar_codigo_web.aspx?episcode=<% =Session("episcode") %>",600,830,"");
	}
	else if (control=="11"){
		f_abre("../formularios/form_captura.aspx?episcode=<% =Session("episcode") %>",700,800,"");
	}
	else if (control=="12"){
		f_abre("../reports/cr_hoja_citacion.aspx?episcode=<% =Session("episcode") %>",600,900,"");
	}
	else if (control=="13"){
		var sFeatures="dialogHeight: 400px; dialogWidth: 500px; center:yes; resizable:no;";
		window.showModalDialog("../formularios/form_prestaciones.aspx?episcode=<% =Session("episcode") %>","",sFeatures)
		//f_abre("../formularios/form_prestaciones.aspx?episcode=<% =Session("episcode") %>",600,900,"");
	}
		//JGM Indicamos el nuevo formulario de consultar incidencias
	else if (control=="15"){
		var sFeatures="dialogHeight: 400px; dialogWidth: 500px; center:yes; resizable:no;";
		window.showModalDialog("../formularios/form_incidencias.aspx?episcode=<% =Session("episcode") %>","",sFeatures)
	}
		//JGM Indicamos el nuevo formulario de recitación para radiologia
	else if (control=="16"){
		f_abre_modal("../formularios/form_cambio_prueba.aspx?episcode=<% =Session("episcode") %>&agencode=<% =Session("agenda_seleccionada") %>",110,380,"");
	}
	;
		</script>
		<script type="text/javascript">
		
	function f_abrir_informe(episcode,numero,nombre){
	
	open_informe.abrir_informe.value="S";
	open_informe.episcode_informe.value=episcode;
	open_informe.numero_informe.value=numero;
	open_informe.nombre_informe.value=nombre;
	
	open_informe.submit();
	
	}
	
	function notificar_entrega_manual(episcode,numero,nombre){
	
	if ('__/__/____' == '<% =CType(Me.FindControl("uo_fecha1").FindControl("fecha_ini"), TextBox).Text %>'){
		alert("Debe especificar una fecha de entrega.");	
	}
	else{	
		if (confirm("Se va a proceder a notificar la entrega del informe al paciente. ¿Está usted seguro?")==1){
		open_informe.abrir_informe.value="I";
		open_informe.tipo.value="M";
		open_informe.episcode_informe.value=episcode;
		open_informe.numero_informe.value=numero;
		open_informe.nombre_informe.value=nombre;
		open_informe.fecha_entrega.value='<% =CType(Me.FindControl("uo_fecha1").FindControl("fecha_ini"), TextBox).Text %>';
		open_informe.comentario.value='<% =Me.TextBox2.Text %>';
	
		open_informe.submit();
		};
	};
	
	}
	
	function notificar_entrega_valija(episcode,numero,nombre){
	
	
	if ('__/__/____' == '<% =CType(Me.FindControl("uo_fecha1").FindControl("fecha_ini"), TextBox).Text %>'){
		alert("Debe especificar una fecha de entrega.");	
	}
	else{
		if (confirm("Se va a proceder a notificar la entrega del informe por valija. ¿Está usted seguro?")==1){
		open_informe.abrir_informe.value="I";
		open_informe.tipo.value="V";
		open_informe.episcode_informe.value=episcode;
		open_informe.numero_informe.value=numero;
		open_informe.nombre_informe.value=nombre;
		open_informe.fecha_entrega.value='<% =CType(Me.FindControl("uo_fecha1").FindControl("fecha_ini"), TextBox).Text %>';
		open_informe.comentario.value='<% =Me.TextBox2.Text %>';
	
		open_informe.submit();
		};
	};
	
	}
	
	function visualizar_historico_radiologia(){
	
	var sFeatures="dialogHeight: 400px; dialogWidth: 600px; center:yes; resizable:no;";
	window.showModalDialog("../formularios/form_historico_radiologia.aspx?pers_key=<% =Session("pers_key") %>","",sFeatures)
	
	}
	
	function visualizar_historico_laboratorio(){
	
	var sFeatures="dialogHeight: 400px; dialogWidth: 500px; center:yes; resizable:no;";
	window.showModalDialog("../formularios/form_historico_laboratorio.aspx?pers_key=<% =Session("pers_key") %>","",sFeatures)
	
	}
		</script>
		<form id="open_informe">
			<input type="hidden" name="abrir_informe"><input type="hidden" name="tipo"><input type="hidden" name="comentario"><input type="hidden" name="fecha_entrega">
			<input type="hidden" name="episcode_informe"> <input type="hidden" name="numero_informe">
			<input type="hidden" name="nombre_informe"> <input value='<% =Session("pers_key") %>' type=hidden 
name=pers_key> <input value='<% =Session("episcode") %>' 
type=hidden name=episcode> <input 
value='<% =Session("mutua") %>' type=hidden name=mutua> <input value='<% =Session("nacimiento") %>' type=hidden name=nacimiento>
			<input value='<% =Session("cove") %>' type=hidden 
name=cove> <input value='<% =Session("estado") %>' 
type=hidden name=estado> <input 
value='<% =Request("realizada") %>' type=hidden name=realizada> <input value='<% =Session("DropDownList2") %>' type=hidden 
name=DropDownList2> <input 
value='<% =Session("DropDownList1") %>' type=hidden name=DropDownList1> <input value='<% =Session("dia_seleccionado") %>' 
type=hidden name=VisibleDate> <input 
value='<% =Session("dia_seleccionado") %>' type=hidden name=dia_seleccionado> <input value='<% =Session("servicio_seleccionado") %>' 
type=hidden name=servicio_seleccionado> <input 
value='<% =Session("agenda_seleccionada") %>' type=hidden 
name=agenda_seleccionada> <input 
value='<% =Session("inactiva") %>' type=hidden name=inactiva>
		</form>
		<form id="Form1" method="post" runat="server">
			<input type="hidden" name="abrir_informe">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; HEIGHT: 100%; TOP: 11px; LEFT: 11px"
				id="Table1" border="0" cellSpacing="0" cellPadding="0" width="805">
				<TBODY>
					<TR>
						<TD class="cabecera_formulario" height="22" colSpan="3">Ficha Paciente
							<asp:label id=Label24 runat="server" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persfullname") %>'>
							</asp:label></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"><asp:panel id="Panel1" runat="server" Width="100%">
								<TABLE id="Table7" border="0" cellSpacing="0" cellPadding="0" width="100%">
									<TR>
										<TD class="letra_negrita" vAlign="top">EPISODIO:
											<asp:label id="Label19" runat="server" Width="224px" CssClass="letra_negrita"></asp:label><BR>
											AGENDA:
											<asp:label id="Label12" runat="server" Width="224px" CssClass="letra_negrita"></asp:label><BR>
											FECHA:
											<asp:label id="Label13" runat="server" Width="224px" CssClass="letra_negrita"></asp:label></TD>
										<TD width="11"></TD>
										<TD>
											<TABLE id="Table8" border="0" cellSpacing="0" cellPadding="0" width="100%">
												<TR>
													<TD class="letra_negrita" align="right">Garante:
														<asp:Label id="Label21" runat="server">Label</asp:Label></TD>
													<TD class="letra_negrita" align="right"></TD>
												</TR>
												<TR>
													<TD class="letra_negrita" align="right">Edad:
														<asp:Label id="Label22" runat="server">Label</asp:Label></TD>
													<TD class="letra_negrita" width="22" align="right"></TD>
												</TR>
												<TR>
													<TD class="letra_negrita" align="right">Cobertura:
														<asp:Label id="Label23" runat="server">Label</asp:Label></TD>
													<TD></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" runat="server" Width="350px" Height="50px" Visible="False"></CR:CRYSTALREPORTVIEWER></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="3">
							<TABLE id="Table6" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD width="10"><asp:button id="Button9" runat="server" Width="150px" Text="Volver"></asp:button></TD>
									<TD width="7"></TD>
									<TD width="11"><asp:button id="Button10" runat="server" Width="150px" Text="Reprogramar"></asp:button></TD>
									<TD width="7"></TD>
									<TD width="11"><asp:button id="Button12" runat="server" Width="150px" Text="Capturar"></asp:button></TD>
									<TD width="7"></TD>
									<TD width="11"><asp:button id="Button13" runat="server" Width="150px" Text="Hoja de Citación"></asp:button></TD>
									<TD width="7"></TD>
									<TD><asp:button id="Button11" runat="server" Width="150px" Text="Generar Código WEB" Enabled="True"
											Font-Bold="True" BackColor="#C0FFFF"></asp:button></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD vAlign="top" colSpan="3">
							<TABLE id="Table2" border="0" cellSpacing="1" cellPadding="1" width="100%">
								<TBODY>
									<TR height="11">
										<TD class="letra_formulario" height="11" colSpan="2"></TD>
									</TR>
									<!-- JGM MODIFICACIÓ 26/01/2011 -->
									<TR height="11">
										<TD class="cabecera_formulario" height="11">DATOS DEL PACIENTE</TD>
										<TD height="11" align="right"><asp:button id="Button18" runat="server" Width="150px" Text="Mostrar Datos"></asp:button></TD>
									</TR>
									<asp:panel id="Panel4" runat="server">
										<TR height="11">
											<TD class="letra_formulario" height="11" colSpan="2"></TD>
										<TR>
											<TD class="letra_formulario" height="11">ESTADO:&nbsp;
												<asp:label id=Label5 runat="server" Width="280px" Text='<%# EstadoEval(DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persacti")) %>'>
												</asp:label></TD>
											<TD height="11" align="right"><asp:button id="BTmodificarDatos" runat="server" Width="150px" Text="Modificar Datos"></asp:button></TD>
										</TR>
										<TR>
											<TD height="11" colSpan="2"></TD>
										</TR>
										<TR>
											<TD height="50" vAlign="top" colSpan="2">
												<TABLE id="Table3" border="0" cellSpacing="0" cellPadding="0" width="100%">
													<TR>
														<TD class="fondo_formulario" height="11" width="120">Nombre</TD>
														<TD height="11" width="11"></TD>
														<TD class="fondo_formulario" height="11" width="120">1º Apellido</TD>
														<TD height="11" width="11"></TD>
														<TD class="fondo_formulario" height="11" width="120">2º Apellido</TD>
														<TD height="11" width="11"></TD>
														<TD class="fondo_formulario" height="11" width="50">Sexo</TD>
														<TD height="11" width="11"></TD>
														<TD class="fondo_formulario" height="11" width="150">Fecha de Nacimiento</TD>
														<TD height="11" width="11"></TD>
														<TD class="fondo_formulario" height="11" width="11">DNI</TD>
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
														<TD class="fondo_formulario" height="11" width="50" colSpan="11">Dirección</TD>
													</TR>
													<TR>
														<TD height="19" width="120" colSpan="11"><asp:label id=Label10 runat="server" Width="568px" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrnameaddr") %>'>
															</asp:label></TD>
													</TR>
													<TR>
														<TD class="fondo_formulario" width="120">Teléfono</TD>
														<TD></TD>
														<TD class="fondo_formulario" width="120">Móvil</TD>
														<TD></TD>
														<TD class="fondo_formulario" width="120">E-mail 1</TD>
														<TD></TD>
														<TD class="fondo_formulario" width="120" colSpan="3">E-mail 2</TD>
														<TD></TD>
														<TD class="fondo_formulario">NHC</TD>
													</TR>
													<TR>
														<TD height="11" width="120"><asp:label id=Label6 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrtel1") %>'>
															</asp:label></TD>
														<TD height="11"></TD>
														<TD height="11" width="120"><asp:label id=Label7 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrtel2") %>'>
															</asp:label></TD>
														<TD height="11"></TD>
														<TD height="11" width="120"><asp:label id=Label18 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].addrmail") %>'>
															</asp:label></TD>
														<TD height="11"></TD>
														<TD height="11" width="120" colSpan="3"><asp:label id=Label20 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persmai1") %>'>
															</asp:label></TD>
														<TD height="11"></TD>
														<TD height="11"><asp:label id=Label15 runat="server" CssClass="letra_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].pati_hfn") %>'>
															</asp:label></TD>
													</TR>
													<TR>
														<TD height="*" width="120" colSpan="6"></TD>
														<TD width="50"></TD>
														<TD></TD>
														<TD></TD>
														<TD></TD>
														<TD></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
						</TD>
					</TR>
					</asp:panel>
					<TR>
						<TD height="11" colSpan="2"></TD>
					</TR>
					<TR>
						<TD class="letra_pequena_negrita" height="11" colSpan="2"><asp:label id="Label14" runat="server">Notas Administrativas:</asp:label></TD>
					</TR>
					<TR>
						<TD height="11" colSpan="2"></TD>
					</TR>
					<TR>
						<TD class="letra_pequena_negrita" height="11" width="600"><asp:textbox id="TextBox1" runat="server" Width="94%"></asp:textbox><IMG src="../imagenes/ojo.gif">
						</TD>
						<TD class="letra_negrita" height="11" align="right"><asp:button id="Button14" runat="server" Width="150" Text="Actualizar"></asp:button></TD>
					</TR>
					<asp:panel id="Panel3" runat="server">
						<TR>
							<TD class="letra_pequena_negrita" height="11" colSpan="2">
								<asp:Label id="Label17" runat="server">Notas del Episodio:</asp:Label></TD>
						</TR>
						<TR>
							<TD height="11" colSpan="2"></TD>
						</TR>
						<TR>
							<TD class="letra_pequena_negrita" height="11" width="600">
								<asp:TextBox id="Textbox3" runat="server" Width="94%"></asp:TextBox><IMG src="../imagenes/nota_episodio.jpg">
							</TD>
							<TD class="letra_negrita" height="11" align="right">
								<asp:Button id="Button15" runat="server" Text="Actualizar" Width="150"></asp:Button></TD>
						</TR>
					</asp:panel><asp:panel id="Panel2" runat="server">
						<TR>
							<TD height="11" colSpan="2"></TD>
						</TR>
						<TR>
							<TD class="letra_negrita" height="11" vAlign="top" colSpan="2">
								<HR SIZE="1" width="100%">
								<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
									<TR>
										<TD class="letra_negrita">&nbsp; INFORMES DE RADIOLOGÍA</TD>
										<TD align="right"><INPUT style="WIDTH: 150px" onclick="javascript:visualizar_historico_radiologia();" value="Ver Histórico"
												type="button"></TD>
									</TR>
								</TABLE>
								<HR SIZE="1" width="100%">
								<%
									
							Dim str_menu as string
											
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							Dim contador as integer
							
							
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.[SP_CIMACEX_RECUPERA_EPIS_INFORMES_MOD] '" & Session("episcode") & "','cetir.carga'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							contador = 0
							
							for each objRow in objDS.Tables(0).Rows
							
							contador = contador + 1
									
							%>
								<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<TR height="11">
										<TD colSpan="3"><% if Session("apporendcode") = "0" then %>
											<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
												<TR height="11"> <!-- JGM ASTERISCAR PER VEURE MODE DISSENY  -->
												<TD colspan="2" class="letra_pequena_negrita" style="CURSOR: hand" onclick="javascript:f_abrir_informe('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"><IMG alt="" src="../imagenes/acrobat.gif">&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %></TD>
												<td align=right><INPUT style="WIDTH: 150px" type="button" value="Notificación Entrega Valija" onclick="javascript:notificar_entrega_valija('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"></td>
												<td width="11"></td>
												<TD width="11"><INPUT style="WIDTH: 150px" type="button" value="Notificación Entrega Manual" onclick="javascript:notificar_entrega_manual('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"></TD>
											 <!-- JGM FI ASTERISCAR --></TR>
											</TABLE>
											<% end if %>
											<asp:label id="Label11" runat="server" Width="175px" CssClass="informe_entregado" Height="18"
												Visible="False">Informe Entregado</asp:label>&nbsp;&nbsp;&nbsp;
											<asp:label id="Label111" runat="server" CssClass="letra_negrita" Height="18" Visible="False"></asp:label></TD>
									</TR>
									<TR height="11">
										<TD></TD>
										<TD></TD>
										<TD></TD>
									</TR>
									<% if Session("apporendcode") = "0" then %>
									<TR height="11">
										<TD colSpan="3">
											<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
												<TR height="11">
													<TD class="letra_pequena_negrita" width="300">Comentarios:&nbsp;&nbsp;&nbsp;
														<asp:textbox id="Textbox2" runat="server" Width="200px" CssClass="letra_pequena_centrada" AutoPostBack="true"></asp:textbox></TD> <!--td width="11"></td-->
													<TD><uo_fecha:uo_fecha id="uo_fecha1" runat="server"></uo_fecha:uo_fecha></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
									<% end if %>
								</TABLE>
								<%
								
								next
							
								end if
								
							%>
							</TD>
						</TR>
						<HR SIZE="1" width="100%">
				</TBODY>
			</TABLE>
			<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD class="letra_negrita">&nbsp; INFORMES DE LABORATORIO</TD>
					<TD align="right"><INPUT style="WIDTH: 150px" onclick="javascript:visualizar_historico_laboratorio();" value="Ver Histórico"
							type="button"></TD>
				</TR>
			</TABLE>
			<HR SIZE="1" width="100%">
			<%
									
							'Dim str_menu as string
											
							'Dim objCIMA as New CIMA_Clases.CIMA
							
							'Dim objDS as New Data.DataSet
							
							'Dim objRow as Data.DataRow
							
							'Dim contador as integer
							
							
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.[SP_CIMACEX_RECUPERA_EPIS_INFORMES_MOD] '" & Session("episcode") & "','echevarne.carga'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							contador = 0
							
							for each objRow in objDS.Tables(0).Rows
							
							contador = contador + 1
									
							%>
			<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
				<TR height="11">
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
				<TR> <!-- JGM ASTERISCAR PER VEURE EN MODE DISSENY -->
											<TD colspan="2" class="letra_pequena_negrita" style="CURSOR: hand" onclick="javascript:f_abrir_informe('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');"><IMG alt="" src="../imagenes/acrobat.gif">&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %></TD>
											<TD class="letra_pequena_negrita" style="CURSOR: hand" align="right">
											<% if Session("apporendcode") = "0" then %>
											<INPUT style="WIDTH: 150px" type="button" value="Notificar Entrega" onclick="javascript:notificar_entrega('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');">
											<% end if %>
												<asp:Label id="Label16" runat="server" Width="175px" CssClass="informe_entregado"
													Visible="False" Height="18">Informe Entregado</asp:Label></TD>
										 <!-- JGM FI ASTERISCAR --></TR>
				<TR height="11">
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
			</TABLE>
			<%
								
				next
							
				end if
								
			%>
			<% if (Session("grupo") = "M") or (Session("grupo") = "E") then %>
			<!-- JGM ALERTA de ANTECEDENTES -->
			<TR>
				<TD height="11" colSpan="3">
					<div style="Z-INDEX: 1; POSITION: relative; TEXT-ALIGN: center; PADDING-BOTTOM: 2px; BACKGROUND-COLOR: red; PADDING-LEFT: 11pt; WIDTH: 100%; FONT-FAMILY: Tahoma; HEIGHT: 11px; VISIBILITY: visible; FONT-SIZE: larger; VERTICAL-ALIGN: baseline; FONT-WEIGHT: bold; PADDING-TOP: 2pt; PADDING-BOTOOM: 2pt; padding-botom: 3 pt"
						id="alerta" class="letra_grande_negrita" align="center" runat="server">PACIENTE 
						CON ANTECEDENTES
						<BR>
						<BR>
						<!--<input id=b_alerta onclick="javascript:document.getElementById('alerta').style.visibility = 'hidden';" type=button value=ACEPTAR>-->
					</div>
				</TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<!-- JGM -->
			<% end if %>
			<TR>
				<TD height="11" colSpan="2"></TD>
			</TR>
			<TR>
				<TD class="letra_negrita" colSpan="2">&nbsp; OTROS DOCUMENTOS</TD>
			</TR>
			<TR>
				<TD height="11" vAlign="top" colSpan="2">
					<HR SIZE="1" width="100%">
					<uo_documentos_rel:uo_documentos_rel id="uo_documentos_rel1" runat="server"></uo_documentos_rel:uo_documentos_rel></TD>
			</TR>
			<TR>
				<TD height="20" vAlign="top" colSpan="2">
					<TABLE id="Table5" border="0" cellSpacing="0" cellPadding="0" width="100%">
						<TR>
							<TD height="11" width="150"></TD>
							<TD height="11" width="217"></TD>
							<TD height="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11" width="11"></TD>
						</TR>
						<TR>
							<TD height="11" width="217" align="left"><asp:button id="Button5" runat="server" Width="130px" Text="Plantillas" BackColor="MidnightBlue"
									ForeColor="White"></asp:button></TD>
							<TD height="11" width="11" align="center"><asp:button id="Button6" runat="server" Width="130px" Visible="False" Text="Generar Receta"
									BackColor="#00C000" ForeColor="White"></asp:button></TD>
							<TD height="11" align="center"></TD>
							<TD height="11" width="11" align="center"><asp:button id="Button3" runat="server" Width="105px" Text="Histórico"></asp:button></TD>
														<TD height="11" width="11" align="center"><asp:button id="Button8" runat="server" Width="105px" Text="Curso Clínico Grupo"></asp:button></TD>
							<TD height="11" align="center"><asp:button id="Button4" runat="server" Width="105px" Text="Medicación"></asp:button></TD>
							<TD height="11" width="11" align="center"><asp:button id="Button2" runat="server" Width="105px" Text="Antecedentes"></asp:button></TD>
							<TD height="11" width="11" align="center"><asp:button id="Button7" runat="server" Width="105px" Text="Diagnósticos"></asp:button></TD>
						</TR>
						<TR>
							<TD height="11" width="150"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11"></TD>
							<TD height="11" width="11"></TD>
							<TD height="11" width="11"></TD>
						</TR>
					</TABLE>
				</TD>
			</TR>
			</asp:panel>
			<TR>
				<TD colSpan="2">
					<TABLE id="Table4" border="0" cellSpacing="0" cellPadding="0" width="100%">
						<TR>
							<TD height="11"></TD>
							<TD height="11"></TD>
							<TD height="11"></TD>
						</TR>
						<TR>
							<TD class="cabecera_formulario" height="11" colSpan="2">EPISODIOS</TD>
							<TD height="11" align="right"><asp:button id="Button19" runat="server" Width="150px" Text="Mostrar"></asp:button></TD>
						</TR>
						<TR>
							<TD height="11"></TD>
							<TD height="11"></TD>
							<TD height="11"></TD>
						</TR>
						<TR>
							<TD height="11"><asp:button id="Button1" runat="server" Width="150px" Text="Ir a ..."></asp:button>&nbsp;
								<asp:button id="Button16" runat="server" Width="150px" Text="Anular cita" Enabled="True"></asp:button>&nbsp;
								<asp:button id="Button17" runat="server" Width="150px" Text="Reprogramar"></asp:button></TD>
							<TD height="11"><asp:checkbox id="chek_anulada" runat="server" CssClass="letra_pequena" Text="Anuladas" AutoPostBack="True"></asp:checkbox></TD>
							<TD height="11"></TD>
						</TR>
						<asp:Panel id="Panel5" runat="server">
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD colSpan="3">
									<asp:datagrid id=DataGrid1 runat="server" Width="100%" BackColor="White" ForeColor="Black" AutoGenerateColumns="False" ShowFooter="True" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" DataSource="<%# Ds_epis1 %>" DataMember="epis" DataKeyField="Episodio" CellPadding="3" GridLines="Vertical" Font-Size="7pt" Font-Names="Verdana">
										<FooterStyle Width="60%" BackColor="#CCCCCC"></FooterStyle>
										<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
										<ItemStyle Font-Size="5pt" Font-Names="Verdana" Font-Bold="True" ForeColor="Black" CssClass="letra_pequena"
											BackColor="White"></ItemStyle>
										<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
										<Columns>
											<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
											<asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha">
												<HeaderStyle Width="60px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Hora" SortExpression="Hora" HeaderText="Hora"></asp:BoundColumn>
											<asp:BoundColumn DataField="&#193;rea" SortExpression="&#193;rea" HeaderText="&#193;rea">
												<HeaderStyle Width="120px"></HeaderStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Agenda" SortExpression="Agenda" HeaderText="Agenda"></asp:BoundColumn>
											<asp:BoundColumn DataField="Prestacion" SortExpression="Prestacion" HeaderText="Prestaci&#243;n"></asp:BoundColumn>
											<asp:BoundColumn DataField="Doctor" SortExpression="Doctor" HeaderText="Doctor"></asp:BoundColumn>
											<asp:BoundColumn DataField="Episodio" SortExpression="Episodio" HeaderText="Episodio"></asp:BoundColumn>
											<asp:BoundColumn DataField="Estado" SortExpression="Estado" HeaderText="Estado"></asp:BoundColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
									</asp:datagrid></TD>
							</TR>
						</asp:Panel>
						<TR>
							<TD height="11"></TD>
							<TD height="11"></TD>
							<TD height="11"></TD>
						</TR>
					</TABLE>
				</TD>
			</TR>
			</TBODY></TABLE></TD></TR><TR>
				<TD height="11"></TD>
				<TD height="11"></TD>
				<TD height="11"></TD>
			</TR>
			</TABLE></form>
		</TD></TR></TBODY></TABLE></FORM>
	</body>
</HTML>
