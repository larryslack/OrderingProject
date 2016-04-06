<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerManager.aspx.cs" Inherits="CustomerManager.CustomerManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Manager</title>
    <link href="css/mainstyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer Manager</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblOp" runat="server" Text="Operation"></asp:Label>
                        <asp:RadioButtonList ID="rbList" runat="server" OnSelectedIndexChanged="rbList_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">Edit</asp:ListItem>
                            <asp:ListItem>Create</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:Label ID="lblSelectCN" runat="server" Text="Select Company"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddCompanyName" CssClass="textBox" runat="server" OnSelectedIndexChanged="ddCompanyName_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCustID" runat="server" Text="Customer ID"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCustID" CssClass="textBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCompanyName" CssClass="cnTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCName" runat="server" Text="Contact Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtConName" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtAddress" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCity" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblRegion" runat="server" Text="Region"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtRegion" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPCode" runat="server" Text="Postal Code"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtPCode" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCountry" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtPhone" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtFax" CssClass="textBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr class="buttonRow">
                    <td colspan="2" class="buttonCell">
                        <asp:Button ID="btnSave" CssClass="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
