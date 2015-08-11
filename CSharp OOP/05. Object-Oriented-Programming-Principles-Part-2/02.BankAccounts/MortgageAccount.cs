
namespace _02.BankAccounts
{
    using System;

    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalcInterestAmount(int numberOfMonths)
        {
            
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }
                return this.InterestRate * numberOfMonths;
            }
            else if (this.Customer is Company)
            {
                if (numberOfMonths <= 12)
                {
                    return (this.InterestRate * numberOfMonths) / 2; 
                }
                return this.InterestRate * numberOfMonths;              
            }
            return 0;
        }
    }
}
