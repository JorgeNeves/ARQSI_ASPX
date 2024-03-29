﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeGestor.aspx.cs" Inherits="EnviarMAILS.HomeGestor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 105px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 105px;
            text-align: center;
            height: 58px;
        }
        .auto-style4 {
            width: 152px;
            text-align: center;
        }
        .auto-style5 {
            width: 152px;
        }
        .auto-style6 {
            width: 152px;
            text-align: center;
            height: 58px;
        }
        .auto-style7 {
            text-align: center;
            height: 58px;
        }
        .auto-style8 {
            width: 152px;
            height: 30px;
        }
        .auto-style9 {
            width: 105px;
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style11 {
            height: 28px;
            width: 97px;
            text-align: left;
        }
        .auto-style12 {
            width: 152px;
            height: 28px;
        }
        .auto-style13 {
            width: 105px;
            height: 28px;
        }
        .auto-style14 {
            height: 28px;
        }
        .auto-style15 {
            width: 97px;
            height: 30px;
            text-align: left;
        }
        .auto-style17 {
            width: 97px;
            text-align: left;
        }
        .auto-style18 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style3" colspan="2">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" DataKeyNames="IdProduto" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="329px">
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
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                </td>
                <td class="auto-style11">Nome Produto</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txNome" runat="server" Width="169px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txNome" Display="Dynamic" ErrorMessage="Nome produto necessário" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style8">
                </td>
                <td class="auto-style15">Preço</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txPreco" runat="server" Width="75px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txPreco" Display="Dynamic" ErrorMessage="Insira um valor numerico" ForeColor="Red" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txPreco" Display="Dynamic" ErrorMessage="Preço necessário" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btInserir" runat="server" OnClick="btInserir_Click" Text="Inserir" />
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style15">Quantidade</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txQuantidade" runat="server" Width="77px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txQuantidade" Display="Dynamic" ErrorMessage="Insira um numero inteiro" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txQuantidade" Display="Dynamic" ErrorMessage="Quantidade necessária" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Alterar" />
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style17">Genero</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txGenero" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txGenero" Display="Dynamic" ErrorMessage="Genero necessário" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remover" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style15">Edicao</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txEdicao" runat="server" Width="79px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txEdicao" ErrorMessage="Edição necessária" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Utilizador logado:<asp:Label ID="lbuser" runat="server"></asp:Label>
                    <br />
&nbsp;<asp:Button ID="btlogout" runat="server" OnClick="btlogout_Click" Text="Logout" />
                </td>
                <td class="auto-style1" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style18" ForeColor="Red" Width="272px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
