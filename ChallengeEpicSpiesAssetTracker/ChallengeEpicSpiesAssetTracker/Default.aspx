<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            Asset Performance Tracker<br />
            <br />
            Asset Name:
            <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
            <br />
            Elections Rigged: <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="resultButton" runat="server" OnClick="resultButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
