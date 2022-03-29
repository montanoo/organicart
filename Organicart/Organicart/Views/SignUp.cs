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
using System.Text.RegularExpressions;

namespace Organicart
{
    public partial class SignUp : Base
    {
        int id; //guarda el id del nuevo registro
        public SignUp()
        {
            InitializeComponent();
            usertxt.Focus();
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
            //permite seleccionar una imagen de los archivos
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult fotore = foto.ShowDialog();
            if (fotore == DialogResult.OK)
            {
                fotocliente.Image = Image.FromFile(foto.FileName);
            }
        }
        public static bool validemail(string pemail)
        {
            //validacion del formato del correo
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
        public byte[] ImageToInsert(Image image)
        {
            //convierte la imagen a byte para guardarla en la base de datos
            using (var memory = new MemoryStream())
            {
                image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);

                return memory.ToArray();
            }
        }
        public Boolean WeakPassword(TextBox txtPassword)
        {
            //evalua la contraseña
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

        private void loginbtn_Click(object sender, EventArgs e)
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
                    using (OrganicartEntities database = new OrganicartEntities())
                    {
                        //primero se guardan los registros en la tabla user
                        user datauser = new user();
                        datauser.username = usertxt.Text;
                        datauser.password = passwordtxt.Text;
                        database.users.Add(datauser);
                        database.SaveChanges();
                        id = datauser.id;
                    }

                    using (OrganicartEntities database = new OrganicartEntities())
                    {
                        //se guardan los registros en la tabla clients
                        client dataclient = new client();
                        dataclient.name = nametxt.Text;
                        dataclient.lastname = lastnametxt.Text;
                        dataclient.phone = Convert.ToInt32(phonetxt.Text);
                        dataclient.dui = duitxt.Text;
                        dataclient.email = emailtxt.Text;
                        if (fotocliente.Image != null) 
                        {
                            dataclient.photo = ImageToInsert(fotocliente.Image);
                        }
                        //relaciona el id de la tabla user con la foreign key de la tabla client
                        var result = database.users.Where(b => b.username == usertxt.Text); 
                        dataclient.user_id = id;
                        database.clients.Add(dataclient);
                        database.SaveChanges();
                    }
                    Login gotologin = new Login();
                    gotologin.Show();
                    this.Close();
                }catch
                {
                    MessageBox.Show("El nombre de usuario, DUI o correo electrónico ya ha sido registrado");
                }

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
    }
}
