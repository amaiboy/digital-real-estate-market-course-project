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
        private readonly Forms.FormMarket formMarket;

        public User()
        {
            BoughtListings = new List<Listing>();
            AddedListings = new List<Listing>();
        }

        public User(FormMarket formMarket)
        {
            BoughtListings = new List<Listing>();
            AddedListings = new List<Listing>();
            this.formMarket = formMarket;
        }

        public User(string name, string email, string password, Forms.FormMarket formMarket)
        {
            Name = name;
            Email = email;
            Password = password;
            BoughtListings = new List<Listing>();
            AddedListings = new List<Listing>();
            this.formMarket = formMarket;
        }

        public void BuyListing(Listing listing)
        {
            // Add the listing to the user's bought listings
            BoughtListings.Add(listing);
            // Remove the listing from the market
            formMarket.RemoveListing(listing);
        }

        public void AddListing(Listing listing)
        {
            // Add the listing to the user's added listings
            AddedListings.Add(listing);
            // Add the listing to the market
            formMarket.AddListing(listing);
        }
    }
}
