using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;

namespace InterfaceLayer
{
    public partial class OrderingFormBrett : Form
    {
        string CustomerID;
        int EmployeeID;
        List<OrderDetail> DetailList;
        List<Panel> pnlList = new List<Panel>();
        Customer currentCustomer;
        List<Product> productList;

        public OrderingFormBrett(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblCustomerID.Text = CustomerID;
            lblEmployeeID.Text = EmployeeID.ToString();
        }

        private void OrderingFormBrett_Load(object sender, EventArgs e)
        {
            productList = Business.ProductList();

            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            AddPanel();

            currentCustomer = Business.GetCustomer(CustomerID);

            txtPostalCode.Text = currentCustomer.PostalCode;
            txtRegion.Text = currentCustomer.Region;
            txtShipAddress.Text = currentCustomer.Address;
            txtShipCity.Text = currentCustomer.City;
            txtShipCountry.Text = currentCustomer.Country;
            txtRegion.Text = currentCustomer.Region;
            txtFax.Text = currentCustomer.Fax;
            txtPhone.Text = currentCustomer.Phone;

            cmbShipVia.DataSource = BrettBusiness.ShipperTable();
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShipVia.SelectedIndex = -1;

            TxtRequiredDateMethods();
        }

        private void AddPanel()
        {
            Panel orderPnl = new Panel();
            orderPnl.Width = pnlContainer.Width - 25;
            orderPnl.Height = 40;
            if (pnlContainer.Controls.Count > 0)
                orderPnl.Top = pnlContainer.Controls[pnlContainer.Controls.Count - 1].Height + pnlContainer.Controls[pnlContainer.Controls.Count - 1].Top + 5;
            else
                orderPnl.Top = 5;
            orderPnl.Left = 4;
            orderPnl.BorderStyle = BorderStyle.FixedSingle;

            pnlContainer.Controls.Add(orderPnl);
            pnlList.Add(orderPnl);
            AddPanelControls(orderPnl);
        }

