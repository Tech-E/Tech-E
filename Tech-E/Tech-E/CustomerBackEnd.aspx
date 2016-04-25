<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerBackEnd.aspx.cs" Inherits="Tech_E.CustomerBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lstCustomer" runat="server" Height="323px" Width="317px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerNo" runat="server" Text="Please enter a Customer No"></asp:Label>
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
&nbsp;<asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" />
        <br />
    
    </div>
    </form>
</body>
</html>
