<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CID.aspx.vb" Inherits="ListasPesquisa.consulta_cid" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<base target="_parent">
		<LINK href="cads.css" type="text/css" rel="stylesheet">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body onload="control()">
		<script language="javascript">
		function control(){
	if (document.all.controlador.value =='2'){
		document.all.Table1.style.display ='none'
	document.all.Table2.style.display ='block'
	document.all.descricao.checked 
	}
	else {
		document.all.Table1.style.display ='block'
	document.all.Table2.style.display ='none'
	document.all.capitulos.checked
	}
	}
	
	
	
	
		function doOk(Value)
		{
				window.returnValue=Value
				//document.all.txtcodigo_cid.value + ";" + document.all.txtdescricao_cid.value;
				window.close();
   
			}

			function doCancel()
			{
				// return a special known value if the user chooses cancel
				window.returnValue=-1; 
				window.close();
			}
			
			function doOK1()
		{
				window.returnValue=document.all.Hidden1.value + ";" + document.all.Hidden2.value;
				window.close();
   
			}

			function doCancel1()
			{
				// return a special known value if the user chooses cancel
				window.returnValue=-1; 
				window.close();
			}

			function ReturnValue(Valor) {
			    if (Valor != '') {
			        SepararItem(Valor)
			    }
			    window.close()
			}

			function SepararItem(String) {
			    var Item1 = window.opener.document.getElementById('NomeCid')
			    var Item2 = window.opener.document.getElementById('CodigoCid')
                
			    if (String != '') {
			        Item1.value = String.split(';')[1];
			        Item2.value = String.split(';')[0];
			    }
			}

		</script>
		<form id="Form1" method="post" runat="server">
			<TABLE class="tablesimples" id="tabela_opcoes" style="HEIGHT: 75px" cellSpacing="0" cellPadding="0"
				width="100%" border="0">
				<TR>
					<TD colSpan="3" style="HEIGHT: 49px"><FONT size="5"><STRONG><FONT size="6"><FONT size="4"> PESQUISA&nbsp;CID-10</FONT>
								</FONT></STRONG><INPUT id="controlador" type="hidden" name="Hidden3" runat="server">
                        tt<BR>
						</FONT>
					</TD>
				</TR>
				<TR>
					<TD colSpan="3" height="20"><FONT color="red" size="4">
							<FIELDSET><LEGEND style="FONT-SIZE: 8pt"><STRONG>Selecione o tipo de Pesquisa</STRONG></LEGEND>
								<TABLE id="Table3" style="FONT-SIZE: 8pt" cellSpacing="1" cellPadding="1" width="100%"
									bgColor="#ccffcc" border="0">
									<TR>
										<TD style="WIDTH: 22px"><INPUT id="capitulos" onclick="document.all.controlador.value='1';control()" type="radio"
												value="capitulos" name="pesquisa" runat="server"></TD>
										<TD><STRONG><FONT color="#000099">Pesquisa por Capítulos</FONT></STRONG></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 22px"><INPUT id="descricao" onclick="document.all.controlador.value='2';control()" type="radio"
												CHECKED value="descricao" name="pesquisa" runat="server"></TD>
										<TD>
											<P align="left"><STRONG><FONT color="#000099">Pesquisa por Código ou Descrição</FONT></STRONG>&nbsp;</P>
										</TD>
									</TR>
								</TABLE>
							</FIELDSET>
						</FONT>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0" class="tablesimples">
				<TR>
					<TD>
						<TABLE class="tablesimples" id="table_pesquisa_capitulo" style="HEIGHT: 204px" cellSpacing="0"
							cellPadding="0" width="100%" border="0">
							<TR>
								<TD></TD>
								<TD style="WIDTH: 347px"><STRONG>Capítulo:</STRONG></TD>
								<TD><STRONG>Agrupamento:</STRONG></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 36px"></TD>
								<TD style="WIDTH: 347px; HEIGHT: 36px"><asp:listbox id=LIST_CAPITULO runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_CAPITULO" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="CAPITULO_CODIGO" DataTextField="capitulo_descricao" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox><STRONG></STRONG></TD>
								<TD style="HEIGHT: 36px"><STRONG><asp:listbox id=LIST_AGRUPAMENTO runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_GRUPO" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="CG_CID_INICIAL" DataTextField="CG_DESCRICAO" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></STRONG></TD>
							</TR>
							<TR>
								<TD vAlign="bottom"></TD>
								<TD style="WIDTH: 347px" vAlign="bottom"><BR>
									<STRONG>Subgrupo:</STRONG></TD>
								<TD vAlign="bottom"><STRONG>Descrição:</STRONG></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD style="WIDTH: 347px"><asp:listbox id=list_cid_3 runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_3" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="cd_grupo_codigo" DataTextField="cd_grupo_descricao" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></TD>
								<TD><asp:listbox id=list_cid_4 runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_4" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="codigo_cid" DataTextField="descricao_cid" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD style="WIDTH: 347px"></TD>
								<TD vAlign="top"></TD>
							</TR>
						</TABLE>
						<TABLE class="tablesimples" id="table_resultados" style="HEIGHT: 141px" cellSpacing="0"
							cellPadding="0" width="100%" align="center" border="0">
							<TR>
								<TD style="WIDTH: 100px" vAlign="top">
									<P align="right"><FONT size="1">Código&nbsp;CID:</FONT></P>
								</TD>
								<TD vAlign="top">
									<P><asp:label id="numero_cid" runat="server" ForeColor="Red" Font-Bold="True"></asp:label></P>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px; HEIGHT: 3px" vAlign="top" colSpan="1" height="3" rowSpan="1"></TD>
								<TD vAlign="top" height="3" style="HEIGHT: 3px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px" vAlign="top">
									<P align="right"><FONT size="1">Capítulo:</FONT></P>
								</TD>
								<TD vAlign="top"><asp:label id="capitulo_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px" vAlign="top">
									<P align="right"><FONT size="1">Agrupamento:</FONT></P>
								</TD>
								<TD vAlign="top">
									<asp:label id="agrupamento_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px; HEIGHT: 13px" vAlign="top">
									<P align="right"><FONT size="1">Sub Grupo:</FONT></P>
								</TD>
								<TD vAlign="top" style="HEIGHT: 13px">
									<asp:label id="subgrupo_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px" vAlign="top">
									<P align="right"><FONT size="1">Descrição:</FONT></P>
								</TD>
								<TD vAlign="top">
									<asp:label id="descricao_cid" runat="server" Font-Bold="True" ForeColor="Black"></asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 100px" vAlign="top">
									<P align="right">
										&nbsp;</P>
									<P align="right"><BR>
										<BR>
										<BR>
										&nbsp;</P>
								</TD>
								<TD vAlign="top">
									<P>
										<TABLE id="table_OK" cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server">
											<TR>
												<TD>
													<P align="left"><BR>
														<INPUT class="botao" id="btnok1" style="WIDTH: 110px; HEIGHT: 22px" onclick="doOK1()" type="button"
															value="OK">&nbsp; <INPUT class="botao" id="btncancel1" style="WIDTH: 131px; HEIGHT: 22px" onclick="doCancel1()"
															type="button" value="Cancelar"></P>
												</TD>
											</TR>
										</TABLE>
									</P>
									<P align="left">
									</P>
									<INPUT type="hidden" id="Hidden1" name="Hidden1" runat="server"> <INPUT type="hidden" id="Hidden2" name="Hidden2" runat="server">
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" bgColor="whitesmoke" border="0">
				<TR>
					<TD>
						<TABLE id="tbllocalizar" style="HEIGHT: 63px" cellSpacing="0" cellPadding="0" width="100%"
							border="0" runat="server">
							<TR>
								<TD align="right" colSpan="1" height="25" rowSpan="1"></TD>
								<TD height="25" style="WIDTH: 416px"></TD>
								<TD height="25"></TD>
								<TD height="25"></TD>
							</TR>
							<TR>
								<TD align="right"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="Smaller">Código:</asp:label></TD>
								<TD style="WIDTH: 416px">
									<asp:TextBox id="txtcodigo_cid" runat="server" Width="228px" CssClass="textbox"></asp:TextBox></TD>
								<TD>
									<P align="left"><asp:button id="btnlocalizar" runat="server" Text="Buscar" CssClass="botao" BorderWidth="1px"></asp:button></P>
								</TD>
								<TD><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="XX-Small" ForeColor="Red"
										Visible="False">Este cid não existe!</asp:label></TD>
							</TR>
							<TR>
								<TD align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="Smaller">Descrição:</asp:label></TD>
								<TD style="WIDTH: 416px"><asp:textbox id="txtdescricao_cid" runat="server" Font-Names="Verdana" BorderWidth="1px" Width="435px"
										Font-Size="Smaller" MaxLength="50" CssClass="textbox"></asp:textbox></TD>
								<TD>
									<P align="left"><asp:button id="btnlocalizar_descricao_cid" runat="server" BorderWidth="1px" Text="Buscar" CssClass="botao"></asp:button></P>
								</TD>
								<TD><asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="XX-Small" ForeColor="Red"
										Visible="False">Este cid não existe!</asp:label></TD>
							</TR>
							<TR>
								<TD align="right"><asp:linkbutton id="LinkButton1" runat="server" Font-Names="Verdana" Font-Size="Smaller">Exibir todos</asp:linkbutton></TD>
								<TD style="WIDTH: 416px"></TD>
								<TD></TD>
								<TD></TD>
							</TR>
						</TABLE>
						<asp:datagrid id=DataGrid1 runat="server" Font-Names="Verdana" Width="100%" Font-Size="Smaller" PageSize="15" AllowPaging="True" AutoGenerateColumns="False" DataMember="CID_4" DataSource="<%# DataSet11 %>" OnPageIndexChanged="mydatagrid_page" AllowSorting="True" CssClass="grid" BorderWidth="1px" BorderColor="#E7E7FF" BorderStyle="None" BackColor="White" CellPadding="3" GridLines="Horizontal">
							<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" ForeColor="#4A3C8C" BorderColor="Transparent"
								BackColor="#E7E7FF"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
							<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
							<Columns>
								<asp:TemplateColumn HeaderText="Código CID">
                                    <EditItemTemplate>
                                        <asp:TextBox runat="server" 
                                            Text='<%# DataBinder.Eval(Container, "DataItem.codigo_cid") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="LabelCodigoCid" runat="server" 
                                            Text='<%# DataBinder.Eval(Container, "DataItem.codigo_cid") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
								<asp:TemplateColumn SortExpression="descricao_cid" HeaderText="Descri&#231;&#227;o do CID">
									<ItemTemplate>
										<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.descricao_cid") %>' NavigateUrl="<%# &quot;javascript:doOk('&quot; &amp; DataBinder.Eval(Container, &quot;DataItem.codigo_cid&quot;) &amp; &quot;;&quot; &amp; DataBinder.Eval(Container, &quot;DataItem.descricao_cid&quot;) &amp; &quot;')&quot; %>">
										</asp:HyperLink>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.descricao_cid") %>'>
										</asp:TextBox>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn Visible="False">
									<ItemTemplate>
										<A style="CURSOR: hand; COLOR: blue" onclick='doOk("<%# DataBinder.Eval(Container, "DataItem.codigo_cid") + ";" + DataBinder.Eval(Container, "DataItem.descricao_cid")%>")'>
											Selecionar...</A>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
						</asp:datagrid><BR>
					</TD>
				</TR>
			</TABLE>
			<BR>
			<TABLE id="Tableok" style="HEIGHT: 45px" cellSpacing="0" cellPadding="0" width="100%" bgColor="whitesmoke"
				border="0" runat="server">
				<TR>
					<TD>
						<P align="center">&nbsp; <INPUT id="btnCancel" style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; FONT-SIZE: 10px; BORDER-LEFT: 1px solid; WIDTH: 82px; BORDER-BOTTOM: 1px solid; FONT-FAMILY: Verdana; HEIGHT: 24px"
								onclick="doCancel()" type="button" value="Voltar" name="btnCancel"></P>
					</TD>
				</TR>
			</TABLE>
			<P></P>
		</form>
	</body>
</HTML>
