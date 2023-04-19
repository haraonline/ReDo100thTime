namespace _12_Polymorphism
{
    internal class DiverseCollections
    {        
        public int[] arrNumbers = new int[5] { 1, 2, 3, 4, 5 };
        public string[] arrSnacks = new string[5] { "Cookies", "Pastries", "Biscuits", "Chocolates", "Chips" };
        public List<string> listDrinks = new List<string>() { "Whisky", "Beer", "Rum", "Vodka", "Wine" };
        public List<int> listEvens = new List<int>() { 2,4,6,8,10 };


        public static void IterateOver<T>(IEnumerable<T> collection)
        {
            Console.WriteLine($"Type: {collection.GetType()}");
            foreach (var item in collection)
            {
                Console.WriteLine($"Value: {item}");
            }
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }   
}
