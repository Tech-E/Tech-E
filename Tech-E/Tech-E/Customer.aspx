<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Tech_E.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lstCustomer" runat="server" Height="278px" Width="259px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Button" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Button" />
&nbsp;<asp:Button ID="Button5" runat="server" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
