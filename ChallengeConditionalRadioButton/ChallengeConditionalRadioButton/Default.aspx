<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preference</div>
        <br />
        <asp:RadioButton ID="radioPencil" runat="server" Checked="True" GroupName="noteGroup" Text="Pencil" />
        <br />
        <asp:RadioButton ID="radioPen" runat="server" GroupName="noteGroup" Text="Pen" />
        <br />
        <asp:RadioButton ID="radioPhone" runat="server" GroupName="noteGroup" Text="Phone" />
        <br />
        <asp:RadioButton ID="radioTablet" runat="server" GroupName="noteGroup" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Image ID="imageResult" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
