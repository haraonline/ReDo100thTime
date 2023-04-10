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

            goodGuy.ShakesHand(goodGuy, badGuy);
        }
    }

    public class Warrior
    {
        //These are properties and are generally for external use (values are assigned outside the class)

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //These are fields and are for internal use only
        private readonly string country = "Magadha";
        private readonly int population = 3_050;

        //Methods
        public void Introduce()
        {
            Console.WriteLine($"Inroducting {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Population: {population}");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        public void ShakesHand(Warrior w1, Warrior w2)
        {
            Console.WriteLine($"{w1.Name} says hello to {w2.Name}");
            Console.WriteLine();
        }
    }
}