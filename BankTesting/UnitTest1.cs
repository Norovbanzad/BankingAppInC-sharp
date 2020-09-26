using System;
using Xunit;
using BankLibrary;

namespace BankTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void OverDrawTest()
        {
            //// Test for a negative balance.
      
            var account = new BankAccount("V", 234000);

            // With smaller amount than the initial balance, the test will fail.
            // With bigger amount test will pass.

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(750000, DateTime.Now, "Attempt to overdraw")
                );   
        }

        [Fact]
        public void PositiveInitialBalance()
        {
            //// Test that the initial balances must be positive.

            // Test will fail with positive number.
            // With negative number testing will pass.

            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", -55)
                );
        }
    }
}
