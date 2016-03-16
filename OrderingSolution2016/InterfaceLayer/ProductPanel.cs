using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLayer;

namespace InterfaceLayer
{
    class ProductPanel : Panel
    {
        public delegate void UpdatePrice();

        public event UpdatePrice updPrice;

        #region Protected Fields
        public ComboBox comboProduct;
        public TextBox txtPrice;
        public TextBox txtQuantity;
        public TextBox txtDiscount;
        public Button btnDelete;
        public List<Product> productListInternal;

        protected Panel Addto = new Panel();

        #endregion

        public ProductPanel(Panel add2, int locationy, List<Product> productlist)
        {

            productListInternal = new List<Product>(productlist);
            comboProduct = new ComboBox();
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new System.Drawing.Point(4, 4);
            comboProduct.Name = "comboBox1";
            comboProduct.Size = new System.Drawing.Size(121, 21);
            comboProduct.TabIndex = 0;
            comboProduct.DataSource = productListInternal;
            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductID";
            // 
            // textBox1
            // 
            txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(131, 4);
            txtPrice.Name = "textBox1";
            txtPrice.Text = "";
            txtPrice.Size = new System.Drawing.Size(70, 20);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // textBox2
            // 
            txtQuantity = new TextBox();
            txtQuantity.Location = new System.Drawing.Point(207, 4);
            txtQuantity.Name = "textBox2";
            txtQuantity.Size = new System.Drawing.Size(70, 20);
            txtQuantity.TabIndex = 2;
            txtQuantity.Text = "0";
            txtQuantity.TextChanged += txtPrice_TextChanged;
            // 
            // textBox3
            // 
            txtDiscount = new TextBox();
            txtDiscount.Location = new System.Drawing.Point(283, 4);
            txtDiscount.Name = "textBox3";
            txtDiscount.Size = new System.Drawing.Size(70, 20);
            txtDiscount.TabIndex = 3;
            int temp = 0;
            txtDiscount.Text = temp.ToString("P");
            txtDiscount.TextChanged += txtPrice_TextChanged;
            // 
            // button1
            // 
            btnDelete = new Button();
            btnDelete.Location = new System.Drawing.Point(359, 4);
            btnDelete.Name = "button1";
            btnDelete.Size = new System.Drawing.Size(48, 20);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.BackColor = System.Drawing.Color.LightPink;
            btnDelete.TabStop = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;

            this.Controls.Add(comboProduct);
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtDiscount);
            this.Controls.Add(btnDelete);
            this.Location = new System.Drawing.Point(4, locationy);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(414, 28);
            add2.Controls.Add(this);
        }

        void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (updPrice != null)
            updPrice();
        }
        public void updatePrice()
        {
            foreach (Product item in productListInternal)
            {
                if (item == comboProduct.SelectedItem)
                {
                    txtPrice.Text = item.UnitPrice.ToString("C");

                }                
            }

        }
    }
}
