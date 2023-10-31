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

        public static int SignupAttempts = 0;

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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var email = txtEmail.Text;

            // TODO: Add better validation
            if (!string.IsNullOrEmpty(username) && password.Length >= 6 && !string.IsNullOrEmpty(email))
            {
                this.DialogResult = DialogResult.OK;
                this.Username = username;
                this.Password = password;
                this.Email = email;
            }
            else
            {
                MessageBox.Show("Введено невірний логін або пароль. Будь ласка, спробуйте ще раз", "Йой... Шось пішло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SignupAttempts++;

                if (SignupAttempts >= 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
