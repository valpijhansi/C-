namespace Aggregation
{
    public class Address
    {
        public string village, city, state, country;
        public Address() { }
        public Address(string village, string city, string state, string country)
        {
            this.village = village;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
    
}
