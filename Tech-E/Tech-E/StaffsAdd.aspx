<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffsAdd.aspx.cs" Inherits="Tech_E.StaffsAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            
            <br />
            <asp:Label ID="Label2" runat="server" Text="StaffName"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="509px" ></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" style="margin-bottom: 0px" Width="509px" class="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Brief"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="83px" TextMode="MultiLine" Width="509px" class="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Man" runat="server" GroupName="1"  />
            Man
            <asp:RadioButton ID="Woman" runat="server" GroupName="1" />
            Woman<br />
            <asp:Label ID="Label6" runat="server" Text="MobilePhone"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"  class="form-control" Width="509px"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Position"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="148px"  >
                <asp:ListItem>staff</asp:ListItem>
                <asp:ListItem>manager</asp:ListItem>
                <asp:ListItem>boss</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Label ID="Label8" runat="server" Text="WorkAge"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Width="77px"  class="form-control"></asp:TextBox>
            &nbsp;YEAR<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Add" Width="74px" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Cancel" Width="74px" />
            <br />
        </div>
    </form>
</body>
</html>
