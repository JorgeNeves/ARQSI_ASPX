<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeCliente.aspx.cs" Inherits="EnviarMAILS.HomeCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style9 {
            height: 32px;
        }
        .auto-style11 {
            height: 32px;
        }
        .auto-style18 {
            height: 231px;
        }
        .auto-style19 {
            height: 146px;
        }
        #iframe {
            width: 1118px;
            height: 177px;
        }
        .auto-style20 {
            margin-bottom: 0px;
        }
        .auto-style22 {
            margin-left: 40px;
        }
        .auto-style23 {
            margin-left: 40px;
            width: 485px;
        }
        .auto-style24 {
            height: 32px;
            width: 485px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 272px;">
            <tr>
                <td class="auto-style18" colspan="3">
                    <div class="auto-style19">
                        <iframe name="Stack" src="http://uvm056.dei.isep.ipp.pt/~uvm056/Trabalho1.html" onscroll="yes" id="iframe" scrolling="yes"  frameborder="2"></iframe>
            
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                                <asp:Button ID="btncarrinho" runat="server" style="margin-left: 24px" Text="Carrinho" Width="84px" OnClick="btncarrinho_Click" />
                                <asp:Button ID="btnencomendas" runat="server" Text="Menu Encomendas" Width="135px" CssClass="auto-style20" />
                                <asp:Button ID="btnComprar" runat="server" OnClick="btnComprar_Click" Text="MenuCompras" />
                                <asp:Button ID="btnlogout" runat="server" style="margin-left: 18px" Text="Logout" Width="89px" OnClick="btnlogout_Click" />
                            </td>
                <td></td>
                <td class="auto-style22">
                    </td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style24">Produtos Disponiveis:</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </td>
                <td>Sugestões<asp:GridView ID="gdvSugestao" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">Utilizador Logado:<asp:Label ID="lblusr" runat="server" Text="lblusr"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
