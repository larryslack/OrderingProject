namespace InterfaceLayer
{
    partial class OrderingFormPicker
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
            this.btnMatt = new System.Windows.Forms.Button();
            this.btnBrett = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatt
            // 
            this.btnMatt.Location = new System.Drawing.Point(12, 12);
            this.btnMatt.Name = "btnMatt";
            this.btnMatt.Size = new System.Drawing.Size(75, 23);
            this.btnMatt.TabIndex = 0;
            this.btnMatt.Text = "Matt";
            this.btnMatt.UseVisualStyleBackColor = true;
            this.btnMatt.Click += new System.EventHandler(this.btnMatt_Click);
            // 
            // btnBrett
            // 
            this.btnBrett.Location = new System.Drawing.Point(12, 41);
            this.btnBrett.Name = "btnBrett";
            this.btnBrett.Size = new System.Drawing.Size(75, 23);
            this.btnBrett.TabIndex = 1;
            this.btnBrett.Text = "Brett";
            this.btnBrett.UseVisualStyleBackColor = true;
            this.btnBrett.Click += new System.EventHandler(this.btnBrett_Click);
            // 
            // OrderingFormPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBrett);
            this.Controls.Add(this.btnMatt);
            this.Name = "OrderingFormPicker";
            this.Text = "OrderingFormPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatt;
        private System.Windows.Forms.Button btnBrett;
    }
}