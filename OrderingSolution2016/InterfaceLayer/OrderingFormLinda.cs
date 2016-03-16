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
    public partial class OrderingFormLinda : Form
    {

        string CustomerID;
        int EmployeeID;
        Customer Cust;
        List<Product> productItems;
        Order NewOrder;
        OrderDetail newOrderDetails;
        List<OrderDetail> NewOrderDet;

        public OrderingFormLinda(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            lblCustomerID.Text = CustomerID;
            List<Customer> Clist = Business.CustomerList();
            foreach (Customer C in Clist)
            {
                if (C.CustomerID == CustomerID)
                    Cust = C;
            }
            lblCompanyName.Text = Cust.CompanyName;
            txtCustName.Text = Cust.CompanyName;
            txtPostCode.Text = Cust.PostalCode;
            txtShipAdd.Text = Cust.Address;
            txtShipCity.Text = Cust.City;
            txtshipCountry.Text = Cust.Country;
            lblEmpID.Text = EmployeeID.ToString();
            txtShipRegion.Text = Cust.Region;
            txtPhoneNum.Text = Cust.Phone;

            cbShipVia.DataSource = Business.ShipperTable();
            cbShipVia.ValueMember = "ShipperID";
            cbShipVia.DisplayMember = "CompanyName";
            cbShipVia.SelectedIndex = -1;

            cbSelectProduct.DataSource = Business.ProductList();
            cbSelectProduct.DisplayMember = "ProductName";
            cbSelectProduct.ValueMember = "ProductID";
            cbSelectProduct.SelectedIndex = -1;
        }

        private void OrderingFormLinda_Load(object sender, EventArgs e)
        {

        }

        void EditCustomerInfo()
        {

        }

        void PlacingOrder()
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtReqDate.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Cannot ship item today. Please choose a future required date.");
                    return;
                }
                else
                {
                    int? shipvia = null;

                    shipvia = (int?)cbShipVia.SelectedValue;
                    NewOrder = new Order(0, CustomerID, EmployeeID, DateTime.Now, dtReqDate.Value.Date, null, shipvia, null, txtCustName.Text,
                       txtShipAdd.Text, txtShipCity.Text, txtShipRegion.Text, txtPostCode.Text, txtshipCountry.Text);
                    Business.SaveOrder(NewOrder);
                    txtOrderId.Text = NewOrder.OrderID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSelectProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                productItems = new List<Product>();
                NewOrderDet = new List<OrderDetail>();
                string selectedProduct = cbSelectProduct.SelectedText;
                //DGV.DataSource = Business.OrderDetailList(Convert.ToInt32(txtOrderId.Text));
                DGV.CurrentRow.Cells["Product"].Value = cbSelectProduct.SelectedValue;
                DGV.CurrentRow.Cells["Quantity"].Value = newOrderDetails.Quantity;

                txtChangeQuantity.Text = DGV.CurrentRow.Cells["Quantity"].Value.ToString();

                if (Convert.ToInt32(txtChangeQuantity.Text) < 50)
                {
                    double normalPrice = Convert.ToInt32(txtChangeQuantity.Text) * Convert.ToUInt32(newOrderDetails.UnitPrice);
                    DGV.CurrentRow.Cells["Price"].Value = newOrderDetails.UnitPrice;
                    DGV.CurrentRow.Cells["Total"].Value = normalPrice;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 50 || Convert.ToInt32(txtChangeQuantity.Text) < 100)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetails.UnitPrice) - (Convert.ToUInt32(newOrderDetails.UnitPrice) * .1);
                    double TenPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price50To100"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = TenPercent;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 100 || Convert.ToInt32(txtChangeQuantity.Text) < 500)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetails.UnitPrice) - (Convert.ToUInt32(newOrderDetails.UnitPrice) * .2);
                    double TwentyPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price100To500"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = TwentyPercent;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 500)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetails.UnitPrice) - (Convert.ToUInt32(newOrderDetails.UnitPrice) * .2);
                    double ThirtyFivePercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price500OrMore"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = ThirtyFivePercent;
                }

                //foreach (DataGridView tmp in DGV.Controls)
                //{
                //    if (DGV.ProductName != null)
                //    {

                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
