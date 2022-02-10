using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrganicartProto
{
    public partial class ProfileForms : OrganicartProto.Form2
    {
        public ProfileForms()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Form2 inicio = new Form2();
            inicio.Show();
            this.Hide();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            Form2 inicio = new Form2();
            inicio.Show();
            this.Hide();
        }
    }
}
