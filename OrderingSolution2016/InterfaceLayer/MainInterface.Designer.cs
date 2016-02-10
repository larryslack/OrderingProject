namespace InterfaceLayer
{
    partial class MainInterface
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
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.txtCompPhone = new System.Windows.Forms.TextBox();
            this.txtCompMail = new System.Windows.Forms.TextBox();
            this.txtCompFax = new System.Windows.Forms.TextBox();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(7, 149);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.Size = new System.Drawing.Size(444, 241);
            this.OrderGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(12, 91);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(112, 23);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // txtCompPhone
            // 
            this.txtCompPhone.Location = new System.Drawing.Point(323, 39);
            this.txtCompPhone.Name = "txtCompPhone";
            this.txtCompPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCompPhone.TabIndex = 6;
            // 
            // txtCompMail
            // 
            this.txtCompMail.Location = new System.Drawing.Point(323, 117);
            this.txtCompMail.Name = "txtCompMail";
            this.txtCompMail.Size = new System.Drawing.Size(100, 20);
            this.txtCompMail.TabIndex = 7;
            // 
            // txtCompFax
            // 
            this.txtCompFax.Location = new System.Drawing.Point(323, 91);
            this.txtCompFax.Name = "txtCompFax";
            this.txtCompFax.Size = new System.Drawing.Size(100, 20);
            this.txtCompFax.TabIndex = 8;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(12, 120);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(112, 23);
            this.btnEditOrder.TabIndex = 9;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnReOrder
            // 
            this.btnReOrder.Location = new System.Drawing.Point(130, 120);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(75, 23);
            this.btnReOrder.TabIndex = 10;
            this.btnReOrder.Text = "Re Order";
            this.btnReOrder.UseVisualStyleBackColor = true;
            this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Company Phone #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fax";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(323, 12);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 15;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contact Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCompID
            // 
            this.txtCompID.Location = new System.Drawing.Point(323, 65);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(100, 20);
            this.txtCompID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interface";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.txtCompFax);
            this.Controls.Add(this.txtCompMail);
            this.Controls.Add(this.txtCompPhone);
            this.Controls.Add(this.txtCompID);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderGrid);
            this.Name = "MainInterface";
            this.Text = "Forrn1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.TextBox txtCompPhone;
        private System.Windows.Forms.TextBox txtCompMail;
        private System.Windows.Forms.TextBox txtCompFax;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnReOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.Label label6;
    }
}

