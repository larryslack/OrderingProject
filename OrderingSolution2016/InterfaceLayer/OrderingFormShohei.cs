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
using DatabaseLayer;
namespace InterfaceLayer
{

    public partial class btnProSave : Form
    {

        int n = 0;

        int l = 3;
        int employeeID;
        Customer custerd;
        List<Product> ProductList = new List<Product>();
        List<OrderDetail> DetailList = new List<OrderDetail>();

        List<Panel> pnlList = new List<Panel>();
        List<ComboBox> cmbList = new List<ComboBox>();
        List<TextBox> txtPriceList = new List<TextBox>();
        List<TextBox> txtQuantityList = new List<TextBox>();
        List<TextBox> txtDiscountList = new List<TextBox>();
        List<Button> btnRemoveList = new List<Button>();

        int OrderID;



        public btnProSave(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            lblCust.Text = CustomerID;
            employeeID = EmployeeID;
            lblEmpl.Text = employeeID.ToString();
            custerd = Business.GetCustomer(CustomerID);
            txtShipName.Text = custerd.CompanyName;
            txtAddress.Text = custerd.Address;
            txtCity.Text = custerd.City;
            txtCountry.Text = custerd.Country;
            txtPost.Text = custerd.PostalCode;
            txtRegion.Text = custerd.Region;
        }

        public btnProSave(string CustomerID, int EmployeeID, int orderid)
        {
            InitializeComponent();
            button2.Enabled = false;
            OrderID = orderid;
            lblOrderID.Text = OrderID.ToString();

            lblCust.Text = CustomerID;
            employeeID = EmployeeID;
            lblEmpl.Text = employeeID.ToString();
            custerd = Business.GetCustomer(CustomerID);
            txtShipName.Text = custerd.CompanyName;
            txtAddress.Text = custerd.Address;
            txtCity.Text = custerd.City;
            txtCountry.Text = custerd.Country;
            txtPost.Text = custerd.PostalCode;
            txtRegion.Text = custerd.Region;

            DetailList = DB.OrderDetailList(OrderID);

            foreach (OrderDetail od in DetailList)
            {
                Panel ProductPanel = new Panel();
                ProductPanel.Height = 30;
                ProductPanel.Width = 500;
                pnlProducts.Controls.Add(ProductPanel);
                ProductPanel.BorderStyle = BorderStyle.FixedSingle;
                pnlList.Add(ProductPanel);

                ComboBox cmb = new ComboBox();
                ProductPanel.Controls.Add(cmb);
                cmb.Left = l;
                cmb.Tag = n;
                cmb.DataSource = new List<Product>(ProductList);
                cmb.DisplayMember = "ProductName";
                cmb.ValueMember = "ProductID";
                cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
                cmbList.Add(cmb);
                cmb.SelectedText = od.ProductName; // not sure if this is right

                TextBox p = new TextBox();
                p.Text = od.UnitPrice.ToString();
                ProductPanel.Controls.Add(p);
                p.Left = l + 120;
                p.Tag = n;
                txtPriceList.Add(p);

                TextBox q = new TextBox();
                q.Text = od.Quantity.ToString();
                ProductPanel.Controls.Add(q);
                q.Left = l + 220;
                q.Tag = n;
                txtQuantityList.Add(q);

                TextBox dis = new TextBox();
                dis.Text = od.Discount.ToString();
                ProductPanel.Controls.Add(dis);
                dis.Left = l + 320;
                dis.Tag = n;
                txtDiscountList.Add(dis);

                Button b = new Button();
                b.Text = "Remove";
                ProductPanel.Controls.Add(b);
                p.Tag = n;
                b.Left = l + 420;
                b.Tag = n;
                b.Click += Remove_Order;
                btnRemoveList.Add(b);

                n++;
                sortPanel();
            }
            DetailList.RemoveRange(0, DetailList.Count);
        }

        private void OrderingFormShohei_Load(object sender, EventArgs e)
        {
            ProductList = Business.ProductList();
            ShipList.DataSource = Business.ShipperTable();
            ShipList.DisplayMember = "CompanyName";
            ShipList.ValueMember = "ShipperID";



        }

