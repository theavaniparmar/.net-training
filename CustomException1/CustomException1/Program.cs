using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException1
{
    public class FundException: Exception
    {
        public FundException() : base("not Much fund in your account.") { }

        public FundException(string message) : base(message) { } 

        public FundException(string message, Exception innerException) : base( message, innerException) { }
    }
     public class Bank
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public Bank(string accountholder, double balance)
        {
            AccountHolder = accountholder;
            Balance = balance;
        }

        public void withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new FundException($"Amount: {amount} \n balance {Balance} \n balance is insufficient");
            }
            Balance -= amount;
            Console.WriteLine($"withdrawal successful! \n balance you have: {Balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank("Riya", 700);
                bank.withdraw(500);
            }
            catch(FundException fe)
            {
                Console.WriteLine($"Error: {fe.Message}");
            }
            Console.ReadKey();
        }
    }
}
