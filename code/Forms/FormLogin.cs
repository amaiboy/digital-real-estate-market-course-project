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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static int LoginAttempts = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errors.Add("Ім'я користувача або пароль не можуть бути порожніми.");
            }

            if (username.Length < 3 || username.Length > 16)
            {
                errors.Add("Ім'я користувача має містити від 3 до 16 символів.");
            }

            if (password.Length < 8)
            {
                errors.Add("Пароль має містити від 8 до 16 символів.");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginAttempts++;

                if (LoginAttempts >= 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }

                return;
            }

            this.DialogResult = DialogResult.OK;
            UserSession.CurrentUser.Name = username;
            UserSession.CurrentUser.Password = password;
            UserSession.CurrentUser.Email = "undefined@undefined.com";
            UserSession.IsLoggedIn = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp();
            this.Hide();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                var username = signUpForm.Username;
                var password = signUpForm.Password;
                var email = signUpForm.Email;

                UserSession.CurrentUser.Name = username;
                UserSession.CurrentUser.Password = password;
                UserSession.CurrentUser.Email = email;
                UserSession.IsLoggedIn = true;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
