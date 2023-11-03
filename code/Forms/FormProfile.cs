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
using code.Classes;

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
            if (!LoginManager.IsLoggedIn)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    LoginManager.IsLoggedIn = true;
                }
                else
                {
                    OpenChildForm(new FormProfileError());
                }
            }

            txtUsername.Text = LoginManager.CurrentUser.Name;
            txtEmail.Text = LoginManager.CurrentUser.Email;
            txtPassword.Text = LoginManager.CurrentUser.Password;
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
            var currentUsername = LoginManager.CurrentUser.Name;
            var currentPassword = LoginManager.CurrentUser.Password;
            var currentEmail = LoginManager.CurrentUser.Email;

            if (newUsername == currentUsername && newPassword == currentPassword && newEmail == currentEmail)
            {
                MessageBox.Show("Ваші облікові дані не були оновлені, бо ви не внесли жодних змін.", "Внесіть зміни і спробуйте ще раз");
            }
            else if (!string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(newEmail))
            {
                DialogResult confirmResult = MessageBox.Show("Ви впевнені що хочете змінити свої облікові дані?", "Підтвердження зміни", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    LoginManager.CurrentUser.Name = newUsername;
                    LoginManager.CurrentUser.Password = newPassword;
                    LoginManager.CurrentUser.Email = newEmail;

                    MessageBox.Show("Ваші облікові дані були успішно оновлено.", "Оновлено успішно");
                }
            }
        }

        private void btnRefreshBoughtListings_Click(object sender, EventArgs e)
        {
            dataGridViewBoughtListings.DataSource = null;
            dataGridViewBoughtListings.DataSource = LoginManager.CurrentUser.BoughtListings;

            if (dataGridViewBoughtListings.Rows.Count != 0)
            {
                lblEmptyBoughtListings.Visible = false;
            }
        }

        private void btnClearBoughtListings_Click(object sender, EventArgs e)
        {
            dataGridViewBoughtListings.DataSource = null;
            LoginManager.CurrentUser.BoughtListings.Clear();
            dataGridViewBoughtListings.DataSource = LoginManager.CurrentUser.BoughtListings;

            lblEmptyBoughtListings.Visible = true;
        }

        private void dataGridViewBoughtListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedListing = (Advertisement)dataGridViewBoughtListings.SelectedRows[0].DataBoundItem;
            FormBoughtListing listingForm = new FormBoughtListing(selectedListing);
            listingForm.ShowDialog();
        }

        private void dataGridViewAddedListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedListing = (Advertisement)dataGridViewAddedListings.SelectedRows[0].DataBoundItem;
            FormAddedListing listingForm = new FormAddedListing(selectedListing);
            listingForm.ShowDialog();
        }

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            FormAddListing formAddListing = new FormAddListing();
            formAddListing.ShowDialog();
        }
    }
}
