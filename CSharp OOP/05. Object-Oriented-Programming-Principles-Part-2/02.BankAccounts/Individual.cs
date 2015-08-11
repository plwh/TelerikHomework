
namespace _02.BankAccounts
{
    public class Individual : Customer
    {
        public Individual(string name)
            :base(name)
        { 

        }

        public override string ToString()
        {
           return "Individual";
        }
    }
}
