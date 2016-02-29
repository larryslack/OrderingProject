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
        List<Panel> pnlList = new List<Panel>();
        Customer currentCustomer;

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

            currentCustomer = Business.GetCustomer(CustomerID);

            txtPostalCode.Text = currentCustomer.PostalCode;
            txtRegion.Text = currentCustomer.Region;
            txtShipAddress.Text = currentCustomer.Address;
            txtShipCity.Text = currentCustomer.City;
            txtShipCountry.Text = currentCustomer.Country;
            txtRegion.Text = currentCustomer.Region;
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
            int standardWidth = pnl.Width / 5 - 7; //Yay magic numbers.
            int standardHeight = pnl.Height - 18;
            int PosY = (pnl.Height / 4) - 2;
            int PosX = 5;

            ComboBox cmb = new ComboBox();
            cmb.Width = standardWidth;
            cmb.Height = standardHeight;
            cmb.Top = PosY;
            cmb.Left = PosX;
            SetupCombo(cmb, pnl);

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

            btnRemove.Click += (sender, e) =>
            {
                if (pnlContainer.Controls.Count > 1)
                {
                    for (int i = 0; i < pnlList.Count; i++)
                    {
                        if (pnlList[i] == pnl)
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
                    }
                }
            };

            // Add all of the new controls to the panel
            pnl.Controls.Add(cmb);
            cmb.SelectedIndex = -1;
            pnl.Controls.Add(txtPrice);
            pnl.Controls.Add(txtQuantity);
            pnl.Controls.Add(txtDiscount);
            pnl.Controls.Add(btnRemove);
        }

        private void SetupCombo(ComboBox cmb, Panel pnl)
        {
            cmb.DataSource = Business.ProductList();
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb.SelectedIndexChanged += (sender, e) =>
            {
                if (cmb.SelectedIndex == -1)
                    return;

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
                o.ShipVia = Convert.ToInt32(txtShipVia.Text);
                o.Freight = Convert.ToDecimal(txtFreight.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
