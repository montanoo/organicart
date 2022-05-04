namespace Organicart.UserControls
{
    partial class CustomOrder
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Clientlbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 17);
            this.panel3.TabIndex = 15;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(183, 50);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(116, 20);
            this.Datelbl.TabIndex = 19;
            this.Datelbl.Text = "Fecha: 3/05/22";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(21, 50);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(42, 20);
            this.IDlbl.TabIndex = 18;
            this.IDlbl.Text = "ID: 2";
            // 
            // Clientlbl
            // 
            this.Clientlbl.AutoSize = true;
            this.Clientlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientlbl.Location = new System.Drawing.Point(21, 25);
            this.Clientlbl.Name = "Clientlbl";
            this.Clientlbl.Size = new System.Drawing.Size(189, 20);
            this.Clientlbl.TabIndex = 16;
            this.Clientlbl.Text = "Cliente: Andrea Velásquez";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.Location = new System.Drawing.Point(21, 71);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(97, 20);
            this.Quantitylbl.TabIndex = 20;
            this.Quantitylbl.Text = "Productos: 4";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.Location = new System.Drawing.Point(21, 91);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(350, 20);
            this.Addresslbl.TabIndex = 21;
            this.Addresslbl.Text = "Dirección: Barrio San Jacinto, Colonia Santa Clara";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 17);
            this.panel1.TabIndex = 16;
            // 
            // CustomOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Clientlbl);
            this.Controls.Add(this.panel3);
            this.Name = "CustomOrder";
            this.Size = new System.Drawing.Size(484, 149);
            this.Click += new System.EventHandler(this.CustomOrder_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Clientlbl;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Panel panel1;
    }
}
