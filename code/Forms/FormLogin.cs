using code.Classes;
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

        public User ValidateLogin(string username, string password)
        {
            return GlobalData.Users.FirstOrDefault(user => user.Name == username && user.Password == password);
        }

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

            var user = ValidateLogin(username, password);

            if (user == null)
            {
                MessageBox.Show("Невірний логін або пароль.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginAttempts++;
                if (LoginAttempts >= 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }

                return;
            }

            this.DialogResult = DialogResult.OK;
            LoginManager.CurrentUser = user;
            GlobalData.AvailableListings.AddRange(user.AddedListings);
            LoginManager.IsLoggedIn = true;
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

                User user = new User(username, email, password);
                GlobalData.Users.Add(user);

                LoginManager.CurrentUser = user;
                LoginManager.IsLoggedIn = true;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
