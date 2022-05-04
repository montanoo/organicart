using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Views;
using Organicart.Models;
using System.IO;

namespace Organicart.Controllers
{
    internal class OrdersQueue
    {
        /*
      Integrantes: 
      - Fernando Josué Montano González. MG210111 | 
      - Andrea Guadalupe Velásquez Joyar. VJ210576 |
      - Ivania María Lebrón Flores. LF212591 | 
      - Luciana María Munguía Villacorta. MV210941 |
      - Carlos Vicente Castillo Sayes. CS210003 |
      */
        public OrdersNode Head { get; set; }

        public OrdersQueue()
        {
            Head = null;
        }

        public void InsertTail(string client, int id, int quantity, DateTime date, string address)
        {
            // creamos un nodo auxiliar del tipo nodo orden.
            var helper = new OrdersNode
            {
                Client = client,
                Id = id,
                Quantity = quantity,
                Date = date,
                Address = address,
                Next = null
            };

            // si el primer valor es null, creamos un nuevo primer valor.
            if (Head == null)
                Head = helper;
            // si no, lo insertamos al final.
            else
            {
                var pointer = Head;
                while (pointer.Next != null)
                    pointer = pointer.Next;
                pointer.Next = helper;
            }
        }

        public void DeleteHead()
        {
            // si el primer valor no es null borramos
            if (Head != null)
            {
                //elimina el primer nodo de la lista
                Head = Head.Next;
            }
        }

        // Método para contar la cantidad de elementos en la queue.
        public int CountQuantity(OrdersNode head)
        {
            var helper = head;
            int i = 0;
            while (helper != null)
            {
                i++;
                helper = helper.Next;
            }
            return i;
        }
        //método de busqueda por posiciones de la cola, asi lo recorremos uno a uno
        public OrdersNode SearchCart(int position)
        {
            OrdersNode pointer = Head;
            if (Head != null)// si la cola no esta vacia
            {
                if (position == 1)//cuando se necesita el nodo 1
                {
                    pointer = Head;
                }
                else
                {
                    for (int i = 1; i <= position - 1; i++) // si se necesita otra posicion que no sea 1
                    {
                        pointer = pointer.Next;
                        if (pointer.Next == null)// si llegamos al final de la lista
                        {
                            break;
                        }
                    }
                    OrdersNode chosenpointer;// apuntador para seleccionar el puntero en la posicion escogida
                    chosenpointer = pointer; // asignamos el puntero a la posicion elegida
                }
            }
            return pointer;
        }

        public OrdersQueue GetOrders()
        {
            // instanciamos la cola.
            var linkedOrders = new OrdersQueue();
            // contexto de la base de datos dada por Entity Framework.
            using (var db = new Organicart.Models.OrganicartEntities())
            {
                var orders = db.billings;
                ///* en la variable products están todos los productos de la base,
                //   guardados como clase product.*/
                //var products = db.products;

                //// recorremos los productos y los guardamos en el final de la lista.
                //foreach (var product in products)
                //{
                //    linkedProducts.InsertTail(product);
                //}

                return linkedOrders;
            }
        }
        public void TailTrying()
        {
            using (var db = new Organicart.Models.OrganicartEntities())
            {
                Organicart.Models.billing order = new Models.billing();
                var or = db.billings;

                Organicart.Models.billing[] orders = new Models.billing[db.billings.Count()];

                //cosas malas
                //var helper = new OrdersNode
                //{
                    
                //    Client = order.client_id.ToString(),
                //    Id = order.client_id,
                //    Quantity = quantity,
                //    Date = date,
                //    Address = address,
                //    Next = null
                //};
                //Models.user gettingid = db.users.Where(a => a.username == username).FirstOrDefault();

                //for (int i = 0; i < db.billings.Count(); i++)
                //{
                //    DateTime fechacomun = new DateTime();
                //    fechacomun = (DateTime)order.date;
                //    DateTime fechaacomun = new DateTime();
                //    fechaacomun = db.billings.Where() ;
                //    orders = db.billings.Where(a => a.date == fechaacomun);
                //}
            
            }
        }
    }
}
