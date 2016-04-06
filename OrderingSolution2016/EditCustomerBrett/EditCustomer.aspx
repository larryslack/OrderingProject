<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="EditCustomerBrett.EditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap-3.3.5-dist/css/bootstrap.css" rel="stylesheet" />
    <link href="css/general_styles.css" rel="stylesheet" />
    <title></title>

    <script type="text/javascript">
        function confirmDeletion(message)
        {
            var result = confirm(message);
            return result;
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <section class="container-fluid">
            <section class="row-fluid">
                <section class="contentWrapper">
                    <header class="col-md-12">
                        <!-- Three states, Customer Form, New Customer, or Edit Customer -->
                        <h2 runat="server" id="lblCustomer" class="labels">Customer Form</h2>
                    </header>

                    <section class="content col-md-12">
                        <section runat="server" id="secTable" class="secTable">
                            <section class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnAdd" runat="server" CssClass="addEdit" Text="Add New Customer" OnClick="btnAdd_Click" />
                            </section>

                            <section class="col-md-12 cusTable">
                                <asp:GridView ID="gridCustomers" runat="server"></asp:GridView>
                            </section>
                        </section>

                        <section runat="server" id="customerFields" class="hidden">
                            <section class="col-md-3 col-md-offset-3">
                                <section class="controlColumn">
                                    <section class="controlGroup">
                                        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtCustomerID" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblContactName" runat="server" Text="Contact Name" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtContactName" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblRegion" runat="server" Text="Region" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtRegion" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblCountry" runat="server" Text="Country" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtCountry" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup faxGroup">
                                        <asp:Label ID="lblFax" runat="server" Text="Fax Number" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtFax" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>
                                </section>
                            </section>

                            <section class="col-md-3">
                                <section class="controlColumn">
                                    <section class="controlGroup">
                                        <asp:Label ID="lblName" runat="server" Text="Company Name" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtCompanyName" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblContactTitle" runat="server" Text="Contact Title" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtContactTitle" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblCity" runat="server" Text="City" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtCity" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtPostalCode" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>

                                    <section class="controlGroup">
                                        <asp:Label ID="lblPhone" runat="server" Text="Phone Number" CssClass="labels"></asp:Label>
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="txtInputs"></asp:TextBox>
                                    </section>
                                </section>
                            </section>

                            <section class="col-md-12 col-md-offset-2 confirmCancel">
                                <section class="col-md-2 col-md-offset-3">
                                    <section class="controlGroup">
                                        <asp:Button ID="btnCancel" runat="server" Text="Canel" OnClientClick="return confirmDeletion('Are you sure you want to cancel?');" OnClick="btnCancel_Click" />
                                        <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" OnClientClick="return confirmDeletion('Are you sure you want to commit these changes?');" />
                                    </section>
                                </section>
                            </section>
                        </section>
                    </section>
                </section>
            </section>
        </section>
    </form>
</body>
</html>
