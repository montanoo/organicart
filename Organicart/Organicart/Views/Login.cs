using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Controllers;

namespace Organicart
{
    public partial class Login : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public Login()
        {
            InitializeComponent();

            var check = new CheckDatabase();
            check.Check();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            var newUser = new SignUp();
            newUser.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var login = new LoginUser();
            login.Login(txtUser.Text, txtPassword.Text);
            this.Hide();
        }
    }
}
