namespace ToiOhomaiMarketPlace
{
    public class Property : Listing
    {
        
        public string City { get; set; }

        public int NumBedrooms { get; set; }

        public string Suburb { get; set; }

        public string PropertyListingInfo()
        {
            return ListingTitle + ", \t" + ListingPrice.ToString("$0.00") + ", \t " + Condition + ", \t" + City + ", \t" + Suburb + ", \t" + NumBedrooms;
            // Return a string with the property listing information
        }
    }
}