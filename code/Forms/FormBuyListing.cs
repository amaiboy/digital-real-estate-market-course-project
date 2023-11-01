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
    public partial class FormBuyListing : Form
    {
        private readonly Listing listing;
        private readonly FormMarket formMarket;

        public FormBuyListing(Listing listing, FormMarket formMarket)
        {
            InitializeComponent();
            this.formMarket = formMarket;
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
            if (UserSession.IsLoggedIn)
            {
                if (UserSession.CurrentUser.Name == listing.Seller)
                {
                    MessageBox.Show("Ви не можете купувати свою нерухомість.", "Помилка придбання об'єкту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserSession.CurrentUser.BoughtListings.Add(listing);
                formMarket.RemoveListing(listing);
            }
            else
            {
                MessageBox.Show("Ви повинні авторизуватися, щоб купити нерухомість.", "Помилка придбання об'єкту", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
