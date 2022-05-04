using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organicart.Views
{
    public partial class AdminMenu : Base
    {
        /*
        Integrantes: 
        - Fernando Josué Montano González. MG210111 | 
        - Andrea Guadalupe Velásquez Joyar. VJ210576 |
        - Ivania María Lebrón Flores. LF212591 | 
        - Luciana María Munguía Villacorta. MV210941 |
        - Carlos Vicente Castillo Sayes. CS210003 |
        */
        public AdminMenu()
        {
            InitializeComponent();
        }

        // si hace click en añadir, entra al menu respectivo.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var openAddProducts = new AdminAddProducts();
            openAddProducts.Show();
            this.Hide();
        }

        // si hace click en editar, entra al menu respectivo.
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editProducts = new AdminEditProducts();
            editProducts.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var enterLogin = new Login();
            enterLogin.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var checkorders = new AdminOrders();
            checkorders.Show();
            this.Hide();
        }
    }
}
