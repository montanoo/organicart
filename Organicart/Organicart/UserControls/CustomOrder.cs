using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organicart.UserControls
{
    public partial class CustomOrder : UserControl
    {
        public static Control Control;
        public CustomOrder()
        {
            InitializeComponent();
        }

        #region Getter and setter for labels
        private string _client;
        private int _id;
        private int _quantity;
        private DateTime _date;
        private string _address;

        public string ClientName
        {
            get { return _client; }
            set { _client = value; Clientlbl.Text = "Cliente: " +value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; IDlbl.Text = "ID: "+value.ToString(); }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; Quantitylbl.Text = "Productos: "+value.ToString(); }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; Datelbl.Text = "Fecha y hora: "+value.ToString(); }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; Addresslbl.Text = "Dirección: " + value; }
        }
        #endregion

        private void CustomOrder_Click(object sender, EventArgs e)
        {
            Control = (Control)sender;   // Sender gives you which control is clicked.
        }
    }
}
