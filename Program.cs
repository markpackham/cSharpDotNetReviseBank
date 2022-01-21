// See https://aka.ms/new-console-template for more information
using MySuperBank;

var account = new BankAccount("Bob",10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with £{account.Balance}.");

account.MakeWithdrawal(2000, DateTime.Now, "Car");
account.MakeDeposit(20000, DateTime.Now, "Won Lottery");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
Console.WriteLine($"£{account.Balance}");

Console.WriteLine(account.GetAccountHistory());
