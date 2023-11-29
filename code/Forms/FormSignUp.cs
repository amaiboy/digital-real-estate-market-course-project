using System;
using System.Collections.Generic;
using System.Linq;
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
            txtPasswordConfirm.PasswordChar = '*';
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
            var passwordConfirm = txtPasswordConfirm.Text;
            var email = txtEmail.Text;

            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(passwordConfirm))
            {
                errors.Add("Ім'я користувача, пароль, підтвердження паролю або електронна пошта не можуть бути порожніми.");
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
            if (password != passwordConfirm)
            {
                errors.Add("Пароль не співпадає з підтвердженням паролю.");
            }

            try
            {
                if (!string.IsNullOrWhiteSpace(email))
                {
                    var validEmail = new System.Net.Mail.MailAddress(email);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                errors.Add("Електронна пошта не дійсна.");
            }

            if (errors.Count == 0)
            {
                try
                {
                    string verificationCode = LoginManager.generateVerificationCode();
                    Console.WriteLine(verificationCode);
                    _ = LoginManager.sendVerificationCodeToEmail(email, verificationCode);

                    FormCodeConfirmation InputForm = new FormCodeConfirmation();
                    DialogResult result = InputForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string userEnteredVerificationCode = InputForm.getVerifyCode();
                        if (userEnteredVerificationCode == verificationCode)
                        {

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    errors.Add("Електронна пошта не веріфікована.");
                }
            }

            if (errors.Count > 0)
            {
                ExceptionManager.HandleException(new Exception(string.Join("\n", errors)), string.Join("\n", errors), "Помилка реєстрації");
                return;
            }

            this.Username = username;
            this.Password = LoginManager.hashPassword(password);
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

        private void btnTogglePasswordConfirmVisibility_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPasswordConfirm.PasswordChar == '*')
                {
                    txtPasswordConfirm.PasswordChar = '\0';
                    btnTogglePasswordConfirmVisibility.Text = "0_0";
                }
                else
                {
                    txtPasswordConfirm.PasswordChar = '*';
                    btnTogglePasswordConfirmVisibility.Text = ">_<";
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Виникла помилка при перемиканні видимості підтвердження пароля", "Помилка видимості підтвердження пароля");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
