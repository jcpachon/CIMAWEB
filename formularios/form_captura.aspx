<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_captura.aspx.vb" Inherits="cimaweb.form_captura"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Captura de Actividad</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
		<script type="text/javascript">


	function anular_incidencia_episodio(id_incidencia_episodio){
	
	anular_incidencia.eliminar_incidencia.value="S";
	anular_incidencia.id_incidencia_episodio.value=id_incidencia_episodio;
	anular_incidencia.submit();
	
	}
	
	function anular_prestacion(bookproc_key){
	
	anular_bookproc_key.eliminar_prestacion.value="S";
	anular_bookproc_key.bookproc_key.value=bookproc_key;
	anular_bookproc_key.submit();
	
	}
	
	function buscar_en_el_dd(){
	
	Form1.Dropdownlist8.value = document.getElementById("caja_codigo").value;
	
	};
	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form name="anular_bookproc_key">
			<input type=hidden 
value='<% =Request("episcode") %>' name=episcode> <input type="hidden" name="bookproc_key"> <input type="hidden" name="eliminar_prestacion">
			<input type=hidden 
value='<% =request("dropdownlist4") %>' name=dropdownlist4><input type=hidden value='<% =request("dropdownlist5") %>' 
name=dropdownlist5><input type=hidden 
value='<% =request("dropdownlist6") %>' name=dropdownlist6><input type=hidden value='<% =request("dropdownlist7") %>' 
name=dropdownlist7> <input type=hidden 
value='<% =request("dropdownlist2") %>' name=dropdownlist2><input type=hidden value='<% =request("dropdownlist3") %>' 
name=dropdownlist3>
		</form>
		<form name="anular_incidencia">
			<input type="hidden" name="id_incidencia_episodio"> <input type="hidden" name="eliminar_incidencia">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD class="cabecera_formulario" colSpan="4" height="22">Captura de Actividad</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD class="menu_lateral_izquierdo" colSpan="4" height="11"><asp:label id="Label1" runat="server" CssClass="letra_pequena_negrita">EPISODIO:</asp:label>&nbsp;
							<asp:label id=Label2 runat="server" CssClass="letra" Width="96px" Text='<%# DataBinder.Eval(Ds_datos_captura1, "Tables[SP_CIMACEX_DATOS_CAPTURA].DefaultView.[0].episcode") %>'>
							</asp:label><asp:label id="Label3" runat="server" CssClass="letra_pequena_negrita">PACIENTE:</asp:label>&nbsp;
							<asp:label id=Label4 runat="server" CssClass="letra" Width="296px" Text='<%# DataBinder.Eval(Ds_datos_captura1, "Tables[SP_CIMACEX_DATOS_CAPTURA].DefaultView.[0].persfullname") %>'>
							</asp:label></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="22">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD width="250"><asp:label id="Label5" runat="server" CssClass="letra_pequena_negrita">Motivo: </asp:label>&nbsp;<asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" DataValueField="apporendcode" DataTextField="apporenddesc" DataMember="apporend" DataSource="<%# Ds_apporend1 %>">
										</asp:dropdownlist></TD>
									<TD width="22"></TD>
									<TD><asp:label id="Label7" runat="server" CssClass="letra_pequena_negrita">Hora Inicio Visita: </asp:label>&nbsp;<asp:textbox id=TextBox2 runat="server" CssClass="letra_pequena_centrada" Width="75px" Text='<%# DataBinder.Eval(Ds_datos_captura1, "Tables[SP_CIMACEX_DATOS_CAPTURA].DefaultView.[0].hora_ini") %>'>
										</asp:textbox>&nbsp;&nbsp;
										<asp:label id="Label8" runat="server" CssClass="letra_pequena_negrita">Hora Fin Visita: </asp:label>&nbsp;<asp:textbox id=TextBox1 runat="server" CssClass="letra_pequena_centrada" Width="75px" Text='<%# DataBinder.Eval(Ds_datos_captura1, "Tables[SP_CIMACEX_DATOS_CAPTURA].DefaultView.[0].hora_fin") %>'>
										</asp:textbox></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="22">
							<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD><asp:label id="Label9" runat="server" CssClass="letra_pequena_negrita">Garante: </asp:label>&nbsp;<asp:label id=Label10 runat="server" CssClass="letra_pequena" Width="200px" Text='<%# DataBinder.Eval(Ds_datos_captura_garante1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE].DefaultView.[0].firmname") %>'></asp:label><asp:label id="Label12" runat="server" CssClass="letra_pequena_negrita">Agrupación de Coberturas: </asp:label>&nbsp;<asp:label id=Label11 runat="server" CssClass="letra_pequena" Width="175px" Text='<%# DataBinder.Eval(Ds_datos_captura_garante1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE].DefaultView.[0].covegroudesclong") %>'></asp:label></TD>
									<TD align="right"><asp:button id="Button1" runat="server" Width="150px" Text="Modificar Garante"></asp:button></TD>
								</TR>
							</TABLE>
							<asp:label id=firm_key_1 runat="server" CssClass="letra_pequena" Width="200px" Text='<%# DataBinder.Eval(Ds_datos_captura_garante1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE].DefaultView.[0].firm_key") %>' Visible="False">
							</asp:label><asp:label id=covegrou_key_1 runat="server" CssClass="letra_pequena" Width="200px" Text='<%# DataBinder.Eval(Ds_datos_captura_garante1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE].DefaultView.[0].covegrou_key") %>' Visible="False">
							</asp:label></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"><asp:panel id="Panel1" runat="server" Visible="False">
								<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="100%" bgColor="lightgrey" border="0">
									<TR>
										<TD bgColor="white" colSpan="3" height="11"></TD>
									</TR>
									<TR>
										<TD colSpan="3" height="11"></TD>
									</TR>
									<TR>
										<TD class="fecha_letra" colSpan="3" height="11">Garantes del Episodio</TD>
									</TR>
									<TR>
										<TD colSpan="3" height="11"></TD>
									</TR>
									<TR>
										<TD style="PADDING-LEFT: 11px" width="300" height="16">
											<asp:label id="Label24" runat="server" CssClass="letra_pequena_negrita">Garante: </asp:label>&nbsp;
											<asp:dropdownlist id=Dropdownlist9 runat="server" CssClass="letra_pequena" Width="225px" DataSource="<%# Ds_firm_garantes1 %>" DataMember="firm" DataTextField="firmname" DataValueField="firm_key" AutoPostBack="True">
											</asp:dropdownlist></TD>
										<TD style="HEIGHT: 16px" width="11" height="16"></TD>
										<TD height="16">
											<asp:label id="Label25" runat="server" CssClass="letra_pequena_negrita">Agrupación de Coberturas: </asp:label>&nbsp;
											<asp:dropdownlist id=Dropdownlist10 runat="server" CssClass="letra_pequena" Width="225px" DataSource="<%# Ds_covegrou1 %>" DataMember="covegrou" DataTextField="covegroudesclong" DataValueField="covegrou_key">
											</asp:dropdownlist></TD>
									</TR>
									<TR>
										<TD width="300" colSpan="3" height="11"></TD>
									</TR>
									<TR>
										<TD style="PADDING-LEFT: 11px" colSpan="3" height="11">
											<asp:label id="Label21" runat="server" CssClass="letra_pequena_negrita">Nº de Póliza: </asp:label>&nbsp;
											<asp:TextBox id="num_poliza" runat="server" CssClass="letra_pequena_centrada"></asp:TextBox>&nbsp;&nbsp;
											<asp:label id="Label28" runat="server" CssClass="letra_pequena_negrita">Nº de Autorización: </asp:label>&nbsp;
											<asp:TextBox id="num_peticion" runat="server" CssClass="letra_pequena_centrada"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD width="300" colSpan="3" height="11"></TD>
									</TR>
									<TR>
										<TD align="right" colSpan="3" height="11">
											<asp:button id="Button4" runat="server" Text="Actualizar" Width="150px"></asp:button></TD>
									</TR>
									<TR>
										<TD align="right" colSpan="3" height="11"></TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD width="350" height="11"><asp:label id="Label26" runat="server" CssClass="letra_pequena_negrita">Nº de Póliza: </asp:label>&nbsp;
										<asp:textbox id=TextBox5 runat="server" CssClass="letra_pequena_centrada" Text='<%# DataBinder.Eval(Ds_datos_captura_garante_poliza1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE2].DefaultView.[0].num_poliza") %>'>
										</asp:textbox></TD>
									<TD width="22" height="11"></TD>
									<TD height="11"><asp:label id="Label27" runat="server" CssClass="letra_pequena_negrita">Nº de Autorización: </asp:label>&nbsp;
										<asp:textbox id=TextBox6 runat="server" CssClass="letra_pequena_centrada" Text='<%# DataBinder.Eval(Ds_datos_captura_garante_poliza1, "Tables[SP_CIMACEX_DATOS_CAPTURA_GARANTE2].DefaultView.[0].num_autori") %>'>
										</asp:textbox></TD>
								</TR>
								<TR>
									<TD width="350" height="22"></TD>
									<TD width="22" height="22"></TD>
									<TD height="22"></TD>
								</TR>
								<TR>
									<TD width="350"><asp:label id="Label6" runat="server" CssClass="letra_pequena_negrita">Médico actual: </asp:label>&nbsp;<asp:dropdownlist id=DropDownList2 runat="server" CssClass="letra_pequena" DataValueField="cstahper_key" DataTextField="persfullname" DataMember="cstahper" DataSource="<%# Ds_datos_captura_cstahper1 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
									<TD width="22"></TD>
									<TD><asp:label id="Label13" runat="server" CssClass="letra_pequena_negrita">Informador: </asp:label>&nbsp;<asp:dropdownlist id=DropDownList3 runat="server" CssClass="letra_pequena" DataValueField="cstahper_key" DataTextField="persfullname" DataMember="cstahper" DataSource="<%# Ds_datos_captura_cstahper2 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<HR width="100%" SIZE="1">
						</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="100%" border="1">
								<TR>
									<TD width="175"><asp:label id="Label14" runat="server" CssClass="letra_pequena_negrita">Centro Origen:</asp:label></TD>
									<TD class="letra_pequena" width="250">CENTRO INTERNACIONAL DE MEDICINA AVANZADA</TD>
									<TD width="11" rowSpan="3"></TD>
									<TD width="175"><asp:label id="Label17" runat="server" CssClass="letra_pequena_negrita">Centro Destino:</asp:label></TD>
									<TD class="letra_pequena" width="250">CENTRO INTERNACIONAL DE MEDICINA AVANZADA</TD>
								</TR>
								<TR>
									<TD width="175"><asp:label id="Label15" runat="server" CssClass="letra_pequena_negrita">Servicio de Procedencia:</asp:label></TD>
									<TD><asp:dropdownlist id=DropDownList4 runat="server" CssClass="letra_pequena" Width="225px" DataValueField="csta_key" DataTextField="cstadesclong" DataMember="csta" DataSource="<%# Ds_csta1 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
									<TD width="175"><asp:label id="Label18" runat="server" CssClass="letra_pequena_negrita">Servicio de Destino:</asp:label></TD>
									<TD><asp:dropdownlist id=DropDownList6 runat="server" CssClass="letra_pequena" Width="225px" DataValueField="csta_key" DataTextField="cstadesclong" DataMember="csta" DataSource="<%# Ds_csta2 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD width="175"><asp:label id="Label16" runat="server" CssClass="letra_pequena_negrita">Médico de Procedencia:</asp:label></TD>
									<TD><asp:dropdownlist id=DropDownList5 runat="server" CssClass="letra_pequena" DataValueField="cstahper_key" DataTextField="persfullname" DataMember="cstahper" DataSource="<%# Ds_datos_captura_cstahper3 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
									<TD width="175"><asp:label id="Label19" runat="server" CssClass="letra_pequena_negrita">Médico de Destino:</asp:label></TD>
									<TD><asp:dropdownlist id=DropDownList7 runat="server" CssClass="letra_pequena" DataValueField="cstahper_key" DataTextField="persfullname" DataMember="cstahper" DataSource="<%# Ds_datos_captura_cstahper4 %>" AutoPostBack="True">
										</asp:dropdownlist></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<HR width="100%" SIZE="1">
							&nbsp;</TD>
					</TR>
					<TR>
						<TD class="cabecera_busca_pacientes" colSpan="4" height="11">Prestaciones</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"><asp:datalist id=DataList1 runat="server" Width="100%" DataMember="hpro" DataSource="<%# Ds_hpro1 %>" DataKeyField="hpro_key">
								<HeaderTemplate>
									<TABLE id="Table66" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD width="150">
												<asp:Label id="Label22" runat="server" CssClass="letra_pequena_negrita">Código</asp:Label></TD>
											<TD width="11"></TD>
											<TD width="255">
												<asp:Label id="Label23" runat="server" CssClass="letra_pequena_negrita">Prestación</asp:Label></TD>
										</TR>
									</TABLE>
								</HeaderTemplate>
								<ItemTemplate>
									<TABLE id="Table6" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD width="150"></TD>
											<TD width="11"></TD>
											<TD width="255"></TD>
											<TD width="11"></TD>
											<TD width="75"></TD>
										</TR>
										<TR>
											<TD>
												<asp:TextBox id=TextBox3 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.hprocode") %>' ReadOnly="True">
												</asp:TextBox></TD>
											<TD></TD>
											<TD>
												<asp:TextBox id=TextBox4 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.hprodesclong") %>' Width="255px" ReadOnly="True">
												</asp:TextBox></TD>
											<TD width="33"></TD>
											<TD align="right"><INPUT type="button" value="Eliminar" onclick='javascript:anular_prestacion(<%# DataBinder.Eval(Container, "DataItem.bookproc_key") %>);' style="WIDTH: 150px">
											</TD>
										</TR>
									</TABLE>
								</ItemTemplate>
							</asp:datalist></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD vAlign="bottom" colSpan="3">
										<HR width="100%" SIZE="1">
									</TD>
								</TR>
								<TR>
									<TD><asp:label id="Label20" runat="server" CssClass="letra_pequena_negrita">Prestación:</asp:label>&nbsp;<asp:dropdownlist id=Dropdownlist8 runat="server" CssClass="letra_pequena" Width="350px" DataValueField="hpro_key" DataTextField="hprodesclong" DataMember="SP_CIMACEX_PRESTACIONES_AGEN" DataSource="<%# Ds_datos_captura_prestaciones_agen1 %>">
										</asp:dropdownlist></TD>
									<TD>&nbsp;&nbsp;</TD>
									<TD align="right">&nbsp;&nbsp;&nbsp;
										<asp:button id="Button3" runat="server" Width="150px" Text="Añadir Prestación"></asp:button></TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD height="11"></TD>
									<TD align="right" height="11"></TD>
								</TR>
								<TR>
									<TD height="11">
										<asp:label id="Label29" runat="server" CssClass="letra_pequena_negrita">Búsqueda por código:</asp:label>&nbsp;<INPUT class="letra_pequena_centrada" id="caja_codigo" style="WIDTH: 75px" type="text">&nbsp;<INPUT class="letra_pequena" style="WIDTH: 50px" onclick="javascript:buscar_en_el_dd();"
											type="button" size="20" value="Buscar"></TD>
									<TD height="11"></TD>
									<TD align="right" height="11"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD align="right" colSpan="4" height="11">
							<HR width="100%" SIZE="1">
						</TD>
					</TR>
					<TR>
						<TD class="cabecera_busca_pacientes" colSpan="4" height="11">Incidencias</TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<asp:DataList id="DataList2" runat="server" DataSource="<%# Ds_incidencia_episodio1 %>" DataMember="incidencia_episodio" DataKeyField="id_incidencia_episodio">
								<HeaderTemplate>
									<TABLE id="Table11" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD width="150">
												<asp:Label id="Label30" runat="server" CssClass="letra_pequena_negrita">Código</asp:Label></TD>
											<TD width="11"></TD>
											<TD width="255">
												<asp:Label id="Label31" runat="server" CssClass="letra_pequena_negrita">Incidencia</asp:Label></TD>
										</TR>
									</TABLE>
								</HeaderTemplate>
								<ItemTemplate>
									<TABLE id="Table9" cellSpacing="0" cellPadding="0" border="0">
										<TR>
											<TD width="150"></TD>
											<TD width="11"></TD>
											<TD width="255"></TD>
											<TD width="11"></TD>
											<TD width="75"></TD>
										</TR>
										<TR>
											<TD>
												<asp:TextBox id=TextBox7 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.codigo_inc") %>' ReadOnly="True">
												</asp:TextBox>
											<TD></TD>
											<TD>
												<asp:TextBox id=TextBox8 runat="server" CssClass="letra_pequena" Text='<%# DataBinder.Eval(Container, "DataItem.descripcion_inc") %>' Width="255px" ReadOnly="True">
												</asp:TextBox></TD>
											<TD width="33"></TD>
											<TD align="right"><INPUT style="WIDTH: 150px" onclick='javascript:anular_incidencia_episodio(<%# DataBinder.Eval(Container, "DataItem.id_incidencia_episodio") %>);' type=button value=Eliminar></TD>
										</TR>
									</TABLE>
								</ItemTemplate>
							</asp:DataList></TD>
					</TR>
					<TR>
						<TD colSpan="4" height="11">
							<TABLE id="Table10" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD vAlign="bottom" colSpan="3">
										<HR width="100%" SIZE="1">
									</TD>
								</TR>
								<TR>
									<TD><asp:label id="Label32" runat="server" CssClass="letra_pequena_negrita">Incidencia:</asp:label>&nbsp;<asp:dropdownlist id="Dropdownlist11" runat="server" CssClass="letra_pequena" Width="350px" DataValueField="id_incidencia" DataTextField="descripcion_inc" DataMember="incidencias" DataSource="<%# Ds_incidencias1 %>">
										</asp:dropdownlist></TD>
									<TD>&nbsp;&nbsp;</TD>
									<TD align="right">&nbsp;&nbsp;&nbsp;
										<asp:button id="Button5" runat="server" Width="150px" Text="Añadir Incidencia"></asp:button></TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD height="11"></TD>
									<TD align="right" height="11"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD align="right" colSpan="4" height="11">
							<HR width="100%" SIZE="1">
						</TD>
					</TR>
					<TR>
						<TD align="right" colSpan="4" height="11"></TD>
					</TR>
					<TR>
						<TD vAlign="bottom" align="right" colSpan="4"><asp:button id="Button2" runat="server" Width="150px" Text="Capturar"></asp:button></TD>
					</TR>
					<TR>
						<TD vAlign="bottom" align="right" colSpan="4" height="11"></TD>
					</TR>
				</TBODY>
			</TABLE>
		</form>
	</body>
</HTML>
