<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_consentimientos.aspx.vb" Inherits="zeus.form_mantenimiento_consentimientos"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_mantenimiento_informes</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
		<script src="../js/rtf.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
		
		function enviar(){
		
			var oRTE = document.frames[0].document.body;
			
			informe.texto.value=escape(oRTE.innerHTML);
			informe.ok.value="S";
			informe.actiu.value=document.getElementById("activo").checked
			//alert(document.getElementById("seleccion_permisos").value);
			informe.permisos.value=document.getElementById("seleccion_permisos").value
			
			informe.submit();
			
		}
		
		</script>
		<form name="informe" method="post">
			<input type="hidden" name="texto"> <input type="hidden" name="ok"> <input type="hidden" name="actiu">
			<input type="hidden" name="permisos">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Mantenimiento de 
						Consentimientos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_muy_pequena_azul_negrita" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_formulario" width="250">Nombre Consentimiento</TD>
								<TD class="fondo_formulario" width="11"></TD>
								<TD class="fondo_formulario">Descripción Consentimiento</TD>
							</TR>
							<TR>
								<TD width="250"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD width="250"><asp:textbox id=TextBox3 runat="server" Text='<%# DataBinder.Eval(Ds_consentimientos1, "Tables[cima_consentimientos].DefaultView.[0].descripcion") %>' Enabled="False" CssClass="letra_pequena" Width="200px"></asp:textbox></TD>
								<TD></TD>
								<TD><asp:textbox id=TextBox4 runat="server" Text='<%# DataBinder.Eval(Ds_consentimientos1, "Tables[cima_consentimientos].DefaultView.[0].informacion") %>' Enabled="False" CssClass="letra_pequena" Width="100%"></asp:textbox></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_muy_pequena_azul_negrita" colSpan="3" height="11">Descripción</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<script type="text/javascript">
						
		initRTE("images/", "", ""); 
		writeRichText('rte1', '', 720, 200, true, false); 
		
						</script>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><INPUT style="WIDTH: 24px; HEIGHT: 20px" type="checkbox" name="activo">
						<DIV class="letra_pequena" style="DISPLAY: inline; WIDTH: 70px; HEIGHT: 15px" ms_positioning="FlowLayout">&nbsp;Activo</DIV>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="fondo_pie" colSpan="3" height="11">Permisos</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 39px" colSpan="3" height="39">
						<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="11"><SELECT name="seleccion_permisos">
										<OPTION value="1" selected>PLANTILLA A DISPOSICIÓN DE
											<% =Session("descripcion") %>
										</OPTION>
										<% 'if len(trim(Session("grupos")))>0 then %>
										<OPTION value="2">PLANTILLA A DISPOSICIÓN DE LOS GRUPOS:
											<% =Session("grupos") %>
										</OPTION>
										<% 'end if %>
										<OPTION value="3">PLANTILLA A DISPOSICIÓN DE TODOS LOS USUARIOS DEL SISTEMA</OPTION>
									</SELECT>
								</TD>
								<TD width="11"></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<HR width="100%" SIZE="1">
					</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD align="right" height="11"><INPUT style="WIDTH: 150px" onclick="javascript:enviar();" type="button" size="20" value="Aceptar"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
			<%
			
			Dim str_menu as string
			Dim objCIMA as New CIMA_Clases.CIMA

			Dim objDS as New Data.DataSet
			
			Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
			
			str_menu = "dbo.SP_CIMACEX_RECUPERA_CONSENTIMIENTO_BASICO " & Session("id_consentimiento")

			objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
			
			if objDS.Tables(0).Rows.Count > 0 then
			
				response.write("<script type=text/javascript>")
				
				response.write ("var oRTE = document.frames[0].document.body;")
		
				response.write("oRTE.innerHTML=unescape('" & objDS.Tables(0).Rows(0).Item(0) & "');")
		
				if objDS.Tables(0).Rows(0).Item(2)="S" then
					response.write("document.getElementById('activo').checked=true;")
				else
					response.write("document.getElementById('activo').checked=false;")
				end if
				
				response.write("document.getElementById('seleccion_permisos').value=" & objDS.Tables(0).Rows(0).Item(1) & ";")
		
				response.write("</script>")
			
			end if
			
			%>
		</form>
	</body>
</HTML>
