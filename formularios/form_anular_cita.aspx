<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_anular_cita.aspx.vb" Inherits="cimaweb.form_anular_cita" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Anular Cita</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
	function enviar_anular(){
		
		//persona.epis_key.value=epis_key;
		document.getElementById("b_anular_cita").disabled=true;
		persona.control.value="S";
		persona.motivo.value='<% =Session("motivo") %>';
		persona.submit();
		//alert("SI");
		
	}
		</script>
		<form name=persona action='../formularios/form_anular_cita.aspx?dia_seleccionado=<% =Session("dia_seleccionado") %>&amp;agencode=<% =Session("agencode") %>&amp;entrada=<% =Session("entrada") %>' method=post>
			<input type="hidden" name="epis_key"> <input type="hidden" name="control"> <input type="hidden" name="motivo">
			<input type=hidden value='<% =Session("ristra") %>' name=ristra>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="5" height="22">Motivo</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD width="11" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="5" style="HEIGHT: 14px">
						<asp:dropdownlist id=DropDownList3 runat="server" DataSource="<%# Ds_bookcanc1 %>" DataMember="bookcanc" DataTextField="bookcancdesclong" DataValueField="bookcanccode" CssClass="letra_pequena" AutoPostBack="True" Width="150px">
						</asp:dropdownlist>
					</TD>
				</TR>
				<TR>
					<TD colSpan="5" height="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="5"><INPUT style="WIDTH: 150px" onclick="javascript:enviar_anular();" type="button" size="150"
							value="Enviar" id="b_anular_cita"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
