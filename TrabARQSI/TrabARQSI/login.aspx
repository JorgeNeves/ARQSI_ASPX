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
        .auto-style4 {
            width: 130px;
        }
        .auto-style5 {
            width: 116px;
        }
    </style>
</head>
<body style="height: 105px">
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
    
        <div>
            <div>
                <table style="width: 100%; height: 32px;">
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style4">
                            <asp:Button ID="btnsignin" runat="server" Height="24px" Text="Sign In" Width="116px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
