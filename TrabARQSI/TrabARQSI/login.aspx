<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TrabARQSI.App_Code.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 114px;
        }
        .auto-style2 {
            width: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:39%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">User:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" ToolTip="Insira a password"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btLogin" runat="server" OnClick="btLogin_Click" Text="Login" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
