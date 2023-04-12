namespace _02_Accessors
{
    public class Bank
    {
        public string Name { get; set; }
        public string Address { get; private set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument: Age, Age must be between 18 and 100");
                };
            }
        }


        public Bank(string name, string address, int age)
        {
            Name = name;
            Address = address;
            Age = age;
        }

        public void ChangeAddress(string newAddress)
        {
            Address = newAddress;
        }

        public override string ToString()
        {
            return $"Bank Name: {Name}, Address: {Address}, Age: {Age}";
        }
    }    
}