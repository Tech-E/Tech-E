<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsBackEnd.aspx.cs" Inherits="Tech_E.ProductsBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lstProducts" runat="server" DataSourceID="Products" DataTextField="ProductName" DataValueField="ProductNo" Height="242px" Width="367px"></asp:ListBox>
        <asp:SqlDataSource ID="Products" runat="server" ConnectionString="<%$ ConnectionStrings:Tech-EConnectionStringNew %>" SelectCommand="SELECT [ProductNo], [ProductName] FROM [tblProduct]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
