<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAddBackEnd.aspx.cs" Inherits="Tech_E.CustomerAddBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Address Line 1"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAddressLine1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address Line 2"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAddressLine2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Town"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="PostCode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Phone No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
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
