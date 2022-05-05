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
    public partial class CustomProductResult : UserControl
    {
        public CustomProductResult()
        {
            InitializeComponent();
        }

        #region Getter and Setter in PictureBox and Labels

        private Image _product;
        private string _name;
        private double _price;
        private int _quantity;
        private int _prodid;

        [Category("Custom Props")]
        public Image ProductImage
        {
            get { return _product; }
            set { _product = value; Productimg.Image = value; }
        }

        [Category("Custom Props")]
        public string ProdName
        {
            get { return _name; }
            set { _name = value; Namelbl.Text = value; }
        }
        [Category("Custom Props")]
        public int ProdID
        {
            get { return _prodid; }
            set { _prodid = value; ProdIDlbl.Text = "Product ID: " + value; }
        }

        [Category("Custom Props")]
        public double Price
        {
            get { return _price; }
            set { _price = value; Pricelbl.Text = "$" + value; }
        }

        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; Quantitylbl.Text = "Cantidad: " + value; }

        }

        #endregion
    }
}
