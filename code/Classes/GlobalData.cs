using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    // клас, що відповідає за збереження активних даних в момент виконання програми
    public static class GlobalData
    {
        public static List<Advertisement> AvailableListings { get; set; }
        public static List<User> Users { get; set; }
    }
}
