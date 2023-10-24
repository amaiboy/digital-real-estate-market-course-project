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
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // TODO: Add exception handling for when the username already exists
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Add form validation. Check for username and password validity.
        }
    }
}
