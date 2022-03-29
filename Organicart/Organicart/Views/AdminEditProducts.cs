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
    public partial class AdminEditProducts : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public AdminEditProducts()
        {
            InitializeComponent();
            
            GetNames();
            FillCategories();
        }

        public void GetNames()
        {
            // obtener los nombres al inicio de la pantalla
            var linkedProducts = new ProductsList();
            var values = linkedProducts.GetProducts();

            var head = values.Head;

            while (head != null)
            {
                cmbNames.Items.Add(head.Data.name);
                head = head.Next;
            }
        }

        /* cuando el usuario cambie de nombre, podrá ver los cambios respectivos en
           las demás opciones, es idéntico al metodo pasado pero ahora llenamos los
           espacios que faltan.*/
        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linkedProducts = new ProductsList();
            var values = linkedProducts.GetProducts();

            var head = values.Head;

            while (head != null)
            {
                if (head.Data.name == cmbNames.Text)
                {
                    chosenImage.Image = ByteToImage(head.Data.photo);
                    cmbCategories.Text = GetSelectedCategory();
                    txtPrice.Text = head.Data.price.ToString();
                    stockQuantity.Text = head.Data.stock.ToString();
                }
                head = head.Next;
            }
        }

        // convertir el array de bytes de la base de datos a una imagen.
        public Image ByteToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

        // ir hacia atrás.
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var enterAdmin = new AdminMenu();
            enterAdmin.Show();
            this.Hide();
        }

        // Obtiene la categoría a partir de la información proporcionada.
        private string GetSelectedCategory()
        {
            // string que retornaremos, incializamos en blanco.
            string category = "";
            // usando el contexto del entity framework
            using (var db = new OrganicartEntities())
            {
                // construimos una query similar a SQL server.
                var value = (from c in db.categories
                        join p in db.products
                        on c.id equals p.category_id
                        where p.name == cmbNames.Text
                        select new { category = c.type }).ToList();

                // recorremos los resultados (1) y lo asignamos a la variable category.
                foreach (var a in value)
                {
                    category = a.category;
                }
            }
            // retornamos la categoría
            return category;
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

        /* borrar el elemento seleccionado, para lo cual me apoyo de EF al no poder
         usar ninguna TAD para esto. */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // si no he seleccionado ningun valor.
            if (cmbNames.Text == "")
            {
                MessageBox.Show("Debes seleccionar primero el valor.");
                return;
            }

            // almacenamos el resultado de la pregunta.
            var dialog = MessageBox.Show("Estás seguro que deseas eliminar este elemento?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // si el usuario aceptó la pregunta.
            if (dialog == DialogResult.Yes)
            {
                // obtenemos el valor a eliminar.
                using (var db = new OrganicartEntities())
                {
                    var delete = (from a in db.products
                        where a.name == cmbNames.Text
                        select a).SingleOrDefault();

                    // borramos el valor.
                    db.products.Remove(delete);
                    db.SaveChanges();
                }

                MessageBox.Show("El registro ha sido correctamente eliminado", "Felicidades");
                Clean(); // limpiamos la entrada
            }
        }

        // limpia la entrada de datos.
        private void Clean()
        {
            cmbNames.Text = "";
            txtPrice.Text = "";
            chosenImage.Image = null;
            cmbCategories.Text = "";
            cmbNames.Items.Clear();
            stockQuantity.Text = "0";
            GetNames();
        }

        // para entrar en modo edición
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Entrar en el modo edición eliminará tu imagen, estás seguro?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnConfirm.Visible = true;
                btnCancel.Visible = true;
                btnLoadImage.Enabled = true;
                stockQuantity.Enabled = true;

                cmbNames.Enabled = false;
                cmbCategories.Enabled = true;
                txtPrice.Enabled = true;
                chosenImage.Image = null;
            }
            
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbNames.Text == "" || txtPrice.Text == "" || chosenImage.Image == null || cmbCategories.Text == "")
                return;
            using (var db = new OrganicartEntities())
            {
                var product = db.products.Where(
                    d => d.name == cmbNames.Text).First();

                product.name = product.name;
                product.photo = ImageToInsert(chosenImage.Image);
                product.category_id = GetCategoryId();
                product.price = float.Parse(txtPrice.Text);
                product.stock = int.Parse(stockQuantity.Text);

                db.SaveChanges();

                try
                {

                    MessageBox.Show("El producto ha sido modificado con éxito!");
                    Clean();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Hubo un error {err.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Clean();
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnLoadImage.Enabled = false;
            stockQuantity.Enabled = false;
            cmbNames.Enabled = true;
            cmbCategories.Enabled = false;
            txtPrice.Enabled = false;
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
        private int GetCategoryId()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnLoadImage.Enabled = false;
            stockQuantity.Enabled = false;

            cmbNames.Enabled = true;
            cmbCategories.Enabled = false;
            txtPrice.Enabled = false;

            Clean();
        }
    }
}
