<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment_1.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 239px;
        }
        .auto-style2 {
            width: 269px;
        }
        .row {
            margin-bottom: 15px;
        }

        .label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .input {
            width: 100%;
            padding: 8px;
        }

        .success {
            color: green;
            font-weight: bold;
        }

        .error {
            color: red;
            font-weight: bold;
        }

        .btn {
            padding: 10px 20px;
            margin-right: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Insert Your Details</h3>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="* Name is Mandatory" CssClass="error" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Family Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvFamilyName" runat="server" ControlToValidate="txtFamilyName" CssClass="error" Display="Dynamic" ErrorMessage="Family Name is Mandotory"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cvFamilyNmae" runat="server" ControlToCompare="txtName" ControlToValidate="txtFamilyName" CssClass="error" Display="Dynamic" ErrorMessage="Name and Family name not be same" Operator="NotEqual"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Address</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="refAddress" runat="server" ControlToValidate="txtAddress" CssClass="error" Display="Dynamic" ErrorMessage="Address must contail atleast 2 letter" ValidationExpression="^(?=(?:.*[A-Za-z]){2,}).+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">City</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="refCity" runat="server" ControlToValidate="txtCity" CssClass="error" Display="Dynamic" ErrorMessage="City must contail atleast 2 letter" ValidationExpression="^(?=(?:.*[A-Za-z]){2,}).+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Zip Code</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" CssClass="error" Display="Dynamic" ErrorMessage="Must contain 5 digits" ValidationExpression="^[0-9]{5}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Phone</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" CssClass="error" Display="Dynamic" ErrorMessage="Its not matches the indian mobile number format" ValidationExpression="^[9876][0-9]{9}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">E - Mail</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" CssClass="error" Display="Dynamic" ErrorMessage="Give in Email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnCheck" runat="server" CssClass="btn" OnClick="btnCheck_Click" Text="Check" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server" CssClass="success"></asp:Label>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Please fix the followings" />
            <br />
               
        </div>
    </form>
    
        
</body>
</html>
