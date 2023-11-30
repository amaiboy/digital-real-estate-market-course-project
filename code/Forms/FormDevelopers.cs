using System;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormDevelopers : Form
    {
        public FormDevelopers()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void styledButtonGithubLink_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/amaiboy/digital-real-estate-market-course-project");
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити сторінку в браузері. Спробуйте ще раз пізніше", "Помилка відкриття");
            }
        }

        private void styledButtonLicense_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/amaiboy/digital-real-estate-market-course-project/blob/main/LICENSE");
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити сторінку в браузері. Спробуйте ще раз пізніше", "Помилка відкриття");
            }
        }
    }
}
