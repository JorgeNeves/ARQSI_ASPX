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
            width: 107px;
            text-align: center;
        }
        .auto-style5 {
            width: 107px;
        }
        .auto-style6 {
            width: 107px;
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
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="IdProduto" DataSourceID="dbLoja" style="margin-left: 0px">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="IdProduto" HeaderText="IdProduto" InsertVisible="False" ReadOnly="True" SortExpression="IdProduto" />
                            <asp:BoundField DataField="Preço" HeaderText="Preço" SortExpression="Preço" />
                            <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                            <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                            <asp:BoundField DataField="Ediçao" HeaderText="Ediçao" SortExpression="Ediçao" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="dbLoja" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ARQSI056ConnectionString %>" DeleteCommand="DELETE FROM [Produto] WHERE [IdProduto] = @original_IdProduto AND (([Preço] = @original_Preço) OR ([Preço] IS NULL AND @original_Preço IS NULL)) AND (([Quantidade] = @original_Quantidade) OR ([Quantidade] IS NULL AND @original_Quantidade IS NULL)) AND (([Nome] = @original_Nome) OR ([Nome] IS NULL AND @original_Nome IS NULL)) AND (([Genero] = @original_Genero) OR ([Genero] IS NULL AND @original_Genero IS NULL)) AND (([Ediçao] = @original_Ediçao) OR ([Ediçao] IS NULL AND @original_Ediçao IS NULL))" InsertCommand="INSERT INTO [Produto] ([Preço], [Quantidade], [Nome], [Genero], [Ediçao]) VALUES (@Preço, @Quantidade, @Nome, @Genero, @Ediçao)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Produto]" UpdateCommand="UPDATE [Produto] SET [Preço] = @Preço, [Quantidade] = @Quantidade, [Nome] = @Nome, [Genero] = @Genero, [Ediçao] = @Ediçao WHERE [IdProduto] = @original_IdProduto AND (([Preço] = @original_Preço) OR ([Preço] IS NULL AND @original_Preço IS NULL)) AND (([Quantidade] = @original_Quantidade) OR ([Quantidade] IS NULL AND @original_Quantidade IS NULL)) AND (([Nome] = @original_Nome) OR ([Nome] IS NULL AND @original_Nome IS NULL)) AND (([Genero] = @original_Genero) OR ([Genero] IS NULL AND @original_Genero IS NULL)) AND (([Ediçao] = @original_Ediçao) OR ([Ediçao] IS NULL AND @original_Ediçao IS NULL))">
                        <DeleteParameters>
                            <asp:Parameter Name="original_IdProduto" Type="Int32" />
                            <asp:Parameter Name="original_Preço" Type="Single" />
                            <asp:Parameter Name="original_Quantidade" Type="Int32" />
                            <asp:Parameter Name="original_Nome" Type="String" />
                            <asp:Parameter Name="original_Genero" Type="String" />
                            <asp:Parameter Name="original_Ediçao" Type="String" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Preço" Type="Single" />
                            <asp:Parameter Name="Quantidade" Type="Int32" />
                            <asp:Parameter Name="Nome" Type="String" />
                            <asp:Parameter Name="Genero" Type="String" />
                            <asp:Parameter Name="Ediçao" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Preço" Type="Single" />
                            <asp:Parameter Name="Quantidade" Type="Int32" />
                            <asp:Parameter Name="Nome" Type="String" />
                            <asp:Parameter Name="Genero" Type="String" />
                            <asp:Parameter Name="Ediçao" Type="String" />
                            <asp:Parameter Name="original_IdProduto" Type="Int32" />
                            <asp:Parameter Name="original_Preço" Type="Single" />
                            <asp:Parameter Name="original_Quantidade" Type="Int32" />
                            <asp:Parameter Name="original_Nome" Type="String" />
                            <asp:Parameter Name="original_Genero" Type="String" />
                            <asp:Parameter Name="original_Ediçao" Type="String" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
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
