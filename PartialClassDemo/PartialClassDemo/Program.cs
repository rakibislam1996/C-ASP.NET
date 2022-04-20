using System;

namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "John";
            customer.LastName = "Cena";
            Console.WriteLine(customer.FullName());
            customer.isActive = true;
            customer.CustomerStatus();
        }
    }
}
