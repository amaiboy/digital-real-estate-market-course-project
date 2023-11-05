using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code.Classes
{
    // клас, що виконує логування, обробку винятків
    public static class ExceptionManager
    {
        public static void HandleException(Exception ex, string body, string heading)
        {
            Console.WriteLine(ex.Message);

            MessageBox.Show($"{body}.\nДодаткова інформація: {ex.Message}", heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowConfirmation(string body, string heading)
        {
            DialogResult result = MessageBox.Show(body, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void ShowSuccess(string body, string heading)
        {
            MessageBox.Show(body, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
