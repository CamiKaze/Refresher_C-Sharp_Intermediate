using System.Collections.Generic;

namespace Fields
{
    public class Customer
    { // Using readonly, if you accidently reset the field, 
      // the "Orders" list will still hold the information.
      // This is now the only place where "Orders" can be initialised.
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            
        }
    }
}
