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
    public partial class Profile : Base
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            var enterCart = new Cart();
            enterCart.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage();
            enterHome.Show();
            this.Hide();
        }
    }
}
