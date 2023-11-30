using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using code.Classes;

namespace code
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        BindingList<Advertisement> predefinedListings = new BindingList<Advertisement>();
        List<User> users = new List<User>();

        public FormMenu()
        {
            predefinedListings = FileHandler.readAdFromCSV();
            users = FileHandler.UserFileReader();
            InitializeComponent();
            OpenChildForm(new Forms.FormWelcome(), null);

            try
            {
                LoginManager.CurrentUser = new User();
                LoginManager.IsLoggedIn = false;
                GlobalData.AvailableListings = predefinedListings;
                GlobalData.Users = users;
                var imageFiles = Directory.GetFiles(@"../../../assets/images/real-estate-pictures/", "*.jpg");
                SetImagesForListings(predefinedListings, imageFiles);

                foreach (var user in users)
                {
                    SetImagesForListings(user.BoughtListings, imageFiles);
                    SetImagesForListings(user.AddedListings, imageFiles);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити дані. Спробуйте пізніше", "Помилка завантаження даних");
            }
        }

        // Метод для синхронізації шляхів до фото
        private void SetImagesForListings(BindingList<Advertisement> listings, string[] imageFiles)
        {
            for (int i = 0; i < listings.Count; i++)
            {
                for (int j = 0; j < imageFiles.Length; j++)
                {
                    if (@"../../../assets/images/real-estate-pictures/" + listings[i].Name + ".jpg" == imageFiles[j])
                    {
                        var ad = listings[i];
                        ad.ImagePath = imageFiles[j];
                    }
                }

            }
        }

        private void ActivateButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = Color.FromArgb(64, 64, 100);
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося активувати кнопку. Спробуйте пізніше", "Помилка активації");
            }
        }

        private void DisableButton()
        {
            try
            {
                foreach (Control control in panelMenu.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.FromArgb(51, 51, 76);
                        button.ForeColor = Color.Gainsboro;
                        button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося деактивувати кнопку. Спробуйте пізніше", "Помилка деактивації");
            }
        }

        private void OpenChildForm(Form newForm, object buttonSender)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }

                ActivateButton(buttonSender);
                activeForm = newForm;
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;
                this.panelFormContainer.Controls.Add(newForm);
                this.panelFormContainer.Tag = newForm;
                newForm.BringToFront();
                newForm.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте пізніше", "Помилка відкриття");
            }
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMarket(), sender);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDevelopers(), sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.FormLogin login = new Forms.FormLogin();
                if (!LoginManager.IsLoggedIn)
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        LoginManager.IsLoggedIn = true;
                        OpenChildForm(new Forms.FormProfile(), sender);
                    }
                    else
                    {
                        OpenChildForm(new Forms.FormWelcome(), sender);
                        return;
                    }
                }
                else
                {
                    OpenChildForm(new Forms.FormProfile(), sender);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося авторизуватися. Спробуйте ще раз пізніше", "Помилка авторизації");
            }
        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWelcome(), sender);
        }
    }
}
