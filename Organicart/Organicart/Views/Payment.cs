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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AboutUs enterAboutUs = new AboutUs();
            enterAboutUs.Show();
            this.Hide();
        }
    }
}
