<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoteControlTest.aspx.cs" Inherits="DesignPatterns.CommandPattern.RemoteControlTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl_Msg" runat="server" ></asp:Label>
        <br />
        <asp:Button ID="btn_Set" runat="server" onclick="btn_Set_Click" Text="設定" />
        <asp:Button ID="btn_Undo" runat="server" Text="復原" onclick="btn_Undo_Click" />
    </div>
    </form>
</body>
</html>
