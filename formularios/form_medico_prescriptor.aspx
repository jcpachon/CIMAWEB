<%@ Register TagPrefix="anthem" Namespace="Anthem" Assembly="Anthem" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_medico_prescriptor.aspx.vb" Inherits="cimaweb.form_medico_prescriptor"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>Médico Prescriptor</title>
<meta content="Microsoft Visual Studio .NET 7.1" name=GENERATOR>
<meta content="Visual Basic .NET 7.1" name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema><LINK href="../css/cima.css" rel=stylesheet >
<script src="../js/cima.js"></script>
</HEAD>
<body MS_POSITIONING="GridLayout">
<form id=Form1 method=post runat="server">
<TABLE id=Table1 style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" 
cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TR>
    <TD class=fondo_pie colSpan=3 height=11>Médico 
      Prescriptor</TD></TR>
  <TR>
    <TD colSpan=3 height=11>
      <TABLE id=Table2 height="100%" cellSpacing=0 cellPadding=0 width="100%" 
      border=0></TABLE></TD></TR>
  <TR>
    <TD class=letra_pequena_negrita height=1>Servicio de 
      Procedencia:</TD>
    <TD height=1></TD>
    <TD align=right height=1><anthem:dropdownlist id=DropDownList2 runat="server" DataMember="csta" DataValueField="csta_key" DataTextField="cstadesclong" DataSource="<%# Ds_csta1 %>" Width="250px" CssClass="letra_pequena" OnSelectedIndexChanged="dropDownList2_SelectedIndexChanged" AutoCallBack="True">
						</anthem:dropdownlist></TD></TR>
  <TR>
    <TD height=11></TD>
    <TD height=11></TD>
    <TD height=11></TD></TR>
  <TR>
    <TD class=letra_pequena_negrita height=11>Médico 
      Prescriptor:</TD>
    <TD height=11></TD>
    <TD align=right height=11><anthem:dropdownlist id=DropDownList3 runat="server" DataMember="cstahper" DataValueField="cstahper_key" DataTextField="persfullname" DataSource="<%# Ds_datos_captura_cstahper1 %>" Width="250px" CssClass="letra_pequena">
						</anthem:dropdownlist></TD></TR>
  <TR>
    <TD height=11></TD>
    <TD height=11></TD>
    <TD height=11></TD></TR>
  <script runat="server">

				Sub dropDownList2_SelectedIndexChanged(sender As Object, e As System.EventArgs)

					DropDownList3.Items.Clear()
					'dropDownList3.Items.Clear()

					'if (dropDownList1.SelectedIndex > 0) then
					'	dropDownList2.Items.Add(dropDownList1.SelectedValue + ".1")
					'	dropDownList2.Items.Add(dropDownList1.SelectedValue + ".2")
					'	dropDownList2.Items.Add(dropDownList1.SelectedValue + ".3")
					'end if
					
					Me.SqlDataAdapter2.SelectCommand.Parameters(0).Value = Me.dropDownList2.SelectedValue

					Me.SqlConnection1.Open()
					Me.SqlDataAdapter2.Fill(me.Ds_datos_captura_cstahper1.cstahper)
					Me.SqlConnection1.Close()

					Me.DropDownList3.DataBind()

					DropDownList3.UpdateAfterCallBack = true
					'dropDownList3.UpdateAfterCallBack = true
					
				End Sub

				</script>

  <TR>
    <TD height=11></TD>
    <TD height=11></TD>
    <SCRIPT language=javascript>
	
	function cerrar() {
	
	if (Form1.DropDownList3.value){
		window.returnValue=Form1.DropDownList3.value ;
		window.close();}
	else{
		alert("Falta informar el Médico Prescriptor.");
	};
		
	}
	
	</SCRIPT>
    <TD align=right height=11><INPUT type="button" style="WIDTH: 150px" onclick="javascript:cerrar();" value="Aceptar"></TD></TR></TABLE></FORM>
	</body>
</HTML>
