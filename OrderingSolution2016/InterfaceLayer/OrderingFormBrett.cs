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
        private bool isEditting = false;
        private string customerID;
        private int employeeID;
        private List<OrderDetail> detailList;
        private List<OrderDetail> tempDetailList;
        private List<BrettProductPanel> pnlList = new List<BrettProductPanel>();
        private Customer currentCustomer;
        private List<Product> productList;
        private int orderID = 0;

        public OrderingFormBrett(string customerID, int emloyeeID)
        {
            InitializeComponent();
            PreInitForm(customerID, emloyeeID);
        }

        public OrderingFormBrett(string customerID, int employeeID, int orderID)
        {
            InitializeComponent();
            PreInitForm(customerID, employeeID);
            this.orderID = orderID;
            this.tempDetailList = Business.OrderDetailList(orderID);
            isEditting = true;
            lblOrderID.Text = orderID.ToString();
        }

        private void OrderingFormBrett_Load(object sender, EventArgs e)
        {
            productList = Business.ProductList();

            pnlContainer.BorderStyle = BorderStyle.FixedSingle;

            currentCustomer = Business.GetCustomer(customerID);
            txtPostalCode.Text = currentCustomer.PostalCode;
            txtRegion.Text = currentCustomer.Region;
            txtShipAddress.Text = currentCustomer.Address;
            txtShipCity.Text = currentCustomer.City;
            txtShipCountry.Text = currentCustomer.Country;
            txtRegion.Text = currentCustomer.Region;
            txtFax.Text = currentCustomer.Fax;
            txtPhone.Text = currentCustomer.Phone;

            cmbShipVia.DataSource = Business.ShipperTable();
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShipVia.SelectedIndex = -1;

            TxtRequiredDateMethods();

            if (isEditting)
            {
                foreach (OrderDetail detail in tempDetailList)
                {
                    AddPanel(detail);
                }
            }

            AddPanel();
        }

        private void PreInitForm(string customerID, int employeeID)
        { 
            this.customerID = customerID;
            this.employeeID = employeeID;
            lblCustomerID.Text = customerID;
            lblEmployeeID.Text = employeeID.ToString();
        }

        private void AddPanel()
        {
            BrettProductPanel BPP = new BrettProductPanel(pnlList, productList, pnlContainer.Width, pnlContainer.Height, pnlContainer.Left);
            SetupPanel(BPP);
        }

        private void AddPanel(OrderDetail detail)
        {
            BrettProductPanel BPP = new BrettProductPanel(pnlList, productList, pnlContainer.Width, pnlContainer.Height, pnlContainer.Left, detail.ProductID, detail.Quantity, detail.Discount, detail.UnitPrice);
            SetupPanel(BPP);
        }

        private void SetupPanel(BrettProductPanel BPP)
        {
            try
            {
                lblError.Text = "";
                pnlContainer.Controls.Add(BPP);
                pnlList.Add(BPP);
                BPP.RemovePanel += RemovePanel;
                BPP.AddProductPanel += AddPanel;
                BPP.CalcFreight += CalculateFreight;

                // I dont know if I like this way for it is efficient
                lblProduct.Left = BrettProductPanel.lblProductX;
                lblPrice.Left = BrettProductPanel.lblPriceX;
                lblUnits.Left = BrettProductPanel.lblUnitsX;
                lblQuantity.Left = BrettProductPanel.lblQuantityX;
                lblDiscount.Left = BrettProductPanel.lblDiscountX;
                lblTotalPrice.Left = BrettProductPanel.lblTotalPriceX;
                BPP.WowSelectedIndexIsAnnoying();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
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
                orderID = o.OrderID;
                lblOrderID.Text = orderID.ToString();
                btnCommitDetails.Enabled = true;
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
            foreach (BrettProductPanel pnl in pnlList)
            {
                freight += pnl.totalPrice;
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

        public void RemovePanel(BrettProductPanel BPP)
        {
            pnlContainer.Controls.Remove(BPP);
            pnlList.Remove(BPP);
        }

        private void btnCommitDetails_Click(object sender, EventArgs e)
        {
            detailList = new List<OrderDetail>();

            foreach (BrettProductPanel pnl in pnlList)
            {
                if (pnl.selectedProductID != -1 && pnl.quantity > 0)
                    detailList.Add(new OrderDetail(orderID, pnl.selectedProductID, pnl.totalPrice, pnl.quantity, pnl.discount));
            }
            Business.SaveDetails(orderID, detailList);

            btnCommitDetails.Enabled = true;
        }
    }
}
