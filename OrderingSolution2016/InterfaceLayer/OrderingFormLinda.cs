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
        int OrderID;
        Customer Cust;
        List<Product> productItems;
        Order ThisOrder;
        OrderDetail newOrderDetail;
        List<OrderDetail> OrderDetailList;
        bool MakingNewOrder;

        public OrderingFormLinda(string CustomerID, int EmployeeID) //this constructor will be called if we are supposed to add a new order
        {
            InitializeComponent();
            MakingNewOrder = true;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;

            lblCustomerID.Text = CustomerID;
            Cust = Business.GetCustomer(CustomerID);


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

        public OrderingFormLinda(string CustomerID, int EmployeeID, int OrderID) //this constructor will be called if we are editing an existing order with orderid OrderID
        {
            InitializeComponent();
            MakingNewOrder = false;
            this.CustomerID = CustomerID;
            this.EmployeeID = EmployeeID;
            this.OrderID = OrderID;

            lblCustomerID.Text = CustomerID;


            //get order and details from business layer
            ThisOrder = Business.FindOrder(OrderID);
            this.OrderDetailList = Business.OrderDetailList(OrderID);

            //display order information and detail information

            Cust = Business.GetCustomer(CustomerID);

            txtCustName.Name = "CustomerID";
            txtCustName.Text = CustomerID;
            txtPostCode.Text = ThisOrder.ShipPostalCode;
            txtShipAdd.Text = ThisOrder.ShipAddress;
            txtShipCity.Text = ThisOrder.ShipCity;
            txtshipCountry.Text = ThisOrder.ShipCountry;
            lblEmpID.Text = EmployeeID.ToString();
            txtShipRegion.Text = ThisOrder.ShipRegion;
            txtPhoneNum.Name = "OrderID";
            txtPhoneNum.Text = OrderID.ToString();


            cbShipVia.DataSource = Business.ShipperTable();
            cbShipVia.ValueMember = "ShipperID";
            cbShipVia.DisplayMember = "CompanyName";
            cbShipVia.SelectedIndex = -1;

            cbSelectProduct.DataSource = Business.ProductList();
            cbSelectProduct.DisplayMember = newOrderDetail.ProductName;
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
                    ThisOrder = new Order(0, CustomerID, EmployeeID, DateTime.Now, dtReqDate.Value.Date, null, shipvia, null, txtCustName.Text,
                       txtShipAdd.Text, txtShipCity.Text, txtShipRegion.Text, txtPostCode.Text, txtshipCountry.Text);
                    Business.SaveOrder(ThisOrder);
                    txtOrderId.Text = ThisOrder.OrderID.ToString();
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
                OrderDetailList = new List<OrderDetail>();
                string selectedProduct = cbSelectProduct.SelectedText;

                DGV.CurrentRow.Cells["Product"].Value = cbSelectProduct.SelectedValue;
                DGV.CurrentRow.Cells["Quantity"].Value = newOrderDetail.Quantity;

                txtChangeQuantity.Text = DGV.CurrentRow.Cells["Quantity"].Value.ToString();

                if (Convert.ToInt32(txtChangeQuantity.Text) < 50)
                {
                    double normalPrice = Convert.ToInt32(txtChangeQuantity.Text) * Convert.ToUInt32(newOrderDetail.UnitPrice);
                    DGV.CurrentRow.Cells["Price"].Value = newOrderDetail.UnitPrice;
                    DGV.CurrentRow.Cells["Total"].Value = normalPrice;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 50 || Convert.ToInt32(txtChangeQuantity.Text) < 100)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .1);
                    double TenPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price50To100"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = TenPercent;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 100 || Convert.ToInt32(txtChangeQuantity.Text) < 500)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .2);
                    double TwentyPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price100To500"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = TwentyPercent;
                }
                else if (Convert.ToInt32(txtChangeQuantity.Text) >= 500)
                {
                    double normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .2);
                    double ThirtyFivePercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                    DGV.CurrentRow.Cells["Price500OrMore"].Value = normalPrice;
                    DGV.CurrentRow.Cells["Total"].Value = ThirtyFivePercent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            short qty=1;
            decimal unitPrice=0;
            decimal normalPrice=0, TenPercent=0, TwentyPercent=0, ThirtyFivePercent=0, TotalLinePrice=0; 
            try
            {
                //DGV.Rows.Add("Chai",1, 1,10,20,10,0);
                string selectedProduct = cbSelectProduct.SelectedText;
                if (cbSelectProduct.SelectedValue != null)
                {



                    if (txtChangeQuantity.Text != null)
                    {
                        qty = short.Parse(txtChangeQuantity.Text);


                        if (qty < 50)
                        {
                             normalPrice = Convert.ToInt32(txtChangeQuantity.Text) * Convert.ToUInt32(newOrderDetail.UnitPrice);
                            DGV.Rows.Add("Price");
                            //DGV.CurrentRow.Cells["Price"].Value = newOrderDetail.UnitPrice;
                            //DGV.CurrentRow.Cells["Total"].Value = normalPrice;
                        }
                        else if (qty >= 50 || qty < 100)
                        {
                            // normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .1);
                             TenPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                            //DGV.CurrentRow.Cells["Price50To100"].Value = normalPrice;
                            //DGV.CurrentRow.Cells["Total"].Value = TenPercent;
                        }
                        else if (qty>= 100 || qty < 500)
                        {
                           //  normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .2);
                             TwentyPercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                            //DGV.CurrentRow.Cells["Price100To500"].Value = normalPrice;
                            //DGV.CurrentRow.Cells["Total"].Value = TwentyPercent;
                        }
                        else if (Convert.ToInt32(txtChangeQuantity.Text) >= 500)
                        {
                            // normalPrice = Convert.ToUInt32(newOrderDetail.UnitPrice) - (Convert.ToUInt32(newOrderDetail.UnitPrice) * .2);
                             ThirtyFivePercent = Convert.ToUInt32(txtChangeQuantity.Text) * normalPrice;
                            //DGV.CurrentRow.Cells["Price500OrMore"].Value = normalPrice;
                            //DGV.CurrentRow.Cells["Total"].Value = ThirtyFivePercent;
                        }







                    }







                    DGV.Rows.Add(cbSelectProduct.SelectedText, qty, normalPrice,TenPercent);

                }
                DGV.CurrentRow.Cells["Product"].Value = cbSelectProduct.SelectedValue;
                DGV.CurrentRow.Cells["Quantity"].Value = newOrderDetail.Quantity;

                txtChangeQuantity.Text = DGV.CurrentRow.Cells["Quantity"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
