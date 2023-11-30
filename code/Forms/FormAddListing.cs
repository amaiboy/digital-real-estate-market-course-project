using code.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace code.Forms
{
    public partial class FormAddListing : Form
    {
        private string selectedImagePath = string.Empty;
        private string destinationPath;
        private string destinationDirectory = @"../../../assets/images/real-estate-pictures";

        public FormAddListing()
        {
            InitializeComponent();

            lblImageName.Text = "Виберіть зображення";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    numericUpDownPrice.Value == 0 ||
                    fileDialogImageUpload.FileName == string.Empty)
                {
                    ExceptionManager.HandleException(new Exception("Заповніть всі поля"), "Будь ласка, заповніть всі поля і переконайтеся, що ціна не дорівнює нулю", "Валідація полів");
                    return;
                }

                bool isConfirmed = ExceptionManager.Confirm("Ви впевнені що хочете додати це оголошення?", "Підтвердження додавання");
                if (isConfirmed)
                {
                    destinationPath = destinationDirectory + "/" + txtName.Text + ".jpg";

                    Advertisement listing = new Advertisement
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Address = txtAddress.Text,
                        Price = Convert.ToInt32(numericUpDownPrice.Value),
                        Seller = LoginManager.CurrentUser.Name,
                        ImagePath = destinationPath
                    };
                    GlobalData.AvailableListings.Add(listing);
                    LoginManager.CurrentUser.AddedListings.Add(listing);
                    ExceptionManager.ShowInfo("Оголошення успішно додано", "Успіх");

                    DialogResult = DialogResult.OK;
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

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialogImageUpload = new OpenFileDialog();
                fileDialogImageUpload.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (fileDialogImageUpload.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = fileDialogImageUpload.FileName;

                    string fileName = Path.GetFileName(selectedImagePath);

                    int maxLength = 26;
                    if (fileName.Length > maxLength)
                    {
                        fileName = fileName.Substring(0, maxLength - 3) + "...";
                    }

                    lblImageName.Text = fileName;

                    string destinationDirectory = @"../../../assets/images/real-estate-pictures";
                    string newFileName = txtName.Text + ".jpg";
                    string destinationPath = Path.Combine(destinationDirectory, newFileName);
                    File.Copy(selectedImagePath, destinationPath, true);
                }
                else
                {
                    selectedImagePath = string.Empty;
                    lblImageName.Text = "Виберіть зображення";
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити фото. Спробуйте пізніше", "Помилка завантаження фото");
            }
        }
    }
}