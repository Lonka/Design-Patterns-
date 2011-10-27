<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageDuck.aspx.cs" Inherits="DesignPatterns.DesignPatternIntroduction.PageDuck" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_FlyNoWay" runat="server" Text="FlyNoWay" 
            onclick="btn_FlyNoWay_Click" />
        <asp:Button ID="btn_FlyWithWings" runat="server" Text="FlyWithWings" 
            onclick="btn_FlyWithWings_Click" />
        <asp:Button ID="btn_FlyRocketPowered" runat="server" 
            onclick="btn_FlyRocketPowered_Click" Text="FlyRocketPowered" />
        <br />
        Perform Result:<asp:Label ID="lbl_Result" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btn_Quack" runat="server" Text="Quack" 
            onclick="btn_Quack_Click" />
        <asp:Button ID="btn_Squeak" runat="server" Text="Squeak" 
            onclick="btn_Squeak_Click" />
        <asp:Button ID="btn_MuteQuack" runat="server" 
            Text="MuteQuack" onclick="btn_MuteQuack_Click" />
        <br />
        Perform Result:<asp:Label ID="lbl_QuackResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
