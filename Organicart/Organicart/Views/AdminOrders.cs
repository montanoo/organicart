using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organicart.Models;
using Organicart.Controllers;

namespace Organicart.Views
{
    public partial class AdminOrders : Base
    {
        public AdminOrders()
        {
            InitializeComponent();
            OrdersQueue ordenes = new OrdersQueue();
            ordenes.TailTrying();
        }
    }
}
