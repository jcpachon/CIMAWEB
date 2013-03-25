<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="cc1" Namespace="WebControlCIMA.Buttons" Assembly="WebControlCIMA" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_citas_rapidas.aspx.vb" Inherits="cimaweb.form_citas_rapidas" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_citas_rapidas</title>
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
	
		function citar_cetir(id_cita,fecha_hora,duracion){
		
		if (Form1.nombre.value == ""){
			//alert(Form1.b_citar_forzado.name);//.disabled=true;
			//b_citar_hueco.disabled=true;
			
			alert("Paciente no definido.");
		}
		else
		{
		
			window.history.forward(1); 
			
			document.getElementById("b_citar_hueco" + id_cita).disabled=true;
		
			formulario_citar.retorno_pers_key.value=document.Form1.pers_key_paciente.value;
			formulario_citar.id_cita.value=id_cita;
			
			//formulario_citar.fecha_cita.value=fecha;
			formulario_citar.btimetabcode.value = '<% =Me.DropDownList5.SelectedValue %>';
			formulario_citar.prestacion.value = '<% =Me.DropDownList4.SelectedValue %>';
			//formulario_citar.hora_inicial.value = hora_ini;
			formulario_citar.ok_cita.value="C";
			formulario_citar.garante.value=<% if len(trim(me.label15.text)) > 0 then response.write (me.label15.text) else response.write ("0") %>;
			formulario_citar.fecha_hora.value=fecha_hora;
			formulario_citar.duracion.value=duracion;
			formulario_citar.submit();
		};
		
		}
	
		</script>
		<script type="text/javascript">
		if (control=="1"){
			f_abre_modal("../formularios/form_busca_persona_citas_rapidas.aspx?Dropdownlist1=<% =Request("Dropdownlist1") %>&Dropdownlist5=<% =Request("Dropdownlist5") %>",600,900,"");
		}
		else if (control=="2"){
			location.href='form_citas_rapidas.aspx';
		}
		;
		</script>
		<script type="text/javascript">
		
		function citar(fecha,hora_ini,hora_fin,btimetabcode,contador_f){
			
			if (Form1.nombre.value != ""){
			for (a=1;a<=contador_f;a++){
			document.getElementById("b_citar_forzado" + a).disabled=true;
			}
			document.envio_cita.fecha_cita.value=fecha;
			document.envio_cita.btimetabcode.value = btimetabcode;
			document.envio_cita.hora_final.value = hora_fin;
			document.envio_cita.hora_inicial.value = hora_ini;
			document.envio_cita.ok_cita.value="S";
			document.envio_cita.retorno_pers_key.value=document.Form1.pers_key_paciente.value;
			document.envio_cita.garante.value=<% if len(trim(me.label15.text)) > 0 then response.write (me.label15.text) else response.write ("0") %>;
		
			document.envio_cita.submit();}
			else{
			alert("Paciente no definido.");
			};
		
		}
		
		</script>
		<form name="formulario_citar">
			<input value="S" type="hidden" name="envio_cita"> <input type="hidden" name="id_cita">
			<input type="hidden" name="retorno_pers_key"> <input type="hidden" name="fecha_cita">
			<input type="hidden" name="hora_inicial"> <input type="hidden" name="hora_final">
			<input value="N" type="hidden" name="ok_cita"> <input type="hidden" name="btimetabcode">
			<input type="hidden" name="garante"> <input 
value="<% =me.Dropdownlist5.SelectedValue.ToString %>" type=hidden name=agencode> <input 
value="<% =me.Dropdownlist2.SelectedValue.ToString %>" type=hidden name=doctor> <input 
value='<% IF me.Dropdownlist3.SelectedValue.ToString = "PRIVADO" THEN
RESPONSE.WRITE("0")
ELSE
RESPONSE.WRITE(me.Dropdownlist3.SelectedValue.ToString)
END IF
%>' 
type=hidden name=firm_key> <input 
value="<% =me.Dropdownlist6.SelectedValue.ToString %>" type=hidden 
name=covegrou_key> <input 
value="<% =me.Dropdownlist4.SelectedValue.ToString %>" type=hidden 
name=prestacion> <input value="<% =me.checkbox1.checked %>" 
type=hidden name=hoja_citacion> <input type="hidden" name="fecha_hora"> <input type="hidden" name="duracion">
			<input type="hidden" name="prestacion"> <input value="<% =me.checkbox2.checked %>" type=hidden name=mcmutual_usuario>
			<input value="<% =me.checkbox3.checked %>" type=hidden 
