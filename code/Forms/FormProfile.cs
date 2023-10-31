using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

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

            FormLogin login = new FormLogin();
            if (!UserSession.IsLoggedIn)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // User user = login.User;
                    // I think User class can hold properties like Name, Email, Password, and probably BoughtListings and AddedListings
                    this.formTitle.Text = "Привіт, " + UserSession.CurrentUser.Name + "!";
                    UserSession.IsLoggedIn = true;
                }
                else
                {
                    OpenChildForm(new FormProfileError());
                }
            }

            txtUsername.Text = UserSession.CurrentUser.Name;
            txtEmail.Text = UserSession.CurrentUser.Email;
            txtPassword.Text = UserSession.CurrentUser.Password;
            txtPassword.PasswordChar = '*';

            var headingFont = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            Padding cellPadding = new Padding(5, 5, 5, 5);

            dataGridViewBoughtListings.DataSource = UserSession.CurrentUser.BoughtListings;
            dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle.Font = headingFont;
            dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle.Padding = cellPadding;
            foreach (DataGridViewColumn column in dataGridViewBoughtListings.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }

            dataGridViewAddedListings.DataSource = UserSession.CurrentUser.AddedListings;
            dataGridViewAddedListings.ColumnHeadersDefaultCellStyle.Font = headingFont;
            dataGridViewAddedListings.ColumnHeadersDefaultCellStyle.Padding = cellPadding;
            foreach (DataGridViewColumn column in dataGridViewAddedListings.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }
        }

        private void OpenChildForm(Form newForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            this.pnlMainContainer.Controls.Add(newForm);
            this.pnlMainContainer.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var newUsername = txtUsername.Text;
            var newPassword = txtPassword.Text;
            var newEmail = txtEmail.Text;
            var currentUsername = UserSession.CurrentUser.Name;
            var currentPassword = UserSession.CurrentUser.Password;
            var currentEmail = UserSession.CurrentUser.Email;

            if (newUsername == currentUsername && newPassword == currentPassword && newEmail == currentEmail)
            {
                MessageBox.Show("Ваші облікові дані не були оновлені, бо ви не внесли жодних змін.", "Внесіть зміни і спробуйте ще раз");
            }
            else if (!string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(newEmail))
            {
                DialogResult confirmResult = MessageBox.Show("Ви впевнені що хочете змінити свої облікові дані?", "Підтвердження зміни", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    UserSession.CurrentUser.Name = newUsername;
                    UserSession.CurrentUser.Password = newPassword;
                    UserSession.CurrentUser.Email = newEmail;

                    MessageBox.Show("Ваші облікові дані були успішно оновлено.", "Оновлено успішно");
                }
            }
        }
    }
}
