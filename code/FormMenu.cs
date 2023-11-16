using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using code.Forms;
using code.Classes;

namespace code
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        List<Advertisement> predefinedListings = new List<Advertisement> {
            new Advertisement {
                Name = "Однокімнатна квартира в центрі міста",
                Description = "Компактна однокімнатна квартира в самому центрі міста. Ідеально підходить для однієї людини або пари. Поруч кафе, театри та зупинки громадського транспорту.",
                Address = "вул. В'язів, 789, кв. 2, Запоріжжя",
                Price = 35000,
                Seller = "Лерой Інгрем",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Заміський будинок для сім'ї з дітьми",
                Description = "Чарівний будинок з трьома спальнями в сімейному районі. Має задній двір для ігор дітей, простору вітальню та легкий доступ до шкіл і парків.",
                Address = "провулок Дубовий, 101, Запоріжжя",
                Price = 180000,
                Seller = "Ліда Болдуін",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Будиночок на березі річки",
                Description = "Затишний будиночок біля річки, ідеально підходить для любителів природи. На вас чекає риболовля, походи та відпочинок. Інтер'єр в сільському стилі з каміном і верандою з видом на річку.",
                Address = "вул. Набережна Дніпра, 222, Запоріжжя",
                Price = 75000,
                Seller = "Еліс Пратт",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Сучасний дуплекс біля технопарку",
                Description = "Сучасний двоповерховий дуплекс біля технопарку. Відкрите планування, високоякісне оздоблення та власний задній двір. Зручно для технологічних фахівців.",
                Address = "пр-т. Технологічний, 333, Запоріжжя",
                Price = 210000,
                Seller = "Шон Болл",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Історичний таунхаус в центрі",
                Description = "Історичний таунхаус з унікальними архітектурними деталями. Чотири спальні, внутрішнє подвір'я з садом і відчуття чарівності старого світу. За декілька кроків від історичного центру міста.",
                Address = "вул. Героїв Майдану, 567, Запоріжжя",
                Price = 175000,
                Seller = "Боббі Джеймс",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Пентхаус з панорамним видом",
                Description = "Елегантний пентхаус із захоплюючим видом на місто. Розкішні зручності, включаючи терасу на даху, спа-центр та фітнес-центр. Ідеально підходить для тих, хто шукає висококласне міське життя.",
                Address = "вул. Небесної Сотні, 999, Запоріжжя",
                Price = 450000,
                Seller = "Домінік Ніл",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Заміський будиночок із земельною ділянкою",
                Description = "Просторий заміський будинок з великою територією. Ідеально підходить для тих, хто шукає спокійний сільський спосіб життя. Включає сарай, фруктовий сад і багато відкритого простору.",
                Address = "провулок Парковий, 777, Запоріжжя",
                Price = 320000,
                Seller = "Ада Бауерс",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Простора квартира з видом на Дніпро",
                Description = "Трьохкімнатна квартира з прекрасним видом на річку Дніпро. Повністю мебльована та обладнана сучасною побутовою технікою. Зручне розташування біля парку та набережної.",
                Address = "вул. Річкова, 456, Запоріжжя",
                Price = 145000,
                Seller = "Ліда Родрігес",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Компактний офіс в бізнес-центрі",
                Description = "Невеликий офіс в сучасному бізнес-центрі. Ідеальний для стартапів та малих компаній. Зручна локація поруч із ресторанами та транспортом.",
                Address = "пр-т. Бізнесовий, 123, офіс 7, Запоріжжя",
                Price = 55000,
                Seller = "Белль Х'юстон",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Сімейний будинок з басейном",
                Description = "Просторий п'ятикімнатний будинок з басейном та ландшафтним дизайном. Ідеальний для родини з дітьми. Розкішний інтер'єр та великий двір.",
                Address = "вул. Сонячна, 777, Запоріжжя",
                Price = 320000,
                Seller = "Вірджинія Берд",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Особняк у старовинному стилі",
                Description = "Величний особняк у старовинному стилі з великим подвір'ям. Шість спалень, зручності для розкішного життя та розташування в історичному районі міста.",
                Address = "провулок Старовинний, 987, Запоріжжя",
                Price = 490000,
                Seller = "Шейн Хейнс",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Модерні апартаменти у бізнес-центрі",
                Description = "Сучасні апартаменти в новому бізнес-центрі. Великий балкон з видом на місто, парковка та зручна інфраструктура. Ідеально для бізнес-подорожей.",
                Address = "пр-т. Модерністський, 555, офіс 12, Запоріжжя",
                Price = 85000,
                Seller = "Ада Осборн",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Лісовий котедж з власним ставком",
                Description = "Просторий котедж на віддаленому ділянці біля лісу. Включає великий ставок для риболовлі та човновий дім. Відмінний варіант для любителів природи.",
                Address = "вул. Лісова, 333, Запоріжжя",
                Price = 280000,
                Seller = "Джеффрі Вотсон",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Багатоквартирний комплекс біля метро",
                Description = "Сучасний багатоквартирний комплекс зі всіма зручностями поруч станції метро. Включає підземний паркінг, фітнес-центр, дитячий майданчик та крамниці.",
                Address = "проспект Метро, 25, Запоріжжя",
                Price = 255000,
                Seller = "Майкл Дуглас",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Лофт в індустріальному стилі",
                Description = "Просторий лофт з високими стелями та цегляними стінами в індустріальному стилі. Відкрите планування, великі вікна та сучасний дизайн інтер'єру.",
                Address = "вул. Фабрична, 112, Запоріжжя",
                Price = 195000,
                Seller = "Емма Стоун",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Студія в новобудові",
                Description = "Сучасна студія в новобудові з відмінним ремонтом. Ідеально підходить для молодої пари або студента.",
                Address = "вул. Студентська, 123, Запоріжжя",
                Price = 40000,
                Seller = "Олександр Сміт",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Котедж в горах",
                Description = "Просторий котедж в горах з панорамним видом. Ідеально для любителів активного відпочинку та гірського туризму.",
                Address = "вул. Гірська, 456, Запоріжжя",
                Price = 200000,
                Seller = "Ірина Шевченко",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Офіс в бізнес-центрі",
                Description = "Просторий офіс в сучасному бізнес-центрі. Ідеально підходить для IT-компанії або стартапу.",
                Address = "пр-т. IT, 789, офіс 13, Запоріжжя",
                Price = 70000,
                Seller = "Максим Петров",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Двокімнатна квартира в спальному районі",
                Description = "Затишна двокімнатна квартира в спальному районі. Поруч школа, садок та супермаркет.",
                Address = "вул. Спальна, 321, Запоріжжя",
                Price = 50000,
                Seller = "Анна Коваленко",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Вілла на березі моря",
                Description = "Розкішна вілла на березі моря з власним пляжем. Ідеально для відпочинку влітку.",
                Address = "вул. Морська, 654, Запоріжжя",
                Price = 500000,
                Seller = "Юрій Лисенко",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Пентхаус з терасою",
                Description = "Елегантний пентхаус з терасою на даху. Вид на річку, камін, джакузі та сауна. Ідеально для романтичного вечора.",
                Address = "вул. Річкова, 777, Запоріжжя",
                Price = 350000,
                Seller = "Лариса Іванова",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Садиба в селі",
                Description = "Затишна садиба в селі з великим садом. Включає гараж, альтанку, гойдалку та барбекю. Відмінний варіант для сімейного відпочинку.",
                Address = "вул. Садова, 123, Запоріжжя",
                Price = 150000,
                Seller = "Олег Кравчук",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Міні-готель біля парку",
                Description = "Модний міні-готель біля парку з чотирма номерами. Включає ресторан, бар, лобі та конференц-зал. Ідеально для малого бізнесу.",
                Address = "вул. Паркова, 456, Запоріжжя",
                Price = 400000,
                Seller = "Євген Сидоренко",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Однокімнатна квартира в центрі",
                Description = "Стильна однокімнатна квартира в центрі міста. Поруч театр, музей та кафе. Включає кондиціонер, Wi-Fi та пральну машину.",
                Address = "вул. Центральна, 234, Запоріжжя",
                Price = 60000,
                Seller = "Валерія Костенко",
                ImagePath = ""
            },
            new Advertisement {
                Name = "Дача на острові",
                Description = "Приватна дача на острові з видом на море. Включає човен, каяки та риболовне спорядження. Ідеально для пригодників.",
                Address = "вул. Острівна, 789, Запоріжжя",
                Price = 300000,
                Seller = "Сергій Мельник",
                ImagePath = ""
            }
        };
        List<User> users = new List<User>{
            new User {
                Name = "developer",
                Email = "developer@real-estate-market.com",
                Password = "developer",
                BoughtListings = new List<Advertisement> {
                    new Advertisement {
                        Name = "Квартира в центрі",
                        Description = "Квартира в центрі міста. Поруч театр, музей та кафе. Включає кондиціонер, Wi-Fi та пральну машину.",
                        Address = "вул. Центральна, 234, Запоріжжя",
                        Price = 57000,
                        Seller = "Валерія Костенко",
                        ImagePath = ""
                    },
                    new Advertisement {
                        Name = "Офіс в бізнес-центрі",
                        Description = "Офіс в бізнес-центрі. Ідеально підходить для IT-компанії або стартапу.",
                        Address = "вул. Бізнес-центральна, 123, Запоріжжя",
                        Price = 70000,
                        Seller = "Максим Петров",
                        ImagePath = ""
                    }
                },
                AddedListings = new List<Advertisement> {
                    new Advertisement {
                        Name = "Будинок біля парку",
                        Description = "Будинок біля парку з чотирма номерами. Включає ресторан, бар, лобі та конференц-зал.",
                        Address = "вул. Паркова, 456, Запоріжжя",
                        Price = 400000,
                        Seller = "developer",
                        ImagePath = ""
                    },
                    new Advertisement {
                        Name = "Однокімнатна квартира в центрі",
                        Description = "Однокімнатна квартира в центрі міста. Поруч театр, музей та кафе.",
                        Address = "вул. Центральна, 234, Запоріжжя",
                        Price = 60000,
                        Seller = "developer",
                        ImagePath = ""
                    },
                    new Advertisement {
                        Name = "Дача на острові",
                        Description = "Дача на острові з видом на море. Включає човен, каяки та риболовне спорядження.",
                        Address = "вул. Острівна, 789, Запоріжжя",
                        Price = 300000,
                        Seller = "developer",
                        ImagePath = ""
                    }
                }
            }
        };

        public FormMenu()
        {
            // Initialize the form components
            InitializeComponent();

            // Open the welcome form as the first form
            OpenChildForm(new Forms.FormWelcome(), null);

            try
            {
                // Set the current user to a new User object
                LoginManager.CurrentUser = new User();

                // Set the login status to false
                LoginManager.IsLoggedIn = false;

                // Set the available listings to the predefined listings
                GlobalData.AvailableListings = predefinedListings;

                // Set the users to the predefined users list
                GlobalData.Users = users;

                // Get the image files from the specified directory
                var imageFiles = Directory.GetFiles(@"../../../assets/images/real-estate-pictures/", "*.jpg");
                // Create a new random object
                var random = new Random();

                // Set random image paths for each predefined listing
                foreach (var ad in predefinedListings)
                {
                    ad.ImagePath = GetRandomImagePath(imageFiles, random);
                }

                // Set random images for each user's bought and added listings
                foreach (var user in users)
                {
                    SetRandomImagesForListings(user.BoughtListings, imageFiles, random);
                    SetRandomImagesForListings(user.AddedListings, imageFiles, random);
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, handle it and display an error message
                ExceptionManager.HandleException(ex, "Не вдалося завантажити дані. Спробуйте пізніше", "Помилка завантаження даних");
            }
        }

        private string GetRandomImagePath(string[] imageFiles, Random random)
        {
            // Get a random index between 0 and the length of the array
            int randomIndex = random.Next(imageFiles.Length);

            // Get the element at the random index
            string randomImageFile = imageFiles[randomIndex];

            // Return the random image file path
            return randomImageFile;
        }

        private void SetRandomImagesForListings(List<Advertisement> listings, string[] imageFiles, Random random)
        {
            // Iterate through each advertisement in the list
            foreach (var ad in listings)
            {
                // Set a random image path for the advertisement
                ad.ImagePath = GetRandomImagePath(imageFiles, random);
            }
        }

        private void ActivateButton(object btnSender)
        {
            try
            {
                // Check if btnSender is not null
                if (btnSender != null)
                {
                    // Check if currentButton is not the same as btnSender
                    if (currentButton != (Button)btnSender)
                    {
                        // Disable the currentButton
                        DisableButton();

                        // Set the currentButton to btnSender
                        currentButton = (Button)btnSender;

                        // Set the background color of currentButton to a lighter color
                        currentButton.BackColor = Color.FromArgb(64, 64, 100);

                        // Set the foreground color of currentButton to white
                        currentButton.ForeColor = Color.White;

                        // Set the font of currentButton to a larger font
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                ExceptionManager.HandleException(ex, "Не вдалося активувати кнопку. Спробуйте пізніше", "Помилка активації");
            }
        }

        private void DisableButton()
        {
            try
            {
                // Iterate through each control in the panelMenu
                foreach (Control control in panelMenu.Controls)
                {
                    // Check if the control is a Button
                    if (control is Button button)
                    {
                        // Set the background color of the button to a darker color
                        button.BackColor = Color.FromArgb(51, 51, 76);

                        // Set the foreground color (text color) of the button to a less noticeable color
                        button.ForeColor = Color.Gainsboro;

                        // Set the font of the button to a smaller font style and size
                        button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the button disabling process
                ExceptionManager.HandleException(ex, "Не вдалося деактивувати кнопку. Спробуйте пізніше", "Помилка деактивації");
            }
        }

        private void OpenChildForm(Form newForm, object buttonSender)
        {
            try
            {
                // Check if there is already an active form
                if (activeForm != null)
                {
                    // Close the active form
                    activeForm.Close();
                }

                // Activate the button that triggered the form opening
                ActivateButton(buttonSender);

                // Set the new form as the active form
                activeForm = newForm;

                // Configure the new form
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;

                // Add the new form to the panel that holds the forms
                this.panelFormContainer.Controls.Add(newForm);
                this.panelFormContainer.Tag = newForm;

                // Bring the new form to the front
                newForm.BringToFront();

                // Show the new form
                newForm.Show();
            }
            catch (Exception ex)
            {
                // Handle any exception that occurs during form opening
                ExceptionManager.HandleException(ex, "Не вдалося відкрити форму. Спробуйте пізніше", "Помилка відкриття");
            }
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            // Open the new Market form in the panel container
            OpenChildForm(new Forms.FormMarket(), sender);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Open the new Help form in the panel container
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            // Open the new Developers form in the panel container
            OpenChildForm(new Forms.FormDevelopers(), sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            // Open the new Profile form in the panel container
            OpenChildForm(new Forms.FormProfile(), sender);
        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            // Open the new Welcome form in the panel container
            OpenChildForm(new Forms.FormWelcome(), sender);
        }
    }
}
