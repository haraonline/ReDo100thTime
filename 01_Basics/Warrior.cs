namespace _01_Basics
{
    public class Warrior
    {
        //These are properties and are generally for external use (values are assigned from outside the class)
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

        public Warrior(string name, int height, int weight)        
        {
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}