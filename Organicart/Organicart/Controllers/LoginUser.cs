using System.Windows.Forms;
using Organicart.Models;
using Organicart.Views;

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
    class LoginUser
    {
        /* para darle uso a las estructuras de datos, añadiremos los usuarios a 
         listas simplemente enlazadas */

        // el método get info se encargará de obtener los valores
        public UserList GetInfo()
        {
            var linkedUsers = new UserList();
            // utilizamos el contexto generado por el Entity Framework para acceder a la bd.
            using (var db = new OrganicartEntities())
            {
                // acá están almacenados absolutamente todos los usuarios que están en la bd.
                var users = db.users;

                /* recorremos a los usuarios con "var",
                 pudimos usar la clase "user" que se creo al usar Entity Framework. */

                foreach (var user in users)
                {
                    linkedUsers.InsertTail(user);
                }
            }
            // retornamos esa lista.
            return linkedUsers;
        }

        public bool Login(string pUsername, string pPassword)
        {
            // leemos los datos con el método anterior.
            var valuesToWork = GetInfo();
            int userRole = 2; // para saber en que categoría entra.
            bool found = false; // bandera que me indicará si se encuentra un usuario que cumpla con las características.

            var currentUser = valuesToWork.Head;

            // recorremos la lista enlazada.
            while (currentUser != null)
            {
                // si encontramos una coincidencia, buscamos que rol tiene.
                if (currentUser.Data.username == pUsername && currentUser.Data.password == pPassword)
                {
                    userRole = currentUser.Data.role_id;
                    found = true;
                }
                currentUser = currentUser.Next;
            }
            var currentForm = new Login();
            if (!found)
            {
                MessageBox.Show(
                    "No hemos encontrado tu usuario, asegurate de haber escrito tu usuario y contraseña correctamente");
            }

            if (found)
            {
                if (userRole == 1)
                {
                    var joinAdmin = new AdminMenu();
                    joinAdmin.Show();

                    currentForm.Hide();
                }
                else
                {
                    var joinHomePage = new HomePage(pUsername);
                    joinHomePage.Show();

                    currentForm.Hide();
                }
            }

            return found;
        }
    }
}
