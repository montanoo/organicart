namespace Organicart.Views
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btnBebidas = new System.Windows.Forms.PictureBox();
            this.btnFrutas = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBebidas.Image = ((System.Drawing.Image)(resources.GetObject("btnBebidas.Image")));
            this.btnBebidas.Location = new System.Drawing.Point(734, 265);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(200, 200);
            this.btnBebidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBebidas.TabIndex = 5;
            this.btnBebidas.TabStop = false;
            // 
            // btnFrutas
            // 
            this.btnFrutas.BackColor = System.Drawing.Color.Transparent;
            this.btnFrutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrutas.Image = ((System.Drawing.Image)(resources.GetObject("btnFrutas.Image")));
            this.btnFrutas.Location = new System.Drawing.Point(373, 265);
            this.btnFrutas.Name = "btnFrutas";
            this.btnFrutas.Size = new System.Drawing.Size(200, 200);
            this.btnFrutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFrutas.TabIndex = 4;
            this.btnFrutas.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(368, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "EDITAR PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(729, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "AÑADIR PRODUCTOS";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBebidas);
            this.Controls.Add(this.btnFrutas);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnFrutas, 0);
            this.Controls.SetChildIndex(this.btnBebidas, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBebidas;
        private System.Windows.Forms.PictureBox btnFrutas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}