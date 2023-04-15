namespace _08_Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.WorksOn = DayOfTheWeek.Monday | DayOfTheWeek.Tuesday | DayOfTheWeek.Wednesday | DayOfTheWeek.Thursday | DayOfTheWeek.Friday;
            Console.WriteLine(person);

        }      
    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DayOfTheWeek WorksOn { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " works on " + WorksOn;
        }
    }    
}