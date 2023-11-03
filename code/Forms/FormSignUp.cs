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
using code.Classes;

namespace code.Forms
{
    public partial class FormSignUp : Form
    {
        public string Username
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
        }

        public bool DoesUsernameExist(string username)
        {
            return GlobalData.Users.Any(user => user.Name == username);
        }

        public bool DoesEmailExist(string email)
        {
            return GlobalData.Users.Any(user => user.Email == email);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var email = txtEmail.Text;

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                errors.Add("Ім'я користувача, пароль або електронна пошта не можуть бути порожніми.");
            }

            if (DoesUsernameExist(username))
            {
                errors.Add("Ім'я користувача вже існує.");
            }

            if (DoesEmailExist(email))
            {
                errors.Add("Електронна пошта вже існує.");
                // TODO: Add account recovery ability by email
            }


            if (username.Length < 3 || username.Length > 16)
            {
                errors.Add("Ім'я користувача має містити від 3 до 16 символів.");
            }

            if (password.Length < 8)
            {
                errors.Add("Пароль повинен мати довжину не менше 8 символів.");
            }

            try
            {
                // TODO: Add email verification
                var validEmail = new System.Net.Mail.MailAddress(email);
            }
            catch (FormatException)
            {
                errors.Add("Електронна пошта не дійсна.");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.DialogResult = DialogResult.OK;
        }
    }
}
