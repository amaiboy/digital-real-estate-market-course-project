using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using code.Classes;
using System.IO;

namespace code.Forms
{
    public partial class FormProfile : Form
    {
        private Form activeForm = null;

        public FormProfile()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.activeForm = this;

            txtUsername.Text = LoginManager.CurrentUser.Name;
            txtEmail.Text = LoginManager.CurrentUser.Email;
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            formTitle.Text = $"Профіль користувача {LoginManager.CurrentUser.Name}";

            var headingFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            Padding cellPadding = new Padding(5, 5, 5, 5);

            dataGridViewBoughtListings.DataSource = LoginManager.CurrentUser.BoughtListings;
            dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle.Font = headingFont;
            dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle.Padding = cellPadding;
            foreach (DataGridViewColumn column in dataGridViewBoughtListings.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }

            dataGridViewAddedListings.DataSource = LoginManager.CurrentUser.AddedListings;
            dataGridViewAddedListings.ColumnHeadersDefaultCellStyle.Font = headingFont;
            dataGridViewAddedListings.ColumnHeadersDefaultCellStyle.Padding = cellPadding;
            foreach (DataGridViewColumn column in dataGridViewAddedListings.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }

            if (dataGridViewBoughtListings.Rows.Count != 0)
            {
                lblEmptyBoughtListings.Visible = false;
            }
            if (dataGridViewAddedListings.Rows.Count != 0)
            {
                lblEmptyAddedListings.Visible = false;
            }
        }

        public void UpdateEmptyLabels(object sender, EventArgs e)
        {
            if (dataGridViewBoughtListings.Rows.Count != 0)
            {
                lblEmptyBoughtListings.Visible = false;
            }
            else
            {
                lblEmptyBoughtListings.Visible = true;
            }

            if (dataGridViewAddedListings.Rows.Count != 0)
            {
                lblEmptyAddedListings.Visible = false;
            }
            else
            {
                lblEmptyAddedListings.Visible = true;
            }
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnTogglePasswordVisibility.Text = "Приховати пароль";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnTogglePasswordVisibility.Text = "Показати пароль";
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var newUsername = txtUsername.Text;
            var newPassword = txtPassword.Text;
            var newEmail = txtEmail.Text;
            var currentUsername = LoginManager.CurrentUser.Name;
            var currentPassword = LoginManager.CurrentUser.Password;
            var currentEmail = LoginManager.CurrentUser.Email;

            if (newUsername == currentUsername && newEmail == currentEmail && newPassword.Length == 0)
            {
                ExceptionManager.ShowInfo("Ви не внесли жодних змін.", "Внесіть зміни і спробуйте ще раз");
            }
            else if (!string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newEmail))
            {
                bool isConfirmed = ExceptionManager.Confirm("Ви впевнені що хочете змінити свої облікові дані?", "Підтвердження зміни");
                List<string> errors = new List<string>();
                if (isConfirmed)
                {
                    if (newUsername != LoginManager.CurrentUser.Name)
                    {
                        foreach (var user in GlobalData.Users)
                        {
                            if (user.Name == newUsername)
                            {
                                errors.Add("Таке ім'я користувача вже існує.");
                                break;
                            }
                        }
                    }
                    if (newEmail != LoginManager.CurrentUser.Email)
                    {
                        foreach (var user in GlobalData.Users)
                        {
                            if (user.Email == newEmail)
                            {
                                errors.Add("Така пошта вже використовується.");
                                break;
                            }
                        }
                    }
                    if (newPassword.Length != 0 && LoginManager.hashPassword(newPassword) == LoginManager.CurrentUser.Password)
                    {
                        errors.Add("Пароль має бути різним.");
                    }
                    if (newUsername.Length < 3 || newUsername.Length > 16)
                    {
                        errors.Add("Ім'я користувача має містити від 3 до 16 символів.");
                    }
                    if (newPassword.Length != 0 && newPassword.Length < 8)
                    {
                        errors.Add("Пароль повинен мати довжину не менше 8 символів.");
                    }

                    if (newEmail != LoginManager.CurrentUser.Email)
                    {
                        try
                        {
                            if (!string.IsNullOrWhiteSpace(newEmail) && newEmail != LoginManager.CurrentUser.Email)
                            {
                                var validEmail = new System.Net.Mail.MailAddress(newEmail);
                            }
                            else
                            {
                                throw new FormatException();
                            }
                        }
                        catch (FormatException)
                        {
                            errors.Add("Електронна пошта не дійсна.");
                        }
                    }

                    if (errors.Count == 0)
                    {
                        try
                        {
                            string verificationCode = LoginManager.generateVerificationCode();
                            Console.WriteLine(verificationCode);
                            _ = LoginManager.sendVerificationCodeToEmail(newEmail, verificationCode);

                            FormCodeConfirmation InputForm = new FormCodeConfirmation();
                            DialogResult result = InputForm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                string userEnteredVerificationCode = InputForm.getVerifyCode();
                                if (userEnteredVerificationCode == verificationCode)
                                {

                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception)
                        {
                            errors.Add("Електронна пошта не веріфікована.");
                        }
                    }

                    if (errors.Count > 0)
                    {
                        ExceptionManager.HandleException(new Exception(string.Join("\n", errors)), string.Join("\n", errors), "Помилка реєстрації");
                        return;
                    }

                    if (LoginManager.CurrentUser.Name != newUsername)
                    {
                        for (int i = 0; i < LoginManager.CurrentUser.AddedListings.Count; i++)
                        {
                            LoginManager.CurrentUser.AddedListings[i].Seller = newUsername;
                        }

                        foreach (var ad in GlobalData.AvailableListings)
                        {
                            if (ad.Seller == LoginManager.CurrentUser.Name)
                            {
                                ad.Seller = newUsername;
                            }
                        }

                        LoginManager.CurrentUser.Name = newUsername;
                    }
                    if (newPassword.Length != 0)
                    {
                        LoginManager.CurrentUser.Password = LoginManager.hashPassword(newPassword);
                    }
                    LoginManager.CurrentUser.Email = newEmail;
                    txtPassword.Text = "";
                    ExceptionManager.ShowInfo("Ви успішно змінили свої облікові дані!", "Зміни внесено успішно");
                }
            }
        }

