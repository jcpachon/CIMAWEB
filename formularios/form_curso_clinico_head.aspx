<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_curso_clinico_head.aspx.vb" Inherits="zeus.form_curso_clinico_head"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_curso_clinico_head</title>
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" cellSpacing="0"
				cellPadding="0" width="100%" border="0" height="40" class="cabecera_formulario">
				<TR>
					<TD width="2"></TD>
					<TD width="*" vAlign="middle">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" height="11" colSpan="11" Width="400">Paciente</TD>
								<TD class="fondo_formulario" height="11" colSpan="11" Width="150">Edad</TD>
							</TR>
							<TR>
								<TD colSpan="11" height="7"></TD>
							</TR>
							<TR>
								<TD colSpan="11">
									<asp:label id=Label1 runat="server" CssClass="cabecera_formulario" Text='<%# DataBinder.Eval(Ds_pers1, "Tables[pers].DefaultView.[0].persfullname") %>' Width="400px">
									</asp:label></TD>
								<TD colSpan="11">
									<asp:label id="Label2" runat="server" CssClass="cabecera_formulario" Width="150px"></asp:label></TD>
							</TR>
							<TR>
								<TD colSpan="11" height="7"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
