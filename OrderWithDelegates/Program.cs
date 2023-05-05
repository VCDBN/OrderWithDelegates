using OrderWithDelegates;

internal class Program
{
    private static void Main(string[] args)
    {
        OrderProcessor orderProcessor = new OrderProcessor();

        Customer customer = new Customer(orderProcessor);
        customer.Name = "Chuck Norris";

        Order order = new Order { OrderNumber = 12345, CustomerName = customer.Name, ShippingAddress = "12 Radar Drive" };
        orderProcessor.ConfirmOrder(order);
        orderProcessor.ShipOrder(order);
    }
}