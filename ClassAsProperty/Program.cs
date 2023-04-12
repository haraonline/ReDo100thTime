namespace _03.ClassAsProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address addr1 = new Address("123 Main St", "Hamburg");
            Person person1 = new Person("John", "Doe", new DateTime(1980, 1, 1), addr1);
            Console.WriteLine(person1.HomeAddress.Street);
            Console.WriteLine(person1.HomeAddress.City);
            Console.WriteLine(person1.HomeAddress.GetFullAddress());
            Console.WriteLine();
            Console.WriteLine(person1);

            /*To access the properties and methods of a class thats is declared as a property of another class,
            we use the dot operator to access the members of class that was declared as a property*/
        }
    }
}
