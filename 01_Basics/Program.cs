using System.Globalization;

namespace _01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior();
            goodGuy.Name = "Bahu";
            goodGuy.Height = 180;
            goodGuy.Weight= 90;
            goodGuy.Introduce();
            

            Warrior badGuy = new Warrior();
            badGuy.Name = "Bhalla";
            badGuy.Height= 200;
            badGuy.Weight = 100;
            badGuy.Introduce();
        }
    }

    public class Warrior
    {
        //These are properties and are generally for external use (values are assigned outside the class)

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //These are fields and are for internal use only
        public string country = "Magadha";
        public int population = 3_050;

        //Methods
        public void Introduce()
        {
            Console.WriteLine($"Inroducting {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Rajyam: {country}");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }       

    }
}