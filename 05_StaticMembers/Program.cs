namespace _05_StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 30);
            Console.WriteLine(p1);
            Person p2 = new Person("Anita", "Kimmel", 25);
            Person p3 = new Person("Jack", "Ryan", 20);
            Person p4 = new Person("Jill", "Mendoz", 15);
            Person p5 = new Person("Jenny", "Swarznegger", 10);
            Person p6 = new Person("Mary", "Littlelamb", 10);
            Console.WriteLine(p6);
            
            Person p7 = new Person("Monika", "Schmidt", 10);
            Person p8 = new Person("Antonio", "Fukua", 10);
            Person.PrintCount();
            Person p9 = new Person("Hara guchi", "Mai", 10);
            Person p10 = new Person("Tina", "Munim", 10);

            Person.PrintCount();
        }
    }
}