name=codigo_web>
		</form>
		<form name="envio_cita">
			<input type="hidden" name="fecha_cita"> <input type="hidden" name="hora_inicial">
			<input type="hidden" name="hora_final"> <input value="N" type="hidden" name="ok_cita">
			<input type="hidden" name="btimetabcode"> <input type="hidden" name="retorno_pers_key">
			<input type="hidden" name="garante"> <input value="<% =me.Dropdownlist5.SelectedValue.ToString %>" type=hidden 
name=agencode> <input 
value="<% =me.Dropdownlist2.SelectedValue.ToString %>" type=hidden name=doctor> <input 
value='<% IF me.Dropdownlist3.SelectedValue.ToString = "PRIVADO" THEN
RESPONSE.WRITE("0")
ELSE
RESPONSE.WRITE(me.Dropdownlist3.SelectedValue.ToString)
END IF
%>' 
type=hidden name=firm_key> <input 
value="<% =me.Dropdownlist6.SelectedValue.ToString %>" type=hidden 
name=covegrou_key> <input 
value="<% =me.Dropdownlist4.SelectedValue.ToString %>" type=hidden 
name=prestacion><input value="<% =me.checkbox1.checked %>" 
type=hidden name=hoja_citacion> <input 
value="<% =me.checkbox2.checked %>" type=hidden name=mcmutual_usuario> <input value="<% =me.checkbox3.checked %>" type=hidden 
name=codigo_web><input type=hidden value="<% =me.textbox4.text %>" name=nhc_marques><input type=hidden value="<% =me.DropDownList11.SelectedValue %>" name=origen_marques>
		</form>
		<form id="Form1" method="post" runat="server">
			<input value="S" type="hidden" name="ok_control">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; TOP: 11px; LEFT: 11px" id="Table1"
				border="0" cellSpacing="0" cellPadding="0" width="100%" height="100%">
				<TR>
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22" colSpan="3">Estación 
						de Citas</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3">
						<TABLE id="Table4" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR>
								<TD><asp:label id="Label14" runat="server" Font-Bold="True" CssClass="letra_pequena">Paciente: </asp:label><INPUT 
            style="WIDTH: 500px" value='<% = Request("nombre") %>' readOnly name=nombre><input 
            value='<% = Request("pers_key_paciente") %>' type=hidden 
            name=pers_key_paciente></TD>
								<TD align="right"><asp:button id="Button2" runat="server" Text="Paciente" Width="150px"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3">
						<HR SIZE="1" width="100%">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD height="11" vAlign="middle" colSpan="3"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Servicio: </asp:label>&nbsp;<asp:dropdownlist id=DropDownList1 runat="server" CssClass="letra_pequena" Width="150px" DataValueField="csta_key" DataTextField="cstadesclong" DataMember="csta" DataSource="<%# Ds_csta1 %>" AutoPostBack="True"></asp:dropdownlist>&nbsp;
						<asp:label id="Label6" runat="server" Font-Bold="True" CssClass="letra_pequena">Agenda: </asp:label>&nbsp;
						<asp:dropdownlist id=Dropdownlist5 runat="server" CssClass="letra_pequena" Width="200px" DataValueField="agencode" DataTextField="agenname" DataMember="agen" DataSource="<%# Ds_agen_tabla1 %>" AutoPostBack="True">
						</asp:dropdownlist>&nbsp;&nbsp;<asp:label id="Label2" runat="server" CssClass="letra_pequena">Doctor: </asp:label>&nbsp;<asp:dropdownlist id=Dropdownlist2 runat="server" CssClass="letra_pequena" Width="225px" DataValueField="pers_key" DataTextField="persfullname" DataMember="pers" DataSource="<%# Ds_pers1 %>" AutoPostBack="True">
						</asp:dropdownlist>&nbsp;</TD>
				</TR>
				<TR>
					<TD class="letra_pequena" height="22" vAlign="middle" colSpan="3">&nbsp;
						<asp:panel id="Panel4" runat="server" Visible="False" Height="22px">
							<asp:Label id="Label10" runat="server" Width="104px">Horarios de Visita:</asp:Label>
							<asp:label id="Label11" runat="server" CssClass="letra_pequena" Width="560px" Visible="False"></asp:label>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD class="letra_pequena" height="22" vAlign="middle" colSpan="3">&nbsp;
						<asp:panel id="Panel6" runat="server" Visible="False" Height="22px">
