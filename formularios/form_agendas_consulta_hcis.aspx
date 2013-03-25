<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_agendas_consulta_hcis.aspx.vb" Inherits="cimaweb.form_agendas_consulta_hcis" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_agendas_consulta_hcis</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<BODY>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="300" border="0">
				<TBODY>
					<TR>
						<TD class="cabecera_formulario" colSpan="3" height="21" style="HEIGHT: 21px">Citas 
							Programadas HCIS</TD>
					</TR>
					<TR>
						<TD colSpan="3" height="11"></TD>
					</TR>
					<TR>
						<TD vAlign="top" width="*" colSpan="3" height="11">
							<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD width="175" height="11"><asp:dropdownlist id="Dropdownlist2" runat="server" AutoPostBack="True" CssClass="letra_pequena" Width="250px" DataSource="<%# Ds_hcis_servicio1 %>" DataMember="hcis_servicio" DataTextField="HCIScodedesc_servicio" DataValueField="HCIScode_servicio">
										</asp:dropdownlist></TD>
									<TD colSpan="4" height="11">&nbsp;&nbsp;
										<asp:dropdownlist id=DropDownList1 runat="server" DataValueField="HCIScode_agenda" DataTextField="HCIScodedesc_agenda" DataMember="hcis_agenda" DataSource="<%# Ds_hcis_agenda1 %>" AutoPostBack="True" CssClass="letra_pequena" Width="250px">
										</asp:dropdownlist>&nbsp;&nbsp;</TD>
									<TD align="right" width="10" height="11"></TD>
									<TD align="right" width="11" height="11"></TD>
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
									<TD></TD>
								</TR>
							</TABLE>
							<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD colSpan="6" height="11"></TD>
								</TR>
								<TR>
									<TD colSpan="6" height="11"></TD>
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
											<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TBODY>
										</TD>
									</TR>
									<TR height="11">
										<TD class="letra_pequena_negrita" colSpan="15"></TD>
									</TR>
									<TR height="11">
										<TD class="letra_pequena_negrita" colSpan="15">PRG - Programada&nbsp; &nbsp;CAP - 
											Capturada</TD>
										<td colspan="2" align="right"><IMG height="16" alt="" src="../imagenes/print.gif" onclick="javascript:printPage();"></td>
									</TR>
									<TR height="11">
										<TD class="letra_pequena_negrita" colSpan="15"></TD>
									</TR>
								</TBODY>
							</TABLE>
					<TR>
						<TD class="menu_lateral_izquierdo" colSpan="15">Citas del día</TD>
					</TR>
					<TR>
						<TD height="11"></TD>
						<TD height="11"></TD>
						<TD height="11"></TD>
					</TR>
					<%
							
							Dim str_menu as string
												
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
														
							'Dim objRow as Data.DataRow
							
							
							Dim a as Integer
							
							Dim contador as integer
							
							Dim ls_array() as String
							
							'Dim ws_sanitas As New SANITAS_WS.Service1

							'Dim ds_citas As New SANITAS_WS.ds_citas


							
							contador = 0
							
							'objDS = objCIMA.f_consulta_CSaludR(str_menu, "DATABASE=CSaludR;DSN=CSaludR;UID=sa;PWD=kampeon10;APP=Microsoft® Visual Studio .NET;Address={10.8.50.213};;WSID=ZEUS;Network=DBMSSOCN")
							If IsNothing(ds_citas) = False Then
							
							'for each objRow in ds_citas.citas
								
								'contador= contador + 1
							
							
							%>
					<TR>
						<TD height="11" colSpan="3">
							<asp:DataGrid id=DataGrid1 runat="server" DataSource="<%# DataView1 %>" Font-Names="Verdana" Font-Size="6pt" ShowHeader="False" Width="100%" PageSize="100" Font-Bold="True">
							</asp:DataGrid>
						</TD>
					</TR>
					<%
							
					'next
					
					end if
					
					%>
				</TBODY>
			</TABLE>
		</form>
		</TD></TR>
		<TR>
			<TD vAlign="top" width="150"></TD>
			<TD style="HEIGHT: 215px" vAlign="top" width="11"></TD>
			<TD style="HEIGHT: 224px" vAlign="top" align="right" width="100%"></TD>
		</TR>
		</TBODY></TABLE>
	</BODY>
</HTML>
