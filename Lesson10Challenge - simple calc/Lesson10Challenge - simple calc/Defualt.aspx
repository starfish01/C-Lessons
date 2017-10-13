<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="Lesson10Challenge___simple_calc.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <br />
            <strong>First Value:</strong>&nbsp;
            <asp:TextBox ID="value1TextBox" runat="server" OnTextChanged="value1TextBox_TextChanged"></asp:TextBox>
            <br />
            <strong>Second Value: </strong>&nbsp;<asp:TextBox ID="value2TextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addBtn" runat="server" Text="+" OnClick="addBtn_Click" /> &nbsp;
            <asp:Button ID="subtractBtn" runat="server" Text="-" OnClick="subtractBtn_Click" />&nbsp;
            <asp:Button ID="muiltplyBtn" runat="server" Text="*" OnClick="muiltplyBtn_Click" />&nbsp;
            <asp:Button ID="devideBtn" runat="server" Text="/" OnClick="devideBtn_Click" />&nbsp;
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
