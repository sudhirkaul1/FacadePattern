namespace FacadePatternApp.Bank;
using FacadePatternApp.Customer;

public class Bank
{
    public bool HasSufficientSavings(Customer customer , int amount) 
    {
        System.Console.WriteLine($"Check customer has sufficient Funds {customer.FirstName} ");
        return true;
    } 
}
