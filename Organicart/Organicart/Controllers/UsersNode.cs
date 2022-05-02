using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organicart.Models;

namespace Organicart.Controllers
{
    /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */

    // clase utilizada para tener a todos los usuarios como nodos de una lista enlazada.
    class UsersNode
    {
        // valores de tipo user son los que recibirá (user -> base de datos tabla user)
        public user Data { get; set; }
        public UsersNode Next { get; set; }

    }
}
