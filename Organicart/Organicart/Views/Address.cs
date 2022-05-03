using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;
using System.IO;

namespace Organicart.Views
{
    public partial class Address : Base
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
        private int adressid;
        public Address(string pUsername)
        {
            InitializeComponent();
            FillStores();
            username = pUsername;
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products(1, username);
            enterProducts.Show();
            this.Hide();
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

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox2.SelectedIndex == -1 || textBox5.Text == "")
            {
                MessageBox.Show("Debes completar los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (OrganicartEntities database = new OrganicartEntities())
            {
                user datauser = new user();
                client dataclient = new client();
                client_address dataadress = new client_address();
                user gettingid = database.users.Where(a => a.username == username).FirstOrDefault();
                client refid = database.clients.Where(a => a.user_id == gettingid.id).FirstOrDefault();
                dataadress.client_id = refid.id;
                dataadress.address = comboBox2.Text +" "+textBox5.Text + " "+textBox4.Text;
                database.client_address.Add(dataadress);
                database.SaveChanges();
                adressid = dataadress.id;
            }
            var enterCheckout = new Payment(username, adressid);
            enterCheckout.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var enterAbout = new About(username);
            enterAbout.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre y apellido")
                textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Correo")
                textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Número")
                textBox3.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FillStores()
        {
            using (var db = new OrganicartEntities())
            {
                foreach (var variable in db.stores)
                    comboBox2.Items.Add(variable.name);
            }
        }
    }
}
