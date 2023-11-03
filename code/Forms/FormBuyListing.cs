using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using code.Classes;

namespace code.Forms
{
    public partial class FormBuyListing : Form
    {
        private readonly Advertisement listing;
        private readonly FormMarket formMarket;

        public FormBuyListing(Advertisement listing, FormMarket formMarket)
        {
            InitializeComponent();
            this.formMarket = formMarket;
            this.listing = listing;
            this.Text = listing.Name;
            this.lblName.Text = listing.Name;
            this.lblDescription.Text = listing.Description;
            this.lblAddress.Text = listing.Address;
            this.lblPrice.Text = $"{listing.Price} ₴ або {listing.Price * getDollarRate()} гривень";
            this.lblSeller.Text = listing.Seller;
        }
        private double getDollarRate()
        {
            string link = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange";
            WebClient wc = new WebClient();
            string xmlString = wc.DownloadString(link);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            XmlNode usdNode = xmlDoc.SelectSingleNode("//currency[cc='USD']");
            XmlNode rateNode = usdNode.SelectSingleNode("rate");
            string usdRate = rateNode.InnerText;
            double rate = Convert.ToDouble(usdRate, CultureInfo.InvariantCulture);
            return rate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (LoginManager.IsLoggedIn)
            {
                if (LoginManager.CurrentUser.Name == listing.Seller)
                {
                    MessageBox.Show("Ви не можете купувати свою нерухомість.", "Помилка придбання об'єкту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoginManager.CurrentUser.BoughtListings.Add(listing);
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
