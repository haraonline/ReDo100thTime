namespace _08_Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Jonathan";
            person.LastName = "Doe";
            person.WorksOn = DayOfTheWeek.Monday | DayOfTheWeek.Tuesday | DayOfTheWeek.Wednesday | DayOfTheWeek.Thursday | DayOfTheWeek.Friday;
            Console.WriteLine(person);

            var anotherPerson = new Person();
            anotherPerson.FirstName = "Jane";
            anotherPerson.LastName = "Smith";
            anotherPerson.WorksOn = DayOfTheWeek.Monday | DayOfTheWeek.Tuesday | DayOfTheWeek.Wednesday;
            Console.WriteLine(anotherPerson);

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