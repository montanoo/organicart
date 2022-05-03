using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;

namespace Organicart.Controllers
{
    internal class AddressQueue
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public AddressNode Head { get; set; }

        public AddressQueue()
        {
            Head = null;
        }

        /* para insertar en la cola, al final solo insertaremos en un lado ya que nos interesa recorrerlo
        más que insertar en cierto orden, lo cual lo convierte en otra estructura que no es
        una lista enlazada, insertaremos en la cola nada más (al final), actuará como una queue. (cola) */
        public void InsertTail(client_address item)
        {
            // creamos un nodo auxiliar del tipo nodo usuario.
            var helper = new AddressNode
            {
                Data = item,
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

        // Método para contar la cantidad de elementos en la queue.
        public int CountQuantity(AddressNode head)
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
    }
}
