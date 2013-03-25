<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_agendas.aspx.vb" Inherits="cimaweb.form_agendas"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>form_agendas</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
</HEAD>
	<BODY>
		<SCRIPT type="text/javascript">
		var cadena;
		cadena = "";
		function enviar_detalle(id_persona, episcode,mutua,nacimiento,cove,estado,realizada,grupo){
			
			envio.pers_key.value = id_persona;
			envio.episcode.value = episcode;
			envio.mutua.value = mutua;
			envio.nacimiento.value = nacimiento;
			envio.cove.value = cove;
			//alert(estado);
			envio.estado.value = estado;
			envio.realizada.value = realizada;
			//JGM - MODIFICACIÓ EGARSAT 26/01/2011
			mutua = mutua.replace(/ /g, '');
			
			if (("<% =Session("grupo") %>" == "U" || "<% =Session("grupo") %>" == "G" || "<% =Session("grupo") %>" == "W" || "<% =Session("grupo") %>" == "I")  && grupo == "<% =Session("grupo") %>"){
				envio.action = "../formularios/form_pers_externos.aspx?inactiva=<% =Me.CheckBox1.Checked %>";
				envio.submit();
			}
			else if (("<% =Session("grupo") %>" == "G") && mutua == "EGARSAT"){
				envio.action = "../formularios/form_pers_externos.aspx?inactiva=<% =Me.CheckBox1.Checked %>";
				envio.submit();
			}
			else if ("<% =Session("grupo") %>" == "L"){
				envio.action = "../formularios/form_pers_externos.aspx?inactiva=<% =Me.CheckBox1.Checked %>";
				envio.submit();
			}
			else if (("<% =Session("grupo") %>" == "U" || "<% =Session("grupo") %>" == "G" || "<% =Session("grupo") %>" == "W" || "<% =Session("grupo") %>" == "I") && grupo != "<% =Session("grupo") %>"){
				//envio.action = "#";
			}
			else{
				envio.submit();
			};
			
		}
		function cambiar_estado(id_persona, episcode,mutua,nacimiento,cove,estado,nuevo_estado,epis_key,lopd){
			
			<%
			
			If Me.Dropdownlist2.SelectedValue <> "UR" Then
			
			%>
			
			if ('False' == '<% =Me.CheckBox1.Checked %>'){
			
			<% 
			'if cdate(Session("VisibleFecha")) = today() then
			%>
			
				cambio.nuevo_estado.value = nuevo_estado;
				cambio.servicio_origen.value = "<% =Request("servicio_origen") %>";
				cambio.agenda_origen.value = "<% =Request("agenda_origen") %>";
				cambio.dia_en_seleccion.value = "<% =Session("VisibleFecha") %>";
				cambio.DropDownList1.value = "<% =Request("DropDownList1") %>";
				cambio.DropDownList2.value = "<% =Request("DropDownList2") %>";
				cambio.dia_en_seleccion.value = "<% =Session("VisibleFecha") %>";
				cambio.episcode.value = episcode;
				cambio.sort_by.value="<% =me.sort_by.selectedvalue %>";
				cambio.epis_key.value = epis_key;
				
				//JGM - MODIFICACIÓ LOPD
				lopd = lopd.replace(/ /g, '');
				if (lopd == "N" && nuevo_estado == "D") {
							
				if (confirm("Paciente pendiente de firma documento LOPD. Recoger firma. ¿Firma el paciente?")==1)
					{cambio.lopd.value = "S"};
				};
	
				cambio.submit();
				//JGM
				//Modificació 20/12/2010 - Per la mútua MGC sortirà un prompt per introduir la pólissa

				mutua = mutua.replace(/ /g, ''); 
				//JGM Modificació 01/03/2010 - Es fa extensiu a totes les pólisses
				//if (mutua == "MGC" && nuevo_estado == "D") {
				if ((mutua.substr(0,1) != "Z" || (mutua.substr(0,1) == "Z" && isNaN(mutua.substr(1,6)) == true )) && nuevo_estado == "D") {
					window.showModalDialog("../formularios/form_num_poliza.htm", window, "dialogWidth:90px;dialogHeight:100px; edge: Raised; center: Yes; help: No; resizable: No; status: No");
				};
				//FI Modificació JGM
				
			<%
			'else
			%>
			
				//cambio.servicio_origen.value = "<% =Request("DropDownList2") %>";
				//cambio.agenda_origen.value = "<% =Request("DropDownList1") %>";
				//cambio.dia_en_seleccion.value = "<% =Session("VisibleFecha") %>";
				//cambio.DropDownList1.value = "<% =Request("DropDownList1") %>";
				//cambio.DropDownList2.value = "<% =Request("DropDownList2") %>";
				//cambio.dia_en_seleccion.value = "<% =Session("VisibleFecha") %>";
				//cambio.episcode.value = episcode;
				//alert("Debe seleccionar el día en curso para admitir una cita.");
				//cambio.submit();
			
			<%
			'end if
			 %>
			 
			};
			
			<%
			
			end if
			
			%>
			
		}
		function box(argumento){
			if (document.getElementById(argumento).checked==1){
				
				cadena = cadena + "/" + argumento
				
				//alert(cadena);
			}
			else{
			
				var array = cadena.split("/")
				
				cadena = "";
				
				//alert(array.length);
				
				for (i=0;i<=array.length - 1;i++){
					
					if (array[i]!=argumento){
					
						cadena = cadena + "/" + array[i];
					
					}
					
				}
			
				//alert(cadena);
			
			}
			
			document.forms("argumento").ristra.value=cadena;
			
		}
		</SCRIPT>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		if (control=="1"){
			f_abre("../formularios/form_solicitar_cita.aspx?dia_seleccionado_corregido=<% =Session("dia_seleccionado_corregido") %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&agencode=<% =Session("agencode") %>",600,900,"");
		}
		else if (control=="2"){
			f_abre_modal("../formularios/form_anular_cita.aspx?servicio_origen=<% =Trim(Request("servicio_origen")) %>&dia_seleccionado=<% =Session("dia_seleccionado") %>&agencode=<% =Session("agencode") %>&ristra=<% =Session("ristra") %>&DropDownList2=<% = me.DropDownList2.selectedvalue %>",110,185,"");
		};
		</script>
		<form id="cambio" method="post">
			<input type="hidden" name="nuevo_estado"> <input type="hidden" name="servicio_origen">
			<input type="hidden" name="agenda_origen"> <input type="hidden" name="dia_en_seleccion">
			<input type="hidden" name="episcode"> <input type="hidden" name="DropDownList2">
			<input type="hidden" name="DropDownList1">
			<input type="hidden" name="sort_by">
			<input type="hidden" name="epis_key">
			<input type="hidden" name="lopd">
		</form>
		<form id="argumento" method="post">
			<input type="hidden" name="ristra"> <input type=hidden 
