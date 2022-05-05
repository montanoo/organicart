using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Organicart.Views;
using Organicart.Models;
using System.Data.OleDb;
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
        public void DeleteHead(DateTime actual)
        {
            // si el primer valor no es null borramos
            if (Head != null)
            {
                //elimina el primer nodo de la lista
                Head = Head.Next;

                //borrar de la tabla
                //iniciamos un helper vacío
                var helper = new OrdersNode { };
                List<billing> billList = new List<billing>();

                using (var db = new OrganicartEntities())
                {

                    //array con todas las instancias de billing que tienen la fecha y hora que se esta buscando
                    var query = (from c in db.billings
                                 where c.date == actual
                                 select c).ToArray();

                    //eliminamos los billings de la bd
                    foreach (var q in query)
                    {
                        db.billings.Remove(q);
                    }
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }


        // Método para contar la cantidad de elementos en la queue.
        public int CountQuantity()
        {
            int quantity = 0;
            var linkedCart = Products.Cart;
            OrdersQueue ordenes = new OrdersQueue();
            ordenes.FillList();
            //obtenemos los productos del carrito

            var helper = ordenes.Head;
            while (helper != null)
            {
                quantity++;
                helper = helper.Next;
            }
            return quantity;
        }
        //método de busqueda por posiciones de la cola, asi lo recorremos uno a uno

        public OrdersNode SearchByDatetime(DateTime datee)
        {
            OrdersQueue orders = new OrdersQueue();
            orders.FillList();
            var helper = orders.Head;
            OrdersNode pointer = Head;

            if (Head != null)// si la cola no esta vacia
            {
                while (helper.Date != datee)
                {
                    helper = helper.Next;
                    if (pointer.Next == null)// si llegamos al final de la cola
                    {
                        break;
                    }
                }
                OrdersNode chosenpointer;// apuntador para seleccionar el puntero en la posicion escogida
                chosenpointer = pointer; // asignamos el puntero a la posicion elegida
            }
            return pointer;
        }
        public OrdersNode SearchOrders(int position)
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
        public void FillList()
        {
            //iniciamos un helper vacío
            var helper = new OrdersNode { };

            using (var db = new OrganicartEntities())
            {

                //sacamos las fechas que se repiten y el numero de repeticiones para separar pedidos
                var dategroups = (from t in db.billings
                                  group t by t.date into g
                                  select new
                                  {
                                      dategr = g.Key,
                                      productquantity = g.Count()
                                  }).ToArray();

                //captamos los valores de cada fecha y  la cantidad de veces que se repite

                for (int i = 0; i < dategroups.Length; i++)
                {
                    //aca guardamos los productos que estan en el billing
                    List<product> listaproductos = new List<product>();

                    int quantity = dategroups[i].productquantity;
                    DateTime dateq = (DateTime)dategroups[i].dategr;

                    //array con todas las instancias de billing que tienen la fecha y hora que se esta buscando
                    var query = (from c in db.billings
                                 where c.date == dateq
                                 select c).ToArray();
                    //solo saca el primer billing con la fecha y hora que se esta consultando
                    var firstquery = (from c in db.billings
                                      where c.date == dateq
                                      select c).FirstOrDefault();

                    //obtenemos el cliente y la direccion de el primer dato con los id especificados
                    var idclient = (from c in db.clients
                                    where c.id == firstquery.client_id
                                    select c).SingleOrDefault();

                    /*ES NECESARIO QUE NO HAYA REPETICION EN CLIENT_ADDRESS PARA QUE ESTO FUNCIONE*/
                    //var idaddress = (from ad in db.client_address
                    //                 where ad.client_id == firstquery.client_id
                    //                 select ad).SingleOrDefault();

                    //recorremos el array con los billings
                    for (int j = 0; j < query.Length; j++)
                    {
                        int a = (int)query[j].product_id;
                        var idproductos = (from prod in db.products
                                           where prod.id == a
                                           select prod).FirstOrDefault();
                        listaproductos.Add(idproductos);
                    }
                    //aqui es donde vamos a llenar la colita, aqui llenaremos el nodo orders
                    helper = new OrdersNode
                    {
                        Client = idclient.name,
                        Id = (int)firstquery.client_id,
                        /*Questionable*/
                        Quantity = query.Length,
                        Date = (DateTime)firstquery.date,
                        //ADDRESS VACIA MIENTRAS SE QUITA LA REPETICION EN CLIENT_ADDRESS
                        Address = "sample address",
                        Productos = listaproductos,
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
            }
        }
    }
}
