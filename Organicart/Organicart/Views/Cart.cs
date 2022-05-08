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
        public static double SessionPrice;
        private string username;
        public static CustomCartItem[] cartItems;
        public static int TotalItems = 0;
        public Cart(string pUsername)
        {
            SessionPrice = 0;
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
                TotalItems++;
            }
        }
        void UserControl_Click(Object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Estás seguro que deseas eliminar este elemento de tu carrito?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            // si el usuario aceptó la pregunta.
            if (dialog != DialogResult.Yes) return;
            Products.Cart.DeleteItem(cartItems[CustomCartItem.Control.TabIndex].ProductNames);
            GenerateDynamicUserControls();
            MessageBox.Show("Se ha eliminado con éxito tu producto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TotalItems--;
        }

        // este metodo nos permite cambiar de un array de bytes a un tipo Image.
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

        // si se desea ir al perfil.
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
            if (TotalItems == 0)
            {
                MessageBox.Show("Debes meter aunque sea algún producto a tu carrito antes de pagar.");
                return;
            }

            var getAddress = new GetAddress();
            var values = getAddress.GetUserInfo(username);
            var amountOfAddress = values.CountQuantity(values.Head);
            if (amountOfAddress == 1)
            {
                var addressid = 0;
                using (OrganicartEntities database = new OrganicartEntities())
                {
                    client_address dataadress = new client_address();
                    user gettingid = database.users.Where(a => a.username == username).FirstOrDefault();
                    client refid = database.clients.Where(a => a.user_id == gettingid.id).FirstOrDefault();
                    dataadress.client_id = refid.id;
                    addressid = dataadress.id;
                }
                Price();
                var enterPayment = new Payment(username, addressid);
                enterPayment.Show();
                this.Hide();
                return;
            }
            Price();
            var enterCheckout = new Address(username);
            enterCheckout.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var enterAbout = new About(username);
            enterAbout.Show();
            this.Hide();
        }

        private void Price()
        {
            foreach (var t in cartItems)
            {
                SessionPrice += t.Price * (double) t.Quantity;
            }
        }

        //metodo para limpiar el carrito
        public void ClearCart()
        {
            flowLayoutPanel1.Controls.Clear();
        }

    }
}
