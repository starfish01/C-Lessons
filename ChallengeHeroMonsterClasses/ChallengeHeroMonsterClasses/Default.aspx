<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeHeroMonsterClasses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="player1Label" runat="server"></asp:Label>
                &nbsp;<asp:Label ID="Label2" runat="server" Text="Health"></asp:Label>
&nbsp;<asp:Label ID="player1HealthLabel" runat="server"></asp:Label>
            &nbsp;</div>
            <br />
            <div>
                <asp:Label ID="player2Label" runat="server"></asp:Label>
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Health"></asp:Label>
&nbsp;<asp:Label ID="player2HealthLabel" runat="server"></asp:Label>
            </div>


            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
