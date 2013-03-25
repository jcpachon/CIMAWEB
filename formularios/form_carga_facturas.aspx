<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_carga_facturas.aspx.vb" Inherits="cimaweb.form_carga_facturas"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_carga_facturas</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form name="borrar">
			<input type="hidden" name="borrar_ok">
			<input type="hidden" name="eliminar_ok">
			<input type="hidden" name="pericode">
			<input type="hidden" name="invsnumb">
		</form>
		<script type="text/javascript">
		
	function borrar_todas(){
	
	if (confirm("Se van a proceder a borrar todas las facturas cargadas. ¿Está usted seguro?")){
		
		//alert("OK. Usted mismo.");
		borrar.borrar_ok.value="S";
		borrar.submit();
		
		};
		//alert("dd");
	
	}
	
	function eliminar(pericode,invsnumb){
	
	if (confirm("Se van a proceder a borrar una factura. ¿Está usted seguro?")){
		
		borrar.eliminar_ok.value="S";
		borrar.pericode.value=pericode;
		borrar.invsnumb.value=invsnumb;
		borrar.submit();
		
		};
	
	}
	
		</script>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" id="Table1" border="0"
				cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD class="cabecera_formulario" height="22" colSpan="5">Carga Facturas</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="2">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="letra_pequena">Periodo:
									<asp:TextBox id="TextBox1" runat="server" CssClass="letra_pequena_centrada" Width="50px"></asp:TextBox>&nbsp;&nbsp; 
									Nº Factura:&nbsp;
									<asp:TextBox id="TextBox2" runat="server" CssClass="letra_pequena_centrada" Width="50px"></asp:TextBox>&nbsp;&nbsp; 
									Multicliente:
									<asp:DropDownList id="DropDownList1" runat="server" CssClass="letra_pequena" Width="100px">
										<asp:ListItem Value="N" Selected="True">NO</asp:ListItem>
										<asp:ListItem Value="S">SI</asp:ListItem>
									</asp:DropDownList></TD>
								<TD class="letra_pequena" align="right">
									<asp:Button id="Button1" runat="server" Width="150px" Text="Añadir"></asp:Button></TD>
							</TR>
							<TR>
								<TD class="letra_pequena" height="11"></TD>
								<TD class="letra_pequena" align="right" height="11"></TD>
							</TR>
							<TR>
								<TD class="letra_pequena"><INPUT style="WIDTH: 150px" type="button" value="Borrar Todas" onclick="javascript:borrar_todas();">
								&nbsp;&nbsp;&nbsp;Nº Facturas:&nbsp;<% =Me.Ds_cima_SNT_no_TIS1.cima_SNT_no_TIS.Rows.Count() %>
								</TD>
								<TD class="letra_pequena" align="right"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11" align="right" width="150"></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD class="fondo_cabecera_a" align="center">Periodo</TD>
								<TD class="fondo_cabecera_a" align="center">Nº Factura</TD>
								<TD class="fondo_cabecera_a" align="center">Multigarante</TD>
								<TD class="fondo_cabecera_a" align="center"></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
								<TD height="11"></TD>
							</TR>
							<%
							'Dim str_menu as string
													
							'Dim objCIMA as New CIMA_Clases.CIMA
							
							'Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							
							
							if Me.Ds_cima_SNT_no_TIS1.cima_SNT_no_TIS.Rows.Count > 0 then
							
							for each objRow in Me.Ds_cima_SNT_no_TIS1.cima_SNT_no_TIS.Rows
							
							%>
							<TR>
								<TD class="letra_pequena" align="center"><% =Cstr(objRow.Item("pericode")) %></TD>
								<TD class="letra_pequena" align="center"><% =Cstr(objRow.Item("invsnumb")) %></TD>
								<TD class="letra_pequena" align="center"><% =objRow.Item("multigarante") %></TD>
								<TD align="right" width="100"><INPUT style="WIDTH: 100px" type="button" value="Eliminar" onclick="javascript:eliminar(<% =Cstr(objRow.Item("pericode")) %>,<% =Cstr(objRow.Item("invsnumb")) %>);"></TD>
							</TR>
							<TR>
								<TD height="7" colspan="4"><HR width="100%" size="1">
								</TD>
							</TR>
							<%
							
							next
							
							end if
							
							%>
							<TR>
								<TD></TD>
								<TD></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="2" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
