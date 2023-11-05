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

            try
            {
                this.formMarket = formMarket;
                this.listing = listing;
                this.Text = listing.Name;
                this.lblName.Text = listing.Name;
                this.lblDescription.Text = listing.Description;
                this.lblAddress.Text = listing.Address;
                this.lblPrice.Text = $"${listing.Price} або {listing.Price * getDollarRate()} ₴";
                this.lblSeller.Text = listing.Seller;
                this.pictureBoxListingImage.Image = Image.FromFile(listing.ImagePath);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити деталі оголошення. Спробуйте пізніше", "Помилка завантаження даних");
            }
        }

        private double getDollarRate()
        {
            try
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
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося отримати курс долара. Спробуйте пізніше", "Помилка отримання курсу");
                return 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginManager.IsLoggedIn)
                {
                    if (LoginManager.CurrentUser.Name == listing.Seller)
                    {
                        ExceptionManager.HandleException(new Exception("Неможливо купити свою власну нерухомість."), "Ви не можете купувати свою нерухомість.", "Помилка купівлі");
                        return;
                    }
                    LoginManager.CurrentUser.BoughtListings.Add(listing);
                    formMarket.RemoveListing(listing);
                }
                else
                {
                    ExceptionManager.HandleException(new Exception("Авторизуйтесь перш ніж купувати нерухомість."), "Ви повинні авторизуватися, щоб купити нерухомість. Будь ласка, увійдіть у свій акаунт і спробуйте ще раз", "Помилка купівлі");
                    return;
                }
                Close();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося купити нерухомість. Спробуйте пізніше", "Помилка купівлі");
            }
        }
    }
}
