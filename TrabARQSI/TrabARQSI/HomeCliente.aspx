<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeCliente.aspx.cs" Inherits="TrabARQSI.HomeCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style8 {
            width: 178px;
            height: 32px;
        }
        .auto-style9 {
            height: 32px;
        }
        .auto-style11 {
            height: 32px;
        }
        .auto-style12 {
            width: 178px;
            height: 14px;
        }
        .auto-style13 {
            width: 125px;
            height: 14px;
        }
        .auto-style15 {
            height: 14px;
        }
        .auto-style16 {
            width: 225px;
            height: 14px;
        }
        .auto-style17 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 272px;">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Produtos Disponiveis:</td>
                <td class="auto-style9" colspan="2">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:SqlDataSource ID="Produtos" runat="server" ConnectionString="<%$ ConnectionStrings:ARQSI056ConnectionString %>" SelectCommand="SELECT [Preço], [Quantidade], [Nome], [Genero], [Ediçao], [ISBN] FROM [Produto]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="Produtos" Width="267px">
                        <Columns>
                            <asp:BoundField DataField="Preço" HeaderText="Preço" SortExpression="Preço" />
                            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                            <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                            <asp:BoundField DataField="Ediçao" HeaderText="Ediçao" SortExpression="Ediçao" />
                            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td class="auto-style9" colspan="2">
                    <table style="width: 100%; height: 112px;">
                        <tr>
                            <td class="auto-style17">&nbsp;</td>
                            <td>
                                <asp:Button ID="btncarrinho" runat="server" style="margin-left: 24px" Text="Carrinho" Width="84px" />
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
                                <asp:Button ID="btnlogout" runat="server" style="margin-left: 18px" Text="Logout" Width="89px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <asp:Label ID="Label1" runat="server" Text="Opções:"></asp:Label>
                    </table>
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Utilizador Logado:<asp:Label ID="lblusr" runat="server" Text="lblusr"></asp:Label>
                </td>
                <td class="auto-style9" colspan="2">
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
