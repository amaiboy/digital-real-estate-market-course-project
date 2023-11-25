using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Forms;
using code.Classes;
using System.Configuration;

namespace code
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        BindingList<Advertisement> predefinedListings = new BindingList<Advertisement>();
        List <User> users = new List<User>();

        public FormMenu()
        {
            predefinedListings = FileHandler.readAdFromCSV();
            users = FileHandler.UserFileReader();
            // Initialize the form components
            InitializeComponent();

            // Open the welcome form as the first form
            OpenChildForm(new Forms.FormWelcome(), null);

            try
            {
                // Set the current user to a new User object
                LoginManager.CurrentUser = new User();

                // Set the login status to false
                LoginManager.IsLoggedIn = false;

                // Set the available listings to the predefined listings
                GlobalData.AvailableListings = predefinedListings;

                // Set the users to the predefined users list
                GlobalData.Users = users;

                // Get the image files from the specified directory
                var imageFiles = Directory.GetFiles(@"../../../assets/images/real-estate-pictures/", "*.jpg");
                // Create a new random object
                var random = new Random();

                // Set random image paths for each predefined listing
                foreach (var ad in predefinedListings)
                {
                    ad.ImagePath = GetRandomImagePath(imageFiles, random);
                }

                // Set random images for each user's bought and added listings
                foreach (var user in users)
                {
                    SetRandomImagesForListings(user.BoughtListings, imageFiles, random);
                    SetRandomImagesForListings(user.AddedListings, imageFiles, random);
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, handle it and display an error message
                ExceptionManager.HandleException(ex, "Не вдалося завантажити дані. Спробуйте пізніше", "Помилка завантаження даних");
            }
        }

        private string GetRandomImagePath(string[] imageFiles, Random random)
        {
            // Get a random index between 0 and the length of the array
            int randomIndex = random.Next(imageFiles.Length);

            // Get the element at the random index
            string randomImageFile = imageFiles[randomIndex];

            // Return the random image file path
            return randomImageFile;
        }

        private void SetRandomImagesForListings(BindingList<Advertisement> listings, string[] imageFiles, Random random)
        {
            // Iterate through each advertisement in the list
            foreach (var ad in listings)
            {
                // Set a random image path for the advertisement
                ad.ImagePath = GetRandomImagePath(imageFiles, random);
            }
        }

        private void ActivateButton(object btnSender)
        {
            try
            {
                // Check if btnSender is not null
                if (btnSender != null)
                {
                    // Check if currentButton is not the same as btnSender
                    if (currentButton != (Button)btnSender)
                    {
                        // Disable the currentButton
                        DisableButton();

                        // Set the currentButton to btnSender
                        currentButton = (Button)btnSender;

                        // Set the background color of currentButton to a lighter color
                        currentButton.BackColor = Color.FromArgb(64, 64, 100);

                        // Set the foreground color of currentButton to white
                        currentButton.ForeColor = Color.White;

                        // Set the font of currentButton to a larger font
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                ExceptionManager.HandleException(ex, "Не вдалося активувати кнопку. Спробуйте пізніше", "Помилка активації");
            }
        }

        private void DisableButton()
        {
            try
            {
                // Iterate through each control in the panelMenu
                foreach (Control control in panelMenu.Controls)
                {
                    // Check if the control is a Button
                    if (control is Button button)
                    {
                        // Set the background color of the button to a darker color
                        button.BackColor = Color.FromArgb(51, 51, 76);

                        // Set the foreground color (text color) of the button to a less noticeable color
                        button.ForeColor = Color.Gainsboro;

                        // Set the font of the button to a smaller font style and size
                        button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the button disabling process
                ExceptionManager.HandleException(ex, "Не вдалося деактивувати кнопку. Спробуйте пізніше", "Помилка деактивації");
            }
        }

        private void OpenChildForm(Form newForm, object buttonSender)
        {
            try
            {
                // Check if there is already an active form
                if (activeForm != null)
                {
                    // Close the active form
                    activeForm.Close();
                }

                // Activate the button that triggered the form opening
                ActivateButton(buttonSender);

                // Set the new form as the active form
                activeForm = newForm;

                // Configure the new form
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;

                // Add the new form to the panel that holds the forms
                this.panelFormContainer.Controls.Add(newForm);
                this.panelFormContainer.Tag = newForm;

                // Bring the new form to the front
                newForm.BringToFront();

                // Show the new form
                newForm.Show();
            }
            catch (Exception ex)
            {
                // Handle any exception that occurs during form opening
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте пізніше", "Помилка відкриття");
            }
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            // Open the new Market form in the panel container
            OpenChildForm(new Forms.FormMarket(), sender);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Open the new Help form in the panel container
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            // Open the new Developers form in the panel container
            OpenChildForm(new Forms.FormDevelopers(), sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            // Open the new Profile form in the panel container
            OpenChildForm(new Forms.FormProfile(), sender);
        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            // Open the new Welcome form in the panel container
            OpenChildForm(new Forms.FormWelcome(), sender);
        }
    }
}
