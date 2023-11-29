using System;
using System.ComponentModel;

namespace code.Classes
{
    // клас користувача
    public class User
    {
        public string UserId
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
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
            UserId = Guid.NewGuid().ToString();
            BoughtListings = new BindingList<Advertisement>();
            AddedListings = new BindingList<Advertisement>();
        }

        public User(string name, string email, string password)
        {
            UserId = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Password = password;
            BoughtListings = new BindingList<Advertisement>();
            AddedListings = new BindingList<Advertisement>();
        }
    }
}
