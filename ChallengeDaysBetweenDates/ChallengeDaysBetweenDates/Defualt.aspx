<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="ChallengeDaysBetweenDates.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Chose one date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            Chose a second date:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="resultBtn" runat="server" OnClick="resultBtn_Click" Text="Ok" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
