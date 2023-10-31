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
    public partial class FormBoughtListing : Form
    {
        public FormBoughtListing(Listing listing)
        {
            InitializeComponent();

            lblName.Text = listing.Name;
            lblSeller.Text = $"Куплено від: {listing.Seller}";
            lblDescription.Text = listing.Description;
            lblAddress.Text = listing.Address;
            lblPrice.Text = $"{listing.Price} ₴";
            lblOwner.Text = $"Власник: {UserSession.CurrentUser.Name}";
        }
    }
}
