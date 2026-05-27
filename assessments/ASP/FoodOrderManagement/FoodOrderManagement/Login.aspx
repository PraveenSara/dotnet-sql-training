<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodOrderManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            height: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">


            <table style="width:100%;">
                <tr>
                    <td class="auto-style2" colspan="3">
                        Login Page</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnLogin" runat="server" CssClass="btn" Text="Button" OnClick="btnLogin_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" CssClass="error"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
