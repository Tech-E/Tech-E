<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAddBackEnd.aspx.cs" Inherits="Tech_E.CustomerAddBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Product Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product Description"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Product price"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Product Manufacturer"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductManufacturer" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="ProductsInStock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductsInStock" runat="server"></asp:TextBox>
        <br />
       
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    
    </div>
    </form>
</body>
</html>
