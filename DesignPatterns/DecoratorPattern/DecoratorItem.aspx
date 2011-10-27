<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DecoratorItem.aspx.cs"
    Inherits="DesignPatterns.DecoratorPattern.DecoratorItem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    請選擇Beverage
                </td>
                <td>
                    <asp:RadioButtonList ID="rdol_Beverage" runat="server">
                        <asp:ListItem Text="HouseBlend(V:90 G:80 T:70)" Value="HouseBlend" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Espresso(V:55 G:45 T:35)" Value="Espresso"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                
            </tr>
             <tr>
                <td>
                    請選擇Decorator
                </td>
                <td>
                    <asp:CheckBoxList ID="chkl_Decorator" runat="server">
                        <asp:ListItem Value="Mocha">Mocha(V:20 G:10 T:5)</asp:ListItem>
                        <asp:ListItem Value="Whip">Whip(V:20 G:10 T:5)</asp:ListItem>
                        <asp:ListItem Value="Milk">Milk(V:5 G:4 T:2)</asp:ListItem>
                        <asp:ListItem Value="Soy">Soy(V:8 G:6 T:5)</asp:ListItem>
                    </asp:CheckBoxList>
                  
                </td>
                
            </tr>
             <tr>
                <td>
                    請選擇Size
                </td>
                <td>
                    <asp:RadioButtonList ID="rdol_Size" runat="server" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem Text="Venti" Value="Venti" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Grande" Value="Grande"></asp:ListItem>
                        <asp:ListItem Text="Tall" Value="Tall"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                
            </tr>
        </table>
        <asp:Button ID="btn_Decorator" runat="server" OnClick="btn_Decorator_Click" 
            Text="結帳" />
        <br />
        購買清單：<asp:Label ID="lbl_Decoraor" runat="server"></asp:Label>
        <br />
        價錢：<asp:Label ID="lbl_Price" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
