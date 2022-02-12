namespace Organicart.Views
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.PictureBox();
            this.Cartbtn = new System.Windows.Forms.PictureBox();
            this.Productsbtn = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.SetChildIndex(this.comboBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1049, 566);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.profilebtn);
            this.panel2.Controls.Add(this.Cartbtn);
            this.panel2.Controls.Add(this.Productsbtn);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 720);
            this.panel2.TabIndex = 48;
            // 
            // profilebtn
            // 
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebtn.Image = ((System.Drawing.Image)(resources.GetObject("profilebtn.Image")));
            this.profilebtn.Location = new System.Drawing.Point(14, 291);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(53, 54);
            this.profilebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilebtn.TabIndex = 2;
            this.profilebtn.TabStop = false;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // Cartbtn
            // 
            this.Cartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cartbtn.Image = ((System.Drawing.Image)(resources.GetObject("Cartbtn.Image")));
            this.Cartbtn.Location = new System.Drawing.Point(12, 213);
            this.Cartbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cartbtn.Name = "Cartbtn";
            this.Cartbtn.Size = new System.Drawing.Size(53, 50);
            this.Cartbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cartbtn.TabIndex = 1;
            this.Cartbtn.TabStop = false;
            this.Cartbtn.Click += new System.EventHandler(this.Cartbtn_Click);
            // 
            // Productsbtn
            // 
            this.Productsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Productsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Productsbtn.Image")));
            this.Productsbtn.Location = new System.Drawing.Point(14, 137);
            this.Productsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(53, 52);
            this.Productsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Productsbtn.TabIndex = 0;
            this.Productsbtn.TabStop = false;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 36);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Sucursales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 50);
            this.label7.TabIndex = 55;
            this.label7.Text = "Productos";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox profilebtn;
        public System.Windows.Forms.PictureBox Cartbtn;
        public System.Windows.Forms.PictureBox Productsbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}