using System;
using System.Drawing;
using System.Windows.Forms;
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
                string truncatedDescription = listing.Description.Length > 60 ? listing.Description.Substring(0, 57) + "..." : listing.Description;
                this.lblDescription.Text = truncatedDescription;
                this.toolTipDescription.SetToolTip(this.lblDescription, listing.Description);
                this.lblAddress.Text = $"{listing.Address} (натисніть щоб перейти на мапу)";
                this.lblPrice.Text = $"${listing.Price} або {listing.Price * Classes.AlgorithmManager.СurrencyСonverter.GetDollarRate()} ₴";
                this.lblSeller.Text = listing.Seller;
                this.pictureBoxListingImage.Image = Image.FromFile(listing.ImagePath);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити деталі оголошення. Спробуйте пізніше", "Помилка завантаження даних");
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

        private void lblAddress_Click(object sender, EventArgs e)
        {
            Classes.AlgorithmManager.ShowMap.GoToMap(listing.Address);
        }
    }
}
