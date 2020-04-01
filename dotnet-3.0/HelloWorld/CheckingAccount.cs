using System;

namespace HelloWorld
{
    public class CheckingAccount
    {
        public double Balance { get; set; }
        public string Name { get; set; }

        public CheckingAccount(string name, double currentBalance)
        {
            Name = name;
            Balance = currentBalance;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException(amount.ToString(), "Withdrawal exceeds balance!");
            }
        }
    }
}
