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
        public string Username
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        public static int LoginAttempts = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // TODO: Add better validation
            if (!string.IsNullOrEmpty(username) && password.Length >= 6)
            {
                this.DialogResult = DialogResult.OK;
                this.Username = username;
                this.Password = password;
                UserSession.IsLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Введено невірний логін або пароль. Будь ласка, спробуйте ще раз", "Йой... Шось пішло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginAttempts++;

                if (LoginAttempts >= 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp();
            this.Hide();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Username = signUpForm.Username;
                this.Password = signUpForm.Password;
                UserSession.IsLoggedIn = true;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
