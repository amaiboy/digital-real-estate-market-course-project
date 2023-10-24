using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class Listing
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public string Seller { get; set; }

        public Listing(string name, int price, string address, string seller)
        {
            Name = name;
            Price = price;
            Address = address;
            Seller = seller;
        }
    }
}
