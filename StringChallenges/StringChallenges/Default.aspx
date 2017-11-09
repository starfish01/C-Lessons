<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StringChallenges.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="resultLabel1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="resultLabel2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="resultLabel3" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
