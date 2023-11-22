using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace code.Classes
{
    // клас, що відповідає за перевірку даних, входу до системи та
    // кодування й декодування паролю
    public static class LoginManager
    {
        public static bool IsLoggedIn
        {
            get; set;
        }
        public static User CurrentUser
        {
            get; set;
        }

        // метод для гешування паролю
        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder hashedPassword = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    hashedPassword.Append(hashedBytes[i].ToString("x2"));
                }

                return hashedPassword.ToString();
            }
        }

        // метод для перевірки совпадіння гешу з введенним паролем
        public static bool verifyPassword(string password, string hashedPassword)
        {
            string hashedInput = hashPassword(password);
            return string.Equals(hashedInput, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
