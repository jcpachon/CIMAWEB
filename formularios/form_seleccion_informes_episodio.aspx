<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_seleccion_informes_episodio.aspx.vb" Inherits="zeus.form_seleccion_informes_episodio"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Selección Informes por Episodio</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
		<script type="text/javascript">
	
	function nuevo(){
	
        var winTop = (screen.height - 300) / 2;
        var winLeft = (screen.width - 600) / 2;
        window.showModalDialog("../formularios/form_seleccion_plantilla.aspx?usuario=<% =Session("usuario") %>&episodio=<% =Session("episo") %>", "","dialogWidth=40;dialogHeight=20;")
        //ventana=window.open('../formularios/form_seleccion_plantilla.aspx?usuario=" & Session("usuario") & "&episodio=" & Session("episcode") & "' , '', 'height=300,width=600,top=' + winTop + ',left=' + winLeft + ',screenX=' + winTop + ',screenY=' + winLeft + '');
        this.close();
	}
	
	function enviar_detalle(id_informe,cerrado, usuario, id_plantilla){
	
		var winTop = (screen.height - 768) / 2
		var winLeft = (screen.width - 1024) / 2
		
		if (cerrado == "N" && usuario.toUpperCase() == '<% =UCase(Session("usuario")) %>'){
		
			ventana=window.open("../informes/informe_basico.aspx?id_informe=" + id_informe + "&usuario=" + usuario + "&id_plantilla=" + id_plantilla , "", "height=768,width=1024,top=" + winTop + ",left=" + winLeft + ",screenX= " + winTop + ",screenY=" + winLeft + ", scrollbars=yes");
			this.close();
		
		}
		else if (cerrado == "N" && usuario.toUpperCase() != '<% =UCase(Session("usuario")) %>'){
			alert("Acceso no permitido. Unicamente el propietario del informe puede modificarlo");
		}
		else{
		
			ventana=window.open("../informes/informe_basico_display.aspx?id_informe=" + id_informe + "&id_plantilla=" + id_plantilla , "", "height=768,width=1024,top=" + winTop + ",left=" + winLeft + ",screenX= " + winTop + ",screenY=" + winLeft + ", scrollbars=yes");
			this.close();
			
		}	
		
	}
	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="fondo_pie" colSpan="3" height="11">Selección de Informes episodio:
						<asp:label id="Label1" runat="server">Label</asp:label></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="3" height="11">
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD class="letra_muy_pequena_azul_negrita" style="WIDTH: 374px">Título</TD>
								<TD class="letra_muy_pequena_azul_negrita">Propietario</TD>
								<TD class="letra_muy_pequena_azul_negrita">Cerrado</TD>
								<TD class="letra_muy_pequena_azul_negrita" width="100">Creación</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 374px" height="11"></TD>
								<TD align="center" height="11"></TD>
								<TD align="center" height="11"></TD>
								<TD align="center" height="11"></TD>
							</TR>
							<%
							
							Dim str_menu as string
							
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
								
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.SP_CIMACEX_RECUPERA_INFORMES_EPISODIO '" & Session("episo") & "'"
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
				
							for each objRow in objDS.Tables(0).Rows
							
							%>
							<TR onmouseover="javascript:this.className='letra_pequena_onMouseOver';" 
        onclick="javascript:enviar_detalle('<% =objRow.Item(4) %>','<% =objRow.Item(2) %>','<% =objRow.Item(1) %>',<% =objRow.Item(5) %>);"onmouseout="javascript:this.className='letra_onMouseOut';" 
        >
								<TD class="letra_pequena_negrita" style="WIDTH: 374px" align="left"><% =objRow.item(0) %></TD>
								<TD class="letra_pequena" align="center"><% =objRow.item(1) %></TD>
								<TD class="letra_pequena" align="center"><% =objRow.item(2) %></TD>
								<TD class="letra_pequena" align="center"><% =objRow.item(3) %></TD>
							</TR>
							<%
							
							next
							
							%>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="3" height="11">* Seleccione el informe a 
						visualizar. Podrá modificarlo siempre y cuando sea usted el propietario y no 
						esté cerrado.</TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" align="right" colSpan="3" height="11"><INPUT style="WIDTH: 150px" onclick="javascript:nuevo();" type="button" value="Nuevo"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" align="center" colSpan="3" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
