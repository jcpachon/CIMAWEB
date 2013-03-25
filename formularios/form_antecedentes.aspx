<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_antecedentes.aspx.vb" Inherits="cimaweb.form_antecedentes"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Antecedentes</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" height="100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="fondo_pie" height="11">Antecedentes</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD vAlign="top" align="right">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="cabecera_formulario">Alergias medicamentosas</TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD>
									<asp:textbox id=TextBox1 runat="server" Rows="5" TextMode="MultiLine" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas1, "Tables[cima_alertas].DefaultView.[0].alerta") %>'>
									</asp:textbox></TD>
							</TR>
							<TR>
								<TD height="11" class="letra_pequena">Activar Alerta:&nbsp;
									<asp:CheckBox id=CheckBox1 runat="server" Checked='<%# CheckboxEval(DataBinder.Eval(Ds_cima_alertas1, "Tables[cima_alertas].DefaultView.[0].aviso")) %>' CssClass="letra_pequena" >
									</asp:CheckBox></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario">Antecedentes personales</TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD>
									<asp:textbox id=TextBox2 runat="server" Rows="5" TextMode="MultiLine" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas2, "Tables[cima_alertas].DefaultView.[0].alerta") %>'>
									</asp:textbox></TD>
							</TR>
							<TR>
								<TD height="11" class="letra_pequena">Activar Alerta:&nbsp;
									<asp:CheckBox id=CheckBox2 runat="server" Checked='<%# CheckBoxEval(DataBinder.Eval(Ds_cima_alertas2, "Tables[cima_alertas].DefaultView.[0].aviso")) %>' CssClass="letra_pequena" >
									</asp:CheckBox></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD class="cabecera_formulario">Antecedentes familiares</TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
							<TR>
								<TD>
									<asp:textbox id=TextBox3 runat="server" Rows="5" TextMode="MultiLine" Width="100%" Text='<%# DataBinder.Eval(Ds_cima_alertas3, "Tables[cima_alertas].DefaultView.[0].alerta") %>'>
									</asp:textbox></TD>
							</TR>
							<TR>
								<TD height="11" class="letra_pequena">Activar Alerta:&nbsp;
									<asp:CheckBox id=CheckBox3 runat="server" Checked='<%# CheckBoxEval(DataBinder.Eval(Ds_cima_alertas3, "Tables[cima_alertas].DefaultView.[0].aviso")) %>' CssClass="letra_pequena" >
									</asp:CheckBox></TD>
							</TR>
							<TR>
								<TD></TD>
							</TR>
						</TABLE>
						&nbsp;
					</TD>
				</TR>
				<TR>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD align="right" height="11">
						<asp:Button id="Button1" runat="server" Width="150px" Text="Actualizar"></asp:Button>&nbsp;
						<asp:Button id="Button2" runat="server" Width="150px" Text="Cerrar"></asp:Button></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
