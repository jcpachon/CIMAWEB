<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_curso_clinico_foot.aspx.vb" Inherits="zeus.form_curso_clinico_foot"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_curso_clinico_foot</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD width="22" height="7"></TD>
					<TD style="WIDTH: 168px" width="168" height="7"></TD>
					<TD width="11" height="7"></TD>
					<TD height="7"></TD>
					<TD width="5" height="7"></TD>
				</TR>
				<TR>
					<TD width="22"></TD>
					<TD style="WIDTH: 168px" width="168"><asp:label id="Label1" runat="server" CssClass="cabecera_titulo_informe_rojo" Width="175px">Alergias medicamentosas:</asp:label></TD>
					<TD width="22"></TD>
					<TD><asp:textbox id="TextBox1" runat="server" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas1, "Tables[cima_alertas].DefaultView.[0].alerta") %>' ></asp:textbox></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD width="22"></TD>
					<TD style="WIDTH: 168px" width="168"><asp:label id="Label2" runat="server" CssClass="cabecera_titulo_informe_rojo" Width="175px">Antecedentes personales:</asp:label></TD>
					<TD></TD>
					<TD><asp:textbox id="TextBox2" runat="server" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas2, "Tables[cima_alertas].DefaultView.[0].alerta") %>' ></asp:textbox></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD width="22"></TD>
					<TD style="WIDTH: 168px" width="168"><asp:label id="Label3" runat="server" CssClass="cabecera_titulo_informe_rojo" Width="175px">Antecedentes familiares:</asp:label></TD>
					<TD></TD>
					<TD><asp:textbox id="TextBox3" runat="server" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas3, "Tables[cima_alertas].DefaultView.[0].alerta") %>' ></asp:textbox></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD width="22"></TD>
					<TD style="WIDTH: 168px" width="168">
						<asp:label id="Label4" runat="server" Width="175px" CssClass="cabecera_titulo_informe">Notas Administrativas:</asp:label></TD>
					<TD></TD>
					<TD>
						<asp:textbox id=Textbox4 runat="server" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas4, "Tables[cima_alertas].DefaultView.[0].alerta") %>' >
						</asp:textbox></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD height="5"></TD>
					<TD style="WIDTH: 168px" height="1">
						<asp:TextBox id="control" runat="server" Visible="False"></asp:TextBox></TD>
					<TD height="5"></TD>
					<TD height="5"></TD>
					<TD height="5"></TD>
				</TR>
				<TR>
					<TD align="right" colSpan="4">
						<asp:Button id="Button1" runat="server" Width="150px" Text="Actualizar"></asp:Button></TD>
					<TD align="right" width="5"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
