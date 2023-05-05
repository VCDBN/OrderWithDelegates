using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWithDelegates
{
    public class OrderProcessor
    {
        public delegate void OrderConfirmedEventHandler(Order order);
        public event OrderConfirmedEventHandler OrderConfirmed;

        public delegate void OrderShippedEventHandler(Order order);
        public event OrderShippedEventHandler OrderShipped;

        public void ConfirmOrder(Order order)
        {
            OrderConfirmed.Invoke(order);
            // Add code here to write order to DB, etc.
        }

        public void ShipOrder(Order order)
        {
            OrderShipped.Invoke(order);
            // Add code here to write shipping to DB, let courier know, etc.
        }
    }

}
