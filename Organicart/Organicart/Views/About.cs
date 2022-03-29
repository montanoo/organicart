using System;
using System.Windows.Forms;

namespace Organicart.Views
{
    public partial class About : Base
    {
        
        //Integrantes: 
        //- Fernando Josué Montano González. MG210111 | 
        //- Andrea Guadalupe Velásquez Joyar. VJ210576 |
        //- Ivania María Lebrón Flores. LF212591 | 
        //- Luciana María Munguía Villacorta. MV210941 |
        //- Carlos Vicente Castillo Sayes. CS210003 |

        string username;
        public About(string pUsername)
        {
            InitializeComponent();
            username = pUsername;
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void homePagebtn_Click(object sender, EventArgs e)
        {
            HomePage enterHomePage = new HomePage(username);
            enterHomePage.Show();
            this.Hide();
        }

        private void cartBtn2_Click(object sender, EventArgs e)
        {
            Cart enterCart = new Cart(username);
            enterCart.Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile enterProfile = new Profile(username);
            enterProfile.Show();
            this.Hide();
        }
    }
}
