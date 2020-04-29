using System;

namespace Constructors
{
    // We inherit from the Vehicle class.
    public class Car : Vehicle
    {
        // We pass a variable to target a specific
        // constructor in the Vehicle class.
        // Note that the parameterless constructor
        // is not being executed because of this.
        public Car(string registrationNumber)
         : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }
    }
}
