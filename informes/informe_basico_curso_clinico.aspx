<%@ Page Language="vb" AutoEventWireup="false" Codebehind="informe_basico_curso_clinico.aspx.vb" Inherits="cimaweb.informe_basico_curso_clinico"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>informe_basico_curso_clinico</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
		<script src="../js/rtf.js"></script>
	</HEAD>
	<body bgColor="whitesmoke" MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" name="Form1" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" height="100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<script type="text/javascript">
	//informe.id_usuario.value=top.header.document.info.id_usuario.value;
	//alert('form_curso_clinico_lat_left');
	top.contents.location.href = '../formularios/form_curso_clinico_lat_left.aspx';
	
				</script>
				<TR>
					<TD class="cabecera_formulario" height="11"></TD>
				</TR>
				<TR>
					<TD class="cabecera_formulario" height="11"><asp:label id="Label2" runat="server" CssClass="fondo_formulario_2" Width="72px">Episodio:&nbsp;&nbsp;</asp:label><asp:label id="Label1" runat="server" CssClass="fondo_formulario_2" Width="144px">Label</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
					&nbsp;&nbsp;
				</TR>
				<TR>
					<TD class="cabecera_formulario" height="13" style="HEIGHT: 13px">
						<asp:label id="Label3" runat="server" Width="176px" CssClass="fondo_formulario_2">Fecha y hora admisión :&nbsp;&nbsp;</asp:label>
						<asp:label id="Label4" runat="server" Width="112px" CssClass="fondo_formulario_2_centrado">fecha</asp:label>&nbsp;
						<asp:label id="Label5" runat="server" Width="80px" CssClass="fondo_formulario_2_centrado">hora</asp:label></TD>
				</TR>
				<TR>
					<TD class="cabecera_formulario" height="11">
						<asp:label id="Label6" runat="server" Width="144px" CssClass="fondo_formulario_2">Motivo asistencia :&nbsp;&nbsp;</asp:label>
						<asp:label id="Label7" runat="server" Width="304px" CssClass="fondo_formulario_2">Motivo</asp:label></TD>
				</TR>
				<TR>
					<TD class="cabecera_formulario" height="11"></TD>
				</TR>
				<TR>
					<TD class="fondo_pie" height="11">Título</TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD align="left" height="11"><input style="WIDTH: 100%" 
      type=text 
      value='<% if trim(Session("cabecera")) = "" then      
		response.write(Session("titulo_propuesto"))      
      else       
		response.write(Session("cabecera"))      
      end if %>' 
      name=cab>
					</TD>
				</TR>
				<TR>
					<TD class="fondo_pie">Motivo</TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
				<TR>
					<TD>
						<script type="text/javascript">
						
		initRTE("images/", "", ""); 
		writeRichText('rte1', '', 200, 80, true, false); 
		
						</script>
					</TD>
				</TR>
				<TR>
					<TD>
						<% 
						F_Pintar()
						%>
					</TD>
				</TR>
				<TR>
					<TD class="fondo_pie">Descripción</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 53px">
						<script type="text/javascript">
						
		initRTE("images/", "", ""); 
		writeRichText('rte2', '', 200, 125, true, false); 
		
						</script>
					</TD>
				</TR>
				<TR>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD align="right" height="11">&nbsp;<INPUT style="WIDTH: 150px" onclick="javascript:enviar();" type="button" value="Enviar"
							disabled>
					</TD>
				</TR>
				<TR>
					<TD align="right" height="11"></TD>
				</TR>
			</TABLE>
		</form>
		<form name="informe" method="post">
			<input type="hidden" name="motivo"> <input type="hidden" name="diagnostico"> <input type="hidden" name="ok">
			<input type="hidden" name="tipo"> <input type="hidden" name="id_usuario"> <input type="hidden" name="cabecera">
			<input type=hidden name="control_episcode" 
			value='<% if Request("control_episcode") = "" then
			response.write(Session("episcode"))
			end if%>'>
			<% F_Pintar_Hidden() %>
		</form>
		<%
		
		Dim str_menu_2 as string
		Dim objCIMA_2 as New CIMA_Clases.CIMA
		Dim objCIMA_3 as New CIMA_Clases.CIMA

		Dim objDS as New Data.DataSet
		Dim objDS_2 as New Data.DataSet

		Dim objRow as Data.DataRow
		
		Dim contador as Integer
		
		Dim contaje as Integer
		
		Dim m,d as string
		
		Dim matriz_memoria() as string
		Dim matriz_memoria2() as string
		
		Dim n as integer
		
		Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
		
		matriz_memoria = Split(Session("memoria"), ",", , CompareMethod.Text)
        matriz_memoria2 = Split(Session("memoria2"), ",", , CompareMethod.Text)
		
		response.write ("<script type=text/javascript>")
		
		str_menu_2 = "dbo.SP_CIMACEX_RECUPERA_INFORME_BASICO " & Session("id_informe") & ",1"

		objDS = objCIMA_2.f_consulta(str_menu_2, Session("cadena_conexion"))
		
		contador = objDS.Tables(0).Rows.Count ' Da igual si valorar motivo o diagnostico.
		
		response.write ("var oRTE = document.frames[0].document.body;")
		
		if contador > 0 then
			response.write ("informe.tipo.value='U';") ' Update.
			m=objDS.Tables(0).Rows(0).Item(0)
		else
			response.write ("informe.tipo.value='N';") ' Nuevo.
			m=""
		end if
		
		'objDS = Nothing
		
		'objCIMA_2 = Nothing
		
		response.write("if (informe.tipo.value == 'U') { oRTE.innerHTML=unescape('" & m & "'); };")
		
		'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		
		contaje = 0
		
		For n = 1 To (UBound(matriz_memoria))
		
			objDS = Nothing
		
			str_menu_2 = "dbo.SP_CIMACEX_RECUPERA_INFORME_BASICO " & Session("id_informe") & "," & matriz_memoria(n)

			objDS = objCIMA_2.f_consulta(str_menu_2, Session("cadena_conexion"))
		
			contador = objDS.Tables(0).Rows.Count ' Da igual si valorar motivo o diagnostico.

			if contador > 0 then
				d=objDS.Tables(0).Rows(0).Item(0)
			else
				d=""
			end if
			
			if matriz_memoria2(n) = 1 then
				contaje = contaje + 1
				response.write ("var oRTE" & cstr(contaje) & " = document.frames[" & cstr(contaje) & "].document.body;")
				response.write("if (informe.tipo.value == 'U') { oRTE" & cstr(contaje) & ".innerHTML=unescape('" & d & "'); };")
			else
				response.write("if (informe.tipo.value == 'U') { document.getElementById('rte" & matriz_memoria(n) & "').value='" & d & "'; };")
			end if

		Next
		
		objDS = Nothing
		
		objCIMA_2 = Nothing
		
		'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		
		str_menu_2 = "dbo.SP_CIMACEX_RECUPERA_INFORME_BASICO " & Session("id_informe") & ",2"

		objDS_2 = objCIMA_3.f_consulta(str_menu_2, Session("cadena_conexion"))

		contador = objDS_2.Tables(0).Rows.Count

		if contador > 0 then
			d=objDS_2.Tables(0).Rows(0).Item(0)
		else
			d=""
		end if

		objDS_2 = Nothing
		
		objCIMA_3 = Nothing

		response.write ("var oRTE" & cstr(contaje + 1) & " = document.frames[" & cstr(contaje + 1) & "].document.body;")
		response.write("if (informe.tipo.value == 'U') { oRTE" & cstr(contaje + 1) & ".innerHTML=unescape('" & d & "'); };")

		response.write("</script>")
		
		%>
		<script type="text/javascript">
		
		if (document.getElementById("cab").value == ''){
		
			document.getElementById("cab").value = '';
		
		}
		
		function enviar(){
		
			var oRTE = document.frames[0].document.body;
			<% 
			response.write ("var oRTE" & cstr(contaje + 1) & " = document.frames[" & cstr(contaje + 1) & "].document.body;")
			%>
			informe.motivo.value=escape(oRTE.innerHTML);
			
			informe.ok.value="S";
			informe.cabecera.value=document.getElementById("cab").value;

			<%
			
			F_Pintar_Enviar()
			
			%>
			
			if (oRTE.innerHTML == '' || <% response.write ("oRTE" & cstr(contaje + 1) & ".innerHTML") %> == ''){
				alert("Los campos MOTIVO y DIAGNOSTICO son obligatorios");
				}
			else{
				var conf = confirm('Se va a proceder a salvar y cerrar el informe. ¿Está usted de acuerdo?');
				
				if (conf==1){
					informe.submit();
					//top.contents.location.href = '../formularios/form_curso_clinico_lat_left.aspx';
				};				
				
				}
				
			
		}
		</script>
	</body>
</HTML>
