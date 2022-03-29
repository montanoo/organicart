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

namespace Organicart.Views
{
    public partial class AdminEditProducts : Base
    {
        public AdminEditProducts()
        {
            InitializeComponent();
            GetNames();
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
                    txtPrice.Text = head.Data.price.ToString();
                }
                head = head.Next;
            }
        }

        public Image ByteToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
    }
}
