namespace _07_StaticClassesAndSingletons
{
    internal static class StaticTools
    {
        public static void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);            
            Console.ResetColor();

            //static classes are singletons
            //they can only have static members
            //they cannot be instantiated            
        }
    }
}
