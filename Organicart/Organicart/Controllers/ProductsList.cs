using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Models;
using Organicart.Views;

namespace Organicart.Controllers
{
    class ProductsList
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public ProductsNode Head { get; set; }

        public ProductsList()
        {
            Head = null;
        }
        public void InsertTail(product item)
        {
            // creamos un nodo auxiliar del tipo nodo usuario.
            var helper = new ProductsNode()
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

        // obtener los registros que hay en la base de datos.
        public ProductsList GetProducts()
        {
            // instanciamos la lista.
            var linkedProducts = new ProductsList();
            // contexto de la base de datos dada por Entity Framework.
            using (var db = new OrganicartEntities())
            {
                /* en la variable products están todos los productos de la base,
                   guardados como clase product.*/
                var products = db.products;

                // recorremos los productos y los guardamos en el final de la lista.
                foreach (var product in products)
                {
                    linkedProducts.InsertTail(product);
                }

                return linkedProducts;
            }
        }
        public ProductsList GetProductsByCategory(int categorynum)
        {
            // instanciamos la lista.
            var linkedProducts = new ProductsList();
            // contexto de la base de datos dada por Entity Framework.
            using (var db = new OrganicartEntities())
            {
                /* en la variable products están todos los productos de la base,
                   guardados como clase product.*/
                //buscamos los productos de la categoria deseada
                var products = db.products.Where(d => d.category_id == categorynum);

                foreach (var product in products)
                {
                    linkedProducts.InsertTail(product);
                }

                return linkedProducts;
            }
        }

        // Método para contar la cantidad de elementos en la lista.
        public int CountQuantity()
        {
            var helper = Head;
            int i = 0;
            while (helper != null)
            {
                i++;
                helper = helper.Next;
            }
            return i;
        }

        //método de busqueda por posiciones producto, asi lo recorremos uno a uno
        public ProductsNode SearchProd(int position)
        {
                ProductsNode pointer = Head;
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
                    ProductsNode chosenpointer;// apuntador para seleccionar el puntero en la posicion escogida
                    chosenpointer = pointer; // asignamos el puntero a la posicion elegida
                }
            }
            return pointer;
        }
    }
}
