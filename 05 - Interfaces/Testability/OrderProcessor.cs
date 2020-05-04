using System;

namespace Testability
{
    // OrderProcessor does not know about ShippingClaculator, it just knows
    // that there is a class that can fulfill that need.
    public class OrderProcessor
    {
        // Instead of being dependent on a conrete class, we want to depend
        // on an interface.
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // _shippingCalculator = new ShippingCalculator();
            // Now there is no reference to the ShippingCalculator concrete
            // class. We are just referencing an interface.
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
