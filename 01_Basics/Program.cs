using _01_Basics.GameCharacters;

namespace _01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior(name: "Bahu", height: 180, weight: 90);
            Warrior badGuy = new Warrior(name: "Bhalla", height: 200, weight: 100);

            goodGuy.Introduce();
            badGuy.Introduce();
            goodGuy.ShakesHand(goodGuy, badGuy);
        }
    }
}