using code.Classes;
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
    public partial class FormAddListing : Form
    {
        public FormAddListing()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                numericUpDownPrice.Value == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля і переконайтеся, що ціна не дорівнює нулю", "Валідація полів");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Ви впевнені що хочете додати це оголошення?", "Підтвердження додавання", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Advertisement listing = new Advertisement
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Address = txtAddress.Text,
                    Price = Convert.ToInt32(numericUpDownPrice.Value),
                    Seller = LoginManager.CurrentUser.Name
                };
                GlobalData.AvailableListings.Add(listing);
                LoginManager.CurrentUser.AddedListings.Add(listing);

                Close();
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            var characterCount = txtDescription.Text.Length;
            lblDescriptionCharactersCount.Text = characterCount.ToString();

            if (characterCount == 250)
            {
                lblDescriptionCharactersCount.ForeColor = Color.FromArgb(97, 9, 9);
            }
            else if (characterCount > 230)
            {
                lblDescriptionCharactersCount.ForeColor = Color.FromArgb(144, 14, 14);
            }
            else
            {
                lblDescriptionCharactersCount.ForeColor = Color.Black;
            }
        }
    }
}
