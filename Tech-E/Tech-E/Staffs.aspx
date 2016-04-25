<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staffs.aspx.cs" Inherits="Tech_E.Staffs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Height="264px" Width="414px"></asp:ListBox>
    
    </div>
    <p>
        please Enter StaffID<br />

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
</body>
</html>
