// See https://aka.ms/new-console-template for more information

using BankyStuffLibrary;
using Humanizer;

Console.WriteLine("car".Pluralize());
Console.WriteLine("cat".Pluralize());
Console.WriteLine("octopus".Pluralize());
Console.WriteLine(321.ToWords());


var account = new BankAccount("Bob",10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with £{account.Balance}.");

account.MakeWithdrawal(1000, DateTime.Now, "Car");
account.MakeDeposit(20000, DateTime.Now, "Won Lottery");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
account.MakeWithdrawal(5, DateTime.Now, "Noodles");
account.MakeWithdrawal(9995, DateTime.Now, "Super Noodles");
Console.WriteLine($"£{account.Balance}");

Console.WriteLine(account.GetAccountHistory());
