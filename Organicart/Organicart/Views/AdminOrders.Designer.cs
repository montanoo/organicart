namespace Organicart.Views
{
    partial class AdminOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.OrdersflowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(1047, 121);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 41);
            this.label1.TabIndex = 68;
            this.label1.Text = "Despachar pedidos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // OrdersflowPanel
            // 
            this.OrdersflowPanel.AutoScroll = true;
            this.OrdersflowPanel.Location = new System.Drawing.Point(21, 214);
            this.OrdersflowPanel.Name = "OrdersflowPanel";
            this.OrdersflowPanel.Size = new System.Drawing.Size(524, 314);
            this.OrdersflowPanel.TabIndex = 50;
            // 
            // ProductsLayoutPanel2
            // 
            this.ProductsLayoutPanel2.AutoScroll = true;
            this.ProductsLayoutPanel2.Location = new System.Drawing.Point(551, 214);
            this.ProductsLayoutPanel2.Name = "ProductsLayoutPanel2";
            this.ProductsLayoutPanel2.Size = new System.Drawing.Size(467, 314);
            this.ProductsLayoutPanel2.TabIndex = 51;
            // 
            // AdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.ProductsLayoutPanel2);
            this.Controls.Add(this.OrdersflowPanel);
            this.Name = "AdminOrders";
            this.Text = "AdminOrders";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.OrdersflowPanel, 0);
            this.Controls.SetChildIndex(this.ProductsLayoutPanel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel OrdersflowPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductsLayoutPanel2;
    }
}