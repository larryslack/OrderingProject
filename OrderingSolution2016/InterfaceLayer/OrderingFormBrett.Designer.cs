﻿namespace InterfaceLayer
{
    partial class OrderingFormBrett
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
            this.btnRandomOrder = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandomOrder
            // 
            this.btnRandomOrder.Location = new System.Drawing.Point(15, 344);
            this.btnRandomOrder.Name = "btnRandomOrder";
            this.btnRandomOrder.Size = new System.Drawing.Size(180, 23);
            this.btnRandomOrder.TabIndex = 0;
            this.btnRandomOrder.Text = "Commit Order";
            this.btnRandomOrder.UseVisualStyleBackColor = true;
            this.btnRandomOrder.Click += new System.EventHandler(this.btnRandomOrder_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(92, 9);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "lblCustomerID";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(92, 44);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeID.TabIndex = 2;
            this.lblEmployeeID.Text = "lblEmployeeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CustomerID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "EmployeeID:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlContainer.Location = new System.Drawing.Point(244, 60);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(682, 371);
            this.pnlContainer.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(247, 44);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Product";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(334, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(426, 44);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(526, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.ForeColor = System.Drawing.Color.Gray;
            this.txtRequiredDate.Location = new System.Drawing.Point(95, 82);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(143, 20);
            this.txtRequiredDate.TabIndex = 10;
            this.txtRequiredDate.Text = "DD/MM/YYYY";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(95, 160);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(143, 20);
            this.txtShipAddress.TabIndex = 12;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(95, 186);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(143, 20);
            this.txtShipCity.TabIndex = 13;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(95, 212);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(143, 20);
            this.txtRegion.TabIndex = 14;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(95, 134);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(143, 20);
            this.txtFreight.TabIndex = 15;
            this.txtFreight.Text = "0.00";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(95, 238);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(143, 20);
            this.txtPostalCode.TabIndex = 16;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(95, 264);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(143, 20);
            this.txtShipCountry.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "RequiredDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ShipVia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ship Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Region";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Freight";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Ship City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Ship Address";
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(95, 107);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(143, 21);
            this.cmbShipVia.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(95, 316);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(143, 20);
            this.txtFax.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 290);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 20);
            this.txtPhone.TabIndex = 30;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Location = new System.Drawing.Point(212, 443);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 32;
            // 
            // OrderingFormBrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 479);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.btnRandomOrder);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtShipAddress);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "OrderingFormBrett";
            this.Text = "OrderingFromBrett";
            this.Load += new System.EventHandler(this.OrderingFormBrett_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomOrder;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblError;
    }
}