using code.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

namespace code.Forms
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string email = inputEmail.Text;

            List<string> errors = new List<string>();

            bool isFinded = false;

            if (name.Length != 0 && email.Length != 0)
            {
                foreach (var user in GlobalData.Users)
                {
                    if (user.Email == email && user.Name == name)
                    {
                        isFinded = true;

                            try
                            {
                                string verificationCode = LoginManager.generateVerificationCode();
                                _ = LoginManager.sendVerificationCodeToEmail(email, verificationCode);

                                InputBox InputForm = new InputBox();
                                DialogResult result = InputForm.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    string userEnteredVerificationCode = InputForm.getVerifyCode();
                                    if (userEnteredVerificationCode == verificationCode)
                                    {
                                    System.Windows.MessageBox.Show("Тимчасовий пароль було вислано на вашу електронну пошту!", "Увага", MessageBoxButton.OK, MessageBoxImage.Information);
                                    string newPassword = LoginManager.generateNewPassword();
                                    user.Password = LoginManager.hashPassword(newPassword);
                                    _ = LoginManager.sendNewPasswordToEmail(email, newPassword);
                                    
                                    FormLogin login = new FormLogin();
                                    this.Hide();
                                    if (login.ShowDialog()== DialogResult.OK)
                                    {
                                        this.DialogResult = DialogResult.OK;
                                    }
                                    else
                                    {
                                        this.DialogResult = DialogResult.Cancel;
                                    }

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
                                errors.Add("Щоб змінити пароль, підтвердіть електронну пошту.");
                            }
                        break;
                    }
                }

                if (!isFinded)
                {
                    errors.Add("Користувача с такими даними не знайдено. Спробуйте ще раз.");
                }
            }
            else
            {
                errors.Add("Значення не можуть бути порожніми!");
            }

            if (errors.Count > 0)
            {
                ExceptionManager.HandleException(new Exception(string.Join("\n", errors)), string.Join("\n", errors), "Помилка реєстрації");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}