        private void AddPanelControls(Panel pnl)
        {
            int standardWidth = 100; //Yay magic numbers.
            int standardHeight = pnl.Height - 18;
            int PosY = (pnl.Height / 4) - 2;
            int PosX = 5;

            ComboBox cmb = new ComboBox();
            cmb.Width = standardWidth * 2;
            cmb.Height = standardHeight;
            cmb.Top = PosY;
            cmb.Left = PosX;

            TextBox txtQuantity = new TextBox();
            txtQuantity.Width = standardWidth;
            txtQuantity.Height = standardHeight;
            txtQuantity.Top = PosY;
            txtQuantity.Left = cmb.Left + cmb.Width + PosX;
            txtQuantity.Text = "0";
            txtQuantity.Name = "txtQuantity" + pnlContainer.Controls.Count;

            TextBox txtDiscount = new TextBox();
            txtDiscount.Width = standardWidth;
            txtDiscount.Height = standardHeight;
            txtDiscount.Top = PosY;
            txtDiscount.Left = txtQuantity.Left + standardWidth + PosX;
            txtDiscount.Text = "0";
            txtDiscount.Name = "txtDiscount" + pnlContainer.Controls.Count;

            TextBox txtPrice = new TextBox();
            txtPrice.Width = standardWidth;
            txtPrice.Height = standardHeight;
            txtPrice.Top = PosY;
            txtPrice.Left = txtDiscount.Left + standardWidth + PosX;
            txtPrice.ReadOnly = true;
            txtPrice.Text = "0.00";
            txtPrice.Name = "txtPrice" + pnlContainer.Controls.Count;

            Button btnRemove = new Button();
            btnRemove.Width = standardWidth;
            btnRemove.Height = standardHeight;
            btnRemove.Top = PosY;
            btnRemove.Left = txtPrice.Left + standardWidth + PosX;
            btnRemove.Text = "Remove";
            btnRemove.ForeColor = Color.Black;
            btnRemove.BackColor = Color.PaleVioletRed;

            // This code is so ugly :<
            lblProduct.Left = (pnlContainer.Left + cmb.Left + (cmb.Width / 2) - PosX * 3);
            lblQuantity.Left = (pnlContainer.Left + txtQuantity.Left + (txtQuantity.Width / 2) - PosX * 3);
            lblDiscount.Left = (pnlContainer.Left + txtDiscount.Left + (txtDiscount.Width / 2) - PosX * 3);
            lblPrice.Left = (pnlContainer.Left + txtPrice.Left + (txtPrice.Width / 2) - PosX * 3);

            btnRemove.Click += (sender, e) =>
            {
                for (int i = 0; i < pnlList.Count; i++)
                {
                    if (pnlList[i] == pnl)
                    {
                        if (i != pnlList.Count - 1)
                        {
                            int setPosY;
                            for (int k = pnlList.Count - 1; k > i; k--)
                            {
                                setPosY = pnlList[k - 1].Top;
                                pnlList[k].Top = setPosY;
                            }

                            pnlContainer.Controls.Remove(pnl);
                            pnlList.Remove(pnl);
                        }
                        else
                        {
                            cmb.SelectedIndex = -1;
                            txtQuantity.Text = "0";
                            txtDiscount.Text = "0";
                            txtPrice.Text = "0.00";
                        }
                    }
                }
            };

            txtQuantity.TextChanged += (sender, e) =>
            {
                try
                {
                    int quantity = 0;
                    decimal discount = 0;
                    int index = Convert.ToInt32(cmb.SelectedValue);

                    lblError.Text = "";

                    if (txtQuantity.Text == "")
                    {
                        txtQuantity.Text = "1";
                        throw new Exception("Please enter a quantity");
                    }
                    else
                        quantity = Convert.ToInt32(txtQuantity.Text);

                    if (txtDiscount.Text == "")
                    {
                        txtDiscount.Text = "1";
                    }
                    else
                        discount = Convert.ToInt32(txtDiscount.Text);

                    txtPrice.Text = CalculatePrice(quantity, discount, index).ToString("###0.00");
                    CalculateFreight();
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            };

            txtDiscount.TextChanged += (sender, e) =>
            {
                try
                {
                    int quantity = 0;
                    decimal discount = 0;
                    int index = Convert.ToInt32(cmb.SelectedValue);

                    lblError.Text = "";

                    if (txtQuantity.Text == "")
                    {
                        txtQuantity.Text = "1";
                        throw new Exception("Please enter a quantity");
                    }
                    else
                        quantity = Convert.ToInt32(txtQuantity.Text);

                    if (txtDiscount.Text == "") // Needs regex.
                        txtDiscount.Text = "0";
                    else
                        discount = Convert.ToInt32(txtDiscount.Text);

                    txtPrice.Text = CalculatePrice(quantity, discount, index).ToString("###0.00");
                    CalculateFreight();
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
            };

            SetupCombo(cmb, pnl, txtQuantity, txtDiscount, txtPrice);
            // Add all of the new controls to the panel
            pnl.Controls.Add(cmb);
            cmb.SelectedIndex = -1;
            pnl.Controls.Add(txtPrice);
            pnl.Controls.Add(txtQuantity);
            pnl.Controls.Add(txtDiscount);
            pnl.Controls.Add(btnRemove);
        }

        private void SetupCombo(ComboBox cmb, Panel pnl, TextBox txtQuantity, TextBox txtDiscount, TextBox txtPrice)
        {
            List<Product> productList = new List<Product>(this.productList);
            cmb.DataSource = productList;
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb.SelectedIndexChanged += (sender, e) =>
            {
                if (cmb.SelectedIndex == -1)
                    return;

                txtQuantity.Text = "1";
                int quantity = Convert.ToInt32(txtQuantity.Text);
                decimal discount = Convert.ToDecimal(txtDiscount.Text);
                int index = Convert.ToInt32(cmb.SelectedValue);

                txtPrice.Text = CalculatePrice(quantity, discount, index).ToString("###0.00");
                CalculateFreight();

                int currentPanelIndex = 0;
                int panelIndexCount = pnlList.Count - 1;

                for (int i = 0; i < pnlList.Count; i++)
                {
                    if (pnl == pnlList[i])
                    {
                        currentPanelIndex = i;
                    }
                }

                if (currentPanelIndex == panelIndexCount)
                {
                    AddPanel();
                }
            };
        }

        private void btnRandomOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order o = new Order(1);
                o.CustomerID = lblCustomerID.Text;
                o.EmployeeID = Convert.ToInt32(lblEmployeeID.Text);
                o.OrderDate = DateTime.Now;
                o.RequiredDate = Convert.ToDateTime(txtRequiredDate.Text);
                o.ShippedDate = null;
                o.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
                o.Freight = Convert.ToDecimal(txtFreight.Text); //Retrieve later.
                o.ShipName = currentCustomer.CompanyName;
                o.ShipAddress = txtShipAddress.Text;
                o.ShipCity = txtShipCity.Text;
                o.ShipRegion = txtRegion.Text;
                o.ShipPostalCode = txtPostalCode.Text;
                o.ShipCountry = txtShipCountry.Text;
                o.EmployeeName = null; // I need the employee name.
                o.ShipperName = cmbShipVia.Text;

                Business.SaveOrder(o);
                DetailList = new List<OrderDetail>();

                foreach (Panel pnl in pnlContainer.Controls)
                {
                    int productID = -1;
                    decimal unitPrice = 0;
                    short quantity = 0;
                    float discount = 0;

                    foreach (Control cntrl in pnl.Controls)
                    {
                        if (((ComboBox)pnl.Controls[0]).SelectedIndex != -1)
                        {
                            if (cntrl is ComboBox)
                            {
                                productID = Convert.ToInt32(((ComboBox)cntrl).SelectedValue);
                            }

                            if (cntrl is TextBox)
                            {
                                if (cntrl.Name.Contains("txtQuantity"))
                                {
                                    quantity = Convert.ToInt16(((TextBox)cntrl).Text);
                                }

                                if (cntrl.Name.Contains("txtPrice"))
                                {
                                    unitPrice = Convert.ToDecimal(((TextBox)cntrl).Text);
                                }

                                if (cntrl.Name.Contains("txtDiscount"))
                                {
                                    discount = Convert.ToSingle(((TextBox)cntrl).Text) / 100;
                                }
                            }
                        }
                    }

                    if (productID != -1 && quantity > 0)
                        DetailList.Add(new OrderDetail(o.OrderID, productID, unitPrice, quantity, discount));
                }

                Business.SaveDetails(o.OrderID, DetailList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public decimal CalculatePrice(int quantity, decimal discount, int index)
        {
            decimal discountPrice = 0;
            decimal totalPrice = 0;

            if (discount == 0)
            {
                discount = 1;
            }
            else if (discount > 0)
            {
                // Puts the discount into percentage. Then adds one so when it is used it will take the percentage off.
                discount = discount / 100m;
                discountPrice = productList[index].UnitPrice * quantity * discount;
            }

            totalPrice = (productList[index].UnitPrice * quantity) - discountPrice;

            return totalPrice;
        }

        public void CalculateFreight()
        {
            decimal freight = 0;
            foreach (Panel pnl in pnlContainer.Controls)
            {
                foreach (Control cntrl in pnl.Controls)
                {
                    if (cntrl is TextBox)
                    {
                        if (cntrl.Name.Contains("txtPrice"))
                        {
                            freight += Convert.ToDecimal(cntrl.Text);
                        }
                    }
                }
            }

            txtFreight.Text = freight.ToString();
        }

        public void TxtRequiredDateMethods()
        {
            txtRequiredDate.Enter += (sender, e) =>
            {
                if (txtRequiredDate.Text == "DD/MM/YYYY")
                {
                    txtRequiredDate.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                    txtRequiredDate.Text = "";
                }
            };

            txtRequiredDate.Leave += (sender, e) =>
            {
                if (txtRequiredDate.Text == "")
                {
                    txtRequiredDate.ForeColor = Color.Gray;
                    txtRequiredDate.Text = "DD/MM/YYYY";
                }
            };
        }
    }
}
