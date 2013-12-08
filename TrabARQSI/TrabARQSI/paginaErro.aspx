<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paginaErro.aspx.cs" Inherits="EnviarMAILS.paginaErro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 607px;
        }
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Pedimos desculpa pelo incomudo, em o sistema registou o seu pedido, <br />
        em breve o seu pedido será recolvido, volte a tentar mais tarde,
        <br />
        Obrigado.<br />
        <asp:Image ID="Image1" runat="server" CssClass="auto-style2" Height="417px" ImageUrl="~/Portal-em-manutenção.jpg" Width="927px" />
        </div>
    </form>
</body>
</html>
