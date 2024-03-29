﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;
using Organicart.Controllers;
using Organicart.UserControls;
using System.IO;
using Organicart.Views;

namespace Organicart.Views
{
    public partial class AdminOrders : Base
    {
        /*
Integrantes: 
- Fernando Josué Montano González. MG210111 | 
- Andrea Guadalupe Velásquez Joyar. VJ210576 |
- Ivania María Lebrón Flores. LF212591 | 
- Luciana María Munguía Villacorta. MV210941 |
- Carlos Vicente Castillo Sayes. CS210003 |
*/
        public static CustomOrder[] ordersItems;
        public static CustomProductResult[] productItems;
        public static int TotalItems = 0;
        public static int TotalItems2 = 0;

        OrdersQueue orders = new OrdersQueue();
        public AdminOrders()
        {
            InitializeComponent();
            OrdersQueue ordenes = new OrdersQueue();
            GenerateDynamicUserControls();
        }

        private void GenerateDynamicUserControls()
        {
            //limpiamos el flow layout panel
            OrdersflowPanel.Controls.Clear();
            orders.FillList();
            var linkedBills = orders;
            //obtenemos los productos de la categoria seleccionada

            var head = linkedBills.Head;
            //establecemos la cantidad de product items que aparecerán en pantalla
            ordersItems = new CustomOrder[orders.CountQuantity()];
            var i = 0;
            while (head != null)
            {
                var values = linkedBills.SearchOrders(i);
                //creating cart items
                ordersItems[i] = new CustomOrder();
                ordersItems[i].ClientName = head.Client;
                ordersItems[i].ID = head.Id;
                ordersItems[i].Date = head.Date;
                ordersItems[i].Quantity = head.Quantity;
                ordersItems[i].Address = head.Address;

                //adding items to the flow layout panel
                OrdersflowPanel.Controls.Add(ordersItems[i]);

                ordersItems[i].Click += this.CustomOrder_Click;

                i++;
                head = head.Next;
                TotalItems++;
            }
        }
        void CustomOrder_Click(Object sender, EventArgs e)
        {
            CustomOrder orden = (CustomOrder)sender; // para acceder a los elementos de la orden seleccionada
            DateTime clavedate = orden.Date;
            GenerateSelectedProducts(clavedate);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var enterAdmin = new AdminMenu();
            enterAdmin.Show();
            this.Hide();
        }

        private void GenerateSelectedProducts(DateTime datee)
        {
            orders.FillList();
            var linkedBills = orders;
            OrdersNode searching = linkedBills.SearchByDatetime(datee);
            #region orders
            List<product> productos = searching.Productos; 
            #endregion

            //limpiamos el flow layout panel
            ProductsLayoutPanel2.Controls.Clear();
            //establecemos la cantidad de product items que aparecerán en pantalla
            productItems = new CustomProductResult[productos.Count()];
            var i = 0;
            foreach (var prod in productos)
            {
                var values = linkedBills.SearchOrders(i);
                //creating cart items
                productItems[i] = new CustomProductResult();
                productItems[i].ProdName = prod.name;
                productItems[i].Quantity = searching.CantperProd[i];
                productItems[i].ProdID = prod.id;
                productItems[i].Price = (double)prod.price;
                productItems[i].ProductImage = ByteToImage(prod.photo);

                //adding items to the flow layout panel
                ProductsLayoutPanel2.Controls.Add(productItems[i]);

                i++;
                TotalItems2++;
            }
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

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if(!CheckIfEmpty())
            {
                //despacho de productos
                DateTime ordering = ordersItems[0].Date;
                orders.DeleteHead(ordering); //se elimina de la tad y de la base
                OrdersflowPanel.Controls.RemoveAt(0);
                OrdersflowPanel.Update();
                ProductsLayoutPanel2.Controls.Clear();

                MessageBox.Show("Pedido despachado con éxito", "Despacho de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckIfEmpty()
        {
            bool empty = false;
            if (OrdersflowPanel.Controls.Count == 0)
            {
                empty = true;
            }
            return empty;
        }
    }
}
