namespace Organicart
{
    partial class CustomCartItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Productlbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Quantitynum = new System.Windows.Forms.NumericUpDown();
            this.Trashbtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantitynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trashbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(92)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.Productimg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 105);
            this.panel1.TabIndex = 0;
            // 
            // Productimg
            // 
            this.Productimg.Location = new System.Drawing.Point(15, 12);
            this.Productimg.Name = "Productimg";
            this.Productimg.Size = new System.Drawing.Size(80, 80);
            this.Productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Productimg.TabIndex = 0;
            this.Productimg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 10);
            this.panel2.TabIndex = 1;
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.Location = new System.Drawing.Point(162, 12);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(273, 25);
            this.Productlbl.TabIndex = 2;
            this.Productlbl.Text = "Pan de Barra Bimbo - 530 grs";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pricelbl.Location = new System.Drawing.Point(162, 46);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(61, 25);
            this.Pricelbl.TabIndex = 4;
            this.Pricelbl.Text = "$0.00";
            // 
            // Quantitynum
            // 
            this.Quantitynum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitynum.Location = new System.Drawing.Point(267, 49);
            this.Quantitynum.Name = "Quantitynum";
            this.Quantitynum.Size = new System.Drawing.Size(157, 26);
            this.Quantitynum.TabIndex = 5;
            // 
            // Trashbtn
            // 
            this.Trashbtn.Enabled = false;
            this.Trashbtn.Image = global::Organicart.Properties.Resources.delete;
            this.Trashbtn.Location = new System.Drawing.Point(478, 14);
            this.Trashbtn.Name = "Trashbtn";
            this.Trashbtn.Size = new System.Drawing.Size(65, 61);
            this.Trashbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Trashbtn.TabIndex = 3;
            this.Trashbtn.TabStop = false;
            // 
            // CustomCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Quantitynum);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.Trashbtn);
            this.Controls.Add(this.Productlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomCartItem";
            this.Size = new System.Drawing.Size(603, 97);
            this.Click += new System.EventHandler(this.CustomCartItem_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantitynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trashbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Productimg;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.PictureBox Trashbtn;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.NumericUpDown Quantitynum;
    }
}
