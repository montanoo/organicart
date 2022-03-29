
namespace Organicart
{
    partial class CustomProductItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Productimg = new System.Windows.Forms.PictureBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Productlbl = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(204)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.Productimg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 98);
            this.panel1.TabIndex = 3;
            // 
            // Productimg
            // 
            this.Productimg.Location = new System.Drawing.Point(24, 11);
            this.Productimg.Name = "Productimg";
            this.Productimg.Size = new System.Drawing.Size(74, 72);
            this.Productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Productimg.TabIndex = 4;
            this.Productimg.TabStop = false;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pricelbl.Location = new System.Drawing.Point(251, 43);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(61, 25);
            this.Pricelbl.TabIndex = 7;
            this.Pricelbl.Text = "$0.00";
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.Location = new System.Drawing.Point(176, 11);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(273, 25);
            this.Productlbl.TabIndex = 5;
            this.Productlbl.Text = "Pan de Barra Bimbo - 530 grs";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.Image = global::Organicart.Properties.Resources.shopping_cart;
            this.btnAddToCart.Location = new System.Drawing.Point(512, 11);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(70, 72);
            this.btnAddToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 9);
            this.panel2.TabIndex = 9;
            // 
            // CustomProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.Productlbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomProductItem";
            this.Size = new System.Drawing.Size(603, 113);
            this.Click += new System.EventHandler(this.CustomProductItem_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Productimg;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.PictureBox btnAddToCart;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
