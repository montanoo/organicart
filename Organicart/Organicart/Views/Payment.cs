using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Views;

namespace Organicart
{
    public partial class Payment : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        private string username;
        public Payment(string pUsername)
        {
            InitializeComponent();
            label6.Text = $"Total a pagar $: {Cart.SessionPrice}";
            dateTimePicker1.CustomFormat = "MM-yyyy";
            dateTimePicker1.MinDate = DateTime.Now;

            username = pUsername;
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            Cart enterCart = new Cart(username);
            enterCart.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var enterProfile = new Profile(username);
            enterProfile.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage(username);
            enterHome.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var enterAbout = new About(username);
            enterAbout.Show();
            this.Hide();
        }

        private void radioButtonefectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox2.Enabled = true;
        }

        private void radioButtontarjeta_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Si selecciona pago con tarjeta            
            if (radioButtontarjeta.Checked == true)
            {
                //Validación que el textbox del número de tarjeta no esté vacío
                if (string.IsNullOrEmpty(txtarjeta.Text))
                {
                    MessageBox.Show("Debe ingresar el número de tarjeta de crédito o débito.", "Tarjeta vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validación que el textbox del número de tarjeta no tenga menos de 16 números
                if (txtarjeta.TextLength < 16)
                {
                    MessageBox.Show("Debe ingresar todos los dígitos de su tarjeta.", "Número de tarjeta inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validación que el textbox de CVV no esté vacío
                if (string.IsNullOrEmpty(txtcvv.Text))
                {
                    MessageBox.Show("Debe ingresar el CVV de la tarjeta.", "CVV vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validación que el textbox del CVV de la tarjeta no tenga menos de 3 números
                if (txtcvv.TextLength < 3)
                {
                    MessageBox.Show("Debe ingresar los 3 dígitos del CVV de su tarjeta.", "CVV inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //Mensaje si paga con tarjeta
                MessageBox.Show("Tu pago con tarjeta ha sido recibido.\nFecha: " + DateTime.Now.ToLongDateString() + "\nHora: " + DateTime.Now.ToShortTimeString(), "¡PAGO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Si selecciona pago en efectivo           
            if (radioButtonefectivo.Checked == true)
            {
                //Validación que el textbox del monto con el que pagará en efectivo no esté vacío
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Debe ingresar el monto con que pagará en efectivo.", "Monto de efectivo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Mensaje si paga en efectivo
                MessageBox.Show("\nTu orden ha sido procesada: \nFecha: " + DateTime.Now.ToLongDateString() + "\nHora: " + DateTime.Now.ToShortTimeString(), "¡GRACIAS POR SU PAGO EN EFECTIVO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
            }
        }

        private void txtcvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
                e.Handled = true;
        }

        private void txtarjeta_TextChanged(object sender, EventArgs e)
        {
            if (txtarjeta.Text == "0000000000000000")
                txtarjeta.Text = "";
        }

        private void txtcvv_TextChanged(object sender, EventArgs e)
        {
            if (txtcvv.Text == "XXX")
                txtarjeta.Text = "";
        }
    }
}
