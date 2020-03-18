using System;
using Xunit;
using lab02;

namespace XUnitTestLab02
{
    public class UnitTest1
    {
        [Fact]
        public void CanDeposit()
        {
            Assert.True(Program.Deposit(5));
        }

        [Fact]
        public void CantDepositNegative()
        {
            Assert.False(Program.Deposit(-5));
        }

        [Fact]
        public void DepositIsCorrect()
        {
            Program.Balance = 200;

            Program.Deposit(20);

            Assert.Equal(220, Program.Balance);
        }

        [Fact]
        public void CanWithdraw()
        {
            Program.Balance = 200;

            Program.Withdraw(20);

            Assert.Equal(180, Program.Balance);
        }

        [Fact]
        
        public void CannotWithdraw()
        {
            Program.Balance = 200;

            Program.Withdraw(220);

            Assert.Equal(200, Program.Balance);
        }
    }
}