value='<% 
If Len(Trim(Request("servicio_origen"))) > 0 Then 
Response.Write(Request("servicio_origen")) 
Else 
Response.Write(Request("DropDownList2")) 
End if  %>' name=DropDownList2>
			<!--input type="hidden" name="ristra"--> <input type=hidden 
value='<%  
If Len(Trim(Request("agenda_origen"))) > 0 Then 
Response.Write(Request("agenda_origen")) 
Else 
Response.Write(Request("DropDownList1")) 
End if 
%>' name=DropDownList1>
			<input type=hidden value='<% =Session("VisibleFecha") %>' name=VisibleDate> <input type=hidden 
value='<% =Session("dia_seleccionado") %>' name=dia_seleccionado> <input type=hidden value='<% =me.dropdownlist2.selectedvalue %>' 
name=servicio_seleccionado><input type=hidden value='<% =Session("agencode") %>' 
name=agenda_seleccionada> <input type="hidden" value="S" name="flag">
		</form>
		
		<form id="envio" action="../formularios/form_pers.aspx?inactiva=<% =Me.CheckBox1.Checked %>" method="post">
		
			<input type="hidden" name="pers_key"> <input type="hidden" name="episcode"><input type=hidden 
value='<% =Request("DropDownList2") %>' name=DropDownList2> <input type=hidden 
value='<% =Request("DropDownList1") %>' name=DropDownList1> <input type=hidden value='<% =Session("VisibleFecha") %>' name=VisibleDate>
			<input type=hidden 
