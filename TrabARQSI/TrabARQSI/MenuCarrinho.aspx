<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuCarrinho.aspx.cs" Inherits="EnviarMAILS.MenuCarrinho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 91px;
        }
        .auto-style3 {
            width: 163px;
        }
        .auto-style4 {
            width: 117px;
        }
        .auto-style5 {
        }
        .auto-style7 {
            height: 91px;
            width: 105px;
        }
        .auto-style9 {
            width: 444px;
        }
        .auto-style10 {
            height: 91px;
            width: 444px;
        }
        .auto-style11 {
            width: 105px;
        }
        .auto-style12 {
            width: 163px;
            height: 21px;
        }
        .auto-style13 {
            width: 117px;
            height: 21px;
        }
        .auto-style14 {
            width: 137px;
            height: 21px;
        }
        .auto-style15 {
            height: 21px;
        }
        .auto-style16 {
            width: 141px;
        }
        .auto-style17 {
            height: 21px;
            width: 141px;
        }
    </style>
</head>
<body style="height: 325px">
    <form id="form1" runat="server">
    <div style="height: 252px">
    
        <table style="width: 100%; height: 176px;">
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style9">Carrinho:<asp:Label ID="lblVazio" runat="server" Text="Carrinho Vazio!" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style10">
                    <asp:GridView ID="GridViewCarrinho" runat="server" OnSelectedIndexChanged="GridViewCarrinho_SelectedIndexChanged" AutoGenerateSelectButton="True" Width="442px" AllowPaging="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label1" runat="server" Text="Operações:"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <table style="width:100%; height: 138px;">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnEncomenda" runat="server" OnClick="Button3_Click" Text="Fazer Encomenda" Width="186px" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnEliminarCarrinho" runat="server" Text="Novo Carrinho" Width="120px" OnClick="btnEliminarCarrinho_Click" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btninicial" runat="server" OnClick="btninicial_Click" Text="Pagina Inicial" />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="btnQuantidade" runat="server" Text="Editar Quantidade" Visible="False" Width="115px" OnClick="btnQuantidade_Click" />
                </td>
                <td>
                    <asp:Button ID="btnremoversel" runat="server" Height="26px" Text="Remover Selecionado" Visible="False" Width="149px" OnClick="btnremoversel_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lbldist" runat="server" Text="Escolher Distribuidora:" Visible="False"></asp:Label>
                    <asp:DropDownList ID="dropLogistica" runat="server" Visible="False" OnSelectedIndexChanged="DropDist_SelectedIndexChanged">
                        <asp:ListItem>LogisticaSA</asp:ListItem>
                        <asp:ListItem Value="ShippingAll"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblpreco" runat="server" Visible="False"></asp:Label>
                </td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14"></td>
                <td class="auto-style17">
                    <asp:Label ID="lblqntidade" runat="server" Text="Nova Quantidade:" Visible="False"></asp:Label>
                    <asp:TextBox ID="txtqtidade" runat="server" Visible="False" Width="29px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtqtidade" Display="Dynamic" ErrorMessage="Tem de inserir um numero inteiro" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                </td>
                <td class="auto-style15">
                    <asp:Button ID="btnconfirmar" runat="server" OnClick="btnconfirmar_Click" Text="Confirmar" Visible="False" Width="70px" />
                    <asp:Button ID="btncancelar" runat="server" OnClick="btncancelar_Click" Text="Cancelar" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnenc" runat="server" Text="Encomendar" Width="91px" Visible="False" />
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
