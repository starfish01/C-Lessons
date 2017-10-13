<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="firstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            What is your first Name?
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            What is your last Name?
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="resultButton" runat="server" OnClick="resultButton_Click" Text="Click Me" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="labelID" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
