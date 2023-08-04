namespace FacadePatternApp.Bank;
using FacadePatternApp.Customer;

public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.FirstName);
            return true;
        }
    }