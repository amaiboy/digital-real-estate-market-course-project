using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code.Forms;

namespace code
{
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
        public List<Listing> BoughtListings
        {
            get; set;
        }
        public List<Listing> AddedListings
        {
            get; set;
        }

        public User()
        {
            BoughtListings = new List<Listing>();
            AddedListings = new List<Listing>();
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            BoughtListings = new List<Listing>();
            AddedListings = new List<Listing>();
        }
    }
}
