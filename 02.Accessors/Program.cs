namespace _02_Accessors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("Bank of America", "123 Main St.", 17);            
            Console.WriteLine(bank);
        }
    }
}