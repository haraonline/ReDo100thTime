namespace _10_Encapsulation
{
    internal class BankAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if (value >= 0)         
                    _balance = value;                
            }
        }
        public string Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
                
            return $"deposited {amount}, your new balance is {Balance}";
        }

        public string Withdraw(decimal amount)            
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return $"withdrawing {amount}, your new balance is {Balance}";
            }
            else
            {
                return $"Insufficient balance - Balance: {Balance}, Withdrawl requested: {amount}";
            }
        }
    }
}
