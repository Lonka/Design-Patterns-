<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacadeTest.aspx.cs" Inherits="DesignPatterns.FacadePattern.FacadeTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_Open" runat="server" Text="開機" onclick="btn_Open_Click" />
        <asp:Button ID="btn_Close" runat="server" Text="關機" onclick="btn_Close_Click" />
        <br />
        <asp:Label ID="lbl_Msg" runat="server"  ></asp:Label>
    </div>
    </form>
</body>
</html>
