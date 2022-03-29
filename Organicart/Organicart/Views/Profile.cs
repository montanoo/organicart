using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Organicart.Models;


namespace Organicart.Views
{
    public partial class Profile : Base
    {
        int iduser = 14;
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

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
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
        private void Profile_Load(object sender, EventArgs e)
        {
            using (OrganicartEntities database = new OrganicartEntities())
            {
                user datauser = database.users.Where(d => d.id == iduser).FirstOrDefault();
                usertxt.Text = datauser.username;
                passwordtxt.Text = datauser.password;
            }

            using (OrganicartEntities database = new OrganicartEntities())
            {
                client dataclient = database.clients.Where(d => d.user_id == iduser).FirstOrDefault();
                nametxt.Text = dataclient.name;
                lastnametxt.Text = dataclient.lastname;
                phonetxt.Text = Convert.ToString(dataclient.phone);
                duitxt.Text = dataclient.dui;
                emailtxt.Text = dataclient.email;
                fotocliente.Image = ByteArrayToImage(dataclient.photo);

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (OrganicartEntities database = new OrganicartEntities())
            {
                user datauser = database.users.Where(d => d.id == iduser).FirstOrDefault();
                datauser.username = nametxt.Text;
                datauser.password = passwordtxt.Text;
                database.Entry(datauser).State = EntityState.Modified;
                database.SaveChanges();
            }

            using (OrganicartEntities database = new OrganicartEntities())
            {
                client dataclient = database.clients.Where(d => d.user_id == iduser).FirstOrDefault();
                    dataclient.name = nametxt.Text;
                    dataclient.lastname = lastnametxt.Text;
                    dataclient.phone = Convert.ToInt32(phonetxt.Text);
                    dataclient.dui = duitxt.Text;
                    dataclient.email = emailtxt.Text;
                    dataclient.photo = ImageToInsert(fotocliente.Image);
                database.Entry(dataclient).State = EntityState.Modified;
                database.SaveChanges();
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult fotore = foto.ShowDialog();
            if (fotore == DialogResult.OK)
            {
                fotocliente.Image = Image.FromFile(foto.FileName);
            }
        }
    }
}
