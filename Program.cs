// See https://aka.ms/new-console-template for more information
using MySuperBank;

var account = new BankAccount("Bob",10000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with £{account.Balance}.");
