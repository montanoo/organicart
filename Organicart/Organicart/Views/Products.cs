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
        Controllers.ProductsList products = new Controllers.ProductsList();
        //recibimos la categoria que se quiere ver
        int selectedcategory;
        int IDProducto;
        public Products(int category)
        {
            selectedcategory = category;
            InitializeComponent();
            GenerateDynamicUserControls();        
        }
        private void GenerateDynamicUserControls()
        {
            var linkedProducts = new Controllers.ProductsList();
            //obtenemos los productos de la categoria seleccionada
            var values = linkedProducts.GetProductsByCategory(selectedcategory);

            var head = values.Head;
            //limpiamos el flow layout panel
            flowLayoutPanel1.Controls.Clear();
            //establecemos la cantidad de product items que aparecerán en pantalla
            CustomProductItem[] productitem = new CustomProductItem[CountItems()];
            int i = 0;

            while (head != null)
            {
                //creating cart items
                productitem[i] = new CustomProductItem();

                //adding data to cart items
                productitem[i].ProductNames = head.Data.name;
                productitem[i].ProductImage = ByteToImage(head.Data.photo);
                productitem[i].Price = (double)head.Data.price;

                //adding items to the flow layout panel
                flowLayoutPanel1.Controls.Add(productitem[i]);

                productitem[i].Click += new System.EventHandler(this.UserControl_Click);
                IDProducto = head.Data.id;
                i++;
                head = head.Next;
            }
        }
        //evento cuando se le da click a un item de producto
        void UserControl_Click(Object sender, EventArgs e)
        {
            //guardar en lista CartList
            Controllers.CartList cart = new Controllers.CartList();
            cart.InsertTail(IDProducto);
        }

        //cuenta los items que cumplen con la categoria seleccionada
        public int CountItems()
        {
            int quantity = 0;
            var linkedProducts = new Controllers.ProductsList();
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
    }
}
