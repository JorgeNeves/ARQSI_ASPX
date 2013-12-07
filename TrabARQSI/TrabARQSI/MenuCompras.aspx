<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuCompras.aspx.cs" Inherits="TrabARQSI.MenuCompras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            height: 29px;
            width: 207px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            height: 29px;
            width: 241px;
        }
        .auto-style5 {
            width: 241px;
        }
        .auto-style7 {
            width: 173px;
        }
        .auto-style8 {
            width: 135px;
        }
        .auto-style9 {
            width: 204px;
        }
        .auto-style10 {
            width: 204px;
            height: 34px;
        }
        .auto-style11 {
            width: 173px;
            height: 34px;
        }
        .auto-style12 {
            width: 135px;
            height: 34px;
        }
        .auto-style13 {
            height: 34px;
        }
    </style>
</head>
<body style="height: 327px">
    <form id="form1" runat="server">
    <div style="height: 317px">
    
        <table style="width: 100%; height: 292px;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Login Como:"></asp:Label>
                    <asp:Label ID="lbluser" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Produtos Disponiveis:"></asp:Label>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateSelectButton="True">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style9">
                                <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Adicionar ao Carrinho" Width="194px" />
                            </td>
                            <td class="auto-style7">
                                <asp:Button ID="btncarrinho" runat="server" OnClick="btncarrinho_Click" Text="Consultar Carrinho" />
                            </td>
                            <td class="auto-style8">
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Voltar ao Menu Anterior" Width="148px" />
                            </td>
                            <td>
                                <asp:Button ID="Button5" runat="server" Text="Button" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Button" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <asp:Label ID="lblqtdd" runat="server" Text="Quantidade:" Visible="False"></asp:Label>
                                <asp:TextBox ID="txtqtdd" runat="server" Visible="False" Width="28px"></asp:TextBox>
                                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Visible="False" />
                                <asp:Button ID="btncancel" runat="server" style="margin-bottom: 0px" Text="Cancelar" Visible="False" Width="58px" />
                            </td>
                            <td class="auto-style11"></td>
                            <td class="auto-style12"></td>
                            <td class="auto-style13"></td>
                            <td class="auto-style13"></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
