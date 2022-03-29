using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Organicart
{
    public partial class CustomCartItem : UserControl
    {
        public static Control Control;
        public CustomCartItem()
        {
            InitializeComponent();
        }

        #region Getter and Setter in PictureBox and Labels

        private Image _product;
        private string _productName;
        private double _price;
        private decimal _quantity;

        [Category("Custom Props")]
        public Image ProductImage
        {
            get { return _product; }
            set { _product = value; Productimg.Image = value; }
        }

        [Category("Custom Props")]
        public string ProductNames
        {
            get { return _productName; }
            set { _productName = value; Productlbl.Text = value; }
        }

        [Category("Custom Props")]
        public double Price
        {
            get { return _price; }
            set { _price = value; Pricelbl.Text = "$" + value; }
        }

        [Category("Custom Props")]
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; Quantitynum.Value = value ; }
        }

        #endregion

        private void CustomCartItem_Click(object sender, System.EventArgs e)
        {
            Control = (Control)sender;   // Sender gives you which control is clicked.
            MessageBox.Show(Control.TabIndex.ToString());
        }
    }
}
