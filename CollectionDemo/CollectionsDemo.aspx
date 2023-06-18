<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollectionsDemo.aspx.cs" Inherits="ODL_Bootcamp.CollectionsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnCollection" runat="server" Text="List" OnClick="btnCollection_Click" />
        <br />
        <asp:Label ID="lblList" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
