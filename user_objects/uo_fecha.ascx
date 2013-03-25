<%@ Control Language="vb" AutoEventWireup="false" Codebehind="uo_fecha.ascx.vb" Inherits="zeus.uo_fecha" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<LINK href="../css/cima.css" rel="stylesheet">
<script src="../js/cima.js"></script>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD class="fecha_letra" noWrap>Fecha</TD>
		<TD noWrap></TD>
	</TR>
	<TR>
		<TD noWrap width="50" vAlign="top">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD><asp:textbox id="fecha_ini" Enabled="False" Width="90px" CssClass="fecha" runat="server">__/__/____</asp:textbox></TD>
					<TD></TD>
					<TD width="11"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="../imagenes/lupa.jpg"></asp:imagebutton></TD>
				</TR>
			</TABLE>
		</TD>
		<TD vAlign="top" noWrap width="50"><asp:calendar id="Calendar1" runat="server" Width="250px" Height="160px" Visible="False" FirstDayOfWeek="Monday"
				BorderWidth="1px" NextPrevFormat="FullMonth" BackColor="White" ForeColor="Black" Font-Size="9pt" Font-Names="Verdana" BorderColor="White"><TodayDayStyle BackColor=" #CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar></TD>
	</TR>
	<TR>
		<TD vAlign="top" noWrap align="left" width="50">
			<DIV id="Div1" style="POSITION: absolute"></DIV>
		</TD>
		<TD vAlign="top" noWrap align="left" width="50"></TD>
	</TR>
</TABLE>
