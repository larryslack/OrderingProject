﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using BusinessLayer;
using System.Drawing;
using System.Text.RegularExpressions;

namespace InterfaceLayer
{
    public class BrettProductPanel : Panel
    {
        public delegate void RemoveProductPanel(BrettProductPanel BPP);
        public event RemoveProductPanel RemovePanel;

        public delegate void AddNewProductPanel();
        public event AddNewProductPanel AddProductPanel;

        public delegate void CalculateFreight();
        public event CalculateFreight CalcFreight;

        public delegate void ErrorOccured(bool error);
        public event ErrorOccured ErrorInCommit;

        #region Fields

        public ComboBox cmbProducts;
        private TextBox txtPrice;
        private TextBox txtUnits;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtTotalPrice;
        private Button btnRemove;
        private List<Product> productList = new List<Product>();
        private List<BrettProductPanel> panelList = new List<BrettProductPanel>();
        private int containerX = 0;
        private bool isEdittingStart = false;

        private int defaultIndex = -1;
        private string strUnits = "Quantity Per Unit";

        #endregion

        #region Properties

        public int selectedProductID { get; private set; }
        public short quantity { get; private set; }
        public float discount { get; private set; }
        public decimal price { get; private set; }
        public decimal totalPrice { get; private set; }
        public decimal freight { get; private set; }

        public static int lblProductX { get; private set; }
        public static int lblPriceX { get; private set; }
        public static int lblUnitsX { get; private set; }
        public static int lblQuantityX { get; private set; }
        public static int lblDiscountX { get; private set; }
        public static int lblTotalPriceX { get; private set; }

        #endregion

        public BrettProductPanel(List<BrettProductPanel> panelList, List<Product> productList, int containerWidth, int containerHeight, int containerLeft)
        {
            this.selectedProductID = 0;
            this.quantity = 1;
            this.discount = 0;
            this.price = 0.00m;
            this.totalPrice = 0.00m;
            this.freight = 0.00m;

            SetupPanel(panelList, productList, containerWidth, containerHeight, containerLeft);
        }

