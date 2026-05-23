<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ProductsDropdown.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Products</h2>
            <asp:Label ID="lblselect" runat="server" Text="Select a Product"></asp:Label>
        &nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                <asp:ListItem Text="-- Select Products --" Value="" />
                <asp:ListItem Text="Mobile" Value="Mobile" /> 
                <asp:ListItem Text="Watch" Value="Watch" /> 
                <asp:ListItem Text="Laptop" Value="Laptop" /> 
                
            </asp:DropDownList>
        </div>
        <asp:ListView ID="lvProducts" runat="server" OnSelectedIndexChanged="lvProducts_SelectedIndexChanged" OnItemCommand="lvProducts_ItemCommand">
            <ItemTemplate>
                <asp:ImageButton ID="ImgProducts" runat="server" 
                    width="350" Height="350"
                    ImageUrl='<%# Eval("ImageUrl") %>' 
                    CommandName="ShowProduct"
                    CommandArgument='<%# Eval("ImageUrl") %>'
                    />
            </ItemTemplate>    
        </asp:ListView>
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor ="Blue"></asp:Label>
        
    </form>
</body>
</html>
