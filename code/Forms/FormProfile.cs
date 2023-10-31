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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            FormLogin login = new FormLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                // User user = login.User;
                // I think User class can hold properties like Name, Email, Password, and probably BoughtListings and AddedListings
                this.formTitle.Text = "Привіт, " + login.Username;
            }
        }
    }
}
