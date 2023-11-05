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
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    numericUpDownPrice.Value == 0)
                {
                    ExceptionManager.HandleException(new Exception("Заповніть всі поля"), "Будь ласка, заповніть всі поля і переконайтеся, що ціна не дорівнює нулю", "Валідація полів");
                    return;
                }

                bool isConfirmed = ExceptionManager.Confirm("Ви впевнені що хочете додати це оголошення?", "Підтвердження додавання");
                if (isConfirmed)
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
                    ExceptionManager.ShowInfo("Оголошення успішно додано", "Успіх");

                    Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося додати оголошення. Спробуйте пізніше", "Помилка додавання");
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося оновити кількість символів. Спробуйте пізніше", "Помилка перевірки довжини опису");
            }
        }
    }
}
