<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointmentBackEnd.aspx.cs" Inherits="Tech_E.AppointmentBackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%@ Page AutoEventWireup="true" CodeBehind="Staffs.aspx.cs" Inherits="Tech_E.Staffs" Language="C#" %>

<!DOCTYPE html>

    <title></title>
    <form id="form2" runat="server">
        <div>
            <asp:ListBox ID="lstAppointment" runat="server" DataSourceID="SqlDataSource1" DataTextField="AppointmentID" DataValueField="AppointmentID" Height="264px" OnSelectedIndexChanged="lstAppointment_SelectedIndexChanged" Width="414px"></asp:ListBox>
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
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
