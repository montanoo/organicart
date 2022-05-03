using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Models;


namespace Organicart.Controllers
{
    public class CartNode
    {
        /*
       Integrantes: 
       - Fernando Josué Montano González. MG210111 | 
       - Andrea Guadalupe Velásquez Joyar. VJ210576 |
       - Ivania María Lebrón Flores. LF212591 | 
       - Luciana María Munguía Villacorta. MV210941 |
       - Carlos Vicente Castillo Sayes. CS210003 |
       */
        // valores de tipo product son los que recibirá (product -> base de datos tabla product)
        public product Data { get; set; }
        public CartNode Next { get; set; }
    }
}
