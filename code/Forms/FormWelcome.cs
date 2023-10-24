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
    public partial class FormWelcome : Form
    {
        private List<string> tips = new List<string>();
        private Random rnd = new Random();

        public FormWelcome()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            DisplayRandomTip();
        }

        private void DisplayRandomTip()
        {
            // TODO: add exception handling
            int randomTipIndex = rnd.Next(tips.Count);
            string randomTip = tips[randomTipIndex];

            labelRandomTip.Text = randomTip;
        }
    }
}
