<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberPatternDemo.aspx.cs" Inherits="ODL_Bootcamp.NumberPatternDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblValue" runat="server" Text="Enter Value"></asp:Label>
        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDisp" runat="server" Text="Display Pattern" OnClick="btnDisp_Click" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
