<%@ Register TagPrefix="uo_seguridad" TagName="uo_seguridad" Src="../user_objects/uo_seguridad.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_documentos.aspx.vb" Inherits="zeus.form_documentos"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>form_documentos</title>
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
				sPath = "C:\CIMAWEB_1\documentos_rel\"
				sFullPath = sPath & sFile
				
				Try
					file1.PostedFile.SaveAs(sFullPath)
					
					' Grabar relación episodio imagen.
					
					F_Grabar(sFile)
					
					' Fin.
					lblResults.CssClass = "letra_muy_pequena_azul_negrita"
					'lblResults.Text = "La imagen " & sFile & " to " & sPathsubir & " subió correctamente."
					lblResults.Text = "El documento " & sFile & " subió correctamente."
					Catch Ex As Exception
					lblResults.CssClass = "letra_muy_pequena_rojo_negrita"
					'lblResults.Text = "La imagen " & sFile & " to " & sPathsubir & " no pudo subirse al servidor por la siguiente razón: " & Ex.Message
					lblResults.Text = "El documento " & sFile & " no pudo subirse al servidor por la siguiente razón: " & Ex.Message
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
	<body MS_POSITIONING="GridLayout">
		<uo_seguridad:uo_seguridad id="uo_seguridad1" runat="server"></uo_seguridad:uo_seguridad>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD colSpan="3"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="450"><INPUT id="File1" style="WIDTH: 100%; HEIGHT: 20px" type="file" size="62" name="file" runat="server"></TD>
								<td width="11"></td>
								<TD align="right">
									<asp:dropdownlist id="DropDownList2" runat="server" Width="100px" CssClass="letra_pequena">
										<asp:ListItem Value="0">&lt;Sin tipo&gt;</asp:ListItem>
										<asp:ListItem Value="1">Word</asp:ListItem>
										<asp:ListItem Value="2">Excel</asp:ListItem>
										<asp:ListItem Value="3">PDF</asp:ListItem>
									</asp:dropdownlist></TD>
								<TD align="right"><asp:button id="Button1" runat="server" Text="Subir" Width="150px" OnClick="DoUpload"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11">
						<asp:Label id="lblResults" runat="server"></asp:Label></TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
				<TR>
					<TD colSpan="3">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD width="11" class="fondo_formulario_2" style="HEIGHT: 18px"></TD>
								<TD class="fondo_formulario_2" style="HEIGHT: 18px">Nombre</TD>
								<!--TD class="fondo_formulario_2" style="HEIGHT: 18px">Episodio</TD-->
								<TD class="fondo_formulario_2" style="HEIGHT: 18px">Usuario</TD>
							</TR>
							<%
									
							Dim str_menu as string
									
							Dim objCIMA as New CIMA_Clases.CIMA
							
							Dim objDS as New Data.DataSet
							
							Dim objRow as Data.DataRow
							
							Session("cadena_conexion")="workstation id=ZEUS;packet size=4096;user id=sa;data source=JUPITER;persist security info=True;initial catalog=CIMACEX;password=kampeon10"
							
							str_menu = "dbo.SP_CIMACEX_RECUPERA_DOCUMENTOS_REL " & Session("pers_key") & ""
			
							objDS = objCIMA.f_consulta(str_menu, Session("cadena_conexion"))
							
							if objDS.Tables(0).Rows.Count > 0 then
							
							for each objRow in objDS.Tables(0).Rows
							
							%>
							<TR>
								<TD width="22" height="11"></TD>
								<TD height="11"></TD>
								<!--TD height="11"></TD-->
								<TD height="11"></TD>
							</TR>
							<TR onclick='javascript:window.open("<% ="../documentos_rel/" &amp; objRow.Item(0) %>' screen.height  550) 2   screenX="x,screenY=y,scrollbars=no&quot;);'" left=" + (screen.width - 800) / 2 + " height="550",??,,+-(??,>
								<TD><% 
										select case objRow.Item(3)
											case 1
												response.write("<IMG alt="""" src=""../imagenes/word.gif"">")
											case 2
												response.write("<IMG alt="""" src=""../imagenes/excel.gif"">")
											case 3
												response.write("<IMG alt="""" src=""../imagenes/acrobat.gif"">")
										end select
										%></TD>
								<TD width="22" height="11"><% =objRow.Item(0) %></TD>
								<!--TD height="11"><% '=objRow.Item(1) %></TD-->
								<TD height="11"><% =objRow.Item(2) %></TD>
							</TR>
							<%
							
							next
							
							end if
							
							%>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="11"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
