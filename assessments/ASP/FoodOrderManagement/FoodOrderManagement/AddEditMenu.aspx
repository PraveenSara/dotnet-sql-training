<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEditMenu.aspx.cs" Inherits="FoodOrderManagement.AddEditMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .error {
    color: red;
    font-weight: bold;
}

.container {
    width: 1000px;
    margin: 40px auto;
    padding: 25px;
    border: 1px solid #ccc;
    border-radius: 10px;
    background-color: #f7f7f7;
}
.btn {
    padding: 10px 20px;
    margin-right: 10px;
    background-color:cornflowerblue;

}

.success {
    color: green;
    font-weight: bold;
}

.table {
    width: 400px;
    margin: 50px auto;
    border: 1px solid #ccc;
    padding: 20px;
}
        .auto-style1 {
            width: 183px;
        }
        .auto-style2 {
            width: 311px;
        }
        .auto-style3 {
            width: 183px;
            height: 33px;
        }
        .auto-style4 {
            width: 311px;
            height: 33px;
        }
        .auto-style5 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="chkIsAvailable">

            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblId" runat="server" Text="MenuId"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtMenuId" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="rfvMenuId" runat="server" ControlToValidate="txtMenuId" CssClass="error" ErrorMessage="Id is mandatory"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtItemName" CssClass="error" ErrorMessage="Name is Mandotory"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True">
                            <asp:ListItem>-- Select Food Catogory --</asp:ListItem>
                            <asp:ListItem>Biriyani</asp:ListItem>
                            <asp:ListItem>Pizza</asp:ListItem>
                            <asp:ListItem>Burger</asp:ListItem>
                            <asp:ListItem>Pasta</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblFoodType" runat="server" Text="Food Type"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="rblFoodType" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                            <asp:ListItem>Veg</asp:ListItem>
                            <asp:ListItem>Non veg</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice" CssClass="error" ErrorMessage="Mandotory field"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblAvailableQuantity" runat="server" Text="Available Quantity"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAvailableQuantity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvAvailable" runat="server" ControlToValidate="txtAvailableQuantity" CssClass="error" ErrorMessage="Mandotory field"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblIsAvailable" runat="server" Text="Is Available"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:CheckBox ID="chkIsAvailable" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnRegister" runat="server" CssClass="btn" OnClick="lblRegister_Click" Text="Add Product" />
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <p>
            <asp:Button ID="btnBack" runat="server" CausesValidation="False" CssClass="btn" OnClick="btnBack_Click" Text="Back" />
        </p>
    </form>
</body>
</html>
