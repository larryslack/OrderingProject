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
    public partial class OrderingFormBrent : Form
    {
        string CurrentCustomer = "Error";
        int CurrentEmployee = 0;

        List<Product> fer = Business.ProductList();

        public OrderingFormBrent()
        {
            //List<Product> = 
            InitializeComponent();
            //ProductBox.Items = 
        }

        public OrderingFormBrent(string CustomerID, int EmployeeID)
        {
            InitializeComponent();
            CurrentCustomer = CustomerID;
            CurrentEmployee = EmployeeID;
            CustLbl.Text += CurrentCustomer;
            UserLbl.Text += CurrentEmployee.ToString();
            //ProductBox.Items
            foreach (Product er in fer)
            {
                ProductBox.Items.Add(er.ProductName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedIndex >= 0)
                OrderList.Items.RemoveAt(OrderList.SelectedIndex);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string AddToOrder = "";
            AddToOrder += ProductBox.SelectedItem.ToString();
            AddToOrder += " (" + QuantityUpdown.Value + ") : ";
            //decimal DaPrice = fer[ProductBox.SelectedIndex].UnitPrice;
            //DaPrice = (DaPrice * QuantityUpdown.Value);
            //AddToOrder += DaPrice.ToString("c");
            AddToOrder += PriceBox.Text;
            OrderList.Items.Add(AddToOrder);
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string thing = fer.items
            InStockBox.Text = fer[ProductBox.SelectedIndex].UnitInStock.ToString();
            SupplierBox.Text = fer[ProductBox.SelectedIndex].SupplierID.ToString();
            if (InStockBox.Text == "0")
            {
                QuantityUpdown.Value = 0;
                AddBtn.Enabled = false;
            }
            else
            {
                QuantityUpdown.Value = 1;
                AddBtn.Enabled = true;
            }
            DiscountUpDown.Value = 0;
            decimal IShouldRenameThat = fer[ProductBox.SelectedIndex].UnitPrice; //Unit Price
            string IShouldRenameThisToo; //Quantity per Unit
            //if (fer[ProductBox.SelectedIndex].QuantityPerUnit == null)
            IShouldRenameThisToo = fer[ProductBox.SelectedIndex].QuantityPerUnit;
            QPUBox.Text = IShouldRenameThisToo;
            PriceBox.Text = IShouldRenameThat.ToString("c");
        }

        private void QuantityUpdown_ValueChanged(object sender, EventArgs e)
        {
            if ((ProductBox.SelectedIndex >= 0) == false) //weird way to do it but im too lazy to look it up
                return;
            if (QuantityUpdown.Value > Convert.ToInt16(InStockBox.Text))
                QuantityUpdown.Value--;
            //decimal DaPrice = fer[ProductBox.SelectedIndex].UnitPrice;
            //DaPrice = (DaPrice * QuantityUpdown.Value);
            PriceBox.Text = CalculatePrice().ToString("c");
        }

        private void DiscountUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PriceBox.Text = CalculatePrice().ToString("c");
        }

        private decimal CalculatePrice()
        {
            if ((ProductBox.SelectedIndex >= 0) == false) //weird way to do it but im too lazy to look it up
                return 0;
            decimal TooLazyToRenameThem = fer[ProductBox.SelectedIndex].UnitPrice;
            TooLazyToRenameThem = TooLazyToRenameThem * QuantityUpdown.Value * (1 - DiscountUpDown.Value);
            return TooLazyToRenameThem;
        }

        private void OrderingFormBrent_Load(object sender, EventArgs e)
        {
            CustIDBox.Text = CurrentCustomer;
        }

        private void FinalBtn_Click(object sender, EventArgs e)
        {
            if (FinalBtn.Text == "Finalize")
            {
                FinalBtn.Text = "Unfinalize";
                OrderingToShipping(true);
                OrderList.Items.Add("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
                OrderList.Items.Add("Conglaturation");
            }
            else
            {
                FinalBtn.Text = "Finalize";
                OrderingToShipping(false);
                OrderList.Items.Remove("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
                OrderList.Items.Remove("Conglaturation");
            }
        }
        private void OrderingToShipping(bool DatWay)
        {
            ShippingPanel.Enabled = DatWay;
            RemoveBtn.Enabled = !DatWay;
            AddBtn.Enabled = !DatWay;
            ProductBox.Enabled = !DatWay;
            QuantityUpdown.Enabled = !DatWay;
            DiscountUpDown.Enabled = !DatWay;
            QPUBox.Enabled = !DatWay;
            PriceBox.Enabled = !DatWay;
            SupplierBox.Enabled = !DatWay;
            InStockBox.Enabled = !DatWay;
        }
    }
}
