using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code.Forms
{
    public partial class ListingForm : Form
    {
        private readonly Listing listing;

        public ListingForm(Listing listing)
        {
            InitializeComponent();
            this.listing = listing;
            this.Text = listing.Name;
            this.lblName.Text = listing.Name;
            this.lblDescription.Text = listing.Description;
            this.lblAddress.Text = listing.Address;
            this.lblPrice.Text = $"{listing.Price} ₴";
            this.lblSeller.Text = listing.Seller;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // TODO: Implement buying mechanism by removing the listing from the database
            Close();
        }
    }
}
