namespace Testability
{
    public interface IShippingCalculator
    { // This interface defines the capability that a class should provide.
        float CalculateShipping(Order order);
    }

    // ShippingCalculator implements IShippingCalculator
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
