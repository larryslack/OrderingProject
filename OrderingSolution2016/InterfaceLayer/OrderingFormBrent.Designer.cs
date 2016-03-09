namespace InterfaceLayer
{
    partial class OrderingFormBrent
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
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityUpdown = new System.Windows.Forms.NumericUpDown();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QPUBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.InStockBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8881 = new System.Windows.Forms.Label();
            this.RequiredDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(93, 68);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(121, 21);
            this.ProductBox.TabIndex = 0;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Enabled = false;
            this.AddBtn.Location = new System.Drawing.Point(12, 66);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 238);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // QuantityUpdown
            // 
            this.QuantityUpdown.Location = new System.Drawing.Point(198, 126);
            this.QuantityUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityUpdown.Name = "QuantityUpdown";
            this.QuantityUpdown.Size = new System.Drawing.Size(47, 20);
            this.QuantityUpdown.TabIndex = 7;
            this.QuantityUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUpdown.ValueChanged += new System.EventHandler(this.QuantityUpdown_ValueChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.SystemColors.Info;
            this.PriceBox.Location = new System.Drawing.Point(60, 208);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(121, 20);
            this.PriceBox.TabIndex = 8;
            this.PriceBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Supplier";
            // 
            // QPUBox
            // 
            this.QPUBox.BackColor = System.Drawing.SystemColors.Info;
            this.QPUBox.Location = new System.Drawing.Point(101, 100);
            this.QPUBox.Name = "QPUBox";
            this.QPUBox.ReadOnly = true;
            this.QPUBox.Size = new System.Drawing.Size(110, 20);
            this.QPUBox.TabIndex = 12;
            this.QPUBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity per Unit";
            // 
            // DiscountUpDown
            // 
            this.DiscountUpDown.DecimalPlaces = 2;
            this.DiscountUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DiscountUpDown.Location = new System.Drawing.Point(67, 182);
            this.DiscountUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiscountUpDown.Name = "DiscountUpDown";
            this.DiscountUpDown.Size = new System.Drawing.Size(47, 20);
            this.DiscountUpDown.TabIndex = 14;
            this.DiscountUpDown.ValueChanged += new System.EventHandler(this.DiscountUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Discount";
            // 
            // InStockBox
            // 
            this.InStockBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InStockBox.Location = new System.Drawing.Point(54, 125);
            this.InStockBox.Name = "InStockBox";
            this.InStockBox.ReadOnly = true;
            this.InStockBox.Size = new System.Drawing.Size(86, 20);
            this.InStockBox.TabIndex = 16;
            this.InStockBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "In Stock";
            // 
            // SupplierBox
            // 
            this.SupplierBox.BackColor = System.Drawing.SystemColors.Info;
            this.SupplierBox.Location = new System.Drawing.Point(60, 234);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.ReadOnly = true;
            this.SupplierBox.Size = new System.Drawing.Size(121, 20);
            this.SupplierBox.TabIndex = 17;
            this.SupplierBox.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8881);
            this.panel1.Controls.Add(this.RequiredDatePicker);
            this.panel1.Location = new System.Drawing.Point(-1, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 265);
            this.panel1.TabIndex = 55;
            this.panel1.TabStop = true;
            // 
            // label8881
            // 
            this.label8881.AutoSize = true;
            this.label8881.Location = new System.Drawing.Point(5, 13);
            this.label8881.Name = "label8881";
            this.label8881.Size = new System.Drawing.Size(76, 13);
            this.label8881.TabIndex = 20;
            this.label8881.Text = "Required Date";
            // 
            // RequiredDatePicker
            // 
            this.RequiredDatePicker.Location = new System.Drawing.Point(79, 7);
            this.RequiredDatePicker.Name = "RequiredDatePicker";
            this.RequiredDatePicker.Size = new System.Drawing.Size(200, 20);
            this.RequiredDatePicker.TabIndex = 19;
            // 
            // OrderingFormBrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SupplierBox);
            this.Controls.Add(this.InStockBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiscountUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QPUBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityUpdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ProductBox);
            this.Name = "OrderingFormBrent";
            this.Text = "OrderingFormBrent";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QuantityUpdown;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QPUBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DiscountUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InStockBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SupplierBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8881;
        private System.Windows.Forms.DateTimePicker RequiredDatePicker;
    }
}