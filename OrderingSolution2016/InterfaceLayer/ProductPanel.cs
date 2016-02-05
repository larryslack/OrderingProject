using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLayer
{
    class ProductPanel : Panel
    {
        #region Protected Fields
        protected ComboBox comboProduct;
        protected TextBox txtPrice;
        protected TextBox txtQuantity;
        protected TextBox txtDiscount;
        protected Button btnDelete;

        protected Panel Addto = new Panel();

        #endregion

        public ProductPanel(Panel add2, int locationy)
        {
            ComboBox comboProduct = new ComboBox();
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new System.Drawing.Point(4, 4);
            comboProduct.Name = "comboBox1";
            comboProduct.Size = new System.Drawing.Size(121, 21);
            comboProduct.TabIndex = 0;
            // 
            // textBox1
            // 
            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(131, 4);
            txtPrice.Name = "textBox1";
            txtPrice.Size = new System.Drawing.Size(70, 20);
            txtPrice.TabIndex = 1;
            // 
            // textBox2
            // 
            TextBox txtQuantity = new TextBox();
            txtQuantity.Location = new System.Drawing.Point(207, 4);
            txtQuantity.Name = "textBox2";
            txtQuantity.Size = new System.Drawing.Size(70, 20);
            txtQuantity.TabIndex = 2;
            // 
            // textBox3
            // 
            TextBox txtDiscount = new TextBox();
            txtDiscount.Location = new System.Drawing.Point(283, 4);
            txtDiscount.Name = "textBox3";
            txtDiscount.Size = new System.Drawing.Size(70, 20);
            txtDiscount.TabIndex = 3;
            // 
            // button1
            // 
            Button btnDelete = new Button();
            btnDelete.Location = new System.Drawing.Point(359, 4);
            btnDelete.Name = "button1";
            btnDelete.Size = new System.Drawing.Size(48, 20);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;

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
    }
}
