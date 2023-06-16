<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArrayDemo.aspx.cs" Inherits="ODL_Bootcamp.ArrayDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblArray" runat="server" Text="Enter the Array : "></asp:Label>
        <asp:TextBox ID="txtArray" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        
        <asp:Button ID="btnDisp" runat="server" Text="Display" OnClick="btnDisp_Click" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
