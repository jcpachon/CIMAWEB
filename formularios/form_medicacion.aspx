<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_medicacion.aspx.vb" Inherits="zeus.form_medicacion"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Medicación</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form name="seleccion" method="post">
			<input type="hidden" name="cadena_creciente">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0" height="100%">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Medicación
						<asp:TextBox id="memoria" runat="server" Visible="False"></asp:TextBox>
						<asp:TextBox id="contador" runat="server" Visible="False"></asp:TextBox></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD vAlign="middle" align="center" height="11">
						<TABLE id="Medicacion1" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<tr height="11" class="fondo_formulario">
								<td></td>
								<td>Medicación</td>
								<td>Fecha</td>
								<td>Duración</td>
								<td>Episodio</td>
								<td>Posología</td>
								<td>Observaciones</td>
							</tr>
							<tr height="11">
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
							</tr>
							<%
						
						Dim str_menu as string
							
						Dim objCIMA as New CIMA_Clases.CIMA
						
						Dim objDS as New Data.DataSet
						
						Dim objRow as Data.DataRow
						
						Dim contador as integer
						
						
							
						Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
						
						str_menu = "dbo.SP_CIMACEX_RECUPERA_MEDICACION_EPISODIO '" & me.textbox5.text & "'"
		
						objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
			
						for each objRow in objDS.Tables(0).Rows
						
						contador = contador + 1
						
						%>
							<tr height="11" class="letra_pequena">
								<td><INPUT id="cb<% =Cstr(contador) %>" type="checkbox" value='<% =objRow.Item(6) %>'></td>
								<td><% =objRow.Item(0) %></td>
								<td><% =objRow.Item(1) %></td>
								<td><% =objRow.Item(2) %></td>
								<td><% =objRow.Item(3) %></td>
								<td><% =objRow.Item(4) %></td>
								<td><% =objRow.Item(5) %></td>
							</tr>
							<%
						
						next
						
						me.contador.text = contador
						
						objRow = Nothing
						objDS = Nothing
						objCIMA = Nothing
						
						%>
							<tr height="11">
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
								<td></td>
							</tr>
						</TABLE>
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="99"></TD>
					<TD height="99"></TD>
					<TD height="99"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" style="WIDTH: 408px" vAlign="middle" colSpan="4" height="22"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario" style="WIDTH: 408px" vAlign="middle">Medicación:
									<asp:dropdownlist id=DropDownList1 runat="server" DataMember="SP_CIMACEX_MEDICACION" DataSource="<%# Ds_drugsele1 %>" DataTextField="drugseledesc" DataValueField="drugselecode_key" CssClass="letra_pequena" Width="300px" AutoPostBack="True">
									</asp:dropdownlist></TD>
								<TD class="cabecera_formulario" vAlign="middle" colSpan="3">&nbsp;Episodio:
									<asp:textbox id="TextBox5" runat="server" CssClass="letra_pequena_centrada" Width="125px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario" style="WIDTH: 395px" vAlign="middle" colSpan="4" height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario" style="WIDTH: 413px" vAlign="middle" colSpan="2" height="11">Fecha 
									Inicio:
									<asp:textbox id="TextBox1" runat="server" CssClass="letra_pequena_centrada" Width="100px"></asp:textbox></TD>
								<TD class="cabecera_formulario" vAlign="middle" colSpan="2" height="11">Duración:
									<asp:textbox id="TextBox6" runat="server" CssClass="letra_pequena_centrada" Width="22px"></asp:textbox>&nbsp;&nbsp;<asp:dropdownlist id="DropDownList2" runat="server" CssClass="letra_pequena">
										<asp:ListItem Value="Dias">Dias</asp:ListItem>
										<asp:ListItem Value="Semanas" Selected="True">Semanas</asp:ListItem>
										<asp:ListItem Value="Meses">Meses</asp:ListItem>
										<asp:ListItem Value="A&#241;os">A&#241;os</asp:ListItem>
									</asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario" colSpan="4" height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario" colSpan="4" height="11">Posología:
									<asp:textbox id="TextBox3" runat="server" CssClass="letra_pequena" Width="448px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="fondo_formulario" colSpan="4" height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario" colSpan="4">Observaciones:</TD>
							</TR>
							<TR>
								<TD colSpan="4"><asp:textbox id="TextBox2" runat="server" CssClass="letra_pequena" Width="100%" TextMode="MultiLine"
										Height="50px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="4" height="22"></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="4" height="11"></TD>
							</TR>
							<TR>
								<TD align="right" colSpan="4">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD align="right"><input type="button" onclick="javascript:generar_receta();" style="WIDTH: 150px" value="Generar Receta"></TD>
											<TD width="11"></TD>
											<TD align="right" width="11"><asp:button id="Button3" runat="server" Width="150px" Text="Aceptar"></asp:button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11"><asp:button id="Button2" runat="server" Width="150px" Text="Cerrar"></asp:button></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
		<script type="text/javascript">
	
		function generar_receta(){

			var cadena;
			
			cadena = ""

			for (i=1;i<=<% =cint(me.contador.text) %>;i++){

			if (document.getElementById("cb" + i).checked == true){
			
				cadena = cadena + document.getElementById("cb" + i).value + "*";
			
			}
			
			}
			
			seleccion.cadena_creciente.value=cadena;
			
			seleccion.submit();
			
		}
	
		</script>
	</body>
</HTML>
