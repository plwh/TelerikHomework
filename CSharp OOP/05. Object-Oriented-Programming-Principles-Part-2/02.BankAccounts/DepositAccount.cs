
namespace _02.BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdrawal, IDeposit
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public void WithdrawAmount(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("Withdrawal amount cannot be higher than balance in acount");
            }
            this.Balance -= amount;
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalcInterestAmount(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                throw new ArgumentOutOfRangeException("Interest rate cannot be calculated if balance is more than 0 and less than 1000");
            }
            return base.CalcInterestAmount(numberOfMonths);
        }    
    }
}
