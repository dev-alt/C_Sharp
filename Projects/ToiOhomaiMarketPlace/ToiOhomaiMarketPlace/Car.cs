namespace ToiOhomaiMarketPlace
{
    public class Car : Listing
    {

        public string CarRego { get; set; }

        public string CarListingInfo()
        {
            
            return ListingTitle + ",\t" + CarRego + ",\t" + ListingPrice + ",\t" + Condition;
            // Returns the listing information for the car


        }
    }
}