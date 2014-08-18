<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CID.aspx.vb" Inherits="ListasPesquisa.consulta_cid" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
<head>
    <title>WebForm1</title>
    <meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
    <meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <base target="_parent">
    <link href="cads.css" type="text/css" rel="stylesheet">
    <link href="Styles.css" type="text/css" rel="stylesheet">
</head>
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
            var opener = null;
            if (window.dialogArguments){
                opener = window.dialogArguments;
            }
            else{

            if (window.opener) {
                opener = window.opener;
            }
                
            }
            opener.returnValue = Value;
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

        //function ReturnValue(Valor) {
        //    if (Valor != '') {
        //        SepararItem(Valor)
        //    }
        //    window.close()
        //}

        //function SepararItem(String) {
        //    var Item1 = window.document.getElementById('NomeCid')
        //    var Item2 = window.document.getElementById('CodigoCid')

        //    if (String != '') {
        //        Item1.value = String.split(';')[1];
        //        Item2.value = String.split(';')[0];

        //    }
        //}

    </script>
    <form id="Form1" method="post" runat="server">
        <table class="tablesimples" id="tabela_opcoes" style="HEIGHT: 75px" cellspacing="0" cellpadding="0"
               width="100%" border="0">
            <tr>
                <td colspan="3" style="HEIGHT: 49px">
                    <font size="5">
                        <strong>
                            <font size="6">
                                <font size="4"> PESQUISA&nbsp;CID-10</font>
                            </font>
                        </strong><INPUT id="controlador" type="hidden" name="Hidden3" runat="server">
                        <br>
                    </font>
                </td>
            </tr>
            <tr>
                <td colspan="3" height="20">
                    <font color="red" size="4">
                        <fieldset>
                            <legend style="FONT-SIZE: 8pt"><strong>Selecione o tipo de Pesquisa</strong></legend>
                            <table id="Table3" style="FONT-SIZE: 8pt" cellspacing="1" cellpadding="1" width="100%"
                                   bgcolor="#ccffcc" border="0">
                                <tr>
                                    <td style="WIDTH: 22px">
                                        <INPUT id="capitulos" onclick="document.all.controlador.value='1';control()" type="radio"
                                               value="capitulos" name="pesquisa" runat="server">
                                    </td>
                                    <td><strong><font color="#000099">Pesquisa por Capítulos</font></strong></td>
                                </tr>
                                <tr>
                                    <td style="WIDTH: 22px">
                                        <INPUT id="descricao" onclick="document.all.controlador.value='2';control()" type="radio"
                                               CHECKED value="descricao" name="pesquisa" runat="server">
                                    </td>
                                    <td>
                                        <p align="left"><strong><font color="#000099">Pesquisa por Código ou Descrição</font></strong>&nbsp;</p>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </font>
                </td>
            </tr>
        </table>
        <table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0" class="tablesimples">
            <tr>
                <td>
                    <table class="tablesimples" id="table_pesquisa_capitulo" style="HEIGHT: 204px" cellspacing="0"
                           cellpadding="0" width="100%" border="0">
                        <tr>
                            <td></td>
                            <td style="WIDTH: 347px"><strong>Capítulo:</strong></td>
                            <td><strong>Agrupamento:</strong></td>
                        </tr>
                        <tr>
                            <td style="HEIGHT: 36px"></td>
                            <td style="WIDTH: 347px; HEIGHT: 36px"><asp:listbox id=LIST_CAPITULO runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_CAPITULO" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="CAPITULO_CODIGO" DataTextField="capitulo_descricao" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox><strong></strong></td>
                            <td style="HEIGHT: 36px"><strong><asp:listbox id=LIST_AGRUPAMENTO runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_GRUPO" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="CG_CID_INICIAL" DataTextField="CG_DESCRICAO" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></strong></td>
                        </tr>
                        <tr>
                            <td valign="bottom"></td>
                            <td style="WIDTH: 347px" valign="bottom">
                                <br>
                                <strong>Subgrupo:</strong>
                            </td>
                            <td valign="bottom"><strong>Descrição:</strong></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="WIDTH: 347px"><asp:listbox id=list_cid_3 runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_3" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="cd_grupo_codigo" DataTextField="cd_grupo_descricao" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></td>
                            <td><asp:listbox id=list_cid_4 runat="server" Font-Names="Verdana" Width="100%" Font-Size="XX-Small" DataMember="CID_4" DataSource="<%# DataSet11 %>" AutoPostBack="True" DataValueField="codigo_cid" DataTextField="descricao_cid" Rows="5" Font-Bold="True" ForeColor="MidnightBlue"></asp:listbox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td style="WIDTH: 347px"></td>
                            <td valign="top"></td>
                        </tr>
                    </table>
                    <table class="tablesimples" id="table_resultados" style="HEIGHT: 141px" cellspacing="0"
                           cellpadding="0" width="100%" align="center" border="0">
                        <tr>
                            <td style="WIDTH: 100px" valign="top">
                                <p align="right"><font size="1">Código&nbsp;CID:</font></p>
                            </td>
                            <td valign="top">
                                <p><asp:label id="numero_cid" runat="server" ForeColor="Red" Font-Bold="True"></asp:label></p>
                            </td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px; HEIGHT: 3px" valign="top" colspan="1" height="3" rowspan="1"></td>
                            <td valign="top" height="3" style="HEIGHT: 3px"></td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px" valign="top">
                                <p align="right"><font size="1">Capítulo:</font></p>
                            </td>
                            <td valign="top"><asp:label id="capitulo_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label></td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px" valign="top">
                                <p align="right"><font size="1">Agrupamento:</font></p>
                            </td>
                            <td valign="top">
                                <asp:label id="agrupamento_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px; HEIGHT: 13px" valign="top">
                                <p align="right"><font size="1">Sub Grupo:</font></p>
                            </td>
                            <td valign="top" style="HEIGHT: 13px">
                                <asp:label id="subgrupo_cid" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="RoyalBlue"></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px" valign="top">
                                <p align="right"><font size="1">Descrição:</font></p>
                            </td>
                            <td valign="top">
                                <asp:label id="descricao_cid" runat="server" Font-Bold="True" ForeColor="Black"></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td style="WIDTH: 100px" valign="top">
                                <p align="right">
                                    &nbsp;
                                </p>
                                <p align="right">
                                    <br>
                                    <br>
                                    <br>
                                    &nbsp;
                                </p>
                            </td>
                            <td valign="top">
                                <p>
                                    <TABLE id="table_OK" cellSpacing="0" cellPadding="0" width="100%" border="0" runat="server">
                                        <tr>
                                            <td>
                                <p align="left">
                                    <br>
                                    <input class="botao" id="btnok1" style="WIDTH: 110px; HEIGHT: 22px" onclick="doOK1()" type="button"
                                           value="OK">&nbsp; <input class="botao" id="btncancel1" style="WIDTH: 131px; HEIGHT: 22px" onclick="doCancel1()"
                                                                    type="button" value="Cancelar">
                                </p>
                            </td>
                        </tr>
                    </table>
                    </P>
                    <p align="left">
                    </p>
                    <INPUT type="hidden" id="Hidden1" name="Hidden1" runat="server"> <INPUT type="hidden" id="Hidden2" name="Hidden2" runat="server">
                </td>
            </tr>
        </table>
        </TD>
        </TR>
        </TABLE>
        <table id="Table2" cellspacing="0" cellpadding="0" width="100%" bgcolor="whitesmoke" border="0">
            <tr>
                <td>
                    <TABLE id="tbllocalizar" style="HEIGHT: 63px" cellSpacing="0" cellPadding="0" width="100%"
                           border="0" runat="server">
                        <tr>
                            <td align="right" colspan="1" height="25" rowspan="1"></td>
                            <td height="25" style="WIDTH: 416px"></td>
                            <td height="25"></td>
                            <td height="25"></td>
                        </tr>
                        <tr>
                            <td align="right"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="Smaller">Código:</asp:label></td>
                            <td style="WIDTH: 416px">
                                <asp:TextBox id="txtcodigo_cid" runat="server" Width="228px" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td>
                                <p align="left"><asp:button id="btnlocalizar" runat="server" Text="Buscar" CssClass="botao" BorderWidth="1px"></asp:button></p>
                            </td>
                            <td>
                                <asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="XX-Small" ForeColor="Red"
                                           Visible="False">Este cid não existe!</asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="Smaller">Descrição:</asp:label></td>
                            <td style="WIDTH: 416px">
                                <asp:textbox id="txtdescricao_cid" runat="server" Font-Names="Verdana" BorderWidth="1px" Width="435px"
                                             Font-Size="Smaller" MaxLength="50" CssClass="textbox"></asp:textbox>
                            </td>
                            <td>
                                <p align="left"><asp:button id="btnlocalizar_descricao_cid" runat="server" BorderWidth="1px" Text="Buscar" CssClass="botao"></asp:button></p>
                            </td>
                            <td>
                                <asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="XX-Small" ForeColor="Red"
                                           Visible="False">Este cid não existe!</asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right"><asp:linkbutton id="LinkButton1" runat="server" Font-Names="Verdana" Font-Size="Smaller">Exibir todos</asp:linkbutton></td>
                            <td style="WIDTH: 416px"></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </TABLE>
                    <asp:datagrid id=DataGrid1 runat="server" Font-Names="Verdana" Width="100%" Font-Size="Smaller" PageSize="15" AllowPaging="True" AutoGenerateColumns="False" DataMember="CID_4" DataSource="<%# DataSet11 %>" OnPageIndexChanged="mydatagrid_page" AllowSorting="True" CssClass="grid" BorderWidth="1px" BorderColor="#E7E7FF" BorderStyle="None" BackColor="White" CellPadding="3" GridLines="Horizontal">
                        <selecteditemstyle font-bold="True" forecolor="#F7F7F7" backcolor="#738A9C"></selecteditemstyle>
                        <alternatingitemstyle backcolor="#F7F7F7"></alternatingitemstyle>
                        <itemstyle font-size="XX-Small" font-names="Verdana" forecolor="#4A3C8C" bordercolor="Transparent"
                                   backcolor="#E7E7FF"></itemstyle>
                        <headerstyle font-bold="True" forecolor="#F7F7F7" backcolor="#4A3C8C"></headerstyle>
                        <footerstyle forecolor="#4A3C8C" backcolor="#B5C7DE"></footerstyle>
                        <columns>
                            <asp:templatecolumn headertext="Código CID">
                                <edititemtemplate>
                                    <asp:textbox runat="server"
                                                 text='<%# DataBinder.Eval(Container, "DataItem.codigo_cid") %>'></asp:textbox>
                                </edititemtemplate>
                                <itemtemplate>
                                    <asp:Label ID="LabelCodigoCid" runat="server"
                                               Text='<%# DataBinder.Eval(Container, "DataItem.codigo_cid") %>'></asp:Label>
                                </itemtemplate>
                            </asp:templatecolumn>
                            <asp:templatecolumn sortexpression="descricao_cid" headertext="Descri&#231;&#227;o do CID">
                                <itemtemplate>
                                    <asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.descricao_cid") %>' NavigateUrl="<%# &quot;javascript:doOk('&quot; &amp; DataBinder.Eval(Container, &quot;DataItem.codigo_cid&quot;) &amp; &quot;;&quot; &amp; DataBinder.Eval(Container, &quot;DataItem.descricao_cid&quot;) &amp; &quot;')&quot; %>">
                                    </asp:HyperLink>
                                </itemtemplate>
                                <edititemtemplate>
                                    <asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.descricao_cid") %>'>
                                    </asp:TextBox>
                                </edititemtemplate>
                            </asp:templatecolumn>
                            <asp:templatecolumn visible="False">
                                <itemtemplate>
                                    <a style="CURSOR: hand; COLOR: blue" onclick='doOk("<%# DataBinder.Eval(Container, "DataItem.codigo_cid") + ";" + DataBinder.Eval(Container, "DataItem.descricao_cid")%>")'>
                                        Selecionar...
                                    </a>
                                </itemtemplate>
                            </asp:templatecolumn>
                        </columns>
                        <pagerstyle horizontalalign="Right" forecolor="#4A3C8C" backcolor="#E7E7FF" mode="NumericPages"></pagerstyle>
                    </asp:datagrid><br>
                </td>
            </tr>
        </table>
        <br>
        <TABLE id="Tableok" style="HEIGHT: 45px" cellSpacing="0" cellPadding="0" width="100%" bgColor="whitesmoke"
               border="0" runat="server">
            <tr>
                <td>
                    <p align="center">
                        &nbsp; <input id="btnCancel" style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; FONT-SIZE: 10px; BORDER-LEFT: 1px solid; WIDTH: 82px; BORDER-BOTTOM: 1px solid; FONT-FAMILY: Verdana; HEIGHT: 24px"
                                      onclick="doCancel()" type="button" value="Voltar" name="btnCancel">
                    </p>
                </td>
            </tr>
        </TABLE>
        <p></p>
    </form>
</body>
</html>
