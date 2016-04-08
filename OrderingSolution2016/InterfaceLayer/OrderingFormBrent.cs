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
        List<OrderDetail> BetterNameThanFer = new List<OrderDetail>();

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

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedIndex >= 0)
            {
                if (BetterNameThanFer[OrderList.SelectedIndex].ProductName == ProductBox.SelectedItem) //If the product being removed is the same as the one selected
                {
                    int k = BetterNameThanFer[OrderList.SelectedIndex].Quantity;
                    InStockBox.Text = (Convert.ToInt16(InStockBox.Text) + k).ToString();
                    AddBtn.Enabled = true;
                }
                BetterNameThanFer.RemoveAt(OrderList.SelectedIndex);
                OrderList.Items.RemoveAt(OrderList.SelectedIndex);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int InStock = Convert.ToInt16(InStockBox.Text);
            //Still need to make it check for multiple things with the same product but different discounts
            if (InStock <= 0)
                return;
            string AddToOrder = "";
            AddToOrder += ProductBox.SelectedItem.ToString();
            for (int j = 0; j < OrderList.Items.Count; j++)
            {
                if (BetterNameThanFer[j].ProductName == ProductBox.SelectedItem.ToString())
                {
                    if (BetterNameThanFer[j].Discount == Convert.ToSingle(DiscountUpDown.Value))
                    {
                        if (Convert.ToInt16(QuantityUpdown.Value) <= InStock)
                        {
                            BetterNameThanFer[j].Quantity += Convert.ToInt16(QuantityUpdown.Value);
                            AddToOrder += " (" + BetterNameThanFer[j].Quantity + ")";
                            InStockBox.Text = (InStock - (Convert.ToInt16(QuantityUpdown.Value))).ToString();
                            if (QuantityUpdown.Value > Convert.ToDecimal(InStockBox.Text))
                            {
                                QuantityUpdown.Value = Convert.ToDecimal(InStockBox.Text);
                                if (QuantityUpdown.Value == 0)
                                    AddBtn.Enabled = false;
                            }
                            if (DiscountUpDown.Value != 0)
                            {
                                AddToOrder += " [" + ((DiscountUpDown.Value) * 100).ToString("#") + "% Discount]";
                            }
                            decimal garb = fer[ProductBox.SelectedIndex].UnitPrice;
                            garb = garb * (BetterNameThanFer[j].Quantity * (1 - DiscountUpDown.Value));
                            AddToOrder += " : " + garb.ToString("c");
                            OrderList.Items[j] = AddToOrder;
                            decimal TooLazyToRenameThem = fer[ProductBox.SelectedIndex].UnitPrice;
                            BetterNameThanFer[j].UnitPrice = (TooLazyToRenameThem * BetterNameThanFer[j].Quantity) * (1 - DiscountUpDown.Value);
                            //TooLazyToRenameThem = TooLazyToRenameThem * QuantityUpdown.Value * (1 - DiscountUpDown.Value);
                            
                            return;
                        }
                        else
                            return;
                    }
                }
            }
            AddToOrder += " (" + QuantityUpdown.Value + ")";
            if (DiscountUpDown.Value != 0)
            {
                AddToOrder += " [" + ((DiscountUpDown.Value) * 100).ToString("#") + "% Discount]";
            }
            AddToOrder += " : " + PriceBox.Text;
            OrderList.Items.Add(AddToOrder);
            //Order Detail code
            int Das = ProductBox.SelectedIndex;
            //Need to make it so the Unit Price is properly calculated before entering it.  Ask Larry if I should do that, or calculate it during the finalize
            OrderDetail ThisPart = new OrderDetail(0, fer[Das].ProductID, fer[Das].UnitPrice, Convert.ToInt16(QuantityUpdown.Value), Convert.ToSingle(DiscountUpDown.Value));
            ThisPart.ProductName = ProductBox.SelectedItem.ToString();
            BetterNameThanFer.Add(ThisPart);
            InStockBox.Text = (InStock - (Convert.ToInt16(QuantityUpdown.Value))).ToString();
            if (QuantityUpdown.Value > Convert.ToDecimal(InStockBox.Text))
            {
                QuantityUpdown.Value = Convert.ToDecimal(InStockBox.Text);
                if (QuantityUpdown.Value == 0)
                    AddBtn.Enabled = false;
            }
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string thing = fer.items
            short? InStock = fer[ProductBox.SelectedIndex].UnitInStock;
            for (int j = 0; j < OrderList.Items.Count; j++)
            {
                if (BetterNameThanFer[j].ProductName == ProductBox.SelectedItem.ToString())
                {
                    InStock -= BetterNameThanFer[j].Quantity;
                }
            }
            InStockBox.Text = InStock.ToString();
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
                decimal TotalCost = 0;
                //for (int j = 0; j < OrderList.Items.Count; j++)
                //{
                //}
                OrderList.Items.Add("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
                OrderList.Items.Add("Conglaturation. It cost  " + TotalCost.ToString("c"));
            }
            else
            {
                FinalBtn.Text = "Finalize";
                OrderingToShipping(false);
                OrderList.Items.Remove("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
                OrderList.Items.RemoveAt(OrderList.Items.Count-1);
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

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Order NewOrder = new Order(3, CurrentCustomer, CurrentEmployee, DateTime.Today, RequiredDatePicker.Value, null, null, null, ShipNameBox.Text, ShipAddressBox.Text, ShipCityBox.Text, ShipRegionBox.Text, ShipPostalBox.Text, ShipCountryBox.Text);
            BusinessLayer.Business.SaveOrder(NewOrder);


            //Business.SaveDetails(NewOrder.OrderID,
        }
    }
}
