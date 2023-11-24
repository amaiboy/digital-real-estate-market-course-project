using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code.Forms;

namespace code.Classes
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
        public BindingList<Advertisement> BoughtListings
        {
            get; set;
        }
        public BindingList<Advertisement> AddedListings
        {
            get; set;
        }

        public User()
        {
            BoughtListings = new BindingList<Advertisement>();
            AddedListings = new BindingList<Advertisement>();
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            BoughtListings = new BindingList<Advertisement>();
            AddedListings = new BindingList<Advertisement>();
        }
    }
}
