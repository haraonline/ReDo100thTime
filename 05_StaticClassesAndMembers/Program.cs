namespace _05_StaticClassesAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 30);
            Person p2 = new Person("Jane", "Doe", 25);
            Person p3 = new Person("Jack", "Doe", 20);
            Person p4 = new Person("Jill", "Doe", 15);
            Person p5 = new Person("Jenny", "Doe", 10);
            Person p6 = new Person("Jenny", "Doe", 10);
            Person p7 = new Person("Jenny", "Doe", 10);
            Person p8 = new Person("Jenny", "Doe", 10);
            Person.PrintCount();
            Person p9 = new Person("Jenny", "Doe", 10);
            Person p10 = new Person("Jenny", "Doe", 10);

            Person.PrintCount();
        }
    }
}