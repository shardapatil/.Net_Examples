<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExceptionHandlingDemo.aspx.cs" Inherits="ODL_Bootcamp.ExceptionHandlingDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFirstVal" runat="server" Text="Enter First Value : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtFirstVal" runat="server"></asp:TextBox>
        &nbsp;
        &nbsp;
        <asp:Label ID="lblSecondVal" runat="server" Text="Enter Second Value : "></asp:Label>
        <asp:TextBox ID="txtSecondVal" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <asp:Label ID="lblException" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
