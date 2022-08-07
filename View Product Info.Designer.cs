namespace Business_Requirement_Management_System
{
    partial class View_Product_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Product_Info));
            this.View_Prod_Info_GV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Prod_Info_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Prod_Info_GV
            // 
            this.View_Prod_Info_GV.BackgroundColor = System.Drawing.Color.White;
            this.View_Prod_Info_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Prod_Info_GV.GridColor = System.Drawing.Color.White;
            this.View_Prod_Info_GV.Location = new System.Drawing.Point(33, 57);
            this.View_Prod_Info_GV.Name = "View_Prod_Info_GV";
            this.View_Prod_Info_GV.RowTemplate.Height = 24;
            this.View_Prod_Info_GV.Size = new System.Drawing.Size(713, 342);
            this.View_Prod_Info_GV.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(338, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 35);
            this.button4.TabIndex = 41;
            this.button4.Text = "Dashboard";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // View_Product_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.View_Prod_Info_GV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_Product_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Product_Info";
            this.Load += new System.EventHandler(this.View_Product_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Prod_Info_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView View_Prod_Info_GV;
        private System.Windows.Forms.Button button4;
    }
}