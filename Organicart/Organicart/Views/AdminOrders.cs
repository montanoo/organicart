using System;
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

namespace Organicart.Views
{
    public partial class AdminOrders : Base
    {
        public static CustomOrder[] ordersItems;
        public static int TotalItems = 0;
        OrdersQueue orders = new OrdersQueue();
        public AdminOrders()
        {
            InitializeComponent();
            OrdersQueue ordenes = new OrdersQueue();
            //ordenes.InsertTail();
            GenerateDynamicUserControls();
        }

        private void GenerateDynamicUserControls()
        {
            orders.FillList();
            var linkedBills = orders;
            //obtenemos los productos de la categoria seleccionada

            var head = linkedBills.Head;
            //limpiamos el flow layout panel
            OrdersflowPanel.Controls.Clear();
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

                //IDProducto = productItems[i].ProductNames;
                i++;
                head = head.Next;
                TotalItems++;
            }
        }
        void CustomOrder_Click(Object sender, EventArgs e)
        {
            //lo que se ejecuta al darle click al control 
            //var dialog = MessageBox.Show("Estás seguro que deseas eliminar este elemento de tu carrito?", "Alerta",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //// si el usuario aceptó la pregunta.
            //if (dialog != DialogResult.Yes) return;
            //Products.Cart.DeleteItem(ordersItems[CustomOrder.Control.TabIndex].Address);
            //GenerateDynamicUserControls();
            //MessageBox.Show("Se ha eliminado con éxito tu producto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //TotalItems--;
        }
    }
}
