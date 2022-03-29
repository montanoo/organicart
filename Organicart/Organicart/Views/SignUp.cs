using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;
using System.IO;

namespace Organicart
{
    public partial class SignUp : Base
    {
        int id;
        public SignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult fotore = foto.ShowDialog();
            if (fotore == DialogResult.OK)
            {
                fotocliente.Image = Image.FromFile(foto.FileName);
            }
        }
        public byte[] ImageToInsert(Image image)
        {
            using (var memory = new MemoryStream())
            {
                image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);

                return memory.ToArray();
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using (OrganicartEntities database=new OrganicartEntities())
            {
                user datauser = new user();
                datauser.username = usertxt.Text;
                datauser.password = passwordtxt.Text;
                database.users.Add(datauser);
                database.SaveChanges();
                id = datauser.id;
            }

            using (OrganicartEntities database = new OrganicartEntities())
            {
                client dataclient = new client();
                dataclient.name = nametxt.Text;
                dataclient.lastname = lastnametxt.Text;
                dataclient.phone = Convert.ToInt32(phonetxt.Text);
                dataclient.dui = duitxt.Text;
                dataclient.email = emailtxt.Text;
                dataclient.photo = ImageToInsert(fotocliente.Image);
                var result = database.users.Where(b => b.username == usertxt.Text);
                dataclient.user_id = id;
                database.clients.Add(dataclient);
                database.SaveChanges();
            }


        }

    }
}
