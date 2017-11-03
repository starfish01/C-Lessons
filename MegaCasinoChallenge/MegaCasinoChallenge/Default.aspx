<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="slotOneImage" runat="server" />
            <asp:Image ID="slotTwoImage" runat="server" />
            <asp:Image ID="slotThreeImage" runat="server" />
            <br />
            <br />
            Your Bet:
            <asp:TextBox ID="betTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="slotLeverButton" runat="server" OnClick="Button1_Click" style="height: 29px" Text="Pull The Lever!" />
            <br />
            <br />
            Player&#39;s Money:
            <asp:Label ID="balanceLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="winningsLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry - x2 Your bet<br />
            2 Cherries - x3 Your bet<br />
            3 Cherries - x4 Your bet<br />
            3 7&#39;s - Jackpot - x100 Your bet<br />
            <br />
            HOWEVER ... If there&#39;s even one bar you win nothing.</div>
    </form>
</body>
</html>
