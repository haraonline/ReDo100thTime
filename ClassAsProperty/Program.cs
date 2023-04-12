namespace ClassAsProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address("123 Main St", "Hamburg");
            Person person1 = new Person("John", "Doe", new DateTime(1980, 1, 1), addr1);
            Console.WriteLine(person1);
        }
    }
}