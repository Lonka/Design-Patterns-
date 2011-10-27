<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPizza.aspx.cs" Inherits="DesignPatterns.FactoryPattern.OrderPizza" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    Area
    <asp:RadioButtonList ID="rdol_PizzaStory" runat="server">
        <asp:ListItem Value="PizzaStoryTW">PizzaStoryTW</asp:ListItem>
        <asp:ListItem Value="PizzaStoryNY">PizzaStoryNY</asp:ListItem>
    </asp:RadioButtonList>
    Flavors
    <asp:RadioButtonList ID="rdol_PizzaFlavors" runat="server">
        <asp:ListItem Value="GreekPizza">GreekPizza</asp:ListItem>
        <asp:ListItem Value="PepperoniPizza">PepperoniPizza</asp:ListItem>
    </asp:RadioButtonList>
        <asp:Button ID="btn_SimpleOrderPizza" runat="server" Text="點餐"  Enabled="false"
            onclick="btn_SimpleOrderPizza_Click" style="height: 21px" />

        <asp:Button ID="btn_OrderPizza" runat="server" onclick="btn_OrderPizza_Click" 
            Text="點餐" />

    </div>
    </form>
</body>
</html>
