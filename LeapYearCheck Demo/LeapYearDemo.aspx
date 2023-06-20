<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeapYearDemo.aspx.cs" Inherits="ODL_Bootcamp.LeapYearDemo" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblYear" runat="server" Text="Enter Year : "></asp:Label>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDispYear" runat="server" Text="Display Year" OnClick="btnDispYear_Click" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
