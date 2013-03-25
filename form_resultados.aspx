<%@ Page Language="vb" AutoEventWireup="false" Codebehind="form_resultados.aspx.vb" Inherits="zeus.form_resultados" enableViewStateMac="True"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Consulta de Resultados ON-LINE</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="css/cima.css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form name="descarga">
			<input type="hidden" name="ok">
		</form>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px; HEIGHT: 100%"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD align="center" vAlign="middle">
						<!--TABLE id="Table2" cellSpacing="0" cellPadding="0" width="150" border="0">
							<TR>
								<TD align="center" bgColor="navy" onclick="javascript:descarga.ok.value='S';descarga.submit();"
									style="CURSOR: hand"><FONT color="#ffffff" class="letra" face="Verdana" size="3" style="FONT-WEIGHT: bold"><% '=Session("episcode") %></FONT></TD>
							</TR>
						</TABLE-->
					</TD>
				</TR>
			</TABLE>
		</form>
		<script type="text/javascript">
		descarga.ok.value="S";
		descarga.submit();
		//window.close();
		//alert("OK");
		</script>
	</body>
</HTML>
