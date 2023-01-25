using System;

namespace MySuperBank
{
    class Program
    {

        static void Main(string[] args)
        {
            var account = new BankAccount("Maki", 10000);
            Console.WriteLine($"account {account.Number} was created for{account.Owner} with {account.Balance}.");
            Console.WriteLine($"test..,");

        }


    }
}
