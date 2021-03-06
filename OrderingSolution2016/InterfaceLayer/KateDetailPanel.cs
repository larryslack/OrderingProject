﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;
using System.Drawing;
namespace InterfaceLayer
{
    class KateDetailPanel : Panel
    {
        #region Protected Fields

        private Panel mMotherPanel;
        private List<Product> mProductList;
        private ComboBox comboProduct;
        private TextBox txtQuantityPerUnit;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private TextBox txtLineTotal;
        private Button btnDelete;

        #endregion


        #region  public fields

        public OrderDetail OD;

        #endregion


        public KateDetailPanel(Panel MotherPanel, int locationy, int OrderID, List<Product> productlist)
        {
            mMotherPanel = MotherPanel;
            OD = new OrderDetail(OrderID, 0, 0, 1, 0);
            mProductList = productlist;
            //
            // comboProduct
            //
            comboProduct = new ComboBox();
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new System.Drawing.Point(4, 4);
            comboProduct.Name = "comboBox1";
            comboProduct.Size = new System.Drawing.Size(200, 21);
            comboProduct.TabIndex = 0;
            comboProduct.DataSource = productlist;
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID";
            comboProduct.SelectedIndex = -1;
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit = new TextBox();
            txtQuantityPerUnit.Location = new System.Drawing.Point(220, 4);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new System.Drawing.Size(120, 20);
            txtQuantityPerUnit.TabStop = false;
            txtQuantityPerUnit.ReadOnly = true;

            // 
            // txtPrice
            // 
            txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(360, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(70, 20);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // txtQuantity
            // 
            txtQuantity = new TextBox();
            txtQuantity.Location = new System.Drawing.Point(450, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Text = "1";
            txtQuantity.Size = new System.Drawing.Size(40, 20);
            txtQuantity.TabIndex = 2;
            txtQuantity.Validating += txtQuantity_Validating;
            txtQuantity.TextChanged += txtQuantity_TextChanged;



            // 
            // txtDiscount
            // 
            txtDiscount = new TextBox();
            txtDiscount.Location = new System.Drawing.Point(510, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(40, 20);
            txtDiscount.TabIndex = 3;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.Validating += txtDiscount_Validating;
            // 
            // txtLineTotal
            // 
            txtLineTotal = new TextBox();
            txtLineTotal.Location = new System.Drawing.Point(570, 4);
            txtLineTotal.Name = "txtLineTotal";
            txtLineTotal.Size = new System.Drawing.Size(40, 20);
            txtLineTotal.ReadOnly = true;
            txtLineTotal.TabIndex = 3;

            // 
            // btnDelete
            // 
            btnDelete = new Button();
            btnDelete.Location = new System.Drawing.Point(630, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(50, 20);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.BackColor = System.Drawing.Color.LightBlue;
            btnDelete.TabStop = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += btnDelete_Click;

            this.Controls.Add(comboProduct);
            this.Controls.Add(txtQuantityPerUnit);
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtDiscount);
            this.Controls.Add(txtLineTotal);
            this.Controls.Add(btnDelete);
            this.Location = new System.Drawing.Point(4, locationy);
            this.Name = "KateDetailPanel";
            this.Size = new System.Drawing.Size(700, 28);
            this.BackColor = Color.LightYellow;
            MotherPanel.Controls.Add(this);
            comboProduct.SelectedIndex = -1;

        }


        void btnDelete_Click(object sender, EventArgs e)
        {
            mMotherPanel.Controls.Remove(this);
        }


        void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                OD.UnitPrice = decimal.Parse(txtPrice.Text);
                if (OD.UnitPrice < 0)
                    throw new Exception("Invalid UnitPrice - cannot be negative");
                CalculateLineTotal();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }

        void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OD.UnitPrice = decimal.Parse(txtPrice.Text);
                if (OD.Quantity < 1)
                    throw new Exception("Invalid UnitPrice");
                CalculateLineTotal();
            }
            catch (Exception) //ignore errors for now, because we have the validating event to handle these
            {

            }

        }

        void txtQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                OD.Quantity = short.Parse(txtQuantity.Text);
                if (OD.Quantity < 1)
                    throw new Exception("Invalid Quantity - it must be 1 or more");
                CalculateLineTotal();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }
        void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OD.Quantity = short.Parse(txtQuantity.Text);
                if (OD.Quantity < 1)
                    throw new Exception("Invalid Quantity - it must be 1 or more");
                CalculateLineTotal();
            }
            catch (Exception) //ignore error for now, because user might be typing and not yet finished
            {

            }


        }


        void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduct.SelectedIndex >= 0 && txtPrice != null)
            {
                txtPrice.Text = mProductList[comboProduct.SelectedIndex].UnitPrice.ToString();
                txtQuantityPerUnit.Text = mProductList[comboProduct.SelectedIndex].QuantityPerUnit;
                OD.ProductID = (int)comboProduct.SelectedValue;
                // ShowDiscount();
            }
        }

        void CalculateLineTotal()
        {
            decimal LinePrice = OD.UnitPrice * OD.Quantity * (decimal)(1 - OD.Discount);
            txtLineTotal.Text = LinePrice.ToString("c");


        }
        //void ShowDiscount()
        //{
        //    txtDiscount.Text = Convert.ToString(OD.Discount * 100);
        //}
        void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtDiscount.Text.Trim() != "")
                {
                    OD.Discount = float.Parse(txtDiscount.Text) / 100;
                    if (OD.Discount > 1)
                    {
                        throw new Exception("Invalid Discount-Discount should not be greater than 100.");
                    }
                    else if (OD.Discount < 0)
                    {
                        throw new Exception("Invalid Discount- Discount can not be less  than 0.");
                    }
                }
                else
                    OD.Discount = 0;
                CalculateLineTotal();
            }
            catch (Exception)
            {


            }

        }

        void txtDiscount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            try
            {
                if (txtDiscount.Text.Trim() != "")
                {
                    OD.Discount = float.Parse(txtDiscount.Text) / 100;
                    if (OD.Discount > 1)
                    {
                        throw new Exception("Invalid Discount-Discount should not be greater than 100.");
                    }
                    else if (OD.Discount < 0)
                    {
                        throw new Exception("Invalid Discount- Discount can not be less  than 0.");
                    }
                }
                else
                    OD.Discount = 0;
                CalculateLineTotal();

                //ShowDiscount();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                e.Cancel = true;

            }





        }

    }
}
