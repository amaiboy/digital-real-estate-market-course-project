using System;
using System.Drawing;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormAddedListing : Form
    {
        public FormAddedListing(Advertisement listing)
        {
            InitializeComponent();

            try
            {
                this.Text = listing.Name;
                lblName.Text = listing.Name;
                lblSeller.Text = $"Це ваше оголошення";
                string truncatedDescription = listing.Description.Length > 60 ? listing.Description.Substring(0, 57) + "..." : listing.Description;
                this.lblDescription.Text = truncatedDescription;
                this.toolTipDescription.SetToolTip(this.lblDescription, listing.Description);
                lblAddress.Text = listing.Address;
                lblPrice.Text = $"{listing.Price} ₴";
                lblDateLastViewed.Text = $"Останній раз переглянуто {DateTime.Now:dd.MM.yyyy}";
                pictureBoxListingImage.Image = Image.FromFile(listing.ImagePath);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити деталі оголошення. Спробуйде закрити розділ і повторити спробу", "Помилка завантаження даних");
            }
        }
    }
}
