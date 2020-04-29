using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Default, parameterless constructor.
        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overloading the constructor.
        // We can use the "this" keyword to specify any of the other
        // constructors that we would like to pass the control to.
        public Customer(int id) : this()
        {// We take what we get from the outside and
         // initialise the respective fields with it.
            this.Id = id;
        }

        // Overloading the constructor.
        // We can use the "this" keyword to specify any of the other
        // constructors that we would like to pass the control to.
        public Customer(int id, string name) : this(id)
        {// We take what we get from the outside and
         // initialise the respective fields with it.
            this.Name = name;
        }
    }
}
