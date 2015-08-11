
namespace _02.BankAccounts
{
    using System;

    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalcInterestAmount(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months cannot be less than zero");
            }
            else if (this.Customer is Individual)
            {
                numberOfMonths -= 3;
            }
            else if (this.Customer is Company)
            {
                numberOfMonths -= 2;
            }
            return base.CalcInterestAmount(numberOfMonths);
        }    
    }
}
