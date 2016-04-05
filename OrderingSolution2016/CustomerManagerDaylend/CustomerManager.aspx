<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerManager.aspx.cs" Inherits="CustomerManager.CustomerManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblOp" runat="server" Text="Operation"></asp:Label>
                        <asp:RadioButtonList ID="rbList" runat="server">
                            <asp:ListItem Selected="True">Edit</asp:ListItem>
                            <asp:ListItem>Create</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddCompanyName" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCustID" runat="server" Text="Customer ID"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCustID" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCName" runat="server" Text="Contact Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRegion" runat="server" Text="Region"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblPCode" runat="server" Text="Postal Code"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtPCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
