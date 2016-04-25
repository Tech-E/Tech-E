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

        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>

    </p>
        <p>
            <asp:Button ID="btn1" runat="server" Text="Apply" Width="171px"  />
&nbsp;<asp:Button ID="btn2" runat="server" Text="Display All" Width="171px"  />

    </p>
        <p>
            <asp:Button ID="btn3" runat="server" Text="Add" OnClick="btn3_Click"  />
&nbsp;<asp:Button ID="btn4" runat="server" Text="Edit" />
&nbsp;<asp:Button ID="btn5" runat="server" Text="Delete" OnClick="btn5_Click"  />

    </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
