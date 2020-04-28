using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Cameron");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            // Object Initializer is a syntax for quickly
            // initialising an object without the need
            // to call one of its constructors.
            // We do this to avoid creating multiple constructors.
            var customer1 = new Customer
            { // Object initialisation syntax is when we assign
              // the name of properties and assign them some
              // intial value.
                Id = 1,
                Name = "Cameron"
            };
        }
    }
}
