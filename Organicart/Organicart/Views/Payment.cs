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
        public Payment()
        {
            InitializeComponent();
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            Cart enterCart = new Cart();
            enterCart.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var enterProfile = new Profile();
            enterProfile.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage();
            enterHome.Show();
            this.Hide();
        }

        private void txttarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten números.", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //No puede ingresar más de 3 números
        private void txtcvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten números.", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Si selecciona pago con tarjeta            
            if (radioButtontarjeta.Checked == true)
            {
                //Validación que el textbox del número de tarjeta no esté vacío
                if (string.IsNullOrEmpty(txttarjeta.Text))
                {
                    MessageBox.Show("Debe ingresar el número de tarjeta de crédito o débito.", "Tarjeta vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validación que el textbox del número de tarjeta no tenga menos de 16 números
                if (txttarjeta.TextLength < 16)
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
                if (string.IsNullOrEmpty(txtefectivo.Text))
                {
                    MessageBox.Show("Debe ingresar el monto con que pagará en efectivo.", "Monto de efectivo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Mensaje si paga en efectivo
                MessageBox.Show("\nTu orden ha sido procesada: \nFecha: " + DateTime.Now.ToLongDateString() + "\nHora: " + DateTime.Now.ToShortTimeString(), "¡GRACIAS POR SU PAGO EN EFECTIVO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Redirección a HomePage luego de procesado el pago
            var enterHome = new HomePage();
            enterHome.Show();
            this.Hide();
        }

        

        
    }
}
