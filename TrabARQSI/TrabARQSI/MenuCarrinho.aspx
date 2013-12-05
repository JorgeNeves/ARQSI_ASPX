<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuCarrinho.aspx.cs" Inherits="TrabARQSI.MenuCarrinho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 91px;
        }
    </style>
</head>
<body style="height: 275px">
    <form id="form1" runat="server">
    <div style="height: 214px">
    
        <table style="width: 100%; height: 176px;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">
                    <asp:GridView ID="GridViewCarrinho" runat="server" AutoGenerateSelectButton="True" DataSourceID="teste">
                    </asp:GridView>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
