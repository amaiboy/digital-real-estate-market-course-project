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

            txtPassword.PasswordChar = '*';
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
                // TODO: Possibly add email verification
                var validEmail = new System.Net.Mail.MailAddress(email);
            }
            catch (FormatException)
            {
                errors.Add("Електронна пошта не дійсна.");
            }

            if (errors.Count > 0)
            {
                ExceptionManager.HandleException(new Exception(string.Join("\n", errors)), string.Join("\n", errors), "Помилка реєстрації");
                return;
            }

            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.DialogResult = DialogResult.OK;
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                    btnTogglePasswordVisibility.Text = "0_0";
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    btnTogglePasswordVisibility.Text = ">_<";
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Виникла помилка при перемиканні видимості пароля", "Помилка видимості пароля");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
