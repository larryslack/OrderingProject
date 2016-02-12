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
            this.btnRandomOrder = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ls = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRandomOrder
            // 
            this.btnRandomOrder.Location = new System.Drawing.Point(95, 109);
            this.btnRandomOrder.Name = "btnRandomOrder";
            this.btnRandomOrder.Size = new System.Drawing.Size(193, 23);
            this.btnRandomOrder.TabIndex = 0;
            this.btnRandomOrder.Text = "Make Random Order";
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
            // ls
            // 
            this.ls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ls.FormattingEnabled = true;
            this.ls.Location = new System.Drawing.Point(12, 184);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(486, 212);
            this.ls.TabIndex = 5;
            // 
            // OrderingFormBrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 408);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnRandomOrder);
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
        private System.Windows.Forms.ListBox ls;
    }
}