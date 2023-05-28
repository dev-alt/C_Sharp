namespace ToiOhomaiMarketPlace
{
    public class MarketPlace : Listing
    {
        
        
        private string description;

        
        public string MarketListingInfo()
        {
            return ListingTitle + ",\t" + ListingPrice.ToString("$0.00") + ",\t" + Condition + ",\t" + description;
            // returns the listing title, price, condition and description
        }


        /// <summary>
        /// Constructor for MarketPlace
        /// </summary>
        /// <param name="desc"></param>
        public MarketPlace(string desc)
        {
            description = desc;
        }
    }
}