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
using Organicart.Controllers;

namespace Organicart.Views
{
    public partial class Products : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */

        // creamos un objeto de clase productslist
        ProductsList products = new ProductsList();
        //recibimos la categoria que se quiere ver
        int selectedcategory;

        CustomProductItem[] productItems;

        private string username;
        //creamos el carrito 
        public static CartList Cart = new CartList();
        public Products(int category, string pUsername)
        {
            selectedcategory = category;
            InitializeComponent();
            GenerateDynamicUserControls();
            username = pUsername;
        }
        private void GenerateDynamicUserControls()
        {
            var linkedProducts = new ProductsList();
            //obtenemos los productos de la categoria seleccionada
            var values = linkedProducts.GetProductsByCategory(selectedcategory);

            var head = values.Head;
            //limpiamos el flow layout panel
            flowLayoutPanel1.Controls.Clear();
            //establecemos la cantidad de product items que aparecerán en pantalla
            productItems = new CustomProductItem[CountItems()];
            var i = 0;

            while (head != null)
            {
                //creating cart items
                productItems[i] = new CustomProductItem();

                //adding data to cart items
                productItems[i].ProductNames = head.Data.name;
                productItems[i].ProductImage = ByteToImage(head.Data.photo);
                productItems[i].Price = (double) head.Data.price;

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(productItems[i]);

                productItems[i].Click += this.UserControl_Click;
                //IDProducto = productItems[i].ProductNames;
                i++;
                head = head.Next;
            }

        }
        //evento cuando se le da click a un item de producto
        void UserControl_Click(Object sender, EventArgs e)
        {
            if (!Cart.Repeated(productItems[CustomProductItem.Control.TabIndex].ProductNames))
            {
                Cart.InsertTail(productItems[CustomProductItem.Control.TabIndex].ProductNames);
            }
            else
            {
                MessageBox.Show("Este producto ya se encuentra en tu carrito! puedes cambiar la cantidad en el carrito");
            }
        }

        //cuenta los items que cumplen con la categoria seleccionada
        public int CountItems()
        {
            var quantity = 0;
            var linkedProducts = new ProductsList();
            //obtenemos los productos de la categoria seleccionada
            var values = linkedProducts.GetProductsByCategory(selectedcategory);

            var head = values.Head;
            while (head != null)
            {
                quantity++;
                head = head.Next;
            }
            return quantity;
        }

        //método para convertir de byte a imagen desde la bd
        public Image ByteToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void Cartbtn_Click(object sender, EventArgs e)
        {
            var enterCart = new Cart(username);
            enterCart.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var enterProfile = new Profile(username);
            enterProfile.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage(username);
            enterHome.Show();
            this.Hide();
        }

        private void aboutUsbtn_Click(object sender, EventArgs e)
        {
            AboutUs enterAboutUs = new AboutUs();
            enterAboutUs.Show();
            this.Hide();
        }
    }
}
