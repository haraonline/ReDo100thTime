namespace _04_ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person("John");
            Person p3 = new Person("John", 25);
            Person p4 = new Person("John", 25, "123 Main St");

            p1.Address = "123 Main St";
            p1.Age = 25;
            p1.Name = "John";

            p2.Address = "123 Main St";
            p2.Age = 25;

            p3.Address = "123 Main St";

            System.Console.WriteLine("p1: {0}, {1}, {2}", p1.Name, p1.Age, p1.Address);
            System.Console.WriteLine("p2: {0}, {1}, {2}", p2.Name, p2.Age, p2.Address);
            System.Console.WriteLine("p3: {0}, {1}, {2}", p3.Name, p3.Age, p3.Address);
            System.Console.WriteLine("p4: {0}, {1}, {2}", p4.Name, p4.Age, p4.Address);
            
            



            System.Console.ReadLine();
        }
    }
}