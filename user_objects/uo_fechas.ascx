<%@ Control Language="vb" AutoEventWireup="false" Codebehind="uo_fechas.ascx.vb" Inherits="zeus.uo_fechas" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<LINK href="../css/cima.css" rel="stylesheet">
<script src="../js/cima.js"></script>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD class="fecha_letra" noWrap>Fecha Inicio</TD>
		<TD width="4"></TD>
		<TD class="fecha_letra">Fecha Fin</TD>
	</TR>
	<TR>
		<TD noWrap width="50">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD><asp:textbox id="fecha_ini" Enabled="False" Width="90px" CssClass="fecha" runat="server">__/__/____</asp:textbox></TD>
					<TD></TD>
					<TD width="11"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="../imagenes/lupa.jpg"></asp:imagebutton></TD>
				</TR>
			</TABLE>
		</TD>
		<TD width="4"></TD>
		<TD noWrap align="right" width="50">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD><asp:textbox id="fecha_fin" Enabled="False" Width="90px" CssClass="fecha" runat="server">__/__/____</asp:textbox></TD>
					<TD></TD>
					<TD width="11"><asp:imagebutton id="Imagebutton2" runat="server" ImageUrl="../imagenes/lupa.jpg"></asp:imagebutton></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD vAlign="top" noWrap align="left" width="50">
			<DIV id="Div1" style="POSITION: absolute"><asp:calendar id="Calendar1" runat="server" FirstDayOfWeek="Monday" Visible="False" Width="250px"
					BorderWidth="1px" NextPrevFormat="FullMonth" BackColor="White" ForeColor="Black" Height="160px" Font-Size="9pt" Font-Names="Verdana"
					BorderColor="White">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar></DIV>
		</TD>
		<TD width="4"></TD>
		<TD noWrap align="left" width="50">
			<DIV id="Div2" style="POSITION: absolute"><asp:calendar id="Calendar2" runat="server" FirstDayOfWeek="Monday" Visible="False" Width="250px"
					BorderWidth="1px" NextPrevFormat="FullMonth" BackColor="White" ForeColor="Black" Height="160px" Font-Size="9pt" Font-Names="Verdana"
					BorderColor="White">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar></DIV>
		</TD>
	</TR>
</TABLE>
