using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrganicartProto
{
    public partial class CartForm : OrganicartProto.Form2
    {
        public CartForm()
        {
            InitializeComponent();
            GenerateDynamicUserControls();
        }

        private void GenerateDynamicUserControls()
        {
            flowLayoutPanel1.Controls.Clear();
            CustomCartItem[] cartitem = new CustomCartItem[2];

            //sample product names
            string[] title = new string[2] { "Pan de Barra Bimbo - 530 grs", "Papel Higiénico Scott - 18 Rollos" };

            //sample prices
            float[] price = new float[2] { 2, 7 };

            //sample images
            Image[] product =  new Image[2] {Properties.Resources.bread, Properties.Resources.toiletpaper};

            //sample quantity
            decimal[] quantity = new decimal[2] { 1,1 };

            for (int i = 0; i < cartitem.Length; i++)
            {
                //creating cart items
                cartitem[i] = new CustomCartItem();

                //adding data to cart items
                cartitem[i].ProductNames = title[i];
                cartitem[i].ProductImage = product[i];
                cartitem[i].Price = price[i];
                cartitem[i].Quantity = quantity[i];

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(cartitem[i]);
            }
        }
    }
}
