/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account
using the appropriate data types and descriptive names. */

using System;

class BankAccountData
{
    static void Main()
    {       
        string firstName = "Harve";
        string middleName = "Bertie";
        string lastName = "Morgan";
        int accountBalance = 5000;
        string bankName = "UnicreditBulbank";
        string iban = "BG00BNBG76611020345658";
        long firstCreditCardNumber = 4652700256450402;
        long secondCreditCardNumber = 5512967236764205;
        long thirdCreditCardNumber = 3448689202253446;
         Console.WriteLine(@"
Account holder name:{0} {1} {2}
Account balance:{3}lv
Bank name:{4}
IBAN:{5}
Credit cards:
1.{6}
2.{7}
3.{8}",firstName,middleName,lastName,accountBalance,bankName,iban,firstCreditCardNumber,secondCreditCardNumber,thirdCreditCardNumber);

    }

    
}
