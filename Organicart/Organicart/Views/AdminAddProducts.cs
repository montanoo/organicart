using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Dmf;
using Organicart.Controllers;
using Organicart.Models;

namespace Organicart.Views
{
    /*
    Integrantes: 
    - Fernando Josué Montano González. MG210111 | 
    - Andrea Guadalupe Velásquez Joyar. VJ210576 |
    - Ivania María Lebrón Flores. LF212591 | 
    - Luciana María Munguía Villacorta. MV210941 |
    - Carlos Vicente Castillo Sayes. CS210003 |
    */
    public partial class AdminAddProducts : Base
    {
        
        public AdminAddProducts()
        {
            InitializeComponent();
            FillCategories();
        }

        // Acá se permitirá al usuario cargar la imagen
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    var image = openImage.FileName;
                    chosenImage.Image = Image.FromFile(image);
                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        // llenar las categorías a seleccionar en el menu de administrador.
        private void FillCategories()
        {
            using (var db = new OrganicartEntities())
            {
                var data = db.categories;
                foreach (var value in data)
                {
                    cmbCategories.Items.Add(value.type);
                }
            }
        }

        // añadir el producto a la base de datos.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || chosenImage.Image == null || cmbCategories.Text == "" || stockQuantity.Text == "0")
                return;
            using (var db = new OrganicartEntities()) // accedemos a la base de datos por medio de EF.
            {
                var product = new product // creamos un objecto de tipo product y llenamos los campos
                {
                    name = txtName.Text,
                    photo = ImageToInsert(chosenImage.Image),
                    category_id = GetSelectedCategory(),
                    stock = int.Parse(stockQuantity.Text),
                    price = float.Parse(txtPrice.Text)
                };
                try
                {
                    db.products.Add(product); // guardar los items con Entity Framework
                    db.SaveChanges();

                    MessageBox.Show("El producto ha sido añadido con éxito!");
                    Clean();
                }
                catch
                {
                    MessageBox.Show("Ya existe un producto con ese nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        /* este metodo transforma la imagen a un array de bytes que nos permite
         almacenarlo en SQL. */
        public byte[] ImageToInsert(Image image)
        {
            using (var memory = new MemoryStream())
            {
                image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);

                return memory.ToArray();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // regresar al menu de admin
            var enterAdmin = new AdminMenu();
            enterAdmin.Show();
            this.Hide();
        }
        private int GetSelectedCategory()
        {
            // string que retornaremos, incializamos en blanco.
            var category = 0;
            // usando el contexto del entity framework
            using (var db = new OrganicartEntities())
            {
                // construimos una query similar a SQL server.
                var id = (from c in db.categories
                    where c.type == cmbCategories.Text
                    select c).SingleOrDefault();
                category = id.id;
                // recorremos los resultados (1) y lo asignamos a la variable category.
            }
            // retornamos la categoría
            return category;
        }

        // limpiamos los txtbox
        private void Clean()
        {
            txtPrice.Text = "";
            txtName.Text = "";
            chosenImage.Image = null;
            cmbCategories.Text = "";
        }
    }
}