value='<% =Session("dia_seleccionado") %>' name=dia_seleccionado> <input type=hidden value='<% =me.dropdownlist2.selectedvalue %>' 
name=servicio_seleccionado><input type=hidden value='<% =Session("agencode") %>' 
name=agenda_seleccionada> <input type="hidden" name="mutua"><input type="hidden" name="nacimiento"><input type="hidden" name="cove"><input type="hidden" name="estado"><input type="hidden" name="realizada">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="300" border="0">
  <TBODY>
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Gestión de Agendas</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD vAlign="top" width="*" colSpan="3" height="11">
						<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="175" height="11"><asp:dropdownlist id="Dropdownlist2" runat="server" AutoPostBack="True" CssClass="letra_pequena" Width="150px">
										<asp:ListItem Value="CE" Selected="True">CONSULTAS EXTERNAS</asp:ListItem>
										<asp:ListItem Value="RX">RADIOLOGIA</asp:ListItem>
										<asp:ListItem Value="LA">LABORATORIO</asp:ListItem>
										<asp:ListItem Value="UR">URGENCIAS</asp:ListItem>
										<asp:ListItem Value="FA">FARMACIA</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD colSpan="4" height="11"><asp:dropdownlist id=DropDownList1 runat="server" DataValueField="agencode" DataTextField="agenname" DataMember="cima_usuarios_agen" DataSource="<%# Ds_agendas1 %>" AutoPostBack="True" CssClass="letra_pequena">
									</asp:dropdownlist>&nbsp;&nbsp; 
