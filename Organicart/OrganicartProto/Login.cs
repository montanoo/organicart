using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganicartProto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Form2 inicio = new Form2();
            inicio.Show();
            this.Hide();
        }
    }
}
