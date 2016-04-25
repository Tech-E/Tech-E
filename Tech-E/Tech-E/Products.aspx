<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Tech_E.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%@ Page AutoEventWireup="true" CodeBehind="Staffs.aspx.cs" Inherits="Tech_E.Staffs" Language="C#" %>

<!DOCTYPE html>

    <title>Products</title>
    <form id="form2" runat="server">
        <div>
            <asp:ListBox ID="ProductListBox" runat="server" Height="264px" Width="414px" DataSourceID="SqlDataSource1" DataTextField="ProductNo" DataValueField="ProductNo" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Tech-EConnectionString %>" SelectCommand="SELECT * FROM [tblProduct]"></asp:SqlDataSource>
        </div>
        <p>
            Enter Product No<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Apply" Width="171px" />
            &nbsp;<asp:Button ID="Button2" runat="server" Text="Display All" Width="171px" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Add" />
            &nbsp;<asp:Button ID="Button4" runat="server" Text="Edit" />
            &nbsp;<asp:Button ID="Button5" runat="server" Text="Delete" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
