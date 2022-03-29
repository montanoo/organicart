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
using System.Text.RegularExpressions;


namespace Organicart.Views
{
    public partial class Profile : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        bool imagechange = false; //servirá para saber si se ha cambiado la foto
        string auxusername; //recibe el parámetro
        public Profile(string username)
        {
            InitializeComponent();

            auxusername = username;
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            var enterCart = new Cart(auxusername);
            enterCart.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage(auxusername);
            enterHome.Show();
            this.Hide();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            //devuelve el byte a una imagen
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
            //verifica el usuario que está en la sesión en ese momento y muestra sus datos
            using (OrganicartEntities database = new OrganicartEntities())
            {
                user datauser_ = database.users.Where(d => d.username == auxusername).FirstOrDefault();
                user datauser = database.users.Where(d => d.id == datauser_.id).FirstOrDefault();
                usertxt.Text = datauser.username;
                passwordtxt.Text = datauser.password;
            }

            using (OrganicartEntities database = new OrganicartEntities())
            {
                user datauser_ = database.users.Where(d => d.username == auxusername).FirstOrDefault();
                client dataclient = database.clients.Where(d => d.user_id == datauser_.id).FirstOrDefault();
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
            if (usertxt.Text == "" || nametxt.Text == "" || lastnametxt.Text == "" ||
               passwordtxt.Text == "" || phonetxt.Text == "" || duitxt.Text == "" || emailtxt.Text == "")
            {
                MessageBox.Show("Faltan campos por completar");
            }
            else if (WeakPassword(passwordtxt))
            {
                MessageBox.Show("La contraseña debe tener más de 8 carácteres");
            }
            else
            {

                try
                {
                    //hace la modificación en la base de datos
                    using (OrganicartEntities database = new OrganicartEntities())
                    {
                        user datauser_ = database.users.Where(d => d.username == auxusername).FirstOrDefault();
                        user datauser = database.users.Where(d => d.id == datauser_.id).FirstOrDefault();
                        datauser.username = nametxt.Text;
                        datauser.password = passwordtxt.Text;
                        database.Entry(datauser).State = EntityState.Modified;
                        database.SaveChanges();
                    }

                    using (OrganicartEntities database = new OrganicartEntities())
                    {
                        user datauser_ = database.users.Where(d => d.username == auxusername).FirstOrDefault();
                        client dataclient = database.clients.Where(d => d.user_id == datauser_.id).FirstOrDefault();
                        dataclient.name = nametxt.Text;
                        dataclient.lastname = lastnametxt.Text;
                        dataclient.phone = Convert.ToInt32(phonetxt.Text);
                        dataclient.dui = duitxt.Text;
                        dataclient.email = emailtxt.Text;

                        if (fotocliente.Image == null)
                        {
                            dataclient.photo = null;
                        }
                        else if (imagechange) //comprueba que la imagen cambió
                        {
                            dataclient.photo = ImageToInsert(fotocliente.Image);
                        }
                        database.Entry(dataclient).State = EntityState.Modified;
                        database.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult fotore = foto.ShowDialog();
            if (fotore == DialogResult.OK)
            {
                fotocliente.Image = Image.FromFile(foto.FileName);
                imagechange = true;
            }
        }

        private void descartarbtn_Click(object sender, EventArgs e)
        {
            fotocliente.Image = null;
        }
        public static bool validemail(string pemail)
        {

            string expression = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

            if (Regex.IsMatch(pemail, expression))
            {
                if (Regex.Replace(pemail, expression, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void emailtxt_Leave(object sender, EventArgs e)
        {
            if (validemail(emailtxt.Text))
            {

            }
            else
            {
                MessageBox.Show("Correo inválido");
                emailtxt.SelectAll();
                emailtxt.Focus();
            }
        }
        public Boolean WeakPassword(TextBox txtPassword)
        {
            int countnumbers = 0;
            for (int i = 0; i < txtPassword.TextLength; i++)
            {
                countnumbers += 1;
            }
            if (countnumbers < 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}