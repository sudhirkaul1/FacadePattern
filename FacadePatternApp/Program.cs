// See https://aka.ms/new-console-template for more information
using FacadePatternApp.Customer;
using FacadePatternApp.Facade;

Console.WriteLine("Hello, World!");

Mortgage mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
Customer customer = new("Ann","McKinsey");
bool eligible = mortgage.IsEligible(customer, 125000);
Console.WriteLine("\n" + customer.FirstName +
        " has been " + (eligible ? "Approved" : "Rejected"));
// Wait for user
Console.ReadKey();