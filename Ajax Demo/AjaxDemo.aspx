<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxDemo.aspx.cs" Inherits="ODL_Bootcamp.AjaxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        Loading...
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnDisplay" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>

        <asp:UpdatePanel ID="UpdatePanel2" runat="server"></asp:UpdatePanel>

        <br /><br />
    </div>
        <p>
        
        <asp:Button ID="btnDisplay" runat="server" Text="Display Date" OnClick="btnDisplay_Click" />
        </p>
    </form>
</body>
</html>
