using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace code.Classes
{
    // клас, що відповідає за считування/зберігання даних з файлів
    public static class FileHandler
    {
        //Метод для запису даних нового користувача в кінець CSV файлу.
        public static void userFileWriter(string login, string password, string email)
        {
            string csvFilePath = "users.csv";

            using (StreamWriter writer = new StreamWriter(csvFilePath, true))
            {
                writer.WriteLine(login + "," + password + "," + email);
            }
        }

        //Метод для пошуку даних конкретного користувача в CSV файлі за логіном.
        public static string[] searchInUserFile(string login)
        {
            string csvFilePath = "users.csv";

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values[0] == login)
                    {
                        return values;
                    }

                }
                return null;
            }
        }

        //Класи для роботи с JSON.
        public class PropertyData
        {
            public PropertyObj[] PropertyObj { get; set; }
        }
        public class PropertyObj
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Address { get; set; }
            public int Price { get; set; }
            public string Seller { get; set; }
        }


        //Метод для пошуку даних конкретної нерухомості в JSON файлі за назвою.
        public static PropertyObj searchInPropertyFile(string propertyName)
        {
            string jsonFilePath = "property.json";

            string jsonText = File.ReadAllText(jsonFilePath);

            PropertyData propertyArr = JsonConvert.DeserializeObject<PropertyData>(jsonText);

            for (int i = 0; i < propertyArr.PropertyObj.Length; i++)
            {
                PropertyObj property1 = propertyArr.PropertyObj[i];
                if (property1.Name == propertyName)
                {
                    PropertyObj property2 = property1;
                    return property2;
                }
            }

            return null;
        }

        //Метод для запису даних нової нерухомості в кінець JSON файлу.
        public static void propertyFileWriter(string Name, string Description, string Address, int Price, string Seller)
        {
            string jsonFilePath = "property.json";

            PropertyData newPropertyArr = new PropertyData
            {
                PropertyObj = new PropertyObj[]
                {
                    new PropertyObj
                    {
                        Name = Name,
                        Description = Description,
                        Address = Address,
                        Price = Price,
                        Seller = Seller
                    },
                }
            };

            string jsonText = File.ReadAllText(jsonFilePath);

            string newJsonString = jsonText.Substring(0, jsonText.Length - 8);

            string newJsonString2 = newJsonString + ",\r\n    {\r\n      \"Name\": \"" + Name + "\",\r\n      \"Description\": \"" + Description + "\",\r\n      \"Address\": \"" + Address + "\",\r\n      \"Price\": " + Price + ",\r\n      \"Seller\": \"" + Seller + "\"\r\n    }\r\n  ]\r\n}";

            File.WriteAllText(jsonFilePath, newJsonString2);
        }

    }
}
