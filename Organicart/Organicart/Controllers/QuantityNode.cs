using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organicart.Controllers
{
    internal class QuantityNode
    {
        /*
      Integrantes: 
      - Fernando Josué Montano González. MG210111 | 
      - Andrea Guadalupe Velásquez Joyar. VJ210576 |
      - Ivania María Lebrón Flores. LF212591 | 
      - Luciana María Munguía Villacorta. MV210941 |
      - Carlos Vicente Castillo Sayes. CS210003 |
      */

        public int Quantity { get; set; }
        public QuantityNode Next { get; set; }
    }
}
