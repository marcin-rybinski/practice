using System;
using Xunit;

namespace XUnitTestsPractice
{
    public class DebitCard
    {
        private int _balance;

        public void Withdraw(int amount)
        {
            if (amount > _balance) throw new ArgumentOutOfRangeException();
            _balance -= amount;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public int GetBalance()
        {
            return _balance;
    }
    }

    public class DebitCardShould
    {
        private DebitCard _sut;
        public DebitCardShould()
        {
            _sut = new DebitCard();
            _sut.Deposit(10);
        }
        [Fact]
        public void AddDepositAmountToBalance()
        {
            var actual = _sut.GetBalance();
            Assert.Equal(10,actual);
        }

        [Fact]
        public void WithdrawCorrectAmount()
        {
            _sut.Withdraw(10);
            var actual = _sut.GetBalance();
            Assert.Equal(0,actual);
        }

        [Fact]
        public void GetCorrectBalance()
        {
            Assert.Equal(10,_sut.GetBalance());
        }

        [Fact]
        public void ThrowExceptionWhenWithdrawAmountIsBiggerThanBalance()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=> _sut.Withdraw(11));
        }
    }
}
