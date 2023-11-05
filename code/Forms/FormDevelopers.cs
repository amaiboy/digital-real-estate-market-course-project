using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                System.Diagnostics.Process.Start("https://github.com/amaiboy/digital-real-estate-market-course-project/blob/dev/LICENSE");
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити сторінку в браузері. Спробуйте ще раз пізніше", "Помилка відкриття");
            }
        }
    }
}
