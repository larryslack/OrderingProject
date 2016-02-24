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
        List<OrderDetail> DetailList = new List<OrderDetail>();

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
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.VerticalScroll.Visible = true;
            AddPanel();
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
            AddPanelControls(orderPnl);
        }

        private void AddPanelControls(Panel pnl)
        {
            int standardWidth = pnl.Width / 5 - 7; //Yay magic numbers.
            int standardHeight = pnl.Height - 18;
            int PosY = (pnl.Height / 4) - 2;
            int PosX = 5;

            ComboBox cmb = new ComboBox();
            cmb.Width = standardWidth;
            cmb.Height = standardHeight;
            cmb.Top = PosY;
            cmb.Left = PosX;
            SetupCombo(cmb);

            TextBox txtPrice = new TextBox();
            txtPrice.Width = standardWidth;
            txtPrice.Height = standardHeight;
            txtPrice.Top = PosY;
            txtPrice.Left = cmb.Left + standardWidth + PosX;

            TextBox txtQuantity = new TextBox();
            txtQuantity.Width = standardWidth;
            txtQuantity.Height = standardHeight;
            txtQuantity.Top = PosY;
            txtQuantity.Left = txtPrice.Left + standardWidth + PosX;

            TextBox txtDiscount = new TextBox();
            txtDiscount.Width = standardWidth;
            txtDiscount.Height = standardHeight;
            txtDiscount.Top = PosY;
            txtDiscount.Left = txtQuantity.Left + standardWidth + PosX;

            Button btnRemove = new Button();
            btnRemove.Width = standardWidth;
            btnRemove.Height = standardHeight;
            btnRemove.Top = PosY;
            btnRemove.Left = txtDiscount.Left + standardWidth + PosX;
            btnRemove.Text = "Remove";
            btnRemove.ForeColor = Color.Black;
            btnRemove.BackColor = Color.PaleVioletRed;
            btnRemove.Name = "del" + (pnlContainer.Controls.Count - 1).ToString();

            btnRemove.Click += (sender, e) =>
            {
                int index = Convert.ToInt16(((Button)sender).Name.Substring(3, cmb.Name.Length - 3));
                if (index > 0)
                {
                    if (index == (pnlContainer.Controls.Count - 1))
                    {
                        pnlContainer.Controls.RemoveAt(index);
                    }
                }
            };

            // Add all of the new controls to the panel
            pnl.Controls.Add(cmb);
            pnl.Controls.Add(txtPrice);
            pnl.Controls.Add(txtQuantity);
            pnl.Controls.Add(txtDiscount);
            pnl.Controls.Add(btnRemove);
        }

        private void SetupCombo(ComboBox cmb)
        {
            cmb.DataSource = Business.ProductList();
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.SelectedItem = null;
            cmb.Name = "cmb" + (pnlContainer.Controls.Count - 1).ToString();

            cmb.SelectedIndexChanged += (sender, e) =>
            {
                if (Convert.ToInt16(((ComboBox)sender).Name.Substring(3, cmb.Name.Length - 3)) == (pnlContainer.Controls.Count - 1))
                {
                    AddPanel();
                }
            };
        }

        private void btnRandomOrder_Click(object sender, EventArgs e)
        {
            try
            {
                AddPanel();
                //Order NewOrder = new Order(0, CustomerID, EmployeeID, DateTime.Now, DateTime.Now + new TimeSpan(7, 0, 0, 0), null, null, null, CustomerID + "Name", "123 4 St", "Medicine Hat", "AB", "T1A 7A7", "Canada");
                //Business.SaveOrder(NewOrder);
                //ls.Items.Add("The new order number is " + NewOrder.OrderID.ToString());
                //OrderDetail NewOrderDetail = new OrderDetail(NewOrder.OrderID, 22, 10.22m, 100, 0);
                //DetailList.Add(NewOrderDetail);

                //NewOrderDetail = new OrderDetail(NewOrder.OrderID, 33, 33.33m, 200, .2f);
                //DetailList.Add(NewOrderDetail);
                //Business.SaveDetails(NewOrder.OrderID, DetailList);
                //ls.Items.Add("Order and 2 details were saved Yeah!!!!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
