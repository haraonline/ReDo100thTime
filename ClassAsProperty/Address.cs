namespace _03_ClassAsProperty
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }        

        public Address(string street, string city)
        {
            Street = street;
            City= city;            
        }

        public override string ToString()
        {
            return $"{Street}, {City}";
        }

        public string GetFullAddress()
        {
            return $"{Street}, {City}";
        }
    }
}
