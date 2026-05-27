<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuDetails.aspx.cs" Inherits="FoodOrderManagement.MenuDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <table class="table table-bordered">

    <tr>
        <th>Menu ID</th>
        <td>
            <asp:Label ID="lblMenuId"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Item Name</th>
        <td>
            <asp:Label ID="lblItemName"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Category</th>
        <td>
            <asp:Label ID="lblCategory"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Food Type</th>
        <td>
            <asp:Label ID="lblFoodType"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Price</th>
        <td>
            <asp:Label ID="lblPrice"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Available Quantity</th>
        <td>
            <asp:Label ID="lblQuantity"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Availability</th>
        <td>
            <asp:Label ID="lblAvailable"
            runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
        <th>Created Date</th>
        <td>
            <asp:Label ID="lblCreatedDate"
            runat="server"></asp:Label>
        </td>
    </tr>

</table>
        </div>
    </form>
</body>
</html>
