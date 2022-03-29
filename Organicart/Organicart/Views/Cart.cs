using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Views;

namespace Organicart
{
    public partial class Cart : Base
    {
        public Cart()
        {
            InitializeComponent();
            GenerateDynamicUserControls();

        }
        private void GenerateDynamicUserControls()
        {
            flowLayoutPanel1.Controls.Clear();
            CustomCartItem[] cartItems = new CustomCartItem[2];

            //sample product names
            string[] title = new string[2] { "Pan de Barra Bimbo - 530 grs", "Papel Higiénico Scott - 18 Rollos" };

            //sample prices
            float[] price = new float[2] { 2, 7 };

            //sample images
            Image[] product = new Image[2] { Properties.Resources.bread, Properties.Resources.toiletpaper };

            //sample quantity
            decimal[] quantity = new decimal[2] { 1, 1 };

            for (int i = 0; i < cartItems.Length; i++)
            {
                //creating cart items
                cartItems[i] = new CustomCartItem();

                //adding data to cart items
                cartItems[i].ProductNames = title[i];
                cartItems[i].ProductImage = product[i];
                cartItems[i].Price = price[i];
                cartItems[i].Quantity = quantity[i];

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(cartItems[i]);
            }
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

        private void aboutUsbtn_Click(object sender, EventArgs e)
        {
            AboutUs enterAboutUs = new AboutUs();
            enterAboutUs.Show();
            this.Hide();
        }
    }
}