        private void btnRefreshBoughtListings_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBoughtListings.DataSource = null;
                dataGridViewBoughtListings.DataSource = LoginManager.CurrentUser.BoughtListings;

                if (dataGridViewBoughtListings.Rows.Count != 0)
                {
                    lblEmptyBoughtListings.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося оновити список куплених оголошень. Спробуйте ще раз пізніше", "Помилка оновлення списку оголошень");
            }
        }

        private void btnClearBoughtListings_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBoughtListings.DataSource = null;
                LoginManager.CurrentUser.BoughtListings.Clear();
                dataGridViewBoughtListings.DataSource = LoginManager.CurrentUser.BoughtListings;

                lblEmptyBoughtListings.Visible = true;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося очистити список куплених оголошень. Спробуйте ще раз пізніше", "Помилка очищення списку оголошень");
            }
        }

        private void dataGridViewBoughtListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedListing = (Advertisement)dataGridViewBoughtListings.SelectedRows[0].DataBoundItem;
                FormBoughtListing listingForm = new FormBoughtListing(selectedListing);
                listingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте ще раз пізніше", "Помилка відкриття форми");
            }
        }

        private void dataGridViewAddedListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedListing = (Advertisement)dataGridViewAddedListings.SelectedRows[0].DataBoundItem;
                FormAddedListing listingForm = new FormAddedListing(selectedListing);
                listingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте ще раз пізніше", "Помилка відкриття форми");
            }
        }

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddListing formAddListing = new FormAddListing();
                formAddListing.ShowDialog();
                if (formAddListing.DialogResult == DialogResult.OK)
                {
                    UpdateEmptyLabels(sender, e);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте ще раз пізніше", "Помилка відкриття форми");
            }
        }

        static void RemoveElement(BindingList<Advertisement> list, Advertisement elementToRemove)
        {
            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == elementToRemove.Name && list[i].Description == elementToRemove.Description && list[i].Price == elementToRemove.Price && list[i].Address == elementToRemove.Address && list[i].Seller == elementToRemove.Seller && list[i].ImagePath == elementToRemove.ImagePath)
                {
                    index = i;
                    break;
                }
            }

            // If the element is found, remove it
            if (index != -1)
            {
                list.RemoveAt(index);
            }
        }

        private void deleteAdvertismentButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isConfirmed = ExceptionManager.Confirm("Ви впевнені що хочете видалити це оголошення?", "Підтвердження видалення");
                if (dataGridViewAddedListings.SelectedRows.Count > 0 && isConfirmed)
                {
                    var selectedListing = dataGridViewAddedListings.SelectedRows[0];
                    var selectedListingAdvertisment = (Advertisement)selectedListing.DataBoundItem; // Исправлено здесь
                    dataGridViewAddedListings.Rows.Remove(selectedListing);

                    // видалення з глобальної колекції
                    //GlobalData.AvailableListings.Remove(selectedListingAdvertisment);
                    RemoveElement(GlobalData.AvailableListings, selectedListingAdvertisment);

                    //Видалення фото с каталогу
                    File.Delete(selectedListingAdvertisment.ImagePath);

                    // видалення з колекції поточного користувача
                    LoginManager.CurrentUser.AddedListings.Remove(selectedListingAdvertisment);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося видалити оголошення. Спробуйте пізніше", "Помилка видалення");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            bool isConfirmed = ExceptionManager.Confirm("Ви впевнені що хочете вийти?", "Підтвердження виходу");
            try
            {
                if (isConfirmed)
                {
                    LoginManager.IsLoggedIn = false;
                    this.Close();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося вийти.", "Помилка виходу");
            }
        }
    }
}
