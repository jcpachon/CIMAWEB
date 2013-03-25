<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_validacion_archivo.aspx.vb" Inherits="cimaweb.form_validacion_archivo"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_validacion_archivo</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form name="borrar">
			<input type="hidden" name="borrar_ok"> <input type="hidden" name="eliminar_ok"> <input type="hidden" name="pericode">
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
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="5" height="22">Validación / Archivo</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_pequena_negrita" height="11">Iniciar Validación:&nbsp;&nbsp;
						<asp:button id="Button1" runat="server" Text="Validar" Width="150px"></asp:button></TD>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_pequena_negrita" height="11"></TD>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_pequena_negrita" height="11"><asp:panel id="Panel1" runat="server" Visible="False"><asp:button id="Button2" runat="server" Text="Generar Archivo" Width="150px" BackColor="#8080FF"></asp:button>&nbsp;&nbsp; 
      Periodo: <asp:textbox id="TextBox1" runat="server" Width="50px" CssClass="letra_pequena_centrada"></asp:textbox>&nbsp;&nbsp; 
      Fecha Inicial: <asp:textbox id="TextBox2" runat="server" Width="100px" CssClass="letra_pequena_centrada"></asp:textbox>&nbsp;&nbsp; 
      Fecha Final: <asp:textbox id="TextBox3" runat="server" Width="100px" CssClass="letra_pequena_centrada"></asp:textbox></TD>
					</asp:panel></TD>
					<TD align="right" height="11"></TD>
				</TR>
				<TR>
					<TD height="22"></TD>
					<TD height="22"></TD>
				</TR>
				<TR>
					<TD class="fondo_pie_a" colSpan="2" height="11">Validación DU</TD>
				</TR>
				<TR>
					<TD colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD align="center" colSpan="2" height="11"><asp:datagrid id=DataGrid3 runat="server" Width="100%" BackColor="White" AutoGenerateColumns="False" Font-Names="Verdana" ForeColor="Black" PageSize="25" Font-Size="7pt" GridLines="Vertical" CellPadding="3" BorderWidth="1px" BorderStyle="Solid" BorderColor="#999999" DataMember="du" DataKeyField="invs_key" DataSource="<%# Ds_validacion_du1 %>">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="XX-Small"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="factura" SortExpression="factura" HeaderText="Factura">
									<HeaderStyle Width="70px"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="invsdate" SortExpression="invsdate" HeaderText="Fecha">
									<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="episcode" SortExpression="episcode" HeaderText="Episodio">
									<HeaderStyle HorizontalAlign="Center" Width="80px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="paciente" SortExpression="paciente" HeaderText="Paciente"></asp:BoundColumn>
								<asp:BoundColumn DataField="du" SortExpression="du" HeaderText="DU1"></asp:BoundColumn>
								<asp:BoundColumn DataField="longitud" SortExpression="longitud" HeaderText="Longitud">
									<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="nota" SortExpression="nota" HeaderText="DU2"></asp:BoundColumn>
								<asp:BoundColumn DataField="multigarante" SortExpression="multigarante" HeaderText="MG">
									<HeaderStyle HorizontalAlign="Center" Width="10px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="dc" SortExpression="dc" HeaderText="DC">
									<HeaderStyle HorizontalAlign="Center" Width="10px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD class="fondo_pie_a" vAlign="top" colSpan="2" height="11">Validación Nº Póliza</TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD align="center" colSpan="2" height="11"><asp:datagrid id=DataGrid1 runat="server" Width="100%" BackColor="White" AutoGenerateColumns="False" Font-Names="Verdana" ForeColor="Black" PageSize="25" Font-Size="7pt" GridLines="Vertical" CellPadding="3" BorderWidth="1px" BorderStyle="Solid" BorderColor="#999999" DataMember="poliza" DataKeyField="invsnumb" DataSource="<%# Ds_validacion_poliza1 %>">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="XX-Small"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="invsnumb" SortExpression="invsnumb" HeaderText="Factura">
									<HeaderStyle Width="70px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="episcode" SortExpression="episcode" HeaderText="Episodio">
									<HeaderStyle HorizontalAlign="Center" Width="80px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="paciente" SortExpression="paciente" HeaderText="Paciente"></asp:BoundColumn>
								<asp:BoundColumn DataField="poliza" SortExpression="poliza" HeaderText="P&#243;liza"></asp:BoundColumn>
								<asp:BoundColumn DataField="longitud" SortExpression="longitud" HeaderText="Longitud">
									<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="dc" SortExpression="dc" HeaderText="DC">
									<HeaderStyle HorizontalAlign="Center" Width="10px"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD class="fondo_pie_a" vAlign="top" colSpan="2" height="11">Validación Prestación</TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2"><asp:datagrid id=DataGrid2 runat="server" Width="100%" BackColor="White" AutoGenerateColumns="False" Font-Names="Verdana" ForeColor="Black" PageSize="25" Font-Size="7pt" GridLines="Vertical" CellPadding="3" BorderWidth="1px" BorderStyle="Solid" BorderColor="#999999" DataMember="v_producto" DataKeyField="factura" DataSource="<%# Ds_v_producto1 %>">
							<FooterStyle BackColor="#CCCCCC"></FooterStyle>
							<SelectedItemStyle ForeColor="White" BackColor="#000099"></SelectedItemStyle>
							<AlternatingItemStyle Font-Size="XX-Small" BackColor="#CCCCCC"></AlternatingItemStyle>
							<ItemStyle Font-Size="XX-Small"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="factura" SortExpression="factura" HeaderText="Factura"></asp:BoundColumn>
								<asp:BoundColumn DataField="linsprodcode" SortExpression="linsprodcode" HeaderText="C&#243;digo P"></asp:BoundColumn>
								<asp:BoundColumn DataField="linsproddesc" SortExpression="linsproddesc" HeaderText="P"></asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="2"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="2" height="11"></TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="2" height="11">Nota: La generación de archivo 
						sólo se activará una vez no se detecten errores en las validaciones.</TD>
				</TR>
				<TR>
					<TD class="letra_cursiva" colSpan="2" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
