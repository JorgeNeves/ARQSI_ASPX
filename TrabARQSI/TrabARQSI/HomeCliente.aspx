<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeCliente.aspx.cs" Inherits="TrabARQSI.HomeCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style9 {
            height: 32px;
        }
        .auto-style15 {
            height: 14px;
        }
        .auto-style17 {
            width: 100px;
        }
        .auto-style18 {
            width: 1179px;
            height: 164px;
        }
        .auto-style19 {
            height: 32px;
            width: 36px;
        }
        .auto-style20 {
            height: 18px;
            width: 36px;
        }
        .auto-style21 {
            height: 18px;
        }
        .auto-style22 {
            width: 92%;
            height: 272px;
        }
    </style>


</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style22">
            <tr>
                <td class="auto-style15" colspan="2">
                    <div>
                        <iframe name="Stack" src="http://uvm056.dei.isep.ipp.pt/~uvm056/Trabalho1.html" onscroll="yes" id="iframe" scrolling="yes"  frameborder="2" class="auto-style18"></iframe>
            
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">Produtos Disponiveis:</td>
                <td class="auto-style21">
                    </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Produtos">
                        <Columns>
                            <asp:BoundField DataField="Preço" HeaderText="Preço" SortExpression="Preço" />
                            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                            <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                            <asp:BoundField DataField="Ediçao" HeaderText="Ediçao" SortExpression="Ediçao" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="Produtos" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI056ConnectionString %>" SelectCommand="SELECT [Preço], [Quantidade], [Nome], [Genero], [Ediçao] FROM [Produto]"></asp:SqlDataSource>
                </td>
                <td class="auto-style9">
                    <table style="width: 100%; height: 112px;">
                        <tr>
                            <td class="auto-style17">&nbsp;</td>
                            <td>
                                <asp:Button ID="btncarrinho" runat="server" style="margin-left: 24px" Text="Carrinho" Width="84px" OnClick="btncarrinho_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnencomendas" runat="server" Text="Menu Encomendas" Width="135px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnlogout" runat="server" style="margin-left: 18px" Text="Logout" Width="89px" OnClick="btnlogout_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <asp:Label ID="Label1" runat="server" Text="Opções:"></asp:Label>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">Utilizador Logado:<asp:Label ID="lblusr" runat="server" Text="lblusr"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
