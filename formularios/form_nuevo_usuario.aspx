<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_nuevo_usuario.aspx.vb" Inherits="cimaweb.form_nuevo_usuario"%>
<%@ Register TagPrefix="cc1" Namespace="WebControlCIMA.Buttons" Assembly="WebControlCIMA" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Datos del Usuario</title>
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
		function f_nif_bien_formado(source, arguments){
       
		//Obtiene valor inicial                
		var valor = document.all.nif.value;
    
		
		numero = valor.substr(0,valor.length-1);
		let = valor.substr(valor.length-1,1);
		numero = numero % 23;
		letra='TRWAGMYFPDXBNJZSQVHLCKET';
		letra=letra.substring(numero,numero+1);
  
		if (letra!=let && document.all.DropDownList4.options[document.all.DropDownList4.selectedIndex].value=="1   "){
    
			arguments.IsValid=false;
			return;
    
		};
    
		arguments.IsValid=true;

		}
		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="4" height="22">
						<asp:Label id="LBEncabezado" runat="server">Nuevo Usuario</asp:Label>
						<asp:Label id="aux_pers_key" runat="server" Visible="False">Label</asp:Label></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD class="fondo_formulario">Apellidos</TD>
					<TD class="fondo_formulario" vAlign="middle" align="left">Nombre</TD>
					<TD class="fondo_formulario">NIF</TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD height="11"><asp:dropdownlist id=DropDownList5 runat="server" DataMember="siaf" DataSource="<%# Ds_siaf1 %>" CssClass="letra_pequena" DataTextField="siafdesc" DataValueField="siafcode">
						</asp:dropdownlist></TD>
					<TD height="11"><asp:textbox id="apellido1" runat="server" CssClass="letra_pequena" Width="125px"></asp:textbox><asp:textbox id="apellido2" runat="server" CssClass="letra_pequena" Width="125px"></asp:textbox></TD>
					<TD height="11"><asp:textbox id="nombre" runat="server" CssClass="letra_pequena" Width="150px"></asp:textbox></TD>
					<TD height="11"><asp:dropdownlist id=DropDownList4 runat="server" DataMember="idenpers" DataSource="<%# Ds_idenpers1 %>" CssClass="letra_pequena" DataTextField="idenpersdesc" DataValueField="idenperscode">
						</asp:dropdownlist><asp:textbox id="nif" runat="server" CssClass="letra_pequena_centrada" Width="75px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
					<TD height="11">
						<asp:CustomValidator id="CustomValidator1" runat="server" CssClass="letra_pequena" ClientValidationFunction="f_nif_bien_formado"
							ControlToValidate="nif" ErrorMessage="NIF mal formado."></asp:CustomValidator></TD>
				</TR>
				<!--TR>
					<TD height="11"></TD>
					<TD colSpan="3" height="11">aaa</TD>
				</TR-->
				<TR>
					<TD colSpan="4" height="11">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD colSpan="6" height="11">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fondo_formulario">Sexo</TD>
											<TD class="fondo_formulario">Fecha de Nacimiento (dd/mm/aaaa)</TD>
										</TR>
										<TR>
											<TD colSpan="5" height="11"></TD>
										</TR>
										<TR>
											<TD width="200"><asp:dropdownlist id=DropDownList1 runat="server" DataMember="tsex" DataSource="<%# Ds_tsex1 %>" CssClass="letra_pequena" DataTextField="tsexdesc" DataValueField="tsexcode">
												</asp:dropdownlist></TD>
											<TD width="200"><asp:textbox id="fecha_nacimiento" runat="server" CssClass="letra_pequena_centrada" Width="75px"
													AutoPostBack="True"></asp:textbox><asp:textbox id="edad" runat="server" CssClass="letra_pequena_centrada" Width="25px" AutoPostBack="True"></asp:textbox><asp:dropdownlist id="DropDownList3" runat="server" CssClass="letra_pequena">
													<asp:ListItem Value="1" Selected="True">a&#241;os</asp:ListItem>
													<asp:ListItem Value="2">meses</asp:ListItem>
													<asp:ListItem Value="3">dias</asp:ListItem>
												</asp:dropdownlist></TD>
											<TD><asp:label id="Label1" runat="server" CssClass="letra_pequena" ForeColor="Red" Visible="False">Formato de fecha incorrecto.</asp:label></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD colSpan="6" height="11"></TD>
							</TR>
							<TR>
								<TD colSpan="6" height="11">
									<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD class="fondo_formulario">Teléfono</TD>
											<TD class="fondo_formulario">Móvil</TD>
											<TD class="fondo_formulario" width="11">&nbsp;</TD>
											<TD class="fondo_formulario" colSpan="2">Dirección</TD>
										</TR>
										<TR>
											<TD colSpan="3" height="11"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
										</TR>
										<TR>
											<TD width="100"><asp:textbox id="telefono" runat="server" CssClass="letra_pequena" Width="75px"></asp:textbox></TD>
											<TD class="letra_pequena">
												<asp:textbox id="movil" runat="server" CssClass="letra_pequena" Width="75px"></asp:textbox></TD>
											<TD class="letra_pequena"></TD>
											<TD class="letra_pequena" colSpan="2"><asp:dropdownlist id=DropDownList2 runat="server" DataMember="troa" DataSource="<%# Ds_troa1 %>" CssClass="letra_pequena" DataTextField="troaname" DataValueField="troacode">
												</asp:dropdownlist><asp:textbox id="direccion" runat="server" CssClass="letra_pequena" Width="200px"></asp:textbox>&nbsp;Nº:&nbsp; 
												&nbsp;
												<asp:textbox id="numero" runat="server" CssClass="letra_pequena" Width="50px"></asp:textbox>&nbsp;Piso:&nbsp; 
												&nbsp;
												<asp:textbox id="piso" runat="server" CssClass="letra_pequena" Width="25px"></asp:textbox>&nbsp;Puerta:&nbsp; 
												&nbsp;
												<asp:textbox id="puerta" runat="server" CssClass="letra_pequena" Width="25px"></asp:textbox>&nbsp;CP:&nbsp;
												<asp:textbox id="cp" runat="server" CssClass="letra_pequena" Width="50px"></asp:textbox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD colSpan="6" height="11"></TD>
							</TR>
							<TR>
								<TD height="11" colSpan="6">
									<TABLE id="Table6" border="0" cellSpacing="0" cellPadding="0" width="100%">
										<TR>
											<TD style="WIDTH: 203px; HEIGHT: 13px" class="fondo_formulario">País</TD>
											<TD style="HEIGHT: 13px" class="fondo_formulario" width="11">&nbsp;</TD>
											<TD style="WIDTH: 220px; HEIGHT: 13px" class="fondo_formulario">Provincia</TD>
											<TD style="HEIGHT: 13px" class="fondo_formulario" width="11">&nbsp;</TD>
											<TD style="HEIGHT: 13px" class="fondo_formulario" colSpan="2">Población</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 455px" height="11" colSpan="3"></TD>
											<TD height="11"></TD>
											<TD height="11"></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 203px" width="203"><asp:dropdownlist id=DropDownList6 runat="server" DataValueField="terr_key" DataTextField="terrdesc" DataSource="<%# Ds_terr1 %>" Width="200px" AutoPostBack="True">
												</asp:dropdownlist></TD>
											<TD class="letra_pequena"></TD>
											<TD style="WIDTH: 220px" class="letra_pequena"><asp:dropdownlist id=DropDownList7 runat="server" DataValueField="terr_key" DataTextField="terrdesc" DataSource="<%# Ds_terr2 %>" Width="230px" AutoPostBack="True">
												</asp:dropdownlist></TD>
											<TD class="letra_pequena"></TD>
											<TD class="letra_pequena" colSpan="2">&nbsp;
												<asp:dropdownlist id=DropDownList8 runat="server" DataValueField="terr_key" DataTextField="terrdesc" DataSource="<%# Ds_terr3 %>" Width="240px" AutoPostBack="True">
												</asp:dropdownlist></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD height="11" colSpan="6"></TD>
							</TR>
							<TR>
								<TD height="11" colSpan="6">
									<TABLE id="Table7" border="0" cellSpacing="0" cellPadding="0" width="100%">
										<TR>
											<TD class="fondo_formulario">E-mail</TD>
										</TR>
										<TR>
											<TD height="11" colSpan="3"></TD>
										</TR>
										<TR>
											<TD class="letra_pequena">
												<asp:TextBox id="email" runat="server" CssClass="letra_pequena" Width="424px"></asp:TextBox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="11" colSpan="4" align="right"></TD>
				</TR>
				<TR>
					<TD align="right" height="11"></TD>
					<TD align="right" colSpan="3" height="11">
						<cc1:ButtonEnviar id="Button1" runat="server" Width="150px" Text="Aceptar"></cc1:ButtonEnviar></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
