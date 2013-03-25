<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_mantenimiento_documentos.aspx.vb" Inherits="zeus.form_mantenimiento_documentos"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_usuarios</title>
		<SCRIPT language="VB" runat="server">
		' Subrutina per carregar el arxiu en la carpeta corresponent.
		Sub DoUpload(Sender As Object, e As System.EventArgs)
	
			Dim sPath As String
			Dim sFile As String
			Dim sFullPath As String
			Dim sSplit() As String
			Dim sPathsubir As String
			
			sPath = Server.MapPath(".")
			If Right(sPath, 1) <> "\" Then 
				sPathsubir = sPath	'Carpeta a subir
				sPath = sPath & "\"
			Else
				sPathsubir = Left(sPath, Len(sPath) - 1)
			End If
			sFile = file.PostedFile.FileName
			sSplit = Split(sFile, "\")
			sFile = sSplit(UBound(sSplit))
			sPath = "C:\CIMAWEB\documentos\"
			sFullPath = sPath & sFile
			
			Try
				file.PostedFile.SaveAs(sFullPath)
				lblResults.CssClass = "letra_muy_pequena_azul_negrita"				
				lblResults.Text = "El documento " & sFile & " subió correctamente."
				Catch Ex As Exception
				lblResults.CssClass = "letra_muy_pequena_rojo_negrita"			
				lblResults.Text = "El documento " & sFile & " no pudo subirse al servidor por la siguiente razón: " & Ex.Message
				Finally
					lblResults.Font.Bold = True
					lblResults.Visible = True
			End Try
		
		End Sub
		</SCRIPT>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" href="../css/cima.css">
		<script src="../js/cima.js"></script>
		<script type="text/javascript">
		if (control=='S'){
			recarga.submit();
		}
		function eliminar(clave,linea){
		if (confirm("¿Está usted seguro de eliminar este documento asociado?")==1)
		{
			elimina.modo_borrado.value="S";
			elimina.agenproc_key.value=clave;
			elimina.line.value=linea;
			
			elimina.submit();
		}
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form method="post" name="elimina">
			<input type="hidden" name="modo_borrado"> <input type="hidden" name="agenproc_key">
			<input type="hidden" name="line"> <input 
value='<% =Request("DropDownList1") %>' type=hidden name=DropDownList1>
		</form>
		<form method="post" name="recarga">
			<input 
value='<% =Request("DropDownList1") %>' type=hidden name=DropDownList1>
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE style="Z-INDEX: 101; POSITION: absolute; WIDTH: 100%; TOP: 11px; LEFT: 11px" id="Table1"
				border="0" cellSpacing="0" cellPadding="0" width="100%">
				<TR>
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22" colSpan="3">Mantenimiento 
						de Documentos por Prestación</TD>
					<TD style="HEIGHT: 22px" class="cabecera_formulario" height="22"></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="3"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD height="30"><asp:label id="Label1" runat="server" CssClass="letra_pequena">Prestación: </asp:label><asp:dropdownlist id=Dropdownlist1 runat="server" CssClass="letra_pequena" AutoPostBack="True" DataSource="<%# Ds_agenproc1 %>" DataMember="agenproc" DataTextField="agenprocdesc" DataValueField="agenproc_key">
						</asp:dropdownlist>&nbsp;&nbsp;
						<asp:button id="Button2" runat="server" Visible="False" Width="120px" Text="Nuevo"></asp:button></TD>
					<td></td>
					<td></td>
					<TD></TD>
				</TR>
				<TR>
					<TD height="22" vAlign="top" colSpan="3"></TD>
					<TD height="22" vAlign="top"></TD>
				</TR>
				<TR>
					<TD vAlign="top" colSpan="3">
						<TABLE id="Table3" border="0" cellSpacing="0" cellPadding="0" width="100%">
							<TR>
								<TD width="100%"><asp:datalist id=DataList1 runat="server" DataSource="<%# Ds_agenproc1 %>" DataMember="agenproc" Width="100%" Font-Names="Verdana" Font-Size="7pt" BorderWidth="1px" GridLines="Both" CellPadding="4" BackColor="White" BorderStyle="None" BorderColor="Black" DataKeyField="agenproc_key">
										<SelectedItemStyle Font-Bold="True"></SelectedItemStyle>
										<HeaderTemplate>
											Prestación&nbsp;
										</HeaderTemplate>
										<ItemStyle Font-Size="7pt" Font-Names="Verdana" ForeColor="Black" BackColor="White"></ItemStyle>
										<ItemTemplate>
											<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TR height="11">
													<TD></TD>
													<TD></TD>
													<TD width="11"></TD>
													<TD></TD>
													<TD></TD>
												</TR>
												<TR>
													<TD class="letra_pequena">ID Prestación:&nbsp; &nbsp;
													</TD>
													<TD>
														<P>
															<asp:TextBox id=id_procedimiento runat="server" Text='<%# DataBinder.Eval(Ds_agenproc1, "Tables[agenproc].DefaultView.[0].agenproccode") %>' Enabled="False">
															</asp:TextBox></P>
													</TD>
													<TD width="11"></TD>
													<TD></TD>
													<TD></TD>
												</TR>
												<TR height="11">
													<TD></TD>
													<TD></TD>
													<TD width="11"></TD>
													<TD></TD>
													<TD></TD>
												</TR>
												<TR height="11">
													<TD class="letra_pequena">Descripción:</TD>
													<TD colSpan="4">
														<asp:Label id=descripcion runat="server" CssClass="letra_pequena_negrita" Width="350px" Text='<%# DataBinder.Eval(Ds_agenproc1, "Tables[agenproc].DefaultView.[0].agenprocdesc") %>'>
														</asp:Label></TD>
												</TR>
											</TABLE>
										</ItemTemplate>
										<HeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
									</asp:datalist></TD>
							</TR>
							<TR>
								<TD height="11"></TD>
							</TR>
						</TABLE>
					</TD>
					<TD height="11" vAlign="top" align="right"><asp:button id="Button1" runat="server" Visible="False" Width="120px" Text="Actualizar"></asp:button></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="4"><asp:panel id="Panel1" runat="server" Visible="False">
							<TABLE id="Table4" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD style="HEIGHT: 32px" class="letra_pequena" width="200">Tipo de Documento:
										<asp:dropdownlist id="DropDownList2" runat="server" CssClass="letra_pequena" Width="100px">
											<asp:ListItem Value="1">Word</asp:ListItem>
											<asp:ListItem Value="2">Excel</asp:ListItem>
											<asp:ListItem Value="3">PDF</asp:ListItem>
										</asp:dropdownlist></TD>
									<TD style="HEIGHT: 32px" width="11"></TD>
									<TD style="HEIGHT: 32px" class="letra_pequena">Descripción:
										<asp:textbox id="TextBox1" runat="server" CssClass="letra_pequena" Width="300px"></asp:textbox></TD>
									<TD style="HEIGHT: 32px" align="right"></TD>
									<TD style="HEIGHT: 32px" align="right">
										<asp:button id="Button3" onclick="DoUpload" runat="server" Text="Añadir" Width="120px"></asp:button></TD>
								</TR>
								<TR>
									<TD class="letra_pequena" height="11" width="200" colSpan="5"></TD>
								</TR>
								<TR>
									<TD class="letra_pequena" height="11" colSpan="5">
										<TABLE id="Table7" border="0" cellSpacing="0" cellPadding="0" width="100%">
											<TR>
												<TD><INPUT style="WIDTH: 550px" id="file" type="file" name="file" runat="server"></TD>
												<TD width="11"></TD>
												<TD align="right">
													<asp:CheckBox id="CheckBox1" runat="server" CssClass="letra_pequena" Text="Enviable por e-mail"
														TextAlign="Left"></asp:CheckBox></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD height="11" colSpan="4"><asp:panel id="Panel2" runat="server" Visible="False">
							<TABLE id="Table6" border="0" cellSpacing="0" cellPadding="0" width="100%">
								<TR>
									<TD height="11" colSpan="4"></TD>
								</TR>
								<TR>
									<TD class="cabecera_busca_pacientes" height="11" colSpan="4">Documentos asociados</TD>
								</TR>
								<TR>
									<TD height="11"></TD>
									<TD height="11"></TD>
									<TD height="11"></TD>
									<TD height="11"></TD>
								</TR>
								<TR>
									<TD colSpan="4"><%
					Dim str_menu as string
							
					Dim objCIMA as New CIMA_Clases.CIMA
					
					Dim objDS as New Data.DataSet
					
					Dim objRow as Data.DataRow
					
					Dim contador as integer
					
					Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
					
					if len(trim(Session("DropDownList1"))) > 0 then
					
					str_menu = "dbo.SP_CIMACEX_RECUPERA_DOCUMENTOS " & Session("DropDownList1") & ""
	
					objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
					
					if objDS.Tables(0).Rows.Count > 0 then
					%>
										<TABLE style="WIDTH: 100%" id="Table5" border="0" cellSpacing="0" cellPadding="0" width="100%">
											<%
									
							for each objRow in objDS.Tables(0).Rows
							
							contador = contador + 1
							
							%>
											<TR style="CURSOR: hand">
												<TD 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% 
								select case objRow.Item(0)
									case 1
										response.write("<IMG alt="""" src=""../imagenes/word.gif"">")
									case 2
										response.write("<IMG alt="""" src=""../imagenes/excel.gif"">")
									case 3
										response.write("<IMG alt="""" src=""../imagenes/acrobat.gif"">")
								end select
								  %></TD>
												<TD class=letra_pequena_negrita 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow.Item(3) %></TD>
												<TD class=letra_pequena 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow.Item(1) %></TD>
												<TD class=letra_pequena 
                onclick="javascript:window.open('<% =objRow.Item(1) %>', '', 'height=550,width=800,top=' + (screen.height - 550) / 2 + ',left=' + (screen.width - 800) / 2 + ',screenX=x,screenY=y,scrollbars=no');"><% =objRow.Item(2) %></TD>
												<TD class="letra_pequena" align="right"></TD>
												<TD class="letra_pequena" align="right"><% 
                if objRow.Item(6) = "S" then
					Response.Write("Enviable por e-mail")
                else
					Response.Write("NO enviable por e-mail")
                end if
               %></TD>
												<TD height="11" colSpan="4" align="right"><INPUT style="WIDTH: 120px" class=letra_pequena onclick="javascript:eliminar(<% =objRow.Item(4) %>,<% =objRow.Item(5) %>)" value=Eliminar type=button></TD>
											</TR>
											<%
												
							next
							
							'Session("contador") = contador
							
							objRow = Nothing
							objDS = Nothing
							objCIMA = Nothing
							
							%>
										</TABLE>
										<%
					end if
					end if
					%>
									</TD>
								</TR>
								<TR>
									<TD class="letra_cursiva" height="11" colSpan="4"></TD>
								</TR>
								<TR>
									<TD class="letra_cursiva" height="11" colSpan="4">Para visualizar un documento haga 
										click sobre el mismo.</TD>
								</TR>
								<TR>
									<TD height="11" colSpan="3"></TD>
								</TR>
								<TR>
									<TD height="11" colSpan="3">
										<asp:Label id="lblResults" runat="server"></asp:Label></TD>
								</TR>
								<TR>
									<TD height="11" colSpan="3"></TD>
								</TR>
							</TABLE>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD height="11" width="125"></TD>
					<TD height="11" width="125"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
