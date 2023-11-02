using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code.Forms;

namespace code
{
    // клас користувача
    public class User
    {
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        // TODO: Add password hashing
        public string Password
        {
            get; set;
        }
        public List<Advertisement> BoughtListings
        {
            get; set;
        }
        public List<Advertisement> AddedListings
        {
            get; set;
        }

        public User()
        {
            BoughtListings = new List<Advertisement>();
            AddedListings = new List<Advertisement>();
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            BoughtListings = new List<Advertisement>();
            AddedListings = new List<Advertisement>();
        }
    }
}