<asp:CheckBox id=CheckBox1 runat="server" CssClass="letra_pequena" Text="Mostrar Inactivas" AutoPostBack="True"></asp:CheckBox></TD>
								<TD align="right" width="10" height="11"><asp:button id="Button1" runat="server" Width="125px" CausesValidation="False" Text="Solicitar Cita"
										Visible="False"></asp:button></TD>
								<TD align="right" width="11" height="11"></TD>
								<% if Session("grupo") <> "G" and Session("grupo") <> "L" %>
								<TD align="right" width="10" height="11">
								<% 'response.write ("W: " & Session("agencode"))
								'if trim(Session("agencode")) = "ECG" or trim(Session("agencode")) = "MM" or trim(Session("agencode")) = "RXC" or trim(Session("agencode")) = "RM" or trim(Session("agencode")) = "TC" or trim(Session("agencode")) = "TLM" or trim(Session("agencode")) = "-TODAS RAD-" or trim(Session("agencode")) = "DN" or trim(Session("agencode")) = "LABO" then %> 
								<INPUT style="WIDTH: 125px" onclick="javascript:if ('False' == '<% =Me.CheckBox1.Checked %>'){if (confirm('Va a ANULAR las citas seleccionadas ¿Está usted seguro?') == 1){document.forms('argumento').submit();};};"
										type="button" size="20" value="Anular Cita">
								<% 
								'end if
								%>
										</TD>
								<% end if %>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD vAlign="top" width="150">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR vAlign="top">
								<TD width="150"><asp:calendar id="Calendar1" runat="server" Width="152px" DayNameFormat="FirstLetter" BackColor="White"
										ForeColor="Black" Height="165px" Font-Size="6pt" Font-Names="Verdana" BorderColor="#999999" CellPadding="4"
										ShowGridLines="True" FirstDayOfWeek="Monday">
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
							<TR>
								<TD width="150" height="6"></TD>
							</TR>
							<TR>
								<TD><asp:calendar id="Calendar2" runat="server" Width="152px" DayNameFormat="FirstLetter" BackColor="White"
										ForeColor="Black" Height="165px" Font-Size="6pt" Font-Names="Verdana" BorderColor="#999999"
										CellPadding="4" ShowGridLines="True" FirstDayOfWeek="Monday">
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
						<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
						<!--
							<TR>
								<TD colSpan="9" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_pequena" width="20" bgColor="#008000" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Libre</TD>
								<TD class="letra_pequena" width="20" bgColor="#ffff00" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Bloqu.</TD>
								<TD class="letra_pequena" width="20" bgColor="#ff0000" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Cerrado</TD>
							</TR> -->
							<TR>
								<TD colSpan="6" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_pequena" width="20" bgColor="#008000" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Libre</TD>
								<TD class="letra_pequena" width="20" bgColor="#ff0000" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Cerrado</TD>
							</TR>
							<TR>
								<TD colSpan="6" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_pequena" width="20" bgColor="#ffff00" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Bloqueado</TD>
								<TD class="letra_pequena" width="20" bgColor="#ffd700" height="11"></TD>
								<TD class="letra_pequena" width="11" height="11"></TD>
								<TD class="letra_pequena" width="60" height="11">Vacaciones</TD>
							</TR>

						</TABLE>
					</TD>
					<TD style="HEIGHT: 215px" vAlign="top" width="11"></TD>
					<TD style="HEIGHT: 224px" vAlign="top" align="right" width="100%">
						<TABLE id="Table3" cellSpacing="0" cellPadding="1" width="95%" border="0">
        <TBODY>
							<TR height="11">
								<TD class="letra_pequena_negrita" colSpan="15"><asp:label id="Label2" runat="server" CssClass="fondo_formulario_2" Width="100%"></asp:label></TD>
							</TR>
							<TR>
								<TD class="letra_pequena_negrita" colSpan="15">
            <TABLE id=Table6 cellSpacing=0 cellPadding=0 width="100%" 
              border=0>
              <TR>
                <TD class="letra_pequena_negrita">Click en
									<asp:image id="Image51" runat="server" ImageUrl="../imagenes/pendiente.gif"></asp:image>para 
									ADMITIR. Click en
									<asp:image id="Image56" runat="server" ImageUrl="../imagenes/admitida.gif"></asp:image>para 
            DESADMITIR.</TD>
                <TD class="letra_pequena_negrita" align=right>CH:&nbsp;&nbsp;</TD><td style="BACKGROUND-COLOR: #FFA500" width=11></td><TD class="letra_pequena_negrita" align=right>HO:&nbsp;&nbsp;</TD><td style="BACKGROUND-COLOR: #66ff99" width=11></td><TD class="letra_pequena_negrita" align=right>UR:&nbsp;&nbsp;</td><td style="BACKGROUND-COLOR: #ff0000" width=11></td><TD class="letra_pequena_negrita" align=right>PO:&nbsp;&nbsp;</td><td style="BACKGROUND-COLOR: #3399ff" width=11></td></TR></TD>
							</TR>
							<TR height="11">
								<TD class="letra_pequena_negrita" colSpan="15"></TD>
							</TR>
							<TR height="11">
								<TD class="letra_pequena_negrita" colSpan="15"><asp:image id="Image57" runat="server" ImageUrl="../imagenes/pendiente.gif"></asp:image>&nbsp;Pendiente&nbsp;&nbsp;<asp:image id="Image59" runat="server" ImageUrl="../imagenes/admitida.gif"></asp:image>&nbsp;Admitida&nbsp;&nbsp;<asp:image id="Image58" runat="server" ImageUrl="../imagenes/realizada.gif"></asp:image>&nbsp;Realizada&nbsp;&nbsp;<asp:image id="Image60" runat="server" ImageUrl="../imagenes/anulada.gif"></asp:image>&nbsp;Anulada&nbsp;&nbsp;<asp:image id="Image61" runat="server" ImageUrl="../imagenes/reprogramada.gif"></asp:image>&nbsp;Reprogramada&nbsp;
