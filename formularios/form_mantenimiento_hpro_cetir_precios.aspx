<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_hpro_cetir_precios.aspx.vb" Inherits="zeus.form_mantenimiento_hpro_cetir_precios"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_hpro_cetir_precios</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
	<script type=text/javascript>
	
	function actualizar(hpro_key,valor){
	
	if (!!isNaN(document.getElementById(valor).value) == false){
	
		enviar.actualizacion.value="S";
		enviar.clave.value=hpro_key;
		enviar.importe.value=document.getElementById(valor).value;
		
		//alert(hpro_key);
		//alert(document.getElementById(valor).value);
		
		enviar.submit();
	}
	else{
	
		alert("Importe erróneo.");
	
	};
	
	}
	
	<% if Request("actualizacion") = "S" then %>
	
	location.href="#<% =Request("clave") %>";
	
	<% end if %>
	
	</script>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form name="enviar">
		<input type=hidden name="actualizacion">
		<input type=hidden name="clave">
		<input type=hidden name="importe">
		</form>
		<form id="Form1" method="post" runat="server">		
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 11px; WIDTH: 100%; POSITION: absolute; TOP: 11px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">
						Precios&nbsp;Prestaciones CIMA - CETIR</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD colSpan="3" vAlign="top">
						<%
					
					Dim objRow as Data.DataRow
					
					Dim contador as Integer
							
											
											
					if Me.Ds_hpro_cetir_precios1.cima_hpro_cetir_precios.Rows.Count > 0 then
											
					%>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fecha_letra" width="100" style="HEIGHT: 14px">Prestación</TD>
								<TD class="fecha_letra" width="11" style="HEIGHT: 14px"></TD>
								<TD class="fecha_letra" width="300" style="HEIGHT: 14px"></TD>
								<TD class="fecha_letra" width="11" style="HEIGHT: 14px"></TD>
								<TD class="fecha_letra" align="right" width="75" style="HEIGHT: 14px">Importe</TD>
								<TD class="fecha_letra" width="11" style="HEIGHT: 14px"></TD>
								<TD class="fecha_letra" style="HEIGHT: 14px"></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD align="right" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<%
							contador = 0
							for each objRow in Me.Ds_hpro_cetir_precios1.cima_hpro_cetir_precios.Rows
							contador = contador + 1
							%>
							<TR>
								<TD class="letra_pequena">
								<a name="#<% =objRow.Item("hpro_key") %>"><% =objRow.Item("hprocode") %></a>
								</TD>
								<TD class="letra_pequena"></TD>
								<TD class="letra_pequena"><% =objRow.Item("hprodesclong") %></TD>
								<TD class="letra_pequena"></TD>
								<TD class="letra_pequena" align="right"><INPUT style="WIDTH: 75px; TEXT-ALIGN: right" type="text" id="tb<% =objRow.Item("hpro_key") %>" value="<% =replace(objRow.Item("importe"),",",".") %>"></TD>
								<TD class="letra_pequena"></TD>
								<TD class="letra_pequena" align="right"><INPUT style="WIDTH: 150px" type="button" size="150" value="Actualizar" onclick='javascript:actualizar(<% =objRow.Item("hpro_key") %>,"tb<% =objRow.Item("hpro_key") %>");'></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD align="right" height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<%
							next
							%>
						</TABLE>
						<%
						
						end if
						
						%>
					</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
