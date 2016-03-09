namespace InterfaceLayer
{
    partial class OrderingFormNathan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.txtfUnitPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblBaseCost = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsVia = new System.Windows.Forms.TextBox();
            this.txtrDate = new System.Windows.Forms.TextBox();
            this.txtsDate = new System.Windows.Forms.TextBox();
            this.lblVia = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.lblReqDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.btnAddOrd = new System.Windows.Forms.Button();
            this.lblRawPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // lblEmID
            // 
            this.lblEmID.AutoSize = true;
            this.lblEmID.Location = new System.Drawing.Point(130, 78);
            this.lblEmID.Name = "lblEmID";
            this.lblEmID.Size = new System.Drawing.Size(23, 13);
            this.lblEmID.TabIndex = 3;
            this.lblEmID.Text = "\" \" ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddtoOrder);
            this.panel1.Controls.Add(this.txtfUnitPrice);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.lblBaseCost);
            this.panel1.Controls.Add(this.txtDisc);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbProducts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(296, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 318);
            this.panel1.TabIndex = 4;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.Location = new System.Drawing.Point(522, 31);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(58, 48);
            this.btnAddtoOrder.TabIndex = 12;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // txtfUnitPrice
            // 
            this.txtfUnitPrice.Location = new System.Drawing.Point(443, 34);
            this.txtfUnitPrice.Name = "txtfUnitPrice";
            this.txtfUnitPrice.Size = new System.Drawing.Size(56, 20);
            this.txtfUnitPrice.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Final price after discount has been applied";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(603, 32);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Clear";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblBaseCost
            // 
            this.lblBaseCost.AutoSize = true;
            this.lblBaseCost.Location = new System.Drawing.Point(296, 42);
            this.lblBaseCost.Name = "lblBaseCost";
            this.lblBaseCost.Size = new System.Drawing.Size(20, 13);
            this.lblBaseCost.TabIndex = 7;
            this.lblBaseCost.Text = "\" \"";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(385, 35);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(40, 20);
            this.txtDisc.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(234, 42);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price per unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(17, 42);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(204, 21);
            this.cbProducts.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtCountry);
            this.panel2.Controls.Add(this.txtFax);
            this.panel2.Controls.Add(this.txtPostal);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtsVia);
            this.panel2.Controls.Add(this.txtrDate);
            this.panel2.Controls.Add(this.txtsDate);
            this.panel2.Controls.Add(this.lblVia);
            this.panel2.Controls.Add(this.lblShipDate);
            this.panel2.Controls.Add(this.lblReqDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 248);
            this.panel2.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(122, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 218);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(122, 189);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 16;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(122, 158);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 15;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(122, 130);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPostal.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "City";
            // 
            // txtsVia
            // 
            this.txtsVia.Location = new System.Drawing.Point(122, 77);
            this.txtsVia.Name = "txtsVia";
            this.txtsVia.Size = new System.Drawing.Size(100, 20);
            this.txtsVia.TabIndex = 8;
            // 
            // txtrDate
            // 
            this.txtrDate.Location = new System.Drawing.Point(122, 48);
            this.txtrDate.Name = "txtrDate";
            this.txtrDate.Size = new System.Drawing.Size(100, 20);
            this.txtrDate.TabIndex = 7;
            // 
            // txtsDate
            // 
            this.txtsDate.Location = new System.Drawing.Point(122, 22);
            this.txtsDate.Name = "txtsDate";
            this.txtsDate.Size = new System.Drawing.Size(100, 20);
            this.txtsDate.TabIndex = 6;
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.Location = new System.Drawing.Point(14, 77);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(46, 13);
            this.lblVia.TabIndex = 4;
            this.lblVia.Text = "Ship Via";
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(14, 22);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(51, 13);
            this.lblShipDate.TabIndex = 3;
            this.lblShipDate.Text = "ShipDate";
            // 
            // lblReqDate
            // 
            this.lblReqDate.AutoSize = true;
            this.lblReqDate.Location = new System.Drawing.Point(14, 48);
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(50, 13);
            this.lblReqDate.TabIndex = 2;
            this.lblReqDate.Text = "ReqDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shipping Details";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(130, 32);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(17, 13);
            this.lblCustId.TabIndex = 6;
            this.lblCustId.Text = "\"\"";
            // 
            // btnAddOrd
            // 
            this.btnAddOrd.Location = new System.Drawing.Point(739, 336);
            this.btnAddOrd.Name = "btnAddOrd";
            this.btnAddOrd.Size = new System.Drawing.Size(223, 23);
            this.btnAddOrd.TabIndex = 8;
            this.btnAddOrd.Text = "Commit";
            this.btnAddOrd.UseVisualStyleBackColor = true;
            this.btnAddOrd.Click += new System.EventHandler(this.btnAddOrd_Click);
            // 
            // lblRawPrice
            // 
            this.lblRawPrice.AutoSize = true;
            this.lblRawPrice.Location = new System.Drawing.Point(333, 374);
            this.lblRawPrice.Name = "lblRawPrice";
            this.lblRawPrice.Size = new System.Drawing.Size(17, 13);
            this.lblRawPrice.TabIndex = 9;
            this.lblRawPrice.Text = "\"\"";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(466, 374);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(17, 13);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "\"\"";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(578, 374);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(17, 13);
            this.lblFin.TabIndex = 11;
            this.lblFin.Text = "\"\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price Before Taxes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tax Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Final Cost After Taxes";
            // 
            // OrderingFormNathan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 396);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblRawPrice);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.btnAddOrd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderingFormNathan";
            this.Text = "OrderingFormNathan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddOrd;
        private System.Windows.Forms.Label lblVia;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.Label lblReqDate;
        private System.Windows.Forms.Label lblRawPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsVia;
        private System.Windows.Forms.TextBox txtrDate;
        private System.Windows.Forms.TextBox txtsDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddtoOrder;
    }
}