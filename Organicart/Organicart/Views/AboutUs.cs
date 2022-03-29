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
    public partial class AboutUs : Base
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void homePagebtn_Click(object sender, EventArgs e)
        {
            HomePage enterHomePage = new HomePage();
            enterHomePage.Show();
            this.Hide();
        }

        private void cartBtn2_Click(object sender, EventArgs e)
        {
            Cart enterCart = new Cart();
            enterCart.Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile enterProfile = new Profile();
            enterProfile.Show();
            this.Hide();
        }
    }
}
