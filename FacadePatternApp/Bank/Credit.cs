namespace FacadePatternApp.Bank;
using FacadePatternApp.Customer;

public class Credit
{
     public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.FirstName);
            return true;
        }
}