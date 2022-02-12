namespace Organicart
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmesvencimiento = new System.Windows.Forms.ComboBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.txtarjeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtontarjeta = new System.Windows.Forms.RadioButton();
            this.radioButtonefectivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.PictureBox();
            this.Cartbtn = new System.Windows.Forms.PictureBox();
            this.Productsbtn = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(295, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 34);
            this.textBox2.TabIndex = 46;
            this.textBox2.Text = "$0.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(291, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 28);
            this.label10.TabIndex = 45;
            this.label10.Text = "¿Con cuánto vas a pagar?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "IVA incluido";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(92)))), ((int)(((byte)(53)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(554, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 89);
            this.button2.TabIndex = 43;
            this.button2.Text = "Procesar pago";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(92)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(507, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "Total: $9.00";
            // 
            // cmbmesvencimiento
            // 
            this.cmbmesvencimiento.FormattingEnabled = true;
            this.cmbmesvencimiento.Items.AddRange(new object[] {
            "1 - Enero",
            "2 - Febrero",
            "3 - Marzo",
            "4 - Abril",
            "5 - Mayo",
            "6 - Junio",
            "7 - Julio",
            "8 - Agosto",
            "9 - Septiembre",
            "10 - Octubre",
            "11 - Noviembre",
            "12 - Diciembre"});
            this.cmbmesvencimiento.Location = new System.Drawing.Point(836, 464);
            this.cmbmesvencimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbmesvencimiento.Name = "cmbmesvencimiento";
            this.cmbmesvencimiento.Size = new System.Drawing.Size(111, 36);
            this.cmbmesvencimiento.TabIndex = 38;
            this.cmbmesvencimiento.Text = "01/2003";
            // 
            // txtaño
            // 
            this.txtaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.txtaño.Location = new System.Drawing.Point(782, 350);
            this.txtaño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaño.Multiline = true;
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(213, 100);
            this.txtaño.TabIndex = 37;
            this.txtaño.Text = "*El CVV son los últimos 3 números de la parte de atrás.";
            this.txtaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(848, 312);
            this.txtcvv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(147, 34);
            this.txtcvv.TabIndex = 36;
            this.txtcvv.Text = "XXX";
            // 
            // txtarjeta
            // 
            this.txtarjeta.Location = new System.Drawing.Point(844, 265);
            this.txtarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtarjeta.Name = "txtarjeta";
            this.txtarjeta.Size = new System.Drawing.Size(203, 34);
            this.txtarjeta.TabIndex = 35;
            this.txtarjeta.Text = "0000 0000 0000 0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(699, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(777, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(699, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nº de tarjeta:";
            // 
            // radioButtontarjeta
            // 
            this.radioButtontarjeta.AutoSize = true;
            this.radioButtontarjeta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtontarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.radioButtontarjeta.Location = new System.Drawing.Point(704, 200);
            this.radioButtontarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtontarjeta.Name = "radioButtontarjeta";
            this.radioButtontarjeta.Size = new System.Drawing.Size(269, 35);
            this.radioButtontarjeta.TabIndex = 30;
            this.radioButtontarjeta.TabStop = true;
            this.radioButtontarjeta.Text = "Tarjeta crédito/débito";
            this.radioButtontarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButtonefectivo
            // 
            this.radioButtonefectivo.AutoSize = true;
            this.radioButtonefectivo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonefectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.radioButtonefectivo.Location = new System.Drawing.Point(296, 200);
            this.radioButtonefectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonefectivo.Name = "radioButtonefectivo";
            this.radioButtonefectivo.Size = new System.Drawing.Size(121, 35);
            this.radioButtonefectivo.TabIndex = 29;
            this.radioButtonefectivo.TabStop = true;
            this.radioButtonefectivo.Text = "Efectivo";
            this.radioButtonefectivo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.profilebtn);
            this.panel2.Controls.Add(this.Cartbtn);
            this.panel2.Controls.Add(this.Productsbtn);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 719);
            this.panel2.TabIndex = 47;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(509, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 50);
            this.label7.TabIndex = 54;
            this.label7.Text = "Realizar pago";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmesvencimiento);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.txtarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtontarjeta);
            this.Controls.Add(this.radioButtonefectivo);
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Controls.SetChildIndex(this.radioButtonefectivo, 0);
            this.Controls.SetChildIndex(this.radioButtontarjeta, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtarjeta, 0);
            this.Controls.SetChildIndex(this.txtcvv, 0);
            this.Controls.SetChildIndex(this.txtaño, 0);
            this.Controls.SetChildIndex(this.cmbmesvencimiento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmesvencimiento;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.TextBox txtarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtontarjeta;
        private System.Windows.Forms.RadioButton radioButtonefectivo;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox Cartbtn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox profilebtn;
        public System.Windows.Forms.PictureBox Productsbtn;
    }
}