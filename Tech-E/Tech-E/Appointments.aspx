<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staffs.aspx.cs" Inherits="Tech_E.Staffs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lstAppointment" runat="server" Height="264px" Width="414px" DataSourceID="SqlDataSource1" DataTextField="AppointmentID" DataValueField="AppointmentID" OnSelectedIndexChanged="lstAppointment_SelectedIndexChanged"></asp:ListBox>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Tech-EConnectionString %>" SelectCommand="SELECT * FROM [tblAppointment]"></asp:SqlDataSource>
    
    </div>
    <p>
        Please Enter AppointmentID<br />

        <asp:TextBox ID="txtAppointment" runat="server"></asp:TextBox>

    </p>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" Width="171px" />
&nbsp;<asp:Button ID="btnDisplay" runat="server" Text="Display All" Width="171px" />

    </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
&nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" />

    </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
