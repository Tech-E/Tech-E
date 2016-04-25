<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDeletePage.aspx.cs" Inherits="Tech_E.StaffDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Are you sure you want to delete this staff information?<br />
        <br />
&nbsp;<asp:Button ID="btn1" runat="server" Text="Yes" Height="37px" Width="81px" OnClick="btn1_Click" />
        &nbsp;<asp:Button ID="btn2" runat="server" Text="No" Height="37px" Width="81px" OnClick="btn2_Click" />
    </div>
    </form>
</body>
</html>
