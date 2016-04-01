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
        private Order curOrder;

        private List<Shipper> shipperList;

        public OrderingFormBrett(string customerID, int emloyeeID)
        {
            InitializeComponent();
            PreInitForm(customerID, emloyeeID);
        }

        public OrderingFormBrett(string customerID, int employeeID, int orderID)
        {
            InitializeComponent();
            PreInitForm(customerID, employeeID);
            curOrder = Business.FindOrder(orderID);
            this.orderID = curOrder.OrderID;
            tempDetailList = Business.OrderDetailList(orderID);
            isEditting = true;
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

            shipperList = Business.ShipperTable();
            cmbShipVia.DataSource = shipperList;
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShipVia.SelectedIndex = -1;

            TxtRequiredDateMethods();

            if (isEditting)
            {
                LoadOrder();
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

        private void LoadOrder()
        {
            lblOrderID.Text = orderID.ToString();
            txtRequiredDate.Text = curOrder.RequiredDate.ToString();
            
            for (int i = 0; i < shipperList.Count; i++)
                if (shipperList[i].ShipperID == curOrder.ShipVia)
                    cmbShipVia.SelectedIndex = i;
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
                if (curOrder != null)
                    curOrder = new Order(1);

                curOrder.CustomerID = lblCustomerID.Text;
                curOrder.EmployeeID = Convert.ToInt32(lblEmployeeID.Text);
                curOrder.OrderDate = DateTime.Now;
                curOrder.RequiredDate = Convert.ToDateTime(txtRequiredDate.Text);
                curOrder.ShippedDate = null;
                curOrder.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
                curOrder.Freight = Convert.ToDecimal(txtFreight.Text); //Retrieve later.
                curOrder.ShipName = currentCustomer.CompanyName;
                curOrder.ShipAddress = txtShipAddress.Text;
                curOrder.ShipCity = txtShipCity.Text;
                curOrder.ShipRegion = txtRegion.Text;
                curOrder.ShipPostalCode = txtPostalCode.Text;
                curOrder.ShipCountry = txtShipCountry.Text;
                curOrder.EmployeeName = null; // I need the employee name.
                curOrder.ShipperName = cmbShipVia.Text;

                Business.SaveOrder(curOrder);
                orderID = curOrder.OrderID;
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
