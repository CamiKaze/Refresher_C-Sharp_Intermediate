using System;

namespace Fields
{
    // We cab use Read Only to make sure that a field is only
    // assigned once. This means that the field can be initialised
    // directly, or through one of the constructors of the class.
    // We do this to create some sort of safety in our application
    // to improve robustness.
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
