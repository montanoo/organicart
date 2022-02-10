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
    public partial class Form2 : Form
    {
        Color color = Color.FromArgb(114, 92, 53);
        Color color2 = Color.FromArgb(84, 119, 94);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Login iniciar = new Login();
            iniciar.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForms profile = new ProfileForms();
            profile.Show();
            this.Hide();
        }

        private void Productsbtn_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = color;
        }

        private void Productsbtn_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = color2;
        }

        private void Cartbtn_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = color;
        }

        private void Cartbtn_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = color2;
        }

        private void profilebtn_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = color;
        }

        private void profilebtn_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = color2;
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Hide();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }
    }
}
