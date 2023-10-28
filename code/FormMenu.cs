using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMenu()
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormWelcome(), null);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(64, 64, 100);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void OpenChildForm(Form newForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(buttonSender);
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            this.panelFormContainer.Controls.Add(newForm);
            this.panelFormContainer.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMarket(), sender);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDevelopers(), sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProfile(), sender);
        }
    }
}
