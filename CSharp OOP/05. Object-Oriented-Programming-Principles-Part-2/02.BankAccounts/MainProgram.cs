/* A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals 
or companies. All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money. All accounts can calculate their interest amount for a given period (in months). In the common 
case its is calculated as follows: number_of_months * interest_rate. Loan accounts have no interest for the first 3 months if are held by 
individuals and for the first 2 months if are held by a company. Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals. Your task is to 
write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions 
and implement the calculation of the interest functionality through overridden methods. */

namespace _02.BankAccounts
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Company microsoft = new Company("Microsoft");
            Individual gosho = new Individual("Gosho");

            DepositAccount depositTest = new DepositAccount(microsoft, 100000, 15);
            MortgageAccount mortgageTest = new MortgageAccount(gosho, 400, 20);

            Console.WriteLine("Customer type:{0}\nCustomer name: {1}",gosho.ToString(),gosho.Name);
            Console.WriteLine("Initial mortgage account balance:{0}lv",mortgageTest.Balance);
            mortgageTest.DepositAmount(30);
            Console.WriteLine("Account balance after adding 30 lv:{0}lv\n",mortgageTest.Balance);

            Console.WriteLine("Customer type:{0}\nCustomer name: {1}",microsoft.ToString(), microsoft.Name);
            Console.WriteLine("Initial deposit account balance:{0}lv",depositTest.Balance);
            depositTest.WithdrawAmount(30000);
            Console.WriteLine("Account balance after withdrawing 30000lv:{0}lv", depositTest.Balance);
            Console.WriteLine("Account interest amount for twelve months:{0}lv\n", depositTest.CalcInterestAmount(12));
        }
    }
}
