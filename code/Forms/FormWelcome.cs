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
        private List<string> tips = new List<string> {
            "У секції Профіль можна переглянути всі публікації, які ви створили",
            "У секції Профіль можна переглянути всі нерухомості, які ви придбали",
            "У секції Профіль можна змінити персональні дані",
            "У секції Ринок можна додавати свої публікації",
            "У секції Ринок можна купувати нерухомість",
            "У секції Ринок можна сортувати та фільтрувати публікації",
            "У секції Ринок можна шукати бажану нерухомість",
            "У секції Ринок можна шукати бажану нерухомість",
            "У секції Допомога можна отримати загальну інформацію про ринок",
            "У секції Про розробників можна дізнатися більше про розробників",
        };

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
