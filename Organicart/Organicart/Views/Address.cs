using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Address(string pUsername)
        {
            InitializeComponent();
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
            var enterPayment = new Payment(username);
            enterPayment.Show();
            this.Hide();
        }
    }
}
