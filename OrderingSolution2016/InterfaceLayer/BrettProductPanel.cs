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

        public delegate void AddNewProductPanel();
        public event AddNewProductPanel AddProductPanel;

        #region Fields

        private ComboBox cmbProducts;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtPrice;
        private Button btnRemove;
        private List<Product> productList = new List<Product>();
        private List<BrettProductPanel> panelList = new List<BrettProductPanel>();
        private int containerX = 0;

        #endregion

        #region Properties

        public int selectedProductID { get; private set; }
        public int quantity { get; private set; }
        public int discount { get; private set; }
        public decimal price { get; private set; }
        public decimal freight { get; private set; }

        public static int lblProductX { get; private set; }
        public static int lblQuantityX { get; private set; }
        public static int lblDiscountX { get; private set; }
        public static int lblPriceX { get; private set; }

        #endregion

        public BrettProductPanel(List<BrettProductPanel> panelList, List<Product> productList, int containerWidth, int containerHeight, int containerLeft)
        {
            this.panelList = panelList;
            this.productList = new List<Product>(productList);
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

            cmbProducts = new ComboBox();
            cmbProducts.Width = standardWidth * 2;
            cmbProducts.Height = standardHeight;
            cmbProducts.Top = PosY;
            cmbProducts.Left = PosX;

            txtQuantity = new TextBox();
            txtQuantity.Width = standardWidth;
            txtQuantity.Height = standardHeight;
            txtQuantity.Top = PosY;
            txtQuantity.Left = cmbProducts.Left + cmbProducts.Width + PosX;
            txtQuantity.Text = "1";
            txtQuantity.Name = "txtQuantity" + panelList.Count;

            txtDiscount = new TextBox();
            txtDiscount.Width = standardWidth;
            txtDiscount.Height = standardHeight;
            txtDiscount.Top = PosY;
            txtDiscount.Left = txtQuantity.Left + standardWidth + PosX;
            txtDiscount.Text = "1";
            txtDiscount.Name = "txtDiscount" + panelList.Count;

            txtPrice = new TextBox();
            txtPrice.Width = standardWidth;
            txtPrice.Height = standardHeight;
            txtPrice.Top = PosY;
            txtPrice.Left = txtDiscount.Left + standardWidth + PosX;
            txtPrice.ReadOnly = true;
            txtPrice.Text = "0.00";
            txtPrice.Name = "txtPrice" + panelList.Count;

            btnRemove = new Button();
            btnRemove.Width = standardWidth;
            btnRemove.Height = standardHeight;
            btnRemove.Top = PosY;
            btnRemove.Left = txtPrice.Left + standardWidth + PosX;
            btnRemove.Text = "Remove";
            btnRemove.ForeColor = Color.Black;
            btnRemove.BackColor = Color.PaleVioletRed;

            // This code is so ugly :<
            lblProductX = (containerX + cmbProducts.Left + (cmbProducts.Width / 2) - PosX * 3);
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
                        }
                        else
                        {
                            cmbProducts.SelectedIndex = -1;
                            txtQuantity.Text = "1";
                            txtDiscount.Text = "1";
                            txtPrice.Text = "0.00";
                        }
                    }
                }
            };

            txtQuantity.TextChanged += (sender, e) =>
            {
                PrepForCalculation();
            };

            txtDiscount.TextChanged += (sender, e) =>
            {
                PrepForCalculation();
            };
        }

        private void SetupComboBox()
        {
            cmbProducts.SelectedIndexChanged += cmbProductsProductsSelected;
            cmbProducts.DataSource = productList;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbProductsProductsSelected(object sender, EventArgs e)
        {
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
                AddProductPanel();
            }

            PrepForCalculation();
        }

        private void AddContols()
        {
            // Add all of the new controls to the panel
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtDiscount);
            this.Controls.Add(btnRemove);
            this.Controls.Add(cmbProducts);
            cmbProducts.SelectedIndex = -1;
        }

        public void FoundSameProduct(bool blnFoundSame)
        {
            if (blnFoundSame)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void PrepForCalculation()
        {
            try
            {
                quantity = 0;
                discount = 0;

                int index = Convert.ToInt32(cmbProducts.SelectedValue);

                if (txtQuantity.Text == "")
                {
                    txtQuantity.Text = "1";
                    throw new Exception("You can only use non positive whole numbers");
                }
                else
                    quantity = Convert.ToInt32(txtQuantity.Text);

                if (txtDiscount.Text == "") // Needs regex.
                    txtDiscount.Text = "0";
                else
                    discount = Convert.ToInt32(txtDiscount.Text);

                CalcPrice(quantity, discount, index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcPrice(int quantity, decimal discount, int index)
        {
            decimal discountPrice = 0;

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

            price = (productList[index].UnitPrice * quantity) - discountPrice;
            txtPrice.Text = price.ToString("###0.00");
        }

        private void CalculateFreight()
        {
            freight = 0;
            foreach (BrettProductPanel pnl in panelList)
            {
                freight += pnl.price;
            }
        }


        /// <summary>
        /// For some reason selected index doesnt want to play nice, so I call it again at the end of it all.
        /// </summary>
        public void WowSelectedIndexIsAnnoying()
        {
            cmbProducts.SelectedIndex = -1;
        }
    }
}
