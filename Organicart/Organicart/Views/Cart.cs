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

        private string username;
        CustomCartItem[] cartItems;
        public Cart(string pUsername)
        {
            InitializeComponent();
            GenerateDynamicUserControls();

            username = pUsername;
        }
        private void GenerateDynamicUserControls()
        {
            //var linkedProducts = new CartList();
            var linkedProducts = Products.Cart;
            //obtenemos los productos de la categoria seleccionada

            var head = linkedProducts.Head;
            //limpiamos el flow layout panel
            flowLayoutPanel1.Controls.Clear();
            //establecemos la cantidad de product items que aparecerán en pantalla
            cartItems = new CustomCartItem[CountItems()];
            var i = 0;

            while (head != null)
            {
                var values = linkedProducts.SearchCart(i);
                //creating cart items
                cartItems[i] = new CustomCartItem();

                //adding data to cart items
                cartItems[i].ProductNames = head.Data.name;
                cartItems[i].ProductImage = ByteToImage(head.Data.photo);
                cartItems[i].Price = (double)head.Data.price;

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(cartItems[i]);

                cartItems[i].Click += this.UserControl_Click;
                //IDProducto = productItems[i].ProductNames;
                i++;
                head = head.Next;
            }

        }
        void UserControl_Click(Object sender, EventArgs e)
        {
            MessageBox.Show(cartItems[CustomCartItem.Control.TabIndex].ProductName);
            Products.Cart.DeleteItem(cartItems[CustomCartItem.Control.TabIndex].ProductNames);
            GenerateDynamicUserControls();
            //hacer metodo de cart para delete
            //esto nooo Cart.InsertTail(productItems[CustomProductItem.Control.TabIndex].ProductNames);
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
            //obtenemos los productos del carrito
            

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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var enterAddress = new Address(username);
            enterAddress.Show();
            this.Hide();
        }
    }
}
