<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemplateTest.aspx.cs" Inherits="DesignPatterns.TemplatePattern.TemplateTest" %>

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
    <asp:Button ID="btn_Tea" runat="server" Text="Tea Algorithm" 
            onclick="btn_Tea_Click" />
    </td>
    <td>
        <asp:Button ID="btn_Coffee" runat="server" Text="Coffee Algorithm" 
            onclick="btn_Coffee_Click" />
            Coffee not yet override hook method
    </td>
    </tr>
    <tr>
    <td colspan="2">
        <asp:RadioButtonList ID="rdol_Hook" runat="server">
        <asp:ListItem Text ="Yes" Value ="1" Selected="True"></asp:ListItem>
        <asp:ListItem Text ="No" Value ="0"></asp:ListItem>
        </asp:RadioButtonList>
    
    </td>
    </tr>
    <tr>
    <td>
          <asp:Label ID="lbl_Tea" runat="server" ></asp:Label>
  
    </td>
    <td>
          <asp:Label ID="lbl_Coffee" runat="server" ></asp:Label>
  
    </td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
