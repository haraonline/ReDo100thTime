namespace _05_StaticClassesAndMembers
{
    internal class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Count++; //this key word doesnt apply here or to the static members. It points to a specific instance of the class.
                     //Static members are shared by all instances of the class.
        }

        public static void PrintCount()
        {
            Console.WriteLine($"Count: {Count}");
        }
    }
}
