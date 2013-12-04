<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeGestor.aspx.cs" Inherits="TrabARQSI.HomeGestor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 227px;
            text-align: center;
            height: 58px;
        }
        .auto-style4 {
            width: 180px;
            text-align: center;
        }
        .auto-style5 {
            width: 180px;
        }
        .auto-style6 {
            width: 180px;
            text-align: center;
            height: 58px;
        }
        .auto-style7 {
            text-align: center;
            height: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="btVisualizar" runat="server" Text="Visualizar" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btinserir" runat="server" style="text-align: center" Text="Inserir" Width="116px" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btatualizar" runat="server" Text="Atualizar" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btremover" runat="server" Text="Remover" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Utilizador logado:<asp:Label ID="lbuser" runat="server"></asp:Label>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
