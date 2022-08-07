namespace Business_Requirement_Management_System
{
    partial class Customer_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Detail));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Cust_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cust_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cust_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cust_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Contact_no = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(196, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(94, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerGV
            // 
            this.CustomerGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGV.Location = new System.Drawing.Point(351, 29);
            this.CustomerGV.Name = "CustomerGV";
            this.CustomerGV.RowTemplate.Height = 24;
            this.CustomerGV.Size = new System.Drawing.Size(701, 456);
            this.CustomerGV.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // Cust_pass
            // 
            this.Cust_pass.Location = new System.Drawing.Point(22, 387);
            this.Cust_pass.Multiline = true;
            this.Cust_pass.Name = "Cust_pass";
            this.Cust_pass.Size = new System.Drawing.Size(302, 42);
            this.Cust_pass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Name";
            // 
            // Cust_name
            // 
            this.Cust_name.Location = new System.Drawing.Point(22, 133);
            this.Cust_name.Multiline = true;
            this.Cust_name.Name = "Cust_name";
            this.Cust_name.Size = new System.Drawing.Size(302, 42);
            this.Cust_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer ID";
            // 
            // Cust_Id
            // 
            this.Cust_Id.Location = new System.Drawing.Point(22, 50);
            this.Cust_Id.Multiline = true;
            this.Cust_Id.Name = "Cust_Id";
            this.Cust_Id.Size = new System.Drawing.Size(302, 42);
            this.Cust_Id.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address";
            // 
            // Cust_Address
            // 
            this.Cust_Address.Location = new System.Drawing.Point(22, 302);
            this.Cust_Address.Multiline = true;
            this.Cust_Address.Name = "Cust_Address";
            this.Cust_Address.Size = new System.Drawing.Size(302, 42);
            this.Cust_Address.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Contact No.";
            // 
            // Contact_no
            // 
            this.Contact_no.Location = new System.Drawing.Point(22, 217);
            this.Contact_no.Multiline = true;
            this.Contact_no.Name = "Contact_no";
            this.Contact_no.Size = new System.Drawing.Size(302, 42);
            this.Contact_no.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(153, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "Dashboard";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(63, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 35);
            this.button5.TabIndex = 25;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Customer_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 525);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contact_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cust_Address);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cust_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cust_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cust_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Detail";
            this.Load += new System.EventHandler(this.Customer_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CustomerGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cust_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cust_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cust_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cust_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Contact_no;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}