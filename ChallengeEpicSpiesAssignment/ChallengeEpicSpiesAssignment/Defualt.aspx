<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            Spy New Assignment Form<br />
            Spy Code Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            New Assignment Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            End&nbsp; Date of Previous Assignment<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Assign Spy" />
        </div>
    </form>
</body>
</html>
