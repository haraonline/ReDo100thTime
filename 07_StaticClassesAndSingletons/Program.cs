namespace _07_StaticClassesAndSingletons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Doe", 123456789);
            Person p2 = new Person("Jane", "Doe", 987654321);

            StaticTools.WriteInColor(p1.ReturnInstanceAsText(), ConsoleColor.Green);
            StaticTools.WriteInColor(p2.ReturnInstanceAsText(), ConsoleColor.Red);
        }
    }
}