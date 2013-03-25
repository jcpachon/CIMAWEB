<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_galeria.aspx.vb" Inherits="zeus.form_galeria"%>
<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Carga de Imágenes</title>
		<SCRIPT language="VB" runat="server">
	
	Sub DoUpload(Sender As Object, e As System.EventArgs)
	
		Dim sPath As String
		Dim sFile As String
		Dim sFullPath As String
		Dim sSplit() As String
		Dim sPathsubir As String
		
		sPath = Server.MapPath(".")
		If Right(sPath, 1) <> "\" Then 
					sPathsubir = sPath 'CArpeta a subir
					sPath = sPath & "\"
				Else
					sPathsubir = Left(sPath, Len(sPath) - 1)
				End If
		sFile = file1.PostedFile.FileName
		sSplit = Split(sFile, "\")
		sFile = sSplit(UBound(sSplit))
		sFullPath = sPath & sFile
		
		Try
			file1.PostedFile.SaveAs(sFullPath)
			
			' Grabar relación episodio imagen.
			
			F_Grabar(sFile)
			
			' Fin.
			lblResults.CssClass = "letra_muy_pequena_azul_negrita"
			lblResults.Text = "La imagen " & sFile & " to " & sPathsubir & " subió correctamente."
			Catch Ex As Exception
			lblResults.CssClass = "letra_muy_pequena_rojo_negrita"
			lblResults.Text = "La imagen " & sFile & " to " & sPathsubir & " no pudo subirse al servidor por la siguiente razón: " & Ex.Message
			Finally
						lblResults.Font.Bold = True
						lblResults.Visible = True
		End Try
		
	End Sub
	
		</SCRIPT>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/cima.css" rel="stylesheet">
		<script src="../js/cima.js"></script>
	</HEAD>
	<body>
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<script type="text/javascript">
	
	if (control=="1"){
		f_abre("http://raim.cimaclinic.com/raimserver/web/DirectRetrieve.aspx?AccessionNumber=<% =Session("epis") %>&Format=z100i0q30h.j12",700,1000,"");
	};
	
	function abrir_popup(url){
		f_abre("../galeria/form_visor.aspx?url=" + url,500,700,"");
	}
	
	function eliminar_imagen(id_galeria,id_usuario){
		eliminar.id_galeria.value=id_galeria;
		if (id_usuario == '<% =Session("usuario") %>'){
			eliminar.submit();
			//window.close();
			//window.showModalDialog("../galeria/form_galeria.aspx?episcode=<% =Session("episodio_origen") %>&id_galeria=" + id_galeria, "","dialogWidth=65;dialogHeight=45;")
			
		}
		else{
			alert("No se puede eliminar una imagen de la galería si el usuario no es el propietario.");
		};
		
	}
		</script>
		<form name="eliminar" method="post">
			<P><input type="hidden" name="id_galeria">
			</P>
		</form>
		<form id="Form1" encType="multipart/form-data" runat="server">
			<TABLE id="Table1" style="LEFT: 10px; TOP: 10px" cellSpacing="0" cellPadding="0" width="100%"
				border="0">
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">
						<asp:Label id="Label3" runat="server">Episodio:</asp:Label><asp:textbox id="memoria" runat="server" CssClass="letra_centrada" ReadOnly="True"></asp:textbox></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="22"></TD>
				</TR>
				<TR>
					<TD class="cabecera_formulario" colSpan="3" height="22">Galería&nbsp;de Imágenes</TD>
				</TR>
				<TR>
					<TD width="300" height="11"></TD>
					<TD height="11"></TD>
					<TD height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<%
						
						Dim str_menu as string
						'Dim str_menu_2 as string
						Dim objCIMA as New CIMA_Clases.CIMA
						'Dim objCIMA_3 as New CIMA_Clases.CIMA

						Dim objDS as New Data.DataSet
						'Dim objDS_2 as New Data.DataSet

						Dim objRow as Data.DataRow
						
						Dim contador as integer
						
						'Dim contador as Integer
						
						'Dim m,d as string
						
						Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
						
						str_menu = "dbo.SP_CIMACEX_RECUPERA_IMAGENES_EPISODIO '" & Session("epis") & "'"
						
						objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))

						objCIMA = nothing	
						
						contador = 0
						
						response.write("<TR>")
						
						for each objRow in objDS.Tables(0).Rows
							contador = contador + 1
						if contador > 3 then
							contador = 1
							response.write("</TR><TR>")
							response.write("<TD align=""center"" width=""33%"">")
						%>
						<!--
						Si aparece un </TABLE> por aquí, se ha de eliminar.
						-->
						<TABLE cellSpacing="0" cellPadding="1" width="100%" border="1">
							<tr class="fondo_formulario">
								<td style="CURSOR: hand" 
          onclick="javascript:eliminar_imagen(<% =objRow.Item(4) %>,'<% =objRow.Item(1) %>');" 
          align=center>Eliminar</td>
								<td align="right" height="11"><IMG style="CURSOR: hand" onclick="javascript:abrir_popup('<% =objRow.Item(0) %>');" src="lupa_pequena.gif" ></IMG></td>
							</tr>
							<tr>
								<td align="center" colSpan="2"><img height=150 
            src="<% =objRow.Item(0) %>" width=150 
        ></img></td>
							</tr>
							<tr>
								<td colSpan="2" height="11"></td>
							</tr>
							<tr class="fondo_formulario">
								<td><% =objRow.Item(1) %></td>
								<td><% =objRow.Item(2) %></td>
							</tr>
							<tr>
								<td colSpan="2" height="11"></td>
							</tr>
							<tr class="fondo_formulario">
								<td colSpan="2">Comentario:<% =" " & objRow.Item(3) %></td>
							</tr>
						</TABLE>
						<%
							response.write("</TD>")
						else
							response.write("<TD align=""center"" width=""33%"">")
						%>
						<TABLE cellSpacing="0" cellPadding="1" width="100%" border="1">
							<tr class="fondo_formulario">
								<td style="CURSOR: hand" 
          onclick="javascript:eliminar_imagen(<% =objRow.Item(4) %>,'<% =objRow.Item(1) %>');" 
          align=center>Eliminar</td>
								<td align="right" height="11"><IMG style="CURSOR: hand" onclick="javascript:abrir_popup('<% =objRow.Item(0) %>');" src="lupa_pequena.gif" ></IMG></td>
							</tr>
							<tr>
								<td align="center" colSpan="2"><img height=150 
            src="<% =objRow.Item(0) %>" width=150 
        ></img></td>
							</tr>
							<tr>
								<td colSpan="2" height="11"></td>
							</tr>
							<tr class="fondo_formulario">
								<td><% =objRow.Item(1) %></td>
								<td><% =objRow.Item(2) %></td>
							</tr>
							<tr>
								<td colSpan="2" height="11"></td>
							</tr>
							<tr class="fondo_formulario">
								<td colSpan="2">Comentario:<% =" " & objRow.Item(3) %></td>
							</tr>
						</TABLE>
						<%
							response.write("</TD>")
						end if
							
						next
							
						response.write("</TR>")
							
						%>
				<TR>
					<TD align="center" colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD align="center" colSpan="3" height="11"><asp:button id="Button2" runat="server" Text="RAIM Web" Width="150px" BackColor="#C0FFFF" Font-Bold="True"></asp:button></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:label id="Label2" runat="server" CssClass="letra_pequena_negrita">Imagen: </asp:label><INPUT id="File1" style="WIDTH: 500px; HEIGHT: 20px" type="file" size="62" name="file"
							runat="server">
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3"><asp:label id="Label1" runat="server" CssClass="letra_pequena_negrita">Comentario: </asp:label><asp:textbox id="TextBox1" runat="server" Width="500px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"><asp:button id="Button1" onclick="DoUpload" runat="server" Text="Subir Imagen" Width="150px"></asp:button></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
			</TABLE>
			</TD></TR></TABLE>
			<HR noShade>
			<asp:label id="lblResults" runat="server" Visible="False"></asp:label></form>
		</FORM>
	</body>
</HTML>
