<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryDemo.aspx.cs" Inherits="ODL_Bootcamp.JQueryDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js">
    </script>
    <script src="JQuery%20Files/MyJQueryScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHide" runat="server" Text="Click Me" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShow" runat="server" Text="Show" />
        <br />
        <p>The jQuery #id selector uses the id attribute of an HTML tag to find the specific element.
            An id should be unique within a page, so you should use the #id selector when you want to find a single, unique element.</p>
        <br />
        <asp:Button ID="btnFade" runat="server" Text="Fade Out" OnClientClick ="return false;"/>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFadeIn" runat="server" Text="Fade In" OnClientClick ="return false;"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnToggle" runat="server" Text="Toggle" OnClientClick ="return false;"/>
        <br />
        <br />
        <asp:Image ID="imgCat" runat="server" ImageUrl="data:image/jpeg;base64,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" />
        <br />
        <br />
        <asp:Button ID="btnSlideDown" runat="server" Text="Slide Down" OnClientClick ="return false;"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSlideUp" runat="server" OnClick="Button2_Click" Text="Slide Up" OnClientClick ="return false;"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSlideToggle" runat="server" Text="Slide Toggle" OnClientClick ="return false;"/>
        <br />
        <br />
        <asp:Image ID="imgCat1" runat="server" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlguxee9su-gcLZjvglY8VR1-sLf6_uhUXSg&amp;usqp=CAU" />
        <br />
        <br />
        <asp:Button ID="btnAnimate" runat="server" OnClick="Button1_Click" Text="Animate" OnClientClick ="return false;"/>
        <br />
        <br />
        <asp:Image ID="imgDog" runat="server" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxsD3vt1brKDPrtQwBGoELCjDpdUJ-7PbU0g&amp;usqp=CAU" />
        <br />
    </div>
    </form>
</body>
</html>
