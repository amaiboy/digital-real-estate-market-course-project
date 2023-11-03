using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormBoughtListing : Form
    {
        public FormBoughtListing(Advertisement listing)
        {
            InitializeComponent();

            this.Text = listing.Name;
            lblName.Text = listing.Name;
            lblSeller.Text = $"Куплено від: {listing.Seller}";
            lblDescription.Text = listing.Description;
            lblAddress.Text = listing.Address;
            lblPrice.Text = $"{listing.Price} ₴";
            lblOwner.Text = $"Власник: {LoginManager.CurrentUser.Name}";
        }
    }
}
