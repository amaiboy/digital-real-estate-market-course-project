using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using code.Classes;

namespace code.Forms
{
    public partial class FormMarket : Form
    {
        public FormMarket()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            dataGridViewListings.DataSource = GlobalData.AvailableListings;
            dataGridViewListings.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            Padding cellPadding = new Padding(5, 5, 5, 5);
            dataGridViewListings.ColumnHeadersDefaultCellStyle.Padding = cellPadding;
            foreach (DataGridViewColumn column in dataGridViewListings.Columns)
            {
                column.DefaultCellStyle.Padding = cellPadding;
            }

            dropdownSortByName.SelectedIndex = 0;
            dropdownSortBySeller.SelectedIndex = 0;
            dropdownSortByPrice.SelectedIndex = 0;
        }

        public void AddListing(Advertisement listing)
        {
            try
            {
                var updatedListings = GlobalData.AvailableListings;
                updatedListings.Add(listing);
                GlobalData.AvailableListings = updatedListings;
                dataGridViewListings.DataSource = GlobalData.AvailableListings;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося додати об'єкт. Спробуйте ще раз пізніше", "Помилка додавання об'єкту");
            }
        }

        public void RemoveListing(Advertisement listing)
        {
            try
            {
                var updatedListings = GlobalData.AvailableListings;
                updatedListings.Remove(listing);
                GlobalData.AvailableListings = updatedListings;
                dataGridViewListings.DataSource = GlobalData.AvailableListings;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося видалити об'єкт. Спробуйте ще раз пізніше", "Помилка видалення об'єкту");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchQuery = txtSearch.Text;
            try
            {
                var filteredList = GlobalData.AvailableListings.Where(l => l.Name.Contains(searchQuery) || l.Description.Contains(searchQuery));
                dataGridViewListings.DataSource = filteredList.ToList();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Помилка при пошуку оголошення. Спробуйте ще раз пізніше", "Помилка пошуку об'єкту");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Пошук за назвою чи описом...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void dataGridViewListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var listing = (Advertisement)dataGridViewListings.SelectedRows[0].DataBoundItem;
                FormBuyListing listingForm = new FormBuyListing(listing, this);
                listingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте ще раз пізніше", "Помилка відкриття форми");
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call the same method or perform the same operation as btnSearch does
                btnSearch_Click(sender, e);

                // Prevent the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void reshowHint(ComboBox dropdown, string hint)
        {
            try
            {
                if (!dropdown.Items.Contains(hint))
                {
                    dropdown.Items.Insert(0, hint);
                    dropdown.ForeColor = System.Drawing.Color.Gray;
                    dropdown.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося показати підказку.", "Помилка показу підказки");
            }
        }

        private void hideHint(ComboBox dropdown, string hint)
        {
            try
            {
                if (dropdown.Items.Contains(hint))
                {
                    dropdown.Items.Remove(hint);
                    dropdown.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося приховати підказку.", "Помилка приховання підказки");
            }
        }

        private void dropdownSortByName_DropDown(object sender, EventArgs e)
        {
            hideHint(dropdownSortByName, "Сортування за назвою");
        }

        private void dropdownSortBySeller_DropDown(object sender, EventArgs e)
        {
            hideHint(dropdownSortBySeller, "Сортування за продавцем");
        }

        private void dropdownSortByPrice_DropDown(object sender, EventArgs e)
        {
            hideHint(dropdownSortByPrice, "Сортування за ціною");
        }

        private void dropdownSortByName_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdownSortByName.SelectedIndex == -1)
            {
                reshowHint(dropdownSortByName, "Сортування за назвою");
            }
        }

        private void dropdownSortBySeller_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdownSortBySeller.SelectedIndex == -1)
            {
                reshowHint(dropdownSortBySeller, "Сортування за продавцем");
            }
        }

        private void dropdownSortByPrice_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdownSortByPrice.SelectedIndex == -1)
            {
                reshowHint(dropdownSortByPrice, "Сортування за ціною");
            }
        }

        private void dropdownSortByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortByName.SelectedItem.ToString() != "Сортування за назвою")
                {
                    Classes.AlgorithmManager.SortManager.SortListings(dropdownSortByName, "byName", dataGridViewListings);

                    reshowHint(dropdownSortByPrice, "Сортування за ціною");
                    dropdownSortByPrice.SelectedIndex = 0;

                    reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                    dropdownSortBySeller.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відсортування оголошення", "Помилка сортування");
            }
        }

        private void dropdownSortByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortByPrice.SelectedItem.ToString() != "Сортування за ціною")
                {
                    Classes.AlgorithmManager.SortManager.SortListings(dropdownSortByPrice, "byPrice", dataGridViewListings);

                    reshowHint(dropdownSortByName, "Сортування за назвою");
                    dropdownSortByName.SelectedIndex = 0;

                    reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                    dropdownSortBySeller.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відсортування оголошення", "Помилка сортування");
            }
        }

        private void dropdownSortBySeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortBySeller.SelectedItem.ToString() != "Сортування за продавцем")
                {
                    Classes.AlgorithmManager.SortManager.SortListings(dropdownSortBySeller, "bySeller", dataGridViewListings);

                    reshowHint(dropdownSortByPrice, "Сортування за ціною");
                    dropdownSortByPrice.SelectedIndex = 0;

                    reshowHint(dropdownSortByName, "Сортування за назвою");
                    dropdownSortByName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося відсортування оголошення", "Помилка сортування");
            }
        }
    }
}
