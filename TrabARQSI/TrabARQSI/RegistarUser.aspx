<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistarUser.aspx.cs" Inherits="TrabARQSI.RegistarUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 91px;
        }
        .auto-style2 {
            width: 91px;
            height: 42px;
        }
        .auto-style3 {
            height: 42px;
        }
        .auto-style4 {
            width: 144px;
        }
        .auto-style5 {
            height: 42px;
            width: 144px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
            width: 112px;
        }
        .auto-style8 {
            height: 23px;
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 232px">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Username:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblverificausername" runat="server" Text="Username Válido!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Confirmar Password:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
        </table>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnregistar" runat="server" Text="Registar" Width="98px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="98px" />
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
