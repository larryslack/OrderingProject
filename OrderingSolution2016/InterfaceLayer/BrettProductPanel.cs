using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;
using System.Drawing;

namespace InterfaceLayer
{
    public class BrettProductPanel : Panel
    {
        public delegate void RemoveProductPanel(BrettProductPanel BPP);
        public event RemoveProductPanel RemovePanel;

        #region Fields

        private ComboBox cmbProducts;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtPrice;
        private List<Product> productList = new List<Product>();
        private static List<BrettProductPanel> panelList = new List<BrettProductPanel>();
        private int containerX = 0;

        #endregion

        #region Properties

        public int selectedProductID { get; private set; }
        public int quantity { get; private set; }
        public int discount { get; private set; }
        public int price { get; private set; }
        public bool blnLastPanel { get; private set; }

        public static int lblProductX { get; private set; }
        public static int lblQuantityX { get; private set; }
        public static int lblDiscountX { get; private set; }
        public static int lblPriceX { get; private set; }

        #endregion

        public BrettProductPanel(List<Product> productList, int containerWidth, int containerHeight, int containerLeft)
        {
            int panelCount = panelList.Count;
            containerX = containerLeft;

            this.Width = containerWidth - 25;
            this.Height = 40;

            if (panelList.Count > 0)
                this.Top = panelList[panelCount - 1].Height + panelList[panelCount - 1].Top + 5;
            else
                this.Top = 5;

            this.Left = 4;
            this.BorderStyle = BorderStyle.FixedSingle;

            this.productList = new List<Product>(productList);
            panelList.Add(this);

            SetupControls();
            SetupComboBox();
            AddContols();
        }

        private void SetupControls()
        {
            int standardWidth = 100; //Yay magic numbers.
            int standardHeight = this.Height - 18;
            int PosY = (this.Height / 4) - 2;
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
            txtQuantity.Name = "txtQuantity" + panelList.Count;

            TextBox txtDiscount = new TextBox();
            txtDiscount.Width = standardWidth;
            txtDiscount.Height = standardHeight;
            txtDiscount.Top = PosY;
            txtDiscount.Left = txtQuantity.Left + standardWidth + PosX;
            txtDiscount.Text = "0";
            txtDiscount.Name = "txtDiscount" + panelList.Count;

            TextBox txtPrice = new TextBox();
            txtPrice.Width = standardWidth;
            txtPrice.Height = standardHeight;
            txtPrice.Top = PosY;
            txtPrice.Left = txtDiscount.Left + standardWidth + PosX;
            txtPrice.ReadOnly = true;
            txtPrice.Text = "0.00";
            txtPrice.Name = "txtPrice" + panelList.Count;

            Button btnRemove = new Button();
            btnRemove.Width = standardWidth;
            btnRemove.Height = standardHeight;
            btnRemove.Top = PosY;
            btnRemove.Left = txtPrice.Left + standardWidth + PosX;
            btnRemove.Text = "Remove";
            btnRemove.ForeColor = Color.Black;
            btnRemove.BackColor = Color.PaleVioletRed;

            // This code is so ugly :<
            lblProductX = (containerX + cmb.Left + (cmb.Width / 2) - PosX * 3);
            lblQuantityX = (containerX + txtQuantity.Left + (txtQuantity.Width / 2) - PosX * 3);
            lblDiscountX = (containerX + txtDiscount.Left + (txtDiscount.Width / 2) - PosX * 3);
            lblPriceX = (containerX + txtPrice.Left + (txtPrice.Width / 2) - PosX * 3);

            btnRemove.Click += (sender, e) =>
            {
                for (int i = 0; i < panelList.Count; i++)
                {
                    if (panelList[i] == this)
                    {
                        if (i != panelList.Count - 1)
                        {
                            int setPosY;
                            for (int k = panelList.Count - 1; k > i; k--)
                            {
                                setPosY = panelList[k - 1].Top;
                                panelList[k].Top = setPosY;
                            }

                            RemovePanel(this);
                            panelList.Remove(this);
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
                int quantity = 0;
                decimal discount = 0;
                int index = Convert.ToInt32(cmb.SelectedValue);

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

                //txtPrice.Text = CalculatePrice(quantity, discount, index).ToString("###0.00");
                //CalculateFreight();
            };

            txtDiscount.TextChanged += (sender, e) =>
            {
                int quantity = 0;
                decimal discount = 0;
                int index = Convert.ToInt32(cmb.SelectedValue);

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

                //txtPrice.Text = CalculatePrice(quantity, discount, index).ToString("###0.00");
                //CalculateFreight();
            };

            //SetupCombo(cmb, pnl, txtQuantity, txtDiscount, txtPrice);
            //pnl.Controls.Add(btnRemove);
        }

        private void SetupComboBox()
        {
            cmbProducts.SelectedIndexChanged += cmbProductsSelected;
            cmbProducts.DataSource = productList;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbProductsSelected(object sender, EventArgs e)
        {
            bool blnLastPanel = false;
            int currentPanelIndex = 0;
            int panelIndexCount = panelList.Count - 1;

            if (cmbProducts.SelectedIndex == -1)
                return;

            selectedProductID = cmbProducts.SelectedIndex;

            for (int i = 0; i < panelList.Count; i++)
            {
                if (this == panelList[i])
                {
                    currentPanelIndex = i;
                }
            }

            if (currentPanelIndex == panelIndexCount)
            {
                blnLastPanel = true;
            }

            this.blnLastPanel = blnLastPanel;
        }

        private void AddContols()
        {
            // Add all of the new controls to the panel
            this.Controls.Add(cmbProducts);
            cmbProducts.SelectedIndex = -1;
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtDiscount);

            this.Controls.Add(cmbProducts);
        }

        public void FoundSameProduct(bool blnFoundSame)
        {
            if (blnFoundSame)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.FromKnownColor(KnownColor.Window);
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
    }
}
