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
using Organicart.Views;

namespace Organicart
{
    public partial class Cart : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public Cart()
        {
            InitializeComponent();
            GenerateDynamicUserControls();

        }
        private void GenerateDynamicUserControls()
        {
            var linkedProducts = new ProductsList();
            //obtenemos los productos de la categoria seleccionada
            var values = Products.Cart;

            var head = values.Head;
            //limpiamos el flow layout panel
            flowLayoutPanel1.Controls.Clear();
            //establecemos la cantidad de product items que aparecerán en pantalla
            var productItems = new CustomCartItem[CountItems()];
            var i = 0;

            while (head != null)
            {
                //creating cart items
                productItems[i] = new CustomCartItem();

                //adding data to cart items
                productItems[i].ProductNames = head.Data.name;
                productItems[i].ProductImage = ByteToImage(head.Data.photo);
                productItems[i].Price = (float) head.Data.price;

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(productItems[i]);

                i++;
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
        public int CountItems()
        {
            int quantity = 0;
            var linkedCart = Products.Cart;
            //obtenemos los productos de la categoria seleccionada
            

            var head = linkedCart.Head;
            while (head != null)
            {
                quantity++;
                head = head.Next;
            }
            return quantity;
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var enterProfile = new Profile();
            enterProfile.Show();
            this.Hide();
        }

        private void Productsbtn_Click(object sender, EventArgs e)
        {
            var enterHome = new HomePage();
            enterHome.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var enterAddress = new Address();
            enterAddress.Show();
            this.Hide();
        }
    }
}