        private void btnNewP_Click(object sender, EventArgs e)
        {

            Panel ProductPanel = new Panel();
            ProductPanel.Height = 30;
            ProductPanel.Width = 500;
            pnlProducts.Controls.Add(ProductPanel);
            ProductPanel.BorderStyle = BorderStyle.FixedSingle;
            pnlList.Add(ProductPanel);

            ComboBox cmb = new ComboBox();
            ProductPanel.Controls.Add(cmb);
            cmb.Left = l;
            cmb.Tag = n;
            cmb.DataSource = new List<Product>(ProductList);
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
            cmbList.Add(cmb);

            TextBox p = new TextBox();
            p.Text = "0";
            ProductPanel.Controls.Add(p);
            p.Left = l + 120;
            p.Tag = n;
            txtPriceList.Add(p);

            TextBox q = new TextBox();
            q.Text = "0";
            ProductPanel.Controls.Add(q);
            q.Left = l + 220;
            q.Tag = n;
            txtQuantityList.Add(q);

            TextBox dis = new TextBox();
            dis.Text = "0";
            ProductPanel.Controls.Add(dis);
            dis.Left = l + 320;
            dis.Tag = n;
            txtDiscountList.Add(dis);

            Button b = new Button();
            b.Text = "Remove";
            ProductPanel.Controls.Add(b);
            p.Tag = n;
            b.Left = l + 420;
            b.Tag = n;
            b.Click += Remove_Order;
            btnRemoveList.Add(b);

            n++;
            sortPanel();
        }

        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thiscmb = (ComboBox)sender;//Check if this work
            bool once = true;
            foreach (ComboBox tmp in cmbList)
            {
                if (thiscmb.SelectedValue == tmp.SelectedValue)
                    if (once)
                        once = false;
                    else
                        MessageBox.Show("There is already a product you selected, chnage to a different one!");
            }
            int index;
            if (thiscmb.SelectedIndex >= 0)
            {
                index = cmbList.IndexOf(thiscmb);
                txtPriceList[index].Text = ProductList[thiscmb.SelectedIndex].UnitPrice.ToString();
                txtQuantityList[index].Text = "0";//ProductList[thiscmb.SelectedIndex].QuantityPerUnit.ToString();

            }
        }

        void Remove_Order(object sender, EventArgs e)
        {
            Button thisbtn = (Button)sender;
            int index;
            index = btnRemoveList.IndexOf(thisbtn);
            cmbList.RemoveAt(index);
            txtPriceList.RemoveAt(index);
            txtQuantityList.RemoveAt(index);
            txtDiscountList.RemoveAt(index);
            btnRemoveList.RemoveAt(index);

            pnlProducts.Controls.Remove(pnlList[index]);
            pnlList.RemoveAt(index);

            sortPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal? freight;
            try
            {
                if (txtFreight.Text == "")
                    freight = null;
                else
                    freight = Convert.ToDecimal(txtFreight);



                Order SHoheiOrder = new Order(0, lblCust.Text, employeeID, DateTime.Now, DTRequired.Value, null, (int?)ShipList.SelectedValue,
                     freight, txtShipName.Text, txtAddress.Text, txtCity.Text, txtRegion.Text, txtPost.Text, txtCountry.Text);

                Business.SaveOrder(SHoheiOrder);
                OrderID = SHoheiOrder.OrderID;
                lblOrderID.Text = OrderID.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < pnlList.Count; i++)
                {
                    int ProductID = (int)cmbList[i].SelectedValue;
                    decimal UnitPrice = Convert.ToDecimal(txtPriceList[i].Text);
                    short Quantity = Convert.ToInt16(txtQuantityList[i].Text);
                    float Discount = Convert.ToSingle(txtDiscountList[i].Text) / 100;
                    OrderDetail od = new OrderDetail(OrderID, ProductID, UnitPrice, Quantity, Discount);
                    DetailList.Add(od);
                }
                Business.SaveDetails(OrderID, DetailList);
                MessageBox.Show("Products saved Properly, or is it?");
                DetailList.RemoveRange(0, DetailList.Count);//is it changing or not?
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void sortPanel()
        {
            int t = 0;
            foreach (Panel tmp in pnlList)
            {
                tmp.Top = t;
                tmp.Left = 0;
                t += 30;
            }
        }
    }
}
