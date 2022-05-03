using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;

namespace Organicart.Controllers
{
    class GetAddress
    {
        private string username;
        public AddressQueue GetUserInfo(string pUsername)
        {
            username = pUsername;
            var addressQueue = new AddressQueue();
            
            // utilizamos el contexto generado por el Entity Framework para acceder a la bd.
            using (var db = new OrganicartEntities())
            {
                var currentUserId = GetUserId();
                // acá están almacenados absolutamente todas los direcciones que están en la bd cuyo usuario sea el logueado actualmente.
                var getAddresses = db.client_address.Where(ad => ad.client_id == currentUserId).ToList();
                foreach (var data in getAddresses)
                    addressQueue.InsertTail(data);
            }
            return addressQueue;
        }
        // Obtener el ID del usuario
        public int GetUserId()
        {
            var currentUserId = -1;
            using (var db = new OrganicartEntities())
            {
                var currentUser = db.users.FirstOrDefault(a => a.username.Equals(username));
                currentUserId = currentUser.id;
            }
            return currentUserId;
        }
    }
}
