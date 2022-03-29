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
        public Address()
        {
            InitializeComponent();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterProducts = new Products();
            enterProducts.Show();
            this.Hide();
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

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            var enterPayment = new Payment();
            enterPayment.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AboutUs enterAboutUs = new AboutUs();
            enterAboutUs.Show();
            this.Hide();
        }
    }
}
