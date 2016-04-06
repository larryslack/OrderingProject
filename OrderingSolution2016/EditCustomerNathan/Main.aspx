<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="EditCustomerNathan.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlCon" runat="server" Height="287px" Width="700px">
            <asp:Label ID="Label1" runat="server" Text="CustomerID" style="z-index: 1; left: 17px; top: 55px; position: absolute"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Name" style="z-index: 1; left: 17px; top: 75px; position: absolute"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Title" style="z-index: 1; left: 17px; top: 95px; position: absolute"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Address" style="z-index: 1; left: 17px; top: 115px; position: absolute"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="City" style="z-index: 1; left: 17px; top: 135px; position: absolute"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Region" style="z-index: 1; left: 17px; top: 155px; position: absolute"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="PostalCode" style="z-index: 1; left: 17px; top: 175px; position: absolute"></asp:Label>
            <asp:Label ID="Label9" runat="server" Text="Country" style="z-index: 1; left: 17px; top: 195px; position: absolute"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Phone" style="z-index: 1; left: 17px; top: 215px; position: absolute"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="Fax" style="z-index: 1; left: 17px; top: 235px; position: absolute"></asp:Label>
            <asp:Label ID="Label11" runat="server" Text="ContactName" style="z-index: 1; left: 17px; top: 255px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 157px; top: 55px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 157px; top: 75px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTile" runat="server" style="z-index: 1; left: 157px; top: 95px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 157px; top: 115px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 157px; top: 135px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtRegion" runat="server" style="z-index: 1; left: 157px; top: 155px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPostalCode" runat="server" style="z-index: 1; left: 157px; top: 175px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCountry" runat="server" style="z-index: 1; left: 157px; top: 195px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 157px; top: 215px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtFax" runat="server" style="z-index: 1; left: 157px; top: 235px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtContactName" runat="server" style="z-index: 1; left: 157px; top: 255px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 303px; top: 220px; position: absolute" Text="Add Customer to DataBase" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 555px; top: 221px; position: absolute" Text="Go To Edit Page" />
            <asp:Label ID="lblError" runat="server" Text="&quot;&quot;"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
