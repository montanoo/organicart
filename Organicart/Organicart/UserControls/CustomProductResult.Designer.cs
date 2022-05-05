namespace Organicart.UserControls
{
    partial class CustomProductResult
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
            this.Productimg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Productimg
            // 
            this.Productimg.Location = new System.Drawing.Point(4, 10);
            this.Productimg.Name = "Productimg";
            this.Productimg.Size = new System.Drawing.Size(93, 89);
            this.Productimg.TabIndex = 0;
            this.Productimg.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel3.Location = new System.Drawing.Point(-54, -5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 17);
            this.panel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel1.Location = new System.Drawing.Point(-54, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 17);
            this.panel1.TabIndex = 17;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(110, 14);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(107, 20);
            this.Namelbl.TabIndex = 18;
            this.Namelbl.Text = "Manzana Gala";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(110, 38);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(45, 20);
            this.Pricelbl.TabIndex = 19;
            this.Pricelbl.Text = "$560";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.Location = new System.Drawing.Point(110, 65);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(97, 20);
            this.Quantitylbl.TabIndex = 20;
            this.Quantitylbl.Text = "Cantidad: 50";
            // 
            // CustomProductResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Productimg);
            this.Name = "CustomProductResult";
            this.Size = new System.Drawing.Size(353, 107);
            ((System.ComponentModel.ISupportInitialize)(this.Productimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Productimg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label Quantitylbl;
    }
}
