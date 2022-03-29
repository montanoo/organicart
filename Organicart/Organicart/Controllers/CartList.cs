using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Models;

namespace Organicart.Controllers
{
    public class CartList
    {
        /*
       Integrantes: 
       - Fernando Josué Montano González. MG210111 | 
       - Andrea Guadalupe Velásquez Joyar. VJ210576 |
       - Ivania María Lebrón Flores. LF212591 | 
       - Luciana María Munguía Villacorta. MV210941 |
       - Carlos Vicente Castillo Sayes. CS210003 |
       */
        public CartNode Head { get; set; }

        public CartList()
        {
            Head = null;
        }

        public void InsertTail(string name)
        {
            using (var db = new OrganicartEntities())
            {
                /* en la variable products están todos los productos de la base,
                   guardados como clase product.*/
                //buscamos el producto con el id deseado
                var products = db.products.Where(d => d.name == name).First();
                // creamos un nodo auxiliar del tipo nodo carrito.
                var helper = new CartNode()
                {
                    Data = products,
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
                    {
                        pointer = pointer.Next;
                    }
                    pointer.Next = helper;
                }
            }
        }
        //método de busqueda por posiciones del carrito, asi lo recorremos uno a uno
        public CartNode SearchCart(int position)
        {
            CartNode pointer = Head;
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
                    CartNode chosenpointer;// apuntador para seleccionar el puntero en la posicion escogida
                    chosenpointer = pointer; // asignamos el puntero a la posicion elegida
                }
            }
            return pointer;
        }

        public bool Repeated(string name)
        {
            /*Tenemos un nuevo nodo auxiliar (puntero) que toma lo que tenga
             el nodo raiz que es el listado completo*/

            CartNode pointer = Head;
            bool repetition;

            if (Head != null)
            {
                repetition = true;
                /*comparamos cada puntero para saber si es diferente al carnet
                si todos son diferentes se retorna false*/
                while (pointer.Data.name != name)
                {
                    pointer = pointer.Next;

                    if (pointer == null)// si llega al final y no se ha encontrado un dui igual, no esta repetido
                    {
                        repetition = false;
                        break;
                    }
                }
            }
            else
            {
                repetition = false;   
            }
            return repetition;
        }


    }
}
