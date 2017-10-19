<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Defualt" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" Height="190px" />
            <br />
            Spy New Assignment Form<br />
            Spy Code Name:
            <asp:TextBox ID="spyCodeNameTextBox" runat="server"></asp:TextBox>
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End&nbsp; Date of Previous Assignment<asp:Calendar ID="endPreviousCalendar" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment<asp:Calendar ID="startAssignmentCalendar" runat="server"></asp:Calendar>
            <br />
            Projected End Date of New Assignment<asp:Calendar ID="endNewAssignmentCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="assignSpyButton" runat="server" Text="Assign Spy" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
