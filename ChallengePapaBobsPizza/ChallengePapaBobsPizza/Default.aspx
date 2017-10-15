<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
&nbsp;Papa Bob&#39;s Pizza and Software<br />
            <br />
            <asp:RadioButton ID="pizzaSizeSmall" runat="server" GroupName="pizzaSizeGroup" Text="Small pizza (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="pizzaSizeMedium" runat="server" GroupName="pizzaSizeGroup" Text="Medium pizza (13&quot;) - $13" />
            <br />
            <asp:RadioButton ID="pizzaSizeLarge" runat="server" GroupName="pizzaSizeGroup" Text="Large pizza (16&quot;) - $16" />
            <br />
            <br />
            <asp:RadioButton ID="pizzaBaseThin" runat="server" GroupName="pizzaBaseGroup" Text="Thin crust" />
            <br />
            <asp:RadioButton ID="pizzaBaseDeep" runat="server" GroupName="pizzaBaseGroup" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <asp:CheckBox ID="ingPepperoni" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="ingOnions" runat="server" Text="Onion (+$0.75)" />
            <br />
            <asp:CheckBox ID="ingGreenPeppers" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="ingRedPeppers" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="ingAnchovies" runat="server" Text="Anchovies (+$2)" />
            <br />
            <br />
            Papa Bob&#39;s Special Deal<br />
            Save $2.00 when you add Pepporoni, Green Peppers and Anchovies, OR Pepporoni, Red Peppers, and Onions to your pizza.<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            Total cost<br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
