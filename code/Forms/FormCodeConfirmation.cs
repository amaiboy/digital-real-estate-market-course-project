using System;
using System.Windows.Forms;

namespace code.Forms
{
    public partial class FormCodeConfirmation : Form
    {
        public FormCodeConfirmation()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string getVerifyCode()
        {
            return inputTextBox.Text;
        }
    }
}
