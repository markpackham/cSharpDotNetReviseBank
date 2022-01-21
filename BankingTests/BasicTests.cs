using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
             Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Bob", 10000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(999999, DateTime.Now, "Attempt to go over overdraf")
                );
        }
    }
}