using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organicart.Views
{
    public partial class Products : Base
    {
        public Products()
        {
            InitializeComponent();
            GenerateDynamicUserControls();
        }
        private void GenerateDynamicUserControls()
        {
            flowLayoutPanel1.Controls.Clear();
            CustomProductItem[] productitem = new CustomProductItem[5];

            //sample product names
            string[] title = new string[5] { "Semita Alta", "Aceite Orisol 875ml", "2 Pack Arroz Precocido 1LB", "Pan de Barra Bimbo - 530 grs", "Papel Higiénico Scott - 18 Rollos" };

            //sample prices
            double[] price = new double[5] { 0.45, 5.60, 1.55, 2.00, 7.00 };

            //sample images
            Image[] product = new Image[5] { Properties.Resources.semita, Properties.Resources.oil, Properties.Resources.rice, Properties.Resources.bread, Properties.Resources.toiletpaper };

            //sample quantity
            //    decimal[] quantity = new decimal[2] { 1, 1 };

            for (int i = 0; i < productitem.Length; i++)
            {
                //creating cart items
                productitem[i] = new CustomProductItem();

                //adding data to cart items
                productitem[i].ProductNames = title[i];
                productitem[i].ProductImage = product[i];
                productitem[i].Price = price[i];
                //    cartitem[i].Quantity = quantity[i];

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(productitem[i]);

            }
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            Cart enterCart = new Cart();
            enterCart.Show();
            this.Hide();
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

        private void aboutUsbtn_Click(object sender, EventArgs e)
        {
            AboutUs enterAboutUs = new AboutUs();
            enterAboutUs.Show();
            this.Hide();
        }
    }
}
