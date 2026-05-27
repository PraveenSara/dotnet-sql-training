<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuList.aspx.cs" Inherits="FoodOrderManagement.MenuList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1></h1>
            <asp:GridView ID="GridView1"
        runat="server"
        AutoGenerateColumns="False"
        DataKeyNames="MenuId"
        OnRowCommand="GridView1_RowCommand"
        CssClass="table table-bordered">

        <Columns>

            <asp:BoundField DataField="MenuId" HeaderText="ID" />
            <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
            <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:BoundField DataField="FoodType" HeaderText="Food Type" />
            <asp:BoundField DataField="Price" HeaderText="Price" />

            <asp:ButtonField
                Text="View"
                CommandName="ViewItem"
                ButtonType="Button" />

            <asp:ButtonField
                Text="Edit"
                CommandName="EditItem"
                ButtonType="Button" />

            <asp:ButtonField
                Text="Delete"
                CommandName="DeleteItem"
                ButtonType="Button" />

        </Columns>

    </asp:GridView>
            

        </div>
    </form>
</body>
</html>
