﻿using System;
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
        private readonly List<string> tips = new List<string> {
            "У розділі Профіль можна ознайомитись зі всіма своїми публікаціями",
            "У розділі Профіль можна переглянути всі придбані нерухомості",
            "У розділі Профіль є можливість змінювати персональні дані",
            "У розділі Ринок можна додавати свої публікації",
            "У розділі Ринок можливо купувати бажану нерухомість",
            "У розділі Ринок можна сортувати та фільтрувати публікації",
            "У розділі Ринок можна виконувати пошук бажаної нерухомості",
            "У розділі Допомога можна отримати загальну інформацію щодо роботи програми",
            "У розділі Про розробників можна дізнатися більше про розробників проєкту",
        };

        private readonly Random rnd = new Random();

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
            var randomTipIndex = rnd.Next(tips.Count);
            var randomTip = tips[randomTipIndex];

            labelRandomTip.Text = randomTip;
        }
    }
}