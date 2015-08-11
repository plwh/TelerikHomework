
namespace _02.BankAccounts
{
    using System;

    public class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer user, decimal balance, decimal interestRate)
        {
            this.Customer = user;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public virtual decimal CalcInterestAmount(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }
    }
}
