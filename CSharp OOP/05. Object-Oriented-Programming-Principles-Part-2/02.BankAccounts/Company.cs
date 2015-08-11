
namespace _02.BankAccounts
{
    using System;

    public class Company : Customer
    {
        public Company(string name)
            :base(name)
        {

        }

        public override string ToString()
        {
            return "Company";
        }
    }
}