        public BrettProductPanel(List<BrettProductPanel> panelList, List<Product> productList, int containerWidth, int containerHeight, int containerLeft, int selectedProductID, short quantity, float discount, decimal price)
        {
            this.quantity = quantity;
            this.discount = discount;
            this.price = price;
            this.totalPrice = 0;
            this.freight = 0;

            SetupPanel(panelList, productList, containerWidth, containerHeight, containerLeft);

            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].ProductID == selectedProductID)
                {
                    defaultIndex = i;
                }
            }

            isEdittingStart = true;
            PrepForCalculation();
        }

        private void SetupPanel(List<BrettProductPanel> panelList, List<Product> productList, int containerWidth, int containerHeight, int containerLeft)
        {
            this.panelList = panelList;
            this.productList = new List<Product>(productList);
            int panelCount = panelList.Count;
            containerX = containerLeft;

            this.Width = containerWidth - 10;
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
            int standardWidth = 80; //Yay magic numbers.
            int standardHeight = this.Height - 18;
            int PosY = (this.Height / 4) - 2;
            int PosX = 5;

            cmbProducts = new ComboBox();
            cmbProducts.Width = (standardWidth + 20) * 2;
            cmbProducts.Height = standardHeight;
            cmbProducts.Top = PosY;
            cmbProducts.Left = PosX;

            txtPrice = new TextBox();
            txtPrice.Width = standardWidth;
            txtPrice.Height = standardHeight;
            txtPrice.Top = PosY;
            txtPrice.Left = cmbProducts.Left + cmbProducts.Width + PosX;
            txtPrice.Text = price.ToString("#,##0.00"); // I need to test this before doing it to the rest.
            txtPrice.Name = "txtPrice" + panelList.Count;

            txtUnits = new TextBox();
            txtUnits.Width = standardWidth + 20;
            txtUnits.Height = standardHeight;
            txtUnits.Top = PosY;
            txtUnits.Left = txtPrice.Left + txtPrice.Width + PosX;
            txtUnits.Text = strUnits;
            txtUnits.Name = "txtUnits" + panelList.Count;
            txtUnits.ReadOnly = true;

            txtQuantity = new TextBox();
            txtQuantity.Width = standardWidth;
            txtQuantity.Height = standardHeight;
            txtQuantity.Top = PosY;
            txtQuantity.Left = txtUnits.Left + txtUnits.Width + PosX;
            txtQuantity.Text = quantity.ToString();
            txtQuantity.Name = "txtQuantity" + panelList.Count;

            txtDiscount = new TextBox();
            txtDiscount.Width = standardWidth;
            txtDiscount.Height = standardHeight;
            txtDiscount.Top = PosY;
            txtDiscount.Left = txtQuantity.Left + txtQuantity.Width + PosX;
            txtDiscount.Text = discount.ToString();
            txtDiscount.Name = "txtDiscount" + panelList.Count;
            txtDiscount.ForeColor = Color.Gray;

            txtTotalPrice = new TextBox();
            txtTotalPrice.Width = standardWidth;
            txtTotalPrice.Height = standardHeight;
            txtTotalPrice.Top = PosY;
            txtTotalPrice.Left = txtDiscount.Left + txtDiscount.Width + PosX;
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Text = "0.00";
            txtTotalPrice.Name = "txtTotalPrice" + panelList.Count;

            btnRemove = new Button();
            btnRemove.Width = standardWidth;
            btnRemove.Height = standardHeight;
            btnRemove.Top = PosY;
            btnRemove.Left = txtTotalPrice.Left + standardWidth + PosX;
            btnRemove.Text = "Remove";
            btnRemove.ForeColor = Color.Black;
            btnRemove.BackColor = Color.PaleVioletRed;

            // This code is so ugly :<
            lblProductX = (containerX + cmbProducts.Left + (cmbProducts.Width / 2) - PosX * 3);
            lblPriceX = (containerX + txtPrice.Left + (txtPrice.Width / 2) - PosX * 3);
            lblUnitsX = (containerX + txtUnits.Left + (txtUnits.Width / 2) - PosX * 3);
            lblQuantityX = (containerX + txtQuantity.Left + (txtQuantity.Width / 2) - PosX * 3);
            lblDiscountX = (containerX + txtDiscount.Left + (txtDiscount.Width / 2) - PosX * 3);
            lblTotalPriceX = (containerX + txtTotalPrice.Left + (txtTotalPrice.Width / 2) - PosX * 3);

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
                            txtDiscount.Text = "0";
                            txtTotalPrice.Text = "0.00";
                        }
                    }
                }

                CalcFreight();
            };

            txtPrice.TextChanged += (sender, e) =>
            {
                PrepForCalculation();
            };
            
            txtQuantity.TextChanged += (sender, e) =>
            {
                PrepForCalculation();
            };

            txtDiscount.TextChanged += (sender, e) =>
            {
                PrepForCalculation();
            };

            txtDiscount.Enter += (sender, e) =>
            {
                if (txtDiscount.Text == "0")
                {
                    txtDiscount.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
                    txtDiscount.Text = "";
                }
            };

            txtDiscount.Leave += (sender, e) =>
            {
                if (txtDiscount.Text == "")
                {
                    txtDiscount.ForeColor = Color.Gray;
                    txtDiscount.Text = "0";
                }
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

            selectedProductID = (int)cmbProducts.SelectedValue;

            txtUnits.Text = productList[selectedProductID - 1].QuantityPerUnit;

            this.BackColor = Color.Transparent;

            for (int i = 0; i < panelList.Count; i++)
            {
                if (this == panelList[i])
                {
                    currentPanelIndex = i;
                }

                if (panelList[i] != this && panelList[i].selectedProductID == this.selectedProductID)
                {
                    this.BackColor = Color.Red;
                    ErrorInCommit(true);
                }
                else
                {
                    ErrorInCommit(false);
                }
            }

            PrepForCalculation();

            // This is set so that if the user is editing it will not destroy the last copy of anything needed.
            if (!isEdittingStart)
            {
                txtPrice.Text = productList[selectedProductID - 1].UnitPrice.ToString("#,##0.00");

                if (currentPanelIndex == panelIndexCount)
                {
                    AddProductPanel();
                }
            }
            else
            {
                isEdittingStart = false;
            }
        }

        private void AddContols()
        {
            // Add all of the new controls to the panel
            this.Controls.Add(txtUnits);
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtTotalPrice);
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
                string priceExpression = @"^([0-9,]+)([.][0-9]{0,2})?$";
                Regex priceRegex = new Regex(priceExpression);

                string quantityExpression = @"^([1-9]\d{0,3})$";
                Regex quantityRegex = new Regex(quantityExpression);

                string discountExpression = @"^([0-9]\d{0,2})$";
                Regex discountRegex = new Regex(discountExpression);

                quantity = 1;
                discount = 0;
                price = 0;

                int index = -1;

                if (cmbProducts.SelectedValue != null)
                    index = Convert.ToInt32(cmbProducts.SelectedIndex);

                if (!(priceRegex.IsMatch(txtPrice.Text)))
                {
                    txtPrice.Text = productList[index].UnitPrice.ToString("#,##0.00");
                    throw new Exception("Only positive decimal values are allowed to be entered");
                }
                else
                {
                    price = Convert.ToDecimal(txtPrice.Text);
                }

                if (!(quantityRegex.IsMatch(txtQuantity.Text)))
                {
                    txtQuantity.Text = "1";
                    throw new Exception("You can only use non negative whole numbers, up to 4 digits for quantity");
                }
                else
                {
                    quantity = Convert.ToInt16(txtQuantity.Text);
                }

                if ((txtDiscount.Text != "") && !(discountRegex.IsMatch(txtDiscount.Text))) // Needs regex.
                {
                    txtDiscount.Text = "0";
                    //throw new Exception("You can only use non negative whole numbers, up to 2 digits for a discount");
                }
                else
                {
                    if (txtDiscount.Text == "")
                        discount = 0;
                    else
                        discount = Convert.ToInt32(txtDiscount.Text);
                }

                CalcPrice(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcPrice(int index)
        {
            // Need to make finishing changes on pricing any what not.
            if (index != -1)
            {
                decimal discountPrice = 0;

                // Puts the discount into percentage. Then adds one so when it is used it will take the percentage off.
                discount = discount / 100;
                discountPrice = price * quantity * Convert.ToDecimal(discount);

                totalPrice = (price * quantity) - discountPrice;

                txtTotalPrice.Text = totalPrice.ToString("###0.00");
                CalcFreight();
            }
        }

        private void LoadPanel()
        {
            txtUnits.Text = productList[selectedProductID - 1].QuantityPerUnit;
        }

        /// <summary>
        /// For some reason selected index doesnt want to play nice, so I call it again at the end of it all.
        /// </summary>
        public void WowSelectedIndexIsAnnoying()
        {
            cmbProducts.SelectedIndex = defaultIndex;
        }
    }
}
