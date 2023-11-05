using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
