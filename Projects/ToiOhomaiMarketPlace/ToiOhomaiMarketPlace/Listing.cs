using System;

namespace ToiOhomaiMarketPlace
{
    public class Listing
    {
        
        private int code;
        protected string fullinfo;
        private Random gen = new Random();

        // properties
        public string Condition { get; set; }
        public double ListingPrice { get; set; }
        public string ListingTitle { get; set; }

        public Listing()
        {
            code = gen.Next(100000, 999999);
            // Constructor for Listing that generates a random code
        }
    }
}