<asp:Label id="Label22" runat="server" CssClass="letra_pequena">Bloques Horarios:</asp:Label>&nbsp; 
<asp:DropDownList id=DropDownList10 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataSource="<%# Ds_btimetab2 %>" DataMember="btimetab" DataTextField="btimetabdesc" DataValueField="btimetabcode">
							</asp:DropDownList></asp:panel></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:label id="Label3" runat="server" Font-Bold="True" CssClass="letra_pequena">Mutua: </asp:label>&nbsp;
						<asp:dropdownlist id=Dropdownlist3 runat="server" CssClass="letra_pequena" Width="200px" DataValueField="firm_key" DataTextField="firmname" DataMember="firm" DataSource="<%# Ds_firm_garantes1 %>" AutoPostBack="True">
						</asp:dropdownlist>&nbsp;
						<asp:label id="Label12" runat="server" CssClass="letra_pequena" Visible="False">Garante: </asp:label><asp:label id="Label13" runat="server" CssClass="letra_pequena" Width="200px" Visible="False"></asp:label>&nbsp;
						<asp:label id="Label7" runat="server" CssClass="letra_pequena" Visible="False">Agr. de Cob.: </asp:label>&nbsp;
						<asp:dropdownlist id=Dropdownlist6 runat="server" CssClass="letra_pequena" Width="175px" DataValueField="covegrou_key" DataTextField="covegroudesclong" DataMember="covegrou" DataSource="<%# Ds_covegrou1 %>" AutoPostBack="True" Visible="False">
						</asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:label id="Label15" runat="server" CssClass="letra_pequena" Visible="False"></asp:label></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:panel id="Panel1" runat="server" Width="100%" Visible="False">
							<asp:TextBox id="TextBox1" runat="server" CssClass="letra" Width="100%" ReadOnly="True" Rows="3"
								TextMode="MultiLine"></asp:TextBox>
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
					<TD height="11" colSpan="3"><asp:label id="Label4" runat="server" Font-Bold="True" CssClass="letra_pequena">Prestación: </asp:label><asp:dropdownlist id=Dropdownlist4 runat="server" CssClass="letra_pequena" Width="350px" DataValueField="Tiempo" DataTextField="Descripción" DataMember="prestaciones" DataSource="<%# Ds_prestaciones1 %>" AutoPostBack="True"></asp:dropdownlist>&nbsp;
						<asp:label id="Label16" runat="server" CssClass="letra_muy_pequena_rojo_negrita" Width="175px"
							Visible="False">REQUIERE AUTORIZACIÓN</asp:label></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
				</TR>
				<!-- JGM 04/02/11 Afegim el NHC de Institut Marqués pel LABORATORI -->
				<asp:Panel id="Panel7" runat="server" Visible="false">
					<TR>
						<TD height="11" colSpan="3">
							<asp:Label id="Label23" runat="server" CssClass="letra_pequena" Font-Bold="True">NHC I. Marqués:</asp:Label>&nbsp;
							<asp:TextBox id="TextBox4" runat="server" CssClass="letra_pequena_centrada"></asp:TextBox>&nbsp;&nbsp;
							<asp:Label id="Label24" runat="server" CssClass="letra_pequena" Font-Bold="True">Origen:</asp:Label>
							<asp:DropDownList id="DropDownList11" runat="server" CssClass="letra_pequena">
								<asp:ListItem Value="0" Selected="True">&nbsp;</asp:ListItem>
								<asp:ListItem Value="TIPO A">TIPO A</asp:ListItem>
								<asp:ListItem Value="TIPO B">TIPO B</asp:ListItem>
								<asp:ListItem Value="CITOLOGIA GINE">CITOLOGIA GINE</asp:ListItem>
								<asp:ListItem Value="CITOLOGIA REPRO">CITOLOGIA REPRO</asp:ListItem>
							</asp:DropDownList></TD>
					</TR>
					<TR>
						<TD colSpan="3"></TD>
					</TR>
				</asp:Panel>
				<TR>
					<TD height="11" colSpan="3">
						<%
									
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
							<TBODY>
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
								<TR style="CURSOR: hand">
									<!-- JGM asteriscar per veure en mode DISSENY -->
								<TD 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
          > 
          <!-- JGM --><% 
						select case objRow_2.Item(0)
							case 1
								response.write("<IMG alt="""" src=""../imagenes/word.gif"">")
							case 2
								response.write("<IMG alt="""" src=""../imagenes/excel.gif"">")
							case 3
								response.write("<IMG alt="""" src=""../imagenes/acrobat.gif"">")
						end select
						%>
					</TD>
					<!-- JGM asteriscar per veure en mode DISSENY -->
								<TD class=letra_pequena_negrita 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
          ><% =objRow_2.Item(3) %></TD>
								<TD class=letra_pequena 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
          ><% =objRow_2.Item(1) %></TD>
								<TD class=letra_pequena 
          onclick="javascript:window.open('<% =objRow_2.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');" 
          ><% =objRow_2.Item(2) %></TD> 
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
			</TD></TR>
			<TR>
				<TD height="11" colSpan="3">
					<HR SIZE="1" width="100%">
				</TD>
			</TR>
			<TR>
				<TD class="fondo_pie" height="11" colSpan="3">Selección de Cita</TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD style="HEIGHT: 15px" class="letra" height="15" colSpan="3"><asp:button id="Button4" runat="server" Text="Asociar a Episodio PADRE" Width="150px"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:label id="Label19" runat="server" CssClass="letra_negrita" Width="150px"></asp:label><asp:label id="Label17" runat="server" CssClass="letra_negrita" Width="150px"></asp:label><asp:label id="Label18" runat="server" CssClass="letra_pequena_negrita" Width="150px" Visible="false"></asp:label></TD>
			</TR>
			<TR>
				<TD style="HEIGHT: 15px" class="letra" height="15" colSpan="3"></TD>
			</TR>
			<TR>
				<TD class="letra" height="15" colSpan="3"><asp:panel id="Panel5" runat="server" Visible="False">
						<asp:DataGrid id=DataGrid2 runat="server" Width="100%" DataSource="<%# Ds_episodios_multicitas1 %>" DataMember="SP_CIMACEX_EPISODIOS_MULTICITAS" Visible="False" BorderColor="#999999" Font-Names="Verdana" Font-Size="7pt" ForeColor="Black" BackColor="White" BorderWidth="1px" BorderStyle="Solid" CellPadding="3" GridLines="Vertical" PageSize="15" AutoGenerateColumns="False">
							<FooterStyle Width="60%" BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="6pt" Font-Names="Verdana" Font-Bold="True" ForeColor="Black" CssClass="letra_pequena"
								BackColor="White"></ItemStyle>
							<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:ButtonColumn Text="&gt;&gt;&gt;" CommandName="Select"></asp:ButtonColumn>
								<asp:BoundColumn Visible="False" DataField="epis_key" SortExpression="epis_key" HeaderText="epis_key"></asp:BoundColumn>
								<asp:BoundColumn DataField="episcode" SortExpression="episcode" HeaderText="EPISODIO"></asp:BoundColumn>
								<asp:BoundColumn DataField="tactdesc" SortExpression="tactdesc" HeaderText="TIPO ACTIVIDAD">
									<HeaderStyle Width="150px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="cstadesclong" SortExpression="cstadesclong" HeaderText="SERVICIO">
									<HeaderStyle Width="175px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="hprodesclong" SortExpression="hprodesclong" HeaderText="PRESTACI&#211;N">
									<HeaderStyle Width="150px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="episdatecrea" SortExpression="episdatecrea" HeaderText="FECHA">
									<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="episopen" SortExpression="episopen" HeaderText="ABIERTO">
									<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
					</asp:panel></TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD class="letra" height="11" colSpan="3"><asp:radiobutton id="RadioButton1" runat="server" CssClass="letra" Text="Búsqueda de huecos" AutoPostBack="True"
						Checked="True" GroupName="grupo"></asp:radiobutton>&nbsp;<asp:radiobutton id="RadioButton2" runat="server" CssClass="letra" Text="Forzar Cita" AutoPostBack="True"
						GroupName="grupo"></asp:radiobutton>&nbsp;&nbsp;&nbsp;
					<asp:label id="Label20" runat="server">Alta MC-Mutual: </asp:label><asp:checkbox id="Checkbox2" runat="server"></asp:checkbox>&nbsp;&nbsp; 
					&nbsp; Hoja de Citación:&nbsp;<asp:checkbox id="CheckBox1" runat="server"></asp:checkbox>&nbsp;&nbsp;
					<asp:label id="Label21" runat="server">Generar código WEB: </asp:label><asp:checkbox id="Checkbox3" runat="server"></asp:checkbox></TD>
			</TR>
			<TR>
				<TD class="letra" height="11" colSpan="3"></TD>
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
									<TD>&nbsp;&nbsp;
										<asp:textbox id="fecha_ini" runat="server" CssClass="letra_pequena_centrada" Width="90px" Enabled="False">__/__/____</asp:textbox>
										<asp:imagebutton id="ImageButton1" runat="server" ImageUrl="../imagenes/lupa_pequena.gif"></asp:imagebutton>&nbsp;&nbsp;&nbsp;
										<asp:DropDownList id="DropDownList8" runat="server" CssClass="letra_pequena" Width="150px">
											<asp:ListItem Value="07:00" Selected="true">07:00</asp:ListItem>
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
										<cc1:ButtonEnviar id="Button1" runat="server" Width="150px" Text="Buscar"></cc1:ButtonEnviar></TD>
								</TR>
								<TR>
									<TD width="75"></TD>
									<TD>
										<asp:calendar id="Calendar1" runat="server" Width="250px" Height="160px" Visible="False" BorderColor="White"
											Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" BackColor="White" BorderWidth="1px"
											NextPrevFormat="FullMonth" FirstDayOfWeek="Monday">
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
						</asp:panel><asp:panel id="Panel3" runat="server" Visible="false">
							<TR>
								<TD class="letra" width="75">Fecha:</TD>
								<TD class="letra">
									<asp:textbox id="Textbox2" runat="server" CssClass="letra_pequena_centrada" Width="90px" Enabled="False">__/__/____</asp:textbox>
									<asp:imagebutton id="Imagebutton2" runat="server" ImageUrl="../imagenes/lupa_pequena.gif"></asp:imagebutton>&nbsp; 
									Franjas Horarias:&nbsp;
									<asp:dropdownlist id=Dropdownlist9 runat="server" CssClass="letra" Width="150px" AutoPostBack="True" DataSource="<%# Ds_btimetab1 %>" DataMember="btimetab" DataTextField="btimetabdesc" DataValueField="btimetabcode">
									</asp:dropdownlist>&nbsp;&nbsp;
									<asp:Label id="Label5" runat="server" CssClass="letra">Hora Inicio: </asp:Label>&nbsp;
									<asp:dropdownlist id="Dropdownlist7" runat="server" Width="75px" AutoPostBack="True" BackColor="Yellow"></asp:dropdownlist>&nbsp;&nbsp;
									<asp:Label id="Label9" runat="server" CssClass="letra">Hora Fin: </asp:Label>&nbsp;
									<asp:textbox id="Textbox3" runat="server" CssClass="letra_centrada" Width="75px" ReadOnly="True"
										BackColor="Yellow"></asp:textbox></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD class="letra" width="75"></TD>
								<TD>
									<asp:calendar id="Calendar2" runat="server" Width="250px" Height="160px" Visible="False" BorderColor="White"
										Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" BackColor="White" BorderWidth="1px"
										NextPrevFormat="FullMonth" FirstDayOfWeek="Monday">
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
								<TD><%
									
									Dim str_menu as string
											
									Dim objCIMA as New CIMA_Clases.CIMA
									
									Dim objDS as New Data.DataSet
									
									Dim objRow as Data.DataRow
									
									Dim contador as integer
									
									
									
									contador = 0
									
									Session("cadena_conexion")="DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN"
									
									if len(trim(Me.DropDownList9.SelectedValue)) > 0 then
									
									'agenproc_key=split(Me.DropDownList2.SelectedValue,"/",,1)
									
									str_menu = "[dbo].[SP_CIMACEX_BLOQUEOS] '" & me.textbox2.text & "','" & me.dropdownlist5.selectedvalue & "'," & Me.DropDownList9.SelectedValue
					
									objDS = objCIMA.f_consulta_CSaludR(str_menu, Session("cadena_conexion"))
									
									if objDS.Tables(0).Rows.Count > 0 then
									
									%>
									<TABLE id="Table44" border="0" cellSpacing="0" cellPadding="0" width="100%">
										<TR>
											<TD height="11" colSpan="6"></TD>
										</TR>
										<TR>
											<TD class="fecha_letra" colSpan="6">Bloqueos Horarios</TD>
										</TR>
										<TR>
											<TD height="11" colSpan="6"></TD>
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
								<TD></TD>
							</TR>
							<TR>
								<TD height="11" colSpan="3"></TD>
							</TR>
							<TR>
								<TD width="75" colSpan="3">
									<cc1:ButtonEnviar id="Button3" runat="server" Width="150px" Text="Citar"></cc1:ButtonEnviar></TD>
							</TR>
						</asp:panel></TBODY></TABLE>
				</TD>
			</TR>
			<TR>
				<TD colSpan="3">
					<%
	'Dim str_menu as string
							
	'Dim objCIMA as New CIMA_Clases.CIMA
	
	'Dim objDS as New Data.DataSet
	
	Dim objRow as Data.DataRow
	
	Dim ls_array() as string
	
	dim li_persona as integer
	
	Dim dr As Data.DataRow
	
	dim n as integer
	
	dim f as integer
	
	
	
	if Session("ok_busca_huecos") = "S" then
	
	Session("ok_busca_huecos") = "N"
	
	%>
					<TABLE border="0" cellSpacing="0" cellPadding="0" width="100%">
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
							<TD style="HEIGHT: 14px">
								<%IF me.Dropdownlist1.SelectedValue = "2" then%>
								Duración
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
				
	ls_array = split(Me.DropDownList4.SelectedValue.ToString,"/")
	
	if len(trim(me.Dropdownlist2.SelectedValue)) > 0 then
		li_persona = cint(me.Dropdownlist2.SelectedValue)
	else
		li_persona = 0
	end if
	
	IF me.Dropdownlist1.SelectedValue = "2" then
			
			'Private service As New CIMAServeiIntegracio.ServeiIntegracio

		'Dim n As Integer
			
			
			
		if Me.DataGrid1.Items.Count() > 0 then   
		
		For n = 0 To Me.DataGrid1.Items.Count() - 1    
	
		'for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
	
		%>
						<TR class="letra_pequena" height="11" align="center">
							<!-- JGM asteriscar per veure en mode DISSENY -->
								<TD><INPUT id="b_citar_hueco<% =cstr(n) %>" onclick="javascript:b_citar_hueco<% =cstr(n) %>.disabled=true;citar_cetir('<% =cstr(n) %>','<% =Me.DataGrid1.Items(n).Cells(2).Text() %>',<% =Me.DataGrid1.Items(n).Cells(3).Text() %>);"value=CITAR type=button></TD>
								<!-- JGM -->
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
		
		%>
					</TABLE>
					<%
		
		end if
	
	ELSE
	
		if me.Dropdownlist2.SelectedValue = "RXAAAAA" then
	
        Me.Ds_busca_huecos1.Clear()

        For n = 1 To UBound(Session("HR"))

            dr = Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.NewRow()

			'dr("hora_ini") = Session("HR")(n).ID_Centre
            dr("hora_ini") = Session("HR")(n).ID_Centre
            dr("hora_fin") = Session("HR")(n).ID_Centre
            dr("btimetabcode") = Session("HR").ID_Cita
            dr("diardate") = Session("HR")(n).ID_Centre
            dr("ok") = Session("HR")(n).ID_Centre
            dr("diardate1") = Session("HR")(n).ID_Centre
            dr("dia_semana") = Session("HR")(n).ID_Centre
            dr("agenname") = Session("HR")(n).ID_Centre
            dr("agencode") = Me.DropDownList5.SelectedValue.ToString
            dr("pers_key") = li_persona
            dr("firm_key") = Session("HR")(n).ID_Centre
            dr("covegrou_key") = Session("HR")(n).ID_Centre
            dr("hpro_key") = ls_array(0)
            dr("duracion") = Session("HR")(n).ID_Centre

            Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows.Add(dr)

            'dt.Rows.Add(dr)

        Next
	
		else
			
			Me.SqlDataAdapter8.SelectCommand.Parameters(1).Value = Me.DropDownList5.SelectedValue.ToString
			Me.SqlDataAdapter8.SelectCommand.Parameters(2).Value = day(Me.Calendar1.SelectedDate)
			Me.SqlDataAdapter8.SelectCommand.Parameters(3).Value = month(Me.Calendar1.SelectedDate)
			Me.SqlDataAdapter8.SelectCommand.Parameters(4).Value = year(Me.Calendar1.SelectedDate)
			Me.SqlDataAdapter8.SelectCommand.Parameters(5).Value = ls_array(1)
			Me.SqlDataAdapter8.SelectCommand.Parameters(6).Value = li_persona
			Me.SqlDataAdapter8.SelectCommand.Parameters(7).Value = cint(Me.Label15.Text)
			Me.SqlDataAdapter8.SelectCommand.Parameters(8).Value = me.Dropdownlist6.SelectedValue
			Me.SqlDataAdapter8.SelectCommand.Parameters(9).Value = ls_array(0)'Me.DataGrid1.Items(i).Cells(9).Text
			Me.SqlDataAdapter8.SelectCommand.Parameters(10).Value = Me.DropDownList8.SelectedValue.ToString'Me.DataGrid1.Items(i).Cells(9).Text
			
			'JGM - Afegim el nou paràmetre
			if Me.DropDownList10.SelectedValue = "--TODOS--"
				Me.SqlDataAdapter8.SelectCommand.Parameters(11).Value = -1
			else
				Me.SqlDataAdapter8.SelectCommand.Parameters(11).Value = Me.DropDownList10.SelectedValue	
			end if

			Me.SqlConnection1.Open()
			Me.SqlDataAdapter8.Fill(Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS)
			Me.SqlConnection1.Close()
	    
		end if
		
		f=0
		
		for each objRow in Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows
		
		f=f+1
		
	%>
					<script type="text/javascript">
	
	function f_desactivar_citas(numero){
	
		for (i=1;i<=numero;i+=1){
		
			//alert("b_citar_forzado" + i + ".disabled=true;");
			document.getElementById("b_citar_forzado" + i ).disabled=true;
		
		}
	
	}
	
					</script>
			<TR class="letra_pequena" height="11" align="center">
				<!-- JGM asteriscar per veure en mode DISSENY -->
					<TD><INPUT style="WIDTH: 50px" id=b_citar_forzado<% =Cstr(f) %> class=letra_pequena_negrita onclick="javascript:f_desactivar_citas(<% =Me.Ds_busca_huecos1.SP_CIMACEX_BUSCA_HUECOS.Rows.Count %>);citar('<% =objRow.Item(3) %>','<% =objRow.Item(0) %>','<% =objRow.Item(1) %>',<% =objRow.Item(2) %>,<% =f %>);"value=CITAR type=button></TD>
					<!-- JGM -->
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
	
	%>
			</TBODY></TABLE>
			<%
	
		end if
	
	END IF
	
	%>
			</TD></TR><TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD class="letra" height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"></TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" runat="server" Width="350px" Visible="False" Height="50px"></CR:CRYSTALREPORTVIEWER><asp:datagrid id="DataGrid1" runat="server" Visible="False"></asp:datagrid></TD>
			</TR>
			<TR>
				<TD colSpan="3">
					<TABLE id="Table2" border="0" cellSpacing="0" cellPadding="0" width="100%" height="100%">
						<TR>
							<TD height="*" vAlign="top"></TD>
						</TR>
					</TABLE>
				</TD>
			</TR>
			<TR>
				<TD height="11" colSpan="3" width="125"></TD>
			</TR>
			</TBODY></TABLE></form>
	</body>
</HTML>
