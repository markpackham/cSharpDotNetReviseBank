using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueIsTrue()
        {
             Assert.True(true);
        }

        [Fact]
        public void RejectGoingOverOverdraft()
        {
            var account = new BankAccount("Bob", 10000);

            Assert.Throws<InvalidOperationException>(
                // () => reminds me of JavaScript
                () => account.MakeWithdrawal(999999, DateTime.Now, "Attempt to go over overdraf")
                );
        }

        [Fact]
        public void RejectNativeMoney()
        {
            var account = new BankAccount("Bob", 10000);

            Assert.Throws<ArgumentOutOfRangeException>(
                // () => reminds me of JavaScript
                () =>  new BankAccount("Attempt to go use negative money",-30)
                );
        }
    }
}