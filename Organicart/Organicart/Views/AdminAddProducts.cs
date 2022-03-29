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
            if (txtName.Text == "" || txtPrice.Text == "" || chosenImage.Image == null || cmbCategories.Text == "")
                return;
            using (var db = new OrganicartEntities())
            {
                var product = new product
                {
                    name = txtName.Text,
                    photo = ImageToInsert(chosenImage.Image),
                    category_id = cmbCategories.SelectedIndex,
                    price = float.Parse(txtPrice.Text)
                };
                db.products.Add(product); // guardar los items con Entity Framework
                db.SaveChanges();
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
    }
}