<asp:Label id=Label1 runat="server">Ordenar:</asp:Label>&nbsp;
<asp:DropDownList id=sort_by runat="server" Width="80px" CssClass="letra_pequena" AutoPostBack="True">
<asp:ListItem Value="H">Hora</asp:ListItem>
<asp:ListItem Value="P">Paciente</asp:ListItem>
<asp:ListItem Value="A">Hora Admisión</asp:ListItem>
</asp:DropDownList></TD><td colspan=2 align=right><IMG height="16" alt="" src="../imagenes/print.gif" onclick="javascript:printPage();"></td>
							</TR>
							<TR height="11">
								<TD class="letra_pequena_negrita" colSpan="15"></TD>
							</TR></TABLE>
							<TR>
								<TD class="menu_lateral_izquierdo" colSpan="15">Citas del día</TD>
							</TR>
							<%
							
							Dim str_menu as string
												
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
														
							Dim objRow as Data.DataRow
							
							Dim a as Integer
							
							Dim contador as integer
							
							Dim ls_array() as String
							
							contador = 0
							
							'if Session("dia_seleccionado") <> Nothing then
							'	ls_array = Split(Session("dia_seleccionado"), "/")
            				'	Session("dia_seleccionado") = ls_array(1) + "/" + ls_array(0) + "/" + ls_array(2)
							'end if
							
							
							str_menu = "dbo.SP_CIMACEX_CITAS_DIA_ORDER_BY '" & Session("dia_seleccionado") & "','" & Session("agencode") & "','00:00:00','23:59:00','" & Me.sort_by.SelectedValue & "'"
							
			
							'response.write (str_menu)
			
							objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
							
							for each objRow in objDS.Tables(0).Rows
								contador= contador + 1
							
							Me.Ds_cima_garantes1.Clear()
							Me.SqlConnection1.Open()
							Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = objRow.Item(0)
							Me.SqlDataAdapter2.Fill(Me.Ds_cima_garantes1.cima_garantes)
							Me.SqlConnection1.Close()
							
							'JGM 01/03/2011 - No es mostren les cites reprogramades per les agendes de DI.
							'and ((trim(objRow.Item(11)) <> "REPROGRAMADA" and Trim(Request("dropdownlist2")) = "RX") or Trim(Request("dropdownlist2")) <> "RX") then
							'if ((Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L") or (Session("grupo") = objRow.Item("grupo")) or (Session("grupo") = "G" and trim(objRow.Item(26)) = "EGARSAT") or (Session("grupo") = "L" and len(trim(objRow.Item("nhc_marques"))) > 0 ) _
							if ((Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L") or (Session("grupo") = objRow.Item("grupo")) or (Session("grupo") = "G" and trim(objRow.Item(26)) = "EGARSAT") or (Session("grupo") = "L" and trim(objRow.Item(26)) = "MARQUES" )) _
							and (trim(objRow.Item(11)) <> "REPROGRAMADA" ) then
							%>
							
							<TR 
							<%
							if objRow.Item("hospitalizado") = "S" then
							%>
							style="BACKGROUND-COLOR: #66ff99" 
							<%
							else if objRow.Item("urgencias") = "S" then
							%>
							style="BACKGROUND-COLOR: #ff0000"
							<%
							else if objRow.Item("episodio_chequeo") = "S" then
							%>
							style="BACKGROUND-COLOR: #FFA500"
							<%
							else if objRow.Item("episodio_preop") = "S" then
							%>
							style="BACKGROUND-COLOR: #3399ff"
							<%
							end if
							%>
							class="letra_onMouseOut" onmouseover="javascript:this.className='letra_onMouseOver';"
								onmouseout="javascript:this.className='letra_onMouseOut';" height="11" title="<% =objRow.Item("usuario") %>">
								<% if trim(objRow.Item(11)) = "ANULADA" then %>
								<TD width="55"></TD>
								<TD 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=11><asp:image id="Image1" runat="server" ImageUrl="../imagenes/anulada.gif"></asp:image><% '=" " & objRow.Item(11) %></TD>
								<% elseif trim(objRow.Item(11)) = "REPROGRAMADA" then %>
								<TD width="55"></TD>
								<TD onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=11><asp:image id="Image62" runat="server" ImageUrl="../imagenes/reprogramada.gif"></asp:image><% '=" " & objRow.Item(11) %></TD>

								<% elseif trim(objRow.Item(11)) = "REALIZADA" then %>
								
								<TD width="55"></TD>
								<TD 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N")  %>','<% =objRow.Item("grupo") %>');" 
          width=11><asp:image id="Image2" runat="server" ImageUrl="../imagenes/realizada.gif"></asp:image><% =left(objRow.Item(29),5) %><% '=" " & objRow.Item(11) %></TD>
								<% elseif trim(objRow.Item(11)) = "ADMITIDA" then %>
								<TD width="55"><% =left(objRow.Item(29),5) %></TD>
								<% if Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L" then %>
								<TD onclick="javascript:cambiar_estado(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','P',<% =objRow.Item("epis_key") %>,'<% =objRow.Item("lopd") %>');" width=11>
								<% else %>
								<TD width=11>
								<% end if %>
								<asp:image id="Image43" runat="server" ImageUrl="../imagenes/admitida.gif"></asp:image><% '=" " & objRow.Item(11) %></TD>
								<% else %>
								<TD width="55">
								<% if ((Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L") or (Session("grupo") = objRow.Item("grupo"))) and trim(objRow.Item("usuario")) <> "CETIR" then %>
								<input id="<% =objRow.Item(25) %>" onpropertychange=javascript:box(this.id); type=checkbox >
								<% end if %>
            </TD>
						
          <% if Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L" then %>
          <TD onclick="javascript:cambiar_estado(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','D',<% =objRow.Item("epis_key") %>,'<% =objRow.Item("lopd") %>');" width=11>
          <% else %>
          <TD width=11>
          <% end if %>
          <asp:image id="Image3" runat="server" ImageUrl="../imagenes/pendiente.gif"></asp:image><% '=" " & objRow.Item(11) %></TD>
								<% end if %>
								<td class=letra_muy_pequena>
								<% 
								if objRow.Item(31) = "Y" then
								
									response.write ("F")
								
								end if
								%>
								</td>
								<td class=letra_muy_pequena>
								<% 
								IF objRow.Item("ID_Prova_CETIR") = "0" THEN
									response.write ("")
								ELSE
									response.write (objRow.Item("ID_Prova_CETIR"))
								END IF
								 %>
								</td>
								<td onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" class=letra_muy_pequena width=150>
								<% =objRow.Item("btimetabdesc") %>
								</td>
								<% 
								'if (Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L") or (Session("grupo") = objRow.Item("grupo")) or (Session("grupo") = "G" and trim(objRow.Item(26)) = "EGARSAT") or (Session("grupo") = "L" and len(trim(objRow.Item("nhc_marques"))) > 0 ) ) then
								if (Session("grupo") <> "U" and Session("grupo") <> "G" and Session("grupo") <> "W" and Session("grupo") <> "I" and Session("grupo") <> "L") or (Session("grupo") = objRow.Item("grupo")) or (Session("grupo") = "G" and trim(objRow.Item(26)) = "EGARSAT") or (Session("grupo") = "L" and trim(objRow.Item(26)) = "MARQUES" ) then
								
								for a= 2 to 10 
								
								if a<7 or a>9 then
								
								if a=2 then
								
								%>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=50><% =objRow.Item(a) %></TD>
								<% 
								elseif a=10 then
								%>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=100><% =objRow.Item(a) %></TD>
								<%
								else if a=4 or a=5 then
								else if a=3 then
								%>
								<TD align=left class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=200><% =objRow.Item(3) %></TD>
								<%
								else
								%>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          width=50><% '=objRow.Item(a) %></TD>
								<% 
								
								end if
								
								end if
								
								next 
								%>
								<TD class="letra_muy_pequena"></TD>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          ><% =objRow.Item(26) %></TD>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          ><% '=objRow.Item(27) %></TD>
								<%
								if me.Ds_cima_garantes1.Tables(0).Rows.Count() > 0 then
								%>
								<TD class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          ><% =me.Ds_cima_garantes1.Tables(0).Rows(0).Item(3) %></TD>
								<%
								end if
								
								else
								
								%>
								
								<TD colspan = 7 width = 125 class=letra_muy_pequena 
          onclick="javascript:enviar_detalle(<% =objRow.Item(22) %>, '<% =objRow.Item(0) %>','<% =objRow.Item(26) %>','<% =objRow.Item(6) %>','<% =objRow.Item(27) %>','<% =objRow.Item(28) %>','<% if trim(objRow.Item(11)) = "REALIZADA" then response.write ("R") ELSE response.write ("N") %>','<% =objRow.Item("grupo") %>');" 
          ><% =objRow.Item("agenprocdesc") %></TD>
          
								<%
								
								end if
								
								%>
								
								<td class=letra_muy_pequena>
								<%
								=objRow.Item("agrup_cobertura")
								%>
								</td>
								
								<td class=letra_muy_pequena>
								<%
								if len(trim(objRow.Item("nota"))) > 0 then
								%>
								<img src="../imagenes/ojo.gif">
								<%
								end if
								%>
								</td>
								<td class=letra_muy_pequena>
								<%
								if len(trim(objRow.Item("nota_episodio"))) > 0 then
								%>
								<img src="../imagenes/nota_episodio.jpg">
								<%
								end if
								%>
								</td>
							</TR>
							<%
							
							end if
							
							next
							
							Me.Ds_cima_garantes1.Clear()
							
							'end if
							
							%>
													</TABLE>
					</TD>
					<TD style="HEIGHT: 224px"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR></TBODY>
			</TABLE>
		</form></TD></TR></TBODY></TABLE>
	</BODY>
</HTML>
