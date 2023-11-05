using code.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

            txtPassword.PasswordChar = '*';
        }

        public static int LoginAttempts = 0;

        public User ValidateLogin(string username, string password)
        {
            try
            {
                return GlobalData.Users.FirstOrDefault(user => user.Name == username && user.Password == password);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося авторизуватися. Спробуйте ще раз пізніше", "Помилка авторизації");
                return null;
            }
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
                ExceptionManager.HandleException(new Exception(string.Join("\n", errors)), string.Join("\n", errors), "Помилка авторизації");
                LoginAttempts++;

                if (LoginAttempts >= 3)
                {
                    ExceptionManager.ShowInfo("Ви зробили надто багато невдалих спроб входу за короткий час. Спробуйте пізніше.", "Помилка входу");
                    this.DialogResult = DialogResult.Cancel;
                }

                return;
            }

            try
            {
                var user = ValidateLogin(username, password);

                if (user == null)
                {
                    ExceptionManager.HandleException(new Exception("Невірний логін або пароль."), "Невірний логін або пароль.", "Помилка авторизації");
                    LoginAttempts++;

                    return;
                }

                this.DialogResult = DialogResult.OK;
                LoginManager.CurrentUser = user;
                GlobalData.AvailableListings.AddRange(user.AddedListings);
                LoginManager.IsLoggedIn = true;

                ExceptionManager.ShowInfo($"Ви успішно увійшли! З поверненням, {user.Name}", "Успішний вхід");
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Виникла помилка під час входу", "Помилка входу");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
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
                    ExceptionManager.ShowInfo($"Ви успішно зареєструвалися! Ласкаво просимо, {user.Name}", "Успішна реєстрація");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Виникла помилка під час реєстрації", "Помилка реєстрації");
            }
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
    }
}
