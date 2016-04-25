<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerBackEnd.aspx.cs" Inherits="Tech_E.CustomerBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lstCustomer" runat="server" Height="307px" Width="318px" AutoPostBack="True" DataSourceID="CustomerData" DataTextField="CustomerNo" DataValueField="CustomerNo"></asp:ListBox>
        <asp:SqlDataSource ID="CustomerData" runat="server" ConnectionString="<%$ ConnectionStrings:Tech-EConnectionString %>" SelectCommand="SELECT * FROM [tblCustomer]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="lblCustomerNo" runat="server" Text="Please enter a Customer No"></asp:Label>
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
&nbsp;<asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
&nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" />
        <br />
    
    </div>
    </form>
</body>
</html>
