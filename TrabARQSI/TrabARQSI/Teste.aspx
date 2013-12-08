﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="EnviarMAILS.Teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 92px;
        }
        .auto-style2 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">quantidade</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Saber Custo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">custo</td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Enviar produtos" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
