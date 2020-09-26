using System;
using BankLibrary;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nora", 230000);
            var account1 = new BankAccount("Lenon", 540000);
            Console.WriteLine($"Account {account.Number} is owned by {account.Owner} with {account.Balance} balance");
            Console.WriteLine($"Account {account1.Number} is owned by {account1.Owner} with {account1.Balance} balance");

            account.MakeWithdrawal(12.6m, DateTime.Now, "Buying tuna");
            account.MakeWithdrawal(19, DateTime.Now, "Buying lock");
            account.MakeWithdrawal(125, DateTime.Now, "Buying boots");
            account.MakeWithdrawal(120, DateTime.Now, "Buying toy");

            account.MakeDeposit(3400, DateTime.Now, "Wage saving");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
