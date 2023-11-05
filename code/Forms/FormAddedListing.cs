﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormAddedListing : Form
    {
        public FormAddedListing(Advertisement listing)
        {
            InitializeComponent();

            try
            {
                this.Text = listing.Name;
                lblName.Text = listing.Name;
                lblSeller.Text = $"Це ваше оголошення";
                lblDescription.Text = listing.Description;
                lblAddress.Text = listing.Address;
                lblPrice.Text = $"{listing.Price} ₴";
                lblDateLastViewed.Text = $"Останній раз переглянуто {DateTime.Now:dd.MM.yyyy}";
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося завантажити деталі оголошення. Спробуйде закрити розділ і повторити спробу", "Помилка завантаження даних");
            }
        }
    }
}
