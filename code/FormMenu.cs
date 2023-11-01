using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Forms;

namespace code
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        List<Listing> predefinedListings = new List<Listing> {
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
            },
            new Listing {
                Name = "Багатоквартирний комплекс біля метро",
                Description = "Сучасний багатоквартирний комплекс зі всіма зручностями поруч станції метро. Включає підземний паркінг, фітнес-центр, дитячий майданчик та крамниці.",
                Address = "проспект Метро, 25, Запоріжжя",
                Price = 255000,
                Seller = "Майкл Дуглас"
            },
            new Listing {
                Name = "Лофт в індустріальному стилі",
                Description = "Просторий лофт з високими стелями та цегляними стінами в індустріальному стилі. Відкрите планування, великі вікна та сучасний дизайн інтер'єру.",
                Address = "вул. Фабрична, 112, Запоріжжя",
                Price = 195000,
                Seller = "Емма Стоун"
            },
            new Listing {
                Name = "Студія в новобудові",
                Description = "Сучасна студія в новобудові з відмінним ремонтом. Ідеально підходить для молодої пари або студента.",
                Address = "вул. Студентська, 123, Запоріжжя",
                Price = 40000,
                Seller = "Олександр Сміт"
            },
            new Listing {
                Name = "Котедж в горах",
                Description = "Просторий котедж в горах з панорамним видом. Ідеально для любителів активного відпочинку та гірського туризму.",
                Address = "вул. Гірська, 456, Запоріжжя",
                Price = 200000,
                Seller = "Ірина Шевченко"
            },
            new Listing {
                Name = "Офіс в бізнес-центрі",
                Description = "Просторий офіс в сучасному бізнес-центрі. Ідеально підходить для IT-компанії або стартапу.",
                Address = "пр-т. IT, 789, офіс 13, Запоріжжя",
                Price = 70000,
                Seller = "Максим Петров"
            },
            new Listing {
                Name = "Двокімнатна квартира в спальному районі",
                Description = "Затишна двокімнатна квартира в спальному районі. Поруч школа, садок та супермаркет.",
                Address = "вул. Спальна, 321, Запоріжжя",
                Price = 50000,
                Seller = "Анна Коваленко"
            },
            new Listing {
                Name = "Вілла на березі моря",
                Description = "Розкішна вілла на березі моря з власним пляжем. Ідеально для відпочинку влітку.",
                Address = "вул. Морська, 654, Запоріжжя",
                Price = 500000,
                Seller = "Юрій Лисенко"
            },
            new Listing {
                Name = "Пентхаус з терасою",
                Description = "Елегантний пентхаус з терасою на даху. Вид на річку, камін, джакузі та сауна. Ідеально для романтичного вечора.",
                Address = "вул. Річкова, 777, Запоріжжя",
                Price = 350000,
                Seller = "Лариса Іванова"
            },
            new Listing {
                Name = "Садиба в селі",
                Description = "Затишна садиба в селі з великим садом. Включає гараж, альтанку, гойдалку та барбекю. Відмінний варіант для сімейного відпочинку.",
                Address = "вул. Садова, 123, Запоріжжя",
                Price = 150000,
                Seller = "Олег Кравчук"
            },
            new Listing {
                Name = "Міні-готель біля парку",
                Description = "Модний міні-готель біля парку з чотирма номерами. Включає ресторан, бар, лобі та конференц-зал. Ідеально для малого бізнесу.",
                Address = "вул. Паркова, 456, Запоріжжя",
                Price = 400000,
                Seller = "Євген Сидоренко"
            },
            new Listing {
                Name = "Однокімнатна квартира в центрі",
                Description = "Стильна однокімнатна квартира в центрі міста. Поруч театр, музей та кафе. Включає кондиціонер, Wi-Fi та пральну машину.",
                Address = "вул. Центральна, 234, Запоріжжя",
                Price = 60000,
                Seller = "Валерія Костенко"
            },
            new Listing {
                Name = "Дача на острові",
                Description = "Приватна дача на острові з видом на море. Включає човен, каяки та риболовне спорядження. Ідеально для пригодників.",
                Address = "вул. Острівна, 789, Запоріжжя",
                Price = 300000,
                Seller = "Сергій Мельник"
            }
        };

        public FormMenu()
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormWelcome(), null);
            UserSession.CurrentUser = new User();
            UserSession.IsLoggedIn = false;
            UserSession.AvailableListings = this.predefinedListings;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(64, 64, 100);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void OpenChildForm(Form newForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(buttonSender);
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            this.panelFormContainer.Controls.Add(newForm);
            this.panelFormContainer.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMarket(), sender);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDevelopers(), sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProfile(), sender);
        }
    }
}
