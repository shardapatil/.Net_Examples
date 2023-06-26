<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestInheritance.aspx.cs" Inherits="ODL_Bootcamp.TestInheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnDisp" runat="server" Text="Display Details" OnClick="btnDisp_Click" />
        <br />
        <br />
        <asp:Label ID="lblSalary" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblBonus" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGenerate" runat="server" Text="Generate Count" OnClick="btnGenerate_Click" />
        <br />
        <br />
        <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
