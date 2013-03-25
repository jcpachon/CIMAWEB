<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_historico_radiologia.aspx.vb" Inherits="zeus.form_historico_radiologia" %>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Histórico DI</title>
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
		
		function abrir_visor(id_estudio,studyuid){
		
		//window.open("AgfaImpaxBridge://localhost/Display?user=cima&password=cima2009&domain=Agfa%20Healthcare&accession=CGM." + id_estudio + "&appserver=cmapacs01.cetir.org","Visor","");
		window.open("agfahc://impax-client-epr/?user=cima&password=cima2009&domain=Agfa%20Healthcare&studyuid=" + studyuid + "","Visor","");
		window.close();
		
		}
		
		function abrir_informe(episcode,numero,nombre){
		
		open_informe.abrir_informe.value="S";
		open_informe.episcode_informe.value=episcode;
		open_informe.numero_informe.value=numero;
		open_informe.nombre_informe.value=nombre;
		
		open_informe.submit();
		
		}
		
		</script>
		<form id="open_informe">
			<input type="hidden" name="abrir_informe"><input type="hidden" name="episcode_informe">
			<input type="hidden" name="numero_informe"> <input type="hidden" name="nombre_informe">
			<input type="hidden" name="pers_key" value='<% =Session("pers_key") %>'>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="98%" border="0">
				<TR>
					<TD height="11"></TD>
					<TD class="fondo_pie" height="11">Histórico DI -
						<% =Session("pers_key") %>
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD vAlign="middle" align="center">
					<TABLE id="Table22" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR height="11">
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						<%
									
							Dim str_menu as string
											
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							Dim contador as integer
							
							Dim ls_pers_key as string
							Dim ls_epis_key as string
							Dim ls_pers_key_aux as string
							Dim li_id_episodio_CETIR as integer
							
							
							Dim a as integer
							
							
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.[SP_CIMACEX_RECUPERA_PERS_INFORMES] '" & Session("pers_key") & "','cetir.carga'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							contador = 0
							
							for each objRow in objDS.Tables(0).Rows
							
							Dim ls_retorno() as string
							
							contador = contador + 1
							
							if objRow.Item("id_usuario") = "cetir.carga"
							
								'Modificació JGM 16/08/2010 . Error en accés a informes CETIR.
								
								ls_pers_key_aux = Cstr(objRow.Item("pers_key_cetir"))
								
								if ls_pers_key_aux > 0
         							ls_pers_key = ls_pers_key_aux
								else
									ls_pers_key = Cstr(Session("pers_key"))
								end if
							
								'ls_pers_key = Cstr(Session("pers_key"))
								'Fi Modificació JGM 16/08/2010
								
								ls_epis_key = Cstr(objRow.Item("episcode"))
								
								service.GetIDEpisodiCGM(ls_pers_key, ls_epis_key, li_id_episodio_CETIR, True)
								'response.write (cstr(li_id_episodio_CETIR))
								
								if li_id_episodio_CETIR > 0 then
								
								Try

								ls_retorno = service.GetDICOMEstudisUID(li_id_episodio_CETIR, True)
								
								Catch 
								
									li_id_episodio_CETIR = 0

								End Try
							end if
									
							end if
							%>
						
							<TR>
								<TD colspan="2" class="letra_pequena_negrita">
								<% 
								if li_id_episodio_CETIR > 0 then
								
								if ls_retorno.Length > 0 then
								
								
								'response.write (ls_retorno(0))'(ls_retorno.Length)'(cstr(UBound(ls_retorno)))
								
								for a = 0 to UBound(ls_retorno)
										
									'if trim(left(ls_retorno(a),1)) <> "/" then
									
										%>
										<IMG alt="" src="../imagenes/placa.jpg" onclick="javascript:abrir_visor('<% =Cstr(li_id_episodio_CETIR) %>','<% =ls_retorno(a) %>');" style="CURSOR: hand">&nbsp;&nbsp;
										<%
										response.write (ls_retorno(a))
										
									'end if
									
								next
								
								end if
								
								end if
								%>
								<IMG alt="" src="../imagenes/acrobat.gif" onclick="javascript:abrir_informe('<% =objRow.Item("episcode") %>',<% =objRow.Item("numero") %>,'<% =objRow.Item("nombre") %>');" style="CURSOR: hand">&nbsp;&nbsp;&nbsp;Número:&nbsp;<% =objRow.Item("numero") %>&nbsp;Autor:&nbsp;<% =objRow.Item("id_usuario") %>&nbsp;Fecha:&nbsp;<% =objRow.Item("fecha") %>&nbsp;Agenda:&nbsp;<% =objRow.Item("agenname") %></TD>
								<TD class="letra_pequena_negrita" style="CURSOR: hand" align="right"><asp:label id="Label11" runat="server" Height="18" Visible="False" CssClass="informe_entregado"
										Width="175px">Informe Entregado</asp:label></TD>
							</TR>
							<TR height="11">
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						
						<%
								
								next
							
								end if
								
							%>
						</TABLE>
					</TD>
					<TD></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD align="center" height="11"><INPUT style="WIDTH: 150px" onclick="javascript:window.close();" type="button" value="Cerrar">
					</TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
