using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        // метод для генерації коду веріфікаціїї з 6 букв та цифр
        public static string generateVerificationCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] code = new char[6];

            for (int i = 0; i < code.Length; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }

            return new string(code);
        }

        // метод для відправлення сгенерованого коду верифікації на пошту
        static void sendVerificationCodeToEmail(string toEmail, string verificationCode)
        {
            string fromWhichEmail = "digital-real-estate-market-email@gmail.com";
            string letterSubject = "Your email verification";
            string textBody = $"Your verification code is: {verificationCode}";

            using (MailMessage mail = new MailMessage(fromWhichEmail, toEmail, letterSubject, textBody))
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential(fromWhichEmail, "your-password");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
