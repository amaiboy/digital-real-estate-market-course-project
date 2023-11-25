using System.Collections.Generic;
using System.ComponentModel;

namespace code.Classes
{
    // клас, що відповідає за збереження активних даних в момент виконання програми
    public static class GlobalData
    {
        public static BindingList<Advertisement> AvailableListings { get; set; }
        public static List<User> Users { get; set; }
    }
}
