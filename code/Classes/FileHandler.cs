﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;
using System.Configuration;

namespace code.Classes
{
    // клас, що відповідає за считування/зберігання даних з файлів
    public static class FileHandler
    {
        // метод для запису даних до CSV файлу з 
        // BindingList<Advertisement>
        public static void saveAdToCSV(BindingList<Advertisement> writeFromList, string filepath = null)
        {
            if (filepath == null)
            {
                string assemblyLocation = Assembly.GetExecutingAssembly().Location;
                string previousDirectory = Path.GetDirectoryName(Path.GetDirectoryName(assemblyLocation));
                string previousDirectory_final = Path.GetDirectoryName(Path.GetDirectoryName(previousDirectory));
                string databaseDirectory = Path.Combine(previousDirectory_final, "code", "DataBase");
                filepath = Path.Combine(databaseDirectory, "advertisment.csv");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (var item in writeFromList)
                    {
                        string CSV_line = $"{item.Name}|{item.Description}|{item.Price}|{item.Address}|" +
                            $"{item.Seller}|{item.ImagePath}";
                        writer.WriteLine(CSV_line);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося записати дані в файл.", "Помилка запису даних");
            }
        }

        // метод для зчитування даних до BindingList<Advertisement>
        // з CSV файлу
        public static BindingList<Advertisement> readAdFromCSV(string filepath = null)
        {
            if (filepath == null)
            {
                string assemblyLocation = Assembly.GetExecutingAssembly().Location;
                string previousDirectory = Path.GetDirectoryName(Path.GetDirectoryName(assemblyLocation));
                string previousDirectory_final = Path.GetDirectoryName(Path.GetDirectoryName(previousDirectory));
                string databaseDirectory = Path.Combine(previousDirectory_final, "code", "DataBase");
                filepath = Path.Combine(databaseDirectory, "advertisment.csv");
            }

            BindingList<Advertisement> readToList = new BindingList<Advertisement>();
            try
            {
                string[] CSV_lines = File.ReadAllLines(filepath);
                for (int i = 0; i < CSV_lines.Length; i++)
                {
                    string[] CSV_data = CSV_lines[i].Split('|');

                    Advertisement advertisement = new Advertisement();
                    advertisement.Name = CSV_data[0];
                    advertisement.Description = CSV_data[1];
                    advertisement.Price = int.Parse(CSV_data[2]);
                    advertisement.Address = CSV_data[3];
                    advertisement.Seller = CSV_data[4];
                    advertisement.ImagePath = CSV_data[5];

                    readToList.Add(advertisement);
                }
                return readToList;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося зчитати дані з файлу.", "Помилка зчитування даних");
                return null;
            }
        }

        // клас для роботи з JSON
        public class UserObj
        {
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string BoughtListingsFilePath { get; set; }
            public string AddedListingsFilePath { get; set; }
        }

        // метод для запису даних User
        public static void UserFileWriter(List<User> writeFromList)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string previousDirectory = Path.GetDirectoryName(Path.GetDirectoryName(assemblyLocation));
            string previousDirectory_final = Path.GetDirectoryName(Path.GetDirectoryName(previousDirectory));
            string databaseDirectory = Path.Combine(previousDirectory_final, "code", "DataBase");
            string filePath = Path.Combine(databaseDirectory, "users.json");

            try
            {
                List<UserObj> writeList = new List<UserObj>();
                foreach (var item in writeFromList)
                {
                    UserObj user = new UserObj();
                    user.UserId = item.UserId;
                    user.Name = item.Name;
                    user.Email = item.Email;
                    user.Password = item.Password;
                    user.BoughtListingsFilePath = Path.Combine(databaseDirectory, $"user_{user.UserId}_BoughtListings.csv");
                    saveAdToCSV(item.BoughtListings, user.BoughtListingsFilePath);
                    user.AddedListingsFilePath = Path.Combine(databaseDirectory, $"user_{user.UserId}_AddedListings.csv");
                    saveAdToCSV(item.AddedListings, user.AddedListingsFilePath);
                    writeList.Add(user);
                }

                string json = JsonConvert.SerializeObject(writeList, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося записати дані в файл.", "Помилка запису даних");
            }
        }

        // метод для зчитування даних User
        public static List<User> UserFileReader()
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string previousDirectory = Path.GetDirectoryName(Path.GetDirectoryName(assemblyLocation));
            string previousDirectory_final = Path.GetDirectoryName(Path.GetDirectoryName(previousDirectory));
            string databaseDirectory = Path.Combine(previousDirectory_final, "code", "DataBase");
            string filePath = Path.Combine(databaseDirectory, "users.json");

            try
            {
                List<UserObj> readList = new List<UserObj>();
                string json = File.ReadAllText(filePath);
                readList = JsonConvert.DeserializeObject<List<UserObj>>(json);

                List<User> users = new List<User>();
                foreach (var item in readList)
                {
                    User user = new User();
                    user.UserId = item.UserId;
                    user.Name = item.Name;
                    user.Email = item.Email;
                    user.Password = item.Password;
                    user.BoughtListings = readAdFromCSV(Path.Combine(databaseDirectory, $"user_{user.UserId}_BoughtListings.csv"));
                    user.AddedListings = readAdFromCSV(Path.Combine(databaseDirectory, $"user_{user.UserId}_AddedListings.csv"));
                    users.Add(user);
                }

                return users;
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex, "Не вдалося зчитати дані з файлу.", "Помилка зчитування даних");
                return null;
            }
        }
    }
}
