<%@ Register TagPrefix="uo_fecha" TagName="uo_fecha" Src="../user_objects/uo_fecha.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_ocupacion_camas.aspx.vb" Inherits="cimaweb.form_ocupacion_camas" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_ocupacion_camas</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; LEFT: 11px; POSITION: absolute; TOP: 11px" id="Table1" border="0"
				cellSpacing="0" cellPadding="0" width="100%">
				<TR height="11">
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22" colSpan="3">Ocupación 
						de Camas</TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR>
					<TD><asp:label id="Label1" runat="server" CssClass="letra_pequena">Plantas :&nbsp;&nbsp;</asp:label><asp:dropdownlist id=Dropdown_plantas runat="server" CssClass="letra_pequena" Width="100px" AutoPostBack="True" DataValueField="spdi_key" DataTextField="spdidesclong" DataMember="spdi" DataSource="<%# Ds_plantas2 %>">
						</asp:dropdownlist>&nbsp;&nbsp;
						<asp:label id="Label2" runat="server" CssClass="letra_pequena" Enabled="False">Camas :&nbsp;&nbsp;</asp:label><asp:dropdownlist id=DropDownList2 runat="server" CssClass="letra_pequena" Width="100px" AutoPostBack="True" DataValueField="beds_key" DataTextField="bedscode" DataMember="SP_CIMACEX_ELEJIR_CAMAS" DataSource="<%# Ds_elije_cama1 %>" Enabled="False">
						</asp:dropdownlist>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:button id="Button1" runat="server" Width="150px" Text="Buscar"></asp:button></TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR>
					<TD><asp:radiobutton id="RadioButton1" runat="server" CssClass="letra_pequena" AutoPostBack="True" Text="Ocupación actual"
							GroupName="a"></asp:radiobutton><asp:radiobutton id="Radiobutton2" runat="server" CssClass="letra_pequena" Width="128px" AutoPostBack="True"
							Text="Historia de una cama" GroupName="a"></asp:radiobutton>
						<asp:CheckBox id="CheckBox1" runat="server" CssClass="Letra_pequena" Text="Camas Acompañantes"></asp:CheckBox></TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="2"><uo_fecha:uo_fecha id="Uo_fecha1" runat="server" Visible="False"></uo_fecha:uo_fecha></TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR>
					<TD><asp:label id="a" runat="server" Width="24px" Visible="False" BackColor="Red" Height="22px"></asp:label>&nbsp;
						<asp:label id="Label4" runat="server" CssClass="letra_pequena" Visible="False">Ocupada</asp:label>&nbsp;&nbsp;
						<asp:label id="b" runat="server" Width="24px" Visible="False" BackColor="LawnGreen" Height="22px"></asp:label>&nbsp;
						<asp:label id="Label3" runat="server" CssClass="letra_pequena" Visible="False">Libre</asp:label></TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<%
					If Me.Ds_recuperar_camas1.SP_CIMACEX_RECUPERA_CAMAS.rows.Count >= 1 Then
				%>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD class="cabecera_busca_pacientes" height="11" colSpan="3">Resultado de la 
						búsqueda
					</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="9">
						<TABLE id="Table2" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="40">Cama</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="180">Paciente</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="50">NHC</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="180">Mutua</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="60">F. Ing.</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="60">H. Ing.</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Episodio</TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<%
							Dim objRow as Data.DataRow
							for each objRow in Me.Ds_recuperar_camas1.SP_CIMACEX_RECUPERA_CAMAS.Rows					
								if objRow.Item(4) = " " then 				
								%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" onmouseout="javascript:this.className='letra_muy_pequena_negrita';"
								height="22">
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" bgColor="#33ff00" align="center"><% =objRow.Item(0) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(3) %>
									<% =objRow.Item(1) %>
									<% =objRow.Item(2) %>
								</TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(4) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(8) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(6)  %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(7)  %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(5) %></TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<%else%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" onmouseout="javascript:this.className='letra_muy_pequena_negrita';"
								height="22">
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" bgColor="#ff0000" align="center"><% =objRow.Item(0) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(3) %>
									<% =objRow.Item(1) %>
									<% =objRow.Item(2) %>
								</TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(4) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(8) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRow.Item(6)  %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRow.Item(7)  %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRow.Item(5) %></TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<% End if %>
							<%					
							next					
							%>
						</TABLE>
					</TD>
				</TR>
				<%		
					end if		
				%>
				<TR>
					<TD height="11"></TD>
				</TR>
				<%
					If Me.Ds_historico_camas1.SP_CIMACEX_HISTORICO_CAMAS.rows.Count >= 1 Then
				%>
				<TR height="11">
					<TD></TD>
				</TR>
				<TR>
					<TD class="cabecera_busca_pacientes" height="11" colSpan="9">Resultado de la 
						búsqueda
					</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="9">
						<TABLE id="Table6" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="35">Cama</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="160">Paciente</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="40">NHC</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="45">F. Ing.</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="45">H. Ing.</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="45">
									F. Alta</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="45">
									H. Alta</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario">Episodio</TD>
								<TD width="11"></TD>
								<TD class="fondo_formulario" width="170">Mutua</TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<%
							Dim objRaw as Data.DataRow
							for each objRaw in Me.Ds_historico_camas1.SP_CIMACEX_HISTORICO_CAMAS.Rows					
							%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" onmouseout="javascript:this.className='letra_muy_pequena_negrita';"
								height="11">
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRaw.Item(0) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRaw.Item(3) %>
									<% =objRaw.Item(1) %>
									<% =objRaw.Item(2) %>
								</TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRaw.Item(4) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRaw.Item(7) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRaw.Item(8) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRaw.Item(9) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita" align="center"><% =objRaw.Item(10) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRaw.Item(5) %></TD>
								<TD width="11"></TD>
								<TD class="letra_muy_pequena_negrita"><% =objRaw.Item(6) %></TD>
								<TD width="11"></TD>
							</TR>
							<TR height="11">
								<TD width="11"></TD>
								<TD></TD>
								<TD width="11"></TD>
							</TR>
							<%					
							next					
							%>
						</TABLE>
					</TD>
				</TR>
				<%		
				end if		
				%>
				<TR>
					<TD height="11" colSpan="9"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
