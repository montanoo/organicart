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
            this.Quantitynum = new System.Windows.Forms.NumericUpDown();
            this.Trashbtn = new System.Windows.Forms.PictureBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.Productlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 129);
            this.panel1.TabIndex = 0;
            // 
            // Productimg
            // 
            this.Productimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Productimg.Location = new System.Drawing.Point(0, 0);
            this.Productimg.Margin = new System.Windows.Forms.Padding(4);
            this.Productimg.Name = "Productimg";
            this.Productimg.Size = new System.Drawing.Size(145, 129);
            this.Productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Productimg.TabIndex = 0;
            this.Productimg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 12);
            this.panel2.TabIndex = 1;
            // 
            // Quantitynum
            // 
            this.Quantitynum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitynum.Location = new System.Drawing.Point(510, 63);
            this.Quantitynum.Margin = new System.Windows.Forms.Padding(4);
            this.Quantitynum.Name = "Quantitynum";
            this.Quantitynum.Size = new System.Drawing.Size(139, 30);
            this.Quantitynum.TabIndex = 5;
            this.Quantitynum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Trashbtn
            // 
            this.Trashbtn.Enabled = false;
            this.Trashbtn.Location = new System.Drawing.Point(688, 28);
            this.Trashbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Trashbtn.Name = "Trashbtn";
            this.Trashbtn.Size = new System.Drawing.Size(87, 75);
            this.Trashbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Trashbtn.TabIndex = 3;
            this.Trashbtn.TabStop = false;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pricelbl.Location = new System.Drawing.Point(294, 63);
            this.Pricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(77, 32);
            this.Pricelbl.TabIndex = 4;
            this.Pricelbl.Text = "$0.00";
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productlbl.Location = new System.Drawing.Point(193, 15);
            this.Productlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(349, 32);
            this.Productlbl.TabIndex = 2;
            this.Productlbl.Text = "Pan de Barra Bimbo - 530 grs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel3.Location = new System.Drawing.Point(-3, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 10);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel4.Location = new System.Drawing.Point(-7, -5);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 10);
            this.panel4.TabIndex = 13;
            // 
            // CustomCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantitynum);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.Trashbtn);
            this.Controls.Add(this.Productlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomCartItem";
            this.Size = new System.Drawing.Size(804, 119);
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
        private System.Windows.Forms.PictureBox Trashbtn;
        private System.Windows.Forms.NumericUpDown Quantitynum;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
