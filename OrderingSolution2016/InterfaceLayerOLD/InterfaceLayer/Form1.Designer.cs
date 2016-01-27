namespace InterfaceLayer
{
    partial class Form1
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
<<<<<<< HEAD
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(285, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(285, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddComp = new System.Windows.Forms.Button();
            this.btnCompNameChange = new System.Windows.Forms.Button();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.txtCompPhone = new System.Windows.Forms.TextBox();
            this.txtCompAdd = new System.Windows.Forms.TextBox();
            this.txtCompFor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(91, 15);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(100, 20);
            this.txtCompName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Name";
            // 
            // btnAddComp
            // 
            this.btnAddComp.Location = new System.Drawing.Point(15, 139);
            this.btnAddComp.Name = "btnAddComp";
            this.btnAddComp.Size = new System.Drawing.Size(112, 31);
            this.btnAddComp.TabIndex = 3;
            this.btnAddComp.Text = "Add new Company";
            this.btnAddComp.UseVisualStyleBackColor = true;
            // 
            // btnCompNameChange
            // 
            this.btnCompNameChange.Location = new System.Drawing.Point(91, 41);
            this.btnCompNameChange.Name = "btnCompNameChange";
            this.btnCompNameChange.Size = new System.Drawing.Size(100, 23);
            this.btnCompNameChange.TabIndex = 4;
            this.btnCompNameChange.Text = "chnage name";
            this.btnCompNameChange.UseVisualStyleBackColor = true;
            // 
            // txtCompID
            // 
            this.txtCompID.Location = new System.Drawing.Point(91, 70);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(100, 20);
            this.txtCompID.TabIndex = 5;
            // 
            // txtCompPhone
            // 
            this.txtCompPhone.Location = new System.Drawing.Point(344, 11);
            this.txtCompPhone.Name = "txtCompPhone";
            this.txtCompPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCompPhone.TabIndex = 6;
            // 
            // txtCompAdd
            // 
            this.txtCompAdd.Location = new System.Drawing.Point(344, 78);
            this.txtCompAdd.Name = "txtCompAdd";
            this.txtCompAdd.Size = new System.Drawing.Size(100, 20);
            this.txtCompAdd.TabIndex = 7;
            // 
            // txtCompFor
            // 
            this.txtCompFor.Location = new System.Drawing.Point(344, 121);
            this.txtCompFor.Name = "txtCompFor";
            this.txtCompFor.Size = new System.Drawing.Size(100, 20);
            this.txtCompFor.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "read supplier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "for";
>>>>>>> 585e753452f24d316dbf68c74227452585bdfc13
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(426, 328);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
=======
            this.ClientSize = new System.Drawing.Size(456, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCompFor);
            this.Controls.Add(this.txtCompAdd);
            this.Controls.Add(this.txtCompPhone);
            this.Controls.Add(this.txtCompID);
            this.Controls.Add(this.btnCompNameChange);
            this.Controls.Add(this.btnAddComp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Forrn1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
>>>>>>> 585e753452f24d316dbf68c74227452585bdfc13
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddComp;
        private System.Windows.Forms.Button btnCompNameChange;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.TextBox txtCompPhone;
        private System.Windows.Forms.TextBox txtCompAdd;
        private System.Windows.Forms.TextBox txtCompFor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
>>>>>>> 585e753452f24d316dbf68c74227452585bdfc13
    }
}

