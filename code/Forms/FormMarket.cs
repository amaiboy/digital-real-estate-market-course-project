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
        List<Listing> listings = new List<Listing> {
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
            dropdown.Items.Insert(0, hint);
            dropdown.ForeColor = System.Drawing.Color.Gray;
            dropdown.SelectedIndex = 0;
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
            reshowHint(dropdownSortByName, "Сортування за назвою");
        }

        private void dropdownSortBySeller_DropDownClosed(object sender, EventArgs e)
        {

            reshowHint(dropdownSortBySeller, "Сортування за продавцем");
        }

        private void dropdownSortByPrice_DropDownClosed(object sender, EventArgs e)
        {

            reshowHint(dropdownSortByPrice, "Сортування за ціною");
        }

        private void dropdownSortByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortByName.SelectedIndex == 0 || dropdownSortByName.SelectedIndex == 1)
                {
                    reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                    reshowHint(dropdownSortByPrice, "Сортування за ціною");
                    dropdownSortByPrice.SelectedIndex = 0;
                    dropdownSortBySeller.SelectedIndex = 0;
                }

                SortListings();
            }
            catch (Exception ex)
            {
                // GeneralException.Show(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void dropdownSortBySeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortBySeller.SelectedIndex == 0 || dropdownSortBySeller.SelectedIndex == 1)
                {
                    reshowHint(dropdownSortByName, "Сортування за назвою");
                    reshowHint(dropdownSortByPrice, "Сортування за ціною");
                    dropdownSortByName.SelectedIndex = 0;
                    dropdownSortByPrice.SelectedIndex = 0;
                }

                SortListings();
            }
            catch (Exception ex)
            {
                // GeneralException.Show(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void dropdownSortByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropdownSortByPrice.SelectedIndex == 0 || dropdownSortByPrice.SelectedIndex == 1)
                {
                    reshowHint(dropdownSortByName, "Сортування за назвою");
                    reshowHint(dropdownSortBySeller, "Сортування за продавцем");
                    dropdownSortByName.SelectedIndex = 0;
                    dropdownSortBySeller.SelectedIndex = 0;
                }

                SortListings();
            }
            catch (Exception ex)
            {
                // GeneralException.Show(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void SortListings()
        {
            var listingsCopy = listings.ToList();

            if (dropdownSortByName.SelectedIndex == 0)
            {
                listingsCopy = listings.OrderBy(l => l.Name).ToList();
            }
            else if (dropdownSortByName.SelectedIndex == 1)
            {
                listingsCopy = listings.OrderByDescending(l => l.Name).ToList();
            }

            if (dropdownSortBySeller.SelectedIndex == 0)
            {
                listingsCopy = listings.OrderBy(l => l.Seller).ToList();
            }
            else if (dropdownSortBySeller.SelectedIndex == 1)
            {
                listingsCopy = listings.OrderByDescending(l => l.Seller).ToList();
            }

            if (dropdownSortByPrice.SelectedIndex == 0)
            {
                listingsCopy = listings.OrderBy(l => l.Price).ToList();
            }
            else if (dropdownSortByPrice.SelectedIndex == 1)
            {
                listingsCopy = listings.OrderByDescending(l => l.Price).ToList();
            }

            dataGridViewListings.DataSource = listingsCopy;
        }
    }
}
