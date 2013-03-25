<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_episodios.aspx.vb" Inherits="cimaweb.form_mantenimiento_episodios" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_episodios</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; TOP: 11px; LEFT: 11px" id="Table1" border="0"
				cellSpacing="0" cellPadding="0" width="100%" height="100%">
				<TR height="11">
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22" colSpan="3">Mantenimiento 
						de Episodios</TD>
				</TR>
				<TR height="11">
					<TD width="11"></TD>
					<TD></TD>
					<TD width="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Episodio :&nbsp;&nbsp;</asp:label><asp:textbox id="TextBox1" runat="server" CssClass="letra_pequena_centrada"></asp:textbox>&nbsp;&nbsp;
						<asp:button id="Button1" runat="server" Text="Buscar" Width="150px"></asp:button></TD>
				</TR>
				<TR>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:panel id="Panel1" runat="server" Visible="False">
							<asp:RadioButton id="RadioButton1" runat="server" CssClass="letra_pequena_negrita" Text="Vincular a Episodio"
								AutoPostBack="True" GroupName="opciones"></asp:RadioButton>
							<asp:RadioButton id="RadioButton3" runat="server" CssClass="letra_pequena_negrita" Text="Desvincular Episodio"
								AutoPostBack="True" GroupName="opciones"></asp:RadioButton>
							<asp:RadioButton id="RadioButton2" runat="server" CssClass="letra_pequena_negrita" Text="Modificar datos I. Marqués"
								AutoPostBack="True" GroupName="opciones"></asp:RadioButton>
							<asp:RadioButton id="RadioButton4" runat="server" CssClass="letra_pequena_negrita" Text="Episodio Padre"
								AutoPostBack="True" GroupName="opciones"></asp:RadioButton>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD height="11" width="11"></TD>
					<TD height="11"></TD>
					<TD height="11" width="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"><asp:panel id="Panel2" runat="server" Visible="False">
<asp:label id="Label2" runat="server" CssClass="letra_pequena">Vincular a Episodio:</asp:label>&nbsp;&nbsp; 
<asp:TextBox id="TextBox2" runat="server" CssClass="letra_pequena_centrada"></asp:TextBox>&nbsp; 
<asp:button id="Button2" runat="server" Text="Vincular" Width="150px"></asp:button>&nbsp; 
      </asp:panel><asp:panel id="Panel3" runat="server" Visible="False">
<asp:label id="Label3" runat="server" CssClass="letra_pequena">Desvincular Episodio:</asp:label>&nbsp;&nbsp; 
<asp:button id="Button3" runat="server" Text="Desvincular" Width="150px"></asp:button></asp:panel><asp:panel id="Panel4" runat="server" Visible="False">
<asp:label id="Label4" runat="server" CssClass="letra_pequena">NHC I. Marqués:</asp:label>&nbsp;&nbsp; 
<asp:TextBox id="TextBox3" runat="server" CssClass="letra_pequena_centrada"></asp:TextBox>&nbsp;&nbsp; 
<asp:label id="Label5" runat="server" CssClass="letra_pequena">Origen:</asp:label>&nbsp;&nbsp; 
<asp:DropDownList id="DropDownList1" runat="server" CssClass="letra_pequena">
								<asp:ListItem Value="0">&nbsp;</asp:ListItem>
								<asp:ListItem Value="TIPO A">TIPO A</asp:ListItem>
								<asp:ListItem Value="TIPO B">TIPO B</asp:ListItem>
								<asp:ListItem Value="CITOLOGIA GINE">CITOLOGIA GINE</asp:ListItem>
								<asp:ListItem Value="CITOLOGIA REPRO">CITOLOGIA REPRO</asp:ListItem>
							</asp:DropDownList>&nbsp; 
<asp:button id="Button4" runat="server" Text="Actualizar" Width="150px"></asp:button>&nbsp;</asp:panel>
						<asp:panel id="Panel5" runat="server" Visible="False">
							<asp:Button id="Button5" runat="server" Text="Aceptar" Width="150px"></asp:Button>
						</asp:panel>
					</TD>
				</TR>
				<TR>
					<TD colSpan="9"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="9"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
