using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

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
        public static async Task sendVerificationCodeToEmail(string toEmail, string verificationCode)
        {
            string mailFrom = "realestateapp@ukr.net";
            string password = "XI56uR64bNjtfvsg";

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Real Estate App Bot", mailFrom));
            message.To.Add(new MailboxAddress("Recipient", toEmail));
            message.Subject = "Верифікація вашої поштової скриньки";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Ваш код верифікації: {verificationCode}";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync(mailFrom, password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        // функція, що генерує випадковий пароль
        public static string generateNewPassword()
        {
            int length = 12;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_+=<>?";
            StringBuilder newPassword = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                newPassword.Append(chars[index]);
            }

            return newPassword.ToString();
        }

        public static async Task sendNewPasswordToEmail(string toEmail, string newPassword)
        {
            string mailFrom = "realestateapp@ukr.net";
            string password = "XI56uR64bNjtfvsg";

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Real Estate App Bot", mailFrom));
            message.To.Add(new MailboxAddress("Recipient", toEmail));
            message.Subject = "Новий пароль від вашого аккаунту";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Ваш новий пароль: {newPassword}\nЗа потреби можете його змінити у особистому кабінеті.";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync(mailFrom, password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
