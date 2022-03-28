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
        }
    }
}
