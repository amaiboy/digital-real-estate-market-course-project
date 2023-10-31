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
    public partial class FormMarket : Form
    {
        public FormMarket()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            dataGridViewListings.DataSource = UserSession.AvailableListings;
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

        public void AddListing(Listing listing)
        {
            var updatedListings = UserSession.AvailableListings.ToList();
            updatedListings.Add(listing);
            UserSession.AvailableListings = updatedListings;
            dataGridViewListings.DataSource = UserSession.AvailableListings;
        }

        public void RemoveListing(Listing listing)
        {
            var updatedListings = UserSession.AvailableListings.ToList();
            updatedListings.Remove(listing);
            UserSession.AvailableListings = updatedListings;
            dataGridViewListings.DataSource = UserSession.AvailableListings;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchQuery = txtSearch.Text;
            var filteredList = UserSession.AvailableListings.Where(l => l.Name.Contains(searchQuery) || l.Description.Contains(searchQuery));
            dataGridViewListings.DataSource = filteredList.ToList();
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
            var listing = (Listing)dataGridViewListings.SelectedRows[0].DataBoundItem;
            FormListing listingForm = new FormListing(listing, this);
            listingForm.ShowDialog();
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
            if (!dropdown.Items.Contains(hint))
            {
                dropdown.Items.Insert(0, hint);
                dropdown.ForeColor = System.Drawing.Color.Gray;
                dropdown.SelectedIndex = 0;
            }
        }

        private void hideHint(ComboBox dropdown, string hint)
        {
            if (dropdown.Items.Contains(hint))
            {
                dropdown.Items.Remove(hint);
                dropdown.ForeColor = System.Drawing.Color.Black;
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
            if (dropdownSortByName.SelectedItem.ToString() != "Сортування за назвою")
            {
                SortListings(dropdownSortByName);

                reshowHint(dropdownSortByPrice, "Сортування за ціною");
                dropdownSortByPrice.SelectedIndex = 0;

                reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                dropdownSortBySeller.SelectedIndex = 0;
            }
        }

        private void dropdownSortByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownSortByPrice.SelectedItem.ToString() != "Сортування за ціною")
            {
                SortListings(dropdownSortByPrice);

                reshowHint(dropdownSortByName, "Сортування за назвою");
                dropdownSortByName.SelectedIndex = 0;

                reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                dropdownSortBySeller.SelectedIndex = 0;
            }
        }

        private void dropdownSortBySeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownSortBySeller.SelectedItem.ToString() != "Сортування за продавцем")
            {
                SortListings(dropdownSortBySeller);

                reshowHint(dropdownSortByPrice, "Сортування за ціною");
                dropdownSortByPrice.SelectedIndex = 0;

                reshowHint(dropdownSortByName, "Сортування за назвою");
                dropdownSortByName.SelectedIndex = 0;
            }
        }

        private void QuickSort(string type, List<Listing> list)
        {
            Sort(list, 0, list.Count - 1, type);
        }

        private void Sort(List<Listing> list, int left, int right, string type)
        {
            if (left < right)
            {
                int pivotIndex = Partition(list, left, right, type);
                Sort(list, left, pivotIndex - 1, type);
                Sort(list, pivotIndex + 1, right, type);
            }
        }

        private int Partition(List<Listing> list, int left, int right, string type)
        {
            if (type == "Ціна")
            {
                int pivot = list[right].Price;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if (list[j].Price < pivot)
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            if (type == "Назва")
            {
                string pivot = list[right].Name;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if ((string.Compare(list[j].Name, pivot) < 0))
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            if (type == "Продавець")
            {
                string pivot = list[right].Seller;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if ((string.Compare(list[j].Seller, pivot) < 0))
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            return 0;
        }

        private void QuickSortDescending(string type, List<Listing> list)
        {
            SortDescending(list, 0, list.Count - 1, type);
        }

        private void SortDescending(List<Listing> list, int left, int right, string type)
        {
            if (left < right)
            {
                int pivotIndex = PartitionDescending(list, left, right, type);
                SortDescending(list, left, pivotIndex - 1, type);
                SortDescending(list, pivotIndex + 1, right, type);
            }
        }

        private int PartitionDescending(List<Listing> list, int left, int right, string type)
        {
            if (type == "Ціна")
            {
                int pivot = list[right].Price;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if (list[j].Price > pivot)
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            if (type == "Назва")
            {
                string pivot = list[right].Name;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if ((string.Compare(list[j].Name, pivot) > 0))
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            if (type == "Продавець")
            {
                string pivot = list[right].Seller;
                int i = left - 1;
                Listing temp;
                for (int j = left; j < right; j++)
                {
                    if ((string.Compare(list[j].Seller, pivot) > 0))
                    {
                        i++;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                temp = list[i + 1];
                list[i + 1] = list[right];
                list[right] = temp;
                return i + 1;
            }
            return 0;
        }

        private void SortListings(ComboBox dropdown)
        {
            var nameHeading = "Назва";
            var sellerHeading = "Продавець";
            var priceHeading = "Ціна";

            var listingsCopy = UserSession.AvailableListings.ToList();
            var selectedItem = dropdown.SelectedIndex;

            if (dropdown == dropdownSortByName)
            {
                if (selectedItem == 0)
                {
                    QuickSort(nameHeading, listingsCopy);
                    nameHeading = "Назва »";
                }
                else
                {
                    QuickSortDescending(nameHeading, listingsCopy);
                    nameHeading = "Назва «";
                }
            }
            else if (dropdown == dropdownSortBySeller)
            {
                if (selectedItem == 0)
                {
                    QuickSort(sellerHeading, listingsCopy);
                    sellerHeading = "Продавець »";
                }
                else
                {
                    QuickSortDescending(sellerHeading, listingsCopy);
                    sellerHeading = "Продавець «";
                }
            }
            else if (dropdown == dropdownSortByPrice)
            {
                if (selectedItem == 0)
                {
                    QuickSort(priceHeading, listingsCopy);
                    priceHeading = "Ціна »";
                }
                else
                {
                    QuickSortDescending(priceHeading, listingsCopy);
                    priceHeading = "Ціна «";
                }
            }

            dataGridViewListings.DataSource = listingsCopy;
            dataGridViewListings.Columns[0].HeaderText = nameHeading;
            dataGridViewListings.Columns[3].HeaderText = sellerHeading;
            dataGridViewListings.Columns[4].HeaderText = priceHeading;
        }
    }
}
