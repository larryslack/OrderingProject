namespace InterfaceLayer
{
    partial class OrderingFormShohei
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
            this.btnNewP = new System.Windows.Forms.Button();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblEmpl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewP
            // 
            this.btnNewP.Location = new System.Drawing.Point(154, 6);
            this.btnNewP.Name = "btnNewP";
            this.btnNewP.Size = new System.Drawing.Size(106, 23);
            this.btnNewP.TabIndex = 0;
            this.btnNewP.Text = "new Product";
            this.btnNewP.UseVisualStyleBackColor = true;
            this.btnNewP.Click += new System.EventHandler(this.btnNewP_Click);
            // 
            // pnlProducts
            // 
            this.pnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducts.Location = new System.Drawing.Point(154, 35);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(307, 257);
            this.pnlProducts.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Order!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(88, 16);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(35, 13);
            this.lblCust.TabIndex = 3;
            this.lblCust.Text = "label3";
            // 
            // lblEmpl
            // 
            this.lblEmpl.AutoSize = true;
            this.lblEmpl.Location = new System.Drawing.Point(88, 55);
            this.lblEmpl.Name = "lblEmpl";
            this.lblEmpl.Size = new System.Drawing.Size(35, 13);
            this.lblEmpl.TabIndex = 4;
            this.lblEmpl.Text = "label4";
            // 
            // OrderingFormShohei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 367);
            this.Controls.Add(this.lblEmpl);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.btnNewP);
            this.Name = "OrderingFormShohei";
            this.Text = "OrderingFormShohei";
            this.Load += new System.EventHandler(this.OrderingFormShohei_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewP;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblEmpl;
    }
}