namespace _07_StaticClassesAndSingletons
{
    internal static class StaticTools
    {
        public static void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);            
            Console.ResetColor();
        }        
    }
}
