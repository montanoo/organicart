using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Models;

namespace Organicart.Controllers
{
    class UserList
    {
        public UsersNode Head { get; set; }

        public UserList()
        {
            Head = null;
        }
        
        /* para insertar en la cola, al final solo insertaremos en un lado ya que nos interesa recorrerlo
        más que insertar en cierto orden, lo cual lo convierte en otra estructura que no es
        una lista enlazada, insertaremos en la cola nada más (al final), actuará como una queue. (cola) */
        public void InsertTail(user item)
        {
            // creamos un nodo auxiliar del tipo nodo usuario.
            var helper = new UsersNode
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
                {
                    pointer = pointer.Next;
                }
                pointer.Next = helper;
            }
        }
    }
}
