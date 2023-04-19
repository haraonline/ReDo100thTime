namespace _10_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            string deposit = account.Deposit(1000);
            string w1 = account.Withdraw(25);            
            string w2 = account.Withdraw(2000);


            Console.WriteLine(deposit);
            Console.WriteLine(w1);
            Console.WriteLine("Balance: " + account.Balance);
            Console.WriteLine(w2);
            Console.WriteLine("Balance: " + account.Balance);
        }
    }
}