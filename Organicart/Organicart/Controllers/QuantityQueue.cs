using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Views;
using Organicart.Models;

namespace Organicart.Controllers
{
    internal class QuantityQueue
    {

        /*
    Integrantes: 
    - Fernando Josué Montano González. MG210111 | 
    - Andrea Guadalupe Velásquez Joyar. VJ210576 |
    - Ivania María Lebrón Flores. LF212591 | 
    - Luciana María Munguía Villacorta. MV210941 |
    - Carlos Vicente Castillo Sayes. CS210003 |
    */
        public QuantityNode Head { get; set; }

        // Método para contar la cantidad de elementos en la queue.
        public int CountQuantity()
        {
            int quantity = 0;
            var linkedCart = Products.Cart;
            QuantityQueue cantidades = new QuantityQueue();

            //obtenemos el numero de cantidades

            var helper = cantidades.Head;
            while (helper != null)
            {
                quantity++;
                helper = helper.Next;
            }
            return quantity;
        }

        public void InsertTail(int q)
        {
            // creamos un nodo auxiliar del tipo nodo usuario.
            var helper = new QuantityNode()
            {
                Quantity = q,
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

        //método de busqueda por posiciones de cantidad
        public int SearchQuantity(int position)
        {
            QuantityNode pointer = Head;
            int chosenq=0;// para seleccionar la cantidad

            if (Head != null)// si la lista no esta vacia
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

                    chosenq = pointer.Quantity; // asignamos el puntero a la posicion elegida
                }
            }
            return chosenq;
        }
    }
}