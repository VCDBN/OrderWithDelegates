using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWithDelegates
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(OrderProcessor orderProcessor)
        {
            orderProcessor.OrderConfirmed += OnOrderConfirmed;
            orderProcessor.OrderShipped += OnOrderShipped;
        }

        private void OnOrderConfirmed(Order order)
        {
            Console.WriteLine($"Order {order.OrderNumber} confirmed for {Name}");
            // Add code to send an email, notification, sms, etc.
        }

        private void OnOrderShipped(Order order)
        {
            Console.WriteLine($"Order {order.OrderNumber} shipped to {order.ShippingAddress}");
            // Add code to send an email, notification, sms, etc.
        }
    }

}
