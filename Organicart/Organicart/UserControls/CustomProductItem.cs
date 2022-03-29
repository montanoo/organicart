using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Organicart
{
    public partial class CustomProductItem : UserControl
    {
        public static Control Control;
        public CustomProductItem()
        {
            InitializeComponent();

        }
        #region Getter and Setter in PictureBox and Labels

        private Image _product;
        private string _productName;
        private double _price;


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


        #endregion

        private void btnAddToCart_Click(object sender, System.EventArgs e)
        {

        }

        private void CustomProductItem_Click(object sender, System.EventArgs e)
        {
            Control = (Control)sender;   // Sender gives you which control is clicked.
            MessageBox.Show(Control.TabIndex.ToString());
        }
    }
}
