namespace InterfaceLayer
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
            this.btnMakeNewOrder = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCommitDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeNewOrder
            // 
            this.btnMakeNewOrder.Location = new System.Drawing.Point(1081, 233);
            this.btnMakeNewOrder.Name = "btnMakeNewOrder";
            this.btnMakeNewOrder.Size = new System.Drawing.Size(180, 23);
            this.btnMakeNewOrder.TabIndex = 0;
            this.btnMakeNewOrder.Text = "Make New Order";
            this.btnMakeNewOrder.UseVisualStyleBackColor = true;
            this.btnMakeNewOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(279, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeID.TabIndex = 2;
            this.lblEmployeeID.Text = "lblEmployeeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "EmployeeID:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlContainer.Location = new System.Drawing.Point(16, 56);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(775, 371);
            this.pnlContainer.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(16, 40);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Product";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(81, 40);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(195, 40);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(295, 40);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.ForeColor = System.Drawing.Color.Gray;
            this.txtRequiredDate.Location = new System.Drawing.Point(93, 44);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(143, 20);
            this.txtRequiredDate.TabIndex = 10;
            this.txtRequiredDate.Text = "DD/MM/YYYY";
            this.txtRequiredDate.Enter += new System.EventHandler(this.DateEnter);
            this.txtRequiredDate.Leave += new System.EventHandler(this.DateLeave);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(93, 130);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(143, 20);
            this.txtFreight.TabIndex = 15;
            this.txtFreight.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Required Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ShipVia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Freight";
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(93, 96);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(143, 21);
            this.cmbShipVia.TabIndex = 27;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Location = new System.Drawing.Point(-26, 443);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 32;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(133, 40);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 33;
            this.lblUnits.Text = "Units";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(170, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "Price";
            // 
            // btnCommitDetails
            // 
            this.btnCommitDetails.Enabled = false;
            this.btnCommitDetails.Location = new System.Drawing.Point(1081, 262);
            this.btnCommitDetails.Name = "btnCommitDetails";
            this.btnCommitDetails.Size = new System.Drawing.Size(180, 23);
            this.btnCommitDetails.TabIndex = 35;
            this.btnCommitDetails.Text = "Commit Details";
            this.btnCommitDetails.UseVisualStyleBackColor = true;
            this.btnCommitDetails.Click += new System.EventHandler(this.btnCommitDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "OrderID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(88, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(26, 20);
            this.lblOrderID.TabIndex = 36;
            this.lblOrderID.Text = "[0]";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtShippedDate);
            this.grpOrder.Controls.Add(this.label9);
            this.grpOrder.Controls.Add(this.txtOrderDate);
            this.grpOrder.Controls.Add(this.OrderDate);
            this.grpOrder.Controls.Add(this.txtRequiredDate);
            this.grpOrder.Controls.Add(this.txtFreight);
            this.grpOrder.Controls.Add(this.label7);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.cmbShipVia);
            this.grpOrder.Controls.Add(this.label13);
            this.grpOrder.Location = new System.Drawing.Point(1045, 56);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(242, 164);
            this.grpOrder.TabIndex = 38;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Information";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtFax);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.txtCountry);
            this.grpCustomer.Controls.Add(this.txtPostalCode);
            this.grpCustomer.Controls.Add(this.txtRegion);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtContactName);
            this.grpCustomer.Controls.Add(this.txtContactTitle);
            this.grpCustomer.Controls.Add(this.label23);
            this.grpCustomer.Controls.Add(this.label22);
            this.grpCustomer.Controls.Add(this.label21);
            this.grpCustomer.Controls.Add(this.label20);
            this.grpCustomer.Controls.Add(this.label19);
            this.grpCustomer.Controls.Add(this.label18);
            this.grpCustomer.Controls.Add(this.label17);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.lblCompanyName);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.lblCustomerID);
            this.grpCustomer.Location = new System.Drawing.Point(797, 56);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(242, 313);
            this.grpCustomer.TabIndex = 39;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "CustomerID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(102, 21);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(72, 13);
            this.lblCustomerID.TabIndex = 40;
            this.lblCustomerID.Text = "lblCustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Company Name";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(102, 47);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(60, 13);
            this.lblCompanyName.TabIndex = 42;
            this.lblCompanyName.Text = "Compname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Contact Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Contact Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "City";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Region";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Postal Code";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 229);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Country";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Fax";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 255);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "Phone";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(105, 70);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(131, 20);
            this.txtContactTitle.TabIndex = 53;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(105, 96);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(131, 20);
            this.txtContactName.TabIndex = 54;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 122);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 20);
            this.txtAddress.TabIndex = 55;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(105, 148);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(131, 20);
            this.txtCity.TabIndex = 56;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 252);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(131, 20);
            this.txtPhone.TabIndex = 60;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(105, 226);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(131, 20);
            this.txtCountry.TabIndex = 59;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(105, 200);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(131, 20);
            this.txtPostalCode.TabIndex = 58;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(105, 174);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(131, 20);
            this.txtRegion.TabIndex = 57;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(105, 280);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(131, 20);
            this.txtFax.TabIndex = 61;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.ForeColor = System.Drawing.Color.Gray;
            this.txtOrderDate.Location = new System.Drawing.Point(93, 18);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(143, 20);
            this.txtOrderDate.TabIndex = 32;
            this.txtOrderDate.Text = "DD/MM/YYYY";
            this.txtOrderDate.Enter += new System.EventHandler(this.DateEnter);
            this.txtOrderDate.Leave += new System.EventHandler(this.DateLeave);
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(14, 21);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(59, 13);
            this.OrderDate.TabIndex = 33;
            this.OrderDate.Text = "Order Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Enabled = false;
            this.txtShippedDate.ForeColor = System.Drawing.Color.Gray;
            this.txtShippedDate.Location = new System.Drawing.Point(93, 70);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(143, 20);
            this.txtShippedDate.TabIndex = 34;
            this.txtShippedDate.Text = "DD/MM/YYYY";
            this.txtShippedDate.Enter += new System.EventHandler(this.DateEnter);
            this.txtShippedDate.Leave += new System.EventHandler(this.DateLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Shipped Date";
            // 
            // OrderingFormBrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 600);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnCommitDetails);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnMakeNewOrder);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "OrderingFormBrett";
            this.Text = "OrderingFromBrett";
            this.Load += new System.EventHandler(this.OrderingFormBrett_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeNewOrder;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCommitDetails;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label OrderDate;
    }
}