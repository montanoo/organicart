using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Controllers;
using Organicart.Models;

namespace Organicart.Controllers
{
    internal class OrdersNode
    {
        /*
       Integrantes: 
       - Fernando Josué Montano González. MG210111 | 
       - Andrea Guadalupe Velásquez Joyar. VJ210576 |
       - Ivania María Lebrón Flores. LF212591 | 
       - Luciana María Munguía Villacorta. MV210941 |
       - Carlos Vicente Castillo Sayes. CS210003 |
       */
        // valores de tipo billing son los que recibirá (billing -> base de datos tabla billing)
        //public Organicart.Models.billing Data { get; set; }

        public string Client { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public List<product> Productos { get; set; }
        public OrdersNode Next { get; set; }
    }
}
