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
    }
}
