namespace InterfaceLayer
{
    partial class OrderingFormLinda
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtShipAdd = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiftyToHundred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HundredToFiveHundred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiveHundredOrMore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtshipCountry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.cbShipVia = new System.Windows.Forms.ComboBox();
            this.dtReqDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSelectProduct = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtChangeQuantity = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(516, 29);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "CustomerID";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(255, 29);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(43, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "lblcomp";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(102, 77);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(149, 22);
            this.txtCustName.TabIndex = 2;
            // 
            // txtShipAdd
            // 
            this.txtShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipAdd.Location = new System.Drawing.Point(102, 116);
            this.txtShipAdd.Name = "txtShipAdd";
            this.txtShipAdd.Size = new System.Drawing.Size(149, 22);
            this.txtShipAdd.TabIndex = 4;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipCity.Location = new System.Drawing.Point(374, 116);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(149, 22);
            this.txtShipCity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CustomerName:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(445, 29);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 7;
            this.lblCustID.Text = "CustomerID:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(173, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 13);
            this.label.TabIndex = 8;
            this.label.Text = "CompanyName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "EmployeeID:";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Price,
            this.FiftyToHundred,
            this.HundredToFiveHundred,
            this.FiveHundredOrMore,
            this.Total});
            this.DGV.Location = new System.Drawing.Point(3, 298);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(814, 170);
            this.DGV.TabIndex = 10;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // FiftyToHundred
            // 
            this.FiftyToHundred.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FiftyToHundred.HeaderText = "Price50To100";
            this.FiftyToHundred.Name = "FiftyToHundred";
            this.FiftyToHundred.ReadOnly = true;
            // 
            // HundredToFiveHundred
            // 
            this.HundredToFiveHundred.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HundredToFiveHundred.HeaderText = "Price100To500";
            this.HundredToFiveHundred.Name = "HundredToFiveHundred";
            this.HundredToFiveHundred.ReadOnly = true;
            // 
            // FiveHundredOrMore
            // 
            this.FiveHundredOrMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FiveHundredOrMore.HeaderText = "Price500OrMore";
            this.FiveHundredOrMore.Name = "FiveHundredOrMore";
            this.FiveHundredOrMore.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmpID);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(72, 29);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(38, 13);
            this.lblEmpID.TabIndex = 12;
            this.lblEmpID.Text = "empID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phone:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(644, 26);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.ReadOnly = true;
            this.txtPhoneNum.Size = new System.Drawing.Size(143, 20);
            this.txtPhoneNum.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ship Via:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ship Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ship City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ship Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Required Date:";
            // 
            // txtshipCountry
            // 
            this.txtshipCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshipCountry.Location = new System.Drawing.Point(643, 116);
            this.txtshipCountry.Name = "txtshipCountry";
            this.txtshipCountry.Size = new System.Drawing.Size(149, 22);
            this.txtshipCountry.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Postal Code:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.Location = new System.Drawing.Point(374, 166);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(149, 22);
            this.txtPostCode.TabIndex = 19;
            // 
            // cbShipVia
            // 
            this.cbShipVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShipVia.FormattingEnabled = true;
            this.cbShipVia.Location = new System.Drawing.Point(374, 76);
            this.cbShipVia.Name = "cbShipVia";
            this.cbShipVia.Size = new System.Drawing.Size(149, 24);
            this.cbShipVia.TabIndex = 25;
            // 
            // dtReqDate
            // 
            this.dtReqDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReqDate.Location = new System.Drawing.Point(643, 77);
            this.dtReqDate.Name = "dtReqDate";
            this.dtReqDate.Size = new System.Drawing.Size(149, 22);
            this.dtReqDate.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Select Product:";
            // 
            // cbSelectProduct
            // 
            this.cbSelectProduct.FormattingEnabled = true;
            this.cbSelectProduct.Location = new System.Drawing.Point(102, 214);
            this.cbSelectProduct.Name = "cbSelectProduct";
            this.cbSelectProduct.Size = new System.Drawing.Size(149, 21);
            this.cbSelectProduct.TabIndex = 28;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(643, 165);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(149, 24);
            this.txtOrderId.TabIndex = 29;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(558, 165);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(79, 24);
            this.btnSaveOrder.TabIndex = 30;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Region:";
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipRegion.Location = new System.Drawing.Point(102, 166);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(149, 22);
            this.txtShipRegion.TabIndex = 31;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(662, 268);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(155, 24);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "Delete Selected Order";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Change Quantity:";
            // 
            // txtChangeQuantity
            // 
            this.txtChangeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeQuantity.Location = new System.Drawing.Point(102, 252);
            this.txtChangeQuantity.Name = "txtChangeQuantity";
            this.txtChangeQuantity.Size = new System.Drawing.Size(149, 22);
            this.txtChangeQuantity.TabIndex = 34;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(288, 211);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(145, 24);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add  This Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // OrderingFormLinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 469);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtChangeQuantity);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShipRegion);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.cbSelectProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtReqDate);
            this.Controls.Add(this.cbShipVia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtshipCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtShipAdd);
            this.Controls.Add(this.txtCustName);
            this.Name = "OrderingFormLinda";
            this.Text = "OrderingFormLinda";
            this.Load += new System.EventHandler(this.OrderingFormLinda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtShipAdd;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtshipCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.ComboBox cbShipVia;
        private System.Windows.Forms.DateTimePicker dtReqDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSelectProduct;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiftyToHundred;
        private System.Windows.Forms.DataGridViewTextBoxColumn HundredToFiveHundred;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiveHundredOrMore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtChangeQuantity;
        private System.Windows.Forms.Button btnAddProduct;
    }
}