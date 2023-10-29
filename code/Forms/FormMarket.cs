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
        readonly List<Listing> listings = new List<Listing> {
            new Listing {
                Name = "Однокімнатна квартира в центрі міста",
                Description = "Компактна однокімнатна квартира в самому центрі міста. Ідеально підходить для однієї людини або пари. Поруч кафе, театри та зупинки громадського транспорту.",
                Address = "вул. В'язів, 789, кв. 2, Запоріжжя",
                Price = 35000,
                Seller = "Лерой Інгрем"
            },
            new Listing {
                Name = "Заміський будинок для сім'ї з дітьми",
                Description = "Чарівний будинок з трьома спальнями в сімейному районі. Має задній двір для ігор дітей, простору вітальню та легкий доступ до шкіл і парків.",
                Address = "провулок Дубовий, 101, Запоріжжя",
                Price = 180000,
                Seller = "Ліда Болдуін"
            },
            new Listing {
                Name = "Будиночок на березі річки",
                Description = "Затишний будиночок біля річки, ідеально підходить для любителів природи. На вас чекає риболовля, походи та відпочинок. Інтер'єр в сільському стилі з каміном і верандою з видом на річку.",
                Address = "вул. Набережна Дніпра, 222, Запоріжжя",
                Price = 75000,
                Seller = "Еліс Пратт"
            },
            new Listing {
                Name = "Сучасний дуплекс біля технопарку",
                Description = "Сучасний двоповерховий дуплекс біля технопарку. Відкрите планування, високоякісне оздоблення та власний задній двір. Зручно для технологічних фахівців.",
                Address = "пр-т. Технологічний, 333, Запоріжжя",
                Price = 210000,
                Seller = "Шон Болл"
            },
            new Listing {
                Name = "Історичний таунхаус в центрі",
                Description = "Історичний таунхаус з унікальними архітектурними деталями. Чотири спальні, внутрішнє подвір'я з садом і відчуття чарівності старого світу. За декілька кроків від історичного центру міста.",
                Address = "вул. Героїв Майдану, 567, Запоріжжя",
                Price = 175000,
                Seller = "Боббі Джеймс"
            },
            new Listing {
                Name = "Пентхаус з панорамним видом",
                Description = "Елегантний пентхаус із захоплюючим видом на місто. Розкішні зручності, включаючи терасу на даху, спа-центр та фітнес-центр. Ідеально підходить для тих, хто шукає висококласне міське життя.",
                Address = "вул. Небесної Сотні, 999, Запоріжжя",
                Price = 450000,
                Seller = "Домінік Ніл"
            },
            new Listing {
                Name = "Заміський будиночок із земельною ділянкою",
                Description = "Просторий заміський будинок з великою територією. Ідеально підходить для тих, хто шукає спокійний сільський спосіб життя. Включає сарай, фруктовий сад і багато відкритого простору.",
                Address = "провулок Парковий, 777, Запоріжжя",
                Price = 320000,
                Seller = "Ада Бауерс"
            },
            new Listing {
                Name = "Простора квартира з видом на Дніпро",
                Description = "Трьохкімнатна квартира з прекрасним видом на річку Дніпро. Повністю мебльована та обладнана сучасною побутовою технікою. Зручне розташування біля парку та набережної.",
                Address = "вул. Річкова, 456, Запоріжжя",
                Price = 145000,
                Seller = "Ліда Родрігес"
            },
            new Listing {
                Name = "Компактний офіс в бізнес-центрі",
                Description = "Невеликий офіс в сучасному бізнес-центрі. Ідеальний для стартапів та малих компаній. Зручна локація поруч із ресторанами та транспортом.",
                Address = "пр-т. Бізнесовий, 123, офіс 7, Запоріжжя",
                Price = 55000,
                Seller = "Белль Х'юстон"
            },
            new Listing {
                Name = "Сімейний будинок з басейном",
                Description = "Просторий п'ятикімнатний будинок з басейном та ландшафтним дизайном. Ідеальний для родини з дітьми. Розкішний інтер'єр та великий двір.",
                Address = "вул. Сонячна, 777, Запоріжжя",
                Price = 320000,
                Seller = "Вірджинія Берд"
            },
            new Listing {
                Name = "Особняк у старовинному стилі",
                Description = "Величний особняк у старовинному стилі з великим подвір'ям. Шість спалень, зручності для розкішного життя та розташування в історичному районі міста.",
                Address = "провулок Старовинний, 987, Запоріжжя",
                Price = 490000,
                Seller = "Шейн Хейнс"
            },
            new Listing {
                Name = "Модерні апартаменти у бізнес-центрі",
                Description = "Сучасні апартаменти в новому бізнес-центрі. Великий балкон з видом на місто, парковка та зручна інфраструктура. Ідеально для бізнес-подорожей.",
                Address = "пр-т. Модерністський, 555, офіс 12, Запоріжжя",
                Price = 85000,
                Seller = "Ада Осборн"
            },
            new Listing {
                Name = "Лісовий котедж з власним ставком",
                Description = "Просторий котедж на віддаленому ділянці біля лісу. Включає великий ставок для риболовлі та човновий дім. Відмінний варіант для любителів природи.",
                Address = "вул. Лісова, 333, Запоріжжя",
                Price = 280000,
                Seller = "Джеффрі Вотсон"
            }
        };

        public FormMarket()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

            dataGridViewListings.DataSource = listings;
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

        private void btnExecuteSearch_Click(object sender, EventArgs e)
        {
            var searchQuery = txtSearch.Text;
            var filteredList = listings.Where(l => l.Name.Contains(searchQuery) || l.Description.Contains(searchQuery));
            dataGridViewListings.DataSource = filteredList.ToList();
        }

        private void dataGridViewListings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var listing = (Listing)dataGridViewListings.SelectedRows[0].DataBoundItem;
            ListingForm listingForm = new ListingForm(listing);
            listingForm.ShowDialog();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Пошук за назвою чи описом...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = System.Drawing.Color.Black;
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
        private void QuickSort(string type,List<Listing> list)
        {
       
                Sort(list, 0, list.Count - 1, type);
        }
        private void Sort(List<Listing> list, int left, int right, string type)
        {
            if(left<right)
            {
                int pivotIndex = Partition(list, left, right, type);
                Sort(list, left, pivotIndex - 1, type);
                Sort(list, pivotIndex + 1, right, type);
            }
        }
        private int Partition(List<Listing> list, int left, int right, string type)
        {
            if(type == "Ціна")
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

            var listingsCopy = listings.ToList();
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
