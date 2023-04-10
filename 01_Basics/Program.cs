namespace _01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior();
            goodGuy.Height = 180;
            goodGuy.Weight= 90;
            

            Warrior badGuy = new Warrior();
            badGuy.Height= 200;
            badGuy.Weight = 100;         

        }
    }

    public class Warrior
    {
        //these are properties and are generally for external use (values are assigned outside the class)
        public int Height { get; set; }
        public int Weight { get; set; }

        //these are fields and are for internal use only
        public string country = "Magadha";
        public int population = 3_050;


        
    }
}