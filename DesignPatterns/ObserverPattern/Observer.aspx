<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Observer.aspx.cs" Inherits="DesignPatterns.ObserverPattern.Observer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        <asp:TextBox ID="txt_data" runat="server"></asp:TextBox>
    <asp:Button ID="btn_UpdateData" runat="server" Text="Update" 
            onclick="btn_UpdateData_Click" />
        <br />
        Observer Site1 :<asp:Label ID="lbl_ObserverSite1" runat="server"></asp:Label>
        <br />
        Observer Site2 :<asp:Label ID="lbl_ObserverSite2" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
