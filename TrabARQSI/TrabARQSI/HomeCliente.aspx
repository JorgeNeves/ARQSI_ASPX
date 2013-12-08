<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeCliente.aspx.cs" Inherits="TrabARQSI.HomeCliente" %>

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
            height: 14px;
            margin-left: 40px;
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
                <td class="auto-style22">
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
                <td class="auto-style9">Produtos Disponiveis:</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True">
                    </asp:GridView>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Utilizador Logado:<asp:Label ID="lblusr" runat="server" Text="lblusr"></asp:Label>
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
